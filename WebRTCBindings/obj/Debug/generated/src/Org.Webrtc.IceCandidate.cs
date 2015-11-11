using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Webrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='IceCandidate']"
	[global::Android.Runtime.Register ("org/webrtc/IceCandidate", DoNotGenerateAcw=true)]
	public partial class IceCandidate : global::Java.Lang.Object {


		static IntPtr sdp_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='IceCandidate']/field[@name='sdp']"
		[Register ("sdp")]
		public string Sdp {
			get {
				if (sdp_jfieldId == IntPtr.Zero)
					sdp_jfieldId = JNIEnv.GetFieldID (class_ref, "sdp", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, sdp_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (sdp_jfieldId == IntPtr.Zero)
					sdp_jfieldId = JNIEnv.GetFieldID (class_ref, "sdp", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, sdp_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr sdpMLineIndex_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='IceCandidate']/field[@name='sdpMLineIndex']"
		[Register ("sdpMLineIndex")]
		public int SdpMLineIndex {
			get {
				if (sdpMLineIndex_jfieldId == IntPtr.Zero)
					sdpMLineIndex_jfieldId = JNIEnv.GetFieldID (class_ref, "sdpMLineIndex", "I");
				return JNIEnv.GetIntField (Handle, sdpMLineIndex_jfieldId);
			}
			set {
				if (sdpMLineIndex_jfieldId == IntPtr.Zero)
					sdpMLineIndex_jfieldId = JNIEnv.GetFieldID (class_ref, "sdpMLineIndex", "I");
				try {
					JNIEnv.SetField (Handle, sdpMLineIndex_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr sdpMid_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='IceCandidate']/field[@name='sdpMid']"
		[Register ("sdpMid")]
		public string SdpMid {
			get {
				if (sdpMid_jfieldId == IntPtr.Zero)
					sdpMid_jfieldId = JNIEnv.GetFieldID (class_ref, "sdpMid", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, sdpMid_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (sdpMid_jfieldId == IntPtr.Zero)
					sdpMid_jfieldId = JNIEnv.GetFieldID (class_ref, "sdpMid", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (Handle, sdpMid_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/webrtc/IceCandidate", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IceCandidate); }
		}

		protected IceCandidate (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_ILjava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='IceCandidate']/constructor[@name='IceCandidate' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;ILjava/lang/String;)V", "")]
		public unsafe IceCandidate (string p0, int p1, string p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				if (GetType () != typeof (IceCandidate)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;ILjava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;ILjava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_ILjava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;ILjava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_ILjava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_ILjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

	}
}
