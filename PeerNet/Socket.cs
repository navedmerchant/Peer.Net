using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using WebSocketSharp;

namespace PeerNet
{
	/// <summary>
	/// Encapsulates the connection to the peer server, using websockets.
	/// </summary>
	public class Socket
	{
		private Uri wsUri;
		private bool disconnected;
		private WebSocket webSocket;
		private string id;

		public delegate void MessageArrivedEventHandler (object sender, SocketMessageEventArgs args);

		public delegate void SocketErrorMessageHandler (object sender, ErrorEventArgs args);

		public event MessageArrivedEventHandler MessageArrived;
		public event EventHandler SocketClosed;
		public event EventHandler SocketOpened;
		public event SocketErrorMessageHandler SocketError;

		public Socket (string host, int port, string path, string key)
		{
			string wsProtocol = "ws://";
			wsUri = new Uri (wsProtocol + host + ":" + port + path + "peerjs?key=" + key);
		}

		public void Start (string id, string token)
		{
			this.id = id;
			String tempuri = wsUri.AbsoluteUri + "&id=" + id + "&token=" + token.ToLower ();
			this.wsUri = new Uri (tempuri);
			StartWebSocket ();
		}

		private void StartWebSocket ()
		{
			webSocket = new WebSocket (wsUri.AbsoluteUri);
			webSocket.Connect ();
			webSocket.OnOpen += WebSocket_OnOpen;
			webSocket.OnMessage += WebSocket_OnMessage;
			webSocket.OnClose += WebSocket_OnClose;
			webSocket.OnError += WebSocket_OnError;
		}

		private void WebSocket_OnError (object sender, ErrorEventArgs e)
		{
			OnSocketError (e);
		}

		protected virtual void OnMessageArrived (SocketMessageEventArgs e)
		{
			MessageArrivedEventHandler handler = MessageArrived;
			if (handler != null) {
				handler (this, e);
			}
		}

		protected virtual void OnSocketClosed (EventArgs e)
		{
			EventHandler handler = SocketClosed;
			if (handler != null) {
				handler (this, e);
			}
		}

		protected virtual void OnSocketOpened (EventArgs e)
		{
			EventHandler handler = SocketOpened;
			if (handler != null) {
				handler (this, e);
			}
		}

		protected virtual void OnSocketError (ErrorEventArgs e)
		{
			SocketErrorMessageHandler handler = SocketError;
			if (handler != null) {
				handler (this, e);
			}
		}

		private void WebSocket_OnClose (object sender, CloseEventArgs e)
		{
			this.disconnected = true;
			OnSocketClosed (EventArgs.Empty);
		}

		private void WebSocket_OnMessage (object sender, MessageEventArgs e)
		{
			SocketMessageEventArgs eventArgs = new SocketMessageEventArgs ();
			eventArgs.Message = e.Data;
			OnMessageArrived (eventArgs);
		}

		private void WebSocket_OnOpen (object sender, EventArgs e)
		{
			this.disconnected = false;
			OnSocketOpened (EventArgs.Empty);
		}

		public void Send (string message)
		{
			webSocket.Send (message);
		}

		public void Close ()
		{
			webSocket.Close ();
		}

	}

	public class SocketMessageEventArgs : EventArgs
	{
		public string Message { get; set; }
	}

}