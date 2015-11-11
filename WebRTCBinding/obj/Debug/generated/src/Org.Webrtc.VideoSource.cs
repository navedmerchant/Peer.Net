using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Webrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='VideoSource']"
	[global::Android.Runtime.Register ("org/webrtc/VideoSource", DoNotGenerateAcw=true)]
	public partial class VideoSource : global::Org.Webrtc.MediaSource {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/webrtc/VideoSource", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VideoSource); }
		}

		protected VideoSource (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='VideoSource']/constructor[@name='VideoSource' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		public unsafe VideoSource (long p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (VideoSource)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(J)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(J)V", __args);
					return;
				}

				if (id_ctor_J == IntPtr.Zero)
					id_ctor_J = JNIEnv.GetMethodID (class_ref, "<init>", "(J)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_J, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_J, __args);
			} finally {
			}
		}

		static Delegate cb_restart;
#pragma warning disable 0169
		static Delegate GetRestartHandler ()
		{
			if (cb_restart == null)
				cb_restart = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Restart);
			return cb_restart;
		}

		static void n_Restart (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.VideoSource __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Restart ();
		}
#pragma warning restore 0169

		static IntPtr id_restart;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='VideoSource']/method[@name='restart' and count(parameter)=0]"
		[Register ("restart", "()V", "GetRestartHandler")]
		public virtual unsafe void Restart ()
		{
			if (id_restart == IntPtr.Zero)
				id_restart = JNIEnv.GetMethodID (class_ref, "restart", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_restart);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "restart", "()V"));
			} finally {
			}
		}

		static Delegate cb_stop;
#pragma warning disable 0169
		static Delegate GetStopHandler ()
		{
			if (cb_stop == null)
				cb_stop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Stop);
			return cb_stop;
		}

		static void n_Stop (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.VideoSource __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		static IntPtr id_stop;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='VideoSource']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler")]
		public virtual unsafe void Stop ()
		{
			if (id_stop == IntPtr.Zero)
				id_stop = JNIEnv.GetMethodID (class_ref, "stop", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_stop);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stop", "()V"));
			} finally {
			}
		}

	}
}
