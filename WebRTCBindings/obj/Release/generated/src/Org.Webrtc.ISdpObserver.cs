using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Webrtc {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.webrtc']/interface[@name='SdpObserver']"
	[Register ("org/webrtc/SdpObserver", "", "Org.Webrtc.ISdpObserverInvoker")]
	public partial interface ISdpObserver : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='SdpObserver']/method[@name='onCreateFailure' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onCreateFailure", "(Ljava/lang/String;)V", "GetOnCreateFailure_Ljava_lang_String_Handler:Org.Webrtc.ISdpObserverInvoker, WebRTCBindings")]
		void OnCreateFailure (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='SdpObserver']/method[@name='onCreateSuccess' and count(parameter)=1 and parameter[1][@type='org.webrtc.SessionDescription']]"
		[Register ("onCreateSuccess", "(Lorg/webrtc/SessionDescription;)V", "GetOnCreateSuccess_Lorg_webrtc_SessionDescription_Handler:Org.Webrtc.ISdpObserverInvoker, WebRTCBindings")]
		void OnCreateSuccess (global::Org.Webrtc.SessionDescription p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='SdpObserver']/method[@name='onSetFailure' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onSetFailure", "(Ljava/lang/String;)V", "GetOnSetFailure_Ljava_lang_String_Handler:Org.Webrtc.ISdpObserverInvoker, WebRTCBindings")]
		void OnSetFailure (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='SdpObserver']/method[@name='onSetSuccess' and count(parameter)=0]"
		[Register ("onSetSuccess", "()V", "GetOnSetSuccessHandler:Org.Webrtc.ISdpObserverInvoker, WebRTCBindings")]
		void OnSetSuccess ();

	}

	[global::Android.Runtime.Register ("org/webrtc/SdpObserver", DoNotGenerateAcw=true)]
	internal class ISdpObserverInvoker : global::Java.Lang.Object, ISdpObserver {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/webrtc/SdpObserver");
		IntPtr class_ref;

		public static ISdpObserver GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISdpObserver> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.webrtc.SdpObserver"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISdpObserverInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ISdpObserverInvoker); }
		}

		static Delegate cb_onCreateFailure_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnCreateFailure_Ljava_lang_String_Handler ()
		{
			if (cb_onCreateFailure_Ljava_lang_String_ == null)
				cb_onCreateFailure_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCreateFailure_Ljava_lang_String_);
			return cb_onCreateFailure_Ljava_lang_String_;
		}

		static void n_OnCreateFailure_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Webrtc.ISdpObserver __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.ISdpObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCreateFailure (p0);
		}
#pragma warning restore 0169

		IntPtr id_onCreateFailure_Ljava_lang_String_;
		public unsafe void OnCreateFailure (string p0)
		{
			if (id_onCreateFailure_Ljava_lang_String_ == IntPtr.Zero)
				id_onCreateFailure_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onCreateFailure", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (Handle, id_onCreateFailure_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onCreateSuccess_Lorg_webrtc_SessionDescription_;
#pragma warning disable 0169
		static Delegate GetOnCreateSuccess_Lorg_webrtc_SessionDescription_Handler ()
		{
			if (cb_onCreateSuccess_Lorg_webrtc_SessionDescription_ == null)
				cb_onCreateSuccess_Lorg_webrtc_SessionDescription_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCreateSuccess_Lorg_webrtc_SessionDescription_);
			return cb_onCreateSuccess_Lorg_webrtc_SessionDescription_;
		}

		static void n_OnCreateSuccess_Lorg_webrtc_SessionDescription_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Webrtc.ISdpObserver __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.ISdpObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.SessionDescription p0 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.SessionDescription> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCreateSuccess (p0);
		}
#pragma warning restore 0169

		IntPtr id_onCreateSuccess_Lorg_webrtc_SessionDescription_;
		public unsafe void OnCreateSuccess (global::Org.Webrtc.SessionDescription p0)
		{
			if (id_onCreateSuccess_Lorg_webrtc_SessionDescription_ == IntPtr.Zero)
				id_onCreateSuccess_Lorg_webrtc_SessionDescription_ = JNIEnv.GetMethodID (class_ref, "onCreateSuccess", "(Lorg/webrtc/SessionDescription;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_onCreateSuccess_Lorg_webrtc_SessionDescription_, __args);
		}

		static Delegate cb_onSetFailure_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnSetFailure_Ljava_lang_String_Handler ()
		{
			if (cb_onSetFailure_Ljava_lang_String_ == null)
				cb_onSetFailure_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSetFailure_Ljava_lang_String_);
			return cb_onSetFailure_Ljava_lang_String_;
		}

		static void n_OnSetFailure_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Webrtc.ISdpObserver __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.ISdpObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSetFailure (p0);
		}
#pragma warning restore 0169

		IntPtr id_onSetFailure_Ljava_lang_String_;
		public unsafe void OnSetFailure (string p0)
		{
			if (id_onSetFailure_Ljava_lang_String_ == IntPtr.Zero)
				id_onSetFailure_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onSetFailure", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (Handle, id_onSetFailure_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onSetSuccess;
#pragma warning disable 0169
		static Delegate GetOnSetSuccessHandler ()
		{
			if (cb_onSetSuccess == null)
				cb_onSetSuccess = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnSetSuccess);
			return cb_onSetSuccess;
		}

		static void n_OnSetSuccess (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.ISdpObserver __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.ISdpObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnSetSuccess ();
		}
#pragma warning restore 0169

		IntPtr id_onSetSuccess;
		public unsafe void OnSetSuccess ()
		{
			if (id_onSetSuccess == IntPtr.Zero)
				id_onSetSuccess = JNIEnv.GetMethodID (class_ref, "onSetSuccess", "()V");
			JNIEnv.CallVoidMethod (Handle, id_onSetSuccess);
		}

	}

}
