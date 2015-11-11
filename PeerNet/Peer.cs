using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Org.Webrtc;
using System.Text.RegularExpressions;	
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace PeerNet
{
    /// <summary>
    /// Class Representation of a Peer.
    /// </summary>
    public class Peer
    {
        /// <summary>
        /// Options for this Peer.
        /// </summary>
        public PeerOptions options;
        /// <summary>
        /// Id of this peer.
        /// </summary>
		public string id;
        /// <summary>
        /// Connection has been killed.
        /// </summary>
		public bool destroyed;
        /// <summary>
        /// connection to the peer server has been killed.
        /// </summary>
		public bool disconnected;
        /// <summary>
        /// Connections have not been opened.
        /// </summary>
		public bool open;
        /// <summary>
        /// List of data connections for this server;
        /// </summary>
		public List<DataConnection> connections;
        /// <summary>
        /// Socket for this Peer
        /// </summary>
		public Socket socket;

        public delegate void PeerConnectedMessageHandler(object sender, PeerConnectedEventArgs args);

        public event PeerConnectedMessageHandler PeerConnected;
        /// <summary>
        /// Peer Contructor.
        /// </summary>
        /// <param name="peerId">Id of the peer. If not specified will be generated by the server;</param>
        /// <param name="peerOptions">Peer options, An instance of Peer.PeerOptions class</param>
        public Peer(string peerId, PeerOptions peerOptions)
        {
            options = peerOptions ?? new PeerOptions(null, null, null, null, null);
            id = peerId;
            connections = new List<DataConnection>();
            InitializeServerConnection();
            if (id == null)
            {
                InitializeID();
            }
            else {
                Initialize(id);
            }
        }
		/// <summary>
		/// This constructor is meant to hold the peer intance for the destination.
		/// We donot provide the options, since we donot connect this peer. We just use it to hold the peer ID so that 
		/// the peer class is uniformly used througout the code.
		/// </summary>
		/// <param name="peerId">Peer identifier.</param>
		public Peer(string peerId){
			this.id = peerId;
		}

		public DataConnection Connect(string peer,DataConnectionOptions options){
			Peer peerToConnect = new Peer(peer);
			DataConnection dataConnection = new DataConnection(peerToConnect,this,options);
			this.connections.Add(dataConnection);
			return dataConnection;
		}

        private void Initialize(string id)
        {
            this.id = id;
            socket.Start(id, this.options.Token);

        }

        private async void InitializeID()
        {
            string protocol = "http://";
            string url = protocol + this.options.Host + ":" + this.options.Port + this.options.Path + this.options.Key + "/id";
            HttpWebRequest httpWebRequest = new HttpWebRequest(new Uri(url));
            httpWebRequest.Method = "GET";
            using (WebResponse response = await httpWebRequest.GetResponseAsync())
            { 
                using (Stream stream = response.GetResponseStream())
                {
                    JsonSerializer jsonSerializer = new JsonSerializer();
                    StreamReader streamReader = new StreamReader(stream);
                    string id = streamReader.ReadToEnd();
                    this.id = id;
                    Initialize(id);                    
                }
            }


        }

        private void InitializeServerConnection()
        {
            this.socket = new Socket(options.Host, options.Port, options.Path, options.Key);
            socket.MessageArrived += Socket_MessageArrived;
            socket.SocketOpened += Socket_SocketOpened;
            socket.SocketError += Socket_SocketError;
            socket.SocketClosed += Socket_SocketClosed;
        }

        private void Socket_SocketClosed(object sender, EventArgs e)
        {
            Console.WriteLine("Socket Closed");
        }

        private void Socket_SocketError(object sender, WebSocketSharp.ErrorEventArgs args)
        {
            Console.WriteLine("Socket Error:" + args.Message);
        }

        private void Socket_SocketOpened(object sender, EventArgs e)
        {
            Console.WriteLine("Socket Opened");
        }

        private void Socket_MessageArrived(object sender, SocketMessageEventArgs args)
        {
            HandleMessage(args.Message);
        }

        private void HandleMessage(string message)
        {
            ServerMessage serverMessage = JsonConvert.DeserializeObject<ServerMessage>(message);
            switch (serverMessage.Type) {
                case "OPEN":
                    PeerConnectedEventArgs peerConnectedEventArgs = new PeerConnectedEventArgs();
                    peerConnectedEventArgs.PeerId = this.id;
                    OnPeerConnected(peerConnectedEventArgs);
                    break;
				case "ANSWER":
					Negotiator negotiator = Negotiator.GetNegotiator ();
					SessionDescription sessionDescription = new SessionDescription (SessionDescription.Type.Answer, serverMessage.Payload.Sdp.Sdp);
					negotiator.HandleMessage (serverMessage,sessionDescription);
					break;
            }  
        }

        private void OnPeerConnected(PeerConnectedEventArgs peerConnectedEventArgs)
        {
            PeerConnectedMessageHandler handler = PeerConnected;
            if (handler != null) {
                handler(this, peerConnectedEventArgs);
            }
        }
    }

    public class ServerMessage {

        public string Type{get;set;}
		public Payload Payload { get; set; }
        public string Src { get; set; }
		public string Msg{ get; set;}
		public string Dst{ get; set;}

    }

	public class Payload{
		public SdpType Sdp{ get; set;}
		public string Type{ get; set;}
		public string ConnectionId{ get; set;}
		public string Browser{ get; set;}
	}

	public class SdpType{
		public string Type{ get; set;}
		public string Sdp {get;set;}
	}

    public class PeerConnectedEventArgs : EventArgs
    {
        public string PeerId { get; set; }
    }

    /// <summary>
    /// Class representing the Peer options while constructing the Peer object
    /// </summary>
    public class PeerOptions
    {
		public string Host{ get; set;}
		public int Port{ get; set;}
		public string Key{ get; set;}
		public string Path{ get; set;}
		public string Token{ get; set;}
		public List<PeerConnection.IceServer> Config{ get; set;}

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="host">Optional host parameter. Defaults to 0.peerjs.com</param>
        /// <param name="port">Optional port. deefaults to 9000</param>
        /// <param name="key">optional key, defaults to "peerjs"</param>
        /// <param name="path">the path of the peerjs server on the url defaults to '/'</param>
        /// <param name="config">List of IceServers to use. defaults to "stun:stun.l.google.com:19302"</param>
        public PeerOptions(string host, int? port, string key, string path, List<PeerConnection.IceServer> config)
        {
            this.Host = host ?? Util.host;
            this.Port = port ?? Util.port;
            this.Key = key ?? "peerjs";
            this.Path = path ?? "/";
            this.Token = Util.token;
            this.Config = config ?? Util.defaultConfig;
        }
    }

}