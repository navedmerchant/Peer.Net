using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Webrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='VideoCapturerAndroid']"
	[global::Android.Runtime.Register ("org/webrtc/VideoCapturerAndroid", DoNotGenerateAcw=true)]
	public partial class VideoCapturerAndroid : global::Org.Webrtc.VideoCapturer, global::Android.Hardware.Camera.IPreviewCallback {

		// Metadata.xml XPath interface reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoCapturerAndroid.CameraErrorHandler']"
		[Register ("org/webrtc/VideoCapturerAndroid$CameraErrorHandler", "", "Org.Webrtc.VideoCapturerAndroid/ICameraErrorHandlerInvoker")]
		public partial interface ICameraErrorHandler : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoCapturerAndroid.CameraErrorHandler']/method[@name='onCameraError' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("onCameraError", "(Ljava/lang/String;)V", "GetOnCameraError_Ljava_lang_String_Handler:Org.Webrtc.VideoCapturerAndroid/ICameraErrorHandlerInvoker, WebRTCBinding")]
			void OnCameraError (string p0);

		}

		[global::Android.Runtime.Register ("org/webrtc/VideoCapturerAndroid$CameraErrorHandler", DoNotGenerateAcw=true)]
		internal class ICameraErrorHandlerInvoker : global::Java.Lang.Object, ICameraErrorHandler {

			static IntPtr java_class_ref = JNIEnv.FindClass ("org/webrtc/VideoCapturerAndroid$CameraErrorHandler");
			IntPtr class_ref;

			public static ICameraErrorHandler GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ICameraErrorHandler> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "org.webrtc.VideoCapturerAndroid.CameraErrorHandler"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ICameraErrorHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ICameraErrorHandlerInvoker); }
			}

			static Delegate cb_onCameraError_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnCameraError_Ljava_lang_String_Handler ()
			{
				if (cb_onCameraError_Ljava_lang_String_ == null)
					cb_onCameraError_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCameraError_Ljava_lang_String_);
				return cb_onCameraError_Ljava_lang_String_;
			}

			static void n_OnCameraError_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Org.Webrtc.VideoCapturerAndroid.ICameraErrorHandler __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoCapturerAndroid.ICameraErrorHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnCameraError (p0);
			}
#pragma warning restore 0169

			IntPtr id_onCameraError_Ljava_lang_String_;
			public unsafe void OnCameraError (string p0)
			{
				if (id_onCameraError_Ljava_lang_String_ == IntPtr.Zero)
					id_onCameraError_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onCameraError", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (Handle, id_onCameraError_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='VideoCapturerAndroid.CameraThread']"
		[global::Android.Runtime.Register ("org/webrtc/VideoCapturerAndroid$CameraThread", DoNotGenerateAcw=true)]
		public partial class CameraThread : global::Java.Lang.Thread {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/webrtc/VideoCapturerAndroid$CameraThread", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (CameraThread); }
			}

			protected CameraThread (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lorg_webrtc_VideoCapturerAndroid_Ljava_util_concurrent_Exchanger_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='VideoCapturerAndroid.CameraThread']/constructor[@name='VideoCapturerAndroid.CameraThread' and count(parameter)=2 and parameter[1][@type='org.webrtc.VideoCapturerAndroid'] and parameter[2][@type='java.util.concurrent.Exchanger&lt;android.os.Handler&gt;']]"
			[Register (".ctor", "(Lorg/webrtc/VideoCapturerAndroid;Ljava/util/concurrent/Exchanger;)V", "")]
			public unsafe CameraThread (global::Org.Webrtc.VideoCapturerAndroid __self, global::Java.Util.Concurrent.Exchanger p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (p0);
					if (GetType () != typeof (CameraThread)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Ljava/util/concurrent/Exchanger;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Ljava/util/concurrent/Exchanger;)V", __args);
						return;
					}

					if (id_ctor_Lorg_webrtc_VideoCapturerAndroid_Ljava_util_concurrent_Exchanger_ == IntPtr.Zero)
						id_ctor_Lorg_webrtc_VideoCapturerAndroid_Ljava_util_concurrent_Exchanger_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/webrtc/VideoCapturerAndroid;Ljava/util/concurrent/Exchanger;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_webrtc_VideoCapturerAndroid_Ljava_util_concurrent_Exchanger_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_webrtc_VideoCapturerAndroid_Ljava_util_concurrent_Exchanger_, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='VideoCapturerAndroid.CaptureFormat']"
		[global::Android.Runtime.Register ("org/webrtc/VideoCapturerAndroid$CaptureFormat", DoNotGenerateAcw=true)]
		public partial class CaptureFormat : global::Java.Lang.Object {


			static IntPtr height_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='VideoCapturerAndroid.CaptureFormat']/field[@name='height']"
			[Register ("height")]
			public int Height {
				get {
					if (height_jfieldId == IntPtr.Zero)
						height_jfieldId = JNIEnv.GetFieldID (class_ref, "height", "I");
					return JNIEnv.GetIntField (Handle, height_jfieldId);
				}
				set {
					if (height_jfieldId == IntPtr.Zero)
						height_jfieldId = JNIEnv.GetFieldID (class_ref, "height", "I");
					try {
						JNIEnv.SetField (Handle, height_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr imageFormat_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='VideoCapturerAndroid.CaptureFormat']/field[@name='imageFormat']"
			[Register ("imageFormat")]
			public int ImageFormat {
				get {
					if (imageFormat_jfieldId == IntPtr.Zero)
						imageFormat_jfieldId = JNIEnv.GetFieldID (class_ref, "imageFormat", "I");
					return JNIEnv.GetIntField (Handle, imageFormat_jfieldId);
				}
				set {
					if (imageFormat_jfieldId == IntPtr.Zero)
						imageFormat_jfieldId = JNIEnv.GetFieldID (class_ref, "imageFormat", "I");
					try {
						JNIEnv.SetField (Handle, imageFormat_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr maxFramerate_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='VideoCapturerAndroid.CaptureFormat']/field[@name='maxFramerate']"
			[Register ("maxFramerate")]
			public int MaxFramerate {
				get {
					if (maxFramerate_jfieldId == IntPtr.Zero)
						maxFramerate_jfieldId = JNIEnv.GetFieldID (class_ref, "maxFramerate", "I");
					return JNIEnv.GetIntField (Handle, maxFramerate_jfieldId);
				}
				set {
					if (maxFramerate_jfieldId == IntPtr.Zero)
						maxFramerate_jfieldId = JNIEnv.GetFieldID (class_ref, "maxFramerate", "I");
					try {
						JNIEnv.SetField (Handle, maxFramerate_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr minFramerate_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='VideoCapturerAndroid.CaptureFormat']/field[@name='minFramerate']"
			[Register ("minFramerate")]
			public int MinFramerate {
				get {
					if (minFramerate_jfieldId == IntPtr.Zero)
						minFramerate_jfieldId = JNIEnv.GetFieldID (class_ref, "minFramerate", "I");
					return JNIEnv.GetIntField (Handle, minFramerate_jfieldId);
				}
				set {
					if (minFramerate_jfieldId == IntPtr.Zero)
						minFramerate_jfieldId = JNIEnv.GetFieldID (class_ref, "minFramerate", "I");
					try {
						JNIEnv.SetField (Handle, minFramerate_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr width_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='VideoCapturerAndroid.CaptureFormat']/field[@name='width']"
			[Register ("width")]
			public int Width {
				get {
					if (width_jfieldId == IntPtr.Zero)
						width_jfieldId = JNIEnv.GetFieldID (class_ref, "width", "I");
					return JNIEnv.GetIntField (Handle, width_jfieldId);
				}
				set {
					if (width_jfieldId == IntPtr.Zero)
						width_jfieldId = JNIEnv.GetFieldID (class_ref, "width", "I");
					try {
						JNIEnv.SetField (Handle, width_jfieldId, value);
					} finally {
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/webrtc/VideoCapturerAndroid$CaptureFormat", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (CaptureFormat); }
			}

			protected CaptureFormat (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_IIII;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='VideoCapturerAndroid.CaptureFormat']/constructor[@name='VideoCapturerAndroid.CaptureFormat' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
			[Register (".ctor", "(IIII)V", "")]
			public unsafe CaptureFormat (int p0, int p1, int p2, int p3)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [4];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					__args [3] = new JValue (p3);
					if (GetType () != typeof (CaptureFormat)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(IIII)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(IIII)V", __args);
						return;
					}

					if (id_ctor_IIII == IntPtr.Zero)
						id_ctor_IIII = JNIEnv.GetMethodID (class_ref, "<init>", "(IIII)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IIII, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_IIII, __args);
				} finally {
				}
			}

			static Delegate cb_frameSize;
#pragma warning disable 0169
			static Delegate GetFrameSizeHandler ()
			{
				if (cb_frameSize == null)
					cb_frameSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_FrameSize);
				return cb_frameSize;
			}

			static int n_FrameSize (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Webrtc.VideoCapturerAndroid.CaptureFormat __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoCapturerAndroid.CaptureFormat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.FrameSize ();
			}
#pragma warning restore 0169

			static IntPtr id_frameSize;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='VideoCapturerAndroid.CaptureFormat']/method[@name='frameSize' and count(parameter)=0]"
			[Register ("frameSize", "()I", "GetFrameSizeHandler")]
			public virtual unsafe int FrameSize ()
			{
				if (id_frameSize == IntPtr.Zero)
					id_frameSize = JNIEnv.GetMethodID (class_ref, "frameSize", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_frameSize);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "frameSize", "()I"));
				} finally {
				}
			}

			static IntPtr id_frameSize_III;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='VideoCapturerAndroid.CaptureFormat']/method[@name='frameSize' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("frameSize", "(III)I", "")]
			public static unsafe int FrameSize (int p0, int p1, int p2)
			{
				if (id_frameSize_III == IntPtr.Zero)
					id_frameSize_III = JNIEnv.GetStaticMethodID (class_ref, "frameSize", "(III)I");
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					return JNIEnv.CallStaticIntMethod  (class_ref, id_frameSize_III, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoCapturerAndroid.CapturerObserver']"
		[Register ("org/webrtc/VideoCapturerAndroid$CapturerObserver", "", "Org.Webrtc.VideoCapturerAndroid/ICapturerObserverInvoker")]
		public partial interface ICapturerObserver : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoCapturerAndroid.CapturerObserver']/method[@name='OnCapturerStarted' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("OnCapturerStarted", "(Z)V", "GetOnCapturerStarted_ZHandler:Org.Webrtc.VideoCapturerAndroid/ICapturerObserverInvoker, WebRTCBinding")]
			void OnCapturerStarted (bool p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoCapturerAndroid.CapturerObserver']/method[@name='OnFrameCaptured' and count(parameter)=6 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='long']]"
			[Register ("OnFrameCaptured", "([BIIIIJ)V", "GetOnFrameCaptured_arrayBIIIIJHandler:Org.Webrtc.VideoCapturerAndroid/ICapturerObserverInvoker, WebRTCBinding")]
			void OnFrameCaptured (byte[] p0, int p1, int p2, int p3, int p4, long p5);

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoCapturerAndroid.CapturerObserver']/method[@name='OnOutputFormatRequest' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("OnOutputFormatRequest", "(III)V", "GetOnOutputFormatRequest_IIIHandler:Org.Webrtc.VideoCapturerAndroid/ICapturerObserverInvoker, WebRTCBinding")]
			void OnOutputFormatRequest (int p0, int p1, int p2);

		}

		[global::Android.Runtime.Register ("org/webrtc/VideoCapturerAndroid$CapturerObserver", DoNotGenerateAcw=true)]
		internal class ICapturerObserverInvoker : global::Java.Lang.Object, ICapturerObserver {

			static IntPtr java_class_ref = JNIEnv.FindClass ("org/webrtc/VideoCapturerAndroid$CapturerObserver");
			IntPtr class_ref;

			public static ICapturerObserver GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ICapturerObserver> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "org.webrtc.VideoCapturerAndroid.CapturerObserver"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ICapturerObserverInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ICapturerObserverInvoker); }
			}

			static Delegate cb_OnCapturerStarted_Z;
#pragma warning disable 0169
			static Delegate GetOnCapturerStarted_ZHandler ()
			{
				if (cb_OnCapturerStarted_Z == null)
					cb_OnCapturerStarted_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_OnCapturerStarted_Z);
				return cb_OnCapturerStarted_Z;
			}

			static void n_OnCapturerStarted_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Org.Webrtc.VideoCapturerAndroid.ICapturerObserver __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoCapturerAndroid.ICapturerObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnCapturerStarted (p0);
			}
#pragma warning restore 0169

			IntPtr id_OnCapturerStarted_Z;
			public unsafe void OnCapturerStarted (bool p0)
			{
				if (id_OnCapturerStarted_Z == IntPtr.Zero)
					id_OnCapturerStarted_Z = JNIEnv.GetMethodID (class_ref, "OnCapturerStarted", "(Z)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (Handle, id_OnCapturerStarted_Z, __args);
			}

			static Delegate cb_OnFrameCaptured_arrayBIIIIJ;
#pragma warning disable 0169
			static Delegate GetOnFrameCaptured_arrayBIIIIJHandler ()
			{
				if (cb_OnFrameCaptured_arrayBIIIIJ == null)
					cb_OnFrameCaptured_arrayBIIIIJ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int, int, int, long>) n_OnFrameCaptured_arrayBIIIIJ);
				return cb_OnFrameCaptured_arrayBIIIIJ;
			}

			static void n_OnFrameCaptured_arrayBIIIIJ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, int p3, int p4, long p5)
			{
				global::Org.Webrtc.VideoCapturerAndroid.ICapturerObserver __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoCapturerAndroid.ICapturerObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				__this.OnFrameCaptured (p0, p1, p2, p3, p4, p5);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
			}
#pragma warning restore 0169

			IntPtr id_OnFrameCaptured_arrayBIIIIJ;
			public unsafe void OnFrameCaptured (byte[] p0, int p1, int p2, int p3, int p4, long p5)
			{
				if (id_OnFrameCaptured_arrayBIIIIJ == IntPtr.Zero)
					id_OnFrameCaptured_arrayBIIIIJ = JNIEnv.GetMethodID (class_ref, "OnFrameCaptured", "([BIIIIJ)V");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				JNIEnv.CallVoidMethod (Handle, id_OnFrameCaptured_arrayBIIIIJ, __args);
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_OnOutputFormatRequest_III;
#pragma warning disable 0169
			static Delegate GetOnOutputFormatRequest_IIIHandler ()
			{
				if (cb_OnOutputFormatRequest_III == null)
					cb_OnOutputFormatRequest_III = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, int>) n_OnOutputFormatRequest_III);
				return cb_OnOutputFormatRequest_III;
			}

			static void n_OnOutputFormatRequest_III (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2)
			{
				global::Org.Webrtc.VideoCapturerAndroid.ICapturerObserver __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoCapturerAndroid.ICapturerObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnOutputFormatRequest (p0, p1, p2);
			}
#pragma warning restore 0169

			IntPtr id_OnOutputFormatRequest_III;
			public unsafe void OnOutputFormatRequest (int p0, int p1, int p2)
			{
				if (id_OnOutputFormatRequest_III == IntPtr.Zero)
					id_OnOutputFormatRequest_III = JNIEnv.GetMethodID (class_ref, "OnOutputFormatRequest", "(III)V");
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod (Handle, id_OnOutputFormatRequest_III, __args);
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='VideoCapturerAndroid.ClosestComparator']"
		[global::Android.Runtime.Register ("org/webrtc/VideoCapturerAndroid$ClosestComparator", DoNotGenerateAcw=true)]
		public abstract partial class ClosestComparator : global::Java.Lang.Object, global::Java.Util.IComparator {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/webrtc/VideoCapturerAndroid$ClosestComparator", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ClosestComparator); }
			}

			protected ClosestComparator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_compare_Ljava_lang_Object_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetCompare_Ljava_lang_Object_Ljava_lang_Object_Handler ()
			{
				if (cb_compare_Ljava_lang_Object_Ljava_lang_Object_ == null)
					cb_compare_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_Compare_Ljava_lang_Object_Ljava_lang_Object_);
				return cb_compare_Ljava_lang_Object_Ljava_lang_Object_;
			}

			static int n_Compare_Ljava_lang_Object_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Org.Webrtc.VideoCapturerAndroid.ClosestComparator __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoCapturerAndroid.ClosestComparator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.Compare (p0, p1);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_compare_Ljava_lang_Object_Ljava_lang_Object_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='VideoCapturerAndroid.ClosestComparator']/method[@name='compare' and count(parameter)=2 and parameter[1][@type='T'] and parameter[2][@type='T']]"
			[Register ("compare", "(Ljava/lang/Object;Ljava/lang/Object;)I", "GetCompare_Ljava_lang_Object_Ljava_lang_Object_Handler")]
			public virtual unsafe int Compare (global::Java.Lang.Object p0, global::Java.Lang.Object p1)
			{
				if (id_compare_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
					id_compare_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "compare", "(Ljava/lang/Object;Ljava/lang/Object;)I");
				IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
				IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (native_p1);

					int __ret;
					if (GetType () == ThresholdType)
						__ret = JNIEnv.CallIntMethod  (Handle, id_compare_Ljava_lang_Object_Ljava_lang_Object_, __args);
					else
						__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "compare", "(Ljava/lang/Object;Ljava/lang/Object;)I"), __args);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

		}

		[global::Android.Runtime.Register ("org/webrtc/VideoCapturerAndroid$ClosestComparator", DoNotGenerateAcw=true)]
		internal partial class ClosestComparatorInvoker : ClosestComparator {

			public ClosestComparatorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			protected override global::System.Type ThresholdType {
				get { return typeof (ClosestComparatorInvoker); }
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='VideoCapturerAndroid.FramePool']"
		[global::Android.Runtime.Register ("org/webrtc/VideoCapturerAndroid$FramePool", DoNotGenerateAcw=true)]
		public partial class FramePool : global::Java.Lang.Object {

			protected FramePool (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='VideoCapturerAndroid.NativeObserver']"
		[global::Android.Runtime.Register ("org/webrtc/VideoCapturerAndroid$NativeObserver", DoNotGenerateAcw=true)]
		public partial class NativeObserver : global::Java.Lang.Object, global::Org.Webrtc.VideoCapturerAndroid.ICapturerObserver {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/webrtc/VideoCapturerAndroid$NativeObserver", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (NativeObserver); }
			}

			protected NativeObserver (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_J;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='VideoCapturerAndroid.NativeObserver']/constructor[@name='VideoCapturerAndroid.NativeObserver' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register (".ctor", "(J)V", "")]
			public unsafe NativeObserver (long p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (GetType () != typeof (NativeObserver)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(J)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(J)V", __args);
						return;
					}

					if (id_ctor_J == IntPtr.Zero)
						id_ctor_J = JNIEnv.GetMethodID (class_ref, "<init>", "(J)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_J, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_J, __args);
				} finally {
				}
			}

			static Delegate cb_OnCapturerStarted_Z;
#pragma warning disable 0169
			static Delegate GetOnCapturerStarted_ZHandler ()
			{
				if (cb_OnCapturerStarted_Z == null)
					cb_OnCapturerStarted_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_OnCapturerStarted_Z);
				return cb_OnCapturerStarted_Z;
			}

			static void n_OnCapturerStarted_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Org.Webrtc.VideoCapturerAndroid.NativeObserver __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoCapturerAndroid.NativeObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnCapturerStarted (p0);
			}
#pragma warning restore 0169

			static IntPtr id_OnCapturerStarted_Z;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='VideoCapturerAndroid.NativeObserver']/method[@name='OnCapturerStarted' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("OnCapturerStarted", "(Z)V", "GetOnCapturerStarted_ZHandler")]
			public virtual unsafe void OnCapturerStarted (bool p0)
			{
				if (id_OnCapturerStarted_Z == IntPtr.Zero)
					id_OnCapturerStarted_Z = JNIEnv.GetMethodID (class_ref, "OnCapturerStarted", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_OnCapturerStarted_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnCapturerStarted", "(Z)V"), __args);
				} finally {
				}
			}

			static Delegate cb_OnFrameCaptured_arrayBIIIIJ;
#pragma warning disable 0169
			static Delegate GetOnFrameCaptured_arrayBIIIIJHandler ()
			{
				if (cb_OnFrameCaptured_arrayBIIIIJ == null)
					cb_OnFrameCaptured_arrayBIIIIJ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int, int, int, long>) n_OnFrameCaptured_arrayBIIIIJ);
				return cb_OnFrameCaptured_arrayBIIIIJ;
			}

			static void n_OnFrameCaptured_arrayBIIIIJ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, int p3, int p4, long p5)
			{
				global::Org.Webrtc.VideoCapturerAndroid.NativeObserver __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoCapturerAndroid.NativeObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				__this.OnFrameCaptured (p0, p1, p2, p3, p4, p5);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
			}
#pragma warning restore 0169

			static IntPtr id_OnFrameCaptured_arrayBIIIIJ;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='VideoCapturerAndroid.NativeObserver']/method[@name='OnFrameCaptured' and count(parameter)=6 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='long']]"
			[Register ("OnFrameCaptured", "([BIIIIJ)V", "GetOnFrameCaptured_arrayBIIIIJHandler")]
			public virtual unsafe void OnFrameCaptured (byte[] p0, int p1, int p2, int p3, int p4, long p5)
			{
				if (id_OnFrameCaptured_arrayBIIIIJ == IntPtr.Zero)
					id_OnFrameCaptured_arrayBIIIIJ = JNIEnv.GetMethodID (class_ref, "OnFrameCaptured", "([BIIIIJ)V");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				try {
					JValue* __args = stackalloc JValue [6];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					__args [3] = new JValue (p3);
					__args [4] = new JValue (p4);
					__args [5] = new JValue (p5);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_OnFrameCaptured_arrayBIIIIJ, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnFrameCaptured", "([BIIIIJ)V"), __args);
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
				}
			}

			static Delegate cb_OnOutputFormatRequest_III;
#pragma warning disable 0169
			static Delegate GetOnOutputFormatRequest_IIIHandler ()
			{
				if (cb_OnOutputFormatRequest_III == null)
					cb_OnOutputFormatRequest_III = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, int>) n_OnOutputFormatRequest_III);
				return cb_OnOutputFormatRequest_III;
			}

			static void n_OnOutputFormatRequest_III (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2)
			{
				global::Org.Webrtc.VideoCapturerAndroid.NativeObserver __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoCapturerAndroid.NativeObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnOutputFormatRequest (p0, p1, p2);
			}
#pragma warning restore 0169

			static IntPtr id_OnOutputFormatRequest_III;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='VideoCapturerAndroid.NativeObserver']/method[@name='OnOutputFormatRequest' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("OnOutputFormatRequest", "(III)V", "GetOnOutputFormatRequest_IIIHandler")]
			public virtual unsafe void OnOutputFormatRequest (int p0, int p1, int p2)
			{
				if (id_OnOutputFormatRequest_III == IntPtr.Zero)
					id_OnOutputFormatRequest_III = JNIEnv.GetMethodID (class_ref, "OnOutputFormatRequest", "(III)V");
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_OnOutputFormatRequest_III, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "OnOutputFormatRequest", "(III)V"), __args);
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/webrtc/VideoCapturerAndroid", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VideoCapturerAndroid); }
		}

		protected VideoCapturerAndroid (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getDeviceCount;
		public static unsafe int DeviceCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='VideoCapturerAndroid']/method[@name='getDeviceCount' and count(parameter)=0]"
			[Register ("getDeviceCount", "()I", "GetGetDeviceCountHandler")]
			get {
				if (id_getDeviceCount == IntPtr.Zero)
					id_getDeviceCount = JNIEnv.GetStaticMethodID (class_ref, "getDeviceCount", "()I");
				try {
					return JNIEnv.CallStaticIntMethod  (class_ref, id_getDeviceCount);
				} finally {
				}
			}
		}

		static IntPtr id_getNameOfBackFacingDevice;
		public static unsafe string NameOfBackFacingDevice {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='VideoCapturerAndroid']/method[@name='getNameOfBackFacingDevice' and count(parameter)=0]"
			[Register ("getNameOfBackFacingDevice", "()Ljava/lang/String;", "GetGetNameOfBackFacingDeviceHandler")]
			get {
				if (id_getNameOfBackFacingDevice == IntPtr.Zero)
					id_getNameOfBackFacingDevice = JNIEnv.GetStaticMethodID (class_ref, "getNameOfBackFacingDevice", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getNameOfBackFacingDevice), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getNameOfFrontFacingDevice;
		public static unsafe string NameOfFrontFacingDevice {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='VideoCapturerAndroid']/method[@name='getNameOfFrontFacingDevice' and count(parameter)=0]"
			[Register ("getNameOfFrontFacingDevice", "()Ljava/lang/String;", "GetGetNameOfFrontFacingDeviceHandler")]
			get {
				if (id_getNameOfFrontFacingDevice == IntPtr.Zero)
					id_getNameOfFrontFacingDevice = JNIEnv.GetStaticMethodID (class_ref, "getNameOfFrontFacingDevice", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getNameOfFrontFacingDevice), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSupportedFormats;
#pragma warning disable 0169
		static Delegate GetGetSupportedFormatsHandler ()
		{
			if (cb_getSupportedFormats == null)
				cb_getSupportedFormats = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSupportedFormats);
			return cb_getSupportedFormats;
		}

		static IntPtr n_GetSupportedFormats (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.VideoCapturerAndroid __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoCapturerAndroid> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Org.Webrtc.VideoCapturerAndroid.CaptureFormat>.ToLocalJniHandle (__this.SupportedFormats);
		}
#pragma warning restore 0169

		static IntPtr id_getSupportedFormats;
		public virtual unsafe global::System.Collections.Generic.IList<global::Org.Webrtc.VideoCapturerAndroid.CaptureFormat> SupportedFormats {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='VideoCapturerAndroid']/method[@name='getSupportedFormats' and count(parameter)=0]"
			[Register ("getSupportedFormats", "()Ljava/util/List;", "GetGetSupportedFormatsHandler")]
			get {
				if (id_getSupportedFormats == IntPtr.Zero)
					id_getSupportedFormats = JNIEnv.GetMethodID (class_ref, "getSupportedFormats", "()Ljava/util/List;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Org.Webrtc.VideoCapturerAndroid.CaptureFormat>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getSupportedFormats), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Org.Webrtc.VideoCapturerAndroid.CaptureFormat>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSupportedFormats", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_changeCaptureFormat_III;
#pragma warning disable 0169
		static Delegate GetChangeCaptureFormat_IIIHandler ()
		{
			if (cb_changeCaptureFormat_III == null)
				cb_changeCaptureFormat_III = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, int>) n_ChangeCaptureFormat_III);
			return cb_changeCaptureFormat_III;
		}

		static void n_ChangeCaptureFormat_III (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2)
		{
			global::Org.Webrtc.VideoCapturerAndroid __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoCapturerAndroid> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ChangeCaptureFormat (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_changeCaptureFormat_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='VideoCapturerAndroid']/method[@name='changeCaptureFormat' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("changeCaptureFormat", "(III)V", "GetChangeCaptureFormat_IIIHandler")]
		public virtual unsafe void ChangeCaptureFormat (int p0, int p1, int p2)
		{
			if (id_changeCaptureFormat_III == IntPtr.Zero)
				id_changeCaptureFormat_III = JNIEnv.GetMethodID (class_ref, "changeCaptureFormat", "(III)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_changeCaptureFormat_III, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "changeCaptureFormat", "(III)V"), __args);
			} finally {
			}
		}

		static IntPtr id_create_Ljava_lang_String_Lorg_webrtc_VideoCapturerAndroid_CameraErrorHandler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='VideoCapturerAndroid']/method[@name='create' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.webrtc.VideoCapturerAndroid.CameraErrorHandler']]"
		[Register ("create", "(Ljava/lang/String;Lorg/webrtc/VideoCapturerAndroid$CameraErrorHandler;)Lorg/webrtc/VideoCapturerAndroid;", "")]
		public static unsafe global::Org.Webrtc.VideoCapturerAndroid Create (string p0, global::Org.Webrtc.VideoCapturerAndroid.ICameraErrorHandler p1)
		{
			if (id_create_Ljava_lang_String_Lorg_webrtc_VideoCapturerAndroid_CameraErrorHandler_ == IntPtr.Zero)
				id_create_Ljava_lang_String_Lorg_webrtc_VideoCapturerAndroid_CameraErrorHandler_ = JNIEnv.GetStaticMethodID (class_ref, "create", "(Ljava/lang/String;Lorg/webrtc/VideoCapturerAndroid$CameraErrorHandler;)Lorg/webrtc/VideoCapturerAndroid;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				global::Org.Webrtc.VideoCapturerAndroid __ret = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoCapturerAndroid> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_Ljava_lang_String_Lorg_webrtc_VideoCapturerAndroid_CameraErrorHandler_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getDeviceName_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='VideoCapturerAndroid']/method[@name='getDeviceName' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getDeviceName", "(I)Ljava/lang/String;", "")]
		public static unsafe string GetDeviceName (int p0)
		{
			if (id_getDeviceName_I == IntPtr.Zero)
				id_getDeviceName_I = JNIEnv.GetStaticMethodID (class_ref, "getDeviceName", "(I)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDeviceName_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_getDeviceNames;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='VideoCapturerAndroid']/method[@name='getDeviceNames' and count(parameter)=0]"
		[Register ("getDeviceNames", "()[Ljava/lang/String;", "")]
		public static unsafe string[] GetDeviceNames ()
		{
			if (id_getDeviceNames == IntPtr.Zero)
				id_getDeviceNames = JNIEnv.GetStaticMethodID (class_ref, "getDeviceNames", "()[Ljava/lang/String;");
			try {
				return (string[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDeviceNames), JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

		static Delegate cb_onOutputFormatRequest_III;
#pragma warning disable 0169
		static Delegate GetOnOutputFormatRequest_IIIHandler ()
		{
			if (cb_onOutputFormatRequest_III == null)
				cb_onOutputFormatRequest_III = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, int>) n_OnOutputFormatRequest_III);
			return cb_onOutputFormatRequest_III;
		}

		static void n_OnOutputFormatRequest_III (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2)
		{
			global::Org.Webrtc.VideoCapturerAndroid __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoCapturerAndroid> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnOutputFormatRequest (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_onOutputFormatRequest_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='VideoCapturerAndroid']/method[@name='onOutputFormatRequest' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("onOutputFormatRequest", "(III)V", "GetOnOutputFormatRequest_IIIHandler")]
		public virtual unsafe void OnOutputFormatRequest (int p0, int p1, int p2)
		{
			if (id_onOutputFormatRequest_III == IntPtr.Zero)
				id_onOutputFormatRequest_III = JNIEnv.GetMethodID (class_ref, "onOutputFormatRequest", "(III)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onOutputFormatRequest_III, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onOutputFormatRequest", "(III)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onPreviewFrame_arrayBLandroid_hardware_Camera_;
#pragma warning disable 0169
		static Delegate GetOnPreviewFrame_arrayBLandroid_hardware_Camera_Handler ()
		{
			if (cb_onPreviewFrame_arrayBLandroid_hardware_Camera_ == null)
				cb_onPreviewFrame_arrayBLandroid_hardware_Camera_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnPreviewFrame_arrayBLandroid_hardware_Camera_);
			return cb_onPreviewFrame_arrayBLandroid_hardware_Camera_;
		}

		static void n_OnPreviewFrame_arrayBLandroid_hardware_Camera_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Webrtc.VideoCapturerAndroid __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoCapturerAndroid> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			global::Android.Hardware.Camera p1 = global::Java.Lang.Object.GetObject<global::Android.Hardware.Camera> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnPreviewFrame (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_onPreviewFrame_arrayBLandroid_hardware_Camera_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='VideoCapturerAndroid']/method[@name='onPreviewFrame' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='android.hardware.Camera']]"
		[Register ("onPreviewFrame", "([BLandroid/hardware/Camera;)V", "GetOnPreviewFrame_arrayBLandroid_hardware_Camera_Handler")]
		public virtual unsafe void OnPreviewFrame (byte[] p0, global::Android.Hardware.Camera p1)
		{
			if (id_onPreviewFrame_arrayBLandroid_hardware_Camera_ == IntPtr.Zero)
				id_onPreviewFrame_arrayBLandroid_hardware_Camera_ = JNIEnv.GetMethodID (class_ref, "onPreviewFrame", "([BLandroid/hardware/Camera;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onPreviewFrame_arrayBLandroid_hardware_Camera_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPreviewFrame", "([BLandroid/hardware/Camera;)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_switchCamera_Ljava_lang_Runnable_;
#pragma warning disable 0169
		static Delegate GetSwitchCamera_Ljava_lang_Runnable_Handler ()
		{
			if (cb_switchCamera_Ljava_lang_Runnable_ == null)
				cb_switchCamera_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_SwitchCamera_Ljava_lang_Runnable_);
			return cb_switchCamera_Ljava_lang_Runnable_;
		}

		static bool n_SwitchCamera_Ljava_lang_Runnable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Webrtc.VideoCapturerAndroid __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoCapturerAndroid> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IRunnable p0 = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SwitchCamera (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_switchCamera_Ljava_lang_Runnable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='VideoCapturerAndroid']/method[@name='switchCamera' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register ("switchCamera", "(Ljava/lang/Runnable;)Z", "GetSwitchCamera_Ljava_lang_Runnable_Handler")]
		public virtual unsafe bool SwitchCamera (global::Java.Lang.IRunnable p0)
		{
			if (id_switchCamera_Ljava_lang_Runnable_ == IntPtr.Zero)
				id_switchCamera_Ljava_lang_Runnable_ = JNIEnv.GetMethodID (class_ref, "switchCamera", "(Ljava/lang/Runnable;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_switchCamera_Ljava_lang_Runnable_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "switchCamera", "(Ljava/lang/Runnable;)Z"), __args);
				return __ret;
			} finally {
			}
		}

	}
}
