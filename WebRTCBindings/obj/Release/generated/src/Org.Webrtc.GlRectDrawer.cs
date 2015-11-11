using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Webrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='GlRectDrawer']"
	[global::Android.Runtime.Register ("org/webrtc/GlRectDrawer", DoNotGenerateAcw=true)]
	public partial class GlRectDrawer : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/webrtc/GlRectDrawer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GlRectDrawer); }
		}

		protected GlRectDrawer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='GlRectDrawer']/constructor[@name='GlRectDrawer' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GlRectDrawer ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (GlRectDrawer)) {
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

		static Delegate cb_drawOes_IarrayF;
#pragma warning disable 0169
		static Delegate GetDrawOes_IarrayFHandler ()
		{
			if (cb_drawOes_IarrayF == null)
				cb_drawOes_IarrayF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_DrawOes_IarrayF);
			return cb_drawOes_IarrayF;
		}

		static void n_DrawOes_IarrayF (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Org.Webrtc.GlRectDrawer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.GlRectDrawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			float[] p1 = (float[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (float));
			__this.DrawOes (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		static IntPtr id_drawOes_IarrayF;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='GlRectDrawer']/method[@name='drawOes' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='float[]']]"
		[Register ("drawOes", "(I[F)V", "GetDrawOes_IarrayFHandler")]
		public virtual unsafe void DrawOes (int p0, float[] p1)
		{
			if (id_drawOes_IarrayF == IntPtr.Zero)
				id_drawOes_IarrayF = JNIEnv.GetMethodID (class_ref, "drawOes", "(I[F)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_drawOes_IarrayF, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "drawOes", "(I[F)V"), __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static Delegate cb_drawYuv_IIarrayIarrayF;
#pragma warning disable 0169
		static Delegate GetDrawYuv_IIarrayIarrayFHandler ()
		{
			if (cb_drawYuv_IIarrayIarrayF == null)
				cb_drawYuv_IIarrayIarrayF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, IntPtr, IntPtr>) n_DrawYuv_IIarrayIarrayF);
			return cb_drawYuv_IIarrayIarrayF;
		}

		static void n_DrawYuv_IIarrayIarrayF (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Org.Webrtc.GlRectDrawer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.GlRectDrawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] p2 = (int[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (int));
			float[] p3 = (float[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (float));
			__this.DrawYuv (p0, p1, p2, p3);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
		}
#pragma warning restore 0169

		static IntPtr id_drawYuv_IIarrayIarrayF;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='GlRectDrawer']/method[@name='drawYuv' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int[]'] and parameter[4][@type='float[]']]"
		[Register ("drawYuv", "(II[I[F)V", "GetDrawYuv_IIarrayIarrayFHandler")]
		public virtual unsafe void DrawYuv (int p0, int p1, int[] p2, float[] p3)
		{
			if (id_drawYuv_IIarrayIarrayF == IntPtr.Zero)
				id_drawYuv_IIarrayIarrayF = JNIEnv.GetMethodID (class_ref, "drawYuv", "(II[I[F)V");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_drawYuv_IIarrayIarrayF, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "drawYuv", "(II[I[F)V"), __args);
			} finally {
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
			}
		}

		static Delegate cb_release;
#pragma warning disable 0169
		static Delegate GetReleaseHandler ()
		{
			if (cb_release == null)
				cb_release = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Release);
			return cb_release;
		}

		static void n_Release (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.GlRectDrawer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.GlRectDrawer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Release ();
		}
#pragma warning restore 0169

		static IntPtr id_release;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='GlRectDrawer']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "GetReleaseHandler")]
		public virtual unsafe void Release ()
		{
			if (id_release == IntPtr.Zero)
				id_release = JNIEnv.GetMethodID (class_ref, "release", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_release);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "release", "()V"));
			} finally {
			}
		}

	}
}
