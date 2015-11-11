using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Webrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection']"
	[global::Android.Runtime.Register ("org/webrtc/PeerConnection", DoNotGenerateAcw=true)]
	public partial class PeerConnection : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.BundlePolicy']"
		[global::Android.Runtime.Register ("org/webrtc/PeerConnection$BundlePolicy", DoNotGenerateAcw=true)]
		public sealed partial class BundlePolicy : global::Java.Lang.Enum {


			static IntPtr BALANCED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.BundlePolicy']/field[@name='BALANCED']"
			[Register ("BALANCED")]
			public static global::Org.Webrtc.PeerConnection.BundlePolicy Balanced {
				get {
					if (BALANCED_jfieldId == IntPtr.Zero)
						BALANCED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BALANCED", "Lorg/webrtc/PeerConnection$BundlePolicy;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BALANCED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.BundlePolicy> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr MAXBUNDLE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.BundlePolicy']/field[@name='MAXBUNDLE']"
			[Register ("MAXBUNDLE")]
			public static global::Org.Webrtc.PeerConnection.BundlePolicy Maxbundle {
				get {
					if (MAXBUNDLE_jfieldId == IntPtr.Zero)
						MAXBUNDLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MAXBUNDLE", "Lorg/webrtc/PeerConnection$BundlePolicy;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MAXBUNDLE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.BundlePolicy> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr MAXCOMPAT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.BundlePolicy']/field[@name='MAXCOMPAT']"
			[Register ("MAXCOMPAT")]
			public static global::Org.Webrtc.PeerConnection.BundlePolicy Maxcompat {
				get {
					if (MAXCOMPAT_jfieldId == IntPtr.Zero)
						MAXCOMPAT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MAXCOMPAT", "Lorg/webrtc/PeerConnection$BundlePolicy;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MAXCOMPAT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.BundlePolicy> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/webrtc/PeerConnection$BundlePolicy", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (BundlePolicy); }
			}

			internal BundlePolicy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.BundlePolicy']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/webrtc/PeerConnection$BundlePolicy;", "")]
			public static unsafe global::Org.Webrtc.PeerConnection.BundlePolicy ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lorg/webrtc/PeerConnection$BundlePolicy;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Org.Webrtc.PeerConnection.BundlePolicy __ret = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.BundlePolicy> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.BundlePolicy']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/webrtc/PeerConnection$BundlePolicy;", "")]
			public static unsafe global::Org.Webrtc.PeerConnection.BundlePolicy[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lorg/webrtc/PeerConnection$BundlePolicy;");
				try {
					return (global::Org.Webrtc.PeerConnection.BundlePolicy[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Webrtc.PeerConnection.BundlePolicy));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.IceConnectionState']"
		[global::Android.Runtime.Register ("org/webrtc/PeerConnection$IceConnectionState", DoNotGenerateAcw=true)]
		public sealed partial class IceConnectionState : global::Java.Lang.Enum {


			static IntPtr CHECKING_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.IceConnectionState']/field[@name='CHECKING']"
			[Register ("CHECKING")]
			public static global::Org.Webrtc.PeerConnection.IceConnectionState Checking {
				get {
					if (CHECKING_jfieldId == IntPtr.Zero)
						CHECKING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CHECKING", "Lorg/webrtc/PeerConnection$IceConnectionState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CHECKING_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.IceConnectionState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CLOSED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.IceConnectionState']/field[@name='CLOSED']"
			[Register ("CLOSED")]
			public static global::Org.Webrtc.PeerConnection.IceConnectionState Closed {
				get {
					if (CLOSED_jfieldId == IntPtr.Zero)
						CLOSED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CLOSED", "Lorg/webrtc/PeerConnection$IceConnectionState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CLOSED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.IceConnectionState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr COMPLETED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.IceConnectionState']/field[@name='COMPLETED']"
			[Register ("COMPLETED")]
			public static global::Org.Webrtc.PeerConnection.IceConnectionState Completed {
				get {
					if (COMPLETED_jfieldId == IntPtr.Zero)
						COMPLETED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "COMPLETED", "Lorg/webrtc/PeerConnection$IceConnectionState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, COMPLETED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.IceConnectionState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CONNECTED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.IceConnectionState']/field[@name='CONNECTED']"
			[Register ("CONNECTED")]
			public static global::Org.Webrtc.PeerConnection.IceConnectionState Connected {
				get {
					if (CONNECTED_jfieldId == IntPtr.Zero)
						CONNECTED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONNECTED", "Lorg/webrtc/PeerConnection$IceConnectionState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CONNECTED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.IceConnectionState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr DISCONNECTED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.IceConnectionState']/field[@name='DISCONNECTED']"
			[Register ("DISCONNECTED")]
			public static global::Org.Webrtc.PeerConnection.IceConnectionState Disconnected {
				get {
					if (DISCONNECTED_jfieldId == IntPtr.Zero)
						DISCONNECTED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DISCONNECTED", "Lorg/webrtc/PeerConnection$IceConnectionState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DISCONNECTED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.IceConnectionState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr FAILED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.IceConnectionState']/field[@name='FAILED']"
			[Register ("FAILED")]
			public static global::Org.Webrtc.PeerConnection.IceConnectionState Failed {
				get {
					if (FAILED_jfieldId == IntPtr.Zero)
						FAILED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FAILED", "Lorg/webrtc/PeerConnection$IceConnectionState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FAILED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.IceConnectionState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr NEW_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.IceConnectionState']/field[@name='NEW']"
			[Register ("NEW")]
			public static global::Org.Webrtc.PeerConnection.IceConnectionState New {
				get {
					if (NEW_jfieldId == IntPtr.Zero)
						NEW_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NEW", "Lorg/webrtc/PeerConnection$IceConnectionState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NEW_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.IceConnectionState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/webrtc/PeerConnection$IceConnectionState", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IceConnectionState); }
			}

			internal IceConnectionState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.IceConnectionState']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/webrtc/PeerConnection$IceConnectionState;", "")]
			public static unsafe global::Org.Webrtc.PeerConnection.IceConnectionState ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lorg/webrtc/PeerConnection$IceConnectionState;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Org.Webrtc.PeerConnection.IceConnectionState __ret = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.IceConnectionState> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.IceConnectionState']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/webrtc/PeerConnection$IceConnectionState;", "")]
			public static unsafe global::Org.Webrtc.PeerConnection.IceConnectionState[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lorg/webrtc/PeerConnection$IceConnectionState;");
				try {
					return (global::Org.Webrtc.PeerConnection.IceConnectionState[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Webrtc.PeerConnection.IceConnectionState));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.IceGatheringState']"
		[global::Android.Runtime.Register ("org/webrtc/PeerConnection$IceGatheringState", DoNotGenerateAcw=true)]
		public sealed partial class IceGatheringState : global::Java.Lang.Enum {


			static IntPtr COMPLETE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.IceGatheringState']/field[@name='COMPLETE']"
			[Register ("COMPLETE")]
			public static global::Org.Webrtc.PeerConnection.IceGatheringState Complete {
				get {
					if (COMPLETE_jfieldId == IntPtr.Zero)
						COMPLETE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "COMPLETE", "Lorg/webrtc/PeerConnection$IceGatheringState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, COMPLETE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.IceGatheringState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr GATHERING_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.IceGatheringState']/field[@name='GATHERING']"
			[Register ("GATHERING")]
			public static global::Org.Webrtc.PeerConnection.IceGatheringState Gathering {
				get {
					if (GATHERING_jfieldId == IntPtr.Zero)
						GATHERING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GATHERING", "Lorg/webrtc/PeerConnection$IceGatheringState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, GATHERING_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.IceGatheringState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr NEW_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.IceGatheringState']/field[@name='NEW']"
			[Register ("NEW")]
			public static global::Org.Webrtc.PeerConnection.IceGatheringState New {
				get {
					if (NEW_jfieldId == IntPtr.Zero)
						NEW_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NEW", "Lorg/webrtc/PeerConnection$IceGatheringState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NEW_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.IceGatheringState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/webrtc/PeerConnection$IceGatheringState", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IceGatheringState); }
			}

			internal IceGatheringState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.IceGatheringState']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/webrtc/PeerConnection$IceGatheringState;", "")]
			public static unsafe global::Org.Webrtc.PeerConnection.IceGatheringState ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lorg/webrtc/PeerConnection$IceGatheringState;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Org.Webrtc.PeerConnection.IceGatheringState __ret = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.IceGatheringState> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.IceGatheringState']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/webrtc/PeerConnection$IceGatheringState;", "")]
			public static unsafe global::Org.Webrtc.PeerConnection.IceGatheringState[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lorg/webrtc/PeerConnection$IceGatheringState;");
				try {
					return (global::Org.Webrtc.PeerConnection.IceGatheringState[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Webrtc.PeerConnection.IceGatheringState));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.IceServer']"
		[global::Android.Runtime.Register ("org/webrtc/PeerConnection$IceServer", DoNotGenerateAcw=true)]
		public partial class IceServer : global::Java.Lang.Object {


			static IntPtr password_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.IceServer']/field[@name='password']"
			[Register ("password")]
			public string Password {
				get {
					if (password_jfieldId == IntPtr.Zero)
						password_jfieldId = JNIEnv.GetFieldID (class_ref, "password", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, password_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (password_jfieldId == IntPtr.Zero)
						password_jfieldId = JNIEnv.GetFieldID (class_ref, "password", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (Handle, password_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr uri_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.IceServer']/field[@name='uri']"
			[Register ("uri")]
			public string Uri {
				get {
					if (uri_jfieldId == IntPtr.Zero)
						uri_jfieldId = JNIEnv.GetFieldID (class_ref, "uri", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, uri_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (uri_jfieldId == IntPtr.Zero)
						uri_jfieldId = JNIEnv.GetFieldID (class_ref, "uri", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (Handle, uri_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr username_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.IceServer']/field[@name='username']"
			[Register ("username")]
			public string Username {
				get {
					if (username_jfieldId == IntPtr.Zero)
						username_jfieldId = JNIEnv.GetFieldID (class_ref, "username", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, username_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (username_jfieldId == IntPtr.Zero)
						username_jfieldId = JNIEnv.GetFieldID (class_ref, "username", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (Handle, username_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/webrtc/PeerConnection$IceServer", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IceServer); }
			}

			protected IceServer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_lang_String_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.IceServer']/constructor[@name='PeerConnection.IceServer' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register (".ctor", "(Ljava/lang/String;)V", "")]
			public unsafe IceServer (string p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					if (GetType () != typeof (IceServer)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;)V", __args);
						return;
					}

					if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
						id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.IceServer']/constructor[@name='PeerConnection.IceServer' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
			[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
			public unsafe IceServer (string p0, string p1, string p2)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = JNIEnv.NewString (p0);
				IntPtr native_p1 = JNIEnv.NewString (p1);
				IntPtr native_p2 = JNIEnv.NewString (p2);
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (native_p1);
					__args [2] = new JValue (native_p2);
					if (GetType () != typeof (IceServer)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", __args);
						return;
					}

					if (id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
						id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					JNIEnv.DeleteLocalRef (native_p1);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.IceTransportsType']"
		[global::Android.Runtime.Register ("org/webrtc/PeerConnection$IceTransportsType", DoNotGenerateAcw=true)]
		public sealed partial class IceTransportsType : global::Java.Lang.Enum {


			static IntPtr ALL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.IceTransportsType']/field[@name='ALL']"
			[Register ("ALL")]
			public static global::Org.Webrtc.PeerConnection.IceTransportsType All {
				get {
					if (ALL_jfieldId == IntPtr.Zero)
						ALL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ALL", "Lorg/webrtc/PeerConnection$IceTransportsType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ALL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.IceTransportsType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr NOHOST_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.IceTransportsType']/field[@name='NOHOST']"
			[Register ("NOHOST")]
			public static global::Org.Webrtc.PeerConnection.IceTransportsType Nohost {
				get {
					if (NOHOST_jfieldId == IntPtr.Zero)
						NOHOST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NOHOST", "Lorg/webrtc/PeerConnection$IceTransportsType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NOHOST_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.IceTransportsType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr NONE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.IceTransportsType']/field[@name='NONE']"
			[Register ("NONE")]
			public static global::Org.Webrtc.PeerConnection.IceTransportsType None {
				get {
					if (NONE_jfieldId == IntPtr.Zero)
						NONE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NONE", "Lorg/webrtc/PeerConnection$IceTransportsType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NONE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.IceTransportsType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr RELAY_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.IceTransportsType']/field[@name='RELAY']"
			[Register ("RELAY")]
			public static global::Org.Webrtc.PeerConnection.IceTransportsType Relay {
				get {
					if (RELAY_jfieldId == IntPtr.Zero)
						RELAY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RELAY", "Lorg/webrtc/PeerConnection$IceTransportsType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RELAY_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.IceTransportsType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/webrtc/PeerConnection$IceTransportsType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IceTransportsType); }
			}

			internal IceTransportsType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.IceTransportsType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/webrtc/PeerConnection$IceTransportsType;", "")]
			public static unsafe global::Org.Webrtc.PeerConnection.IceTransportsType ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lorg/webrtc/PeerConnection$IceTransportsType;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Org.Webrtc.PeerConnection.IceTransportsType __ret = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.IceTransportsType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.IceTransportsType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/webrtc/PeerConnection$IceTransportsType;", "")]
			public static unsafe global::Org.Webrtc.PeerConnection.IceTransportsType[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lorg/webrtc/PeerConnection$IceTransportsType;");
				try {
					return (global::Org.Webrtc.PeerConnection.IceTransportsType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Webrtc.PeerConnection.IceTransportsType));
				} finally {
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='org.webrtc']/interface[@name='PeerConnection.Observer']"
		[Register ("org/webrtc/PeerConnection$Observer", "", "Org.Webrtc.PeerConnection/IObserverInvoker")]
		public partial interface IObserver : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='PeerConnection.Observer']/method[@name='onAddStream' and count(parameter)=1 and parameter[1][@type='org.webrtc.MediaStream']]"
			[Register ("onAddStream", "(Lorg/webrtc/MediaStream;)V", "GetOnAddStream_Lorg_webrtc_MediaStream_Handler:Org.Webrtc.PeerConnection/IObserverInvoker, WebRTCBinding")]
			void OnAddStream (global::Org.Webrtc.MediaStream p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='PeerConnection.Observer']/method[@name='onDataChannel' and count(parameter)=1 and parameter[1][@type='org.webrtc.DataChannel']]"
			[Register ("onDataChannel", "(Lorg/webrtc/DataChannel;)V", "GetOnDataChannel_Lorg_webrtc_DataChannel_Handler:Org.Webrtc.PeerConnection/IObserverInvoker, WebRTCBinding")]
			void OnDataChannel (global::Org.Webrtc.DataChannel p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='PeerConnection.Observer']/method[@name='onIceCandidate' and count(parameter)=1 and parameter[1][@type='org.webrtc.IceCandidate']]"
			[Register ("onIceCandidate", "(Lorg/webrtc/IceCandidate;)V", "GetOnIceCandidate_Lorg_webrtc_IceCandidate_Handler:Org.Webrtc.PeerConnection/IObserverInvoker, WebRTCBinding")]
			void OnIceCandidate (global::Org.Webrtc.IceCandidate p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='PeerConnection.Observer']/method[@name='onIceConnectionChange' and count(parameter)=1 and parameter[1][@type='org.webrtc.PeerConnection.IceConnectionState']]"
			[Register ("onIceConnectionChange", "(Lorg/webrtc/PeerConnection$IceConnectionState;)V", "GetOnIceConnectionChange_Lorg_webrtc_PeerConnection_IceConnectionState_Handler:Org.Webrtc.PeerConnection/IObserverInvoker, WebRTCBinding")]
			void OnIceConnectionChange (global::Org.Webrtc.PeerConnection.IceConnectionState p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='PeerConnection.Observer']/method[@name='onIceConnectionReceivingChange' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("onIceConnectionReceivingChange", "(Z)V", "GetOnIceConnectionReceivingChange_ZHandler:Org.Webrtc.PeerConnection/IObserverInvoker, WebRTCBinding")]
			void OnIceConnectionReceivingChange (bool p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='PeerConnection.Observer']/method[@name='onIceGatheringChange' and count(parameter)=1 and parameter[1][@type='org.webrtc.PeerConnection.IceGatheringState']]"
			[Register ("onIceGatheringChange", "(Lorg/webrtc/PeerConnection$IceGatheringState;)V", "GetOnIceGatheringChange_Lorg_webrtc_PeerConnection_IceGatheringState_Handler:Org.Webrtc.PeerConnection/IObserverInvoker, WebRTCBinding")]
			void OnIceGatheringChange (global::Org.Webrtc.PeerConnection.IceGatheringState p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='PeerConnection.Observer']/method[@name='onRemoveStream' and count(parameter)=1 and parameter[1][@type='org.webrtc.MediaStream']]"
			[Register ("onRemoveStream", "(Lorg/webrtc/MediaStream;)V", "GetOnRemoveStream_Lorg_webrtc_MediaStream_Handler:Org.Webrtc.PeerConnection/IObserverInvoker, WebRTCBinding")]
			void OnRemoveStream (global::Org.Webrtc.MediaStream p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='PeerConnection.Observer']/method[@name='onRenegotiationNeeded' and count(parameter)=0]"
			[Register ("onRenegotiationNeeded", "()V", "GetOnRenegotiationNeededHandler:Org.Webrtc.PeerConnection/IObserverInvoker, WebRTCBinding")]
			void OnRenegotiationNeeded ();

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='PeerConnection.Observer']/method[@name='onSignalingChange' and count(parameter)=1 and parameter[1][@type='org.webrtc.PeerConnection.SignalingState']]"
			[Register ("onSignalingChange", "(Lorg/webrtc/PeerConnection$SignalingState;)V", "GetOnSignalingChange_Lorg_webrtc_PeerConnection_SignalingState_Handler:Org.Webrtc.PeerConnection/IObserverInvoker, WebRTCBinding")]
			void OnSignalingChange (global::Org.Webrtc.PeerConnection.SignalingState p0);

		}

		[global::Android.Runtime.Register ("org/webrtc/PeerConnection$Observer", DoNotGenerateAcw=true)]
		internal class IObserverInvoker : global::Java.Lang.Object, IObserver {

			static IntPtr java_class_ref = JNIEnv.FindClass ("org/webrtc/PeerConnection$Observer");
			IntPtr class_ref;

			public static IObserver GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IObserver> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "org.webrtc.PeerConnection.Observer"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IObserverInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IObserverInvoker); }
			}

			static Delegate cb_onAddStream_Lorg_webrtc_MediaStream_;
#pragma warning disable 0169
			static Delegate GetOnAddStream_Lorg_webrtc_MediaStream_Handler ()
			{
				if (cb_onAddStream_Lorg_webrtc_MediaStream_ == null)
					cb_onAddStream_Lorg_webrtc_MediaStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnAddStream_Lorg_webrtc_MediaStream_);
				return cb_onAddStream_Lorg_webrtc_MediaStream_;
			}

			static void n_OnAddStream_Lorg_webrtc_MediaStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Org.Webrtc.PeerConnection.IObserver __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.IObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Webrtc.MediaStream p0 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaStream> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnAddStream (p0);
			}
#pragma warning restore 0169

			IntPtr id_onAddStream_Lorg_webrtc_MediaStream_;
			public unsafe void OnAddStream (global::Org.Webrtc.MediaStream p0)
			{
				if (id_onAddStream_Lorg_webrtc_MediaStream_ == IntPtr.Zero)
					id_onAddStream_Lorg_webrtc_MediaStream_ = JNIEnv.GetMethodID (class_ref, "onAddStream", "(Lorg/webrtc/MediaStream;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (Handle, id_onAddStream_Lorg_webrtc_MediaStream_, __args);
			}

			static Delegate cb_onDataChannel_Lorg_webrtc_DataChannel_;
#pragma warning disable 0169
			static Delegate GetOnDataChannel_Lorg_webrtc_DataChannel_Handler ()
			{
				if (cb_onDataChannel_Lorg_webrtc_DataChannel_ == null)
					cb_onDataChannel_Lorg_webrtc_DataChannel_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDataChannel_Lorg_webrtc_DataChannel_);
				return cb_onDataChannel_Lorg_webrtc_DataChannel_;
			}

			static void n_OnDataChannel_Lorg_webrtc_DataChannel_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Org.Webrtc.PeerConnection.IObserver __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.IObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Webrtc.DataChannel p0 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.DataChannel> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnDataChannel (p0);
			}
#pragma warning restore 0169

			IntPtr id_onDataChannel_Lorg_webrtc_DataChannel_;
			public unsafe void OnDataChannel (global::Org.Webrtc.DataChannel p0)
			{
				if (id_onDataChannel_Lorg_webrtc_DataChannel_ == IntPtr.Zero)
					id_onDataChannel_Lorg_webrtc_DataChannel_ = JNIEnv.GetMethodID (class_ref, "onDataChannel", "(Lorg/webrtc/DataChannel;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (Handle, id_onDataChannel_Lorg_webrtc_DataChannel_, __args);
			}

			static Delegate cb_onIceCandidate_Lorg_webrtc_IceCandidate_;
#pragma warning disable 0169
			static Delegate GetOnIceCandidate_Lorg_webrtc_IceCandidate_Handler ()
			{
				if (cb_onIceCandidate_Lorg_webrtc_IceCandidate_ == null)
					cb_onIceCandidate_Lorg_webrtc_IceCandidate_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnIceCandidate_Lorg_webrtc_IceCandidate_);
				return cb_onIceCandidate_Lorg_webrtc_IceCandidate_;
			}

			static void n_OnIceCandidate_Lorg_webrtc_IceCandidate_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Org.Webrtc.PeerConnection.IObserver __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.IObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Webrtc.IceCandidate p0 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IceCandidate> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnIceCandidate (p0);
			}
#pragma warning restore 0169

			IntPtr id_onIceCandidate_Lorg_webrtc_IceCandidate_;
			public unsafe void OnIceCandidate (global::Org.Webrtc.IceCandidate p0)
			{
				if (id_onIceCandidate_Lorg_webrtc_IceCandidate_ == IntPtr.Zero)
					id_onIceCandidate_Lorg_webrtc_IceCandidate_ = JNIEnv.GetMethodID (class_ref, "onIceCandidate", "(Lorg/webrtc/IceCandidate;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (Handle, id_onIceCandidate_Lorg_webrtc_IceCandidate_, __args);
			}

			static Delegate cb_onIceConnectionChange_Lorg_webrtc_PeerConnection_IceConnectionState_;
#pragma warning disable 0169
			static Delegate GetOnIceConnectionChange_Lorg_webrtc_PeerConnection_IceConnectionState_Handler ()
			{
				if (cb_onIceConnectionChange_Lorg_webrtc_PeerConnection_IceConnectionState_ == null)
					cb_onIceConnectionChange_Lorg_webrtc_PeerConnection_IceConnectionState_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnIceConnectionChange_Lorg_webrtc_PeerConnection_IceConnectionState_);
				return cb_onIceConnectionChange_Lorg_webrtc_PeerConnection_IceConnectionState_;
			}

			static void n_OnIceConnectionChange_Lorg_webrtc_PeerConnection_IceConnectionState_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Org.Webrtc.PeerConnection.IObserver __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.IObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Webrtc.PeerConnection.IceConnectionState p0 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.IceConnectionState> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnIceConnectionChange (p0);
			}
#pragma warning restore 0169

			IntPtr id_onIceConnectionChange_Lorg_webrtc_PeerConnection_IceConnectionState_;
			public unsafe void OnIceConnectionChange (global::Org.Webrtc.PeerConnection.IceConnectionState p0)
			{
				if (id_onIceConnectionChange_Lorg_webrtc_PeerConnection_IceConnectionState_ == IntPtr.Zero)
					id_onIceConnectionChange_Lorg_webrtc_PeerConnection_IceConnectionState_ = JNIEnv.GetMethodID (class_ref, "onIceConnectionChange", "(Lorg/webrtc/PeerConnection$IceConnectionState;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (Handle, id_onIceConnectionChange_Lorg_webrtc_PeerConnection_IceConnectionState_, __args);
			}

			static Delegate cb_onIceConnectionReceivingChange_Z;
#pragma warning disable 0169
			static Delegate GetOnIceConnectionReceivingChange_ZHandler ()
			{
				if (cb_onIceConnectionReceivingChange_Z == null)
					cb_onIceConnectionReceivingChange_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_OnIceConnectionReceivingChange_Z);
				return cb_onIceConnectionReceivingChange_Z;
			}

			static void n_OnIceConnectionReceivingChange_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Org.Webrtc.PeerConnection.IObserver __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.IObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnIceConnectionReceivingChange (p0);
			}
#pragma warning restore 0169

			IntPtr id_onIceConnectionReceivingChange_Z;
			public unsafe void OnIceConnectionReceivingChange (bool p0)
			{
				if (id_onIceConnectionReceivingChange_Z == IntPtr.Zero)
					id_onIceConnectionReceivingChange_Z = JNIEnv.GetMethodID (class_ref, "onIceConnectionReceivingChange", "(Z)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (Handle, id_onIceConnectionReceivingChange_Z, __args);
			}

			static Delegate cb_onIceGatheringChange_Lorg_webrtc_PeerConnection_IceGatheringState_;
#pragma warning disable 0169
			static Delegate GetOnIceGatheringChange_Lorg_webrtc_PeerConnection_IceGatheringState_Handler ()
			{
				if (cb_onIceGatheringChange_Lorg_webrtc_PeerConnection_IceGatheringState_ == null)
					cb_onIceGatheringChange_Lorg_webrtc_PeerConnection_IceGatheringState_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnIceGatheringChange_Lorg_webrtc_PeerConnection_IceGatheringState_);
				return cb_onIceGatheringChange_Lorg_webrtc_PeerConnection_IceGatheringState_;
			}

			static void n_OnIceGatheringChange_Lorg_webrtc_PeerConnection_IceGatheringState_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Org.Webrtc.PeerConnection.IObserver __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.IObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Webrtc.PeerConnection.IceGatheringState p0 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.IceGatheringState> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnIceGatheringChange (p0);
			}
#pragma warning restore 0169

			IntPtr id_onIceGatheringChange_Lorg_webrtc_PeerConnection_IceGatheringState_;
			public unsafe void OnIceGatheringChange (global::Org.Webrtc.PeerConnection.IceGatheringState p0)
			{
				if (id_onIceGatheringChange_Lorg_webrtc_PeerConnection_IceGatheringState_ == IntPtr.Zero)
					id_onIceGatheringChange_Lorg_webrtc_PeerConnection_IceGatheringState_ = JNIEnv.GetMethodID (class_ref, "onIceGatheringChange", "(Lorg/webrtc/PeerConnection$IceGatheringState;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (Handle, id_onIceGatheringChange_Lorg_webrtc_PeerConnection_IceGatheringState_, __args);
			}

			static Delegate cb_onRemoveStream_Lorg_webrtc_MediaStream_;
#pragma warning disable 0169
			static Delegate GetOnRemoveStream_Lorg_webrtc_MediaStream_Handler ()
			{
				if (cb_onRemoveStream_Lorg_webrtc_MediaStream_ == null)
					cb_onRemoveStream_Lorg_webrtc_MediaStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnRemoveStream_Lorg_webrtc_MediaStream_);
				return cb_onRemoveStream_Lorg_webrtc_MediaStream_;
			}

			static void n_OnRemoveStream_Lorg_webrtc_MediaStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Org.Webrtc.PeerConnection.IObserver __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.IObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Webrtc.MediaStream p0 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaStream> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnRemoveStream (p0);
			}
#pragma warning restore 0169

			IntPtr id_onRemoveStream_Lorg_webrtc_MediaStream_;
			public unsafe void OnRemoveStream (global::Org.Webrtc.MediaStream p0)
			{
				if (id_onRemoveStream_Lorg_webrtc_MediaStream_ == IntPtr.Zero)
					id_onRemoveStream_Lorg_webrtc_MediaStream_ = JNIEnv.GetMethodID (class_ref, "onRemoveStream", "(Lorg/webrtc/MediaStream;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (Handle, id_onRemoveStream_Lorg_webrtc_MediaStream_, __args);
			}

			static Delegate cb_onRenegotiationNeeded;
#pragma warning disable 0169
			static Delegate GetOnRenegotiationNeededHandler ()
			{
				if (cb_onRenegotiationNeeded == null)
					cb_onRenegotiationNeeded = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnRenegotiationNeeded);
				return cb_onRenegotiationNeeded;
			}

			static void n_OnRenegotiationNeeded (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Webrtc.PeerConnection.IObserver __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.IObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnRenegotiationNeeded ();
			}
#pragma warning restore 0169

			IntPtr id_onRenegotiationNeeded;
			public unsafe void OnRenegotiationNeeded ()
			{
				if (id_onRenegotiationNeeded == IntPtr.Zero)
					id_onRenegotiationNeeded = JNIEnv.GetMethodID (class_ref, "onRenegotiationNeeded", "()V");
				JNIEnv.CallVoidMethod (Handle, id_onRenegotiationNeeded);
			}

			static Delegate cb_onSignalingChange_Lorg_webrtc_PeerConnection_SignalingState_;
#pragma warning disable 0169
			static Delegate GetOnSignalingChange_Lorg_webrtc_PeerConnection_SignalingState_Handler ()
			{
				if (cb_onSignalingChange_Lorg_webrtc_PeerConnection_SignalingState_ == null)
					cb_onSignalingChange_Lorg_webrtc_PeerConnection_SignalingState_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSignalingChange_Lorg_webrtc_PeerConnection_SignalingState_);
				return cb_onSignalingChange_Lorg_webrtc_PeerConnection_SignalingState_;
			}

			static void n_OnSignalingChange_Lorg_webrtc_PeerConnection_SignalingState_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Org.Webrtc.PeerConnection.IObserver __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.IObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Webrtc.PeerConnection.SignalingState p0 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.SignalingState> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnSignalingChange (p0);
			}
#pragma warning restore 0169

			IntPtr id_onSignalingChange_Lorg_webrtc_PeerConnection_SignalingState_;
			public unsafe void OnSignalingChange (global::Org.Webrtc.PeerConnection.SignalingState p0)
			{
				if (id_onSignalingChange_Lorg_webrtc_PeerConnection_SignalingState_ == IntPtr.Zero)
					id_onSignalingChange_Lorg_webrtc_PeerConnection_SignalingState_ = JNIEnv.GetMethodID (class_ref, "onSignalingChange", "(Lorg/webrtc/PeerConnection$SignalingState;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (Handle, id_onSignalingChange_Lorg_webrtc_PeerConnection_SignalingState_, __args);
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.RTCConfiguration']"
		[global::Android.Runtime.Register ("org/webrtc/PeerConnection$RTCConfiguration", DoNotGenerateAcw=true)]
		public partial class RTCConfiguration : global::Java.Lang.Object {


			static IntPtr audioJitterBufferFastAccelerate_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.RTCConfiguration']/field[@name='audioJitterBufferFastAccelerate']"
			[Register ("audioJitterBufferFastAccelerate")]
			public bool AudioJitterBufferFastAccelerate {
				get {
					if (audioJitterBufferFastAccelerate_jfieldId == IntPtr.Zero)
						audioJitterBufferFastAccelerate_jfieldId = JNIEnv.GetFieldID (class_ref, "audioJitterBufferFastAccelerate", "Z");
					return JNIEnv.GetBooleanField (Handle, audioJitterBufferFastAccelerate_jfieldId);
				}
				set {
					if (audioJitterBufferFastAccelerate_jfieldId == IntPtr.Zero)
						audioJitterBufferFastAccelerate_jfieldId = JNIEnv.GetFieldID (class_ref, "audioJitterBufferFastAccelerate", "Z");
					try {
						JNIEnv.SetField (Handle, audioJitterBufferFastAccelerate_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr audioJitterBufferMaxPackets_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.RTCConfiguration']/field[@name='audioJitterBufferMaxPackets']"
			[Register ("audioJitterBufferMaxPackets")]
			public int AudioJitterBufferMaxPackets {
				get {
					if (audioJitterBufferMaxPackets_jfieldId == IntPtr.Zero)
						audioJitterBufferMaxPackets_jfieldId = JNIEnv.GetFieldID (class_ref, "audioJitterBufferMaxPackets", "I");
					return JNIEnv.GetIntField (Handle, audioJitterBufferMaxPackets_jfieldId);
				}
				set {
					if (audioJitterBufferMaxPackets_jfieldId == IntPtr.Zero)
						audioJitterBufferMaxPackets_jfieldId = JNIEnv.GetFieldID (class_ref, "audioJitterBufferMaxPackets", "I");
					try {
						JNIEnv.SetField (Handle, audioJitterBufferMaxPackets_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr bundlePolicy_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.RTCConfiguration']/field[@name='bundlePolicy']"
			[Register ("bundlePolicy")]
			public global::Org.Webrtc.PeerConnection.BundlePolicy BundlePolicy {
				get {
					if (bundlePolicy_jfieldId == IntPtr.Zero)
						bundlePolicy_jfieldId = JNIEnv.GetFieldID (class_ref, "bundlePolicy", "Lorg/webrtc/PeerConnection$BundlePolicy;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, bundlePolicy_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.BundlePolicy> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (bundlePolicy_jfieldId == IntPtr.Zero)
						bundlePolicy_jfieldId = JNIEnv.GetFieldID (class_ref, "bundlePolicy", "Lorg/webrtc/PeerConnection$BundlePolicy;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (Handle, bundlePolicy_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr iceServers_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.RTCConfiguration']/field[@name='iceServers']"
			[Register ("iceServers")]
			public global::System.Collections.IList IceServers {
				get {
					if (iceServers_jfieldId == IntPtr.Zero)
						iceServers_jfieldId = JNIEnv.GetFieldID (class_ref, "iceServers", "Ljava/util/List;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, iceServers_jfieldId);
					return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (iceServers_jfieldId == IntPtr.Zero)
						iceServers_jfieldId = JNIEnv.GetFieldID (class_ref, "iceServers", "Ljava/util/List;");
					IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (Handle, iceServers_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr iceTransportsType_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.RTCConfiguration']/field[@name='iceTransportsType']"
			[Register ("iceTransportsType")]
			public global::Org.Webrtc.PeerConnection.IceTransportsType IceTransportsType {
				get {
					if (iceTransportsType_jfieldId == IntPtr.Zero)
						iceTransportsType_jfieldId = JNIEnv.GetFieldID (class_ref, "iceTransportsType", "Lorg/webrtc/PeerConnection$IceTransportsType;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, iceTransportsType_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.IceTransportsType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (iceTransportsType_jfieldId == IntPtr.Zero)
						iceTransportsType_jfieldId = JNIEnv.GetFieldID (class_ref, "iceTransportsType", "Lorg/webrtc/PeerConnection$IceTransportsType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (Handle, iceTransportsType_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr rtcpMuxPolicy_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.RTCConfiguration']/field[@name='rtcpMuxPolicy']"
			[Register ("rtcpMuxPolicy")]
			public global::Org.Webrtc.PeerConnection.RtcpMuxPolicy RtcpMuxPolicy {
				get {
					if (rtcpMuxPolicy_jfieldId == IntPtr.Zero)
						rtcpMuxPolicy_jfieldId = JNIEnv.GetFieldID (class_ref, "rtcpMuxPolicy", "Lorg/webrtc/PeerConnection$RtcpMuxPolicy;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, rtcpMuxPolicy_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.RtcpMuxPolicy> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (rtcpMuxPolicy_jfieldId == IntPtr.Zero)
						rtcpMuxPolicy_jfieldId = JNIEnv.GetFieldID (class_ref, "rtcpMuxPolicy", "Lorg/webrtc/PeerConnection$RtcpMuxPolicy;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (Handle, rtcpMuxPolicy_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr tcpCandidatePolicy_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.RTCConfiguration']/field[@name='tcpCandidatePolicy']"
			[Register ("tcpCandidatePolicy")]
			public global::Org.Webrtc.PeerConnection.TcpCandidatePolicy TcpCandidatePolicy {
				get {
					if (tcpCandidatePolicy_jfieldId == IntPtr.Zero)
						tcpCandidatePolicy_jfieldId = JNIEnv.GetFieldID (class_ref, "tcpCandidatePolicy", "Lorg/webrtc/PeerConnection$TcpCandidatePolicy;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, tcpCandidatePolicy_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.TcpCandidatePolicy> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (tcpCandidatePolicy_jfieldId == IntPtr.Zero)
						tcpCandidatePolicy_jfieldId = JNIEnv.GetFieldID (class_ref, "tcpCandidatePolicy", "Lorg/webrtc/PeerConnection$TcpCandidatePolicy;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (Handle, tcpCandidatePolicy_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/webrtc/PeerConnection$RTCConfiguration", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (RTCConfiguration); }
			}

			protected RTCConfiguration (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_util_List_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.RTCConfiguration']/constructor[@name='PeerConnection.RTCConfiguration' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;org.webrtc.PeerConnection.IceServer&gt;']]"
			[Register (".ctor", "(Ljava/util/List;)V", "")]
			public unsafe RTCConfiguration (global::System.Collections.Generic.IList<global::Org.Webrtc.PeerConnection.IceServer> p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = global::Android.Runtime.JavaList<global::Org.Webrtc.PeerConnection.IceServer>.ToLocalJniHandle (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					if (GetType () != typeof (RTCConfiguration)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/util/List;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/util/List;)V", __args);
						return;
					}

					if (id_ctor_Ljava_util_List_ == IntPtr.Zero)
						id_ctor_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/List;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_List_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_util_List_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.RtcpMuxPolicy']"
		[global::Android.Runtime.Register ("org/webrtc/PeerConnection$RtcpMuxPolicy", DoNotGenerateAcw=true)]
		public sealed partial class RtcpMuxPolicy : global::Java.Lang.Enum {


			static IntPtr NEGOTIATE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.RtcpMuxPolicy']/field[@name='NEGOTIATE']"
			[Register ("NEGOTIATE")]
			public static global::Org.Webrtc.PeerConnection.RtcpMuxPolicy Negotiate {
				get {
					if (NEGOTIATE_jfieldId == IntPtr.Zero)
						NEGOTIATE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NEGOTIATE", "Lorg/webrtc/PeerConnection$RtcpMuxPolicy;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NEGOTIATE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.RtcpMuxPolicy> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr REQUIRE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.RtcpMuxPolicy']/field[@name='REQUIRE']"
			[Register ("REQUIRE")]
			public static global::Org.Webrtc.PeerConnection.RtcpMuxPolicy Require {
				get {
					if (REQUIRE_jfieldId == IntPtr.Zero)
						REQUIRE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REQUIRE", "Lorg/webrtc/PeerConnection$RtcpMuxPolicy;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, REQUIRE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.RtcpMuxPolicy> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/webrtc/PeerConnection$RtcpMuxPolicy", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (RtcpMuxPolicy); }
			}

			internal RtcpMuxPolicy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.RtcpMuxPolicy']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/webrtc/PeerConnection$RtcpMuxPolicy;", "")]
			public static unsafe global::Org.Webrtc.PeerConnection.RtcpMuxPolicy ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lorg/webrtc/PeerConnection$RtcpMuxPolicy;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Org.Webrtc.PeerConnection.RtcpMuxPolicy __ret = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.RtcpMuxPolicy> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.RtcpMuxPolicy']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/webrtc/PeerConnection$RtcpMuxPolicy;", "")]
			public static unsafe global::Org.Webrtc.PeerConnection.RtcpMuxPolicy[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lorg/webrtc/PeerConnection$RtcpMuxPolicy;");
				try {
					return (global::Org.Webrtc.PeerConnection.RtcpMuxPolicy[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Webrtc.PeerConnection.RtcpMuxPolicy));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.SignalingState']"
		[global::Android.Runtime.Register ("org/webrtc/PeerConnection$SignalingState", DoNotGenerateAcw=true)]
		public sealed partial class SignalingState : global::Java.Lang.Enum {


			static IntPtr CLOSED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.SignalingState']/field[@name='CLOSED']"
			[Register ("CLOSED")]
			public static global::Org.Webrtc.PeerConnection.SignalingState Closed {
				get {
					if (CLOSED_jfieldId == IntPtr.Zero)
						CLOSED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CLOSED", "Lorg/webrtc/PeerConnection$SignalingState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CLOSED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.SignalingState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr HAVE_LOCAL_OFFER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.SignalingState']/field[@name='HAVE_LOCAL_OFFER']"
			[Register ("HAVE_LOCAL_OFFER")]
			public static global::Org.Webrtc.PeerConnection.SignalingState HaveLocalOffer {
				get {
					if (HAVE_LOCAL_OFFER_jfieldId == IntPtr.Zero)
						HAVE_LOCAL_OFFER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HAVE_LOCAL_OFFER", "Lorg/webrtc/PeerConnection$SignalingState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, HAVE_LOCAL_OFFER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.SignalingState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr HAVE_LOCAL_PRANSWER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.SignalingState']/field[@name='HAVE_LOCAL_PRANSWER']"
			[Register ("HAVE_LOCAL_PRANSWER")]
			public static global::Org.Webrtc.PeerConnection.SignalingState HaveLocalPranswer {
				get {
					if (HAVE_LOCAL_PRANSWER_jfieldId == IntPtr.Zero)
						HAVE_LOCAL_PRANSWER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HAVE_LOCAL_PRANSWER", "Lorg/webrtc/PeerConnection$SignalingState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, HAVE_LOCAL_PRANSWER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.SignalingState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr HAVE_REMOTE_OFFER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.SignalingState']/field[@name='HAVE_REMOTE_OFFER']"
			[Register ("HAVE_REMOTE_OFFER")]
			public static global::Org.Webrtc.PeerConnection.SignalingState HaveRemoteOffer {
				get {
					if (HAVE_REMOTE_OFFER_jfieldId == IntPtr.Zero)
						HAVE_REMOTE_OFFER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HAVE_REMOTE_OFFER", "Lorg/webrtc/PeerConnection$SignalingState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, HAVE_REMOTE_OFFER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.SignalingState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr HAVE_REMOTE_PRANSWER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.SignalingState']/field[@name='HAVE_REMOTE_PRANSWER']"
			[Register ("HAVE_REMOTE_PRANSWER")]
			public static global::Org.Webrtc.PeerConnection.SignalingState HaveRemotePranswer {
				get {
					if (HAVE_REMOTE_PRANSWER_jfieldId == IntPtr.Zero)
						HAVE_REMOTE_PRANSWER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HAVE_REMOTE_PRANSWER", "Lorg/webrtc/PeerConnection$SignalingState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, HAVE_REMOTE_PRANSWER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.SignalingState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr STABLE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.SignalingState']/field[@name='STABLE']"
			[Register ("STABLE")]
			public static global::Org.Webrtc.PeerConnection.SignalingState Stable {
				get {
					if (STABLE_jfieldId == IntPtr.Zero)
						STABLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STABLE", "Lorg/webrtc/PeerConnection$SignalingState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, STABLE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.SignalingState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/webrtc/PeerConnection$SignalingState", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (SignalingState); }
			}

			internal SignalingState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.SignalingState']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/webrtc/PeerConnection$SignalingState;", "")]
			public static unsafe global::Org.Webrtc.PeerConnection.SignalingState ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lorg/webrtc/PeerConnection$SignalingState;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Org.Webrtc.PeerConnection.SignalingState __ret = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.SignalingState> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.SignalingState']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/webrtc/PeerConnection$SignalingState;", "")]
			public static unsafe global::Org.Webrtc.PeerConnection.SignalingState[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lorg/webrtc/PeerConnection$SignalingState;");
				try {
					return (global::Org.Webrtc.PeerConnection.SignalingState[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Webrtc.PeerConnection.SignalingState));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.TcpCandidatePolicy']"
		[global::Android.Runtime.Register ("org/webrtc/PeerConnection$TcpCandidatePolicy", DoNotGenerateAcw=true)]
		public sealed partial class TcpCandidatePolicy : global::Java.Lang.Enum {


			static IntPtr DISABLED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.TcpCandidatePolicy']/field[@name='DISABLED']"
			[Register ("DISABLED")]
			public static global::Org.Webrtc.PeerConnection.TcpCandidatePolicy Disabled {
				get {
					if (DISABLED_jfieldId == IntPtr.Zero)
						DISABLED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DISABLED", "Lorg/webrtc/PeerConnection$TcpCandidatePolicy;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DISABLED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.TcpCandidatePolicy> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr ENABLED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.TcpCandidatePolicy']/field[@name='ENABLED']"
			[Register ("ENABLED")]
			public static global::Org.Webrtc.PeerConnection.TcpCandidatePolicy Enabled {
				get {
					if (ENABLED_jfieldId == IntPtr.Zero)
						ENABLED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ENABLED", "Lorg/webrtc/PeerConnection$TcpCandidatePolicy;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ENABLED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.TcpCandidatePolicy> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/webrtc/PeerConnection$TcpCandidatePolicy", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (TcpCandidatePolicy); }
			}

			internal TcpCandidatePolicy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.TcpCandidatePolicy']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/webrtc/PeerConnection$TcpCandidatePolicy;", "")]
			public static unsafe global::Org.Webrtc.PeerConnection.TcpCandidatePolicy ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lorg/webrtc/PeerConnection$TcpCandidatePolicy;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Org.Webrtc.PeerConnection.TcpCandidatePolicy __ret = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.TcpCandidatePolicy> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection.TcpCandidatePolicy']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/webrtc/PeerConnection$TcpCandidatePolicy;", "")]
			public static unsafe global::Org.Webrtc.PeerConnection.TcpCandidatePolicy[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lorg/webrtc/PeerConnection$TcpCandidatePolicy;");
				try {
					return (global::Org.Webrtc.PeerConnection.TcpCandidatePolicy[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Webrtc.PeerConnection.TcpCandidatePolicy));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/webrtc/PeerConnection", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PeerConnection); }
		}

		protected PeerConnection (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getLocalDescription;
#pragma warning disable 0169
		static Delegate GetGetLocalDescriptionHandler ()
		{
			if (cb_getLocalDescription == null)
				cb_getLocalDescription = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLocalDescription);
			return cb_getLocalDescription;
		}

		static IntPtr n_GetLocalDescription (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.PeerConnection __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LocalDescription);
		}
#pragma warning restore 0169

		static IntPtr id_getLocalDescription;
		public virtual unsafe global::Org.Webrtc.SessionDescription LocalDescription {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection']/method[@name='getLocalDescription' and count(parameter)=0]"
			[Register ("getLocalDescription", "()Lorg/webrtc/SessionDescription;", "GetGetLocalDescriptionHandler")]
			get {
				if (id_getLocalDescription == IntPtr.Zero)
					id_getLocalDescription = JNIEnv.GetMethodID (class_ref, "getLocalDescription", "()Lorg/webrtc/SessionDescription;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Webrtc.SessionDescription> (JNIEnv.CallObjectMethod  (Handle, id_getLocalDescription), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Webrtc.SessionDescription> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLocalDescription", "()Lorg/webrtc/SessionDescription;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRemoteDescription;
#pragma warning disable 0169
		static Delegate GetGetRemoteDescriptionHandler ()
		{
			if (cb_getRemoteDescription == null)
				cb_getRemoteDescription = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRemoteDescription);
			return cb_getRemoteDescription;
		}

		static IntPtr n_GetRemoteDescription (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.PeerConnection __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RemoteDescription);
		}
#pragma warning restore 0169

		static IntPtr id_getRemoteDescription;
		public virtual unsafe global::Org.Webrtc.SessionDescription RemoteDescription {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection']/method[@name='getRemoteDescription' and count(parameter)=0]"
			[Register ("getRemoteDescription", "()Lorg/webrtc/SessionDescription;", "GetGetRemoteDescriptionHandler")]
			get {
				if (id_getRemoteDescription == IntPtr.Zero)
					id_getRemoteDescription = JNIEnv.GetMethodID (class_ref, "getRemoteDescription", "()Lorg/webrtc/SessionDescription;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Webrtc.SessionDescription> (JNIEnv.CallObjectMethod  (Handle, id_getRemoteDescription), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Webrtc.SessionDescription> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRemoteDescription", "()Lorg/webrtc/SessionDescription;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addIceCandidate_Lorg_webrtc_IceCandidate_;
#pragma warning disable 0169
		static Delegate GetAddIceCandidate_Lorg_webrtc_IceCandidate_Handler ()
		{
			if (cb_addIceCandidate_Lorg_webrtc_IceCandidate_ == null)
				cb_addIceCandidate_Lorg_webrtc_IceCandidate_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_AddIceCandidate_Lorg_webrtc_IceCandidate_);
			return cb_addIceCandidate_Lorg_webrtc_IceCandidate_;
		}

		static bool n_AddIceCandidate_Lorg_webrtc_IceCandidate_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Webrtc.PeerConnection __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.IceCandidate p0 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IceCandidate> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AddIceCandidate (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addIceCandidate_Lorg_webrtc_IceCandidate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection']/method[@name='addIceCandidate' and count(parameter)=1 and parameter[1][@type='org.webrtc.IceCandidate']]"
		[Register ("addIceCandidate", "(Lorg/webrtc/IceCandidate;)Z", "GetAddIceCandidate_Lorg_webrtc_IceCandidate_Handler")]
		public virtual unsafe bool AddIceCandidate (global::Org.Webrtc.IceCandidate p0)
		{
			if (id_addIceCandidate_Lorg_webrtc_IceCandidate_ == IntPtr.Zero)
				id_addIceCandidate_Lorg_webrtc_IceCandidate_ = JNIEnv.GetMethodID (class_ref, "addIceCandidate", "(Lorg/webrtc/IceCandidate;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_addIceCandidate_Lorg_webrtc_IceCandidate_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addIceCandidate", "(Lorg/webrtc/IceCandidate;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_addStream_Lorg_webrtc_MediaStream_;
#pragma warning disable 0169
		static Delegate GetAddStream_Lorg_webrtc_MediaStream_Handler ()
		{
			if (cb_addStream_Lorg_webrtc_MediaStream_ == null)
				cb_addStream_Lorg_webrtc_MediaStream_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_AddStream_Lorg_webrtc_MediaStream_);
			return cb_addStream_Lorg_webrtc_MediaStream_;
		}

		static bool n_AddStream_Lorg_webrtc_MediaStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Webrtc.PeerConnection __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.MediaStream p0 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaStream> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AddStream (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addStream_Lorg_webrtc_MediaStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection']/method[@name='addStream' and count(parameter)=1 and parameter[1][@type='org.webrtc.MediaStream']]"
		[Register ("addStream", "(Lorg/webrtc/MediaStream;)Z", "GetAddStream_Lorg_webrtc_MediaStream_Handler")]
		public virtual unsafe bool AddStream (global::Org.Webrtc.MediaStream p0)
		{
			if (id_addStream_Lorg_webrtc_MediaStream_ == IntPtr.Zero)
				id_addStream_Lorg_webrtc_MediaStream_ = JNIEnv.GetMethodID (class_ref, "addStream", "(Lorg/webrtc/MediaStream;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_addStream_Lorg_webrtc_MediaStream_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addStream", "(Lorg/webrtc/MediaStream;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.PeerConnection __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public virtual unsafe void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_close);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "close", "()V"));
			} finally {
			}
		}

		static Delegate cb_createAnswer_Lorg_webrtc_SdpObserver_Lorg_webrtc_MediaConstraints_;
#pragma warning disable 0169
		static Delegate GetCreateAnswer_Lorg_webrtc_SdpObserver_Lorg_webrtc_MediaConstraints_Handler ()
		{
			if (cb_createAnswer_Lorg_webrtc_SdpObserver_Lorg_webrtc_MediaConstraints_ == null)
				cb_createAnswer_Lorg_webrtc_SdpObserver_Lorg_webrtc_MediaConstraints_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateAnswer_Lorg_webrtc_SdpObserver_Lorg_webrtc_MediaConstraints_);
			return cb_createAnswer_Lorg_webrtc_SdpObserver_Lorg_webrtc_MediaConstraints_;
		}

		static void n_CreateAnswer_Lorg_webrtc_SdpObserver_Lorg_webrtc_MediaConstraints_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Webrtc.PeerConnection __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.ISdpObserver p0 = (global::Org.Webrtc.ISdpObserver)global::Java.Lang.Object.GetObject<global::Org.Webrtc.ISdpObserver> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.MediaConstraints p1 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaConstraints> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.CreateAnswer (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_createAnswer_Lorg_webrtc_SdpObserver_Lorg_webrtc_MediaConstraints_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection']/method[@name='createAnswer' and count(parameter)=2 and parameter[1][@type='org.webrtc.SdpObserver'] and parameter[2][@type='org.webrtc.MediaConstraints']]"
		[Register ("createAnswer", "(Lorg/webrtc/SdpObserver;Lorg/webrtc/MediaConstraints;)V", "GetCreateAnswer_Lorg_webrtc_SdpObserver_Lorg_webrtc_MediaConstraints_Handler")]
		public virtual unsafe void CreateAnswer (global::Org.Webrtc.ISdpObserver p0, global::Org.Webrtc.MediaConstraints p1)
		{
			if (id_createAnswer_Lorg_webrtc_SdpObserver_Lorg_webrtc_MediaConstraints_ == IntPtr.Zero)
				id_createAnswer_Lorg_webrtc_SdpObserver_Lorg_webrtc_MediaConstraints_ = JNIEnv.GetMethodID (class_ref, "createAnswer", "(Lorg/webrtc/SdpObserver;Lorg/webrtc/MediaConstraints;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_createAnswer_Lorg_webrtc_SdpObserver_Lorg_webrtc_MediaConstraints_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createAnswer", "(Lorg/webrtc/SdpObserver;Lorg/webrtc/MediaConstraints;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_createDataChannel_Ljava_lang_String_Lorg_webrtc_DataChannel_Init_;
#pragma warning disable 0169
		static Delegate GetCreateDataChannel_Ljava_lang_String_Lorg_webrtc_DataChannel_Init_Handler ()
		{
			if (cb_createDataChannel_Ljava_lang_String_Lorg_webrtc_DataChannel_Init_ == null)
				cb_createDataChannel_Ljava_lang_String_Lorg_webrtc_DataChannel_Init_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateDataChannel_Ljava_lang_String_Lorg_webrtc_DataChannel_Init_);
			return cb_createDataChannel_Ljava_lang_String_Lorg_webrtc_DataChannel_Init_;
		}

		static IntPtr n_CreateDataChannel_Ljava_lang_String_Lorg_webrtc_DataChannel_Init_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Webrtc.PeerConnection __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.DataChannel.Init p1 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.DataChannel.Init> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateDataChannel (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_createDataChannel_Ljava_lang_String_Lorg_webrtc_DataChannel_Init_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection']/method[@name='createDataChannel' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.webrtc.DataChannel.Init']]"
		[Register ("createDataChannel", "(Ljava/lang/String;Lorg/webrtc/DataChannel$Init;)Lorg/webrtc/DataChannel;", "GetCreateDataChannel_Ljava_lang_String_Lorg_webrtc_DataChannel_Init_Handler")]
		public virtual unsafe global::Org.Webrtc.DataChannel CreateDataChannel (string p0, global::Org.Webrtc.DataChannel.Init p1)
		{
			if (id_createDataChannel_Ljava_lang_String_Lorg_webrtc_DataChannel_Init_ == IntPtr.Zero)
				id_createDataChannel_Ljava_lang_String_Lorg_webrtc_DataChannel_Init_ = JNIEnv.GetMethodID (class_ref, "createDataChannel", "(Ljava/lang/String;Lorg/webrtc/DataChannel$Init;)Lorg/webrtc/DataChannel;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				global::Org.Webrtc.DataChannel __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Webrtc.DataChannel> (JNIEnv.CallObjectMethod  (Handle, id_createDataChannel_Ljava_lang_String_Lorg_webrtc_DataChannel_Init_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Webrtc.DataChannel> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createDataChannel", "(Ljava/lang/String;Lorg/webrtc/DataChannel$Init;)Lorg/webrtc/DataChannel;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_createOffer_Lorg_webrtc_SdpObserver_Lorg_webrtc_MediaConstraints_;
#pragma warning disable 0169
		static Delegate GetCreateOffer_Lorg_webrtc_SdpObserver_Lorg_webrtc_MediaConstraints_Handler ()
		{
			if (cb_createOffer_Lorg_webrtc_SdpObserver_Lorg_webrtc_MediaConstraints_ == null)
				cb_createOffer_Lorg_webrtc_SdpObserver_Lorg_webrtc_MediaConstraints_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateOffer_Lorg_webrtc_SdpObserver_Lorg_webrtc_MediaConstraints_);
			return cb_createOffer_Lorg_webrtc_SdpObserver_Lorg_webrtc_MediaConstraints_;
		}

		static void n_CreateOffer_Lorg_webrtc_SdpObserver_Lorg_webrtc_MediaConstraints_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Webrtc.PeerConnection __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.ISdpObserver p0 = (global::Org.Webrtc.ISdpObserver)global::Java.Lang.Object.GetObject<global::Org.Webrtc.ISdpObserver> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.MediaConstraints p1 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaConstraints> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.CreateOffer (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_createOffer_Lorg_webrtc_SdpObserver_Lorg_webrtc_MediaConstraints_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection']/method[@name='createOffer' and count(parameter)=2 and parameter[1][@type='org.webrtc.SdpObserver'] and parameter[2][@type='org.webrtc.MediaConstraints']]"
		[Register ("createOffer", "(Lorg/webrtc/SdpObserver;Lorg/webrtc/MediaConstraints;)V", "GetCreateOffer_Lorg_webrtc_SdpObserver_Lorg_webrtc_MediaConstraints_Handler")]
		public virtual unsafe void CreateOffer (global::Org.Webrtc.ISdpObserver p0, global::Org.Webrtc.MediaConstraints p1)
		{
			if (id_createOffer_Lorg_webrtc_SdpObserver_Lorg_webrtc_MediaConstraints_ == IntPtr.Zero)
				id_createOffer_Lorg_webrtc_SdpObserver_Lorg_webrtc_MediaConstraints_ = JNIEnv.GetMethodID (class_ref, "createOffer", "(Lorg/webrtc/SdpObserver;Lorg/webrtc/MediaConstraints;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_createOffer_Lorg_webrtc_SdpObserver_Lorg_webrtc_MediaConstraints_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createOffer", "(Lorg/webrtc/SdpObserver;Lorg/webrtc/MediaConstraints;)V"), __args);
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
			global::Org.Webrtc.PeerConnection __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dispose ();
		}
#pragma warning restore 0169

		static IntPtr id_dispose;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection']/method[@name='dispose' and count(parameter)=0]"
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

		static Delegate cb_getStats_Lorg_webrtc_StatsObserver_Lorg_webrtc_MediaStreamTrack_;
#pragma warning disable 0169
		static Delegate GetGetStats_Lorg_webrtc_StatsObserver_Lorg_webrtc_MediaStreamTrack_Handler ()
		{
			if (cb_getStats_Lorg_webrtc_StatsObserver_Lorg_webrtc_MediaStreamTrack_ == null)
				cb_getStats_Lorg_webrtc_StatsObserver_Lorg_webrtc_MediaStreamTrack_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_GetStats_Lorg_webrtc_StatsObserver_Lorg_webrtc_MediaStreamTrack_);
			return cb_getStats_Lorg_webrtc_StatsObserver_Lorg_webrtc_MediaStreamTrack_;
		}

		static bool n_GetStats_Lorg_webrtc_StatsObserver_Lorg_webrtc_MediaStreamTrack_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Webrtc.PeerConnection __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.IStatsObserver p0 = (global::Org.Webrtc.IStatsObserver)global::Java.Lang.Object.GetObject<global::Org.Webrtc.IStatsObserver> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.MediaStreamTrack p1 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaStreamTrack> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.GetStats (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getStats_Lorg_webrtc_StatsObserver_Lorg_webrtc_MediaStreamTrack_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection']/method[@name='getStats' and count(parameter)=2 and parameter[1][@type='org.webrtc.StatsObserver'] and parameter[2][@type='org.webrtc.MediaStreamTrack']]"
		[Register ("getStats", "(Lorg/webrtc/StatsObserver;Lorg/webrtc/MediaStreamTrack;)Z", "GetGetStats_Lorg_webrtc_StatsObserver_Lorg_webrtc_MediaStreamTrack_Handler")]
		public virtual unsafe bool GetStats (global::Org.Webrtc.IStatsObserver p0, global::Org.Webrtc.MediaStreamTrack p1)
		{
			if (id_getStats_Lorg_webrtc_StatsObserver_Lorg_webrtc_MediaStreamTrack_ == IntPtr.Zero)
				id_getStats_Lorg_webrtc_StatsObserver_Lorg_webrtc_MediaStreamTrack_ = JNIEnv.GetMethodID (class_ref, "getStats", "(Lorg/webrtc/StatsObserver;Lorg/webrtc/MediaStreamTrack;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_getStats_Lorg_webrtc_StatsObserver_Lorg_webrtc_MediaStreamTrack_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStats", "(Lorg/webrtc/StatsObserver;Lorg/webrtc/MediaStreamTrack;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_iceConnectionState;
#pragma warning disable 0169
		static Delegate GetInvokeIceConnectionStateHandler ()
		{
			if (cb_iceConnectionState == null)
				cb_iceConnectionState = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_InvokeIceConnectionState);
			return cb_iceConnectionState;
		}

		static IntPtr n_InvokeIceConnectionState (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.PeerConnection __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InvokeIceConnectionState ());
		}
#pragma warning restore 0169

		static IntPtr id_iceConnectionState;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection']/method[@name='iceConnectionState' and count(parameter)=0]"
		[Register ("iceConnectionState", "()Lorg/webrtc/PeerConnection$IceConnectionState;", "GetInvokeIceConnectionStateHandler")]
		public virtual unsafe global::Org.Webrtc.PeerConnection.IceConnectionState InvokeIceConnectionState ()
		{
			if (id_iceConnectionState == IntPtr.Zero)
				id_iceConnectionState = JNIEnv.GetMethodID (class_ref, "iceConnectionState", "()Lorg/webrtc/PeerConnection$IceConnectionState;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.IceConnectionState> (JNIEnv.CallObjectMethod  (Handle, id_iceConnectionState), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.IceConnectionState> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "iceConnectionState", "()Lorg/webrtc/PeerConnection$IceConnectionState;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_iceGatheringState;
#pragma warning disable 0169
		static Delegate GetInvokeIceGatheringStateHandler ()
		{
			if (cb_iceGatheringState == null)
				cb_iceGatheringState = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_InvokeIceGatheringState);
			return cb_iceGatheringState;
		}

		static IntPtr n_InvokeIceGatheringState (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.PeerConnection __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InvokeIceGatheringState ());
		}
#pragma warning restore 0169

		static IntPtr id_iceGatheringState;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection']/method[@name='iceGatheringState' and count(parameter)=0]"
		[Register ("iceGatheringState", "()Lorg/webrtc/PeerConnection$IceGatheringState;", "GetInvokeIceGatheringStateHandler")]
		public virtual unsafe global::Org.Webrtc.PeerConnection.IceGatheringState InvokeIceGatheringState ()
		{
			if (id_iceGatheringState == IntPtr.Zero)
				id_iceGatheringState = JNIEnv.GetMethodID (class_ref, "iceGatheringState", "()Lorg/webrtc/PeerConnection$IceGatheringState;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.IceGatheringState> (JNIEnv.CallObjectMethod  (Handle, id_iceGatheringState), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.IceGatheringState> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "iceGatheringState", "()Lorg/webrtc/PeerConnection$IceGatheringState;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_removeStream_Lorg_webrtc_MediaStream_;
#pragma warning disable 0169
		static Delegate GetRemoveStream_Lorg_webrtc_MediaStream_Handler ()
		{
			if (cb_removeStream_Lorg_webrtc_MediaStream_ == null)
				cb_removeStream_Lorg_webrtc_MediaStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveStream_Lorg_webrtc_MediaStream_);
			return cb_removeStream_Lorg_webrtc_MediaStream_;
		}

		static void n_RemoveStream_Lorg_webrtc_MediaStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Webrtc.PeerConnection __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.MediaStream p0 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaStream> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveStream (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeStream_Lorg_webrtc_MediaStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection']/method[@name='removeStream' and count(parameter)=1 and parameter[1][@type='org.webrtc.MediaStream']]"
		[Register ("removeStream", "(Lorg/webrtc/MediaStream;)V", "GetRemoveStream_Lorg_webrtc_MediaStream_Handler")]
		public virtual unsafe void RemoveStream (global::Org.Webrtc.MediaStream p0)
		{
			if (id_removeStream_Lorg_webrtc_MediaStream_ == IntPtr.Zero)
				id_removeStream_Lorg_webrtc_MediaStream_ = JNIEnv.GetMethodID (class_ref, "removeStream", "(Lorg/webrtc/MediaStream;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_removeStream_Lorg_webrtc_MediaStream_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeStream", "(Lorg/webrtc/MediaStream;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setIceConnectionReceivingTimeout_I;
#pragma warning disable 0169
		static Delegate GetSetIceConnectionReceivingTimeout_IHandler ()
		{
			if (cb_setIceConnectionReceivingTimeout_I == null)
				cb_setIceConnectionReceivingTimeout_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetIceConnectionReceivingTimeout_I);
			return cb_setIceConnectionReceivingTimeout_I;
		}

		static void n_SetIceConnectionReceivingTimeout_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Webrtc.PeerConnection __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetIceConnectionReceivingTimeout (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setIceConnectionReceivingTimeout_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection']/method[@name='setIceConnectionReceivingTimeout' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setIceConnectionReceivingTimeout", "(I)V", "GetSetIceConnectionReceivingTimeout_IHandler")]
		public virtual unsafe void SetIceConnectionReceivingTimeout (int p0)
		{
			if (id_setIceConnectionReceivingTimeout_I == IntPtr.Zero)
				id_setIceConnectionReceivingTimeout_I = JNIEnv.GetMethodID (class_ref, "setIceConnectionReceivingTimeout", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setIceConnectionReceivingTimeout_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIceConnectionReceivingTimeout", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setLocalDescription_Lorg_webrtc_SdpObserver_Lorg_webrtc_SessionDescription_;
#pragma warning disable 0169
		static Delegate GetSetLocalDescription_Lorg_webrtc_SdpObserver_Lorg_webrtc_SessionDescription_Handler ()
		{
			if (cb_setLocalDescription_Lorg_webrtc_SdpObserver_Lorg_webrtc_SessionDescription_ == null)
				cb_setLocalDescription_Lorg_webrtc_SdpObserver_Lorg_webrtc_SessionDescription_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetLocalDescription_Lorg_webrtc_SdpObserver_Lorg_webrtc_SessionDescription_);
			return cb_setLocalDescription_Lorg_webrtc_SdpObserver_Lorg_webrtc_SessionDescription_;
		}

		static void n_SetLocalDescription_Lorg_webrtc_SdpObserver_Lorg_webrtc_SessionDescription_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Webrtc.PeerConnection __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.ISdpObserver p0 = (global::Org.Webrtc.ISdpObserver)global::Java.Lang.Object.GetObject<global::Org.Webrtc.ISdpObserver> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.SessionDescription p1 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.SessionDescription> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetLocalDescription (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setLocalDescription_Lorg_webrtc_SdpObserver_Lorg_webrtc_SessionDescription_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection']/method[@name='setLocalDescription' and count(parameter)=2 and parameter[1][@type='org.webrtc.SdpObserver'] and parameter[2][@type='org.webrtc.SessionDescription']]"
		[Register ("setLocalDescription", "(Lorg/webrtc/SdpObserver;Lorg/webrtc/SessionDescription;)V", "GetSetLocalDescription_Lorg_webrtc_SdpObserver_Lorg_webrtc_SessionDescription_Handler")]
		public virtual unsafe void SetLocalDescription (global::Org.Webrtc.ISdpObserver p0, global::Org.Webrtc.SessionDescription p1)
		{
			if (id_setLocalDescription_Lorg_webrtc_SdpObserver_Lorg_webrtc_SessionDescription_ == IntPtr.Zero)
				id_setLocalDescription_Lorg_webrtc_SdpObserver_Lorg_webrtc_SessionDescription_ = JNIEnv.GetMethodID (class_ref, "setLocalDescription", "(Lorg/webrtc/SdpObserver;Lorg/webrtc/SessionDescription;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setLocalDescription_Lorg_webrtc_SdpObserver_Lorg_webrtc_SessionDescription_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLocalDescription", "(Lorg/webrtc/SdpObserver;Lorg/webrtc/SessionDescription;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setRemoteDescription_Lorg_webrtc_SdpObserver_Lorg_webrtc_SessionDescription_;
#pragma warning disable 0169
		static Delegate GetSetRemoteDescription_Lorg_webrtc_SdpObserver_Lorg_webrtc_SessionDescription_Handler ()
		{
			if (cb_setRemoteDescription_Lorg_webrtc_SdpObserver_Lorg_webrtc_SessionDescription_ == null)
				cb_setRemoteDescription_Lorg_webrtc_SdpObserver_Lorg_webrtc_SessionDescription_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetRemoteDescription_Lorg_webrtc_SdpObserver_Lorg_webrtc_SessionDescription_);
			return cb_setRemoteDescription_Lorg_webrtc_SdpObserver_Lorg_webrtc_SessionDescription_;
		}

		static void n_SetRemoteDescription_Lorg_webrtc_SdpObserver_Lorg_webrtc_SessionDescription_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Webrtc.PeerConnection __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.ISdpObserver p0 = (global::Org.Webrtc.ISdpObserver)global::Java.Lang.Object.GetObject<global::Org.Webrtc.ISdpObserver> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.SessionDescription p1 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.SessionDescription> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetRemoteDescription (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setRemoteDescription_Lorg_webrtc_SdpObserver_Lorg_webrtc_SessionDescription_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection']/method[@name='setRemoteDescription' and count(parameter)=2 and parameter[1][@type='org.webrtc.SdpObserver'] and parameter[2][@type='org.webrtc.SessionDescription']]"
		[Register ("setRemoteDescription", "(Lorg/webrtc/SdpObserver;Lorg/webrtc/SessionDescription;)V", "GetSetRemoteDescription_Lorg_webrtc_SdpObserver_Lorg_webrtc_SessionDescription_Handler")]
		public virtual unsafe void SetRemoteDescription (global::Org.Webrtc.ISdpObserver p0, global::Org.Webrtc.SessionDescription p1)
		{
			if (id_setRemoteDescription_Lorg_webrtc_SdpObserver_Lorg_webrtc_SessionDescription_ == IntPtr.Zero)
				id_setRemoteDescription_Lorg_webrtc_SdpObserver_Lorg_webrtc_SessionDescription_ = JNIEnv.GetMethodID (class_ref, "setRemoteDescription", "(Lorg/webrtc/SdpObserver;Lorg/webrtc/SessionDescription;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setRemoteDescription_Lorg_webrtc_SdpObserver_Lorg_webrtc_SessionDescription_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRemoteDescription", "(Lorg/webrtc/SdpObserver;Lorg/webrtc/SessionDescription;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_signalingState;
#pragma warning disable 0169
		static Delegate GetInvokeSignalingStateHandler ()
		{
			if (cb_signalingState == null)
				cb_signalingState = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_InvokeSignalingState);
			return cb_signalingState;
		}

		static IntPtr n_InvokeSignalingState (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.PeerConnection __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InvokeSignalingState ());
		}
#pragma warning restore 0169

		static IntPtr id_signalingState;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection']/method[@name='signalingState' and count(parameter)=0]"
		[Register ("signalingState", "()Lorg/webrtc/PeerConnection$SignalingState;", "GetInvokeSignalingStateHandler")]
		public virtual unsafe global::Org.Webrtc.PeerConnection.SignalingState InvokeSignalingState ()
		{
			if (id_signalingState == IntPtr.Zero)
				id_signalingState = JNIEnv.GetMethodID (class_ref, "signalingState", "()Lorg/webrtc/PeerConnection$SignalingState;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.SignalingState> (JNIEnv.CallObjectMethod  (Handle, id_signalingState), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection.SignalingState> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "signalingState", "()Lorg/webrtc/PeerConnection$SignalingState;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_updateIce_Ljava_util_List_Lorg_webrtc_MediaConstraints_;
#pragma warning disable 0169
		static Delegate GetUpdateIce_Ljava_util_List_Lorg_webrtc_MediaConstraints_Handler ()
		{
			if (cb_updateIce_Ljava_util_List_Lorg_webrtc_MediaConstraints_ == null)
				cb_updateIce_Ljava_util_List_Lorg_webrtc_MediaConstraints_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_UpdateIce_Ljava_util_List_Lorg_webrtc_MediaConstraints_);
			return cb_updateIce_Ljava_util_List_Lorg_webrtc_MediaConstraints_;
		}

		static bool n_UpdateIce_Ljava_util_List_Lorg_webrtc_MediaConstraints_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Webrtc.PeerConnection __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.PeerConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Org.Webrtc.PeerConnection.IceServer>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.MediaConstraints p1 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaConstraints> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.UpdateIce (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_updateIce_Ljava_util_List_Lorg_webrtc_MediaConstraints_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='PeerConnection']/method[@name='updateIce' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;org.webrtc.PeerConnection.IceServer&gt;'] and parameter[2][@type='org.webrtc.MediaConstraints']]"
		[Register ("updateIce", "(Ljava/util/List;Lorg/webrtc/MediaConstraints;)Z", "GetUpdateIce_Ljava_util_List_Lorg_webrtc_MediaConstraints_Handler")]
		public virtual unsafe bool UpdateIce (global::System.Collections.Generic.IList<global::Org.Webrtc.PeerConnection.IceServer> p0, global::Org.Webrtc.MediaConstraints p1)
		{
			if (id_updateIce_Ljava_util_List_Lorg_webrtc_MediaConstraints_ == IntPtr.Zero)
				id_updateIce_Ljava_util_List_Lorg_webrtc_MediaConstraints_ = JNIEnv.GetMethodID (class_ref, "updateIce", "(Ljava/util/List;Lorg/webrtc/MediaConstraints;)Z");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Org.Webrtc.PeerConnection.IceServer>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_updateIce_Ljava_util_List_Lorg_webrtc_MediaConstraints_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateIce", "(Ljava/util/List;Lorg/webrtc/MediaConstraints;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
