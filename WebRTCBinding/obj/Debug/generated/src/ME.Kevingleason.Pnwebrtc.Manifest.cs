using System;
using System.Collections.Generic;
using Android.Runtime;

namespace ME.Kevingleason.Pnwebrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='me.kevingleason.pnwebrtc']/class[@name='Manifest']"
	[global::Android.Runtime.Register ("me/kevingleason/pnwebrtc/Manifest", DoNotGenerateAcw=true)]
	public sealed partial class Manifest : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='me.kevingleason.pnwebrtc']/class[@name='Manifest.permission']"
		[global::Android.Runtime.Register ("me/kevingleason/pnwebrtc/Manifest$permission", DoNotGenerateAcw=true)]
		public sealed partial class Permission : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='me.kevingleason.pnwebrtc']/class[@name='Manifest.permission']/field[@name='C2D_MESSAGE']"
			[Register ("C2D_MESSAGE")]
			public const string C2dMessage = (string) "your.package.name.permission.C2D_MESSAGE";
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("me/kevingleason/pnwebrtc/Manifest$permission", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Permission); }
			}

			internal Permission (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='me.kevingleason.pnwebrtc']/class[@name='Manifest.permission']/constructor[@name='Manifest.permission' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Permission ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (Permission)) {
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

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("me/kevingleason/pnwebrtc/Manifest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Manifest); }
		}

		internal Manifest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='me.kevingleason.pnwebrtc']/class[@name='Manifest']/constructor[@name='Manifest' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Manifest ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Manifest)) {
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
