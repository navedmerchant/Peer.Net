using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Webrtc.Videoengine {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc.videoengine']/class[@name='ViESurfaceRenderer']"
	[global::Android.Runtime.Register ("org/webrtc/videoengine/ViESurfaceRenderer", DoNotGenerateAcw=true)]
	public partial class ViESurfaceRenderer : global::Java.Lang.Object, global::Android.Views.ISurfaceHolderCallback {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/webrtc/videoengine/ViESurfaceRenderer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ViESurfaceRenderer); }
		}

		protected ViESurfaceRenderer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_view_SurfaceView_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc.videoengine']/class[@name='ViESurfaceRenderer']/constructor[@name='ViESurfaceRenderer' and count(parameter)=1 and parameter[1][@type='android.view.SurfaceView']]"
		[Register (".ctor", "(Landroid/view/SurfaceView;)V", "")]
		public unsafe ViESurfaceRenderer (global::Android.Views.SurfaceView p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (ViESurfaceRenderer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/view/SurfaceView;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/view/SurfaceView;)V", __args);
					return;
				}

				if (id_ctor_Landroid_view_SurfaceView_ == IntPtr.Zero)
					id_ctor_Landroid_view_SurfaceView_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/view/SurfaceView;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_view_SurfaceView_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_view_SurfaceView_, __args);
			} finally {
			}
		}

		static Delegate cb_CreateBitmap_II;
#pragma warning disable 0169
		static Delegate GetCreateBitmap_IIHandler ()
		{
			if (cb_CreateBitmap_II == null)
				cb_CreateBitmap_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr>) n_CreateBitmap_II);
			return cb_CreateBitmap_II;
		}

		static IntPtr n_CreateBitmap_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Org.Webrtc.Videoengine.ViESurfaceRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Videoengine.ViESurfaceRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CreateBitmap (p0, p1));
		}
#pragma warning restore 0169

		static IntPtr id_CreateBitmap_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.videoengine']/class[@name='ViESurfaceRenderer']/method[@name='CreateBitmap' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("CreateBitmap", "(II)Landroid/graphics/Bitmap;", "GetCreateBitmap_IIHandler")]
		public virtual unsafe global::Android.Graphics.Bitmap CreateBitmap (int p0, int p1)
		{
			if (id_CreateBitmap_II == IntPtr.Zero)
				id_CreateBitmap_II = JNIEnv.GetMethodID (class_ref, "CreateBitmap", "(II)Landroid/graphics/Bitmap;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod  (Handle, id_CreateBitmap_II, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "CreateBitmap", "(II)Landroid/graphics/Bitmap;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_CreateByteBuffer_II;
#pragma warning disable 0169
		static Delegate GetCreateByteBuffer_IIHandler ()
		{
			if (cb_CreateByteBuffer_II == null)
				cb_CreateByteBuffer_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr>) n_CreateByteBuffer_II);
			return cb_CreateByteBuffer_II;
		}

		static IntPtr n_CreateByteBuffer_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Org.Webrtc.Videoengine.ViESurfaceRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Videoengine.ViESurfaceRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CreateByteBuffer (p0, p1));
		}
#pragma warning restore 0169

		static IntPtr id_CreateByteBuffer_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.videoengine']/class[@name='ViESurfaceRenderer']/method[@name='CreateByteBuffer' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("CreateByteBuffer", "(II)Ljava/nio/ByteBuffer;", "GetCreateByteBuffer_IIHandler")]
		public virtual unsafe global::Java.Nio.ByteBuffer CreateByteBuffer (int p0, int p1)
		{
			if (id_CreateByteBuffer_II == IntPtr.Zero)
				id_CreateByteBuffer_II = JNIEnv.GetMethodID (class_ref, "CreateByteBuffer", "(II)Ljava/nio/ByteBuffer;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (JNIEnv.CallObjectMethod  (Handle, id_CreateByteBuffer_II, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "CreateByteBuffer", "(II)Ljava/nio/ByteBuffer;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_DrawBitmap;
#pragma warning disable 0169
		static Delegate GetDrawBitmapHandler ()
		{
			if (cb_DrawBitmap == null)
				cb_DrawBitmap = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DrawBitmap);
			return cb_DrawBitmap;
		}

		static void n_DrawBitmap (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.Videoengine.ViESurfaceRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Videoengine.ViESurfaceRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DrawBitmap ();
		}
#pragma warning restore 0169

		static IntPtr id_DrawBitmap;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.videoengine']/class[@name='ViESurfaceRenderer']/method[@name='DrawBitmap' and count(parameter)=0]"
		[Register ("DrawBitmap", "()V", "GetDrawBitmapHandler")]
		public virtual unsafe void DrawBitmap ()
		{
			if (id_DrawBitmap == IntPtr.Zero)
				id_DrawBitmap = JNIEnv.GetMethodID (class_ref, "DrawBitmap", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_DrawBitmap);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "DrawBitmap", "()V"));
			} finally {
			}
		}

		static Delegate cb_DrawByteBuffer;
#pragma warning disable 0169
		static Delegate GetDrawByteBufferHandler ()
		{
			if (cb_DrawByteBuffer == null)
				cb_DrawByteBuffer = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DrawByteBuffer);
			return cb_DrawByteBuffer;
		}

		static void n_DrawByteBuffer (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.Videoengine.ViESurfaceRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Videoengine.ViESurfaceRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DrawByteBuffer ();
		}
#pragma warning restore 0169

		static IntPtr id_DrawByteBuffer;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.videoengine']/class[@name='ViESurfaceRenderer']/method[@name='DrawByteBuffer' and count(parameter)=0]"
		[Register ("DrawByteBuffer", "()V", "GetDrawByteBufferHandler")]
		public virtual unsafe void DrawByteBuffer ()
		{
			if (id_DrawByteBuffer == IntPtr.Zero)
				id_DrawByteBuffer = JNIEnv.GetMethodID (class_ref, "DrawByteBuffer", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_DrawByteBuffer);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "DrawByteBuffer", "()V"));
			} finally {
			}
		}

		static Delegate cb_SetCoordinates_FFFF;
#pragma warning disable 0169
		static Delegate GetSetCoordinates_FFFFHandler ()
		{
			if (cb_SetCoordinates_FFFF == null)
				cb_SetCoordinates_FFFF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float, float, float>) n_SetCoordinates_FFFF);
			return cb_SetCoordinates_FFFF;
		}

		static void n_SetCoordinates_FFFF (IntPtr jnienv, IntPtr native__this, float p0, float p1, float p2, float p3)
		{
			global::Org.Webrtc.Videoengine.ViESurfaceRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Videoengine.ViESurfaceRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetCoordinates (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_SetCoordinates_FFFF;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.videoengine']/class[@name='ViESurfaceRenderer']/method[@name='SetCoordinates' and count(parameter)=4 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float']]"
		[Register ("SetCoordinates", "(FFFF)V", "GetSetCoordinates_FFFFHandler")]
		public virtual unsafe void SetCoordinates (float p0, float p1, float p2, float p3)
		{
			if (id_SetCoordinates_FFFF == IntPtr.Zero)
				id_SetCoordinates_FFFF = JNIEnv.GetMethodID (class_ref, "SetCoordinates", "(FFFF)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_SetCoordinates_FFFF, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "SetCoordinates", "(FFFF)V"), __args);
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
			global::Org.Webrtc.Videoengine.ViESurfaceRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Videoengine.ViESurfaceRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ISurfaceHolder p0 = (global::Android.Views.ISurfaceHolder)global::Java.Lang.Object.GetObject<global::Android.Views.ISurfaceHolder> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Format p1 = (global::Android.Graphics.Format) native_p1;
			__this.SurfaceChanged (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_surfaceChanged_Landroid_view_SurfaceHolder_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.videoengine']/class[@name='ViESurfaceRenderer']/method[@name='surfaceChanged' and count(parameter)=4 and parameter[1][@type='android.view.SurfaceHolder'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
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
			global::Org.Webrtc.Videoengine.ViESurfaceRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Videoengine.ViESurfaceRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ISurfaceHolder p0 = (global::Android.Views.ISurfaceHolder)global::Java.Lang.Object.GetObject<global::Android.Views.ISurfaceHolder> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SurfaceCreated (p0);
		}
#pragma warning restore 0169

		static IntPtr id_surfaceCreated_Landroid_view_SurfaceHolder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.videoengine']/class[@name='ViESurfaceRenderer']/method[@name='surfaceCreated' and count(parameter)=1 and parameter[1][@type='android.view.SurfaceHolder']]"
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
			global::Org.Webrtc.Videoengine.ViESurfaceRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Videoengine.ViESurfaceRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ISurfaceHolder p0 = (global::Android.Views.ISurfaceHolder)global::Java.Lang.Object.GetObject<global::Android.Views.ISurfaceHolder> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SurfaceDestroyed (p0);
		}
#pragma warning restore 0169

		static IntPtr id_surfaceDestroyed_Landroid_view_SurfaceHolder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.videoengine']/class[@name='ViESurfaceRenderer']/method[@name='surfaceDestroyed' and count(parameter)=1 and parameter[1][@type='android.view.SurfaceHolder']]"
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
