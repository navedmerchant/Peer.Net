using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Webrtc.Voiceengine {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='WebRtcAudioUtils']"
	[global::Android.Runtime.Register ("org/webrtc/voiceengine/WebRtcAudioUtils", DoNotGenerateAcw=true)]
	public sealed partial class WebRtcAudioUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/webrtc/voiceengine/WebRtcAudioUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (WebRtcAudioUtils); }
		}

		internal WebRtcAudioUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='WebRtcAudioUtils']/constructor[@name='WebRtcAudioUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe WebRtcAudioUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (WebRtcAudioUtils)) {
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

		static IntPtr id_isAcousticEchoCancelerApproved;
		public static unsafe bool IsAcousticEchoCancelerApproved {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='WebRtcAudioUtils']/method[@name='isAcousticEchoCancelerApproved' and count(parameter)=0]"
			[Register ("isAcousticEchoCancelerApproved", "()Z", "GetIsAcousticEchoCancelerApprovedHandler")]
			get {
				if (id_isAcousticEchoCancelerApproved == IntPtr.Zero)
					id_isAcousticEchoCancelerApproved = JNIEnv.GetStaticMethodID (class_ref, "isAcousticEchoCancelerApproved", "()Z");
				try {
					return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isAcousticEchoCancelerApproved);
				} finally {
				}
			}
		}

		static IntPtr id_isAcousticEchoCancelerSupported;
		public static unsafe bool IsAcousticEchoCancelerSupported {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='WebRtcAudioUtils']/method[@name='isAcousticEchoCancelerSupported' and count(parameter)=0]"
			[Register ("isAcousticEchoCancelerSupported", "()Z", "GetIsAcousticEchoCancelerSupportedHandler")]
			get {
				if (id_isAcousticEchoCancelerSupported == IntPtr.Zero)
					id_isAcousticEchoCancelerSupported = JNIEnv.GetStaticMethodID (class_ref, "isAcousticEchoCancelerSupported", "()Z");
				try {
					return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isAcousticEchoCancelerSupported);
				} finally {
				}
			}
		}

		static IntPtr id_getThreadInfo;
		public static unsafe string ThreadInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='WebRtcAudioUtils']/method[@name='getThreadInfo' and count(parameter)=0]"
			[Register ("getThreadInfo", "()Ljava/lang/String;", "GetGetThreadInfoHandler")]
			get {
				if (id_getThreadInfo == IntPtr.Zero)
					id_getThreadInfo = JNIEnv.GetStaticMethodID (class_ref, "getThreadInfo", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getThreadInfo), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_deviceIsBlacklistedForHwAecUsage;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='WebRtcAudioUtils']/method[@name='deviceIsBlacklistedForHwAecUsage' and count(parameter)=0]"
		[Register ("deviceIsBlacklistedForHwAecUsage", "()Z", "")]
		public static unsafe bool DeviceIsBlacklistedForHwAecUsage ()
		{
			if (id_deviceIsBlacklistedForHwAecUsage == IntPtr.Zero)
				id_deviceIsBlacklistedForHwAecUsage = JNIEnv.GetStaticMethodID (class_ref, "deviceIsBlacklistedForHwAecUsage", "()Z");
			try {
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_deviceIsBlacklistedForHwAecUsage);
			} finally {
			}
		}

		static IntPtr id_deviceIsBlacklistedForOpenSLESUsage;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='WebRtcAudioUtils']/method[@name='deviceIsBlacklistedForOpenSLESUsage' and count(parameter)=0]"
		[Register ("deviceIsBlacklistedForOpenSLESUsage", "()Z", "")]
		public static unsafe bool DeviceIsBlacklistedForOpenSLESUsage ()
		{
			if (id_deviceIsBlacklistedForOpenSLESUsage == IntPtr.Zero)
				id_deviceIsBlacklistedForOpenSLESUsage = JNIEnv.GetStaticMethodID (class_ref, "deviceIsBlacklistedForOpenSLESUsage", "()Z");
			try {
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_deviceIsBlacklistedForOpenSLESUsage);
			} finally {
			}
		}

		static IntPtr id_hasPermission_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='WebRtcAudioUtils']/method[@name='hasPermission' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("hasPermission", "(Landroid/content/Context;Ljava/lang/String;)Z", "")]
		public static unsafe bool HasPermission (global::Android.Content.Context p0, string p1)
		{
			if (id_hasPermission_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_hasPermission_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "hasPermission", "(Landroid/content/Context;Ljava/lang/String;)Z");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_hasPermission_Landroid_content_Context_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_logDeviceInfo_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='WebRtcAudioUtils']/method[@name='logDeviceInfo' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("logDeviceInfo", "(Ljava/lang/String;)V", "")]
		public static unsafe void LogDeviceInfo (string p0)
		{
			if (id_logDeviceInfo_Ljava_lang_String_ == IntPtr.Zero)
				id_logDeviceInfo_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "logDeviceInfo", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_logDeviceInfo_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_runningOnEmulator;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='WebRtcAudioUtils']/method[@name='runningOnEmulator' and count(parameter)=0]"
		[Register ("runningOnEmulator", "()Z", "")]
		public static unsafe bool RunningOnEmulator ()
		{
			if (id_runningOnEmulator == IntPtr.Zero)
				id_runningOnEmulator = JNIEnv.GetStaticMethodID (class_ref, "runningOnEmulator", "()Z");
			try {
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_runningOnEmulator);
			} finally {
			}
		}

		static IntPtr id_runningOnGingerBreadOrHigher;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='WebRtcAudioUtils']/method[@name='runningOnGingerBreadOrHigher' and count(parameter)=0]"
		[Register ("runningOnGingerBreadOrHigher", "()Z", "")]
		public static unsafe bool RunningOnGingerBreadOrHigher ()
		{
			if (id_runningOnGingerBreadOrHigher == IntPtr.Zero)
				id_runningOnGingerBreadOrHigher = JNIEnv.GetStaticMethodID (class_ref, "runningOnGingerBreadOrHigher", "()Z");
			try {
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_runningOnGingerBreadOrHigher);
			} finally {
			}
		}

		static IntPtr id_runningOnJellyBeanMR1OrHigher;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='WebRtcAudioUtils']/method[@name='runningOnJellyBeanMR1OrHigher' and count(parameter)=0]"
		[Register ("runningOnJellyBeanMR1OrHigher", "()Z", "")]
		public static unsafe bool RunningOnJellyBeanMR1OrHigher ()
		{
			if (id_runningOnJellyBeanMR1OrHigher == IntPtr.Zero)
				id_runningOnJellyBeanMR1OrHigher = JNIEnv.GetStaticMethodID (class_ref, "runningOnJellyBeanMR1OrHigher", "()Z");
			try {
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_runningOnJellyBeanMR1OrHigher);
			} finally {
			}
		}

		static IntPtr id_runningOnJellyBeanOrHigher;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='WebRtcAudioUtils']/method[@name='runningOnJellyBeanOrHigher' and count(parameter)=0]"
		[Register ("runningOnJellyBeanOrHigher", "()Z", "")]
		public static unsafe bool RunningOnJellyBeanOrHigher ()
		{
			if (id_runningOnJellyBeanOrHigher == IntPtr.Zero)
				id_runningOnJellyBeanOrHigher = JNIEnv.GetStaticMethodID (class_ref, "runningOnJellyBeanOrHigher", "()Z");
			try {
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_runningOnJellyBeanOrHigher);
			} finally {
			}
		}

		static IntPtr id_runningOnLollipopOrHigher;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='WebRtcAudioUtils']/method[@name='runningOnLollipopOrHigher' and count(parameter)=0]"
		[Register ("runningOnLollipopOrHigher", "()Z", "")]
		public static unsafe bool RunningOnLollipopOrHigher ()
		{
			if (id_runningOnLollipopOrHigher == IntPtr.Zero)
				id_runningOnLollipopOrHigher = JNIEnv.GetStaticMethodID (class_ref, "runningOnLollipopOrHigher", "()Z");
			try {
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_runningOnLollipopOrHigher);
			} finally {
			}
		}

	}
}
