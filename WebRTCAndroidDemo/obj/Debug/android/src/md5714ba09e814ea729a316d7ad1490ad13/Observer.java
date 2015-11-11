package md5714ba09e814ea729a316d7ad1490ad13;


public class Observer
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		org.webrtc.PeerConnection.Observer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onAddStream:(Lorg/webrtc/MediaStream;)V:GetOnAddStream_Lorg_webrtc_MediaStream_Handler:Org.Webrtc.PeerConnection/IObserverInvoker, WebRTCBindings\n" +
			"n_onDataChannel:(Lorg/webrtc/DataChannel;)V:GetOnDataChannel_Lorg_webrtc_DataChannel_Handler:Org.Webrtc.PeerConnection/IObserverInvoker, WebRTCBindings\n" +
			"n_onIceCandidate:(Lorg/webrtc/IceCandidate;)V:GetOnIceCandidate_Lorg_webrtc_IceCandidate_Handler:Org.Webrtc.PeerConnection/IObserverInvoker, WebRTCBindings\n" +
			"n_onIceConnectionChange:(Lorg/webrtc/PeerConnection$IceConnectionState;)V:GetOnIceConnectionChange_Lorg_webrtc_PeerConnection_IceConnectionState_Handler:Org.Webrtc.PeerConnection/IObserverInvoker, WebRTCBindings\n" +
			"n_onIceConnectionReceivingChange:(Z)V:GetOnIceConnectionReceivingChange_ZHandler:Org.Webrtc.PeerConnection/IObserverInvoker, WebRTCBindings\n" +
			"n_onIceGatheringChange:(Lorg/webrtc/PeerConnection$IceGatheringState;)V:GetOnIceGatheringChange_Lorg_webrtc_PeerConnection_IceGatheringState_Handler:Org.Webrtc.PeerConnection/IObserverInvoker, WebRTCBindings\n" +
			"n_onRemoveStream:(Lorg/webrtc/MediaStream;)V:GetOnRemoveStream_Lorg_webrtc_MediaStream_Handler:Org.Webrtc.PeerConnection/IObserverInvoker, WebRTCBindings\n" +
			"n_onRenegotiationNeeded:()V:GetOnRenegotiationNeededHandler:Org.Webrtc.PeerConnection/IObserverInvoker, WebRTCBindings\n" +
			"n_onSignalingChange:(Lorg/webrtc/PeerConnection$SignalingState;)V:GetOnSignalingChange_Lorg_webrtc_PeerConnection_SignalingState_Handler:Org.Webrtc.PeerConnection/IObserverInvoker, WebRTCBindings\n" +
			"";
		mono.android.Runtime.register ("PeerNet.Observer, PeerJS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", Observer.class, __md_methods);
	}


	public Observer () throws java.lang.Throwable
	{
		super ();
		if (getClass () == Observer.class)
			mono.android.TypeManager.Activate ("PeerNet.Observer, PeerJS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onAddStream (org.webrtc.MediaStream p0)
	{
		n_onAddStream (p0);
	}

	private native void n_onAddStream (org.webrtc.MediaStream p0);


	public void onDataChannel (org.webrtc.DataChannel p0)
	{
		n_onDataChannel (p0);
	}

	private native void n_onDataChannel (org.webrtc.DataChannel p0);


	public void onIceCandidate (org.webrtc.IceCandidate p0)
	{
		n_onIceCandidate (p0);
	}

	private native void n_onIceCandidate (org.webrtc.IceCandidate p0);


	public void onIceConnectionChange (org.webrtc.PeerConnection.IceConnectionState p0)
	{
		n_onIceConnectionChange (p0);
	}

	private native void n_onIceConnectionChange (org.webrtc.PeerConnection.IceConnectionState p0);


	public void onIceConnectionReceivingChange (boolean p0)
	{
		n_onIceConnectionReceivingChange (p0);
	}

	private native void n_onIceConnectionReceivingChange (boolean p0);


	public void onIceGatheringChange (org.webrtc.PeerConnection.IceGatheringState p0)
	{
		n_onIceGatheringChange (p0);
	}

	private native void n_onIceGatheringChange (org.webrtc.PeerConnection.IceGatheringState p0);


	public void onRemoveStream (org.webrtc.MediaStream p0)
	{
		n_onRemoveStream (p0);
	}

	private native void n_onRemoveStream (org.webrtc.MediaStream p0);


	public void onRenegotiationNeeded ()
	{
		n_onRenegotiationNeeded ();
	}

	private native void n_onRenegotiationNeeded ();


	public void onSignalingChange (org.webrtc.PeerConnection.SignalingState p0)
	{
		n_onSignalingChange (p0);
	}

	private native void n_onSignalingChange (org.webrtc.PeerConnection.SignalingState p0);

	java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
