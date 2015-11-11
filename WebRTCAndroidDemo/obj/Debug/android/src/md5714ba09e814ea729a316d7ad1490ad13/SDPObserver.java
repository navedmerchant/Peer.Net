package md5714ba09e814ea729a316d7ad1490ad13;


public class SDPObserver
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		org.webrtc.SdpObserver
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreateFailure:(Ljava/lang/String;)V:GetOnCreateFailure_Ljava_lang_String_Handler:Org.Webrtc.ISdpObserverInvoker, WebRTCBindings\n" +
			"n_onCreateSuccess:(Lorg/webrtc/SessionDescription;)V:GetOnCreateSuccess_Lorg_webrtc_SessionDescription_Handler:Org.Webrtc.ISdpObserverInvoker, WebRTCBindings\n" +
			"n_onSetFailure:(Ljava/lang/String;)V:GetOnSetFailure_Ljava_lang_String_Handler:Org.Webrtc.ISdpObserverInvoker, WebRTCBindings\n" +
			"n_onSetSuccess:()V:GetOnSetSuccessHandler:Org.Webrtc.ISdpObserverInvoker, WebRTCBindings\n" +
			"";
		mono.android.Runtime.register ("PeerNet.SDPObserver, PeerJS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", SDPObserver.class, __md_methods);
	}


	public SDPObserver () throws java.lang.Throwable
	{
		super ();
		if (getClass () == SDPObserver.class)
			mono.android.TypeManager.Activate ("PeerNet.SDPObserver, PeerJS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreateFailure (java.lang.String p0)
	{
		n_onCreateFailure (p0);
	}

	private native void n_onCreateFailure (java.lang.String p0);


	public void onCreateSuccess (org.webrtc.SessionDescription p0)
	{
		n_onCreateSuccess (p0);
	}

	private native void n_onCreateSuccess (org.webrtc.SessionDescription p0);


	public void onSetFailure (java.lang.String p0)
	{
		n_onSetFailure (p0);
	}

	private native void n_onSetFailure (java.lang.String p0);


	public void onSetSuccess ()
	{
		n_onSetSuccess ();
	}

	private native void n_onSetSuccess ();

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
