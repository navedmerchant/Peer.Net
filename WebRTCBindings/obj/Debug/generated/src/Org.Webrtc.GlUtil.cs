using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Webrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='GlUtil']"
	[global::Android.Runtime.Register ("org/webrtc/GlUtil", DoNotGenerateAcw=true)]
	public partial class GlUtil : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/webrtc/GlUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GlUtil); }
		}

		protected GlUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_checkNoGLES2Error_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='GlUtil']/method[@name='checkNoGLES2Error' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("checkNoGLES2Error", "(Ljava/lang/String;)V", "")]
		public static unsafe void CheckNoGLES2Error (string p0)
		{
			if (id_checkNoGLES2Error_Ljava_lang_String_ == IntPtr.Zero)
				id_checkNoGLES2Error_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "checkNoGLES2Error", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_checkNoGLES2Error_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_createFloatBuffer_arrayF;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='GlUtil']/method[@name='createFloatBuffer' and count(parameter)=1 and parameter[1][@type='float[]']]"
		[Register ("createFloatBuffer", "([F)Ljava/nio/FloatBuffer;", "")]
		public static unsafe global::Java.Nio.FloatBuffer CreateFloatBuffer (float[] p0)
		{
			if (id_createFloatBuffer_arrayF == IntPtr.Zero)
				id_createFloatBuffer_arrayF = JNIEnv.GetStaticMethodID (class_ref, "createFloatBuffer", "([F)Ljava/nio/FloatBuffer;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Java.Nio.FloatBuffer __ret = global::Java.Lang.Object.GetObject<global::Java.Nio.FloatBuffer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createFloatBuffer_arrayF, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}
}
