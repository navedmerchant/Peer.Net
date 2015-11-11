using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Webrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='VideoTrack']"
	[global::Android.Runtime.Register ("org/webrtc/VideoTrack", DoNotGenerateAcw=true)]
	public partial class VideoTrack : global::Org.Webrtc.MediaStreamTrack {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/webrtc/VideoTrack", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VideoTrack); }
		}

		protected VideoTrack (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='VideoTrack']/constructor[@name='VideoTrack' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		public unsafe VideoTrack (long p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (VideoTrack)) {
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

		static Delegate cb_addRenderer_Lorg_webrtc_VideoRenderer_;
#pragma warning disable 0169
		static Delegate GetAddRenderer_Lorg_webrtc_VideoRenderer_Handler ()
		{
			if (cb_addRenderer_Lorg_webrtc_VideoRenderer_ == null)
				cb_addRenderer_Lorg_webrtc_VideoRenderer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddRenderer_Lorg_webrtc_VideoRenderer_);
			return cb_addRenderer_Lorg_webrtc_VideoRenderer_;
		}

		static void n_AddRenderer_Lorg_webrtc_VideoRenderer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Webrtc.VideoTrack __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.VideoRenderer p0 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoRenderer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddRenderer (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addRenderer_Lorg_webrtc_VideoRenderer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='VideoTrack']/method[@name='addRenderer' and count(parameter)=1 and parameter[1][@type='org.webrtc.VideoRenderer']]"
		[Register ("addRenderer", "(Lorg/webrtc/VideoRenderer;)V", "GetAddRenderer_Lorg_webrtc_VideoRenderer_Handler")]
		public virtual unsafe void AddRenderer (global::Org.Webrtc.VideoRenderer p0)
		{
			if (id_addRenderer_Lorg_webrtc_VideoRenderer_ == IntPtr.Zero)
				id_addRenderer_Lorg_webrtc_VideoRenderer_ = JNIEnv.GetMethodID (class_ref, "addRenderer", "(Lorg/webrtc/VideoRenderer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_addRenderer_Lorg_webrtc_VideoRenderer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addRenderer", "(Lorg/webrtc/VideoRenderer;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_removeRenderer_Lorg_webrtc_VideoRenderer_;
#pragma warning disable 0169
		static Delegate GetRemoveRenderer_Lorg_webrtc_VideoRenderer_Handler ()
		{
			if (cb_removeRenderer_Lorg_webrtc_VideoRenderer_ == null)
				cb_removeRenderer_Lorg_webrtc_VideoRenderer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveRenderer_Lorg_webrtc_VideoRenderer_);
			return cb_removeRenderer_Lorg_webrtc_VideoRenderer_;
		}

		static void n_RemoveRenderer_Lorg_webrtc_VideoRenderer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Webrtc.VideoTrack __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.VideoRenderer p0 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoRenderer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveRenderer (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeRenderer_Lorg_webrtc_VideoRenderer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='VideoTrack']/method[@name='removeRenderer' and count(parameter)=1 and parameter[1][@type='org.webrtc.VideoRenderer']]"
		[Register ("removeRenderer", "(Lorg/webrtc/VideoRenderer;)V", "GetRemoveRenderer_Lorg_webrtc_VideoRenderer_Handler")]
		public virtual unsafe void RemoveRenderer (global::Org.Webrtc.VideoRenderer p0)
		{
			if (id_removeRenderer_Lorg_webrtc_VideoRenderer_ == IntPtr.Zero)
				id_removeRenderer_Lorg_webrtc_VideoRenderer_ = JNIEnv.GetMethodID (class_ref, "removeRenderer", "(Lorg/webrtc/VideoRenderer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_removeRenderer_Lorg_webrtc_VideoRenderer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeRenderer", "(Lorg/webrtc/VideoRenderer;)V"), __args);
			} finally {
			}
		}

	}
}
