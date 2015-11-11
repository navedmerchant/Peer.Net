using Org.Webrtc;
using Android.Util;
using System;
using Java.Nio.Charset;

namespace PeerNet
{
    public class DataConnection
	{
		public bool Open{ get; set;}
		public Peer Peer{ get; set;}
		public Peer Provider { get; set;}
		public string Id{ get; set;}
		public string Type{ get; set;}
		public DataChannel Channel{ get; set;}
		public PeerConnection Connection{ get; set;}
		public DataConnectionOptions DataConnectionOptions{ get; set;}
		Negotiator negotiator;

		public delegate void MessageArrivedEventHandler(object sender, MessageArgs messageArgs);

		public event EventHandler DataConnectionOpened;
		public event EventHandler DataConnctionClosed;
		public event MessageArrivedEventHandler MessageArrived;


		public DataConnection(Peer peer, Peer provider, DataConnectionOptions dataConnectionOptions){
			Type = "data";
			this.Peer = peer;
			this.Provider = provider;
			this.Id = "dc_" + Util.token;
			this.DataConnectionOptions = dataConnectionOptions;
			negotiator = Negotiator.GetNegotiator ();
			NegotiatorOptions negotiatorOptions = new NegotiatorOptions ();
			negotiatorOptions.Originator = true;
			negotiator.StartConnection (this, negotiatorOptions,provider.context);
		}

		public void Initialize(DataChannel dataChannel){
			Channel = dataChannel;
			DataConnectionObserver dataConnectionObserver = new DataConnectionObserver (dataChannel,this);
			dataChannel.RegisterObserver (dataConnectionObserver);
		}

		public void Send(string data)
		{
			Java.Lang.String dataString = new Java.Lang.String (data);
			Java.Nio.ByteBuffer bufferData = Java.Nio.ByteBuffer.AllocateDirect (data.Length);
			bufferData.Put (dataString.GetBytes("UTF-8"));
			bufferData.Flip ();
			DataChannel.Buffer buffer = new DataChannel.Buffer (bufferData, false);
			Channel.Send (buffer);
		}

		public void OnMessage (DataChannel.Buffer p0)
		{
			MessageArrivedEventHandler handler = MessageArrived;
			Charset charset = Charset.ForName ("UTF-8");
			CharsetDecoder decoder = charset.NewDecoder ();
			String message = "";
			try{
				message = decoder.Decode(p0.Data).ToString();
			}
			catch(Exception e){
				Console.WriteLine (e.Data);
			}
			MessageArgs messageArgs = new MessageArgs ();
			messageArgs.Message = message;
			if (handler != null)
			{
				handler(this, messageArgs);
			}
		}

		public void OnChannelOpened ()
		{
			EventHandler handler = DataConnectionOpened;
			EventArgs args = new EventArgs ();
			if (handler != null)
			{
				handler(this, args);
			}
		}

		public void OnChannelClosed ()
		{
			EventHandler handler = DataConnctionClosed;
			EventArgs args = new EventArgs ();
			if (handler != null)
			{
				handler(this, args);
			}
		}
			
		public void Close ()
		{
			//TODO: implement clsoing and stuff
		}
	}

	class DataConnectionObserver : Java.Lang.Object,DataChannel.IObserver{

		DataChannel dataChannel;
		DataConnection dataConnection;

		public DataConnectionObserver(DataChannel dataChannel, DataConnection dataConnection){
			this.dataChannel = dataChannel;
			this.dataConnection = dataConnection;
		}
		#region IObserver implementation
		public void OnBufferedAmountChange (long p0)
		{
			//nothing to do here
		}
		public void OnMessage (DataChannel.Buffer p0)
		{
			Log.WriteLine (LogPriority.Debug, "DataConnectionObserver", "Message Received" + p0.Data);
			dataConnection.OnMessage (p0);
		}


		public void OnStateChange ()
		{
			if (dataChannel.InvokeState() == DataChannel.State.Open) {
				OnChannelOpened ();
			} else if (dataChannel.InvokeState() == DataChannel.State.Closed) {
				OnChannelClosed ();
			}
		}


		void OnChannelOpened ()
		{
			dataConnection.OnChannelOpened ();
		}

		void OnChannelClosed ()
		{
			dataConnection.OnChannelClosed ();
		}


		#endregion
		
	}

	public class DataConnectionOptions{
		public enum SerializationType{
			binary,
			binaryutf8,
			json,
			none
		}
		public string Label{ get; set;}
		public string MetaData{ get; set;}
		public SerializationType Serialization{ get; set;}
		public bool Reliable{ get; set;}
		public DataConnectionOptions(string label,string metadata, SerializationType serialization, bool reliable){
			this.Label = label ?? "dc_" + Util.token;
			this.MetaData = metadata ?? "";
			this.Reliable = reliable;
			this.Serialization = serialization;
		}
	}

	public class MessageArgs:EventArgs{
		public string Message{get;set;}
	}
		
}