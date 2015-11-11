using System;
using System.Collections.Generic;
using Android.Runtime;

namespace ME.Kevingleason.Pnwebrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='me.kevingleason.pnwebrtc']/class[@name='PnPeer']"
	[global::Android.Runtime.Register ("me/kevingleason/pnwebrtc/PnPeer", DoNotGenerateAcw=true)]
	public partial class PnPeer : global::Java.Lang.Object, global::Org.Webrtc.PeerConnection.IObserver, global::Org.Webrtc.ISdpObserver {


		// Metadata.xml XPath field reference: path="/api/package[@name='me.kevingleason.pnwebrtc']/class[@name='PnPeer']/field[@name='STATUS_CONNECTED']"
		[Register ("STATUS_CONNECTED")]
		public const string StatusConnected = (string) "CONNECTED";

		// Metadata.xml XPath field reference: path="/api/package[@name='me.kevingleason.pnwebrtc']/class[@name='PnPeer']/field[@name='STATUS_CONNECTING']"
		[Register ("STATUS_CONNECTING")]
		public const string StatusConnecting = (string) "CONNECTING";

		// Metadata.xml XPath field reference: path="/api/package[@name='me.kevingleason.pnwebrtc']/class[@name='PnPeer']/field[@name='STATUS_DISCONNECTED']"
		[Register ("STATUS_DISCONNECTED")]
		public const string StatusDisconnected = (string) "DISCONNECTED";

		// Metadata.xml XPath field reference: path="/api/package[@name='me.kevingleason.pnwebrtc']/class[@name='PnPeer']/field[@name='TAG']"
		[Register ("TAG")]
		public const string Tag = (string) "PnPeer";

		// Metadata.xml XPath field reference: path="/api/package[@name='me.kevingleason.pnwebrtc']/class[@name='PnPeer']/field[@name='TYPE_ANSWER']"
		[Register ("TYPE_ANSWER")]
		public const string TypeAnswer = (string) "answer";

		// Metadata.xml XPath field reference: path="/api/package[@name='me.kevingleason.pnwebrtc']/class[@name='PnPeer']/field[@name='TYPE_NONE']"
		[Register ("TYPE_NONE")]
		public const string TypeNone = (string) "NONE";

		// Metadata.xml XPath field reference: path="/api/package[@name='me.kevingleason.pnwebrtc']/class[@name='PnPeer']/field[@name='TYPE_OFFER']"
		[Register ("TYPE_OFFER")]
		public const string TypeOffer = (string) "offer";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("me/kevingleason/pnwebrtc/PnPeer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PnPeer); }
		}

		protected PnPeer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_isDialed;
#pragma warning disable 0169
		static Delegate GetIsDialedHandler ()
		{
			if (cb_isDialed == null)
				cb_isDialed = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDialed);
			return cb_isDialed;
		}

		static bool n_IsDialed (IntPtr jnienv, IntPtr native__this)
		{
			global::ME.Kevingleason.Pnwebrtc.PnPeer __this = global::Java.Lang.Object.GetObject<global::ME.Kevingleason.Pnwebrtc.PnPeer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Dialed;
		}
#pragma warning restore 0169

		static Delegate cb_setDialed_Z;
#pragma warning disable 0169
		static Delegate GetSetDialed_ZHandler ()
		{
			if (cb_setDialed_Z == null)
				cb_setDialed_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDialed_Z);
			return cb_setDialed_Z;
		}

		static void n_SetDialed_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::ME.Kevingleason.Pnwebrtc.PnPeer __this = global::Java.Lang.Object.GetObject<global::ME.Kevingleason.Pnwebrtc.PnPeer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dialed = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isDialed;
		static IntPtr id_setDialed_Z;
		public virtual unsafe bool Dialed {
			// Metadata.xml XPath method reference: path="/api/package[@name='me.kevingleason.pnwebrtc']/class[@name='PnPeer']/method[@name='isDialed' and count(parameter)=0]"
			[Register ("isDialed", "()Z", "GetIsDialedHandler")]
			get {
				if (id_isDialed == IntPtr.Zero)
					id_isDialed = JNIEnv.GetMethodID (class_ref, "isDialed", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isDialed);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isDialed", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='me.kevingleason.pnwebrtc']/class[@name='PnPeer']/method[@name='setDialed' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setDialed", "(Z)V", "GetSetDialed_ZHandler")]
			set {
				if (id_setDialed_Z == IntPtr.Zero)
					id_setDialed_Z = JNIEnv.GetMethodID (class_ref, "setDialed", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setDialed_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDialed", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getId;
#pragma warning disable 0169
		static Delegate GetGetIdHandler ()
		{
			if (cb_getId == null)
				cb_getId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetId);
			return cb_getId;
		}

		static IntPtr n_GetId (IntPtr jnienv, IntPtr native__this)
		{
			global::ME.Kevingleason.Pnwebrtc.PnPeer __this = global::Java.Lang.Object.GetObject<global::ME.Kevingleason.Pnwebrtc.PnPeer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Id);
		}
#pragma warning restore 0169

		static IntPtr id_getId;
		public virtual unsafe string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='me.kevingleason.pnwebrtc']/class[@name='PnPeer']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Ljava/lang/String;", "GetGetIdHandler")]
			get {
				if (id_getId == IntPtr.Zero)
					id_getId = JNIEnv.GetMethodID (class_ref, "getId", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPc;
#pragma warning disable 0169
		static Delegate GetGetPcHandler ()
		{
			if (cb_getPc == null)
				cb_getPc = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPc);
			return cb_getPc;
		}

		static IntPtr n_GetPc (IntPtr jnienv, IntPtr native__this)
		{
			global::ME.Kevingleason.Pnwebrtc.PnPeer __this = global::Java.Lang.Object.GetObject<global::ME.Kevingleason.Pnwebrtc.PnPeer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Pc);
		}
#pragma warning restore 0169

		static IntPtr id_getPc;
		public virtual unsafe global::Org.Webrtc.PeerConnection Pc {
			// Metadata.xml XPath method reference: path="/api/package[@name='me.kevingleason.pnwebrtc']/class[@name='PnPeer']/method[@name='getPc' and count(parameter)=0]"
			[Register ("getPc", "()Lorg/webrtc/PeerConnection;", "GetGetPcHandler")]
			get {
				if (id_getPc == IntPtr.Zero)
					id_getPc = JNIEnv.GetMethodID (class_ref, "getPc", "()Lorg/webrtc/PeerConnection;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection> (JNIEnv.CallObjectMethod  (Handle, id_getPc), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPc", "()Lorg/webrtc/PeerConnection;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isReceived;
#pragma warning disable 0169
		static Delegate GetIsReceivedHandler ()
		{
			if (cb_isReceived == null)
				cb_isReceived = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsReceived);
			return cb_isReceived;
		}

		static bool n_IsReceived (IntPtr jnienv, IntPtr native__this)
		{
			global::ME.Kevingleason.Pnwebrtc.PnPeer __this = global::Java.Lang.Object.GetObject<global::ME.Kevingleason.Pnwebrtc.PnPeer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Received;
		}
#pragma warning restore 0169

		static Delegate cb_setReceived_Z;
#pragma warning disable 0169
		static Delegate GetSetReceived_ZHandler ()
		{
			if (cb_setReceived_Z == null)
				cb_setReceived_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetReceived_Z);
			return cb_setReceived_Z;
		}

		static void n_SetReceived_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::ME.Kevingleason.Pnwebrtc.PnPeer __this = global::Java.Lang.Object.GetObject<global::ME.Kevingleason.Pnwebrtc.PnPeer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Received = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isReceived;
		static IntPtr id_setReceived_Z;
		public virtual unsafe bool Received {
			// Metadata.xml XPath method reference: path="/api/package[@name='me.kevingleason.pnwebrtc']/class[@name='PnPeer']/method[@name='isReceived' and count(parameter)=0]"
			[Register ("isReceived", "()Z", "GetIsReceivedHandler")]
			get {
				if (id_isReceived == IntPtr.Zero)
					id_isReceived = JNIEnv.GetMethodID (class_ref, "isReceived", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isReceived);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isReceived", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='me.kevingleason.pnwebrtc']/class[@name='PnPeer']/method[@name='setReceived' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setReceived", "(Z)V", "GetSetReceived_ZHandler")]
			set {
				if (id_setReceived_Z == IntPtr.Zero)
					id_setReceived_Z = JNIEnv.GetMethodID (class_ref, "setReceived", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setReceived_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setReceived", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getStatus;
#pragma warning disable 0169
		static Delegate GetGetStatusHandler ()
		{
			if (cb_getStatus == null)
				cb_getStatus = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStatus);
			return cb_getStatus;
		}

		static IntPtr n_GetStatus (IntPtr jnienv, IntPtr native__this)
		{
			global::ME.Kevingleason.Pnwebrtc.PnPeer __this = global::Java.Lang.Object.GetObject<global::ME.Kevingleason.Pnwebrtc.PnPeer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Status);
		}
#pragma warning restore 0169

		static Delegate cb_setStatus_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetStatus_Ljava_lang_String_Handler ()
		{
			if (cb_setStatus_Ljava_lang_String_ == null)
				cb_setStatus_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetStatus_Ljava_lang_String_);
			return cb_setStatus_Ljava_lang_String_;
		}

		static void n_SetStatus_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::ME.Kevingleason.Pnwebrtc.PnPeer __this = global::Java.Lang.Object.GetObject<global::ME.Kevingleason.Pnwebrtc.PnPeer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Status = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getStatus;
		static IntPtr id_setStatus_Ljava_lang_String_;
		public virtual unsafe string Status {
			// Metadata.xml XPath method reference: path="/api/package[@name='me.kevingleason.pnwebrtc']/class[@name='PnPeer']/method[@name='getStatus' and count(parameter)=0]"
			[Register ("getStatus", "()Ljava/lang/String;", "GetGetStatusHandler")]
			get {
				if (id_getStatus == IntPtr.Zero)
					id_getStatus = JNIEnv.GetMethodID (class_ref, "getStatus", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getStatus), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStatus", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='me.kevingleason.pnwebrtc']/class[@name='PnPeer']/method[@name='setStatus' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setStatus", "(Ljava/lang/String;)V", "GetSetStatus_Ljava_lang_String_Handler")]
			set {
				if (id_setStatus_Ljava_lang_String_ == IntPtr.Zero)
					id_setStatus_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setStatus", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setStatus_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStatus", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetType);
			return cb_getType;
		}

		static IntPtr n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			global::ME.Kevingleason.Pnwebrtc.PnPeer __this = global::Java.Lang.Object.GetObject<global::ME.Kevingleason.Pnwebrtc.PnPeer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Type);
		}
#pragma warning restore 0169

		static Delegate cb_setType_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetType_Ljava_lang_String_Handler ()
		{
			if (cb_setType_Ljava_lang_String_ == null)
				cb_setType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetType_Ljava_lang_String_);
			return cb_setType_Ljava_lang_String_;
		}

		static void n_SetType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::ME.Kevingleason.Pnwebrtc.PnPeer __this = global::Java.Lang.Object.GetObject<global::ME.Kevingleason.Pnwebrtc.PnPeer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Type = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getType;
		static IntPtr id_setType_Ljava_lang_String_;
		public virtual unsafe string Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='me.kevingleason.pnwebrtc']/class[@name='PnPeer']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()Ljava/lang/String;", "GetGetTypeHandler")]
			get {
				if (id_getType == IntPtr.Zero)
					id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getType), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='me.kevingleason.pnwebrtc']/class[@name='PnPeer']/method[@name='setType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setType", "(Ljava/lang/String;)V", "GetSetType_Ljava_lang_String_Handler")]
			set {
				if (id_setType_Ljava_lang_String_ == IntPtr.Zero)
					id_setType_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setType", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setType_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setType", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_hangup;
#pragma warning disable 0169
		static Delegate GetHangupHandler ()
		{
			if (cb_hangup == null)
				cb_hangup = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Hangup);
			return cb_hangup;
		}

		static void n_Hangup (IntPtr jnienv, IntPtr native__this)
		{
			global::ME.Kevingleason.Pnwebrtc.PnPeer __this = global::Java.Lang.Object.GetObject<global::ME.Kevingleason.Pnwebrtc.PnPeer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Hangup ();
		}
#pragma warning restore 0169

		static IntPtr id_hangup;
		// Metadata.xml XPath method reference: path="/api/package[@name='me.kevingleason.pnwebrtc']/class[@name='PnPeer']/method[@name='hangup' and count(parameter)=0]"
		[Register ("hangup", "()V", "GetHangupHandler")]
		public virtual unsafe void Hangup ()
		{
			if (id_hangup == IntPtr.Zero)
				id_hangup = JNIEnv.GetMethodID (class_ref, "hangup", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_hangup);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hangup", "()V"));
			} finally {
			}
		}

		static Delegate cb_onAddStream_Lorg_webrtc_MediaStream_;
#pragma warning disable 0169
		static Delegate GetOnAddStream_Lorg_webrtc_MediaStream_Handler ()
		{
			if (cb_onAddStream_Lorg_webrtc_MediaStream_ == null)
				cb_onAddStream_Lorg_webrtc_MediaStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnAddStream_Lorg_webrtc_MediaStream_);
			return cb_onAddStream_Lorg_webrtc_MediaStream_;
		}

		static void n_OnAddStream_Lorg_webrtc_MediaStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::ME.Kevingleason.Pnwebrtc.PnPeer __this = global::Java.Lang.Object.GetObject<global::ME.Kevingleason.Pnwebrtc.PnPeer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.MediaStream p0 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaStream> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnAddStream (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onAddStream_Lorg_webrtc_MediaStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='me.kevingleason.pnwebrtc']/class[@name='PnPeer']/method[@name='onAddStream' and count(parameter)=1 and parameter[1][@type='org.webrtc.MediaStream']]"
		[Register ("onAddStream", "(Lorg/webrtc/MediaStream;)V", "GetOnAddStream_Lorg_webrtc_MediaStream_Handler")]
		public virtual unsafe void OnAddStream (global::Org.Webrtc.MediaStream p0)
		{
			if (id_onAddStream_Lorg_webrtc_MediaStream_ == IntPtr.Zero)
				id_onAddStream_Lorg_webrtc_MediaStream_ = JNIEnv.GetMethodID (class_ref, "onAddStream", "(Lorg/webrtc/MediaStream;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onAddStream_Lorg_webrtc_MediaStream_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onAddStream", "(Lorg/webrtc/MediaStream;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onCreateFailure_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnCreateFailure_Ljava_lang_String_Handler ()
		{
			if (cb_onCreateFailure_Ljava_lang_String_ == null)
				cb_onCreateFailure_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCreateFailure_Ljava_lang_String_);
			return cb_onCreateFailure_Ljava_lang_String_;
		}

		static void n_OnCreateFailure_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::ME.Kevingleason.Pnwebrtc.PnPeer __this = global::Java.Lang.Object.GetObject<global::ME.Kevingleason.Pnwebrtc.PnPeer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCreateFailure (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onCreateFailure_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='me.kevingleason.pnwebrtc']/class[@name='PnPeer']/method[@name='onCreateFailure' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onCreateFailure", "(Ljava/lang/String;)V", "GetOnCreateFailure_Ljava_lang_String_Handler")]
		public virtual unsafe void OnCreateFailure (string p0)
		{
			if (id_onCreateFailure_Ljava_lang_String_ == IntPtr.Zero)
				id_onCreateFailure_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onCreateFailure", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onCreateFailure_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCreateFailure", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_onCreateSuccess_Lorg_webrtc_SessionDescription_;
#pragma warning disable 0169
		static Delegate GetOnCreateSuccess_Lorg_webrtc_SessionDescription_Handler ()
		{
			if (cb_onCreateSuccess_Lorg_webrtc_SessionDescription_ == null)
				cb_onCreateSuccess_Lorg_webrtc_SessionDescription_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCreateSuccess_Lorg_webrtc_SessionDescription_);
			return cb_onCreateSuccess_Lorg_webrtc_SessionDescription_;
		}

		static void n_OnCreateSuccess_Lorg_webrtc_SessionDescription_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::ME.Kevingleason.Pnwebrtc.PnPeer __this = global::Java.Lang.Object.GetObject<global::ME.Kevingleason.Pnwebrtc.PnPeer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.SessionDescription p0 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.SessionDescription> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCreateSuccess (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onCreateSuccess_Lorg_webrtc_SessionDescription_;
		// Metadata.xml XPath method reference: path="/api/package[@name='me.kevingleason.pnwebrtc']/class[@name='PnPeer']/method[@name='onCreateSuccess' and count(parameter)=1 and parameter[1][@type='org.webrtc.SessionDescription']]"
		[Register ("onCreateSuccess", "(Lorg/webrtc/SessionDescription;)V", "GetOnCreateSuccess_Lorg_webrtc_SessionDescription_Handler")]
		public virtual unsafe void OnCreateSuccess (global::Org.Webrtc.SessionDescription p0)
		{
			if (id_onCreateSuccess_Lorg_webrtc_SessionDescription_ == IntPtr.Zero)
				id_onCreateSuccess_Lorg_webrtc_SessionDescription_ = JNIEnv.GetMethodID (class_ref, "onCreateSuccess", "(Lorg/webrtc/SessionDescription;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onCreateSuccess_Lorg_webrtc_SessionDescription_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCreateSuccess", "(Lorg/webrtc/SessionDescription;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onDataChannel_Lorg_webrtc_DataChannel_;
#pragma warning disable 0169
		static Delegate GetOnDataChannel_Lorg_webrtc_DataChannel_Handler ()
		{
			if (cb_onDataChannel_Lorg_webrtc_DataChannel_ == null)
				cb_onDataChannel_Lorg_webrtc_DataChannel_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDataChannel_Lorg_webrtc_DataChannel_);
			return cb_onDataChannel_Lorg_webrtc_DataChannel_;
		}

		static void n_OnDataChannel_Lorg_webrtc_DataChannel_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::ME.Kevingleason.Pnwebrtc.PnPeer __this = global::Java.Lang.Object.GetObject<global::ME.Kevingleason.Pnwebrtc.PnPeer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.DataChannel p0 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.DataChannel> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDataChannel (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onDataChannel_Lorg_webrtc_DataChannel_;
		// Metadata.xml XPath method reference: path="/api/package[@name='me.kevingleason.pnwebrtc']/class[@name='PnPeer']/method[@name='onDataChannel' and count(parameter)=1 and parameter[1][@type='org.webrtc.DataChannel']]"
		[Register ("onDataChannel", "(Lorg/webrtc/DataChannel;)V", "GetOnDataChannel_Lorg_webrtc_DataChannel_Handler")]
		public virtual unsafe void OnDataChannel (global::Org.Webrtc.DataChannel p0)
		{
			if (id_onDataChannel_Lorg_webrtc_DataChannel_ == IntPtr.Zero)
				id_onDataChannel_Lorg_webrtc_DataChannel_ = JNIEnv.GetMethodID (class_ref, "onDataChannel", "(Lorg/webrtc/DataChannel;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onDataChannel_Lorg_webrtc_DataChannel_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDataChannel", "(Lorg/webrtc/DataChannel;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onIceCandidate_Lorg_webrtc_IceCandidate_;
#pragma warning disable 0169
		static Delegate GetOnIceCandidate_Lorg_webrtc_IceCandidate_Handler ()
		{
			if (cb_onIceCandidate_Lorg_webrtc_IceCandidate_ == null)
				cb_onIceCandidate_Lorg_webrtc_IceCandidate_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnIceCandidate_Lorg_webrtc_IceCandidate_);
			return cb_onIceCandidate_Lorg_webrtc_IceCandidate_;
		}

		static void n_OnIceCandidate_Lorg_webrtc_IceCandidate_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::ME.Kevingleason.Pnwebrtc.PnPeer __this = global::Java.Lang.Object.GetObject<global::ME.Kevingleason.Pnwebrtc.PnPeer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.IceCandidate p0 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IceCandidate> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnIceCandidate (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onIceCandidate_Lorg_webrtc_IceCandidate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='me.kevingleason.pnwebrtc']/class[@name='PnPeer']/method[@name='onIceCandidate' and count(parameter)=1 and parameter[1][@type='org.webrtc.IceCandidate']]"
		[Register ("onIceCandidate", "(Lorg/webrtc/IceCandidate;)V", "GetOnIceCandidate_Lorg_webrtc_IceCandidate_Handler")]
		public virtual unsafe void OnIceCandidate (global::Org.Webrtc.IceCandidate p0)
		{
			if (id_onIceCandidate_Lorg_webrtc_IceCandidate_ == IntPtr.Zero)
				id_onIceCandidate_Lorg_webrtc_IceCandidate_ = JNIEnv.GetMethodID (class_ref, "onIceCandidate", "(Lorg/webrtc/IceCandidate;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onIceCandidate_Lorg_webrtc_IceCandidate_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onIceCandidate", "(Lorg/webrtc/IceCandidate;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onIceConnectionChange_Lorg_webrtc_PeerConnection_IceConnectionState_;
#pragma warning disable 0169
		static Delegate GetOnIceConnectionChange_Lorg_webrtc_PeerConnection_IceConnectionState_Handler ()
		{
			if (cb_onIceConnectionChange_Lorg_webrtc_PeerConnection_IceConnectionState_ == null)
				cb_onIceConnectionChange_Lorg_webrtc_PeerConnection_IceConnectionState_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnIceConnectionChange_Lorg_webrtc_PeerConnection_IceConnectionState_);
			return cb_onIceConnectionChange_Lorg_webrtc_PeerConnection_IceConnectionState_;
		}

		static void n_OnIceConnectionChange_Lorg_webrtc_PeerConnection_IceConnectionState_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::ME.Kevingleason.Pnwebrtc.PnPeer __this = global::Java.Lang.Object.GetObject<global::ME.Kevingleason.Pnwebrtc.PnPeer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.PeerConnection.IceConnectionState p0 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.IceConnectionState> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnIceConnectionChange (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onIceConnectionChange_Lorg_webrtc_PeerConnection_IceConnectionState_;
		// Metadata.xml XPath method reference: path="/api/package[@name='me.kevingleason.pnwebrtc']/class[@name='PnPeer']/method[@name='onIceConnectionChange' and count(parameter)=1 and parameter[1][@type='org.webrtc.PeerConnection.IceConnectionState']]"
		[Register ("onIceConnectionChange", "(Lorg/webrtc/PeerConnection$IceConnectionState;)V", "GetOnIceConnectionChange_Lorg_webrtc_PeerConnection_IceConnectionState_Handler")]
		public virtual unsafe void OnIceConnectionChange (global::Org.Webrtc.PeerConnection.IceConnectionState p0)
		{
			if (id_onIceConnectionChange_Lorg_webrtc_PeerConnection_IceConnectionState_ == IntPtr.Zero)
				id_onIceConnectionChange_Lorg_webrtc_PeerConnection_IceConnectionState_ = JNIEnv.GetMethodID (class_ref, "onIceConnectionChange", "(Lorg/webrtc/PeerConnection$IceConnectionState;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onIceConnectionChange_Lorg_webrtc_PeerConnection_IceConnectionState_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onIceConnectionChange", "(Lorg/webrtc/PeerConnection$IceConnectionState;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onIceConnectionReceivingChange_Z;
#pragma warning disable 0169
		static Delegate GetOnIceConnectionReceivingChange_ZHandler ()
		{
			if (cb_onIceConnectionReceivingChange_Z == null)
				cb_onIceConnectionReceivingChange_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_OnIceConnectionReceivingChange_Z);
			return cb_onIceConnectionReceivingChange_Z;
		}

		static void n_OnIceConnectionReceivingChange_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::ME.Kevingleason.Pnwebrtc.PnPeer __this = global::Java.Lang.Object.GetObject<global::ME.Kevingleason.Pnwebrtc.PnPeer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnIceConnectionReceivingChange (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onIceConnectionReceivingChange_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='me.kevingleason.pnwebrtc']/class[@name='PnPeer']/method[@name='onIceConnectionReceivingChange' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("onIceConnectionReceivingChange", "(Z)V", "GetOnIceConnectionReceivingChange_ZHandler")]
		public virtual unsafe void OnIceConnectionReceivingChange (bool p0)
		{
			if (id_onIceConnectionReceivingChange_Z == IntPtr.Zero)
				id_onIceConnectionReceivingChange_Z = JNIEnv.GetMethodID (class_ref, "onIceConnectionReceivingChange", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onIceConnectionReceivingChange_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onIceConnectionReceivingChange", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onIceGatheringChange_Lorg_webrtc_PeerConnection_IceGatheringState_;
#pragma warning disable 0169
		static Delegate GetOnIceGatheringChange_Lorg_webrtc_PeerConnection_IceGatheringState_Handler ()
		{
			if (cb_onIceGatheringChange_Lorg_webrtc_PeerConnection_IceGatheringState_ == null)
				cb_onIceGatheringChange_Lorg_webrtc_PeerConnection_IceGatheringState_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnIceGatheringChange_Lorg_webrtc_PeerConnection_IceGatheringState_);
			return cb_onIceGatheringChange_Lorg_webrtc_PeerConnection_IceGatheringState_;
		}

		static void n_OnIceGatheringChange_Lorg_webrtc_PeerConnection_IceGatheringState_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::ME.Kevingleason.Pnwebrtc.PnPeer __this = global::Java.Lang.Object.GetObject<global::ME.Kevingleason.Pnwebrtc.PnPeer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.PeerConnection.IceGatheringState p0 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.IceGatheringState> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnIceGatheringChange (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onIceGatheringChange_Lorg_webrtc_PeerConnection_IceGatheringState_;
		// Metadata.xml XPath method reference: path="/api/package[@name='me.kevingleason.pnwebrtc']/class[@name='PnPeer']/method[@name='onIceGatheringChange' and count(parameter)=1 and parameter[1][@type='org.webrtc.PeerConnection.IceGatheringState']]"
		[Register ("onIceGatheringChange", "(Lorg/webrtc/PeerConnection$IceGatheringState;)V", "GetOnIceGatheringChange_Lorg_webrtc_PeerConnection_IceGatheringState_Handler")]
		public virtual unsafe void OnIceGatheringChange (global::Org.Webrtc.PeerConnection.IceGatheringState p0)
		{
			if (id_onIceGatheringChange_Lorg_webrtc_PeerConnection_IceGatheringState_ == IntPtr.Zero)
				id_onIceGatheringChange_Lorg_webrtc_PeerConnection_IceGatheringState_ = JNIEnv.GetMethodID (class_ref, "onIceGatheringChange", "(Lorg/webrtc/PeerConnection$IceGatheringState;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onIceGatheringChange_Lorg_webrtc_PeerConnection_IceGatheringState_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onIceGatheringChange", "(Lorg/webrtc/PeerConnection$IceGatheringState;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onRemoveStream_Lorg_webrtc_MediaStream_;
#pragma warning disable 0169
		static Delegate GetOnRemoveStream_Lorg_webrtc_MediaStream_Handler ()
		{
			if (cb_onRemoveStream_Lorg_webrtc_MediaStream_ == null)
				cb_onRemoveStream_Lorg_webrtc_MediaStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnRemoveStream_Lorg_webrtc_MediaStream_);
			return cb_onRemoveStream_Lorg_webrtc_MediaStream_;
		}

		static void n_OnRemoveStream_Lorg_webrtc_MediaStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::ME.Kevingleason.Pnwebrtc.PnPeer __this = global::Java.Lang.Object.GetObject<global::ME.Kevingleason.Pnwebrtc.PnPeer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.MediaStream p0 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaStream> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnRemoveStream (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onRemoveStream_Lorg_webrtc_MediaStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='me.kevingleason.pnwebrtc']/class[@name='PnPeer']/method[@name='onRemoveStream' and count(parameter)=1 and parameter[1][@type='org.webrtc.MediaStream']]"
		[Register ("onRemoveStream", "(Lorg/webrtc/MediaStream;)V", "GetOnRemoveStream_Lorg_webrtc_MediaStream_Handler")]
		public virtual unsafe void OnRemoveStream (global::Org.Webrtc.MediaStream p0)
		{
			if (id_onRemoveStream_Lorg_webrtc_MediaStream_ == IntPtr.Zero)
				id_onRemoveStream_Lorg_webrtc_MediaStream_ = JNIEnv.GetMethodID (class_ref, "onRemoveStream", "(Lorg/webrtc/MediaStream;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onRemoveStream_Lorg_webrtc_MediaStream_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onRemoveStream", "(Lorg/webrtc/MediaStream;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onRenegotiationNeeded;
#pragma warning disable 0169
		static Delegate GetOnRenegotiationNeededHandler ()
		{
			if (cb_onRenegotiationNeeded == null)
				cb_onRenegotiationNeeded = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnRenegotiationNeeded);
			return cb_onRenegotiationNeeded;
		}

		static void n_OnRenegotiationNeeded (IntPtr jnienv, IntPtr native__this)
		{
			global::ME.Kevingleason.Pnwebrtc.PnPeer __this = global::Java.Lang.Object.GetObject<global::ME.Kevingleason.Pnwebrtc.PnPeer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnRenegotiationNeeded ();
		}
#pragma warning restore 0169

		static IntPtr id_onRenegotiationNeeded;
		// Metadata.xml XPath method reference: path="/api/package[@name='me.kevingleason.pnwebrtc']/class[@name='PnPeer']/method[@name='onRenegotiationNeeded' and count(parameter)=0]"
		[Register ("onRenegotiationNeeded", "()V", "GetOnRenegotiationNeededHandler")]
		public virtual unsafe void OnRenegotiationNeeded ()
		{
			if (id_onRenegotiationNeeded == IntPtr.Zero)
				id_onRenegotiationNeeded = JNIEnv.GetMethodID (class_ref, "onRenegotiationNeeded", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onRenegotiationNeeded);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onRenegotiationNeeded", "()V"));
			} finally {
			}
		}

		static Delegate cb_onSetFailure_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnSetFailure_Ljava_lang_String_Handler ()
		{
			if (cb_onSetFailure_Ljava_lang_String_ == null)
				cb_onSetFailure_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSetFailure_Ljava_lang_String_);
			return cb_onSetFailure_Ljava_lang_String_;
		}

		static void n_OnSetFailure_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::ME.Kevingleason.Pnwebrtc.PnPeer __this = global::Java.Lang.Object.GetObject<global::ME.Kevingleason.Pnwebrtc.PnPeer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSetFailure (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onSetFailure_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='me.kevingleason.pnwebrtc']/class[@name='PnPeer']/method[@name='onSetFailure' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onSetFailure", "(Ljava/lang/String;)V", "GetOnSetFailure_Ljava_lang_String_Handler")]
		public virtual unsafe void OnSetFailure (string p0)
		{
			if (id_onSetFailure_Ljava_lang_String_ == IntPtr.Zero)
				id_onSetFailure_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onSetFailure", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onSetFailure_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSetFailure", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_onSetSuccess;
#pragma warning disable 0169
		static Delegate GetOnSetSuccessHandler ()
		{
			if (cb_onSetSuccess == null)
				cb_onSetSuccess = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnSetSuccess);
			return cb_onSetSuccess;
		}

		static void n_OnSetSuccess (IntPtr jnienv, IntPtr native__this)
		{
			global::ME.Kevingleason.Pnwebrtc.PnPeer __this = global::Java.Lang.Object.GetObject<global::ME.Kevingleason.Pnwebrtc.PnPeer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnSetSuccess ();
		}
#pragma warning restore 0169

		static IntPtr id_onSetSuccess;
		// Metadata.xml XPath method reference: path="/api/package[@name='me.kevingleason.pnwebrtc']/class[@name='PnPeer']/method[@name='onSetSuccess' and count(parameter)=0]"
		[Register ("onSetSuccess", "()V", "GetOnSetSuccessHandler")]
		public virtual unsafe void OnSetSuccess ()
		{
			if (id_onSetSuccess == IntPtr.Zero)
				id_onSetSuccess = JNIEnv.GetMethodID (class_ref, "onSetSuccess", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onSetSuccess);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSetSuccess", "()V"));
			} finally {
			}
		}

		static Delegate cb_onSignalingChange_Lorg_webrtc_PeerConnection_SignalingState_;
#pragma warning disable 0169
		static Delegate GetOnSignalingChange_Lorg_webrtc_PeerConnection_SignalingState_Handler ()
		{
			if (cb_onSignalingChange_Lorg_webrtc_PeerConnection_SignalingState_ == null)
				cb_onSignalingChange_Lorg_webrtc_PeerConnection_SignalingState_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSignalingChange_Lorg_webrtc_PeerConnection_SignalingState_);
			return cb_onSignalingChange_Lorg_webrtc_PeerConnection_SignalingState_;
		}

		static void n_OnSignalingChange_Lorg_webrtc_PeerConnection_SignalingState_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::ME.Kevingleason.Pnwebrtc.PnPeer __this = global::Java.Lang.Object.GetObject<global::ME.Kevingleason.Pnwebrtc.PnPeer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.PeerConnection.SignalingState p0 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.SignalingState> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSignalingChange (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onSignalingChange_Lorg_webrtc_PeerConnection_SignalingState_;
		// Metadata.xml XPath method reference: path="/api/package[@name='me.kevingleason.pnwebrtc']/class[@name='PnPeer']/method[@name='onSignalingChange' and count(parameter)=1 and parameter[1][@type='org.webrtc.PeerConnection.SignalingState']]"
		[Register ("onSignalingChange", "(Lorg/webrtc/PeerConnection$SignalingState;)V", "GetOnSignalingChange_Lorg_webrtc_PeerConnection_SignalingState_Handler")]
		public virtual unsafe void OnSignalingChange (global::Org.Webrtc.PeerConnection.SignalingState p0)
		{
			if (id_onSignalingChange_Lorg_webrtc_PeerConnection_SignalingState_ == IntPtr.Zero)
				id_onSignalingChange_Lorg_webrtc_PeerConnection_SignalingState_ = JNIEnv.GetMethodID (class_ref, "onSignalingChange", "(Lorg/webrtc/PeerConnection$SignalingState;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onSignalingChange_Lorg_webrtc_PeerConnection_SignalingState_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSignalingChange", "(Lorg/webrtc/PeerConnection$SignalingState;)V"), __args);
			} finally {
			}
		}

	}
}
