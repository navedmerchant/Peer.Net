using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Webrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='VideoCapturer']"
	[global::Android.Runtime.Register ("org/webrtc/VideoCapturer", DoNotGenerateAcw=true)]
	public partial class VideoCapturer : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/webrtc/VideoCapturer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VideoCapturer); }
		}

		protected VideoCapturer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='VideoCapturer']/constructor[@name='VideoCapturer' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		protected unsafe VideoCapturer ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (VideoCapturer)) {
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

		static IntPtr id_create_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='VideoCapturer']/method[@name='create' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("create", "(Ljava/lang/String;)Lorg/webrtc/VideoCapturer;", "")]
		public static unsafe global::Org.Webrtc.VideoCapturer Create (string p0)
		{
			if (id_create_Ljava_lang_String_ == IntPtr.Zero)
				id_create_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "create", "(Ljava/lang/String;)Lorg/webrtc/VideoCapturer;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Org.Webrtc.VideoCapturer __ret = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoCapturer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
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
			global::Org.Webrtc.VideoCapturer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoCapturer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dispose ();
		}
#pragma warning restore 0169

		static IntPtr id_dispose;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='VideoCapturer']/method[@name='dispose' and count(parameter)=0]"
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

		static Delegate cb_setNativeCapturer_J;
#pragma warning disable 0169
		static Delegate GetSetNativeCapturer_JHandler ()
		{
			if (cb_setNativeCapturer_J == null)
				cb_setNativeCapturer_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetNativeCapturer_J);
			return cb_setNativeCapturer_J;
		}

		static void n_SetNativeCapturer_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Org.Webrtc.VideoCapturer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoCapturer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetNativeCapturer (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setNativeCapturer_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='VideoCapturer']/method[@name='setNativeCapturer' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setNativeCapturer", "(J)V", "GetSetNativeCapturer_JHandler")]
		protected virtual unsafe void SetNativeCapturer (long p0)
		{
			if (id_setNativeCapturer_J == IntPtr.Zero)
				id_setNativeCapturer_J = JNIEnv.GetMethodID (class_ref, "setNativeCapturer", "(J)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setNativeCapturer_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNativeCapturer", "(J)V"), __args);
			} finally {
			}
		}

	}
}
