using System;
using System.Collections.Generic;
using Android.Runtime;

namespace ME.Kevingleason.Pnwebrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='me.kevingleason.pnwebrtc']/class[@name='PnRTCMessage']"
	[global::Android.Runtime.Register ("me/kevingleason/pnwebrtc/PnRTCMessage", DoNotGenerateAcw=true)]
	public partial class PnRTCMessage : global::Org.Json.JSONObject {


		// Metadata.xml XPath field reference: path="/api/package[@name='me.kevingleason.pnwebrtc']/class[@name='PnRTCMessage']/field[@name='JSON_HANGUP']"
		[Register ("JSON_HANGUP")]
		public const string JsonHangup = (string) "hangup";

		// Metadata.xml XPath field reference: path="/api/package[@name='me.kevingleason.pnwebrtc']/class[@name='PnRTCMessage']/field[@name='JSON_ICE']"
		[Register ("JSON_ICE")]
		public const string JsonIce = (string) "candidate";

		// Metadata.xml XPath field reference: path="/api/package[@name='me.kevingleason.pnwebrtc']/class[@name='PnRTCMessage']/field[@name='JSON_ID']"
		[Register ("JSON_ID")]
		public const string JsonId = (string) "id";

		// Metadata.xml XPath field reference: path="/api/package[@name='me.kevingleason.pnwebrtc']/class[@name='PnRTCMessage']/field[@name='JSON_MESSAGE']"
		[Register ("JSON_MESSAGE")]
		public const string JsonMessage = (string) "message";

		// Metadata.xml XPath field reference: path="/api/package[@name='me.kevingleason.pnwebrtc']/class[@name='PnRTCMessage']/field[@name='JSON_NUMBER']"
		[Register ("JSON_NUMBER")]
		public const string JsonNumber = (string) "number";

		// Metadata.xml XPath field reference: path="/api/package[@name='me.kevingleason.pnwebrtc']/class[@name='PnRTCMessage']/field[@name='JSON_PACKET']"
		[Register ("JSON_PACKET")]
		public const string JsonPacket = (string) "packet";

		// Metadata.xml XPath field reference: path="/api/package[@name='me.kevingleason.pnwebrtc']/class[@name='PnRTCMessage']/field[@name='JSON_SDP']"
		[Register ("JSON_SDP")]
		public const string JsonSdp = (string) "sdp";

		// Metadata.xml XPath field reference: path="/api/package[@name='me.kevingleason.pnwebrtc']/class[@name='PnRTCMessage']/field[@name='JSON_THUMBNAIL']"
		[Register ("JSON_THUMBNAIL")]
		public const string JsonThumbnail = (string) "thumbnail";

		// Metadata.xml XPath field reference: path="/api/package[@name='me.kevingleason.pnwebrtc']/class[@name='PnRTCMessage']/field[@name='JSON_TYPE']"
		[Register ("JSON_TYPE")]
		public const string JsonType = (string) "type";

		// Metadata.xml XPath field reference: path="/api/package[@name='me.kevingleason.pnwebrtc']/class[@name='PnRTCMessage']/field[@name='JSON_USERMSG']"
		[Register ("JSON_USERMSG")]
		public const string JsonUsermsg = (string) "usermsg";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("me/kevingleason/pnwebrtc/PnRTCMessage", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PnRTCMessage); }
		}

		protected PnRTCMessage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='me.kevingleason.pnwebrtc']/class[@name='PnRTCMessage']/constructor[@name='PnRTCMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe PnRTCMessage (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (PnRTCMessage)) {
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

		static IntPtr id_ctor_Lorg_json_JSONObject_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='me.kevingleason.pnwebrtc']/class[@name='PnRTCMessage']/constructor[@name='PnRTCMessage' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register (".ctor", "(Lorg/json/JSONObject;)V", "")]
		public unsafe PnRTCMessage (global::Org.Json.JSONObject p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (PnRTCMessage)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/json/JSONObject;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/json/JSONObject;)V", __args);
					return;
				}

				if (id_ctor_Lorg_json_JSONObject_ == IntPtr.Zero)
					id_ctor_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/json/JSONObject;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_json_JSONObject_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_json_JSONObject_, __args);
			} finally {
			}
		}

		static Delegate cb_getJSON;
#pragma warning disable 0169
		static Delegate GetGetJSONHandler ()
		{
			if (cb_getJSON == null)
				cb_getJSON = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetJSON);
			return cb_getJSON;
		}

		static IntPtr n_GetJSON (IntPtr jnienv, IntPtr native__this)
		{
			global::ME.Kevingleason.Pnwebrtc.PnRTCMessage __this = global::Java.Lang.Object.GetObject<global::ME.Kevingleason.Pnwebrtc.PnRTCMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.JSON);
		}
#pragma warning restore 0169

		static IntPtr id_getJSON;
		public virtual unsafe global::Org.Json.JSONObject JSON {
			// Metadata.xml XPath method reference: path="/api/package[@name='me.kevingleason.pnwebrtc']/class[@name='PnRTCMessage']/method[@name='getJSON' and count(parameter)=0]"
			[Register ("getJSON", "()Lorg/json/JSONObject;", "GetGetJSONHandler")]
			get {
				if (id_getJSON == IntPtr.Zero)
					id_getJSON = JNIEnv.GetMethodID (class_ref, "getJSON", "()Lorg/json/JSONObject;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod  (Handle, id_getJSON), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getJSON", "()Lorg/json/JSONObject;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMessage;
#pragma warning disable 0169
		static Delegate GetGetMessageHandler ()
		{
			if (cb_getMessage == null)
				cb_getMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMessage);
			return cb_getMessage;
		}

		static IntPtr n_GetMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::ME.Kevingleason.Pnwebrtc.PnRTCMessage __this = global::Java.Lang.Object.GetObject<global::ME.Kevingleason.Pnwebrtc.PnRTCMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Message);
		}
#pragma warning restore 0169

		static IntPtr id_getMessage;
		public virtual unsafe string Message {
			// Metadata.xml XPath method reference: path="/api/package[@name='me.kevingleason.pnwebrtc']/class[@name='PnRTCMessage']/method[@name='getMessage' and count(parameter)=0]"
			[Register ("getMessage", "()Ljava/lang/String;", "GetGetMessageHandler")]
			get {
				if (id_getMessage == IntPtr.Zero)
					id_getMessage = JNIEnv.GetMethodID (class_ref, "getMessage", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getMessage), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessage", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
