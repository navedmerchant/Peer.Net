using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Webrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='MediaStreamTrack']"
	[global::Android.Runtime.Register ("org/webrtc/MediaStreamTrack", DoNotGenerateAcw=true)]
	public partial class MediaStreamTrack : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='MediaStreamTrack.State']"
		[global::Android.Runtime.Register ("org/webrtc/MediaStreamTrack$State", DoNotGenerateAcw=true)]
		public sealed partial class State : global::Java.Lang.Enum {


			static IntPtr ENDED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='MediaStreamTrack.State']/field[@name='ENDED']"
			[Register ("ENDED")]
			public static global::Org.Webrtc.MediaStreamTrack.State Ended {
				get {
					if (ENDED_jfieldId == IntPtr.Zero)
						ENDED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ENDED", "Lorg/webrtc/MediaStreamTrack$State;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ENDED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaStreamTrack.State> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr FAILED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='MediaStreamTrack.State']/field[@name='FAILED']"
			[Register ("FAILED")]
			public static global::Org.Webrtc.MediaStreamTrack.State Failed {
				get {
					if (FAILED_jfieldId == IntPtr.Zero)
						FAILED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FAILED", "Lorg/webrtc/MediaStreamTrack$State;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FAILED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaStreamTrack.State> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr INITIALIZING_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='MediaStreamTrack.State']/field[@name='INITIALIZING']"
			[Register ("INITIALIZING")]
			public static global::Org.Webrtc.MediaStreamTrack.State Initializing {
				get {
					if (INITIALIZING_jfieldId == IntPtr.Zero)
						INITIALIZING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INITIALIZING", "Lorg/webrtc/MediaStreamTrack$State;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INITIALIZING_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaStreamTrack.State> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr LIVE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='MediaStreamTrack.State']/field[@name='LIVE']"
			[Register ("LIVE")]
			public static global::Org.Webrtc.MediaStreamTrack.State Live {
				get {
					if (LIVE_jfieldId == IntPtr.Zero)
						LIVE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LIVE", "Lorg/webrtc/MediaStreamTrack$State;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LIVE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaStreamTrack.State> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/webrtc/MediaStreamTrack$State", ref java_class_handle);
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
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='MediaStreamTrack.State']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/webrtc/MediaStreamTrack$State;", "")]
			public static unsafe global::Org.Webrtc.MediaStreamTrack.State ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lorg/webrtc/MediaStreamTrack$State;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Org.Webrtc.MediaStreamTrack.State __ret = global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaStreamTrack.State> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='MediaStreamTrack.State']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/webrtc/MediaStreamTrack$State;", "")]
			public static unsafe global::Org.Webrtc.MediaStreamTrack.State[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lorg/webrtc/MediaStreamTrack$State;");
				try {
					return (global::Org.Webrtc.MediaStreamTrack.State[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Webrtc.MediaStreamTrack.State));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/webrtc/MediaStreamTrack", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MediaStreamTrack); }
		}

		protected MediaStreamTrack (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='MediaStreamTrack']/constructor[@name='MediaStreamTrack' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		public unsafe MediaStreamTrack (long p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (MediaStreamTrack)) {
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
			global::Org.Webrtc.MediaStreamTrack __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaStreamTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dispose ();
		}
#pragma warning restore 0169

		static IntPtr id_dispose;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='MediaStreamTrack']/method[@name='dispose' and count(parameter)=0]"
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

		static Delegate cb_enabled;
#pragma warning disable 0169
		static Delegate GetEnabledHandler ()
		{
			if (cb_enabled == null)
				cb_enabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Enabled);
			return cb_enabled;
		}

		static bool n_Enabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.MediaStreamTrack __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaStreamTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Enabled ();
		}
#pragma warning restore 0169

		static IntPtr id_enabled;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='MediaStreamTrack']/method[@name='enabled' and count(parameter)=0]"
		[Register ("enabled", "()Z", "GetEnabledHandler")]
		public virtual unsafe bool Enabled ()
		{
			if (id_enabled == IntPtr.Zero)
				id_enabled = JNIEnv.GetMethodID (class_ref, "enabled", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_enabled);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "enabled", "()Z"));
			} finally {
			}
		}

		static Delegate cb_id;
#pragma warning disable 0169
		static Delegate GetIdHandler ()
		{
			if (cb_id == null)
				cb_id = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Id);
			return cb_id;
		}

		static IntPtr n_Id (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.MediaStreamTrack __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaStreamTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Id ());
		}
#pragma warning restore 0169

		static IntPtr id_id;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='MediaStreamTrack']/method[@name='id' and count(parameter)=0]"
		[Register ("id", "()Ljava/lang/String;", "GetIdHandler")]
		public virtual unsafe string Id ()
		{
			if (id_id == IntPtr.Zero)
				id_id = JNIEnv.GetMethodID (class_ref, "id", "()Ljava/lang/String;");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_id), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "id", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_kind;
#pragma warning disable 0169
		static Delegate GetKindHandler ()
		{
			if (cb_kind == null)
				cb_kind = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Kind);
			return cb_kind;
		}

		static IntPtr n_Kind (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.MediaStreamTrack __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaStreamTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Kind ());
		}
#pragma warning restore 0169

		static IntPtr id_kind;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='MediaStreamTrack']/method[@name='kind' and count(parameter)=0]"
		[Register ("kind", "()Ljava/lang/String;", "GetKindHandler")]
		public virtual unsafe string Kind ()
		{
			if (id_kind == IntPtr.Zero)
				id_kind = JNIEnv.GetMethodID (class_ref, "kind", "()Ljava/lang/String;");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_kind), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "kind", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetEnabled_ZHandler ()
		{
			if (cb_setEnabled_Z == null)
				cb_setEnabled_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, bool>) n_SetEnabled_Z);
			return cb_setEnabled_Z;
		}

		static bool n_SetEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Org.Webrtc.MediaStreamTrack __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaStreamTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetEnabled (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setEnabled_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='MediaStreamTrack']/method[@name='setEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setEnabled", "(Z)Z", "GetSetEnabled_ZHandler")]
		public virtual unsafe bool SetEnabled (bool p0)
		{
			if (id_setEnabled_Z == IntPtr.Zero)
				id_setEnabled_Z = JNIEnv.GetMethodID (class_ref, "setEnabled", "(Z)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_setEnabled_Z, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEnabled", "(Z)Z"), __args);
			} finally {
			}
		}

		static Delegate cb_setState_Lorg_webrtc_MediaStreamTrack_State_;
#pragma warning disable 0169
		static Delegate GetSetState_Lorg_webrtc_MediaStreamTrack_State_Handler ()
		{
			if (cb_setState_Lorg_webrtc_MediaStreamTrack_State_ == null)
				cb_setState_Lorg_webrtc_MediaStreamTrack_State_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_SetState_Lorg_webrtc_MediaStreamTrack_State_);
			return cb_setState_Lorg_webrtc_MediaStreamTrack_State_;
		}

		static bool n_SetState_Lorg_webrtc_MediaStreamTrack_State_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Webrtc.MediaStreamTrack __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaStreamTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.MediaStreamTrack.State p0 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaStreamTrack.State> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SetState (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setState_Lorg_webrtc_MediaStreamTrack_State_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='MediaStreamTrack']/method[@name='setState' and count(parameter)=1 and parameter[1][@type='org.webrtc.MediaStreamTrack.State']]"
		[Register ("setState", "(Lorg/webrtc/MediaStreamTrack$State;)Z", "GetSetState_Lorg_webrtc_MediaStreamTrack_State_Handler")]
		public virtual unsafe bool SetState (global::Org.Webrtc.MediaStreamTrack.State p0)
		{
			if (id_setState_Lorg_webrtc_MediaStreamTrack_State_ == IntPtr.Zero)
				id_setState_Lorg_webrtc_MediaStreamTrack_State_ = JNIEnv.GetMethodID (class_ref, "setState", "(Lorg/webrtc/MediaStreamTrack$State;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_setState_Lorg_webrtc_MediaStreamTrack_State_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setState", "(Lorg/webrtc/MediaStreamTrack$State;)Z"), __args);
				return __ret;
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
			global::Org.Webrtc.MediaStreamTrack __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaStreamTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InvokeState ());
		}
#pragma warning restore 0169

		static IntPtr id_state;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='MediaStreamTrack']/method[@name='state' and count(parameter)=0]"
		[Register ("state", "()Lorg/webrtc/MediaStreamTrack$State;", "GetInvokeStateHandler")]
		public virtual unsafe global::Org.Webrtc.MediaStreamTrack.State InvokeState ()
		{
			if (id_state == IntPtr.Zero)
				id_state = JNIEnv.GetMethodID (class_ref, "state", "()Lorg/webrtc/MediaStreamTrack$State;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaStreamTrack.State> (JNIEnv.CallObjectMethod  (Handle, id_state), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaStreamTrack.State> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "state", "()Lorg/webrtc/MediaStreamTrack$State;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
