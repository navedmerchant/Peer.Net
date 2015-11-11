using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Webrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='EglBase']"
	[global::Android.Runtime.Register ("org/webrtc/EglBase", DoNotGenerateAcw=true)]
	public sealed partial class EglBase : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='EglBase.ConfigType']"
		[global::Android.Runtime.Register ("org/webrtc/EglBase$ConfigType", DoNotGenerateAcw=true)]
		public sealed partial class ConfigType : global::Java.Lang.Enum {


			static IntPtr PIXEL_BUFFER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='EglBase.ConfigType']/field[@name='PIXEL_BUFFER']"
			[Register ("PIXEL_BUFFER")]
			public static global::Org.Webrtc.EglBase.ConfigType PixelBuffer {
				get {
					if (PIXEL_BUFFER_jfieldId == IntPtr.Zero)
						PIXEL_BUFFER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PIXEL_BUFFER", "Lorg/webrtc/EglBase$ConfigType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PIXEL_BUFFER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.EglBase.ConfigType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr PLAIN_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='EglBase.ConfigType']/field[@name='PLAIN']"
			[Register ("PLAIN")]
			public static global::Org.Webrtc.EglBase.ConfigType Plain {
				get {
					if (PLAIN_jfieldId == IntPtr.Zero)
						PLAIN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PLAIN", "Lorg/webrtc/EglBase$ConfigType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PLAIN_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.EglBase.ConfigType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr RECORDABLE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='EglBase.ConfigType']/field[@name='RECORDABLE']"
			[Register ("RECORDABLE")]
			public static global::Org.Webrtc.EglBase.ConfigType Recordable {
				get {
					if (RECORDABLE_jfieldId == IntPtr.Zero)
						RECORDABLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RECORDABLE", "Lorg/webrtc/EglBase$ConfigType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RECORDABLE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.EglBase.ConfigType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/webrtc/EglBase$ConfigType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ConfigType); }
			}

			internal ConfigType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='EglBase.ConfigType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/webrtc/EglBase$ConfigType;", "")]
			public static unsafe global::Org.Webrtc.EglBase.ConfigType ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lorg/webrtc/EglBase$ConfigType;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Org.Webrtc.EglBase.ConfigType __ret = global::Java.Lang.Object.GetObject<global::Org.Webrtc.EglBase.ConfigType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='EglBase.ConfigType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/webrtc/EglBase$ConfigType;", "")]
			public static unsafe global::Org.Webrtc.EglBase.ConfigType[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lorg/webrtc/EglBase$ConfigType;");
				try {
					return (global::Org.Webrtc.EglBase.ConfigType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Webrtc.EglBase.ConfigType));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/webrtc/EglBase", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (EglBase); }
		}

		internal EglBase (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_opengl_EGLContext_Lorg_webrtc_EglBase_ConfigType_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='EglBase']/constructor[@name='EglBase' and count(parameter)=2 and parameter[1][@type='android.opengl.EGLContext'] and parameter[2][@type='org.webrtc.EglBase.ConfigType']]"
		[Register (".ctor", "(Landroid/opengl/EGLContext;Lorg/webrtc/EglBase$ConfigType;)V", "")]
		public unsafe EglBase (global::Android.Opengl.EGLContext p0, global::Org.Webrtc.EglBase.ConfigType p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (EglBase)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/opengl/EGLContext;Lorg/webrtc/EglBase$ConfigType;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/opengl/EGLContext;Lorg/webrtc/EglBase$ConfigType;)V", __args);
					return;
				}

				if (id_ctor_Landroid_opengl_EGLContext_Lorg_webrtc_EglBase_ConfigType_ == IntPtr.Zero)
					id_ctor_Landroid_opengl_EGLContext_Lorg_webrtc_EglBase_ConfigType_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/opengl/EGLContext;Lorg/webrtc/EglBase$ConfigType;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_opengl_EGLContext_Lorg_webrtc_EglBase_ConfigType_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_opengl_EGLContext_Lorg_webrtc_EglBase_ConfigType_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='EglBase']/constructor[@name='EglBase' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe EglBase ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (EglBase)) {
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

		static IntPtr id_getContext;
		public unsafe global::Android.Opengl.EGLContext Context {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='EglBase']/method[@name='getContext' and count(parameter)=0]"
			[Register ("getContext", "()Landroid/opengl/EGLContext;", "GetGetContextHandler")]
			get {
				if (id_getContext == IntPtr.Zero)
					id_getContext = JNIEnv.GetMethodID (class_ref, "getContext", "()Landroid/opengl/EGLContext;");
				try {
					return global::Java.Lang.Object.GetObject<global::Android.Opengl.EGLContext> (JNIEnv.CallObjectMethod  (Handle, id_getContext), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_hasSurface;
		public unsafe bool HasSurface {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='EglBase']/method[@name='hasSurface' and count(parameter)=0]"
			[Register ("hasSurface", "()Z", "GetHasSurfaceHandler")]
			get {
				if (id_hasSurface == IntPtr.Zero)
					id_hasSurface = JNIEnv.GetMethodID (class_ref, "hasSurface", "()Z");
				try {
					return JNIEnv.CallBooleanMethod  (Handle, id_hasSurface);
				} finally {
				}
			}
		}

		static IntPtr id_isEGL14Supported;
		public static unsafe bool IsEGL14Supported {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='EglBase']/method[@name='isEGL14Supported' and count(parameter)=0]"
			[Register ("isEGL14Supported", "()Z", "GetIsEGL14SupportedHandler")]
			get {
				if (id_isEGL14Supported == IntPtr.Zero)
					id_isEGL14Supported = JNIEnv.GetStaticMethodID (class_ref, "isEGL14Supported", "()Z");
				try {
					return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isEGL14Supported);
				} finally {
				}
			}
		}

		static IntPtr id_createDummyPbufferSurface;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='EglBase']/method[@name='createDummyPbufferSurface' and count(parameter)=0]"
		[Register ("createDummyPbufferSurface", "()V", "")]
		public unsafe void CreateDummyPbufferSurface ()
		{
			if (id_createDummyPbufferSurface == IntPtr.Zero)
				id_createDummyPbufferSurface = JNIEnv.GetMethodID (class_ref, "createDummyPbufferSurface", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_createDummyPbufferSurface);
			} finally {
			}
		}

		static IntPtr id_createPbufferSurface_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='EglBase']/method[@name='createPbufferSurface' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("createPbufferSurface", "(II)V", "")]
		public unsafe void CreatePbufferSurface (int p0, int p1)
		{
			if (id_createPbufferSurface_II == IntPtr.Zero)
				id_createPbufferSurface_II = JNIEnv.GetMethodID (class_ref, "createPbufferSurface", "(II)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod  (Handle, id_createPbufferSurface_II, __args);
			} finally {
			}
		}

		static IntPtr id_createSurface_Landroid_view_Surface_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='EglBase']/method[@name='createSurface' and count(parameter)=1 and parameter[1][@type='android.view.Surface']]"
		[Register ("createSurface", "(Landroid/view/Surface;)V", "")]
		public unsafe void CreateSurface (global::Android.Views.Surface p0)
		{
			if (id_createSurface_Landroid_view_Surface_ == IntPtr.Zero)
				id_createSurface_Landroid_view_Surface_ = JNIEnv.GetMethodID (class_ref, "createSurface", "(Landroid/view/Surface;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_createSurface_Landroid_view_Surface_, __args);
			} finally {
			}
		}

		static IntPtr id_makeCurrent;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='EglBase']/method[@name='makeCurrent' and count(parameter)=0]"
		[Register ("makeCurrent", "()V", "")]
		public unsafe void MakeCurrent ()
		{
			if (id_makeCurrent == IntPtr.Zero)
				id_makeCurrent = JNIEnv.GetMethodID (class_ref, "makeCurrent", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_makeCurrent);
			} finally {
			}
		}

		static IntPtr id_release;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='EglBase']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "")]
		public unsafe void Release ()
		{
			if (id_release == IntPtr.Zero)
				id_release = JNIEnv.GetMethodID (class_ref, "release", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_release);
			} finally {
			}
		}

		static IntPtr id_releaseSurface;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='EglBase']/method[@name='releaseSurface' and count(parameter)=0]"
		[Register ("releaseSurface", "()V", "")]
		public unsafe void ReleaseSurface ()
		{
			if (id_releaseSurface == IntPtr.Zero)
				id_releaseSurface = JNIEnv.GetMethodID (class_ref, "releaseSurface", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_releaseSurface);
			} finally {
			}
		}

		static IntPtr id_swapBuffers;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='EglBase']/method[@name='swapBuffers' and count(parameter)=0]"
		[Register ("swapBuffers", "()V", "")]
		public unsafe void SwapBuffers ()
		{
			if (id_swapBuffers == IntPtr.Zero)
				id_swapBuffers = JNIEnv.GetMethodID (class_ref, "swapBuffers", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_swapBuffers);
			} finally {
			}
		}

	}
}
