using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Webrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='VideoRenderer']"
	[global::Android.Runtime.Register ("org/webrtc/VideoRenderer", DoNotGenerateAcw=true)]
	public partial class VideoRenderer : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoRenderer.Callbacks']"
		[Register ("org/webrtc/VideoRenderer$Callbacks", "", "Org.Webrtc.VideoRenderer/ICallbacksInvoker")]
		public partial interface ICallbacks : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoRenderer.Callbacks']/method[@name='canApplyRotation' and count(parameter)=0]"
			[Register ("canApplyRotation", "()Z", "GetCanApplyRotationHandler:Org.Webrtc.VideoRenderer/ICallbacksInvoker, WebRTCBinding")]
			bool CanApplyRotation ();

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='VideoRenderer.Callbacks']/method[@name='renderFrame' and count(parameter)=1 and parameter[1][@type='org.webrtc.VideoRenderer.I420Frame']]"
			[Register ("renderFrame", "(Lorg/webrtc/VideoRenderer$I420Frame;)V", "GetRenderFrame_Lorg_webrtc_VideoRenderer_I420Frame_Handler:Org.Webrtc.VideoRenderer/ICallbacksInvoker, WebRTCBinding")]
			void RenderFrame (global::Org.Webrtc.VideoRenderer.I420Frame p0);

		}

		[global::Android.Runtime.Register ("org/webrtc/VideoRenderer$Callbacks", DoNotGenerateAcw=true)]
		internal class ICallbacksInvoker : global::Java.Lang.Object, ICallbacks {

			static IntPtr java_class_ref = JNIEnv.FindClass ("org/webrtc/VideoRenderer$Callbacks");
			IntPtr class_ref;

			public static ICallbacks GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ICallbacks> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "org.webrtc.VideoRenderer.Callbacks"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ICallbacksInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ICallbacksInvoker); }
			}

			static Delegate cb_canApplyRotation;
#pragma warning disable 0169
			static Delegate GetCanApplyRotationHandler ()
			{
				if (cb_canApplyRotation == null)
					cb_canApplyRotation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_CanApplyRotation);
				return cb_canApplyRotation;
			}

			static bool n_CanApplyRotation (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Webrtc.VideoRenderer.ICallbacks __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoRenderer.ICallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.CanApplyRotation ();
			}
#pragma warning restore 0169

			IntPtr id_canApplyRotation;
			public unsafe bool CanApplyRotation ()
			{
				if (id_canApplyRotation == IntPtr.Zero)
					id_canApplyRotation = JNIEnv.GetMethodID (class_ref, "canApplyRotation", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_canApplyRotation);
			}

			static Delegate cb_renderFrame_Lorg_webrtc_VideoRenderer_I420Frame_;
#pragma warning disable 0169
			static Delegate GetRenderFrame_Lorg_webrtc_VideoRenderer_I420Frame_Handler ()
			{
				if (cb_renderFrame_Lorg_webrtc_VideoRenderer_I420Frame_ == null)
					cb_renderFrame_Lorg_webrtc_VideoRenderer_I420Frame_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RenderFrame_Lorg_webrtc_VideoRenderer_I420Frame_);
				return cb_renderFrame_Lorg_webrtc_VideoRenderer_I420Frame_;
			}

			static void n_RenderFrame_Lorg_webrtc_VideoRenderer_I420Frame_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Org.Webrtc.VideoRenderer.ICallbacks __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoRenderer.ICallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Webrtc.VideoRenderer.I420Frame p0 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoRenderer.I420Frame> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.RenderFrame (p0);
			}
#pragma warning restore 0169

			IntPtr id_renderFrame_Lorg_webrtc_VideoRenderer_I420Frame_;
			public unsafe void RenderFrame (global::Org.Webrtc.VideoRenderer.I420Frame p0)
			{
				if (id_renderFrame_Lorg_webrtc_VideoRenderer_I420Frame_ == IntPtr.Zero)
					id_renderFrame_Lorg_webrtc_VideoRenderer_I420Frame_ = JNIEnv.GetMethodID (class_ref, "renderFrame", "(Lorg/webrtc/VideoRenderer$I420Frame;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (Handle, id_renderFrame_Lorg_webrtc_VideoRenderer_I420Frame_, __args);
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='VideoRenderer.I420Frame']"
		[global::Android.Runtime.Register ("org/webrtc/VideoRenderer$I420Frame", DoNotGenerateAcw=true)]
		public partial class I420Frame : global::Java.Lang.Object {


			static IntPtr height_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='VideoRenderer.I420Frame']/field[@name='height']"
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

			static IntPtr rotationDegree_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='VideoRenderer.I420Frame']/field[@name='rotationDegree']"
			[Register ("rotationDegree")]
			public int RotationDegree {
				get {
					if (rotationDegree_jfieldId == IntPtr.Zero)
						rotationDegree_jfieldId = JNIEnv.GetFieldID (class_ref, "rotationDegree", "I");
					return JNIEnv.GetIntField (Handle, rotationDegree_jfieldId);
				}
				set {
					if (rotationDegree_jfieldId == IntPtr.Zero)
						rotationDegree_jfieldId = JNIEnv.GetFieldID (class_ref, "rotationDegree", "I");
					try {
						JNIEnv.SetField (Handle, rotationDegree_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr textureId_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='VideoRenderer.I420Frame']/field[@name='textureId']"
			[Register ("textureId")]
			public int TextureId {
				get {
					if (textureId_jfieldId == IntPtr.Zero)
						textureId_jfieldId = JNIEnv.GetFieldID (class_ref, "textureId", "I");
					return JNIEnv.GetIntField (Handle, textureId_jfieldId);
				}
				set {
					if (textureId_jfieldId == IntPtr.Zero)
						textureId_jfieldId = JNIEnv.GetFieldID (class_ref, "textureId", "I");
					try {
						JNIEnv.SetField (Handle, textureId_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr textureObject_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='VideoRenderer.I420Frame']/field[@name='textureObject']"
			[Register ("textureObject")]
			public global::Java.Lang.Object TextureObject {
				get {
					if (textureObject_jfieldId == IntPtr.Zero)
						textureObject_jfieldId = JNIEnv.GetFieldID (class_ref, "textureObject", "Ljava/lang/Object;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, textureObject_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (textureObject_jfieldId == IntPtr.Zero)
						textureObject_jfieldId = JNIEnv.GetFieldID (class_ref, "textureObject", "Ljava/lang/Object;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (Handle, textureObject_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr width_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='VideoRenderer.I420Frame']/field[@name='width']"
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

			static IntPtr yuvFrame_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='VideoRenderer.I420Frame']/field[@name='yuvFrame']"
			[Register ("yuvFrame")]
			public bool YuvFrame {
				get {
					if (yuvFrame_jfieldId == IntPtr.Zero)
						yuvFrame_jfieldId = JNIEnv.GetFieldID (class_ref, "yuvFrame", "Z");
					return JNIEnv.GetBooleanField (Handle, yuvFrame_jfieldId);
				}
				set {
					if (yuvFrame_jfieldId == IntPtr.Zero)
						yuvFrame_jfieldId = JNIEnv.GetFieldID (class_ref, "yuvFrame", "Z");
					try {
						JNIEnv.SetField (Handle, yuvFrame_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr yuvPlanes_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='VideoRenderer.I420Frame']/field[@name='yuvPlanes']"
			[Register ("yuvPlanes")]
			public IList<Java.Nio.ByteBuffer> YuvPlanes {
				get {
					if (yuvPlanes_jfieldId == IntPtr.Zero)
						yuvPlanes_jfieldId = JNIEnv.GetFieldID (class_ref, "yuvPlanes", "[Ljava/nio/ByteBuffer;");
					return JavaArray<global::Java.Nio.ByteBuffer>.FromJniHandle (JNIEnv.GetObjectField (Handle, yuvPlanes_jfieldId), JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (yuvPlanes_jfieldId == IntPtr.Zero)
						yuvPlanes_jfieldId = JNIEnv.GetFieldID (class_ref, "yuvPlanes", "[Ljava/nio/ByteBuffer;");
					IntPtr native_value = JavaArray<global::Java.Nio.ByteBuffer>.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (Handle, yuvPlanes_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr yuvStrides_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='VideoRenderer.I420Frame']/field[@name='yuvStrides']"
			[Register ("yuvStrides")]
			public IList<int> YuvStrides {
				get {
					if (yuvStrides_jfieldId == IntPtr.Zero)
						yuvStrides_jfieldId = JNIEnv.GetFieldID (class_ref, "yuvStrides", "[I");
					return JavaArray<int>.FromJniHandle (JNIEnv.GetObjectField (Handle, yuvStrides_jfieldId), JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (yuvStrides_jfieldId == IntPtr.Zero)
						yuvStrides_jfieldId = JNIEnv.GetFieldID (class_ref, "yuvStrides", "[I");
					IntPtr native_value = JavaArray<int>.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (Handle, yuvStrides_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/webrtc/VideoRenderer$I420Frame", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (I420Frame); }
			}

			protected I420Frame (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_IIIarrayIarrayLjava_nio_ByteBuffer_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='VideoRenderer.I420Frame']/constructor[@name='VideoRenderer.I420Frame' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int[]'] and parameter[5][@type='java.nio.ByteBuffer[]']]"
			[Register (".ctor", "(III[I[Ljava/nio/ByteBuffer;)V", "")]
			public unsafe I420Frame (int p0, int p1, int p2, int[] p3, global::Java.Nio.ByteBuffer[] p4)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p3 = JNIEnv.NewArray (p3);
				IntPtr native_p4 = JNIEnv.NewArray (p4);
				try {
					JValue* __args = stackalloc JValue [5];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					__args [3] = new JValue (native_p3);
					__args [4] = new JValue (native_p4);
					if (GetType () != typeof (I420Frame)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(III[I[Ljava/nio/ByteBuffer;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(III[I[Ljava/nio/ByteBuffer;)V", __args);
						return;
					}

					if (id_ctor_IIIarrayIarrayLjava_nio_ByteBuffer_ == IntPtr.Zero)
						id_ctor_IIIarrayIarrayLjava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "<init>", "(III[I[Ljava/nio/ByteBuffer;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IIIarrayIarrayLjava_nio_ByteBuffer_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_IIIarrayIarrayLjava_nio_ByteBuffer_, __args);
				} finally {
					if (p3 != null) {
						JNIEnv.CopyArray (native_p3, p3);
						JNIEnv.DeleteLocalRef (native_p3);
					}
					if (p4 != null) {
						JNIEnv.CopyArray (native_p4, p4);
						JNIEnv.DeleteLocalRef (native_p4);
					}
				}
			}

			static IntPtr id_ctor_IIILjava_lang_Object_I;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='VideoRenderer.I420Frame']/constructor[@name='VideoRenderer.I420Frame' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.Object'] and parameter[5][@type='int']]"
			[Register (".ctor", "(IIILjava/lang/Object;I)V", "")]
			public unsafe I420Frame (int p0, int p1, int p2, global::Java.Lang.Object p3, int p4)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [5];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					__args [3] = new JValue (p3);
					__args [4] = new JValue (p4);
					if (GetType () != typeof (I420Frame)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(IIILjava/lang/Object;I)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(IIILjava/lang/Object;I)V", __args);
						return;
					}

					if (id_ctor_IIILjava_lang_Object_I == IntPtr.Zero)
						id_ctor_IIILjava_lang_Object_I = JNIEnv.GetMethodID (class_ref, "<init>", "(IIILjava/lang/Object;I)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IIILjava_lang_Object_I, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_IIILjava_lang_Object_I, __args);
				} finally {
				}
			}

			static Delegate cb_copyFrom_arrayBI;
#pragma warning disable 0169
			static Delegate GetCopyFrom_arrayBIHandler ()
			{
				if (cb_copyFrom_arrayBI == null)
					cb_copyFrom_arrayBI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_CopyFrom_arrayBI);
				return cb_copyFrom_arrayBI;
			}

			static IntPtr n_CopyFrom_arrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
			{
				global::Org.Webrtc.VideoRenderer.I420Frame __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoRenderer.I420Frame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CopyFrom (p0, p1));
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_copyFrom_arrayBI;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='VideoRenderer.I420Frame']/method[@name='copyFrom' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
			[Register ("copyFrom", "([BI)Lorg/webrtc/VideoRenderer$I420Frame;", "GetCopyFrom_arrayBIHandler")]
			public virtual unsafe global::Org.Webrtc.VideoRenderer.I420Frame CopyFrom (byte[] p0, int p1)
			{
				if (id_copyFrom_arrayBI == IntPtr.Zero)
					id_copyFrom_arrayBI = JNIEnv.GetMethodID (class_ref, "copyFrom", "([BI)Lorg/webrtc/VideoRenderer$I420Frame;");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (p1);

					global::Org.Webrtc.VideoRenderer.I420Frame __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoRenderer.I420Frame> (JNIEnv.CallObjectMethod  (Handle, id_copyFrom_arrayBI, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoRenderer.I420Frame> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "copyFrom", "([BI)Lorg/webrtc/VideoRenderer$I420Frame;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
				}
			}

			static Delegate cb_copyFrom_Lorg_webrtc_VideoRenderer_I420Frame_;
#pragma warning disable 0169
			static Delegate GetCopyFrom_Lorg_webrtc_VideoRenderer_I420Frame_Handler ()
			{
				if (cb_copyFrom_Lorg_webrtc_VideoRenderer_I420Frame_ == null)
					cb_copyFrom_Lorg_webrtc_VideoRenderer_I420Frame_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CopyFrom_Lorg_webrtc_VideoRenderer_I420Frame_);
				return cb_copyFrom_Lorg_webrtc_VideoRenderer_I420Frame_;
			}

			static IntPtr n_CopyFrom_Lorg_webrtc_VideoRenderer_I420Frame_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Org.Webrtc.VideoRenderer.I420Frame __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoRenderer.I420Frame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Webrtc.VideoRenderer.I420Frame p0 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoRenderer.I420Frame> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CopyFrom (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_copyFrom_Lorg_webrtc_VideoRenderer_I420Frame_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='VideoRenderer.I420Frame']/method[@name='copyFrom' and count(parameter)=1 and parameter[1][@type='org.webrtc.VideoRenderer.I420Frame']]"
			[Register ("copyFrom", "(Lorg/webrtc/VideoRenderer$I420Frame;)Lorg/webrtc/VideoRenderer$I420Frame;", "GetCopyFrom_Lorg_webrtc_VideoRenderer_I420Frame_Handler")]
			public virtual unsafe global::Org.Webrtc.VideoRenderer.I420Frame CopyFrom (global::Org.Webrtc.VideoRenderer.I420Frame p0)
			{
				if (id_copyFrom_Lorg_webrtc_VideoRenderer_I420Frame_ == IntPtr.Zero)
					id_copyFrom_Lorg_webrtc_VideoRenderer_I420Frame_ = JNIEnv.GetMethodID (class_ref, "copyFrom", "(Lorg/webrtc/VideoRenderer$I420Frame;)Lorg/webrtc/VideoRenderer$I420Frame;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Org.Webrtc.VideoRenderer.I420Frame __ret;
					if (GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoRenderer.I420Frame> (JNIEnv.CallObjectMethod  (Handle, id_copyFrom_Lorg_webrtc_VideoRenderer_I420Frame_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoRenderer.I420Frame> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "copyFrom", "(Lorg/webrtc/VideoRenderer$I420Frame;)Lorg/webrtc/VideoRenderer$I420Frame;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_rotatedHeight;
#pragma warning disable 0169
			static Delegate GetRotatedHeightHandler ()
			{
				if (cb_rotatedHeight == null)
					cb_rotatedHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_RotatedHeight);
				return cb_rotatedHeight;
			}

			static int n_RotatedHeight (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Webrtc.VideoRenderer.I420Frame __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoRenderer.I420Frame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.RotatedHeight ();
			}
#pragma warning restore 0169

			static IntPtr id_rotatedHeight;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='VideoRenderer.I420Frame']/method[@name='rotatedHeight' and count(parameter)=0]"
			[Register ("rotatedHeight", "()I", "GetRotatedHeightHandler")]
			public virtual unsafe int RotatedHeight ()
			{
				if (id_rotatedHeight == IntPtr.Zero)
					id_rotatedHeight = JNIEnv.GetMethodID (class_ref, "rotatedHeight", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_rotatedHeight);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "rotatedHeight", "()I"));
				} finally {
				}
			}

			static Delegate cb_rotatedWidth;
#pragma warning disable 0169
			static Delegate GetRotatedWidthHandler ()
			{
				if (cb_rotatedWidth == null)
					cb_rotatedWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_RotatedWidth);
				return cb_rotatedWidth;
			}

			static int n_RotatedWidth (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Webrtc.VideoRenderer.I420Frame __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoRenderer.I420Frame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.RotatedWidth ();
			}
#pragma warning restore 0169

			static IntPtr id_rotatedWidth;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='VideoRenderer.I420Frame']/method[@name='rotatedWidth' and count(parameter)=0]"
			[Register ("rotatedWidth", "()I", "GetRotatedWidthHandler")]
			public virtual unsafe int RotatedWidth ()
			{
				if (id_rotatedWidth == IntPtr.Zero)
					id_rotatedWidth = JNIEnv.GetMethodID (class_ref, "rotatedWidth", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_rotatedWidth);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "rotatedWidth", "()I"));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/webrtc/VideoRenderer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VideoRenderer); }
		}

		protected VideoRenderer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_webrtc_VideoRenderer_Callbacks_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='VideoRenderer']/constructor[@name='VideoRenderer' and count(parameter)=1 and parameter[1][@type='org.webrtc.VideoRenderer.Callbacks']]"
		[Register (".ctor", "(Lorg/webrtc/VideoRenderer$Callbacks;)V", "")]
		public unsafe VideoRenderer (global::Org.Webrtc.VideoRenderer.ICallbacks p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (VideoRenderer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/webrtc/VideoRenderer$Callbacks;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/webrtc/VideoRenderer$Callbacks;)V", __args);
					return;
				}

				if (id_ctor_Lorg_webrtc_VideoRenderer_Callbacks_ == IntPtr.Zero)
					id_ctor_Lorg_webrtc_VideoRenderer_Callbacks_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/webrtc/VideoRenderer$Callbacks;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_webrtc_VideoRenderer_Callbacks_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_webrtc_VideoRenderer_Callbacks_, __args);
			} finally {
			}
		}

		static IntPtr id_createGui_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='VideoRenderer']/method[@name='createGui' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("createGui", "(II)Lorg/webrtc/VideoRenderer;", "")]
		public static unsafe global::Org.Webrtc.VideoRenderer CreateGui (int p0, int p1)
		{
			if (id_createGui_II == IntPtr.Zero)
				id_createGui_II = JNIEnv.GetStaticMethodID (class_ref, "createGui", "(II)Lorg/webrtc/VideoRenderer;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoRenderer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createGui_II, __args), JniHandleOwnership.TransferLocalRef);
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
			global::Org.Webrtc.VideoRenderer __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dispose ();
		}
#pragma warning restore 0169

		static IntPtr id_dispose;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='VideoRenderer']/method[@name='dispose' and count(parameter)=0]"
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

	}
}
