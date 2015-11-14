using Org.Webrtc;
using Android.Util;
using System;
using Java.Nio.Charset;

namespace PeerNet
{
	/// <summary>
	/// Encapsulated the Data channel between the peers.
	/// </summary>
	public class DataConnection
	{
			
		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="PeerNet.DataConnection"/> is open.
		/// </summary>
		/// <value><c>true</c> if open; otherwise, <c>false</c>.</value>
		public bool Open{ get; set; }

		/// <summary>
		/// Gets or sets the peer.
		/// </summary>
		/// <value>The peer.</value>
		public Peer Peer{ get; set; }

		/// <summary>
		/// Gets or sets the provider.
		/// </summary>
		/// <value>The provider.</value>
		public Peer Provider { get; set; }

		/// <summary>
		/// Gets or sets the identifier.
		/// </summary>
		/// <value>The identifier.</value>
		public string Id{ get; set; }

		/// <summary>
		/// Gets or sets the type.
		/// </summary>
		/// <value>The type.</value>
		public string Type{ get; set; }

		/// <summary>
		/// Gets or sets the channel.
		/// </summary>
		/// <value>The channel.</value>
		public DataChannel Channel{ get; set; }

		/// <summary>
		/// Gets or sets the Peer Connection.
		/// </summary>
		/// <value>The connection.</value>
		public PeerConnection Connection{ get; set; }

		/// <summary>
		/// Gets or sets the data connection options.
		/// </summary>
		/// <value>The data connection options.</value>
		public DataConnectionOptions DataConnectionOptions{ get; set; }

		/// <summary>
		/// The negotiator, A singleton instance used accross the class
		/// </summary>
		Negotiator negotiator;

		#region Event Handlers

		public delegate void MessageArrivedEventHandler (object sender, MessageArgs messageArgs);

		public event EventHandler DataConnectionOpened;
		public event EventHandler DataConnctionClosed;
		public event MessageArrivedEventHandler MessageArrived;

		#endregion

		/// <summary>
		/// Initializes a new instance of the <see cref="PeerNet.DataConnection"/> class.
		/// </summary>
		/// <param name="peer">Peer to connect to.</param>
		/// <param name="provider">This Peer.</param>
		/// <param name="dataConnectionOptions">an instance of the DataConnectionOptions class.</param>
		public DataConnection (Peer peer, Peer provider, DataConnectionOptions dataConnectionOptions)
		{
			Type = "data";
			this.Peer = peer;
			this.Provider = provider;
			this.Id = "dc_" + Util.token;
			this.DataConnectionOptions = dataConnectionOptions;
			negotiator = Negotiator.GetNegotiator ();
			NegotiatorOptions negotiatorOptions = new NegotiatorOptions ();
			negotiatorOptions.Originator = true;
			negotiator.StartConnection (this, negotiatorOptions, provider.context);
		}

		/// <summary>
		/// Initialize the specified dataChannel.
		/// </summary>
		/// <param name="dataChannel">Data channel.</param>
		public void Initialize (DataChannel dataChannel)
		{
			Channel = dataChannel;
			DataConnectionObserver dataConnectionObserver = new DataConnectionObserver (dataChannel, this);
			dataChannel.RegisterObserver (dataConnectionObserver);
		}

		/// <summary>
		/// Send the data. The serialization is defined when connecting to the peer, will be the serialization used.
		/// </summary>
		/// <param name="data">data in string format..</param>
		public void Send (string data)
		{
			Java.Lang.String dataString = new Java.Lang.String (data);
			Java.Nio.ByteBuffer bufferData = Java.Nio.ByteBuffer.AllocateDirect (data.Length);
			bufferData.Put (dataString.GetBytes ("UTF-8"));
			bufferData.Flip ();
			DataChannel.Buffer buffer = new DataChannel.Buffer (bufferData, false);
			Channel.Send (buffer);
		}

		/// <summary>
		/// Called when the data Channel recieved an event, 
		/// </summary>
		/// <param name="p0">The Data in DataChannel.buffer format, which is is actually a Java ByteBuffer</param>
		public void OnMessage (DataChannel.Buffer p0)
		{
			MessageArrivedEventHandler handler = MessageArrived;
			Charset charset = Charset.ForName ("UTF-8");
			CharsetDecoder decoder = charset.NewDecoder ();
			String message = "";
			try {
				message = decoder.Decode (p0.Data).ToString ();
			} catch (Exception e) {
				Console.WriteLine (e.Data);
			}
			MessageArgs messageArgs = new MessageArgs ();
			messageArgs.Message = message;
			if (handler != null) {
				handler (this, messageArgs);
			}
		}

		/// <summary>
		/// Raises the channel opened event.
		/// </summary>
		public void OnChannelOpened ()
		{
			EventHandler handler = DataConnectionOpened;
			EventArgs args = new EventArgs ();
			if (handler != null) {
				handler (this, args);
			}
		}

		/// <summary>
		/// Raises the channel closed event.
		/// </summary>
		public void OnChannelClosed ()
		{
			EventHandler handler = DataConnctionClosed;
			EventArgs args = new EventArgs ();
			if (handler != null) {
				handler (this, args);
			}
		}

		/// <summary>
		/// Close this instance.
		/// </summary>
		public void Close ()
		{
			//TODO: implement clsoing and stuff
		}
	}

	/// <summary>
	/// An observer for the dataconnection, handles the open and and on message events and passes it back to DataConnection
	/// </summary>
	class DataConnectionObserver : Java.Lang.Object,DataChannel.IObserver
	{

		//Holds the instance of the data channel, that has been initailized before.
		DataChannel dataChannel;
		//Holds the data connection instance
		DataConnection dataConnection;

		public DataConnectionObserver (DataChannel dataChannel, DataConnection dataConnection)
		{
			this.dataChannel = dataChannel;
			this.dataConnection = dataConnection;
		}

		#region IObserver implementation

		public void OnBufferedAmountChange (long p0)
		{
			//nothing to do here
		}

		/// <summary>
		/// Raises the message event.
		/// </summary>
		/// <param name="p0">P0.</param>
		public void OnMessage (DataChannel.Buffer p0)
		{
			Log.WriteLine (LogPriority.Debug, "DataConnectionObserver", "Message Received" + p0.Data);
			dataConnection.OnMessage (p0);
		}

		/// <summary>
		/// Raises the state change event.
		/// </summary>
		public void OnStateChange ()
		{
			if (dataChannel.InvokeState () == DataChannel.State.Open) {
				OnChannelOpened ();
			} else if (dataChannel.InvokeState () == DataChannel.State.Closed) {
				OnChannelClosed ();
			}
		}

		/// <summary>
		/// Raises the channel opened event.
		/// </summary>
		void OnChannelOpened ()
		{
			dataConnection.OnChannelOpened ();
		}

		/// <summary>
		/// Raises the channel closed event.
		/// </summary>
		void OnChannelClosed ()
		{
			dataConnection.OnChannelClosed ();
		}

		#endregion
		
	}

	/// <summary>
	/// Specifies options for DataConnection
	/// </summary>
	public class DataConnectionOptions
	{
		/// <summary>
		/// Enum of Serialization type, can be binary,binaryutf8,json,none
		/// </summary>
		public enum SerializationType
		{
			binary,
			binaryutf8,
			json,
			none
		}

		/// <summary>
		/// Gets or sets the label.
		/// </summary>
		/// <value>The label.</value>
		public string Label{ get; set; }

		/// <summary>
		/// Gets or sets the meta data.
		/// </summary>
		/// <value>The meta data.</value>
		public string MetaData{ get; set; }

		/// <summary>
		/// Gets or sets the serialization.
		/// </summary>
		/// <value>The serialization.</value>
		public SerializationType Serialization{ get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="PeerNet.DataConnectiom"/> is reliable.
		/// </summary>
		/// <value><c>true</c> if reliable; otherwise, <c>false</c>.</value>
		public bool Reliable{ get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="PeerNet.DataConnectionOptions"/> class.
		/// </summary>
		/// <param name="label">Label optional, if not given a random token is generated for this dataconnection.</param>
		/// <param name="metadata">Some metatdat to be given to the client on the other end</param>
		/// <param name="serialization">The serialization used for this dataconnection </param>
		/// <param name="reliable">If set to <c>true</c> reliable.</param>
		public DataConnectionOptions (string label, string metadata, SerializationType serialization, bool reliable)
		{
			this.Label = label ?? "dc_" + Util.token;
			this.MetaData = metadata ?? "";
			this.Reliable = reliable;
			this.Serialization = serialization;
		}
	}

	/// <summary>
	/// Message arguments.
	/// </summary>
	public class MessageArgs:EventArgs
	{
		public string Message{ get; set; }
	}
		
}