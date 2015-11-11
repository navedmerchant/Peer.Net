using System;
using System.Collections.Generic;
using Android.Runtime;

namespace ME.Kevingleason.Pnwebrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='me.kevingleason.pnwebrtc']/class[@name='PnSignalingParams']"
	[global::Android.Runtime.Register ("me/kevingleason/pnwebrtc/PnSignalingParams", DoNotGenerateAcw=true)]
	public partial class PnSignalingParams : global::Java.Lang.Object {


		static IntPtr audioConstraints_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='me.kevingleason.pnwebrtc']/class[@name='PnSignalingParams']/field[@name='audioConstraints']"
		[Register ("audioConstraints")]
		public global::Org.Webrtc.MediaConstraints AudioConstraints {
			get {
				if (audioConstraints_jfieldId == IntPtr.Zero)
					audioConstraints_jfieldId = JNIEnv.GetFieldID (class_ref, "audioConstraints", "Lorg/webrtc/MediaConstraints;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, audioConstraints_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaConstraints> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (audioConstraints_jfieldId == IntPtr.Zero)
					audioConstraints_jfieldId = JNIEnv.GetFieldID (class_ref, "audioConstraints", "Lorg/webrtc/MediaConstraints;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, audioConstraints_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr iceServers_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='me.kevingleason.pnwebrtc']/class[@name='PnSignalingParams']/field[@name='iceServers']"
		[Register ("iceServers")]
		public global::System.Collections.IList IceServers {
			get {
				if (iceServers_jfieldId == IntPtr.Zero)
					iceServers_jfieldId = JNIEnv.GetFieldID (class_ref, "iceServers", "Ljava/util/List;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, iceServers_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (iceServers_jfieldId == IntPtr.Zero)
					iceServers_jfieldId = JNIEnv.GetFieldID (class_ref, "iceServers", "Ljava/util/List;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, iceServers_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr pcConstraints_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='me.kevingleason.pnwebrtc']/class[@name='PnSignalingParams']/field[@name='pcConstraints']"
		[Register ("pcConstraints")]
		public global::Org.Webrtc.MediaConstraints PcConstraints {
			get {
				if (pcConstraints_jfieldId == IntPtr.Zero)
					pcConstraints_jfieldId = JNIEnv.GetFieldID (class_ref, "pcConstraints", "Lorg/webrtc/MediaConstraints;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, pcConstraints_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaConstraints> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (pcConstraints_jfieldId == IntPtr.Zero)
					pcConstraints_jfieldId = JNIEnv.GetFieldID (class_ref, "pcConstraints", "Lorg/webrtc/MediaConstraints;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, pcConstraints_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr videoConstraints_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='me.kevingleason.pnwebrtc']/class[@name='PnSignalingParams']/field[@name='videoConstraints']"
		[Register ("videoConstraints")]
		public global::Org.Webrtc.MediaConstraints VideoConstraints {
			get {
				if (videoConstraints_jfieldId == IntPtr.Zero)
					videoConstraints_jfieldId = JNIEnv.GetFieldID (class_ref, "videoConstraints", "Lorg/webrtc/MediaConstraints;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, videoConstraints_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaConstraints> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (videoConstraints_jfieldId == IntPtr.Zero)
					videoConstraints_jfieldId = JNIEnv.GetFieldID (class_ref, "videoConstraints", "Lorg/webrtc/MediaConstraints;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, videoConstraints_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("me/kevingleason/pnwebrtc/PnSignalingParams", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PnSignalingParams); }
		}

		protected PnSignalingParams (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_webrtc_MediaConstraints_Lorg_webrtc_MediaConstraints_Lorg_webrtc_MediaConstraints_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='me.kevingleason.pnwebrtc']/class[@name='PnSignalingParams']/constructor[@name='PnSignalingParams' and count(parameter)=3 and parameter[1][@type='org.webrtc.MediaConstraints'] and parameter[2][@type='org.webrtc.MediaConstraints'] and parameter[3][@type='org.webrtc.MediaConstraints']]"
		[Register (".ctor", "(Lorg/webrtc/MediaConstraints;Lorg/webrtc/MediaConstraints;Lorg/webrtc/MediaConstraints;)V", "")]
		public unsafe PnSignalingParams (global::Org.Webrtc.MediaConstraints p0, global::Org.Webrtc.MediaConstraints p1, global::Org.Webrtc.MediaConstraints p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (PnSignalingParams)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/webrtc/MediaConstraints;Lorg/webrtc/MediaConstraints;Lorg/webrtc/MediaConstraints;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/webrtc/MediaConstraints;Lorg/webrtc/MediaConstraints;Lorg/webrtc/MediaConstraints;)V", __args);
					return;
				}

				if (id_ctor_Lorg_webrtc_MediaConstraints_Lorg_webrtc_MediaConstraints_Lorg_webrtc_MediaConstraints_ == IntPtr.Zero)
					id_ctor_Lorg_webrtc_MediaConstraints_Lorg_webrtc_MediaConstraints_Lorg_webrtc_MediaConstraints_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/webrtc/MediaConstraints;Lorg/webrtc/MediaConstraints;Lorg/webrtc/MediaConstraints;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_webrtc_MediaConstraints_Lorg_webrtc_MediaConstraints_Lorg_webrtc_MediaConstraints_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_webrtc_MediaConstraints_Lorg_webrtc_MediaConstraints_Lorg_webrtc_MediaConstraints_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Ljava_util_List_Lorg_webrtc_MediaConstraints_Lorg_webrtc_MediaConstraints_Lorg_webrtc_MediaConstraints_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='me.kevingleason.pnwebrtc']/class[@name='PnSignalingParams']/constructor[@name='PnSignalingParams' and count(parameter)=4 and parameter[1][@type='java.util.List&lt;org.webrtc.PeerConnection.IceServer&gt;'] and parameter[2][@type='org.webrtc.MediaConstraints'] and parameter[3][@type='org.webrtc.MediaConstraints'] and parameter[4][@type='org.webrtc.MediaConstraints']]"
		[Register (".ctor", "(Ljava/util/List;Lorg/webrtc/MediaConstraints;Lorg/webrtc/MediaConstraints;Lorg/webrtc/MediaConstraints;)V", "")]
		public unsafe PnSignalingParams (global::System.Collections.Generic.IList<global::Org.Webrtc.PeerConnection.IceServer> p0, global::Org.Webrtc.MediaConstraints p1, global::Org.Webrtc.MediaConstraints p2, global::Org.Webrtc.MediaConstraints p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Org.Webrtc.PeerConnection.IceServer>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				if (GetType () != typeof (PnSignalingParams)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/util/List;Lorg/webrtc/MediaConstraints;Lorg/webrtc/MediaConstraints;Lorg/webrtc/MediaConstraints;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/util/List;Lorg/webrtc/MediaConstraints;Lorg/webrtc/MediaConstraints;Lorg/webrtc/MediaConstraints;)V", __args);
					return;
				}

				if (id_ctor_Ljava_util_List_Lorg_webrtc_MediaConstraints_Lorg_webrtc_MediaConstraints_Lorg_webrtc_MediaConstraints_ == IntPtr.Zero)
					id_ctor_Ljava_util_List_Lorg_webrtc_MediaConstraints_Lorg_webrtc_MediaConstraints_Lorg_webrtc_MediaConstraints_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/List;Lorg/webrtc/MediaConstraints;Lorg/webrtc/MediaConstraints;Lorg/webrtc/MediaConstraints;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_List_Lorg_webrtc_MediaConstraints_Lorg_webrtc_MediaConstraints_Lorg_webrtc_MediaConstraints_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_util_List_Lorg_webrtc_MediaConstraints_Lorg_webrtc_MediaConstraints_Lorg_webrtc_MediaConstraints_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='me.kevingleason.pnwebrtc']/class[@name='PnSignalingParams']/constructor[@name='PnSignalingParams' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PnSignalingParams ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (PnSignalingParams)) {
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

		static IntPtr id_ctor_Ljava_util_List_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='me.kevingleason.pnwebrtc']/class[@name='PnSignalingParams']/constructor[@name='PnSignalingParams' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;org.webrtc.PeerConnection.IceServer&gt;']]"
		[Register (".ctor", "(Ljava/util/List;)V", "")]
		public unsafe PnSignalingParams (global::System.Collections.Generic.IList<global::Org.Webrtc.PeerConnection.IceServer> p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Org.Webrtc.PeerConnection.IceServer>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (PnSignalingParams)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/util/List;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/util/List;)V", __args);
					return;
				}

				if (id_ctor_Ljava_util_List_ == IntPtr.Zero)
					id_ctor_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/List;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_List_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_util_List_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_addIceServers_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetAddIceServers_Ljava_util_List_Handler ()
		{
			if (cb_addIceServers_Ljava_util_List_ == null)
				cb_addIceServers_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddIceServers_Ljava_util_List_);
			return cb_addIceServers_Ljava_util_List_;
		}

		static void n_AddIceServers_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::ME.Kevingleason.Pnwebrtc.PnSignalingParams __this = global::Java.Lang.Object.GetObject<global::ME.Kevingleason.Pnwebrtc.PnSignalingParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Org.Webrtc.PeerConnection.IceServer>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddIceServers (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addIceServers_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='me.kevingleason.pnwebrtc']/class[@name='PnSignalingParams']/method[@name='addIceServers' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;org.webrtc.PeerConnection.IceServer&gt;']]"
		[Register ("addIceServers", "(Ljava/util/List;)V", "GetAddIceServers_Ljava_util_List_Handler")]
		public virtual unsafe void AddIceServers (global::System.Collections.Generic.IList<global::Org.Webrtc.PeerConnection.IceServer> p0)
		{
			if (id_addIceServers_Ljava_util_List_ == IntPtr.Zero)
				id_addIceServers_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "addIceServers", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Org.Webrtc.PeerConnection.IceServer>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_addIceServers_Ljava_util_List_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addIceServers", "(Ljava/util/List;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_addIceServers_Lorg_webrtc_PeerConnection_IceServer_;
#pragma warning disable 0169
		static Delegate GetAddIceServers_Lorg_webrtc_PeerConnection_IceServer_Handler ()
		{
			if (cb_addIceServers_Lorg_webrtc_PeerConnection_IceServer_ == null)
				cb_addIceServers_Lorg_webrtc_PeerConnection_IceServer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddIceServers_Lorg_webrtc_PeerConnection_IceServer_);
			return cb_addIceServers_Lorg_webrtc_PeerConnection_IceServer_;
		}

		static void n_AddIceServers_Lorg_webrtc_PeerConnection_IceServer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::ME.Kevingleason.Pnwebrtc.PnSignalingParams __this = global::Java.Lang.Object.GetObject<global::ME.Kevingleason.Pnwebrtc.PnSignalingParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.PeerConnection.IceServer p0 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.IceServer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddIceServers (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addIceServers_Lorg_webrtc_PeerConnection_IceServer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='me.kevingleason.pnwebrtc']/class[@name='PnSignalingParams']/method[@name='addIceServers' and count(parameter)=1 and parameter[1][@type='org.webrtc.PeerConnection.IceServer']]"
		[Register ("addIceServers", "(Lorg/webrtc/PeerConnection$IceServer;)V", "GetAddIceServers_Lorg_webrtc_PeerConnection_IceServer_Handler")]
		public virtual unsafe void AddIceServers (global::Org.Webrtc.PeerConnection.IceServer p0)
		{
			if (id_addIceServers_Lorg_webrtc_PeerConnection_IceServer_ == IntPtr.Zero)
				id_addIceServers_Lorg_webrtc_PeerConnection_IceServer_ = JNIEnv.GetMethodID (class_ref, "addIceServers", "(Lorg/webrtc/PeerConnection$IceServer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_addIceServers_Lorg_webrtc_PeerConnection_IceServer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addIceServers", "(Lorg/webrtc/PeerConnection$IceServer;)V"), __args);
			} finally {
			}
		}

		static IntPtr id_defaultIceServers;
		// Metadata.xml XPath method reference: path="/api/package[@name='me.kevingleason.pnwebrtc']/class[@name='PnSignalingParams']/method[@name='defaultIceServers' and count(parameter)=0]"
		[Register ("defaultIceServers", "()Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Org.Webrtc.PeerConnection.IceServer> DefaultIceServers ()
		{
			if (id_defaultIceServers == IntPtr.Zero)
				id_defaultIceServers = JNIEnv.GetStaticMethodID (class_ref, "defaultIceServers", "()Ljava/util/List;");
			try {
				return global::Android.Runtime.JavaList<global::Org.Webrtc.PeerConnection.IceServer>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_defaultIceServers), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_defaultInstance;
		// Metadata.xml XPath method reference: path="/api/package[@name='me.kevingleason.pnwebrtc']/class[@name='PnSignalingParams']/method[@name='defaultInstance' and count(parameter)=0]"
		[Register ("defaultInstance", "()Lme/kevingleason/pnwebrtc/PnSignalingParams;", "")]
		public static unsafe global::ME.Kevingleason.Pnwebrtc.PnSignalingParams DefaultInstance ()
		{
			if (id_defaultInstance == IntPtr.Zero)
				id_defaultInstance = JNIEnv.GetStaticMethodID (class_ref, "defaultInstance", "()Lme/kevingleason/pnwebrtc/PnSignalingParams;");
			try {
				return global::Java.Lang.Object.GetObject<global::ME.Kevingleason.Pnwebrtc.PnSignalingParams> (JNIEnv.CallStaticObjectMethod  (class_ref, id_defaultInstance), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
