using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Webrtc.Videoengine {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc.videoengine']/class[@name='VideoCaptureAndroid']"
	[global::Android.Runtime.Register ("org/webrtc/videoengine/VideoCaptureAndroid", DoNotGenerateAcw=true)]
	public partial class VideoCaptureAndroid : global::Java.Lang.Object, global::Android.Hardware.Camera.IPreviewCallback, global::Android.Views.ISurfaceHolderCallback {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc.videoengine']/class[@name='VideoCaptureAndroid.CameraThread']"
		[global::Android.Runtime.Register ("org/webrtc/videoengine/VideoCaptureAndroid$CameraThread", DoNotGenerateAcw=true)]
		public partial class CameraThread : global::Java.Lang.Thread {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/webrtc/videoengine/VideoCaptureAndroid$CameraThread", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (CameraThread); }
			}

			protected CameraThread (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lorg_webrtc_videoengine_VideoCaptureAndroid_Ljava_util_concurrent_Exchanger_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc.videoengine']/class[@name='VideoCaptureAndroid.CameraThread']/constructor[@name='VideoCaptureAndroid.CameraThread' and count(parameter)=2 and parameter[1][@type='org.webrtc.videoengine.VideoCaptureAndroid'] and parameter[2][@type='java.util.concurrent.Exchanger&lt;android.os.Handler&gt;']]"
			[Register (".ctor", "(Lorg/webrtc/videoengine/VideoCaptureAndroid;Ljava/util/concurrent/Exchanger;)V", "")]
			public unsafe CameraThread (global::Org.Webrtc.Videoengine.VideoCaptureAndroid __self, global::Java.Util.Concurrent.Exchanger p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (p0);
					if (GetType () != typeof (CameraThread)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Ljava/util/concurrent/Exchanger;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Ljava/util/concurrent/Exchanger;)V", __args);
						return;
					}

					if (id_ctor_Lorg_webrtc_videoengine_VideoCaptureAndroid_Ljava_util_concurrent_Exchanger_ == IntPtr.Zero)
						id_ctor_Lorg_webrtc_videoengine_VideoCaptureAndroid_Ljava_util_concurrent_Exchanger_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/webrtc/videoengine/VideoCaptureAndroid;Ljava/util/concurrent/Exchanger;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_webrtc_videoengine_VideoCaptureAndroid_Ljava_util_concurrent_Exchanger_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_webrtc_videoengine_VideoCaptureAndroid_Ljava_util_concurrent_Exchanger_, __args);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/webrtc/videoengine/VideoCaptureAndroid", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VideoCaptureAndroid); }
		}

		protected VideoCaptureAndroid (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_IJ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc.videoengine']/class[@name='VideoCaptureAndroid']/constructor[@name='VideoCaptureAndroid' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='long']]"
		[Register (".ctor", "(IJ)V", "")]
		public unsafe VideoCaptureAndroid (int p0, long p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (VideoCaptureAndroid)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(IJ)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(IJ)V", __args);
					return;
				}

				if (id_ctor_IJ == IntPtr.Zero)
					id_ctor_IJ = JNIEnv.GetMethodID (class_ref, "<init>", "(IJ)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IJ, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_IJ, __args);
			} finally {
			}
		}

		static Delegate cb_onPreviewFrame_arrayBLandroid_hardware_Camera_;
#pragma warning disable 0169
		static Delegate GetOnPreviewFrame_arrayBLandroid_hardware_Camera_Handler ()
		{
			if (cb_onPreviewFrame_arrayBLandroid_hardware_Camera_ == null)
				cb_onPreviewFrame_arrayBLandroid_hardware_Camera_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnPreviewFrame_arrayBLandroid_hardware_Camera_);
			return cb_onPreviewFrame_arrayBLandroid_hardware_Camera_;
		}

		static void n_OnPreviewFrame_arrayBLandroid_hardware_Camera_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Webrtc.Videoengine.VideoCaptureAndroid __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Videoengine.VideoCaptureAndroid> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			global::Android.Hardware.Camera p1 = global::Java.Lang.Object.GetObject<global::Android.Hardware.Camera> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnPreviewFrame (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_onPreviewFrame_arrayBLandroid_hardware_Camera_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.videoengine']/class[@name='VideoCaptureAndroid']/method[@name='onPreviewFrame' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='android.hardware.Camera']]"
		[Register ("onPreviewFrame", "([BLandroid/hardware/Camera;)V", "GetOnPreviewFrame_arrayBLandroid_hardware_Camera_Handler")]
		public virtual unsafe void OnPreviewFrame (byte[] p0, global::Android.Hardware.Camera p1)
		{
			if (id_onPreviewFrame_arrayBLandroid_hardware_Camera_ == IntPtr.Zero)
				id_onPreviewFrame_arrayBLandroid_hardware_Camera_ = JNIEnv.GetMethodID (class_ref, "onPreviewFrame", "([BLandroid/hardware/Camera;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onPreviewFrame_arrayBLandroid_hardware_Camera_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPreviewFrame", "([BLandroid/hardware/Camera;)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_setLocalPreview_Landroid_view_SurfaceHolder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.videoengine']/class[@name='VideoCaptureAndroid']/method[@name='setLocalPreview' and count(parameter)=1 and parameter[1][@type='android.view.SurfaceHolder']]"
		[Register ("setLocalPreview", "(Landroid/view/SurfaceHolder;)V", "")]
		public static unsafe void SetLocalPreview (global::Android.Views.ISurfaceHolder p0)
		{
			if (id_setLocalPreview_Landroid_view_SurfaceHolder_ == IntPtr.Zero)
				id_setLocalPreview_Landroid_view_SurfaceHolder_ = JNIEnv.GetStaticMethodID (class_ref, "setLocalPreview", "(Landroid/view/SurfaceHolder;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setLocalPreview_Landroid_view_SurfaceHolder_, __args);
			} finally {
			}
		}

		static Delegate cb_surfaceChanged_Landroid_view_SurfaceHolder_III;
#pragma warning disable 0169
		static Delegate GetSurfaceChanged_Landroid_view_SurfaceHolder_IIIHandler ()
		{
			if (cb_surfaceChanged_Landroid_view_SurfaceHolder_III == null)
				cb_surfaceChanged_Landroid_view_SurfaceHolder_III = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int, int>) n_SurfaceChanged_Landroid_view_SurfaceHolder_III);
			return cb_surfaceChanged_Landroid_view_SurfaceHolder_III;
		}

		static void n_SurfaceChanged_Landroid_view_SurfaceHolder_III (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int native_p1, int p2, int p3)
		{
			global::Org.Webrtc.Videoengine.VideoCaptureAndroid __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Videoengine.VideoCaptureAndroid> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ISurfaceHolder p0 = (global::Android.Views.ISurfaceHolder)global::Java.Lang.Object.GetObject<global::Android.Views.ISurfaceHolder> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Format p1 = (global::Android.Graphics.Format) native_p1;
			__this.SurfaceChanged (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_surfaceChanged_Landroid_view_SurfaceHolder_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.videoengine']/class[@name='VideoCaptureAndroid']/method[@name='surfaceChanged' and count(parameter)=4 and parameter[1][@type='android.view.SurfaceHolder'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("surfaceChanged", "(Landroid/view/SurfaceHolder;III)V", "GetSurfaceChanged_Landroid_view_SurfaceHolder_IIIHandler")]
		public virtual unsafe void SurfaceChanged (global::Android.Views.ISurfaceHolder p0, [global::Android.Runtime.GeneratedEnum] global::Android.Graphics.Format p1, int p2, int p3)
		{
			if (id_surfaceChanged_Landroid_view_SurfaceHolder_III == IntPtr.Zero)
				id_surfaceChanged_Landroid_view_SurfaceHolder_III = JNIEnv.GetMethodID (class_ref, "surfaceChanged", "(Landroid/view/SurfaceHolder;III)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue ((int) p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_surfaceChanged_Landroid_view_SurfaceHolder_III, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "surfaceChanged", "(Landroid/view/SurfaceHolder;III)V"), __args);
			} finally {
			}
		}

		static Delegate cb_surfaceCreated_Landroid_view_SurfaceHolder_;
#pragma warning disable 0169
		static Delegate GetSurfaceCreated_Landroid_view_SurfaceHolder_Handler ()
		{
			if (cb_surfaceCreated_Landroid_view_SurfaceHolder_ == null)
				cb_surfaceCreated_Landroid_view_SurfaceHolder_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SurfaceCreated_Landroid_view_SurfaceHolder_);
			return cb_surfaceCreated_Landroid_view_SurfaceHolder_;
		}

		static void n_SurfaceCreated_Landroid_view_SurfaceHolder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Webrtc.Videoengine.VideoCaptureAndroid __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Videoengine.VideoCaptureAndroid> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ISurfaceHolder p0 = (global::Android.Views.ISurfaceHolder)global::Java.Lang.Object.GetObject<global::Android.Views.ISurfaceHolder> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SurfaceCreated (p0);
		}
#pragma warning restore 0169

		static IntPtr id_surfaceCreated_Landroid_view_SurfaceHolder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.videoengine']/class[@name='VideoCaptureAndroid']/method[@name='surfaceCreated' and count(parameter)=1 and parameter[1][@type='android.view.SurfaceHolder']]"
		[Register ("surfaceCreated", "(Landroid/view/SurfaceHolder;)V", "GetSurfaceCreated_Landroid_view_SurfaceHolder_Handler")]
		public virtual unsafe void SurfaceCreated (global::Android.Views.ISurfaceHolder p0)
		{
			if (id_surfaceCreated_Landroid_view_SurfaceHolder_ == IntPtr.Zero)
				id_surfaceCreated_Landroid_view_SurfaceHolder_ = JNIEnv.GetMethodID (class_ref, "surfaceCreated", "(Landroid/view/SurfaceHolder;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_surfaceCreated_Landroid_view_SurfaceHolder_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "surfaceCreated", "(Landroid/view/SurfaceHolder;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_surfaceDestroyed_Landroid_view_SurfaceHolder_;
#pragma warning disable 0169
		static Delegate GetSurfaceDestroyed_Landroid_view_SurfaceHolder_Handler ()
		{
			if (cb_surfaceDestroyed_Landroid_view_SurfaceHolder_ == null)
				cb_surfaceDestroyed_Landroid_view_SurfaceHolder_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SurfaceDestroyed_Landroid_view_SurfaceHolder_);
			return cb_surfaceDestroyed_Landroid_view_SurfaceHolder_;
		}

		static void n_SurfaceDestroyed_Landroid_view_SurfaceHolder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Webrtc.Videoengine.VideoCaptureAndroid __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Videoengine.VideoCaptureAndroid> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ISurfaceHolder p0 = (global::Android.Views.ISurfaceHolder)global::Java.Lang.Object.GetObject<global::Android.Views.ISurfaceHolder> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SurfaceDestroyed (p0);
		}
#pragma warning restore 0169

		static IntPtr id_surfaceDestroyed_Landroid_view_SurfaceHolder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.videoengine']/class[@name='VideoCaptureAndroid']/method[@name='surfaceDestroyed' and count(parameter)=1 and parameter[1][@type='android.view.SurfaceHolder']]"
		[Register ("surfaceDestroyed", "(Landroid/view/SurfaceHolder;)V", "GetSurfaceDestroyed_Landroid_view_SurfaceHolder_Handler")]
		public virtual unsafe void SurfaceDestroyed (global::Android.Views.ISurfaceHolder p0)
		{
			if (id_surfaceDestroyed_Landroid_view_SurfaceHolder_ == IntPtr.Zero)
				id_surfaceDestroyed_Landroid_view_SurfaceHolder_ = JNIEnv.GetMethodID (class_ref, "surfaceDestroyed", "(Landroid/view/SurfaceHolder;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_surfaceDestroyed_Landroid_view_SurfaceHolder_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "surfaceDestroyed", "(Landroid/view/SurfaceHolder;)V"), __args);
			} finally {
			}
		}

	}
}
