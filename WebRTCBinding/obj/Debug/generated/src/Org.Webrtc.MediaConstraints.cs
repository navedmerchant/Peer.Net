using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Webrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='MediaConstraints']"
	[global::Android.Runtime.Register ("org/webrtc/MediaConstraints", DoNotGenerateAcw=true)]
	public partial class MediaConstraints : global::Java.Lang.Object {


		static IntPtr mandatory_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='MediaConstraints']/field[@name='mandatory']"
		[Register ("mandatory")]
		public global::System.Collections.IList Mandatory {
			get {
				if (mandatory_jfieldId == IntPtr.Zero)
					mandatory_jfieldId = JNIEnv.GetFieldID (class_ref, "mandatory", "Ljava/util/List;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mandatory_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mandatory_jfieldId == IntPtr.Zero)
					mandatory_jfieldId = JNIEnv.GetFieldID (class_ref, "mandatory", "Ljava/util/List;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, mandatory_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr optional_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='MediaConstraints']/field[@name='optional']"
		[Register ("optional")]
		public global::System.Collections.IList Optional {
			get {
				if (optional_jfieldId == IntPtr.Zero)
					optional_jfieldId = JNIEnv.GetFieldID (class_ref, "optional", "Ljava/util/List;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, optional_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (optional_jfieldId == IntPtr.Zero)
					optional_jfieldId = JNIEnv.GetFieldID (class_ref, "optional", "Ljava/util/List;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, optional_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='MediaConstraints.KeyValuePair']"
		[global::Android.Runtime.Register ("org/webrtc/MediaConstraints$KeyValuePair", DoNotGenerateAcw=true)]
		public partial class KeyValuePair : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/webrtc/MediaConstraints$KeyValuePair", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (KeyValuePair); }
			}

			protected KeyValuePair (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='MediaConstraints.KeyValuePair']/constructor[@name='MediaConstraints.KeyValuePair' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
			public unsafe KeyValuePair (string p0, string p1)
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
					if (GetType () != typeof (KeyValuePair)) {
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

			static Delegate cb_getKey;
#pragma warning disable 0169
			static Delegate GetGetKeyHandler ()
			{
				if (cb_getKey == null)
					cb_getKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetKey);
				return cb_getKey;
			}

			static IntPtr n_GetKey (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Webrtc.MediaConstraints.KeyValuePair __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaConstraints.KeyValuePair> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Key);
			}
#pragma warning restore 0169

			static IntPtr id_getKey;
			public virtual unsafe string Key {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='MediaConstraints.KeyValuePair']/method[@name='getKey' and count(parameter)=0]"
				[Register ("getKey", "()Ljava/lang/String;", "GetGetKeyHandler")]
				get {
					if (id_getKey == IntPtr.Zero)
						id_getKey = JNIEnv.GetMethodID (class_ref, "getKey", "()Ljava/lang/String;");
					try {

						if (GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getKey), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getKey", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getValue;
#pragma warning disable 0169
			static Delegate GetGetValueHandler ()
			{
				if (cb_getValue == null)
					cb_getValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetValue);
				return cb_getValue;
			}

			static IntPtr n_GetValue (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Webrtc.MediaConstraints.KeyValuePair __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaConstraints.KeyValuePair> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Value);
			}
#pragma warning restore 0169

			static IntPtr id_getValue;
			public virtual unsafe string Value {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='MediaConstraints.KeyValuePair']/method[@name='getValue' and count(parameter)=0]"
				[Register ("getValue", "()Ljava/lang/String;", "GetGetValueHandler")]
				get {
					if (id_getValue == IntPtr.Zero)
						id_getValue = JNIEnv.GetMethodID (class_ref, "getValue", "()Ljava/lang/String;");
					try {

						if (GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getValue), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getValue", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/webrtc/MediaConstraints", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MediaConstraints); }
		}

		protected MediaConstraints (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='MediaConstraints']/constructor[@name='MediaConstraints' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MediaConstraints ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (MediaConstraints)) {
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

	}
}
