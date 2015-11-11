using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using PeerNet;
using Org.Webrtc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace WebRTCAndroidDemo
{
    [Activity(Label = "WebRTCAndroidDemo", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        TextView textView;
		Peer peer;
		string targetPeer;
		DataConnection dataConnection;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);
            textView = FindViewById<TextView>(Resource.Id.textView1);
			EditText editText = FindViewById<EditText> (Resource.Id.editText1);
			button.Click += delegate {
				targetPeer = editText.Text;
				PeerNet.DataConnectionOptions dataConnectionOptions = new DataConnectionOptions (null, null, DataConnectionOptions.SerializationType.json, true);
				dataConnection = peer.Connect (targetPeer, dataConnectionOptions);
				dataConnection.DataConnectionOpened += DataConnection_DataConnectionOpened;
			};
			Button sendButton = FindViewById<Button> (Resource.Id.button1);
			sendButton.Click += SendButton_Click;

			PeerConnectionFactory.InitializeAndroidGlobals (this, true, true,true,VideoRendererGui.EGLContext);
			peer = new Peer(null, new PeerOptions(null, null, "ytgklpf684u0udi", null, null));
            peer.PeerConnected += Peer_PeerConnected;
        }

        void SendButton_Click (object sender, EventArgs e)
        {
			JObject jobject = new JObject ();
			jobject["data"] = "Hello";
			dataConnection.Send (jobject.ToString ());
        }

        void DataConnection_DataConnectionOpened (object sender, EventArgs e)
        {
			dataConnection.MessageArrived += DataConnection_MessageArrived;
        }

        void DataConnection_MessageArrived (object sender, MessageArgs messageArgs)
        {
			Console.WriteLine ("New Message: " + messageArgs.Message);
        }

        private void Peer_PeerConnected(object sender, PeerConnectedEventArgs args)
        {
            using (var h = new Handler(Looper.MainLooper))
                h.Post(() => { textView.Text = args.PeerId; });
        }
    }
}

