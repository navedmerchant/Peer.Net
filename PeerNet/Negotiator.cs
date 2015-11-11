using System;
using Org.Webrtc;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Android.Content;


namespace PeerNet
{
	public class Negotiator
	{
		public DataConnection dataConnection;
		public PeerConnection peerConnection;
		public Dictionary<string,PeerConnection> connections;
		private static Negotiator negotiator =  new Negotiator();
		private Context context;
		private Negotiator (){
		
		}

		public static Negotiator GetNegotiator(){
			return negotiator;
		}

		public void StartConnection (DataConnection dataConnection, NegotiatorOptions negotiatorOptions, Context context)
		{
			this.context = context;
			this.dataConnection = dataConnection;
			PeerConnection peerConnection = GetPeerConnection(dataConnection,negotiatorOptions); 
			dataConnection.Connection = peerConnection;

			if (negotiatorOptions.Originator) {
				DataChannel dataChannel = peerConnection.CreateDataChannel (dataConnection.Id, new DataChannel.Init ());
				dataConnection.Initialize (dataChannel);
				MakeOffer (dataConnection);
			}
		}

		public void HandleMessage (ServerMessage serverMessage,SessionDescription sessionDescription)
		{
			RemoteSDPObserver remoteSDPObserver = new RemoteSDPObserver (this);
			peerConnection.SetRemoteDescription (remoteSDPObserver, sessionDescription);
		}

		private void MakeOffer (DataConnection dataconnection)
		{
			PeerConnection peerConnection = dataConnection.Connection;
			MediaConstraints mediaConstraints = new MediaConstraints ();
			SDPObserver sdpObserver = new SDPObserver(this);
			peerConnection.CreateOffer (sdpObserver, mediaConstraints);
		}
	
		private PeerConnection GetPeerConnection (DataConnection dataConnection, NegotiatorOptions negotiatorOptions)
		{
			if (connections == null) {
				connections = new Dictionary<string, PeerConnection> ();
			}
			if (negotiatorOptions.PeerConnectionID != null) {
				PeerConnection outPeerConnection;
				connections.TryGetValue (negotiatorOptions.PeerConnectionID,out outPeerConnection);
					return outPeerConnection;
			} else {
				PeerConnection peerConnection = StartPeerConnection (dataConnection);
				return peerConnection;
			}

		}
		PeerConnection StartPeerConnection (DataConnection dataConnection)
		{
			MediaConstraints mediaConstraints = new MediaConstraints ();
			PeerConnectionFactory.InitializeAndroidGlobals (context, true, true,true,VideoRendererGui.EGLContext);
			PeerConnectionFactory peerConnectionFactory = new PeerConnectionFactory ();
			//mediaConstraints.Optional.Add(new MediaConstraints.KeyValuePair("RtpDataChannels","true"));
			Observer observer = new Observer (this);
			peerConnection = peerConnectionFactory.CreatePeerConnection (dataConnection.Provider.options.Config, mediaConstraints, observer);
			return peerConnection;
		}
	}


	class RemoteSDPObserver : Java.Lang.Object,ISdpObserver{

		private Negotiator negotiator;
		private SessionDescription sessionDescription;
		public RemoteSDPObserver(Negotiator negotiator){
			this.negotiator = negotiator;
		}

		#region ISdpObserver implementation
		public void OnCreateFailure (string p0)
		{
			throw new NotImplementedException ();
		}
		public void OnCreateSuccess (SessionDescription p0)
		{
			Console.WriteLine ("Remote description creation success");
		}
		public void OnSetFailure (string p0)
		{
			//throw new NotImplementedException ();
		}
		public void OnSetSuccess ()
		{
			Console.WriteLine ("Remote description set success");
		}
		#endregion

	}



	class SDPObserver : Java.Lang.Object,ISdpObserver{

		private Negotiator negotiator;
		private SessionDescription sessionDescription;
		public SDPObserver(Negotiator negotiator){
			this.negotiator = negotiator;
		}

		#region ISdpObserver implementation
		public void OnCreateFailure (string p0)
		{
			throw new NotImplementedException ();
		}
		public void OnCreateSuccess (SessionDescription p0)
		{
			sessionDescription = p0;
			negotiator.peerConnection.SetLocalDescription (this, p0);
		}
		public void OnSetFailure (string p0)
		{
			//throw new NotImplementedException ();
		}
		public void OnSetSuccess ()
		{
			JObject sdp = new JObject ();
			sdp ["type"] = "offer";
			sdp ["sdp"] = sessionDescription.Description;
			JObject payload = new JObject ();
			payload ["sdp"] = sdp;
			payload ["type"] = negotiator.dataConnection.Type;
			payload ["label"] = negotiator.dataConnection.Id;
			payload ["connectionId"] = negotiator.dataConnection.Id;
			payload ["reliable"] = negotiator.dataConnection.DataConnectionOptions.Reliable;
			payload ["serialization"] = negotiator.dataConnection.DataConnectionOptions.Serialization.ToString();
			payload ["metadata"] = negotiator.dataConnection.DataConnectionOptions.MetaData;
			JObject message = new JObject ();
			message ["type"] = "OFFER";
			message ["payload"] = payload;
			message ["dst"] = negotiator.dataConnection.Peer.id;
			Console.WriteLine ("Offer JSON " + message.ToString()); 
			negotiator.dataConnection.Provider.socket.Send (message.ToString());
		}
		#endregion

	}

	class Observer : Java.Lang.Object,PeerConnection.IObserver{

		Negotiator negotiator;

		public Observer(Negotiator negotiator){
			this.negotiator = negotiator;
		}
		//for mediaconnection so we wont implement it
		#region IObserver implementation
		public void OnAddStream (MediaStream p0)
		{
			//throw new NotImplementedException ();
		}

		public void OnDataChannel (DataChannel p0)
		{
			Console.WriteLine ("Recieved data channel");
			negotiator.dataConnection.Initialize (p0);
		}

		public void OnIceCandidate (IceCandidate p0)
		{
			JObject candidate = new JObject ();
			candidate ["candidate"] = p0.Sdp;
			candidate ["sdpMLineIndex"] = p0.SdpMLineIndex;
			JObject payload = new JObject ();
			payload ["candidate"] = candidate;
			payload ["type"] = negotiator.dataConnection.Type;
			payload["connectionId"] = negotiator.dataConnection.Id;
			JObject message = new JObject ();
			message ["type"] = "CANDIDATE";
			message ["payload"] = payload;
			message ["dst"] = negotiator.dataConnection.Peer.id;
			negotiator.dataConnection.Provider.socket.Send (message.ToString ());

		}

		public void OnIceConnectionChange (PeerConnection.IceConnectionState p0)
		{
			if (p0 == PeerConnection.IceConnectionState.Failed) {
				negotiator.dataConnection.Close ();
			} else if (p0 == PeerConnection.IceConnectionState.Disconnected) {
				negotiator.dataConnection.Close ();
			} else if (p0 == PeerConnection.IceConnectionState.Completed) {
				Console.WriteLine ("We cool homies, everything is setup");
			}
		}

		public void OnIceConnectionReceivingChange (bool p0)
		{
			//throw new NotImplementedException ();
		}

		public void OnIceGatheringChange (PeerConnection.IceGatheringState p0)
		{
			//throw new NotImplementedException ();
		}

		public void OnRemoveStream (MediaStream p0)
		{
			//throw new NotImplementedException ();
		}

		public void OnRenegotiationNeeded ()
		{
			//throw new NotImplementedException ();
		}

		public void OnSignalingChange (PeerConnection.SignalingState p0)
		{
			//throw new NotImplementedException ();
		}
		#endregion
		
	}

	public class NegotiatorOptions{
		public bool Originator{ get; set;}
		public string PeerConnectionID{ get; set;}
	}
}
	