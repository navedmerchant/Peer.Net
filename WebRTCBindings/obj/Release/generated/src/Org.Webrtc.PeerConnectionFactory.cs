using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Webrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnectionFactory']"
	[global::Android.Runtime.Register ("org/webrtc/PeerConnectionFactory", DoNotGenerateAcw=true)]
	public partial class PeerConnectionFactory : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnectionFactory.Options']"
		[global::Android.Runtime.Register ("org/webrtc/PeerConnectionFactory$Options", DoNotGenerateAcw=true)]
		public partial class Options : global::Java.Lang.Object {


			static IntPtr disableEncryption_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnectionFactory.Options']/field[@name='disableEncryption']"
			[Register ("disableEncryption")]
			public bool DisableEncryption {
				get {
					if (disableEncryption_jfieldId == IntPtr.Zero)
						disableEncryption_jfieldId = JNIEnv.GetFieldID (class_ref, "disableEncryption", "Z");
					return JNIEnv.GetBooleanField (Handle, disableEncryption_jfieldId);
				}
				set {
					if (disableEncryption_jfieldId == IntPtr.Zero)
						disableEncryption_jfieldId = JNIEnv.GetFieldID (class_ref, "disableEncryption", "Z");
					try {
						JNIEnv.SetField (Handle, disableEncryption_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr networkIgnoreMask_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnectionFactory.Options']/field[@name='networkIgnoreMask']"
			[Register ("networkIgnoreMask")]
			public int NetworkIgnoreMask {
				get {
					if (networkIgnoreMask_jfieldId == IntPtr.Zero)
						networkIgnoreMask_jfieldId = JNIEnv.GetFieldID (class_ref, "networkIgnoreMask", "I");
					return JNIEnv.GetIntField (Handle, networkIgnoreMask_jfieldId);
				}
				set {
					if (networkIgnoreMask_jfieldId == IntPtr.Zero)
						networkIgnoreMask_jfieldId = JNIEnv.GetFieldID (class_ref, "networkIgnoreMask", "I");
					try {
						JNIEnv.SetField (Handle, networkIgnoreMask_jfieldId, value);
					} finally {
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/webrtc/PeerConnectionFactory$Options", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Options); }
			}

			protected Options (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnectionFactory.Options']/constructor[@name='PeerConnectionFactory.Options' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Options ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (Options)) {
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

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/webrtc/PeerConnectionFactory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PeerConnectionFactory); }
		}

		protected PeerConnectionFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnectionFactory']/constructor[@name='PeerConnectionFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PeerConnectionFactory ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (PeerConnectionFactory)) {
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

		static Delegate cb_createAudioSource_Lorg_webrtc_MediaConstraints_;
#pragma warning disable 0169
		static Delegate GetCreateAudioSource_Lorg_webrtc_MediaConstraints_Handler ()
		{
			if (cb_createAudioSource_Lorg_webrtc_MediaConstraints_ == null)
				cb_createAudioSource_Lorg_webrtc_MediaConstraints_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateAudioSource_Lorg_webrtc_MediaConstraints_);
			return cb_createAudioSource_Lorg_webrtc_MediaConstraints_;
		}

		static IntPtr n_CreateAudioSource_Lorg_webrtc_MediaConstraints_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Webrtc.PeerConnectionFactory __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnectionFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.MediaConstraints p0 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaConstraints> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateAudioSource (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_createAudioSource_Lorg_webrtc_MediaConstraints_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnectionFactory']/method[@name='createAudioSource' and count(parameter)=1 and parameter[1][@type='org.webrtc.MediaConstraints']]"
		[Register ("createAudioSource", "(Lorg/webrtc/MediaConstraints;)Lorg/webrtc/AudioSource;", "GetCreateAudioSource_Lorg_webrtc_MediaConstraints_Handler")]
		public virtual unsafe global::Org.Webrtc.AudioSource CreateAudioSource (global::Org.Webrtc.MediaConstraints p0)
		{
			if (id_createAudioSource_Lorg_webrtc_MediaConstraints_ == IntPtr.Zero)
				id_createAudioSource_Lorg_webrtc_MediaConstraints_ = JNIEnv.GetMethodID (class_ref, "createAudioSource", "(Lorg/webrtc/MediaConstraints;)Lorg/webrtc/AudioSource;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Org.Webrtc.AudioSource __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Webrtc.AudioSource> (JNIEnv.CallObjectMethod  (Handle, id_createAudioSource_Lorg_webrtc_MediaConstraints_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Webrtc.AudioSource> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createAudioSource", "(Lorg/webrtc/MediaConstraints;)Lorg/webrtc/AudioSource;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_createAudioTrack_Ljava_lang_String_Lorg_webrtc_AudioSource_;
#pragma warning disable 0169
		static Delegate GetCreateAudioTrack_Ljava_lang_String_Lorg_webrtc_AudioSource_Handler ()
		{
			if (cb_createAudioTrack_Ljava_lang_String_Lorg_webrtc_AudioSource_ == null)
				cb_createAudioTrack_Ljava_lang_String_Lorg_webrtc_AudioSource_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateAudioTrack_Ljava_lang_String_Lorg_webrtc_AudioSource_);
			return cb_createAudioTrack_Ljava_lang_String_Lorg_webrtc_AudioSource_;
		}

		static IntPtr n_CreateAudioTrack_Ljava_lang_String_Lorg_webrtc_AudioSource_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Webrtc.PeerConnectionFactory __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnectionFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.AudioSource p1 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.AudioSource> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateAudioTrack (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_createAudioTrack_Ljava_lang_String_Lorg_webrtc_AudioSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnectionFactory']/method[@name='createAudioTrack' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.webrtc.AudioSource']]"
		[Register ("createAudioTrack", "(Ljava/lang/String;Lorg/webrtc/AudioSource;)Lorg/webrtc/AudioTrack;", "GetCreateAudioTrack_Ljava_lang_String_Lorg_webrtc_AudioSource_Handler")]
		public virtual unsafe global::Org.Webrtc.AudioTrack CreateAudioTrack (string p0, global::Org.Webrtc.AudioSource p1)
		{
			if (id_createAudioTrack_Ljava_lang_String_Lorg_webrtc_AudioSource_ == IntPtr.Zero)
				id_createAudioTrack_Ljava_lang_String_Lorg_webrtc_AudioSource_ = JNIEnv.GetMethodID (class_ref, "createAudioTrack", "(Ljava/lang/String;Lorg/webrtc/AudioSource;)Lorg/webrtc/AudioTrack;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				global::Org.Webrtc.AudioTrack __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Webrtc.AudioTrack> (JNIEnv.CallObjectMethod  (Handle, id_createAudioTrack_Ljava_lang_String_Lorg_webrtc_AudioSource_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Webrtc.AudioTrack> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createAudioTrack", "(Ljava/lang/String;Lorg/webrtc/AudioSource;)Lorg/webrtc/AudioTrack;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_createLocalMediaStream_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCreateLocalMediaStream_Ljava_lang_String_Handler ()
		{
			if (cb_createLocalMediaStream_Ljava_lang_String_ == null)
				cb_createLocalMediaStream_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateLocalMediaStream_Ljava_lang_String_);
			return cb_createLocalMediaStream_Ljava_lang_String_;
		}

		static IntPtr n_CreateLocalMediaStream_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Webrtc.PeerConnectionFactory __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnectionFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateLocalMediaStream (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_createLocalMediaStream_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnectionFactory']/method[@name='createLocalMediaStream' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("createLocalMediaStream", "(Ljava/lang/String;)Lorg/webrtc/MediaStream;", "GetCreateLocalMediaStream_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Webrtc.MediaStream CreateLocalMediaStream (string p0)
		{
			if (id_createLocalMediaStream_Ljava_lang_String_ == IntPtr.Zero)
				id_createLocalMediaStream_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "createLocalMediaStream", "(Ljava/lang/String;)Lorg/webrtc/MediaStream;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Org.Webrtc.MediaStream __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaStream> (JNIEnv.CallObjectMethod  (Handle, id_createLocalMediaStream_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaStream> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createLocalMediaStream", "(Ljava/lang/String;)Lorg/webrtc/MediaStream;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_createPeerConnection_Ljava_util_List_Lorg_webrtc_MediaConstraints_Lorg_webrtc_PeerConnection_Observer_;
#pragma warning disable 0169
		static Delegate GetCreatePeerConnection_Ljava_util_List_Lorg_webrtc_MediaConstraints_Lorg_webrtc_PeerConnection_Observer_Handler ()
		{
			if (cb_createPeerConnection_Ljava_util_List_Lorg_webrtc_MediaConstraints_Lorg_webrtc_PeerConnection_Observer_ == null)
				cb_createPeerConnection_Ljava_util_List_Lorg_webrtc_MediaConstraints_Lorg_webrtc_PeerConnection_Observer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_CreatePeerConnection_Ljava_util_List_Lorg_webrtc_MediaConstraints_Lorg_webrtc_PeerConnection_Observer_);
			return cb_createPeerConnection_Ljava_util_List_Lorg_webrtc_MediaConstraints_Lorg_webrtc_PeerConnection_Observer_;
		}

		static IntPtr n_CreatePeerConnection_Ljava_util_List_Lorg_webrtc_MediaConstraints_Lorg_webrtc_PeerConnection_Observer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Org.Webrtc.PeerConnectionFactory __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnectionFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Org.Webrtc.PeerConnection.IceServer>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.MediaConstraints p1 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaConstraints> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.PeerConnection.IObserver p2 = (global::Org.Webrtc.PeerConnection.IObserver)global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.IObserver> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreatePeerConnection (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_createPeerConnection_Ljava_util_List_Lorg_webrtc_MediaConstraints_Lorg_webrtc_PeerConnection_Observer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnectionFactory']/method[@name='createPeerConnection' and count(parameter)=3 and parameter[1][@type='java.util.List&lt;org.webrtc.PeerConnection.IceServer&gt;'] and parameter[2][@type='org.webrtc.MediaConstraints'] and parameter[3][@type='org.webrtc.PeerConnection.Observer']]"
		[Register ("createPeerConnection", "(Ljava/util/List;Lorg/webrtc/MediaConstraints;Lorg/webrtc/PeerConnection$Observer;)Lorg/webrtc/PeerConnection;", "GetCreatePeerConnection_Ljava_util_List_Lorg_webrtc_MediaConstraints_Lorg_webrtc_PeerConnection_Observer_Handler")]
		public virtual unsafe global::Org.Webrtc.PeerConnection CreatePeerConnection (global::System.Collections.Generic.IList<global::Org.Webrtc.PeerConnection.IceServer> p0, global::Org.Webrtc.MediaConstraints p1, global::Org.Webrtc.PeerConnection.IObserver p2)
		{
			if (id_createPeerConnection_Ljava_util_List_Lorg_webrtc_MediaConstraints_Lorg_webrtc_PeerConnection_Observer_ == IntPtr.Zero)
				id_createPeerConnection_Ljava_util_List_Lorg_webrtc_MediaConstraints_Lorg_webrtc_PeerConnection_Observer_ = JNIEnv.GetMethodID (class_ref, "createPeerConnection", "(Ljava/util/List;Lorg/webrtc/MediaConstraints;Lorg/webrtc/PeerConnection$Observer;)Lorg/webrtc/PeerConnection;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Org.Webrtc.PeerConnection.IceServer>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				global::Org.Webrtc.PeerConnection __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection> (JNIEnv.CallObjectMethod  (Handle, id_createPeerConnection_Ljava_util_List_Lorg_webrtc_MediaConstraints_Lorg_webrtc_PeerConnection_Observer_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createPeerConnection", "(Ljava/util/List;Lorg/webrtc/MediaConstraints;Lorg/webrtc/PeerConnection$Observer;)Lorg/webrtc/PeerConnection;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_createPeerConnection_Lorg_webrtc_PeerConnection_RTCConfiguration_Lorg_webrtc_MediaConstraints_Lorg_webrtc_PeerConnection_Observer_;
#pragma warning disable 0169
		static Delegate GetCreatePeerConnection_Lorg_webrtc_PeerConnection_RTCConfiguration_Lorg_webrtc_MediaConstraints_Lorg_webrtc_PeerConnection_Observer_Handler ()
		{
			if (cb_createPeerConnection_Lorg_webrtc_PeerConnection_RTCConfiguration_Lorg_webrtc_MediaConstraints_Lorg_webrtc_PeerConnection_Observer_ == null)
				cb_createPeerConnection_Lorg_webrtc_PeerConnection_RTCConfiguration_Lorg_webrtc_MediaConstraints_Lorg_webrtc_PeerConnection_Observer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_CreatePeerConnection_Lorg_webrtc_PeerConnection_RTCConfiguration_Lorg_webrtc_MediaConstraints_Lorg_webrtc_PeerConnection_Observer_);
			return cb_createPeerConnection_Lorg_webrtc_PeerConnection_RTCConfiguration_Lorg_webrtc_MediaConstraints_Lorg_webrtc_PeerConnection_Observer_;
		}

		static IntPtr n_CreatePeerConnection_Lorg_webrtc_PeerConnection_RTCConfiguration_Lorg_webrtc_MediaConstraints_Lorg_webrtc_PeerConnection_Observer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Org.Webrtc.PeerConnectionFactory __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnectionFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.PeerConnection.RTCConfiguration p0 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.RTCConfiguration> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.MediaConstraints p1 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaConstraints> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.PeerConnection.IObserver p2 = (global::Org.Webrtc.PeerConnection.IObserver)global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.IObserver> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreatePeerConnection (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_createPeerConnection_Lorg_webrtc_PeerConnection_RTCConfiguration_Lorg_webrtc_MediaConstraints_Lorg_webrtc_PeerConnection_Observer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnectionFactory']/method[@name='createPeerConnection' and count(parameter)=3 and parameter[1][@type='org.webrtc.PeerConnection.RTCConfiguration'] and parameter[2][@type='org.webrtc.MediaConstraints'] and parameter[3][@type='org.webrtc.PeerConnection.Observer']]"
		[Register ("createPeerConnection", "(Lorg/webrtc/PeerConnection$RTCConfiguration;Lorg/webrtc/MediaConstraints;Lorg/webrtc/PeerConnection$Observer;)Lorg/webrtc/PeerConnection;", "GetCreatePeerConnection_Lorg_webrtc_PeerConnection_RTCConfiguration_Lorg_webrtc_MediaConstraints_Lorg_webrtc_PeerConnection_Observer_Handler")]
		public virtual unsafe global::Org.Webrtc.PeerConnection CreatePeerConnection (global::Org.Webrtc.PeerConnection.RTCConfiguration p0, global::Org.Webrtc.MediaConstraints p1, global::Org.Webrtc.PeerConnection.IObserver p2)
		{
			if (id_createPeerConnection_Lorg_webrtc_PeerConnection_RTCConfiguration_Lorg_webrtc_MediaConstraints_Lorg_webrtc_PeerConnection_Observer_ == IntPtr.Zero)
				id_createPeerConnection_Lorg_webrtc_PeerConnection_RTCConfiguration_Lorg_webrtc_MediaConstraints_Lorg_webrtc_PeerConnection_Observer_ = JNIEnv.GetMethodID (class_ref, "createPeerConnection", "(Lorg/webrtc/PeerConnection$RTCConfiguration;Lorg/webrtc/MediaConstraints;Lorg/webrtc/PeerConnection$Observer;)Lorg/webrtc/PeerConnection;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				global::Org.Webrtc.PeerConnection __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection> (JNIEnv.CallObjectMethod  (Handle, id_createPeerConnection_Lorg_webrtc_PeerConnection_RTCConfiguration_Lorg_webrtc_MediaConstraints_Lorg_webrtc_PeerConnection_Observer_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createPeerConnection", "(Lorg/webrtc/PeerConnection$RTCConfiguration;Lorg/webrtc/MediaConstraints;Lorg/webrtc/PeerConnection$Observer;)Lorg/webrtc/PeerConnection;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_createVideoSource_Lorg_webrtc_VideoCapturer_Lorg_webrtc_MediaConstraints_;
#pragma warning disable 0169
		static Delegate GetCreateVideoSource_Lorg_webrtc_VideoCapturer_Lorg_webrtc_MediaConstraints_Handler ()
		{
			if (cb_createVideoSource_Lorg_webrtc_VideoCapturer_Lorg_webrtc_MediaConstraints_ == null)
				cb_createVideoSource_Lorg_webrtc_VideoCapturer_Lorg_webrtc_MediaConstraints_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateVideoSource_Lorg_webrtc_VideoCapturer_Lorg_webrtc_MediaConstraints_);
			return cb_createVideoSource_Lorg_webrtc_VideoCapturer_Lorg_webrtc_MediaConstraints_;
		}

		static IntPtr n_CreateVideoSource_Lorg_webrtc_VideoCapturer_Lorg_webrtc_MediaConstraints_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Webrtc.PeerConnectionFactory __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnectionFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.VideoCapturer p0 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoCapturer> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.MediaConstraints p1 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaConstraints> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateVideoSource (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_createVideoSource_Lorg_webrtc_VideoCapturer_Lorg_webrtc_MediaConstraints_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnectionFactory']/method[@name='createVideoSource' and count(parameter)=2 and parameter[1][@type='org.webrtc.VideoCapturer'] and parameter[2][@type='org.webrtc.MediaConstraints']]"
		[Register ("createVideoSource", "(Lorg/webrtc/VideoCapturer;Lorg/webrtc/MediaConstraints;)Lorg/webrtc/VideoSource;", "GetCreateVideoSource_Lorg_webrtc_VideoCapturer_Lorg_webrtc_MediaConstraints_Handler")]
		public virtual unsafe global::Org.Webrtc.VideoSource CreateVideoSource (global::Org.Webrtc.VideoCapturer p0, global::Org.Webrtc.MediaConstraints p1)
		{
			if (id_createVideoSource_Lorg_webrtc_VideoCapturer_Lorg_webrtc_MediaConstraints_ == IntPtr.Zero)
				id_createVideoSource_Lorg_webrtc_VideoCapturer_Lorg_webrtc_MediaConstraints_ = JNIEnv.GetMethodID (class_ref, "createVideoSource", "(Lorg/webrtc/VideoCapturer;Lorg/webrtc/MediaConstraints;)Lorg/webrtc/VideoSource;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Org.Webrtc.VideoSource __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoSource> (JNIEnv.CallObjectMethod  (Handle, id_createVideoSource_Lorg_webrtc_VideoCapturer_Lorg_webrtc_MediaConstraints_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoSource> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createVideoSource", "(Lorg/webrtc/VideoCapturer;Lorg/webrtc/MediaConstraints;)Lorg/webrtc/VideoSource;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_createVideoTrack_Ljava_lang_String_Lorg_webrtc_VideoSource_;
#pragma warning disable 0169
		static Delegate GetCreateVideoTrack_Ljava_lang_String_Lorg_webrtc_VideoSource_Handler ()
		{
			if (cb_createVideoTrack_Ljava_lang_String_Lorg_webrtc_VideoSource_ == null)
				cb_createVideoTrack_Ljava_lang_String_Lorg_webrtc_VideoSource_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateVideoTrack_Ljava_lang_String_Lorg_webrtc_VideoSource_);
			return cb_createVideoTrack_Ljava_lang_String_Lorg_webrtc_VideoSource_;
		}

		static IntPtr n_CreateVideoTrack_Ljava_lang_String_Lorg_webrtc_VideoSource_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Webrtc.PeerConnectionFactory __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnectionFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.VideoSource p1 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoSource> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateVideoTrack (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_createVideoTrack_Ljava_lang_String_Lorg_webrtc_VideoSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnectionFactory']/method[@name='createVideoTrack' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.webrtc.VideoSource']]"
		[Register ("createVideoTrack", "(Ljava/lang/String;Lorg/webrtc/VideoSource;)Lorg/webrtc/VideoTrack;", "GetCreateVideoTrack_Ljava_lang_String_Lorg_webrtc_VideoSource_Handler")]
		public virtual unsafe global::Org.Webrtc.VideoTrack CreateVideoTrack (string p0, global::Org.Webrtc.VideoSource p1)
		{
			if (id_createVideoTrack_Ljava_lang_String_Lorg_webrtc_VideoSource_ == IntPtr.Zero)
				id_createVideoTrack_Ljava_lang_String_Lorg_webrtc_VideoSource_ = JNIEnv.GetMethodID (class_ref, "createVideoTrack", "(Ljava/lang/String;Lorg/webrtc/VideoSource;)Lorg/webrtc/VideoTrack;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				global::Org.Webrtc.VideoTrack __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoTrack> (JNIEnv.CallObjectMethod  (Handle, id_createVideoTrack_Ljava_lang_String_Lorg_webrtc_VideoSource_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoTrack> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createVideoTrack", "(Ljava/lang/String;Lorg/webrtc/VideoSource;)Lorg/webrtc/VideoTrack;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_dispose;
#pragma warning disable 0169
		static Delegate GetDisposeHandler ()
		{
			if (cb_dispose == null)
				cb_dispose = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Dispose);
			return cb_dispose;
		}

		static void n_Dispose (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.PeerConnectionFactory __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnectionFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dispose ();
		}
#pragma warning restore 0169

		static IntPtr id_dispose;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnectionFactory']/method[@name='dispose' and count(parameter)=0]"
		[Register ("dispose", "()V", "GetDisposeHandler")]
		public virtual unsafe void Dispose ()
		{
			if (id_dispose == IntPtr.Zero)
				id_dispose = JNIEnv.GetMethodID (class_ref, "dispose", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_dispose);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dispose", "()V"));
			} finally {
			}
		}

		static IntPtr id_initializeAndroidGlobals_Ljava_lang_Object_ZZZLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnectionFactory']/method[@name='initializeAndroidGlobals' and count(parameter)=5 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean'] and parameter[4][@type='boolean'] and parameter[5][@type='java.lang.Object']]"
		[Register ("initializeAndroidGlobals", "(Ljava/lang/Object;ZZZLjava/lang/Object;)Z", "")]
		public static unsafe bool InitializeAndroidGlobals (global::Java.Lang.Object p0, bool p1, bool p2, bool p3, global::Java.Lang.Object p4)
		{
			if (id_initializeAndroidGlobals_Ljava_lang_Object_ZZZLjava_lang_Object_ == IntPtr.Zero)
				id_initializeAndroidGlobals_Ljava_lang_Object_ZZZLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "initializeAndroidGlobals", "(Ljava/lang/Object;ZZZLjava/lang/Object;)Z");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_initializeAndroidGlobals_Ljava_lang_Object_ZZZLjava_lang_Object_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_initializeFieldTrials_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnectionFactory']/method[@name='initializeFieldTrials' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("initializeFieldTrials", "(Ljava/lang/String;)V", "")]
		public static unsafe void InitializeFieldTrials (string p0)
		{
			if (id_initializeFieldTrials_Ljava_lang_String_ == IntPtr.Zero)
				id_initializeFieldTrials_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "initializeFieldTrials", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_initializeFieldTrials_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_nativeSetOptions_JLorg_webrtc_PeerConnectionFactory_Options_;
#pragma warning disable 0169
		static Delegate GetNativeSetOptions_JLorg_webrtc_PeerConnectionFactory_Options_Handler ()
		{
			if (cb_nativeSetOptions_JLorg_webrtc_PeerConnectionFactory_Options_ == null)
				cb_nativeSetOptions_JLorg_webrtc_PeerConnectionFactory_Options_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, IntPtr>) n_NativeSetOptions_JLorg_webrtc_PeerConnectionFactory_Options_);
			return cb_nativeSetOptions_JLorg_webrtc_PeerConnectionFactory_Options_;
		}

		static void n_NativeSetOptions_JLorg_webrtc_PeerConnectionFactory_Options_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			global::Org.Webrtc.PeerConnectionFactory __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnectionFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.PeerConnectionFactory.Options p1 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnectionFactory.Options> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.NativeSetOptions (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_nativeSetOptions_JLorg_webrtc_PeerConnectionFactory_Options_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnectionFactory']/method[@name='nativeSetOptions' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='org.webrtc.PeerConnectionFactory.Options']]"
		[Register ("nativeSetOptions", "(JLorg/webrtc/PeerConnectionFactory$Options;)V", "GetNativeSetOptions_JLorg_webrtc_PeerConnectionFactory_Options_Handler")]
		public virtual unsafe void NativeSetOptions (long p0, global::Org.Webrtc.PeerConnectionFactory.Options p1)
		{
			if (id_nativeSetOptions_JLorg_webrtc_PeerConnectionFactory_Options_ == IntPtr.Zero)
				id_nativeSetOptions_JLorg_webrtc_PeerConnectionFactory_Options_ = JNIEnv.GetMethodID (class_ref, "nativeSetOptions", "(JLorg/webrtc/PeerConnectionFactory$Options;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_nativeSetOptions_JLorg_webrtc_PeerConnectionFactory_Options_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "nativeSetOptions", "(JLorg/webrtc/PeerConnectionFactory$Options;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setOptions_Lorg_webrtc_PeerConnectionFactory_Options_;
#pragma warning disable 0169
		static Delegate GetSetOptions_Lorg_webrtc_PeerConnectionFactory_Options_Handler ()
		{
			if (cb_setOptions_Lorg_webrtc_PeerConnectionFactory_Options_ == null)
				cb_setOptions_Lorg_webrtc_PeerConnectionFactory_Options_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOptions_Lorg_webrtc_PeerConnectionFactory_Options_);
			return cb_setOptions_Lorg_webrtc_PeerConnectionFactory_Options_;
		}

		static void n_SetOptions_Lorg_webrtc_PeerConnectionFactory_Options_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Webrtc.PeerConnectionFactory __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnectionFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.PeerConnectionFactory.Options p0 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnectionFactory.Options> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOptions (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOptions_Lorg_webrtc_PeerConnectionFactory_Options_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnectionFactory']/method[@name='setOptions' and count(parameter)=1 and parameter[1][@type='org.webrtc.PeerConnectionFactory.Options']]"
		[Register ("setOptions", "(Lorg/webrtc/PeerConnectionFactory$Options;)V", "GetSetOptions_Lorg_webrtc_PeerConnectionFactory_Options_Handler")]
		public virtual unsafe void SetOptions (global::Org.Webrtc.PeerConnectionFactory.Options p0)
		{
			if (id_setOptions_Lorg_webrtc_PeerConnectionFactory_Options_ == IntPtr.Zero)
				id_setOptions_Lorg_webrtc_PeerConnectionFactory_Options_ = JNIEnv.GetMethodID (class_ref, "setOptions", "(Lorg/webrtc/PeerConnectionFactory$Options;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setOptions_Lorg_webrtc_PeerConnectionFactory_Options_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOptions", "(Lorg/webrtc/PeerConnectionFactory$Options;)V"), __args);
			} finally {
			}
		}

	}
}
