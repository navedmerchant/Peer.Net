using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Webrtc.Videoengine {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc.videoengine']/class[@name='ViEAndroidGLES20']"
	[global::Android.Runtime.Register ("org/webrtc/videoengine/ViEAndroidGLES20", DoNotGenerateAcw=true)]
	public partial class ViEAndroidGLES20 : global::Android.Opengl.GLSurfaceView, global::Android.Opengl.GLSurfaceView.IRenderer {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc.videoengine']/class[@name='ViEAndroidGLES20.ConfigChooser']"
		[global::Android.Runtime.Register ("org/webrtc/videoengine/ViEAndroidGLES20$ConfigChooser", DoNotGenerateAcw=true)]
		public partial class ConfigChooser : global::Java.Lang.Object, global::Android.Opengl.GLSurfaceView.IEGLConfigChooser {


			static IntPtr mAlphaSize_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc.videoengine']/class[@name='ViEAndroidGLES20.ConfigChooser']/field[@name='mAlphaSize']"
			[Register ("mAlphaSize")]
			protected int MAlphaSize {
				get {
					if (mAlphaSize_jfieldId == IntPtr.Zero)
						mAlphaSize_jfieldId = JNIEnv.GetFieldID (class_ref, "mAlphaSize", "I");
					return JNIEnv.GetIntField (Handle, mAlphaSize_jfieldId);
				}
				set {
					if (mAlphaSize_jfieldId == IntPtr.Zero)
						mAlphaSize_jfieldId = JNIEnv.GetFieldID (class_ref, "mAlphaSize", "I");
					try {
						JNIEnv.SetField (Handle, mAlphaSize_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr mBlueSize_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc.videoengine']/class[@name='ViEAndroidGLES20.ConfigChooser']/field[@name='mBlueSize']"
			[Register ("mBlueSize")]
			protected int MBlueSize {
				get {
					if (mBlueSize_jfieldId == IntPtr.Zero)
						mBlueSize_jfieldId = JNIEnv.GetFieldID (class_ref, "mBlueSize", "I");
					return JNIEnv.GetIntField (Handle, mBlueSize_jfieldId);
				}
				set {
					if (mBlueSize_jfieldId == IntPtr.Zero)
						mBlueSize_jfieldId = JNIEnv.GetFieldID (class_ref, "mBlueSize", "I");
					try {
						JNIEnv.SetField (Handle, mBlueSize_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr mDepthSize_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc.videoengine']/class[@name='ViEAndroidGLES20.ConfigChooser']/field[@name='mDepthSize']"
			[Register ("mDepthSize")]
			protected int MDepthSize {
				get {
					if (mDepthSize_jfieldId == IntPtr.Zero)
						mDepthSize_jfieldId = JNIEnv.GetFieldID (class_ref, "mDepthSize", "I");
					return JNIEnv.GetIntField (Handle, mDepthSize_jfieldId);
				}
				set {
					if (mDepthSize_jfieldId == IntPtr.Zero)
						mDepthSize_jfieldId = JNIEnv.GetFieldID (class_ref, "mDepthSize", "I");
					try {
						JNIEnv.SetField (Handle, mDepthSize_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr mGreenSize_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc.videoengine']/class[@name='ViEAndroidGLES20.ConfigChooser']/field[@name='mGreenSize']"
			[Register ("mGreenSize")]
			protected int MGreenSize {
				get {
					if (mGreenSize_jfieldId == IntPtr.Zero)
						mGreenSize_jfieldId = JNIEnv.GetFieldID (class_ref, "mGreenSize", "I");
					return JNIEnv.GetIntField (Handle, mGreenSize_jfieldId);
				}
				set {
					if (mGreenSize_jfieldId == IntPtr.Zero)
						mGreenSize_jfieldId = JNIEnv.GetFieldID (class_ref, "mGreenSize", "I");
					try {
						JNIEnv.SetField (Handle, mGreenSize_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr mRedSize_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc.videoengine']/class[@name='ViEAndroidGLES20.ConfigChooser']/field[@name='mRedSize']"
			[Register ("mRedSize")]
			protected int MRedSize {
				get {
					if (mRedSize_jfieldId == IntPtr.Zero)
						mRedSize_jfieldId = JNIEnv.GetFieldID (class_ref, "mRedSize", "I");
					return JNIEnv.GetIntField (Handle, mRedSize_jfieldId);
				}
				set {
					if (mRedSize_jfieldId == IntPtr.Zero)
						mRedSize_jfieldId = JNIEnv.GetFieldID (class_ref, "mRedSize", "I");
					try {
						JNIEnv.SetField (Handle, mRedSize_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr mStencilSize_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc.videoengine']/class[@name='ViEAndroidGLES20.ConfigChooser']/field[@name='mStencilSize']"
			[Register ("mStencilSize")]
			protected int MStencilSize {
				get {
					if (mStencilSize_jfieldId == IntPtr.Zero)
						mStencilSize_jfieldId = JNIEnv.GetFieldID (class_ref, "mStencilSize", "I");
					return JNIEnv.GetIntField (Handle, mStencilSize_jfieldId);
				}
				set {
					if (mStencilSize_jfieldId == IntPtr.Zero)
						mStencilSize_jfieldId = JNIEnv.GetFieldID (class_ref, "mStencilSize", "I");
					try {
						JNIEnv.SetField (Handle, mStencilSize_jfieldId, value);
					} finally {
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/webrtc/videoengine/ViEAndroidGLES20$ConfigChooser", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ConfigChooser); }
			}

			protected ConfigChooser (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_IIIIII;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc.videoengine']/class[@name='ViEAndroidGLES20.ConfigChooser']/constructor[@name='ViEAndroidGLES20.ConfigChooser' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int']]"
			[Register (".ctor", "(IIIIII)V", "")]
			public unsafe ConfigChooser (int p0, int p1, int p2, int p3, int p4, int p5)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [6];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					__args [3] = new JValue (p3);
					__args [4] = new JValue (p4);
					__args [5] = new JValue (p5);
					if (GetType () != typeof (ConfigChooser)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(IIIIII)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(IIIIII)V", __args);
						return;
					}

					if (id_ctor_IIIIII == IntPtr.Zero)
						id_ctor_IIIIII = JNIEnv.GetMethodID (class_ref, "<init>", "(IIIIII)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IIIIII, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_IIIIII, __args);
				} finally {
				}
			}

			static Delegate cb_chooseConfig_Ljavax_microedition_khronos_egl_EGL10_Ljavax_microedition_khronos_egl_EGLDisplay_;
#pragma warning disable 0169
			static Delegate GetChooseConfig_Ljavax_microedition_khronos_egl_EGL10_Ljavax_microedition_khronos_egl_EGLDisplay_Handler ()
			{
				if (cb_chooseConfig_Ljavax_microedition_khronos_egl_EGL10_Ljavax_microedition_khronos_egl_EGLDisplay_ == null)
					cb_chooseConfig_Ljavax_microedition_khronos_egl_EGL10_Ljavax_microedition_khronos_egl_EGLDisplay_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_ChooseConfig_Ljavax_microedition_khronos_egl_EGL10_Ljavax_microedition_khronos_egl_EGLDisplay_);
				return cb_chooseConfig_Ljavax_microedition_khronos_egl_EGL10_Ljavax_microedition_khronos_egl_EGLDisplay_;
			}

			static IntPtr n_ChooseConfig_Ljavax_microedition_khronos_egl_EGL10_Ljavax_microedition_khronos_egl_EGLDisplay_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Org.Webrtc.Videoengine.ViEAndroidGLES20.ConfigChooser __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Videoengine.ViEAndroidGLES20.ConfigChooser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Javax.Microedition.Khronos.Egl.IEGL10 p0 = (global::Javax.Microedition.Khronos.Egl.IEGL10)global::Java.Lang.Object.GetObject<global::Javax.Microedition.Khronos.Egl.IEGL10> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Javax.Microedition.Khronos.Egl.EGLDisplay p1 = global::Java.Lang.Object.GetObject<global::Javax.Microedition.Khronos.Egl.EGLDisplay> (native_p1, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ChooseConfig (p0, p1));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_chooseConfig_Ljavax_microedition_khronos_egl_EGL10_Ljavax_microedition_khronos_egl_EGLDisplay_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.videoengine']/class[@name='ViEAndroidGLES20.ConfigChooser']/method[@name='chooseConfig' and count(parameter)=2 and parameter[1][@type='javax.microedition.khronos.egl.EGL10'] and parameter[2][@type='javax.microedition.khronos.egl.EGLDisplay']]"
			[Register ("chooseConfig", "(Ljavax/microedition/khronos/egl/EGL10;Ljavax/microedition/khronos/egl/EGLDisplay;)Ljavax/microedition/khronos/egl/EGLConfig;", "GetChooseConfig_Ljavax_microedition_khronos_egl_EGL10_Ljavax_microedition_khronos_egl_EGLDisplay_Handler")]
			public virtual unsafe global::Javax.Microedition.Khronos.Egl.EGLConfig ChooseConfig (global::Javax.Microedition.Khronos.Egl.IEGL10 p0, global::Javax.Microedition.Khronos.Egl.EGLDisplay p1)
			{
				if (id_chooseConfig_Ljavax_microedition_khronos_egl_EGL10_Ljavax_microedition_khronos_egl_EGLDisplay_ == IntPtr.Zero)
					id_chooseConfig_Ljavax_microedition_khronos_egl_EGL10_Ljavax_microedition_khronos_egl_EGLDisplay_ = JNIEnv.GetMethodID (class_ref, "chooseConfig", "(Ljavax/microedition/khronos/egl/EGL10;Ljavax/microedition/khronos/egl/EGLDisplay;)Ljavax/microedition/khronos/egl/EGLConfig;");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);

					global::Javax.Microedition.Khronos.Egl.EGLConfig __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Javax.Microedition.Khronos.Egl.EGLConfig> (JNIEnv.CallObjectMethod  (Handle, id_chooseConfig_Ljavax_microedition_khronos_egl_EGL10_Ljavax_microedition_khronos_egl_EGLDisplay_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Javax.Microedition.Khronos.Egl.EGLConfig> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "chooseConfig", "(Ljavax/microedition/khronos/egl/EGL10;Ljavax/microedition/khronos/egl/EGLDisplay;)Ljavax/microedition/khronos/egl/EGLConfig;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_chooseConfig_Ljavax_microedition_khronos_egl_EGL10_Ljavax_microedition_khronos_egl_EGLDisplay_arrayLjavax_microedition_khronos_egl_EGLConfig_;
#pragma warning disable 0169
			static Delegate GetChooseConfig_Ljavax_microedition_khronos_egl_EGL10_Ljavax_microedition_khronos_egl_EGLDisplay_arrayLjavax_microedition_khronos_egl_EGLConfig_Handler ()
			{
				if (cb_chooseConfig_Ljavax_microedition_khronos_egl_EGL10_Ljavax_microedition_khronos_egl_EGLDisplay_arrayLjavax_microedition_khronos_egl_EGLConfig_ == null)
					cb_chooseConfig_Ljavax_microedition_khronos_egl_EGL10_Ljavax_microedition_khronos_egl_EGLDisplay_arrayLjavax_microedition_khronos_egl_EGLConfig_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_ChooseConfig_Ljavax_microedition_khronos_egl_EGL10_Ljavax_microedition_khronos_egl_EGLDisplay_arrayLjavax_microedition_khronos_egl_EGLConfig_);
				return cb_chooseConfig_Ljavax_microedition_khronos_egl_EGL10_Ljavax_microedition_khronos_egl_EGLDisplay_arrayLjavax_microedition_khronos_egl_EGLConfig_;
			}

			static IntPtr n_ChooseConfig_Ljavax_microedition_khronos_egl_EGL10_Ljavax_microedition_khronos_egl_EGLDisplay_arrayLjavax_microedition_khronos_egl_EGLConfig_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
			{
				global::Org.Webrtc.Videoengine.ViEAndroidGLES20.ConfigChooser __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Videoengine.ViEAndroidGLES20.ConfigChooser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Javax.Microedition.Khronos.Egl.IEGL10 p0 = (global::Javax.Microedition.Khronos.Egl.IEGL10)global::Java.Lang.Object.GetObject<global::Javax.Microedition.Khronos.Egl.IEGL10> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Javax.Microedition.Khronos.Egl.EGLDisplay p1 = global::Java.Lang.Object.GetObject<global::Javax.Microedition.Khronos.Egl.EGLDisplay> (native_p1, JniHandleOwnership.DoNotTransfer);
				global::Javax.Microedition.Khronos.Egl.EGLConfig[] p2 = (global::Javax.Microedition.Khronos.Egl.EGLConfig[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (global::Javax.Microedition.Khronos.Egl.EGLConfig));
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ChooseConfig (p0, p1, p2));
				if (p2 != null)
					JNIEnv.CopyArray (p2, native_p2);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_chooseConfig_Ljavax_microedition_khronos_egl_EGL10_Ljavax_microedition_khronos_egl_EGLDisplay_arrayLjavax_microedition_khronos_egl_EGLConfig_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.videoengine']/class[@name='ViEAndroidGLES20.ConfigChooser']/method[@name='chooseConfig' and count(parameter)=3 and parameter[1][@type='javax.microedition.khronos.egl.EGL10'] and parameter[2][@type='javax.microedition.khronos.egl.EGLDisplay'] and parameter[3][@type='javax.microedition.khronos.egl.EGLConfig[]']]"
			[Register ("chooseConfig", "(Ljavax/microedition/khronos/egl/EGL10;Ljavax/microedition/khronos/egl/EGLDisplay;[Ljavax/microedition/khronos/egl/EGLConfig;)Ljavax/microedition/khronos/egl/EGLConfig;", "GetChooseConfig_Ljavax_microedition_khronos_egl_EGL10_Ljavax_microedition_khronos_egl_EGLDisplay_arrayLjavax_microedition_khronos_egl_EGLConfig_Handler")]
			public virtual unsafe global::Javax.Microedition.Khronos.Egl.EGLConfig ChooseConfig (global::Javax.Microedition.Khronos.Egl.IEGL10 p0, global::Javax.Microedition.Khronos.Egl.EGLDisplay p1, global::Javax.Microedition.Khronos.Egl.EGLConfig[] p2)
			{
				if (id_chooseConfig_Ljavax_microedition_khronos_egl_EGL10_Ljavax_microedition_khronos_egl_EGLDisplay_arrayLjavax_microedition_khronos_egl_EGLConfig_ == IntPtr.Zero)
					id_chooseConfig_Ljavax_microedition_khronos_egl_EGL10_Ljavax_microedition_khronos_egl_EGLDisplay_arrayLjavax_microedition_khronos_egl_EGLConfig_ = JNIEnv.GetMethodID (class_ref, "chooseConfig", "(Ljavax/microedition/khronos/egl/EGL10;Ljavax/microedition/khronos/egl/EGLDisplay;[Ljavax/microedition/khronos/egl/EGLConfig;)Ljavax/microedition/khronos/egl/EGLConfig;");
				IntPtr native_p2 = JNIEnv.NewArray (p2);
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (native_p2);

					global::Javax.Microedition.Khronos.Egl.EGLConfig __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Javax.Microedition.Khronos.Egl.EGLConfig> (JNIEnv.CallObjectMethod  (Handle, id_chooseConfig_Ljavax_microedition_khronos_egl_EGL10_Ljavax_microedition_khronos_egl_EGLDisplay_arrayLjavax_microedition_khronos_egl_EGLConfig_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Javax.Microedition.Khronos.Egl.EGLConfig> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "chooseConfig", "(Ljavax/microedition/khronos/egl/EGL10;Ljavax/microedition/khronos/egl/EGLDisplay;[Ljavax/microedition/khronos/egl/EGLConfig;)Ljavax/microedition/khronos/egl/EGLConfig;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					if (p2 != null) {
						JNIEnv.CopyArray (native_p2, p2);
						JNIEnv.DeleteLocalRef (native_p2);
					}
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc.videoengine']/class[@name='ViEAndroidGLES20.ContextFactory']"
		[global::Android.Runtime.Register ("org/webrtc/videoengine/ViEAndroidGLES20$ContextFactory", DoNotGenerateAcw=true)]
		public partial class ContextFactory : global::Java.Lang.Object, global::Android.Opengl.GLSurfaceView.IEGLContextFactory {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/webrtc/videoengine/ViEAndroidGLES20$ContextFactory", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ContextFactory); }
			}

			protected ContextFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_createContext_Ljavax_microedition_khronos_egl_EGL10_Ljavax_microedition_khronos_egl_EGLDisplay_Ljavax_microedition_khronos_egl_EGLConfig_;
#pragma warning disable 0169
			static Delegate GetCreateContext_Ljavax_microedition_khronos_egl_EGL10_Ljavax_microedition_khronos_egl_EGLDisplay_Ljavax_microedition_khronos_egl_EGLConfig_Handler ()
			{
				if (cb_createContext_Ljavax_microedition_khronos_egl_EGL10_Ljavax_microedition_khronos_egl_EGLDisplay_Ljavax_microedition_khronos_egl_EGLConfig_ == null)
					cb_createContext_Ljavax_microedition_khronos_egl_EGL10_Ljavax_microedition_khronos_egl_EGLDisplay_Ljavax_microedition_khronos_egl_EGLConfig_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateContext_Ljavax_microedition_khronos_egl_EGL10_Ljavax_microedition_khronos_egl_EGLDisplay_Ljavax_microedition_khronos_egl_EGLConfig_);
				return cb_createContext_Ljavax_microedition_khronos_egl_EGL10_Ljavax_microedition_khronos_egl_EGLDisplay_Ljavax_microedition_khronos_egl_EGLConfig_;
			}

			static IntPtr n_CreateContext_Ljavax_microedition_khronos_egl_EGL10_Ljavax_microedition_khronos_egl_EGLDisplay_Ljavax_microedition_khronos_egl_EGLConfig_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
			{
				global::Org.Webrtc.Videoengine.ViEAndroidGLES20.ContextFactory __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Videoengine.ViEAndroidGLES20.ContextFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Javax.Microedition.Khronos.Egl.IEGL10 p0 = (global::Javax.Microedition.Khronos.Egl.IEGL10)global::Java.Lang.Object.GetObject<global::Javax.Microedition.Khronos.Egl.IEGL10> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Javax.Microedition.Khronos.Egl.EGLDisplay p1 = global::Java.Lang.Object.GetObject<global::Javax.Microedition.Khronos.Egl.EGLDisplay> (native_p1, JniHandleOwnership.DoNotTransfer);
				global::Javax.Microedition.Khronos.Egl.EGLConfig p2 = global::Java.Lang.Object.GetObject<global::Javax.Microedition.Khronos.Egl.EGLConfig> (native_p2, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateContext (p0, p1, p2));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_createContext_Ljavax_microedition_khronos_egl_EGL10_Ljavax_microedition_khronos_egl_EGLDisplay_Ljavax_microedition_khronos_egl_EGLConfig_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.videoengine']/class[@name='ViEAndroidGLES20.ContextFactory']/method[@name='createContext' and count(parameter)=3 and parameter[1][@type='javax.microedition.khronos.egl.EGL10'] and parameter[2][@type='javax.microedition.khronos.egl.EGLDisplay'] and parameter[3][@type='javax.microedition.khronos.egl.EGLConfig']]"
			[Register ("createContext", "(Ljavax/microedition/khronos/egl/EGL10;Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLConfig;)Ljavax/microedition/khronos/egl/EGLContext;", "GetCreateContext_Ljavax_microedition_khronos_egl_EGL10_Ljavax_microedition_khronos_egl_EGLDisplay_Ljavax_microedition_khronos_egl_EGLConfig_Handler")]
			public virtual unsafe global::Javax.Microedition.Khronos.Egl.EGLContext CreateContext (global::Javax.Microedition.Khronos.Egl.IEGL10 p0, global::Javax.Microedition.Khronos.Egl.EGLDisplay p1, global::Javax.Microedition.Khronos.Egl.EGLConfig p2)
			{
				if (id_createContext_Ljavax_microedition_khronos_egl_EGL10_Ljavax_microedition_khronos_egl_EGLDisplay_Ljavax_microedition_khronos_egl_EGLConfig_ == IntPtr.Zero)
					id_createContext_Ljavax_microedition_khronos_egl_EGL10_Ljavax_microedition_khronos_egl_EGLDisplay_Ljavax_microedition_khronos_egl_EGLConfig_ = JNIEnv.GetMethodID (class_ref, "createContext", "(Ljavax/microedition/khronos/egl/EGL10;Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLConfig;)Ljavax/microedition/khronos/egl/EGLContext;");
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);

					global::Javax.Microedition.Khronos.Egl.EGLContext __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Javax.Microedition.Khronos.Egl.EGLContext> (JNIEnv.CallObjectMethod  (Handle, id_createContext_Ljavax_microedition_khronos_egl_EGL10_Ljavax_microedition_khronos_egl_EGLDisplay_Ljavax_microedition_khronos_egl_EGLConfig_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Javax.Microedition.Khronos.Egl.EGLContext> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createContext", "(Ljavax/microedition/khronos/egl/EGL10;Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLConfig;)Ljavax/microedition/khronos/egl/EGLContext;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_destroyContext_Ljavax_microedition_khronos_egl_EGL10_Ljavax_microedition_khronos_egl_EGLDisplay_Ljavax_microedition_khronos_egl_EGLContext_;
#pragma warning disable 0169
			static Delegate GetDestroyContext_Ljavax_microedition_khronos_egl_EGL10_Ljavax_microedition_khronos_egl_EGLDisplay_Ljavax_microedition_khronos_egl_EGLContext_Handler ()
			{
				if (cb_destroyContext_Ljavax_microedition_khronos_egl_EGL10_Ljavax_microedition_khronos_egl_EGLDisplay_Ljavax_microedition_khronos_egl_EGLContext_ == null)
					cb_destroyContext_Ljavax_microedition_khronos_egl_EGL10_Ljavax_microedition_khronos_egl_EGLDisplay_Ljavax_microedition_khronos_egl_EGLContext_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_DestroyContext_Ljavax_microedition_khronos_egl_EGL10_Ljavax_microedition_khronos_egl_EGLDisplay_Ljavax_microedition_khronos_egl_EGLContext_);
				return cb_destroyContext_Ljavax_microedition_khronos_egl_EGL10_Ljavax_microedition_khronos_egl_EGLDisplay_Ljavax_microedition_khronos_egl_EGLContext_;
			}

			static void n_DestroyContext_Ljavax_microedition_khronos_egl_EGL10_Ljavax_microedition_khronos_egl_EGLDisplay_Ljavax_microedition_khronos_egl_EGLContext_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
			{
				global::Org.Webrtc.Videoengine.ViEAndroidGLES20.ContextFactory __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Videoengine.ViEAndroidGLES20.ContextFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Javax.Microedition.Khronos.Egl.IEGL10 p0 = (global::Javax.Microedition.Khronos.Egl.IEGL10)global::Java.Lang.Object.GetObject<global::Javax.Microedition.Khronos.Egl.IEGL10> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Javax.Microedition.Khronos.Egl.EGLDisplay p1 = global::Java.Lang.Object.GetObject<global::Javax.Microedition.Khronos.Egl.EGLDisplay> (native_p1, JniHandleOwnership.DoNotTransfer);
				global::Javax.Microedition.Khronos.Egl.EGLContext p2 = global::Java.Lang.Object.GetObject<global::Javax.Microedition.Khronos.Egl.EGLContext> (native_p2, JniHandleOwnership.DoNotTransfer);
				__this.DestroyContext (p0, p1, p2);
			}
#pragma warning restore 0169

			static IntPtr id_destroyContext_Ljavax_microedition_khronos_egl_EGL10_Ljavax_microedition_khronos_egl_EGLDisplay_Ljavax_microedition_khronos_egl_EGLContext_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.videoengine']/class[@name='ViEAndroidGLES20.ContextFactory']/method[@name='destroyContext' and count(parameter)=3 and parameter[1][@type='javax.microedition.khronos.egl.EGL10'] and parameter[2][@type='javax.microedition.khronos.egl.EGLDisplay'] and parameter[3][@type='javax.microedition.khronos.egl.EGLContext']]"
			[Register ("destroyContext", "(Ljavax/microedition/khronos/egl/EGL10;Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLContext;)V", "GetDestroyContext_Ljavax_microedition_khronos_egl_EGL10_Ljavax_microedition_khronos_egl_EGLDisplay_Ljavax_microedition_khronos_egl_EGLContext_Handler")]
			public virtual unsafe void DestroyContext (global::Javax.Microedition.Khronos.Egl.IEGL10 p0, global::Javax.Microedition.Khronos.Egl.EGLDisplay p1, global::Javax.Microedition.Khronos.Egl.EGLContext p2)
			{
				if (id_destroyContext_Ljavax_microedition_khronos_egl_EGL10_Ljavax_microedition_khronos_egl_EGLDisplay_Ljavax_microedition_khronos_egl_EGLContext_ == IntPtr.Zero)
					id_destroyContext_Ljavax_microedition_khronos_egl_EGL10_Ljavax_microedition_khronos_egl_EGLDisplay_Ljavax_microedition_khronos_egl_EGLContext_ = JNIEnv.GetMethodID (class_ref, "destroyContext", "(Ljavax/microedition/khronos/egl/EGL10;Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLContext;)V");
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_destroyContext_Ljavax_microedition_khronos_egl_EGL10_Ljavax_microedition_khronos_egl_EGLDisplay_Ljavax_microedition_khronos_egl_EGLContext_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "destroyContext", "(Ljavax/microedition/khronos/egl/EGL10;Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLContext;)V"), __args);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/webrtc/videoengine/ViEAndroidGLES20", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ViEAndroidGLES20); }
		}

		protected ViEAndroidGLES20 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc.videoengine']/class[@name='ViEAndroidGLES20']/constructor[@name='ViEAndroidGLES20' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe ViEAndroidGLES20 (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (ViEAndroidGLES20)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_ZII;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc.videoengine']/class[@name='ViEAndroidGLES20']/constructor[@name='ViEAndroidGLES20' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='boolean'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;ZII)V", "")]
		public unsafe ViEAndroidGLES20 (global::Android.Content.Context p0, bool p1, int p2, int p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				if (GetType () != typeof (ViEAndroidGLES20)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;ZII)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;ZII)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ZII == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ZII = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;ZII)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_ZII, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_ZII, __args);
			} finally {
			}
		}

		static Delegate cb_DeRegisterNativeObject;
#pragma warning disable 0169
		static Delegate GetDeRegisterNativeObjectHandler ()
		{
			if (cb_DeRegisterNativeObject == null)
				cb_DeRegisterNativeObject = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DeRegisterNativeObject);
			return cb_DeRegisterNativeObject;
		}

		static void n_DeRegisterNativeObject (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.Videoengine.ViEAndroidGLES20 __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Videoengine.ViEAndroidGLES20> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DeRegisterNativeObject ();
		}
#pragma warning restore 0169

		static IntPtr id_DeRegisterNativeObject;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.videoengine']/class[@name='ViEAndroidGLES20']/method[@name='DeRegisterNativeObject' and count(parameter)=0]"
		[Register ("DeRegisterNativeObject", "()V", "GetDeRegisterNativeObjectHandler")]
		public virtual unsafe void DeRegisterNativeObject ()
		{
			if (id_DeRegisterNativeObject == IntPtr.Zero)
				id_DeRegisterNativeObject = JNIEnv.GetMethodID (class_ref, "DeRegisterNativeObject", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_DeRegisterNativeObject);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "DeRegisterNativeObject", "()V"));
			} finally {
			}
		}

		static IntPtr id_IsSupported_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.videoengine']/class[@name='ViEAndroidGLES20']/method[@name='IsSupported' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("IsSupported", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool IsSupported (global::Android.Content.Context p0)
		{
			if (id_IsSupported_Landroid_content_Context_ == IntPtr.Zero)
				id_IsSupported_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "IsSupported", "(Landroid/content/Context;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_IsSupported_Landroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_ReDraw;
#pragma warning disable 0169
		static Delegate GetReDrawHandler ()
		{
			if (cb_ReDraw == null)
				cb_ReDraw = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ReDraw);
			return cb_ReDraw;
		}

		static void n_ReDraw (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.Videoengine.ViEAndroidGLES20 __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Videoengine.ViEAndroidGLES20> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReDraw ();
		}
#pragma warning restore 0169

		static IntPtr id_ReDraw;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.videoengine']/class[@name='ViEAndroidGLES20']/method[@name='ReDraw' and count(parameter)=0]"
		[Register ("ReDraw", "()V", "GetReDrawHandler")]
		public virtual unsafe void ReDraw ()
		{
			if (id_ReDraw == IntPtr.Zero)
				id_ReDraw = JNIEnv.GetMethodID (class_ref, "ReDraw", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_ReDraw);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "ReDraw", "()V"));
			} finally {
			}
		}

		static Delegate cb_RegisterNativeObject_J;
#pragma warning disable 0169
		static Delegate GetRegisterNativeObject_JHandler ()
		{
			if (cb_RegisterNativeObject_J == null)
				cb_RegisterNativeObject_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_RegisterNativeObject_J);
			return cb_RegisterNativeObject_J;
		}

		static void n_RegisterNativeObject_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Org.Webrtc.Videoengine.ViEAndroidGLES20 __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Videoengine.ViEAndroidGLES20> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RegisterNativeObject (p0);
		}
#pragma warning restore 0169

		static IntPtr id_RegisterNativeObject_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.videoengine']/class[@name='ViEAndroidGLES20']/method[@name='RegisterNativeObject' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("RegisterNativeObject", "(J)V", "GetRegisterNativeObject_JHandler")]
		public virtual unsafe void RegisterNativeObject (long p0)
		{
			if (id_RegisterNativeObject_J == IntPtr.Zero)
				id_RegisterNativeObject_J = JNIEnv.GetMethodID (class_ref, "RegisterNativeObject", "(J)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_RegisterNativeObject_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "RegisterNativeObject", "(J)V"), __args);
			} finally {
			}
		}

		static IntPtr id_UseOpenGL2_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.videoengine']/class[@name='ViEAndroidGLES20']/method[@name='UseOpenGL2' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("UseOpenGL2", "(Ljava/lang/Object;)Z", "")]
		public static unsafe bool UseOpenGL2 (global::Java.Lang.Object p0)
		{
			if (id_UseOpenGL2_Ljava_lang_Object_ == IntPtr.Zero)
				id_UseOpenGL2_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "UseOpenGL2", "(Ljava/lang/Object;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_UseOpenGL2_Ljava_lang_Object_, __args);
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
			global::Org.Webrtc.Videoengine.ViEAndroidGLES20 __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Videoengine.ViEAndroidGLES20> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Javax.Microedition.Khronos.Opengles.IGL10 p0 = (global::Javax.Microedition.Khronos.Opengles.IGL10)global::Java.Lang.Object.GetObject<global::Javax.Microedition.Khronos.Opengles.IGL10> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDrawFrame (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onDrawFrame_Ljavax_microedition_khronos_opengles_GL10_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.videoengine']/class[@name='ViEAndroidGLES20']/method[@name='onDrawFrame' and count(parameter)=1 and parameter[1][@type='javax.microedition.khronos.opengles.GL10']]"
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
			global::Org.Webrtc.Videoengine.ViEAndroidGLES20 __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Videoengine.ViEAndroidGLES20> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Javax.Microedition.Khronos.Opengles.IGL10 p0 = (global::Javax.Microedition.Khronos.Opengles.IGL10)global::Java.Lang.Object.GetObject<global::Javax.Microedition.Khronos.Opengles.IGL10> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSurfaceChanged (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_onSurfaceChanged_Ljavax_microedition_khronos_opengles_GL10_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.videoengine']/class[@name='ViEAndroidGLES20']/method[@name='onSurfaceChanged' and count(parameter)=3 and parameter[1][@type='javax.microedition.khronos.opengles.GL10'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
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
			global::Org.Webrtc.Videoengine.ViEAndroidGLES20 __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Videoengine.ViEAndroidGLES20> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Javax.Microedition.Khronos.Opengles.IGL10 p0 = (global::Javax.Microedition.Khronos.Opengles.IGL10)global::Java.Lang.Object.GetObject<global::Javax.Microedition.Khronos.Opengles.IGL10> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Javax.Microedition.Khronos.Egl.EGLConfig p1 = global::Java.Lang.Object.GetObject<global::Javax.Microedition.Khronos.Egl.EGLConfig> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnSurfaceCreated (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onSurfaceCreated_Ljavax_microedition_khronos_opengles_GL10_Ljavax_microedition_khronos_egl_EGLConfig_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.videoengine']/class[@name='ViEAndroidGLES20']/method[@name='onSurfaceCreated' and count(parameter)=2 and parameter[1][@type='javax.microedition.khronos.opengles.GL10'] and parameter[2][@type='javax.microedition.khronos.egl.EGLConfig']]"
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

	}
}
