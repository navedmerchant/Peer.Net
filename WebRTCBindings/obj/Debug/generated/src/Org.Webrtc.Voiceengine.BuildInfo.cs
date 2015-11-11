using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Webrtc.Voiceengine {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='BuildInfo']"
	[global::Android.Runtime.Register ("org/webrtc/voiceengine/BuildInfo", DoNotGenerateAcw=true)]
	public sealed partial class BuildInfo : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/webrtc/voiceengine/BuildInfo", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BuildInfo); }
		}

		internal BuildInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='BuildInfo']/constructor[@name='BuildInfo' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BuildInfo ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (BuildInfo)) {
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

		static IntPtr id_getAndroidBuildId;
		public static unsafe string AndroidBuildId {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='BuildInfo']/method[@name='getAndroidBuildId' and count(parameter)=0]"
			[Register ("getAndroidBuildId", "()Ljava/lang/String;", "GetGetAndroidBuildIdHandler")]
			get {
				if (id_getAndroidBuildId == IntPtr.Zero)
					id_getAndroidBuildId = JNIEnv.GetStaticMethodID (class_ref, "getAndroidBuildId", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getAndroidBuildId), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getBrand;
		public static unsafe string Brand {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='BuildInfo']/method[@name='getBrand' and count(parameter)=0]"
			[Register ("getBrand", "()Ljava/lang/String;", "GetGetBrandHandler")]
			get {
				if (id_getBrand == IntPtr.Zero)
					id_getBrand = JNIEnv.GetStaticMethodID (class_ref, "getBrand", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getBrand), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getBuildRelease;
		public static unsafe string BuildRelease {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='BuildInfo']/method[@name='getBuildRelease' and count(parameter)=0]"
			[Register ("getBuildRelease", "()Ljava/lang/String;", "GetGetBuildReleaseHandler")]
			get {
				if (id_getBuildRelease == IntPtr.Zero)
					id_getBuildRelease = JNIEnv.GetStaticMethodID (class_ref, "getBuildRelease", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getBuildRelease), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getBuildType;
		public static unsafe string BuildType {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='BuildInfo']/method[@name='getBuildType' and count(parameter)=0]"
			[Register ("getBuildType", "()Ljava/lang/String;", "GetGetBuildTypeHandler")]
			get {
				if (id_getBuildType == IntPtr.Zero)
					id_getBuildType = JNIEnv.GetStaticMethodID (class_ref, "getBuildType", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getBuildType), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getDevice;
		public static unsafe string Device {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='BuildInfo']/method[@name='getDevice' and count(parameter)=0]"
			[Register ("getDevice", "()Ljava/lang/String;", "GetGetDeviceHandler")]
			get {
				if (id_getDevice == IntPtr.Zero)
					id_getDevice = JNIEnv.GetStaticMethodID (class_ref, "getDevice", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDevice), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getDeviceManufacturer;
		public static unsafe string DeviceManufacturer {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='BuildInfo']/method[@name='getDeviceManufacturer' and count(parameter)=0]"
			[Register ("getDeviceManufacturer", "()Ljava/lang/String;", "GetGetDeviceManufacturerHandler")]
			get {
				if (id_getDeviceManufacturer == IntPtr.Zero)
					id_getDeviceManufacturer = JNIEnv.GetStaticMethodID (class_ref, "getDeviceManufacturer", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDeviceManufacturer), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getDeviceModel;
		public static unsafe string DeviceModel {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='BuildInfo']/method[@name='getDeviceModel' and count(parameter)=0]"
			[Register ("getDeviceModel", "()Ljava/lang/String;", "GetGetDeviceModelHandler")]
			get {
				if (id_getDeviceModel == IntPtr.Zero)
					id_getDeviceModel = JNIEnv.GetStaticMethodID (class_ref, "getDeviceModel", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDeviceModel), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getProduct;
		public static unsafe string Product {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='BuildInfo']/method[@name='getProduct' and count(parameter)=0]"
			[Register ("getProduct", "()Ljava/lang/String;", "GetGetProductHandler")]
			get {
				if (id_getProduct == IntPtr.Zero)
					id_getProduct = JNIEnv.GetStaticMethodID (class_ref, "getProduct", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getProduct), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getSdkVersion;
		public static unsafe string SdkVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc.voiceengine']/class[@name='BuildInfo']/method[@name='getSdkVersion' and count(parameter)=0]"
			[Register ("getSdkVersion", "()Ljava/lang/String;", "GetGetSdkVersionHandler")]
			get {
				if (id_getSdkVersion == IntPtr.Zero)
					id_getSdkVersion = JNIEnv.GetStaticMethodID (class_ref, "getSdkVersion", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getSdkVersion), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
