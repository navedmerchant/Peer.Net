using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Webrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='StatsReport']"
	[global::Android.Runtime.Register ("org/webrtc/StatsReport", DoNotGenerateAcw=true)]
	public partial class StatsReport : global::Java.Lang.Object {


		static IntPtr id_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='StatsReport']/field[@name='id']"
		[Register ("id")]
		public string Id {
			get {
				if (id_jfieldId == IntPtr.Zero)
					id_jfieldId = JNIEnv.GetFieldID (class_ref, "id", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, id_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_jfieldId == IntPtr.Zero)
					id_jfieldId = JNIEnv.GetFieldID (class_ref, "id", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, id_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr timestamp_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='StatsReport']/field[@name='timestamp']"
		[Register ("timestamp")]
		public double Timestamp {
			get {
				if (timestamp_jfieldId == IntPtr.Zero)
					timestamp_jfieldId = JNIEnv.GetFieldID (class_ref, "timestamp", "D");
				return JNIEnv.GetDoubleField (Handle, timestamp_jfieldId);
			}
			set {
				if (timestamp_jfieldId == IntPtr.Zero)
					timestamp_jfieldId = JNIEnv.GetFieldID (class_ref, "timestamp", "D");
				try {
					JNIEnv.SetField (Handle, timestamp_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr type_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='StatsReport']/field[@name='type']"
		[Register ("type")]
		public string Type {
			get {
				if (type_jfieldId == IntPtr.Zero)
					type_jfieldId = JNIEnv.GetFieldID (class_ref, "type", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, type_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (type_jfieldId == IntPtr.Zero)
					type_jfieldId = JNIEnv.GetFieldID (class_ref, "type", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, type_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr values_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='StatsReport']/field[@name='values']"
		[Register ("values")]
		public IList<Org.Webrtc.StatsReport.Value> Values {
			get {
				if (values_jfieldId == IntPtr.Zero)
					values_jfieldId = JNIEnv.GetFieldID (class_ref, "values", "[Lorg/webrtc/StatsReport$Value;");
				return JavaArray<global::Org.Webrtc.StatsReport.Value>.FromJniHandle (JNIEnv.GetObjectField (Handle, values_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (values_jfieldId == IntPtr.Zero)
					values_jfieldId = JNIEnv.GetFieldID (class_ref, "values", "[Lorg/webrtc/StatsReport$Value;");
				IntPtr native_value = JavaArray<global::Org.Webrtc.StatsReport.Value>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, values_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='StatsReport.Value']"
		[global::Android.Runtime.Register ("org/webrtc/StatsReport$Value", DoNotGenerateAcw=true)]
		public partial class Value : global::Java.Lang.Object {


			static IntPtr name_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='StatsReport.Value']/field[@name='name']"
			[Register ("name")]
			public string Name {
				get {
					if (name_jfieldId == IntPtr.Zero)
						name_jfieldId = JNIEnv.GetFieldID (class_ref, "name", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, name_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (name_jfieldId == IntPtr.Zero)
						name_jfieldId = JNIEnv.GetFieldID (class_ref, "name", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (Handle, name_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr value_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='StatsReport.Value']/field[@name='value']"
			[Register ("value")]
			public string Value {
				get {
					if (value_jfieldId == IntPtr.Zero)
						value_jfieldId = JNIEnv.GetFieldID (class_ref, "value", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, value_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (value_jfieldId == IntPtr.Zero)
						value_jfieldId = JNIEnv.GetFieldID (class_ref, "value", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (Handle, value_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/webrtc/StatsReport$Value", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Value); }
			}

			protected Value (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='StatsReport.Value']/constructor[@name='StatsReport.Value' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
			public unsafe Value (string p0, string p1)
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
					if (GetType () != typeof (Value)) {
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

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/webrtc/StatsReport", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StatsReport); }
		}

		protected StatsReport (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_DarrayLorg_webrtc_StatsReport_Value_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='StatsReport']/constructor[@name='StatsReport' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='double'] and parameter[4][@type='org.webrtc.StatsReport.Value[]']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;D[Lorg/webrtc/StatsReport$Value;)V", "")]
		public unsafe StatsReport (string p0, string p1, double p2, global::Org.Webrtc.StatsReport.Value[] p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				if (GetType () != typeof (StatsReport)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/lang/String;D[Lorg/webrtc/StatsReport$Value;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Ljava/lang/String;D[Lorg/webrtc/StatsReport$Value;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_DarrayLorg_webrtc_StatsReport_Value_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_DarrayLorg_webrtc_StatsReport_Value_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;D[Lorg/webrtc/StatsReport$Value;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_DarrayLorg_webrtc_StatsReport_Value_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_DarrayLorg_webrtc_StatsReport_Value_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
			}
		}

	}
}
