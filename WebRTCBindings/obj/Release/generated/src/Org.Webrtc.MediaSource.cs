using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Webrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='MediaSource']"
	[global::Android.Runtime.Register ("org/webrtc/MediaSource", DoNotGenerateAcw=true)]
	public partial class MediaSource : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='MediaSource.State']"
		[global::Android.Runtime.Register ("org/webrtc/MediaSource$State", DoNotGenerateAcw=true)]
		public sealed partial class State : global::Java.Lang.Enum {


			static IntPtr ENDED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='MediaSource.State']/field[@name='ENDED']"
			[Register ("ENDED")]
			public static global::Org.Webrtc.MediaSource.State Ended {
				get {
					if (ENDED_jfieldId == IntPtr.Zero)
						ENDED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ENDED", "Lorg/webrtc/MediaSource$State;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ENDED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaSource.State> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr INITIALIZING_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='MediaSource.State']/field[@name='INITIALIZING']"
			[Register ("INITIALIZING")]
			public static global::Org.Webrtc.MediaSource.State Initializing {
				get {
					if (INITIALIZING_jfieldId == IntPtr.Zero)
						INITIALIZING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INITIALIZING", "Lorg/webrtc/MediaSource$State;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INITIALIZING_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaSource.State> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr LIVE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='MediaSource.State']/field[@name='LIVE']"
			[Register ("LIVE")]
			public static global::Org.Webrtc.MediaSource.State Live {
				get {
					if (LIVE_jfieldId == IntPtr.Zero)
						LIVE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LIVE", "Lorg/webrtc/MediaSource$State;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LIVE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaSource.State> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr MUTED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='MediaSource.State']/field[@name='MUTED']"
			[Register ("MUTED")]
			public static global::Org.Webrtc.MediaSource.State Muted {
				get {
					if (MUTED_jfieldId == IntPtr.Zero)
						MUTED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MUTED", "Lorg/webrtc/MediaSource$State;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MUTED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaSource.State> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/webrtc/MediaSource$State", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (State); }
			}

			internal State (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='MediaSource.State']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/webrtc/MediaSource$State;", "")]
			public static unsafe global::Org.Webrtc.MediaSource.State ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lorg/webrtc/MediaSource$State;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Org.Webrtc.MediaSource.State __ret = global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaSource.State> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='MediaSource.State']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/webrtc/MediaSource$State;", "")]
			public static unsafe global::Org.Webrtc.MediaSource.State[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lorg/webrtc/MediaSource$State;");
				try {
					return (global::Org.Webrtc.MediaSource.State[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Webrtc.MediaSource.State));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/webrtc/MediaSource", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MediaSource); }
		}

		protected MediaSource (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='MediaSource']/constructor[@name='MediaSource' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		public unsafe MediaSource (long p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (MediaSource)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(J)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(J)V", __args);
					return;
				}

				if (id_ctor_J == IntPtr.Zero)
					id_ctor_J = JNIEnv.GetMethodID (class_ref, "<init>", "(J)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_J, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_J, __args);
			} finally {
			}
		}

		static Delegate cb_dispose;
#pragma warning disable 0169
		static Delegate GetDisposeHandler ()
		{
			if (cb_dispose == null)
				cb_dispose = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Dispose);
			return cb_dispose;
		}

		static void n_Dispose (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.MediaSource __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dispose ();
		}
#pragma warning restore 0169

		static IntPtr id_dispose;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='MediaSource']/method[@name='dispose' and count(parameter)=0]"
		[Register ("dispose", "()V", "GetDisposeHandler")]
		public virtual unsafe void Dispose ()
		{
			if (id_dispose == IntPtr.Zero)
				id_dispose = JNIEnv.GetMethodID (class_ref, "dispose", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_dispose);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dispose", "()V"));
			} finally {
			}
		}

		static Delegate cb_state;
#pragma warning disable 0169
		static Delegate GetInvokeStateHandler ()
		{
			if (cb_state == null)
				cb_state = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_InvokeState);
			return cb_state;
		}

		static IntPtr n_InvokeState (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.MediaSource __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InvokeState ());
		}
#pragma warning restore 0169

		static IntPtr id_state;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='MediaSource']/method[@name='state' and count(parameter)=0]"
		[Register ("state", "()Lorg/webrtc/MediaSource$State;", "GetInvokeStateHandler")]
		public virtual unsafe global::Org.Webrtc.MediaSource.State InvokeState ()
		{
			if (id_state == IntPtr.Zero)
				id_state = JNIEnv.GetMethodID (class_ref, "state", "()Lorg/webrtc/MediaSource$State;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaSource.State> (JNIEnv.CallObjectMethod  (Handle, id_state), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaSource.State> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "state", "()Lorg/webrtc/MediaSource$State;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
