using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Webrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='SessionDescription']"
	[global::Android.Runtime.Register ("org/webrtc/SessionDescription", DoNotGenerateAcw=true)]
	public partial class SessionDescription : global::Java.Lang.Object {


		static IntPtr description_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='SessionDescription']/field[@name='description']"
		[Register ("description")]
		public string Description {
			get {
				if (description_jfieldId == IntPtr.Zero)
					description_jfieldId = JNIEnv.GetFieldID (class_ref, "description", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, description_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (description_jfieldId == IntPtr.Zero)
					description_jfieldId = JNIEnv.GetFieldID (class_ref, "description", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, description_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='SessionDescription.Type']"
		[global::Android.Runtime.Register ("org/webrtc/SessionDescription$Type", DoNotGenerateAcw=true)]
		public sealed partial class Type : global::Java.Lang.Enum {


			static IntPtr ANSWER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='SessionDescription.Type']/field[@name='ANSWER']"
			[Register ("ANSWER")]
			public static global::Org.Webrtc.SessionDescription.Type Answer {
				get {
					if (ANSWER_jfieldId == IntPtr.Zero)
						ANSWER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ANSWER", "Lorg/webrtc/SessionDescription$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ANSWER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.SessionDescription.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr OFFER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='SessionDescription.Type']/field[@name='OFFER']"
			[Register ("OFFER")]
			public static global::Org.Webrtc.SessionDescription.Type Offer {
				get {
					if (OFFER_jfieldId == IntPtr.Zero)
						OFFER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OFFER", "Lorg/webrtc/SessionDescription$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OFFER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.SessionDescription.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr PRANSWER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='SessionDescription.Type']/field[@name='PRANSWER']"
			[Register ("PRANSWER")]
			public static global::Org.Webrtc.SessionDescription.Type Pranswer {
				get {
					if (PRANSWER_jfieldId == IntPtr.Zero)
						PRANSWER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PRANSWER", "Lorg/webrtc/SessionDescription$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PRANSWER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.SessionDescription.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/webrtc/SessionDescription$Type", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Type); }
			}

			internal Type (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_canonicalForm;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='SessionDescription.Type']/method[@name='canonicalForm' and count(parameter)=0]"
			[Register ("canonicalForm", "()Ljava/lang/String;", "")]
			public unsafe string CanonicalForm ()
			{
				if (id_canonicalForm == IntPtr.Zero)
					id_canonicalForm = JNIEnv.GetMethodID (class_ref, "canonicalForm", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_canonicalForm), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_fromCanonicalForm_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='SessionDescription.Type']/method[@name='fromCanonicalForm' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("fromCanonicalForm", "(Ljava/lang/String;)Lorg/webrtc/SessionDescription$Type;", "")]
			public static unsafe global::Org.Webrtc.SessionDescription.Type FromCanonicalForm (string p0)
			{
				if (id_fromCanonicalForm_Ljava_lang_String_ == IntPtr.Zero)
					id_fromCanonicalForm_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "fromCanonicalForm", "(Ljava/lang/String;)Lorg/webrtc/SessionDescription$Type;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Org.Webrtc.SessionDescription.Type __ret = global::Java.Lang.Object.GetObject<global::Org.Webrtc.SessionDescription.Type> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromCanonicalForm_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='SessionDescription.Type']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/webrtc/SessionDescription$Type;", "")]
			public static unsafe global::Org.Webrtc.SessionDescription.Type ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lorg/webrtc/SessionDescription$Type;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Org.Webrtc.SessionDescription.Type __ret = global::Java.Lang.Object.GetObject<global::Org.Webrtc.SessionDescription.Type> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='SessionDescription.Type']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/webrtc/SessionDescription$Type;", "")]
			public static unsafe global::Org.Webrtc.SessionDescription.Type[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lorg/webrtc/SessionDescription$Type;");
				try {
					return (global::Org.Webrtc.SessionDescription.Type[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Webrtc.SessionDescription.Type));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/webrtc/SessionDescription", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SessionDescription); }
		}

		protected SessionDescription (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_webrtc_SessionDescription_Type_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='SessionDescription']/constructor[@name='SessionDescription' and count(parameter)=2 and parameter[1][@type='org.webrtc.SessionDescription.Type'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Lorg/webrtc/SessionDescription$Type;Ljava/lang/String;)V", "")]
		public unsafe SessionDescription (global::Org.Webrtc.SessionDescription.Type p0, string p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				if (GetType () != typeof (SessionDescription)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/webrtc/SessionDescription$Type;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/webrtc/SessionDescription$Type;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Lorg_webrtc_SessionDescription_Type_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Lorg_webrtc_SessionDescription_Type_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/webrtc/SessionDescription$Type;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_webrtc_SessionDescription_Type_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_webrtc_SessionDescription_Type_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
