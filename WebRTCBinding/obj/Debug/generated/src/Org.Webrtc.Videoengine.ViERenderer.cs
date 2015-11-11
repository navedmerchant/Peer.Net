using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Webrtc.Videoengine {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc.videoengine']/class[@name='ViERenderer']"
	[global::Android.Runtime.Register ("org/webrtc/videoengine/ViERenderer", DoNotGenerateAcw=true)]
	public partial class ViERenderer : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/webrtc/videoengine/ViERenderer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ViERenderer); }
		}

		protected ViERenderer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc.videoengine']/class[@name='ViERenderer']/constructor[@name='ViERenderer' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ViERenderer ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ViERenderer)) {
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

		static IntPtr id_CreateRenderer_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.videoengine']/class[@name='ViERenderer']/method[@name='CreateRenderer' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("CreateRenderer", "(Landroid/content/Context;)Landroid/view/SurfaceView;", "")]
		public static unsafe global::Android.Views.SurfaceView CreateRenderer (global::Android.Content.Context p0)
		{
			if (id_CreateRenderer_Landroid_content_Context_ == IntPtr.Zero)
				id_CreateRenderer_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "CreateRenderer", "(Landroid/content/Context;)Landroid/view/SurfaceView;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Android.Views.SurfaceView __ret = global::Java.Lang.Object.GetObject<global::Android.Views.SurfaceView> (JNIEnv.CallStaticObjectMethod  (class_ref, id_CreateRenderer_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_CreateRenderer_Landroid_content_Context_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.videoengine']/class[@name='ViERenderer']/method[@name='CreateRenderer' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='boolean']]"
		[Register ("CreateRenderer", "(Landroid/content/Context;Z)Landroid/view/SurfaceView;", "")]
		public static unsafe global::Android.Views.SurfaceView CreateRenderer (global::Android.Content.Context p0, bool p1)
		{
			if (id_CreateRenderer_Landroid_content_Context_Z == IntPtr.Zero)
				id_CreateRenderer_Landroid_content_Context_Z = JNIEnv.GetStaticMethodID (class_ref, "CreateRenderer", "(Landroid/content/Context;Z)Landroid/view/SurfaceView;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Android.Views.SurfaceView __ret = global::Java.Lang.Object.GetObject<global::Android.Views.SurfaceView> (JNIEnv.CallStaticObjectMethod  (class_ref, id_CreateRenderer_Landroid_content_Context_Z, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
