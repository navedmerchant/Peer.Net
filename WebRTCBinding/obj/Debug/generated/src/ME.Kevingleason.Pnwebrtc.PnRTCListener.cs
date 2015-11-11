using System;
using System.Collections.Generic;
using Android.Runtime;

namespace ME.Kevingleason.Pnwebrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='me.kevingleason.pnwebrtc']/class[@name='PnRTCListener']"
	[global::Android.Runtime.Register ("me/kevingleason/pnwebrtc/PnRTCListener", DoNotGenerateAcw=true)]
	public abstract partial class PnRTCListener : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("me/kevingleason/pnwebrtc/PnRTCListener", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PnRTCListener); }
		}

		protected PnRTCListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='me.kevingleason.pnwebrtc']/class[@name='PnRTCListener']/constructor[@name='PnRTCListener' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PnRTCListener ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (PnRTCListener)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static Delegate cb_onAddRemoteStream_Lorg_webrtc_MediaStream_Lme_kevingleason_pnwebrtc_PnPeer_;
#pragma warning disable 0169
		static Delegate GetOnAddRemoteStream_Lorg_webrtc_MediaStream_Lme_kevingleason_pnwebrtc_PnPeer_Handler ()
		{
			if (cb_onAddRemoteStream_Lorg_webrtc_MediaStream_Lme_kevingleason_pnwebrtc_PnPeer_ == null)
				cb_onAddRemoteStream_Lorg_webrtc_MediaStream_Lme_kevingleason_pnwebrtc_PnPeer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnAddRemoteStream_Lorg_webrtc_MediaStream_Lme_kevingleason_pnwebrtc_PnPeer_);
			return cb_onAddRemoteStream_Lorg_webrtc_MediaStream_Lme_kevingleason_pnwebrtc_PnPeer_;
		}

		static void n_OnAddRemoteStream_Lorg_webrtc_MediaStream_Lme_kevingleason_pnwebrtc_PnPeer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::ME.Kevingleason.Pnwebrtc.PnRTCListener __this = global::Java.Lang.Object.GetObject<global::ME.Kevingleason.Pnwebrtc.PnRTCListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.MediaStream p0 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaStream> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::ME.Kevingleason.Pnwebrtc.PnPeer p1 = global::Java.Lang.Object.GetObject<global::ME.Kevingleason.Pnwebrtc.PnPeer> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnAddRemoteStream (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onAddRemoteStream_Lorg_webrtc_MediaStream_Lme_kevingleason_pnwebrtc_PnPeer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='me.kevingleason.pnwebrtc']/class[@name='PnRTCListener']/method[@name='onAddRemoteStream' and count(parameter)=2 and parameter[1][@type='org.webrtc.MediaStream'] and parameter[2][@type='me.kevingleason.pnwebrtc.PnPeer']]"
		[Register ("onAddRemoteStream", "(Lorg/webrtc/MediaStream;Lme/kevingleason/pnwebrtc/PnPeer;)V", "GetOnAddRemoteStream_Lorg_webrtc_MediaStream_Lme_kevingleason_pnwebrtc_PnPeer_Handler")]
		public virtual unsafe void OnAddRemoteStream (global::Org.Webrtc.MediaStream p0, global::ME.Kevingleason.Pnwebrtc.PnPeer p1)
		{
			if (id_onAddRemoteStream_Lorg_webrtc_MediaStream_Lme_kevingleason_pnwebrtc_PnPeer_ == IntPtr.Zero)
				id_onAddRemoteStream_Lorg_webrtc_MediaStream_Lme_kevingleason_pnwebrtc_PnPeer_ = JNIEnv.GetMethodID (class_ref, "onAddRemoteStream", "(Lorg/webrtc/MediaStream;Lme/kevingleason/pnwebrtc/PnPeer;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onAddRemoteStream_Lorg_webrtc_MediaStream_Lme_kevingleason_pnwebrtc_PnPeer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onAddRemoteStream", "(Lorg/webrtc/MediaStream;Lme/kevingleason/pnwebrtc/PnPeer;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onCallReady_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnCallReady_Ljava_lang_String_Handler ()
		{
			if (cb_onCallReady_Ljava_lang_String_ == null)
				cb_onCallReady_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCallReady_Ljava_lang_String_);
			return cb_onCallReady_Ljava_lang_String_;
		}

		static void n_OnCallReady_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::ME.Kevingleason.Pnwebrtc.PnRTCListener __this = global::Java.Lang.Object.GetObject<global::ME.Kevingleason.Pnwebrtc.PnRTCListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCallReady (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onCallReady_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='me.kevingleason.pnwebrtc']/class[@name='PnRTCListener']/method[@name='onCallReady' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onCallReady", "(Ljava/lang/String;)V", "GetOnCallReady_Ljava_lang_String_Handler")]
		public virtual unsafe void OnCallReady (string p0)
		{
			if (id_onCallReady_Ljava_lang_String_ == IntPtr.Zero)
				id_onCallReady_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onCallReady", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onCallReady_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCallReady", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_onConnected_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnConnected_Ljava_lang_String_Handler ()
		{
			if (cb_onConnected_Ljava_lang_String_ == null)
				cb_onConnected_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnConnected_Ljava_lang_String_);
			return cb_onConnected_Ljava_lang_String_;
		}

		static void n_OnConnected_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::ME.Kevingleason.Pnwebrtc.PnRTCListener __this = global::Java.Lang.Object.GetObject<global::ME.Kevingleason.Pnwebrtc.PnRTCListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnConnected (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onConnected_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='me.kevingleason.pnwebrtc']/class[@name='PnRTCListener']/method[@name='onConnected' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onConnected", "(Ljava/lang/String;)V", "GetOnConnected_Ljava_lang_String_Handler")]
		public virtual unsafe void OnConnected (string p0)
		{
			if (id_onConnected_Ljava_lang_String_ == IntPtr.Zero)
				id_onConnected_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onConnected", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onConnected_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onConnected", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_onDebug_Lme_kevingleason_pnwebrtc_PnRTCMessage_;
#pragma warning disable 0169
		static Delegate GetOnDebug_Lme_kevingleason_pnwebrtc_PnRTCMessage_Handler ()
		{
			if (cb_onDebug_Lme_kevingleason_pnwebrtc_PnRTCMessage_ == null)
				cb_onDebug_Lme_kevingleason_pnwebrtc_PnRTCMessage_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDebug_Lme_kevingleason_pnwebrtc_PnRTCMessage_);
			return cb_onDebug_Lme_kevingleason_pnwebrtc_PnRTCMessage_;
		}

		static void n_OnDebug_Lme_kevingleason_pnwebrtc_PnRTCMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::ME.Kevingleason.Pnwebrtc.PnRTCListener __this = global::Java.Lang.Object.GetObject<global::ME.Kevingleason.Pnwebrtc.PnRTCListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::ME.Kevingleason.Pnwebrtc.PnRTCMessage p0 = global::Java.Lang.Object.GetObject<global::ME.Kevingleason.Pnwebrtc.PnRTCMessage> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDebug (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onDebug_Lme_kevingleason_pnwebrtc_PnRTCMessage_;
		// Metadata.xml XPath method reference: path="/api/package[@name='me.kevingleason.pnwebrtc']/class[@name='PnRTCListener']/method[@name='onDebug' and count(parameter)=1 and parameter[1][@type='me.kevingleason.pnwebrtc.PnRTCMessage']]"
		[Register ("onDebug", "(Lme/kevingleason/pnwebrtc/PnRTCMessage;)V", "GetOnDebug_Lme_kevingleason_pnwebrtc_PnRTCMessage_Handler")]
		public virtual unsafe void OnDebug (global::ME.Kevingleason.Pnwebrtc.PnRTCMessage p0)
		{
			if (id_onDebug_Lme_kevingleason_pnwebrtc_PnRTCMessage_ == IntPtr.Zero)
				id_onDebug_Lme_kevingleason_pnwebrtc_PnRTCMessage_ = JNIEnv.GetMethodID (class_ref, "onDebug", "(Lme/kevingleason/pnwebrtc/PnRTCMessage;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onDebug_Lme_kevingleason_pnwebrtc_PnRTCMessage_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDebug", "(Lme/kevingleason/pnwebrtc/PnRTCMessage;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onLocalStream_Lorg_webrtc_MediaStream_;
#pragma warning disable 0169
		static Delegate GetOnLocalStream_Lorg_webrtc_MediaStream_Handler ()
		{
			if (cb_onLocalStream_Lorg_webrtc_MediaStream_ == null)
				cb_onLocalStream_Lorg_webrtc_MediaStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnLocalStream_Lorg_webrtc_MediaStream_);
			return cb_onLocalStream_Lorg_webrtc_MediaStream_;
		}

		static void n_OnLocalStream_Lorg_webrtc_MediaStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::ME.Kevingleason.Pnwebrtc.PnRTCListener __this = global::Java.Lang.Object.GetObject<global::ME.Kevingleason.Pnwebrtc.PnRTCListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.MediaStream p0 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaStream> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnLocalStream (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onLocalStream_Lorg_webrtc_MediaStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='me.kevingleason.pnwebrtc']/class[@name='PnRTCListener']/method[@name='onLocalStream' and count(parameter)=1 and parameter[1][@type='org.webrtc.MediaStream']]"
		[Register ("onLocalStream", "(Lorg/webrtc/MediaStream;)V", "GetOnLocalStream_Lorg_webrtc_MediaStream_Handler")]
		public virtual unsafe void OnLocalStream (global::Org.Webrtc.MediaStream p0)
		{
			if (id_onLocalStream_Lorg_webrtc_MediaStream_ == IntPtr.Zero)
				id_onLocalStream_Lorg_webrtc_MediaStream_ = JNIEnv.GetMethodID (class_ref, "onLocalStream", "(Lorg/webrtc/MediaStream;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onLocalStream_Lorg_webrtc_MediaStream_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onLocalStream", "(Lorg/webrtc/MediaStream;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onMessage_Lme_kevingleason_pnwebrtc_PnPeer_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetOnMessage_Lme_kevingleason_pnwebrtc_PnPeer_Ljava_lang_Object_Handler ()
		{
			if (cb_onMessage_Lme_kevingleason_pnwebrtc_PnPeer_Ljava_lang_Object_ == null)
				cb_onMessage_Lme_kevingleason_pnwebrtc_PnPeer_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnMessage_Lme_kevingleason_pnwebrtc_PnPeer_Ljava_lang_Object_);
			return cb_onMessage_Lme_kevingleason_pnwebrtc_PnPeer_Ljava_lang_Object_;
		}

		static void n_OnMessage_Lme_kevingleason_pnwebrtc_PnPeer_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::ME.Kevingleason.Pnwebrtc.PnRTCListener __this = global::Java.Lang.Object.GetObject<global::ME.Kevingleason.Pnwebrtc.PnRTCListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::ME.Kevingleason.Pnwebrtc.PnPeer p0 = global::Java.Lang.Object.GetObject<global::ME.Kevingleason.Pnwebrtc.PnPeer> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnMessage (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onMessage_Lme_kevingleason_pnwebrtc_PnPeer_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='me.kevingleason.pnwebrtc']/class[@name='PnRTCListener']/method[@name='onMessage' and count(parameter)=2 and parameter[1][@type='me.kevingleason.pnwebrtc.PnPeer'] and parameter[2][@type='java.lang.Object']]"
		[Register ("onMessage", "(Lme/kevingleason/pnwebrtc/PnPeer;Ljava/lang/Object;)V", "GetOnMessage_Lme_kevingleason_pnwebrtc_PnPeer_Ljava_lang_Object_Handler")]
		public virtual unsafe void OnMessage (global::ME.Kevingleason.Pnwebrtc.PnPeer p0, global::Java.Lang.Object p1)
		{
			if (id_onMessage_Lme_kevingleason_pnwebrtc_PnPeer_Ljava_lang_Object_ == IntPtr.Zero)
				id_onMessage_Lme_kevingleason_pnwebrtc_PnPeer_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onMessage", "(Lme/kevingleason/pnwebrtc/PnPeer;Ljava/lang/Object;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onMessage_Lme_kevingleason_pnwebrtc_PnPeer_Ljava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onMessage", "(Lme/kevingleason/pnwebrtc/PnPeer;Ljava/lang/Object;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onPeerConnectionClosed_Lme_kevingleason_pnwebrtc_PnPeer_;
#pragma warning disable 0169
		static Delegate GetOnPeerConnectionClosed_Lme_kevingleason_pnwebrtc_PnPeer_Handler ()
		{
			if (cb_onPeerConnectionClosed_Lme_kevingleason_pnwebrtc_PnPeer_ == null)
				cb_onPeerConnectionClosed_Lme_kevingleason_pnwebrtc_PnPeer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnPeerConnectionClosed_Lme_kevingleason_pnwebrtc_PnPeer_);
			return cb_onPeerConnectionClosed_Lme_kevingleason_pnwebrtc_PnPeer_;
		}

		static void n_OnPeerConnectionClosed_Lme_kevingleason_pnwebrtc_PnPeer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::ME.Kevingleason.Pnwebrtc.PnRTCListener __this = global::Java.Lang.Object.GetObject<global::ME.Kevingleason.Pnwebrtc.PnRTCListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::ME.Kevingleason.Pnwebrtc.PnPeer p0 = global::Java.Lang.Object.GetObject<global::ME.Kevingleason.Pnwebrtc.PnPeer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnPeerConnectionClosed (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onPeerConnectionClosed_Lme_kevingleason_pnwebrtc_PnPeer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='me.kevingleason.pnwebrtc']/class[@name='PnRTCListener']/method[@name='onPeerConnectionClosed' and count(parameter)=1 and parameter[1][@type='me.kevingleason.pnwebrtc.PnPeer']]"
		[Register ("onPeerConnectionClosed", "(Lme/kevingleason/pnwebrtc/PnPeer;)V", "GetOnPeerConnectionClosed_Lme_kevingleason_pnwebrtc_PnPeer_Handler")]
		public virtual unsafe void OnPeerConnectionClosed (global::ME.Kevingleason.Pnwebrtc.PnPeer p0)
		{
			if (id_onPeerConnectionClosed_Lme_kevingleason_pnwebrtc_PnPeer_ == IntPtr.Zero)
				id_onPeerConnectionClosed_Lme_kevingleason_pnwebrtc_PnPeer_ = JNIEnv.GetMethodID (class_ref, "onPeerConnectionClosed", "(Lme/kevingleason/pnwebrtc/PnPeer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onPeerConnectionClosed_Lme_kevingleason_pnwebrtc_PnPeer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPeerConnectionClosed", "(Lme/kevingleason/pnwebrtc/PnPeer;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onPeerStatusChanged_Lme_kevingleason_pnwebrtc_PnPeer_;
#pragma warning disable 0169
		static Delegate GetOnPeerStatusChanged_Lme_kevingleason_pnwebrtc_PnPeer_Handler ()
		{
			if (cb_onPeerStatusChanged_Lme_kevingleason_pnwebrtc_PnPeer_ == null)
				cb_onPeerStatusChanged_Lme_kevingleason_pnwebrtc_PnPeer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnPeerStatusChanged_Lme_kevingleason_pnwebrtc_PnPeer_);
			return cb_onPeerStatusChanged_Lme_kevingleason_pnwebrtc_PnPeer_;
		}

		static void n_OnPeerStatusChanged_Lme_kevingleason_pnwebrtc_PnPeer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::ME.Kevingleason.Pnwebrtc.PnRTCListener __this = global::Java.Lang.Object.GetObject<global::ME.Kevingleason.Pnwebrtc.PnRTCListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::ME.Kevingleason.Pnwebrtc.PnPeer p0 = global::Java.Lang.Object.GetObject<global::ME.Kevingleason.Pnwebrtc.PnPeer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnPeerStatusChanged (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onPeerStatusChanged_Lme_kevingleason_pnwebrtc_PnPeer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='me.kevingleason.pnwebrtc']/class[@name='PnRTCListener']/method[@name='onPeerStatusChanged' and count(parameter)=1 and parameter[1][@type='me.kevingleason.pnwebrtc.PnPeer']]"
		[Register ("onPeerStatusChanged", "(Lme/kevingleason/pnwebrtc/PnPeer;)V", "GetOnPeerStatusChanged_Lme_kevingleason_pnwebrtc_PnPeer_Handler")]
		public virtual unsafe void OnPeerStatusChanged (global::ME.Kevingleason.Pnwebrtc.PnPeer p0)
		{
			if (id_onPeerStatusChanged_Lme_kevingleason_pnwebrtc_PnPeer_ == IntPtr.Zero)
				id_onPeerStatusChanged_Lme_kevingleason_pnwebrtc_PnPeer_ = JNIEnv.GetMethodID (class_ref, "onPeerStatusChanged", "(Lme/kevingleason/pnwebrtc/PnPeer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onPeerStatusChanged_Lme_kevingleason_pnwebrtc_PnPeer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPeerStatusChanged", "(Lme/kevingleason/pnwebrtc/PnPeer;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onRemoveRemoteStream_Lorg_webrtc_MediaStream_Lme_kevingleason_pnwebrtc_PnPeer_;
#pragma warning disable 0169
		static Delegate GetOnRemoveRemoteStream_Lorg_webrtc_MediaStream_Lme_kevingleason_pnwebrtc_PnPeer_Handler ()
		{
			if (cb_onRemoveRemoteStream_Lorg_webrtc_MediaStream_Lme_kevingleason_pnwebrtc_PnPeer_ == null)
				cb_onRemoveRemoteStream_Lorg_webrtc_MediaStream_Lme_kevingleason_pnwebrtc_PnPeer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnRemoveRemoteStream_Lorg_webrtc_MediaStream_Lme_kevingleason_pnwebrtc_PnPeer_);
			return cb_onRemoveRemoteStream_Lorg_webrtc_MediaStream_Lme_kevingleason_pnwebrtc_PnPeer_;
		}

		static void n_OnRemoveRemoteStream_Lorg_webrtc_MediaStream_Lme_kevingleason_pnwebrtc_PnPeer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::ME.Kevingleason.Pnwebrtc.PnRTCListener __this = global::Java.Lang.Object.GetObject<global::ME.Kevingleason.Pnwebrtc.PnRTCListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.MediaStream p0 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaStream> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::ME.Kevingleason.Pnwebrtc.PnPeer p1 = global::Java.Lang.Object.GetObject<global::ME.Kevingleason.Pnwebrtc.PnPeer> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnRemoveRemoteStream (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onRemoveRemoteStream_Lorg_webrtc_MediaStream_Lme_kevingleason_pnwebrtc_PnPeer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='me.kevingleason.pnwebrtc']/class[@name='PnRTCListener']/method[@name='onRemoveRemoteStream' and count(parameter)=2 and parameter[1][@type='org.webrtc.MediaStream'] and parameter[2][@type='me.kevingleason.pnwebrtc.PnPeer']]"
		[Register ("onRemoveRemoteStream", "(Lorg/webrtc/MediaStream;Lme/kevingleason/pnwebrtc/PnPeer;)V", "GetOnRemoveRemoteStream_Lorg_webrtc_MediaStream_Lme_kevingleason_pnwebrtc_PnPeer_Handler")]
		public virtual unsafe void OnRemoveRemoteStream (global::Org.Webrtc.MediaStream p0, global::ME.Kevingleason.Pnwebrtc.PnPeer p1)
		{
			if (id_onRemoveRemoteStream_Lorg_webrtc_MediaStream_Lme_kevingleason_pnwebrtc_PnPeer_ == IntPtr.Zero)
				id_onRemoveRemoteStream_Lorg_webrtc_MediaStream_Lme_kevingleason_pnwebrtc_PnPeer_ = JNIEnv.GetMethodID (class_ref, "onRemoveRemoteStream", "(Lorg/webrtc/MediaStream;Lme/kevingleason/pnwebrtc/PnPeer;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onRemoveRemoteStream_Lorg_webrtc_MediaStream_Lme_kevingleason_pnwebrtc_PnPeer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onRemoveRemoteStream", "(Lorg/webrtc/MediaStream;Lme/kevingleason/pnwebrtc/PnPeer;)V"), __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("me/kevingleason/pnwebrtc/PnRTCListener", DoNotGenerateAcw=true)]
	internal partial class PnRTCListenerInvoker : PnRTCListener {

		public PnRTCListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (PnRTCListenerInvoker); }
		}

	}

}
