package md5714ba09e814ea729a316d7ad1490ad13;


public class DataConnectionObserver
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		org.webrtc.DataChannel.Observer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onBufferedAmountChange:(J)V:GetOnBufferedAmountChange_JHandler:Org.Webrtc.DataChannel/IObserverInvoker, WebRTCBindings\n" +
			"n_onMessage:(Lorg/webrtc/DataChannel$Buffer;)V:GetOnMessage_Lorg_webrtc_DataChannel_Buffer_Handler:Org.Webrtc.DataChannel/IObserverInvoker, WebRTCBindings\n" +
			"n_onStateChange:()V:GetOnStateChangeHandler:Org.Webrtc.DataChannel/IObserverInvoker, WebRTCBindings\n" +
			"";
		mono.android.Runtime.register ("PeerNet.DataConnectionObserver, PeerJS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", DataConnectionObserver.class, __md_methods);
	}


	public DataConnectionObserver () throws java.lang.Throwable
	{
		super ();
		if (getClass () == DataConnectionObserver.class)
			mono.android.TypeManager.Activate ("PeerNet.DataConnectionObserver, PeerJS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onBufferedAmountChange (long p0)
	{
		n_onBufferedAmountChange (p0);
	}

	private native void n_onBufferedAmountChange (long p0);


	public void onMessage (org.webrtc.DataChannel.Buffer p0)
	{
		n_onMessage (p0);
	}

	private native void n_onMessage (org.webrtc.DataChannel.Buffer p0);


	public void onStateChange ()
	{
		n_onStateChange ();
	}

	private native void n_onStateChange ();

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
