using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Webrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='MediaStream']"
	[global::Android.Runtime.Register ("org/webrtc/MediaStream", DoNotGenerateAcw=true)]
	public partial class MediaStream : global::Java.Lang.Object {


		static IntPtr audioTracks_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='MediaStream']/field[@name='audioTracks']"
		[Register ("audioTracks")]
		public global::Java.Util.LinkedList AudioTracks {
			get {
				if (audioTracks_jfieldId == IntPtr.Zero)
					audioTracks_jfieldId = JNIEnv.GetFieldID (class_ref, "audioTracks", "Ljava/util/LinkedList;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, audioTracks_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Util.LinkedList> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (audioTracks_jfieldId == IntPtr.Zero)
					audioTracks_jfieldId = JNIEnv.GetFieldID (class_ref, "audioTracks", "Ljava/util/LinkedList;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, audioTracks_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr videoTracks_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='MediaStream']/field[@name='videoTracks']"
		[Register ("videoTracks")]
		public global::Java.Util.LinkedList VideoTracks {
			get {
				if (videoTracks_jfieldId == IntPtr.Zero)
					videoTracks_jfieldId = JNIEnv.GetFieldID (class_ref, "videoTracks", "Ljava/util/LinkedList;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, videoTracks_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Util.LinkedList> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (videoTracks_jfieldId == IntPtr.Zero)
					videoTracks_jfieldId = JNIEnv.GetFieldID (class_ref, "videoTracks", "Ljava/util/LinkedList;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, videoTracks_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/webrtc/MediaStream", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MediaStream); }
		}

		protected MediaStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='MediaStream']/constructor[@name='MediaStream' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		public unsafe MediaStream (long p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (MediaStream)) {
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

		static Delegate cb_addTrack_Lorg_webrtc_AudioTrack_;
#pragma warning disable 0169
		static Delegate GetAddTrack_Lorg_webrtc_AudioTrack_Handler ()
		{
			if (cb_addTrack_Lorg_webrtc_AudioTrack_ == null)
				cb_addTrack_Lorg_webrtc_AudioTrack_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_AddTrack_Lorg_webrtc_AudioTrack_);
			return cb_addTrack_Lorg_webrtc_AudioTrack_;
		}

		static bool n_AddTrack_Lorg_webrtc_AudioTrack_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Webrtc.MediaStream __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.AudioTrack p0 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.AudioTrack> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AddTrack (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addTrack_Lorg_webrtc_AudioTrack_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='MediaStream']/method[@name='addTrack' and count(parameter)=1 and parameter[1][@type='org.webrtc.AudioTrack']]"
		[Register ("addTrack", "(Lorg/webrtc/AudioTrack;)Z", "GetAddTrack_Lorg_webrtc_AudioTrack_Handler")]
		public virtual unsafe bool AddTrack (global::Org.Webrtc.AudioTrack p0)
		{
			if (id_addTrack_Lorg_webrtc_AudioTrack_ == IntPtr.Zero)
				id_addTrack_Lorg_webrtc_AudioTrack_ = JNIEnv.GetMethodID (class_ref, "addTrack", "(Lorg/webrtc/AudioTrack;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_addTrack_Lorg_webrtc_AudioTrack_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addTrack", "(Lorg/webrtc/AudioTrack;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_addTrack_Lorg_webrtc_VideoTrack_;
#pragma warning disable 0169
		static Delegate GetAddTrack_Lorg_webrtc_VideoTrack_Handler ()
		{
			if (cb_addTrack_Lorg_webrtc_VideoTrack_ == null)
				cb_addTrack_Lorg_webrtc_VideoTrack_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_AddTrack_Lorg_webrtc_VideoTrack_);
			return cb_addTrack_Lorg_webrtc_VideoTrack_;
		}

		static bool n_AddTrack_Lorg_webrtc_VideoTrack_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Webrtc.MediaStream __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.VideoTrack p0 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoTrack> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AddTrack (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addTrack_Lorg_webrtc_VideoTrack_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='MediaStream']/method[@name='addTrack' and count(parameter)=1 and parameter[1][@type='org.webrtc.VideoTrack']]"
		[Register ("addTrack", "(Lorg/webrtc/VideoTrack;)Z", "GetAddTrack_Lorg_webrtc_VideoTrack_Handler")]
		public virtual unsafe bool AddTrack (global::Org.Webrtc.VideoTrack p0)
		{
			if (id_addTrack_Lorg_webrtc_VideoTrack_ == IntPtr.Zero)
				id_addTrack_Lorg_webrtc_VideoTrack_ = JNIEnv.GetMethodID (class_ref, "addTrack", "(Lorg/webrtc/VideoTrack;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_addTrack_Lorg_webrtc_VideoTrack_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addTrack", "(Lorg/webrtc/VideoTrack;)Z"), __args);
				return __ret;
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
			global::Org.Webrtc.MediaStream __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dispose ();
		}
#pragma warning restore 0169

		static IntPtr id_dispose;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='MediaStream']/method[@name='dispose' and count(parameter)=0]"
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

		static Delegate cb_label;
#pragma warning disable 0169
		static Delegate GetLabelHandler ()
		{
			if (cb_label == null)
				cb_label = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Label);
			return cb_label;
		}

		static IntPtr n_Label (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.MediaStream __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Label ());
		}
#pragma warning restore 0169

		static IntPtr id_label;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='MediaStream']/method[@name='label' and count(parameter)=0]"
		[Register ("label", "()Ljava/lang/String;", "GetLabelHandler")]
		public virtual unsafe string Label ()
		{
			if (id_label == IntPtr.Zero)
				id_label = JNIEnv.GetMethodID (class_ref, "label", "()Ljava/lang/String;");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_label), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "label", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_removeTrack_Lorg_webrtc_AudioTrack_;
#pragma warning disable 0169
		static Delegate GetRemoveTrack_Lorg_webrtc_AudioTrack_Handler ()
		{
			if (cb_removeTrack_Lorg_webrtc_AudioTrack_ == null)
				cb_removeTrack_Lorg_webrtc_AudioTrack_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RemoveTrack_Lorg_webrtc_AudioTrack_);
			return cb_removeTrack_Lorg_webrtc_AudioTrack_;
		}

		static bool n_RemoveTrack_Lorg_webrtc_AudioTrack_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Webrtc.MediaStream __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.AudioTrack p0 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.AudioTrack> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RemoveTrack (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_removeTrack_Lorg_webrtc_AudioTrack_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='MediaStream']/method[@name='removeTrack' and count(parameter)=1 and parameter[1][@type='org.webrtc.AudioTrack']]"
		[Register ("removeTrack", "(Lorg/webrtc/AudioTrack;)Z", "GetRemoveTrack_Lorg_webrtc_AudioTrack_Handler")]
		public virtual unsafe bool RemoveTrack (global::Org.Webrtc.AudioTrack p0)
		{
			if (id_removeTrack_Lorg_webrtc_AudioTrack_ == IntPtr.Zero)
				id_removeTrack_Lorg_webrtc_AudioTrack_ = JNIEnv.GetMethodID (class_ref, "removeTrack", "(Lorg/webrtc/AudioTrack;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_removeTrack_Lorg_webrtc_AudioTrack_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeTrack", "(Lorg/webrtc/AudioTrack;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_removeTrack_Lorg_webrtc_VideoTrack_;
#pragma warning disable 0169
		static Delegate GetRemoveTrack_Lorg_webrtc_VideoTrack_Handler ()
		{
			if (cb_removeTrack_Lorg_webrtc_VideoTrack_ == null)
				cb_removeTrack_Lorg_webrtc_VideoTrack_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RemoveTrack_Lorg_webrtc_VideoTrack_);
			return cb_removeTrack_Lorg_webrtc_VideoTrack_;
		}

		static bool n_RemoveTrack_Lorg_webrtc_VideoTrack_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Webrtc.MediaStream __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.MediaStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.VideoTrack p0 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.VideoTrack> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RemoveTrack (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_removeTrack_Lorg_webrtc_VideoTrack_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='MediaStream']/method[@name='removeTrack' and count(parameter)=1 and parameter[1][@type='org.webrtc.VideoTrack']]"
		[Register ("removeTrack", "(Lorg/webrtc/VideoTrack;)Z", "GetRemoveTrack_Lorg_webrtc_VideoTrack_Handler")]
		public virtual unsafe bool RemoveTrack (global::Org.Webrtc.VideoTrack p0)
		{
			if (id_removeTrack_Lorg_webrtc_VideoTrack_ == IntPtr.Zero)
				id_removeTrack_Lorg_webrtc_VideoTrack_ = JNIEnv.GetMethodID (class_ref, "removeTrack", "(Lorg/webrtc/VideoTrack;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_removeTrack_Lorg_webrtc_VideoTrack_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeTrack", "(Lorg/webrtc/VideoTrack;)Z"), __args);
				return __ret;
			} finally {
			}
		}

	}
}
