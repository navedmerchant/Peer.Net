using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Webrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='VideoRendererGui']"
	[global::Android.Runtime.Register ("org/webrtc/VideoRendererGui", DoNotGenerateAcw=true)]
	public partial class VideoRendererGui : global::Java.Lang.Object, global::Android.Opengl.GLSurfaceView.IRenderer {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='VideoRendererGui.ScalingType']"
		[global::Android.Runtime.Register ("org/webrtc/VideoRendererGui$ScalingType", DoNotGenerateAcw=true)]
		public sealed partial class ScalingType : global::Java.Lang.Enum {


			static IntPtr SCALE_ASPECT_BALANCED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='VideoRendererGui.ScalingType']/field[@name='SCALE_ASPECT_BALANCED']"
			[Register ("SCALE_ASPECT_BALANCED")]
			public static global::Org.Webrtc.VideoRendererGui.ScalingType ScaleAspectBalanced {
				get {
					if (SCALE_ASPECT_BALANCED_jfieldId == IntPtr.Zero)
						SCALE_ASPECT_BALANCED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SCALE_ASPECT_BALANCED", "Lorg/webrtc/VideoRendererGui$ScalingType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SCALE_ASPECT_BALANCED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoRendererGui.ScalingType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SCALE_ASPECT_FILL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='VideoRendererGui.ScalingType']/field[@name='SCALE_ASPECT_FILL']"
			[Register ("SCALE_ASPECT_FILL")]
			public static global::Org.Webrtc.VideoRendererGui.ScalingType ScaleAspectFill {
				get {
					if (SCALE_ASPECT_FILL_jfieldId == IntPtr.Zero)
						SCALE_ASPECT_FILL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SCALE_ASPECT_FILL", "Lorg/webrtc/VideoRendererGui$ScalingType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SCALE_ASPECT_FILL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoRendererGui.ScalingType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SCALE_ASPECT_FIT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='VideoRendererGui.ScalingType']/field[@name='SCALE_ASPECT_FIT']"
			[Register ("SCALE_ASPECT_FIT")]
			public static global::Org.Webrtc.VideoRendererGui.ScalingType ScaleAspectFit {
				get {
					if (SCALE_ASPECT_FIT_jfieldId == IntPtr.Zero)
						SCALE_ASPECT_FIT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SCALE_ASPECT_FIT", "Lorg/webrtc/VideoRendererGui$ScalingType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SCALE_ASPECT_FIT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoRendererGui.ScalingType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/webrtc/VideoRendererGui$ScalingType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ScalingType); }
			}

			internal ScalingType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='VideoRendererGui.ScalingType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/webrtc/VideoRendererGui$ScalingType;", "")]
			public static unsafe global::Org.Webrtc.VideoRendererGui.ScalingType ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lorg/webrtc/VideoRendererGui$ScalingType;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Org.Webrtc.VideoRendererGui.ScalingType __ret = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoRendererGui.ScalingType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='VideoRendererGui.ScalingType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/webrtc/VideoRendererGui$ScalingType;", "")]
			public static unsafe global::Org.Webrtc.VideoRendererGui.ScalingType[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lorg/webrtc/VideoRendererGui$ScalingType;");
				try {
					return (global::Org.Webrtc.VideoRendererGui.ScalingType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Webrtc.VideoRendererGui.ScalingType));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='VideoRendererGui.YuvImageRenderer']"
		[global::Android.Runtime.Register ("org/webrtc/VideoRendererGui$YuvImageRenderer", DoNotGenerateAcw=true)]
		public partial class YuvImageRenderer : global::Java.Lang.Object, global::Org.Webrtc.VideoRenderer.ICallbacks {

			// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='VideoRendererGui.YuvImageRenderer.RendererType']"
			[global::Android.Runtime.Register ("org/webrtc/VideoRendererGui$YuvImageRenderer$RendererType", DoNotGenerateAcw=true)]
			public sealed partial class RendererType : global::Java.Lang.Enum {


				static IntPtr RENDERER_TEXTURE_jfieldId;

				// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='VideoRendererGui.YuvImageRenderer.RendererType']/field[@name='RENDERER_TEXTURE']"
				[Register ("RENDERER_TEXTURE")]
				public static global::Org.Webrtc.VideoRendererGui.YuvImageRenderer.RendererType RendererTexture {
					get {
						if (RENDERER_TEXTURE_jfieldId == IntPtr.Zero)
							RENDERER_TEXTURE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RENDERER_TEXTURE", "Lorg/webrtc/VideoRendererGui$YuvImageRenderer$RendererType;");
						IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RENDERER_TEXTURE_jfieldId);
						return global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoRendererGui.YuvImageRenderer.RendererType> (__ret, JniHandleOwnership.TransferLocalRef);
					}
				}

				static IntPtr RENDERER_YUV_jfieldId;

				// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='VideoRendererGui.YuvImageRenderer.RendererType']/field[@name='RENDERER_YUV']"
				[Register ("RENDERER_YUV")]
				public static global::Org.Webrtc.VideoRendererGui.YuvImageRenderer.RendererType RendererYuv {
					get {
						if (RENDERER_YUV_jfieldId == IntPtr.Zero)
							RENDERER_YUV_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RENDERER_YUV", "Lorg/webrtc/VideoRendererGui$YuvImageRenderer$RendererType;");
						IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RENDERER_YUV_jfieldId);
						return global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoRendererGui.YuvImageRenderer.RendererType> (__ret, JniHandleOwnership.TransferLocalRef);
					}
				}
				internal static IntPtr java_class_handle;
				internal static IntPtr class_ref {
					get {
						return JNIEnv.FindClass ("org/webrtc/VideoRendererGui$YuvImageRenderer$RendererType", ref java_class_handle);
					}
				}

				protected override IntPtr ThresholdClass {
					get { return class_ref; }
				}

				protected override global::System.Type ThresholdType {
					get { return typeof (RendererType); }
				}

				internal RendererType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			}

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/webrtc/VideoRendererGui$YuvImageRenderer", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (YuvImageRenderer); }
			}

			protected YuvImageRenderer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_canApplyRotation;
#pragma warning disable 0169
			static Delegate GetCanApplyRotationHandler ()
			{
				if (cb_canApplyRotation == null)
					cb_canApplyRotation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_CanApplyRotation);
				return cb_canApplyRotation;
			}

			static bool n_CanApplyRotation (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Webrtc.VideoRendererGui.YuvImageRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoRendererGui.YuvImageRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.CanApplyRotation ();
			}
#pragma warning restore 0169

			static IntPtr id_canApplyRotation;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='VideoRendererGui.YuvImageRenderer']/method[@name='canApplyRotation' and count(parameter)=0]"
			[Register ("canApplyRotation", "()Z", "GetCanApplyRotationHandler")]
			public virtual unsafe bool CanApplyRotation ()
			{
				if (id_canApplyRotation == IntPtr.Zero)
					id_canApplyRotation = JNIEnv.GetMethodID (class_ref, "canApplyRotation", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_canApplyRotation);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "canApplyRotation", "()Z"));
				} finally {
				}
			}

			static Delegate cb_renderFrame_Lorg_webrtc_VideoRenderer_I420Frame_;
#pragma warning disable 0169
			static Delegate GetRenderFrame_Lorg_webrtc_VideoRenderer_I420Frame_Handler ()
			{
				if (cb_renderFrame_Lorg_webrtc_VideoRenderer_I420Frame_ == null)
					cb_renderFrame_Lorg_webrtc_VideoRenderer_I420Frame_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RenderFrame_Lorg_webrtc_VideoRenderer_I420Frame_);
				return cb_renderFrame_Lorg_webrtc_VideoRenderer_I420Frame_;
			}

			static void n_RenderFrame_Lorg_webrtc_VideoRenderer_I420Frame_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Org.Webrtc.VideoRendererGui.YuvImageRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoRendererGui.YuvImageRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Webrtc.VideoRenderer.I420Frame p0 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoRenderer.I420Frame> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.RenderFrame (p0);
			}
#pragma warning restore 0169

			static IntPtr id_renderFrame_Lorg_webrtc_VideoRenderer_I420Frame_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='VideoRendererGui.YuvImageRenderer']/method[@name='renderFrame' and count(parameter)=1 and parameter[1][@type='org.webrtc.VideoRenderer.I420Frame']]"
			[Register ("renderFrame", "(Lorg/webrtc/VideoRenderer$I420Frame;)V", "GetRenderFrame_Lorg_webrtc_VideoRenderer_I420Frame_Handler")]
			public virtual unsafe void RenderFrame (global::Org.Webrtc.VideoRenderer.I420Frame p0)
			{
				if (id_renderFrame_Lorg_webrtc_VideoRenderer_I420Frame_ == IntPtr.Zero)
					id_renderFrame_Lorg_webrtc_VideoRenderer_I420Frame_ = JNIEnv.GetMethodID (class_ref, "renderFrame", "(Lorg/webrtc/VideoRenderer$I420Frame;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_renderFrame_Lorg_webrtc_VideoRenderer_I420Frame_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "renderFrame", "(Lorg/webrtc/VideoRenderer$I420Frame;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_setPosition_IIIILorg_webrtc_VideoRendererGui_ScalingType_Z;
#pragma warning disable 0169
			static Delegate GetSetPosition_IIIILorg_webrtc_VideoRendererGui_ScalingType_ZHandler ()
			{
				if (cb_setPosition_IIIILorg_webrtc_VideoRendererGui_ScalingType_Z == null)
					cb_setPosition_IIIILorg_webrtc_VideoRendererGui_ScalingType_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, int, int, IntPtr, bool>) n_SetPosition_IIIILorg_webrtc_VideoRendererGui_ScalingType_Z);
				return cb_setPosition_IIIILorg_webrtc_VideoRendererGui_ScalingType_Z;
			}

			static void n_SetPosition_IIIILorg_webrtc_VideoRendererGui_ScalingType_Z (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, int p3, IntPtr native_p4, bool p5)
			{
				global::Org.Webrtc.VideoRendererGui.YuvImageRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoRendererGui.YuvImageRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Webrtc.VideoRendererGui.ScalingType p4 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoRendererGui.ScalingType> (native_p4, JniHandleOwnership.DoNotTransfer);
				__this.SetPosition (p0, p1, p2, p3, p4, p5);
			}
#pragma warning restore 0169

			static IntPtr id_setPosition_IIIILorg_webrtc_VideoRendererGui_ScalingType_Z;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='VideoRendererGui.YuvImageRenderer']/method[@name='setPosition' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='org.webrtc.VideoRendererGui.ScalingType'] and parameter[6][@type='boolean']]"
			[Register ("setPosition", "(IIIILorg/webrtc/VideoRendererGui$ScalingType;Z)V", "GetSetPosition_IIIILorg_webrtc_VideoRendererGui_ScalingType_ZHandler")]
			public virtual unsafe void SetPosition (int p0, int p1, int p2, int p3, global::Org.Webrtc.VideoRendererGui.ScalingType p4, bool p5)
			{
				if (id_setPosition_IIIILorg_webrtc_VideoRendererGui_ScalingType_Z == IntPtr.Zero)
					id_setPosition_IIIILorg_webrtc_VideoRendererGui_ScalingType_Z = JNIEnv.GetMethodID (class_ref, "setPosition", "(IIIILorg/webrtc/VideoRendererGui$ScalingType;Z)V");
				try {
					JValue* __args = stackalloc JValue [6];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					__args [3] = new JValue (p3);
					__args [4] = new JValue (p4);
					__args [5] = new JValue (p5);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setPosition_IIIILorg_webrtc_VideoRendererGui_ScalingType_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPosition", "(IIIILorg/webrtc/VideoRendererGui$ScalingType;Z)V"), __args);
				} finally {
				}
			}

			static Delegate cb_setScreenSize_II;
#pragma warning disable 0169
			static Delegate GetSetScreenSize_IIHandler ()
			{
				if (cb_setScreenSize_II == null)
					cb_setScreenSize_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_SetScreenSize_II);
				return cb_setScreenSize_II;
			}

			static void n_SetScreenSize_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
			{
				global::Org.Webrtc.VideoRendererGui.YuvImageRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoRendererGui.YuvImageRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.SetScreenSize (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_setScreenSize_II;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='VideoRendererGui.YuvImageRenderer']/method[@name='setScreenSize' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("setScreenSize", "(II)V", "GetSetScreenSize_IIHandler")]
			public virtual unsafe void SetScreenSize (int p0, int p1)
			{
				if (id_setScreenSize_II == IntPtr.Zero)
					id_setScreenSize_II = JNIEnv.GetMethodID (class_ref, "setScreenSize", "(II)V");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setScreenSize_II, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setScreenSize", "(II)V"), __args);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/webrtc/VideoRendererGui", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VideoRendererGui); }
		}

		protected VideoRendererGui (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getEGLContext;
		public static unsafe global::Android.Opengl.EGLContext EGLContext {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='VideoRendererGui']/method[@name='getEGLContext' and count(parameter)=0]"
			[Register ("getEGLContext", "()Landroid/opengl/EGLContext;", "GetGetEGLContextHandler")]
			get {
				if (id_getEGLContext == IntPtr.Zero)
					id_getEGLContext = JNIEnv.GetStaticMethodID (class_ref, "getEGLContext", "()Landroid/opengl/EGLContext;");
				try {
					return global::Java.Lang.Object.GetObject<global::Android.Opengl.EGLContext> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getEGLContext), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_createGui_IIIILorg_webrtc_VideoRendererGui_ScalingType_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='VideoRendererGui']/method[@name='createGui' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='org.webrtc.VideoRendererGui.ScalingType'] and parameter[6][@type='boolean']]"
		[Register ("createGui", "(IIIILorg/webrtc/VideoRendererGui$ScalingType;Z)Lorg/webrtc/VideoRenderer;", "")]
		public static unsafe global::Org.Webrtc.VideoRenderer CreateGui (int p0, int p1, int p2, int p3, global::Org.Webrtc.VideoRendererGui.ScalingType p4, bool p5)
		{
			if (id_createGui_IIIILorg_webrtc_VideoRendererGui_ScalingType_Z == IntPtr.Zero)
				id_createGui_IIIILorg_webrtc_VideoRendererGui_ScalingType_Z = JNIEnv.GetStaticMethodID (class_ref, "createGui", "(IIIILorg/webrtc/VideoRendererGui$ScalingType;Z)Lorg/webrtc/VideoRenderer;");
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				global::Org.Webrtc.VideoRenderer __ret = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoRenderer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createGui_IIIILorg_webrtc_VideoRendererGui_ScalingType_Z, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_createGuiRenderer_IIIILorg_webrtc_VideoRendererGui_ScalingType_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='VideoRendererGui']/method[@name='createGuiRenderer' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='org.webrtc.VideoRendererGui.ScalingType'] and parameter[6][@type='boolean']]"
		[Register ("createGuiRenderer", "(IIIILorg/webrtc/VideoRendererGui$ScalingType;Z)Lorg/webrtc/VideoRenderer$Callbacks;", "")]
		public static unsafe global::Org.Webrtc.VideoRenderer.ICallbacks CreateGuiRenderer (int p0, int p1, int p2, int p3, global::Org.Webrtc.VideoRendererGui.ScalingType p4, bool p5)
		{
			if (id_createGuiRenderer_IIIILorg_webrtc_VideoRendererGui_ScalingType_Z == IntPtr.Zero)
				id_createGuiRenderer_IIIILorg_webrtc_VideoRendererGui_ScalingType_Z = JNIEnv.GetStaticMethodID (class_ref, "createGuiRenderer", "(IIIILorg/webrtc/VideoRendererGui$ScalingType;Z)Lorg/webrtc/VideoRenderer$Callbacks;");
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				global::Org.Webrtc.VideoRenderer.ICallbacks __ret = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoRenderer.ICallbacks> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createGuiRenderer_IIIILorg_webrtc_VideoRendererGui_ScalingType_Z, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_onDrawFrame_Ljavax_microedition_khronos_opengles_GL10_;
#pragma warning disable 0169
		static Delegate GetOnDrawFrame_Ljavax_microedition_khronos_opengles_GL10_Handler ()
		{
			if (cb_onDrawFrame_Ljavax_microedition_khronos_opengles_GL10_ == null)
				cb_onDrawFrame_Ljavax_microedition_khronos_opengles_GL10_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDrawFrame_Ljavax_microedition_khronos_opengles_GL10_);
			return cb_onDrawFrame_Ljavax_microedition_khronos_opengles_GL10_;
		}

		static void n_OnDrawFrame_Ljavax_microedition_khronos_opengles_GL10_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Webrtc.VideoRendererGui __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoRendererGui> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Javax.Microedition.Khronos.Opengles.IGL10 p0 = (global::Javax.Microedition.Khronos.Opengles.IGL10)global::Java.Lang.Object.GetObject<global::Javax.Microedition.Khronos.Opengles.IGL10> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDrawFrame (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onDrawFrame_Ljavax_microedition_khronos_opengles_GL10_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='VideoRendererGui']/method[@name='onDrawFrame' and count(parameter)=1 and parameter[1][@type='javax.microedition.khronos.opengles.GL10']]"
		[Register ("onDrawFrame", "(Ljavax/microedition/khronos/opengles/GL10;)V", "GetOnDrawFrame_Ljavax_microedition_khronos_opengles_GL10_Handler")]
		public virtual unsafe void OnDrawFrame (global::Javax.Microedition.Khronos.Opengles.IGL10 p0)
		{
			if (id_onDrawFrame_Ljavax_microedition_khronos_opengles_GL10_ == IntPtr.Zero)
				id_onDrawFrame_Ljavax_microedition_khronos_opengles_GL10_ = JNIEnv.GetMethodID (class_ref, "onDrawFrame", "(Ljavax/microedition/khronos/opengles/GL10;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onDrawFrame_Ljavax_microedition_khronos_opengles_GL10_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDrawFrame", "(Ljavax/microedition/khronos/opengles/GL10;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onSurfaceChanged_Ljavax_microedition_khronos_opengles_GL10_II;
#pragma warning disable 0169
		static Delegate GetOnSurfaceChanged_Ljavax_microedition_khronos_opengles_GL10_IIHandler ()
		{
			if (cb_onSurfaceChanged_Ljavax_microedition_khronos_opengles_GL10_II == null)
				cb_onSurfaceChanged_Ljavax_microedition_khronos_opengles_GL10_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int>) n_OnSurfaceChanged_Ljavax_microedition_khronos_opengles_GL10_II);
			return cb_onSurfaceChanged_Ljavax_microedition_khronos_opengles_GL10_II;
		}

		static void n_OnSurfaceChanged_Ljavax_microedition_khronos_opengles_GL10_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Org.Webrtc.VideoRendererGui __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoRendererGui> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Javax.Microedition.Khronos.Opengles.IGL10 p0 = (global::Javax.Microedition.Khronos.Opengles.IGL10)global::Java.Lang.Object.GetObject<global::Javax.Microedition.Khronos.Opengles.IGL10> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSurfaceChanged (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_onSurfaceChanged_Ljavax_microedition_khronos_opengles_GL10_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='VideoRendererGui']/method[@name='onSurfaceChanged' and count(parameter)=3 and parameter[1][@type='javax.microedition.khronos.opengles.GL10'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("onSurfaceChanged", "(Ljavax/microedition/khronos/opengles/GL10;II)V", "GetOnSurfaceChanged_Ljavax_microedition_khronos_opengles_GL10_IIHandler")]
		public virtual unsafe void OnSurfaceChanged (global::Javax.Microedition.Khronos.Opengles.IGL10 p0, int p1, int p2)
		{
			if (id_onSurfaceChanged_Ljavax_microedition_khronos_opengles_GL10_II == IntPtr.Zero)
				id_onSurfaceChanged_Ljavax_microedition_khronos_opengles_GL10_II = JNIEnv.GetMethodID (class_ref, "onSurfaceChanged", "(Ljavax/microedition/khronos/opengles/GL10;II)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onSurfaceChanged_Ljavax_microedition_khronos_opengles_GL10_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSurfaceChanged", "(Ljavax/microedition/khronos/opengles/GL10;II)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onSurfaceCreated_Ljavax_microedition_khronos_opengles_GL10_Ljavax_microedition_khronos_egl_EGLConfig_;
#pragma warning disable 0169
		static Delegate GetOnSurfaceCreated_Ljavax_microedition_khronos_opengles_GL10_Ljavax_microedition_khronos_egl_EGLConfig_Handler ()
		{
			if (cb_onSurfaceCreated_Ljavax_microedition_khronos_opengles_GL10_Ljavax_microedition_khronos_egl_EGLConfig_ == null)
				cb_onSurfaceCreated_Ljavax_microedition_khronos_opengles_GL10_Ljavax_microedition_khronos_egl_EGLConfig_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnSurfaceCreated_Ljavax_microedition_khronos_opengles_GL10_Ljavax_microedition_khronos_egl_EGLConfig_);
			return cb_onSurfaceCreated_Ljavax_microedition_khronos_opengles_GL10_Ljavax_microedition_khronos_egl_EGLConfig_;
		}

		static void n_OnSurfaceCreated_Ljavax_microedition_khronos_opengles_GL10_Ljavax_microedition_khronos_egl_EGLConfig_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Webrtc.VideoRendererGui __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoRendererGui> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Javax.Microedition.Khronos.Opengles.IGL10 p0 = (global::Javax.Microedition.Khronos.Opengles.IGL10)global::Java.Lang.Object.GetObject<global::Javax.Microedition.Khronos.Opengles.IGL10> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Javax.Microedition.Khronos.Egl.EGLConfig p1 = global::Java.Lang.Object.GetObject<global::Javax.Microedition.Khronos.Egl.EGLConfig> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnSurfaceCreated (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onSurfaceCreated_Ljavax_microedition_khronos_opengles_GL10_Ljavax_microedition_khronos_egl_EGLConfig_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='VideoRendererGui']/method[@name='onSurfaceCreated' and count(parameter)=2 and parameter[1][@type='javax.microedition.khronos.opengles.GL10'] and parameter[2][@type='javax.microedition.khronos.egl.EGLConfig']]"
		[Register ("onSurfaceCreated", "(Ljavax/microedition/khronos/opengles/GL10;Ljavax/microedition/khronos/egl/EGLConfig;)V", "GetOnSurfaceCreated_Ljavax_microedition_khronos_opengles_GL10_Ljavax_microedition_khronos_egl_EGLConfig_Handler")]
		public virtual unsafe void OnSurfaceCreated (global::Javax.Microedition.Khronos.Opengles.IGL10 p0, global::Javax.Microedition.Khronos.Egl.EGLConfig p1)
		{
			if (id_onSurfaceCreated_Ljavax_microedition_khronos_opengles_GL10_Ljavax_microedition_khronos_egl_EGLConfig_ == IntPtr.Zero)
				id_onSurfaceCreated_Ljavax_microedition_khronos_opengles_GL10_Ljavax_microedition_khronos_egl_EGLConfig_ = JNIEnv.GetMethodID (class_ref, "onSurfaceCreated", "(Ljavax/microedition/khronos/opengles/GL10;Ljavax/microedition/khronos/egl/EGLConfig;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onSurfaceCreated_Ljavax_microedition_khronos_opengles_GL10_Ljavax_microedition_khronos_egl_EGLConfig_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSurfaceCreated", "(Ljavax/microedition/khronos/opengles/GL10;Ljavax/microedition/khronos/egl/EGLConfig;)V"), __args);
			} finally {
			}
		}

		static IntPtr id_remove_Lorg_webrtc_VideoRenderer_Callbacks_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='VideoRendererGui']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='org.webrtc.VideoRenderer.Callbacks']]"
		[Register ("remove", "(Lorg/webrtc/VideoRenderer$Callbacks;)V", "")]
		public static unsafe void Remove (global::Org.Webrtc.VideoRenderer.ICallbacks p0)
		{
			if (id_remove_Lorg_webrtc_VideoRenderer_Callbacks_ == IntPtr.Zero)
				id_remove_Lorg_webrtc_VideoRenderer_Callbacks_ = JNIEnv.GetStaticMethodID (class_ref, "remove", "(Lorg/webrtc/VideoRenderer$Callbacks;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_remove_Lorg_webrtc_VideoRenderer_Callbacks_, __args);
			} finally {
			}
		}

		static IntPtr id_setView_Landroid_opengl_GLSurfaceView_Ljava_lang_Runnable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='VideoRendererGui']/method[@name='setView' and count(parameter)=2 and parameter[1][@type='android.opengl.GLSurfaceView'] and parameter[2][@type='java.lang.Runnable']]"
		[Register ("setView", "(Landroid/opengl/GLSurfaceView;Ljava/lang/Runnable;)V", "")]
		public static unsafe void SetView (global::Android.Opengl.GLSurfaceView p0, global::Java.Lang.IRunnable p1)
		{
			if (id_setView_Landroid_opengl_GLSurfaceView_Ljava_lang_Runnable_ == IntPtr.Zero)
				id_setView_Landroid_opengl_GLSurfaceView_Ljava_lang_Runnable_ = JNIEnv.GetStaticMethodID (class_ref, "setView", "(Landroid/opengl/GLSurfaceView;Ljava/lang/Runnable;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setView_Landroid_opengl_GLSurfaceView_Ljava_lang_Runnable_, __args);
			} finally {
			}
		}

		static IntPtr id_update_Lorg_webrtc_VideoRenderer_Callbacks_IIIILorg_webrtc_VideoRendererGui_ScalingType_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='VideoRendererGui']/method[@name='update' and count(parameter)=7 and parameter[1][@type='org.webrtc.VideoRenderer.Callbacks'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='org.webrtc.VideoRendererGui.ScalingType'] and parameter[7][@type='boolean']]"
		[Register ("update", "(Lorg/webrtc/VideoRenderer$Callbacks;IIIILorg/webrtc/VideoRendererGui$ScalingType;Z)V", "")]
		public static unsafe void Update (global::Org.Webrtc.VideoRenderer.ICallbacks p0, int p1, int p2, int p3, int p4, global::Org.Webrtc.VideoRendererGui.ScalingType p5, bool p6)
		{
			if (id_update_Lorg_webrtc_VideoRenderer_Callbacks_IIIILorg_webrtc_VideoRendererGui_ScalingType_Z == IntPtr.Zero)
				id_update_Lorg_webrtc_VideoRenderer_Callbacks_IIIILorg_webrtc_VideoRendererGui_ScalingType_Z = JNIEnv.GetStaticMethodID (class_ref, "update", "(Lorg/webrtc/VideoRenderer$Callbacks;IIIILorg/webrtc/VideoRendererGui$ScalingType;Z)V");
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_update_Lorg_webrtc_VideoRenderer_Callbacks_IIIILorg_webrtc_VideoRendererGui_ScalingType_Z, __args);
			} finally {
			}
		}

	}
}
