using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Webrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='Logging']"
	[global::Android.Runtime.Register ("org/webrtc/Logging", DoNotGenerateAcw=true)]
	public partial class Logging : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='Logging.Severity']"
		[global::Android.Runtime.Register ("org/webrtc/Logging$Severity", DoNotGenerateAcw=true)]
		public sealed partial class Severity : global::Java.Lang.Enum {


			static IntPtr LS_ERROR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='Logging.Severity']/field[@name='LS_ERROR']"
			[Register ("LS_ERROR")]
			public static global::Org.Webrtc.Logging.Severity LsError {
				get {
					if (LS_ERROR_jfieldId == IntPtr.Zero)
						LS_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LS_ERROR", "Lorg/webrtc/Logging$Severity;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LS_ERROR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.Logging.Severity> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr LS_INFO_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='Logging.Severity']/field[@name='LS_INFO']"
			[Register ("LS_INFO")]
			public static global::Org.Webrtc.Logging.Severity LsInfo {
				get {
					if (LS_INFO_jfieldId == IntPtr.Zero)
						LS_INFO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LS_INFO", "Lorg/webrtc/Logging$Severity;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LS_INFO_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.Logging.Severity> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr LS_SENSITIVE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='Logging.Severity']/field[@name='LS_SENSITIVE']"
			[Register ("LS_SENSITIVE")]
			public static global::Org.Webrtc.Logging.Severity LsSensitive {
				get {
					if (LS_SENSITIVE_jfieldId == IntPtr.Zero)
						LS_SENSITIVE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LS_SENSITIVE", "Lorg/webrtc/Logging$Severity;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LS_SENSITIVE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.Logging.Severity> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr LS_VERBOSE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='Logging.Severity']/field[@name='LS_VERBOSE']"
			[Register ("LS_VERBOSE")]
			public static global::Org.Webrtc.Logging.Severity LsVerbose {
				get {
					if (LS_VERBOSE_jfieldId == IntPtr.Zero)
						LS_VERBOSE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LS_VERBOSE", "Lorg/webrtc/Logging$Severity;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LS_VERBOSE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.Logging.Severity> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr LS_WARNING_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='Logging.Severity']/field[@name='LS_WARNING']"
			[Register ("LS_WARNING")]
			public static global::Org.Webrtc.Logging.Severity LsWarning {
				get {
					if (LS_WARNING_jfieldId == IntPtr.Zero)
						LS_WARNING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LS_WARNING", "Lorg/webrtc/Logging$Severity;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LS_WARNING_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.Logging.Severity> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/webrtc/Logging$Severity", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Severity); }
			}

			internal Severity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='Logging.Severity']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/webrtc/Logging$Severity;", "")]
			public static unsafe global::Org.Webrtc.Logging.Severity ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lorg/webrtc/Logging$Severity;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Org.Webrtc.Logging.Severity __ret = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Logging.Severity> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='Logging.Severity']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/webrtc/Logging$Severity;", "")]
			public static unsafe global::Org.Webrtc.Logging.Severity[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lorg/webrtc/Logging$Severity;");
				try {
					return (global::Org.Webrtc.Logging.Severity[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Webrtc.Logging.Severity));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='Logging.TraceLevel']"
		[global::Android.Runtime.Register ("org/webrtc/Logging$TraceLevel", DoNotGenerateAcw=true)]
		public sealed partial class TraceLevel : global::Java.Lang.Enum {


			static IntPtr TRACE_ALL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='Logging.TraceLevel']/field[@name='TRACE_ALL']"
			[Register ("TRACE_ALL")]
			public static global::Org.Webrtc.Logging.TraceLevel TraceAll {
				get {
					if (TRACE_ALL_jfieldId == IntPtr.Zero)
						TRACE_ALL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TRACE_ALL", "Lorg/webrtc/Logging$TraceLevel;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TRACE_ALL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.Logging.TraceLevel> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr TRACE_APICALL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='Logging.TraceLevel']/field[@name='TRACE_APICALL']"
			[Register ("TRACE_APICALL")]
			public static global::Org.Webrtc.Logging.TraceLevel TraceApicall {
				get {
					if (TRACE_APICALL_jfieldId == IntPtr.Zero)
						TRACE_APICALL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TRACE_APICALL", "Lorg/webrtc/Logging$TraceLevel;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TRACE_APICALL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.Logging.TraceLevel> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr TRACE_CRITICAL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='Logging.TraceLevel']/field[@name='TRACE_CRITICAL']"
			[Register ("TRACE_CRITICAL")]
			public static global::Org.Webrtc.Logging.TraceLevel TraceCritical {
				get {
					if (TRACE_CRITICAL_jfieldId == IntPtr.Zero)
						TRACE_CRITICAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TRACE_CRITICAL", "Lorg/webrtc/Logging$TraceLevel;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TRACE_CRITICAL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.Logging.TraceLevel> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr TRACE_DEBUG_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='Logging.TraceLevel']/field[@name='TRACE_DEBUG']"
			[Register ("TRACE_DEBUG")]
			public static global::Org.Webrtc.Logging.TraceLevel TraceDebug {
				get {
					if (TRACE_DEBUG_jfieldId == IntPtr.Zero)
						TRACE_DEBUG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TRACE_DEBUG", "Lorg/webrtc/Logging$TraceLevel;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TRACE_DEBUG_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.Logging.TraceLevel> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr TRACE_DEFAULT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='Logging.TraceLevel']/field[@name='TRACE_DEFAULT']"
			[Register ("TRACE_DEFAULT")]
			public static global::Org.Webrtc.Logging.TraceLevel TraceDefault {
				get {
					if (TRACE_DEFAULT_jfieldId == IntPtr.Zero)
						TRACE_DEFAULT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TRACE_DEFAULT", "Lorg/webrtc/Logging$TraceLevel;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TRACE_DEFAULT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.Logging.TraceLevel> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr TRACE_ERROR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='Logging.TraceLevel']/field[@name='TRACE_ERROR']"
			[Register ("TRACE_ERROR")]
			public static global::Org.Webrtc.Logging.TraceLevel TraceError {
				get {
					if (TRACE_ERROR_jfieldId == IntPtr.Zero)
						TRACE_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TRACE_ERROR", "Lorg/webrtc/Logging$TraceLevel;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TRACE_ERROR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.Logging.TraceLevel> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr TRACE_INFO_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='Logging.TraceLevel']/field[@name='TRACE_INFO']"
			[Register ("TRACE_INFO")]
			public static global::Org.Webrtc.Logging.TraceLevel TraceInfo {
				get {
					if (TRACE_INFO_jfieldId == IntPtr.Zero)
						TRACE_INFO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TRACE_INFO", "Lorg/webrtc/Logging$TraceLevel;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TRACE_INFO_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.Logging.TraceLevel> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr TRACE_MEMORY_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='Logging.TraceLevel']/field[@name='TRACE_MEMORY']"
			[Register ("TRACE_MEMORY")]
			public static global::Org.Webrtc.Logging.TraceLevel TraceMemory {
				get {
					if (TRACE_MEMORY_jfieldId == IntPtr.Zero)
						TRACE_MEMORY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TRACE_MEMORY", "Lorg/webrtc/Logging$TraceLevel;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TRACE_MEMORY_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.Logging.TraceLevel> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr TRACE_MODULECALL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='Logging.TraceLevel']/field[@name='TRACE_MODULECALL']"
			[Register ("TRACE_MODULECALL")]
			public static global::Org.Webrtc.Logging.TraceLevel TraceModulecall {
				get {
					if (TRACE_MODULECALL_jfieldId == IntPtr.Zero)
						TRACE_MODULECALL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TRACE_MODULECALL", "Lorg/webrtc/Logging$TraceLevel;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TRACE_MODULECALL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.Logging.TraceLevel> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr TRACE_NONE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='Logging.TraceLevel']/field[@name='TRACE_NONE']"
			[Register ("TRACE_NONE")]
			public static global::Org.Webrtc.Logging.TraceLevel TraceNone {
				get {
					if (TRACE_NONE_jfieldId == IntPtr.Zero)
						TRACE_NONE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TRACE_NONE", "Lorg/webrtc/Logging$TraceLevel;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TRACE_NONE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.Logging.TraceLevel> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr TRACE_STATEINFO_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='Logging.TraceLevel']/field[@name='TRACE_STATEINFO']"
			[Register ("TRACE_STATEINFO")]
			public static global::Org.Webrtc.Logging.TraceLevel TraceStateinfo {
				get {
					if (TRACE_STATEINFO_jfieldId == IntPtr.Zero)
						TRACE_STATEINFO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TRACE_STATEINFO", "Lorg/webrtc/Logging$TraceLevel;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TRACE_STATEINFO_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.Logging.TraceLevel> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr TRACE_STREAM_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='Logging.TraceLevel']/field[@name='TRACE_STREAM']"
			[Register ("TRACE_STREAM")]
			public static global::Org.Webrtc.Logging.TraceLevel TraceStream {
				get {
					if (TRACE_STREAM_jfieldId == IntPtr.Zero)
						TRACE_STREAM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TRACE_STREAM", "Lorg/webrtc/Logging$TraceLevel;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TRACE_STREAM_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.Logging.TraceLevel> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr TRACE_TERSEINFO_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='Logging.TraceLevel']/field[@name='TRACE_TERSEINFO']"
			[Register ("TRACE_TERSEINFO")]
			public static global::Org.Webrtc.Logging.TraceLevel TraceTerseinfo {
				get {
					if (TRACE_TERSEINFO_jfieldId == IntPtr.Zero)
						TRACE_TERSEINFO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TRACE_TERSEINFO", "Lorg/webrtc/Logging$TraceLevel;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TRACE_TERSEINFO_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.Logging.TraceLevel> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr TRACE_TIMER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='Logging.TraceLevel']/field[@name='TRACE_TIMER']"
			[Register ("TRACE_TIMER")]
			public static global::Org.Webrtc.Logging.TraceLevel TraceTimer {
				get {
					if (TRACE_TIMER_jfieldId == IntPtr.Zero)
						TRACE_TIMER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TRACE_TIMER", "Lorg/webrtc/Logging$TraceLevel;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TRACE_TIMER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.Logging.TraceLevel> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr TRACE_WARNING_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='Logging.TraceLevel']/field[@name='TRACE_WARNING']"
			[Register ("TRACE_WARNING")]
			public static global::Org.Webrtc.Logging.TraceLevel TraceWarning {
				get {
					if (TRACE_WARNING_jfieldId == IntPtr.Zero)
						TRACE_WARNING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TRACE_WARNING", "Lorg/webrtc/Logging$TraceLevel;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TRACE_WARNING_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.Logging.TraceLevel> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr level_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='Logging.TraceLevel']/field[@name='level']"
			[Register ("level")]
			public int Level {
				get {
					if (level_jfieldId == IntPtr.Zero)
						level_jfieldId = JNIEnv.GetFieldID (class_ref, "level", "I");
					return JNIEnv.GetIntField (Handle, level_jfieldId);
				}
				set {
					if (level_jfieldId == IntPtr.Zero)
						level_jfieldId = JNIEnv.GetFieldID (class_ref, "level", "I");
					try {
						JNIEnv.SetField (Handle, level_jfieldId, value);
					} finally {
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/webrtc/Logging$TraceLevel", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (TraceLevel); }
			}

			internal TraceLevel (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='Logging.TraceLevel']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/webrtc/Logging$TraceLevel;", "")]
			public static unsafe global::Org.Webrtc.Logging.TraceLevel ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lorg/webrtc/Logging$TraceLevel;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Org.Webrtc.Logging.TraceLevel __ret = global::Java.Lang.Object.GetObject<global::Org.Webrtc.Logging.TraceLevel> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='Logging.TraceLevel']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/webrtc/Logging$TraceLevel;", "")]
			public static unsafe global::Org.Webrtc.Logging.TraceLevel[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lorg/webrtc/Logging$TraceLevel;");
				try {
					return (global::Org.Webrtc.Logging.TraceLevel[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Webrtc.Logging.TraceLevel));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/webrtc/Logging", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Logging); }
		}

		protected Logging (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='Logging']/constructor[@name='Logging' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Logging ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Logging)) {
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

		static IntPtr id_enableTracing_Ljava_lang_String_Ljava_util_EnumSet_Lorg_webrtc_Logging_Severity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='Logging']/method[@name='enableTracing' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.EnumSet&lt;org.webrtc.Logging.TraceLevel&gt;'] and parameter[3][@type='org.webrtc.Logging.Severity']]"
		[Register ("enableTracing", "(Ljava/lang/String;Ljava/util/EnumSet;Lorg/webrtc/Logging$Severity;)V", "")]
		public static unsafe void EnableTracing (string p0, global::Java.Util.EnumSet p1, global::Org.Webrtc.Logging.Severity p2)
		{
			if (id_enableTracing_Ljava_lang_String_Ljava_util_EnumSet_Lorg_webrtc_Logging_Severity_ == IntPtr.Zero)
				id_enableTracing_Ljava_lang_String_Ljava_util_EnumSet_Lorg_webrtc_Logging_Severity_ = JNIEnv.GetStaticMethodID (class_ref, "enableTracing", "(Ljava/lang/String;Ljava/util/EnumSet;Lorg/webrtc/Logging$Severity;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_enableTracing_Ljava_lang_String_Ljava_util_EnumSet_Lorg_webrtc_Logging_Severity_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
