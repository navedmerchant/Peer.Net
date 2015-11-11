using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Webrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='MediaCodecVideoDecoder']"
	[global::Android.Runtime.Register ("org/webrtc/MediaCodecVideoDecoder", DoNotGenerateAcw=true)]
	public partial class MediaCodecVideoDecoder : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='MediaCodecVideoDecoder.DecoderOutputBufferInfo']"
		[global::Android.Runtime.Register ("org/webrtc/MediaCodecVideoDecoder$DecoderOutputBufferInfo", DoNotGenerateAcw=true)]
		public partial class DecoderOutputBufferInfo : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/webrtc/MediaCodecVideoDecoder$DecoderOutputBufferInfo", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DecoderOutputBufferInfo); }
			}

			protected DecoderOutputBufferInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_IIIJ;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='MediaCodecVideoDecoder.DecoderOutputBufferInfo']/constructor[@name='MediaCodecVideoDecoder.DecoderOutputBufferInfo' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='long']]"
			[Register (".ctor", "(IIIJ)V", "")]
			public unsafe DecoderOutputBufferInfo (int p0, int p1, int p2, long p3)
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
					if (GetType () != typeof (DecoderOutputBufferInfo)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(IIIJ)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(IIIJ)V", __args);
						return;
					}

					if (id_ctor_IIIJ == IntPtr.Zero)
						id_ctor_IIIJ = JNIEnv.GetMethodID (class_ref, "<init>", "(IIIJ)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IIIJ, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_IIIJ, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='MediaCodecVideoDecoder.DecoderProperties']"
		[global::Android.Runtime.Register ("org/webrtc/MediaCodecVideoDecoder$DecoderProperties", DoNotGenerateAcw=true)]
		public partial class DecoderProperties : global::Java.Lang.Object {


			static IntPtr codecName_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='MediaCodecVideoDecoder.DecoderProperties']/field[@name='codecName']"
			[Register ("codecName")]
			public string CodecName {
				get {
					if (codecName_jfieldId == IntPtr.Zero)
						codecName_jfieldId = JNIEnv.GetFieldID (class_ref, "codecName", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, codecName_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (codecName_jfieldId == IntPtr.Zero)
						codecName_jfieldId = JNIEnv.GetFieldID (class_ref, "codecName", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (Handle, codecName_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr colorFormat_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='MediaCodecVideoDecoder.DecoderProperties']/field[@name='colorFormat']"
			[Register ("colorFormat")]
			public int ColorFormat {
				get {
					if (colorFormat_jfieldId == IntPtr.Zero)
						colorFormat_jfieldId = JNIEnv.GetFieldID (class_ref, "colorFormat", "I");
					return JNIEnv.GetIntField (Handle, colorFormat_jfieldId);
				}
				set {
					if (colorFormat_jfieldId == IntPtr.Zero)
						colorFormat_jfieldId = JNIEnv.GetFieldID (class_ref, "colorFormat", "I");
					try {
						JNIEnv.SetField (Handle, colorFormat_jfieldId, value);
					} finally {
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/webrtc/MediaCodecVideoDecoder$DecoderProperties", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DecoderProperties); }
			}

			protected DecoderProperties (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_lang_String_I;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='MediaCodecVideoDecoder.DecoderProperties']/constructor[@name='MediaCodecVideoDecoder.DecoderProperties' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
			[Register (".ctor", "(Ljava/lang/String;I)V", "")]
			public unsafe DecoderProperties (string p0, int p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (p1);
					if (GetType () != typeof (DecoderProperties)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;I)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;I)V", __args);
						return;
					}

					if (id_ctor_Ljava_lang_String_I == IntPtr.Zero)
						id_ctor_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;I)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_I, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_I, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='MediaCodecVideoDecoder.VideoCodecType']"
		[global::Android.Runtime.Register ("org/webrtc/MediaCodecVideoDecoder$VideoCodecType", DoNotGenerateAcw=true)]
		public sealed partial class VideoCodecType : global::Java.Lang.Enum {


			static IntPtr VIDEO_CODEC_H264_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='MediaCodecVideoDecoder.VideoCodecType']/field[@name='VIDEO_CODEC_H264']"
			[Register ("VIDEO_CODEC_H264")]
			public static global::Org.Webrtc.MediaCodecVideoDecoder.VideoCodecType VideoCodecH264 {
				get {
					if (VIDEO_CODEC_H264_jfieldId == IntPtr.Zero)
						VIDEO_CODEC_H264_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDEO_CODEC_H264", "Lorg/webrtc/MediaCodecVideoDecoder$VideoCodecType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDEO_CODEC_H264_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaCodecVideoDecoder.VideoCodecType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDEO_CODEC_VP8_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='MediaCodecVideoDecoder.VideoCodecType']/field[@name='VIDEO_CODEC_VP8']"
			[Register ("VIDEO_CODEC_VP8")]
			public static global::Org.Webrtc.MediaCodecVideoDecoder.VideoCodecType VideoCodecVp8 {
				get {
					if (VIDEO_CODEC_VP8_jfieldId == IntPtr.Zero)
						VIDEO_CODEC_VP8_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDEO_CODEC_VP8", "Lorg/webrtc/MediaCodecVideoDecoder$VideoCodecType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDEO_CODEC_VP8_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaCodecVideoDecoder.VideoCodecType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDEO_CODEC_VP9_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='MediaCodecVideoDecoder.VideoCodecType']/field[@name='VIDEO_CODEC_VP9']"
			[Register ("VIDEO_CODEC_VP9")]
			public static global::Org.Webrtc.MediaCodecVideoDecoder.VideoCodecType VideoCodecVp9 {
				get {
					if (VIDEO_CODEC_VP9_jfieldId == IntPtr.Zero)
						VIDEO_CODEC_VP9_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDEO_CODEC_VP9", "Lorg/webrtc/MediaCodecVideoDecoder$VideoCodecType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDEO_CODEC_VP9_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaCodecVideoDecoder.VideoCodecType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/webrtc/MediaCodecVideoDecoder$VideoCodecType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (VideoCodecType); }
			}

			internal VideoCodecType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='MediaCodecVideoDecoder.VideoCodecType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/webrtc/MediaCodecVideoDecoder$VideoCodecType;", "")]
			public static unsafe global::Org.Webrtc.MediaCodecVideoDecoder.VideoCodecType ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lorg/webrtc/MediaCodecVideoDecoder$VideoCodecType;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Org.Webrtc.MediaCodecVideoDecoder.VideoCodecType __ret = global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaCodecVideoDecoder.VideoCodecType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='MediaCodecVideoDecoder.VideoCodecType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/webrtc/MediaCodecVideoDecoder$VideoCodecType;", "")]
			public static unsafe global::Org.Webrtc.MediaCodecVideoDecoder.VideoCodecType[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lorg/webrtc/MediaCodecVideoDecoder$VideoCodecType;");
				try {
					return (global::Org.Webrtc.MediaCodecVideoDecoder.VideoCodecType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Webrtc.MediaCodecVideoDecoder.VideoCodecType));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/webrtc/MediaCodecVideoDecoder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MediaCodecVideoDecoder); }
		}

		protected MediaCodecVideoDecoder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_isH264HwSupported;
		public static unsafe bool IsH264HwSupported {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='MediaCodecVideoDecoder']/method[@name='isH264HwSupported' and count(parameter)=0]"
			[Register ("isH264HwSupported", "()Z", "GetIsH264HwSupportedHandler")]
			get {
				if (id_isH264HwSupported == IntPtr.Zero)
					id_isH264HwSupported = JNIEnv.GetStaticMethodID (class_ref, "isH264HwSupported", "()Z");
				try {
					return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isH264HwSupported);
				} finally {
				}
			}
		}

		static IntPtr id_isVp8HwSupported;
		public static unsafe bool IsVp8HwSupported {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='MediaCodecVideoDecoder']/method[@name='isVp8HwSupported' and count(parameter)=0]"
			[Register ("isVp8HwSupported", "()Z", "GetIsVp8HwSupportedHandler")]
			get {
				if (id_isVp8HwSupported == IntPtr.Zero)
					id_isVp8HwSupported = JNIEnv.GetStaticMethodID (class_ref, "isVp8HwSupported", "()Z");
				try {
					return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isVp8HwSupported);
				} finally {
				}
			}
		}

	}
}
