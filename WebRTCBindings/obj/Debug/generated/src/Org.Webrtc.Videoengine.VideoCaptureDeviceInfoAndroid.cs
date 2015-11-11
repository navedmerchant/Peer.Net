using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Webrtc.Videoengine {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc.videoengine']/class[@name='VideoCaptureDeviceInfoAndroid']"
	[global::Android.Runtime.Register ("org/webrtc/videoengine/VideoCaptureDeviceInfoAndroid", DoNotGenerateAcw=true)]
	public partial class VideoCaptureDeviceInfoAndroid : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/webrtc/videoengine/VideoCaptureDeviceInfoAndroid", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VideoCaptureDeviceInfoAndroid); }
		}

		protected VideoCaptureDeviceInfoAndroid (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc.videoengine']/class[@name='VideoCaptureDeviceInfoAndroid']/constructor[@name='VideoCaptureDeviceInfoAndroid' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe VideoCaptureDeviceInfoAndroid ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (VideoCaptureDeviceInfoAndroid)) {
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
