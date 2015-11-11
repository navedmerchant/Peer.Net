using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Webrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='GlShader']"
	[global::Android.Runtime.Register ("org/webrtc/GlShader", DoNotGenerateAcw=true)]
	public partial class GlShader : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/webrtc/GlShader", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GlShader); }
		}

		protected GlShader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='GlShader']/constructor[@name='GlShader' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe GlShader (string p0, string p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				if (GetType () != typeof (GlShader)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_getAttribLocation_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetAttribLocation_Ljava_lang_String_Handler ()
		{
			if (cb_getAttribLocation_Ljava_lang_String_ == null)
				cb_getAttribLocation_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetAttribLocation_Ljava_lang_String_);
			return cb_getAttribLocation_Ljava_lang_String_;
		}

		static int n_GetAttribLocation_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Webrtc.GlShader __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.GlShader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetAttribLocation (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getAttribLocation_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='GlShader']/method[@name='getAttribLocation' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getAttribLocation", "(Ljava/lang/String;)I", "GetGetAttribLocation_Ljava_lang_String_Handler")]
		public virtual unsafe int GetAttribLocation (string p0)
		{
			if (id_getAttribLocation_Ljava_lang_String_ == IntPtr.Zero)
				id_getAttribLocation_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getAttribLocation", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod  (Handle, id_getAttribLocation_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAttribLocation", "(Ljava/lang/String;)I"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getUniformLocation_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetUniformLocation_Ljava_lang_String_Handler ()
		{
			if (cb_getUniformLocation_Ljava_lang_String_ == null)
				cb_getUniformLocation_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetUniformLocation_Ljava_lang_String_);
			return cb_getUniformLocation_Ljava_lang_String_;
		}

		static int n_GetUniformLocation_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Webrtc.GlShader __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.GlShader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetUniformLocation (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getUniformLocation_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='GlShader']/method[@name='getUniformLocation' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getUniformLocation", "(Ljava/lang/String;)I", "GetGetUniformLocation_Ljava_lang_String_Handler")]
		public virtual unsafe int GetUniformLocation (string p0)
		{
			if (id_getUniformLocation_Ljava_lang_String_ == IntPtr.Zero)
				id_getUniformLocation_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getUniformLocation", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod  (Handle, id_getUniformLocation_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUniformLocation", "(Ljava/lang/String;)I"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
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
			global::Org.Webrtc.GlShader __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.GlShader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Release ();
		}
#pragma warning restore 0169

		static IntPtr id_release;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='GlShader']/method[@name='release' and count(parameter)=0]"
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

		static Delegate cb_setVertexAttribArray_Ljava_lang_String_ILjava_nio_FloatBuffer_;
#pragma warning disable 0169
		static Delegate GetSetVertexAttribArray_Ljava_lang_String_ILjava_nio_FloatBuffer_Handler ()
		{
			if (cb_setVertexAttribArray_Ljava_lang_String_ILjava_nio_FloatBuffer_ == null)
				cb_setVertexAttribArray_Ljava_lang_String_ILjava_nio_FloatBuffer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_SetVertexAttribArray_Ljava_lang_String_ILjava_nio_FloatBuffer_);
			return cb_setVertexAttribArray_Ljava_lang_String_ILjava_nio_FloatBuffer_;
		}

		static void n_SetVertexAttribArray_Ljava_lang_String_ILjava_nio_FloatBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
		{
			global::Org.Webrtc.GlShader __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.GlShader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.FloatBuffer p2 = global::Java.Lang.Object.GetObject<global::Java.Nio.FloatBuffer> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SetVertexAttribArray (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_setVertexAttribArray_Ljava_lang_String_ILjava_nio_FloatBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='GlShader']/method[@name='setVertexAttribArray' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='java.nio.FloatBuffer']]"
		[Register ("setVertexAttribArray", "(Ljava/lang/String;ILjava/nio/FloatBuffer;)V", "GetSetVertexAttribArray_Ljava_lang_String_ILjava_nio_FloatBuffer_Handler")]
		public virtual unsafe void SetVertexAttribArray (string p0, int p1, global::Java.Nio.FloatBuffer p2)
		{
			if (id_setVertexAttribArray_Ljava_lang_String_ILjava_nio_FloatBuffer_ == IntPtr.Zero)
				id_setVertexAttribArray_Ljava_lang_String_ILjava_nio_FloatBuffer_ = JNIEnv.GetMethodID (class_ref, "setVertexAttribArray", "(Ljava/lang/String;ILjava/nio/FloatBuffer;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setVertexAttribArray_Ljava_lang_String_ILjava_nio_FloatBuffer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setVertexAttribArray", "(Ljava/lang/String;ILjava/nio/FloatBuffer;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_useProgram;
#pragma warning disable 0169
		static Delegate GetUseProgramHandler ()
		{
			if (cb_useProgram == null)
				cb_useProgram = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_UseProgram);
			return cb_useProgram;
		}

		static void n_UseProgram (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.GlShader __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.GlShader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UseProgram ();
		}
#pragma warning restore 0169

		static IntPtr id_useProgram;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='GlShader']/method[@name='useProgram' and count(parameter)=0]"
		[Register ("useProgram", "()V", "GetUseProgramHandler")]
		public virtual unsafe void UseProgram ()
		{
			if (id_useProgram == IntPtr.Zero)
				id_useProgram = JNIEnv.GetMethodID (class_ref, "useProgram", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_useProgram);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "useProgram", "()V"));
			} finally {
			}
		}

	}
}
