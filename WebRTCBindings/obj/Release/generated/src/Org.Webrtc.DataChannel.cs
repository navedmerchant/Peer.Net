using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Webrtc {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='DataChannel']"
	[global::Android.Runtime.Register ("org/webrtc/DataChannel", DoNotGenerateAcw=true)]
	public partial class DataChannel : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='DataChannel.Buffer']"
		[global::Android.Runtime.Register ("org/webrtc/DataChannel$Buffer", DoNotGenerateAcw=true)]
		public partial class Buffer : global::Java.Lang.Object {


			static IntPtr binary_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='DataChannel.Buffer']/field[@name='binary']"
			[Register ("binary")]
			public bool Binary {
				get {
					if (binary_jfieldId == IntPtr.Zero)
						binary_jfieldId = JNIEnv.GetFieldID (class_ref, "binary", "Z");
					return JNIEnv.GetBooleanField (Handle, binary_jfieldId);
				}
				set {
					if (binary_jfieldId == IntPtr.Zero)
						binary_jfieldId = JNIEnv.GetFieldID (class_ref, "binary", "Z");
					try {
						JNIEnv.SetField (Handle, binary_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr data_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='DataChannel.Buffer']/field[@name='data']"
			[Register ("data")]
			public global::Java.Nio.ByteBuffer Data {
				get {
					if (data_jfieldId == IntPtr.Zero)
						data_jfieldId = JNIEnv.GetFieldID (class_ref, "data", "Ljava/nio/ByteBuffer;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, data_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (data_jfieldId == IntPtr.Zero)
						data_jfieldId = JNIEnv.GetFieldID (class_ref, "data", "Ljava/nio/ByteBuffer;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (Handle, data_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/webrtc/DataChannel$Buffer", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Buffer); }
			}

			protected Buffer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_nio_ByteBuffer_Z;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='DataChannel.Buffer']/constructor[@name='DataChannel.Buffer' and count(parameter)=2 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='boolean']]"
			[Register (".ctor", "(Ljava/nio/ByteBuffer;Z)V", "")]
			public unsafe Buffer (global::Java.Nio.ByteBuffer p0, bool p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					if (GetType () != typeof (Buffer)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/nio/ByteBuffer;Z)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/nio/ByteBuffer;Z)V", __args);
						return;
					}

					if (id_ctor_Ljava_nio_ByteBuffer_Z == IntPtr.Zero)
						id_ctor_Ljava_nio_ByteBuffer_Z = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/nio/ByteBuffer;Z)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_nio_ByteBuffer_Z, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_nio_ByteBuffer_Z, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='DataChannel.Init']"
		[global::Android.Runtime.Register ("org/webrtc/DataChannel$Init", DoNotGenerateAcw=true)]
		public partial class Init : global::Java.Lang.Object {


			static IntPtr id_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='DataChannel.Init']/field[@name='id']"
			[Register ("id")]
			public int Id {
				get {
					if (id_jfieldId == IntPtr.Zero)
						id_jfieldId = JNIEnv.GetFieldID (class_ref, "id", "I");
					return JNIEnv.GetIntField (Handle, id_jfieldId);
				}
				set {
					if (id_jfieldId == IntPtr.Zero)
						id_jfieldId = JNIEnv.GetFieldID (class_ref, "id", "I");
					try {
						JNIEnv.SetField (Handle, id_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr maxRetransmitTimeMs_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='DataChannel.Init']/field[@name='maxRetransmitTimeMs']"
			[Register ("maxRetransmitTimeMs")]
			public int MaxRetransmitTimeMs {
				get {
					if (maxRetransmitTimeMs_jfieldId == IntPtr.Zero)
						maxRetransmitTimeMs_jfieldId = JNIEnv.GetFieldID (class_ref, "maxRetransmitTimeMs", "I");
					return JNIEnv.GetIntField (Handle, maxRetransmitTimeMs_jfieldId);
				}
				set {
					if (maxRetransmitTimeMs_jfieldId == IntPtr.Zero)
						maxRetransmitTimeMs_jfieldId = JNIEnv.GetFieldID (class_ref, "maxRetransmitTimeMs", "I");
					try {
						JNIEnv.SetField (Handle, maxRetransmitTimeMs_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr maxRetransmits_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='DataChannel.Init']/field[@name='maxRetransmits']"
			[Register ("maxRetransmits")]
			public int MaxRetransmits {
				get {
					if (maxRetransmits_jfieldId == IntPtr.Zero)
						maxRetransmits_jfieldId = JNIEnv.GetFieldID (class_ref, "maxRetransmits", "I");
					return JNIEnv.GetIntField (Handle, maxRetransmits_jfieldId);
				}
				set {
					if (maxRetransmits_jfieldId == IntPtr.Zero)
						maxRetransmits_jfieldId = JNIEnv.GetFieldID (class_ref, "maxRetransmits", "I");
					try {
						JNIEnv.SetField (Handle, maxRetransmits_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr negotiated_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='DataChannel.Init']/field[@name='negotiated']"
			[Register ("negotiated")]
			public bool Negotiated {
				get {
					if (negotiated_jfieldId == IntPtr.Zero)
						negotiated_jfieldId = JNIEnv.GetFieldID (class_ref, "negotiated", "Z");
					return JNIEnv.GetBooleanField (Handle, negotiated_jfieldId);
				}
				set {
					if (negotiated_jfieldId == IntPtr.Zero)
						negotiated_jfieldId = JNIEnv.GetFieldID (class_ref, "negotiated", "Z");
					try {
						JNIEnv.SetField (Handle, negotiated_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr ordered_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='DataChannel.Init']/field[@name='ordered']"
			[Register ("ordered")]
			public bool Ordered {
				get {
					if (ordered_jfieldId == IntPtr.Zero)
						ordered_jfieldId = JNIEnv.GetFieldID (class_ref, "ordered", "Z");
					return JNIEnv.GetBooleanField (Handle, ordered_jfieldId);
				}
				set {
					if (ordered_jfieldId == IntPtr.Zero)
						ordered_jfieldId = JNIEnv.GetFieldID (class_ref, "ordered", "Z");
					try {
						JNIEnv.SetField (Handle, ordered_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr protocol_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='DataChannel.Init']/field[@name='protocol']"
			[Register ("protocol")]
			public string Protocol {
				get {
					if (protocol_jfieldId == IntPtr.Zero)
						protocol_jfieldId = JNIEnv.GetFieldID (class_ref, "protocol", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, protocol_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (protocol_jfieldId == IntPtr.Zero)
						protocol_jfieldId = JNIEnv.GetFieldID (class_ref, "protocol", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (Handle, protocol_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/webrtc/DataChannel$Init", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Init); }
			}

			protected Init (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='DataChannel.Init']/constructor[@name='DataChannel.Init' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Init ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (Init)) {
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

		// Metadata.xml XPath interface reference: path="/api/package[@name='org.webrtc']/interface[@name='DataChannel.Observer']"
		[Register ("org/webrtc/DataChannel$Observer", "", "Org.Webrtc.DataChannel/IObserverInvoker")]
		public partial interface IObserver : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='DataChannel.Observer']/method[@name='onBufferedAmountChange' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("onBufferedAmountChange", "(J)V", "GetOnBufferedAmountChange_JHandler:Org.Webrtc.DataChannel/IObserverInvoker, WebRTCBindings")]
			void OnBufferedAmountChange (long p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='DataChannel.Observer']/method[@name='onMessage' and count(parameter)=1 and parameter[1][@type='org.webrtc.DataChannel.Buffer']]"
			[Register ("onMessage", "(Lorg/webrtc/DataChannel$Buffer;)V", "GetOnMessage_Lorg_webrtc_DataChannel_Buffer_Handler:Org.Webrtc.DataChannel/IObserverInvoker, WebRTCBindings")]
			void OnMessage (global::Org.Webrtc.DataChannel.Buffer p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='DataChannel.Observer']/method[@name='onStateChange' and count(parameter)=0]"
			[Register ("onStateChange", "()V", "GetOnStateChangeHandler:Org.Webrtc.DataChannel/IObserverInvoker, WebRTCBindings")]
			void OnStateChange ();

		}

		[global::Android.Runtime.Register ("org/webrtc/DataChannel$Observer", DoNotGenerateAcw=true)]
		internal class IObserverInvoker : global::Java.Lang.Object, IObserver {

			static IntPtr java_class_ref = JNIEnv.FindClass ("org/webrtc/DataChannel$Observer");
			IntPtr class_ref;

			public static IObserver GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IObserver> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "org.webrtc.DataChannel.Observer"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IObserverInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IObserverInvoker); }
			}

			static Delegate cb_onBufferedAmountChange_J;
#pragma warning disable 0169
			static Delegate GetOnBufferedAmountChange_JHandler ()
			{
				if (cb_onBufferedAmountChange_J == null)
					cb_onBufferedAmountChange_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_OnBufferedAmountChange_J);
				return cb_onBufferedAmountChange_J;
			}

			static void n_OnBufferedAmountChange_J (IntPtr jnienv, IntPtr native__this, long p0)
			{
				global::Org.Webrtc.DataChannel.IObserver __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.DataChannel.IObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnBufferedAmountChange (p0);
			}
#pragma warning restore 0169

			IntPtr id_onBufferedAmountChange_J;
			public unsafe void OnBufferedAmountChange (long p0)
			{
				if (id_onBufferedAmountChange_J == IntPtr.Zero)
					id_onBufferedAmountChange_J = JNIEnv.GetMethodID (class_ref, "onBufferedAmountChange", "(J)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (Handle, id_onBufferedAmountChange_J, __args);
			}

			static Delegate cb_onMessage_Lorg_webrtc_DataChannel_Buffer_;
#pragma warning disable 0169
			static Delegate GetOnMessage_Lorg_webrtc_DataChannel_Buffer_Handler ()
			{
				if (cb_onMessage_Lorg_webrtc_DataChannel_Buffer_ == null)
					cb_onMessage_Lorg_webrtc_DataChannel_Buffer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnMessage_Lorg_webrtc_DataChannel_Buffer_);
				return cb_onMessage_Lorg_webrtc_DataChannel_Buffer_;
			}

			static void n_OnMessage_Lorg_webrtc_DataChannel_Buffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Org.Webrtc.DataChannel.IObserver __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.DataChannel.IObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Webrtc.DataChannel.Buffer p0 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.DataChannel.Buffer> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnMessage (p0);
			}
#pragma warning restore 0169

			IntPtr id_onMessage_Lorg_webrtc_DataChannel_Buffer_;
			public unsafe void OnMessage (global::Org.Webrtc.DataChannel.Buffer p0)
			{
				if (id_onMessage_Lorg_webrtc_DataChannel_Buffer_ == IntPtr.Zero)
					id_onMessage_Lorg_webrtc_DataChannel_Buffer_ = JNIEnv.GetMethodID (class_ref, "onMessage", "(Lorg/webrtc/DataChannel$Buffer;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (Handle, id_onMessage_Lorg_webrtc_DataChannel_Buffer_, __args);
			}

			static Delegate cb_onStateChange;
#pragma warning disable 0169
			static Delegate GetOnStateChangeHandler ()
			{
				if (cb_onStateChange == null)
					cb_onStateChange = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnStateChange);
				return cb_onStateChange;
			}

			static void n_OnStateChange (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Webrtc.DataChannel.IObserver __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.DataChannel.IObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnStateChange ();
			}
#pragma warning restore 0169

			IntPtr id_onStateChange;
			public unsafe void OnStateChange ()
			{
				if (id_onStateChange == IntPtr.Zero)
					id_onStateChange = JNIEnv.GetMethodID (class_ref, "onStateChange", "()V");
				JNIEnv.CallVoidMethod (Handle, id_onStateChange);
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='org.webrtc']/class[@name='DataChannel.State']"
		[global::Android.Runtime.Register ("org/webrtc/DataChannel$State", DoNotGenerateAcw=true)]
		public sealed partial class State : global::Java.Lang.Enum {


			static IntPtr CLOSED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='DataChannel.State']/field[@name='CLOSED']"
			[Register ("CLOSED")]
			public static global::Org.Webrtc.DataChannel.State Closed {
				get {
					if (CLOSED_jfieldId == IntPtr.Zero)
						CLOSED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CLOSED", "Lorg/webrtc/DataChannel$State;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CLOSED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.DataChannel.State> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CLOSING_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='DataChannel.State']/field[@name='CLOSING']"
			[Register ("CLOSING")]
			public static global::Org.Webrtc.DataChannel.State Closing {
				get {
					if (CLOSING_jfieldId == IntPtr.Zero)
						CLOSING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CLOSING", "Lorg/webrtc/DataChannel$State;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CLOSING_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.DataChannel.State> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CONNECTING_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='DataChannel.State']/field[@name='CONNECTING']"
			[Register ("CONNECTING")]
			public static global::Org.Webrtc.DataChannel.State Connecting {
				get {
					if (CONNECTING_jfieldId == IntPtr.Zero)
						CONNECTING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONNECTING", "Lorg/webrtc/DataChannel$State;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CONNECTING_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.DataChannel.State> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr OPEN_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.webrtc']/class[@name='DataChannel.State']/field[@name='OPEN']"
			[Register ("OPEN")]
			public static global::Org.Webrtc.DataChannel.State Open {
				get {
					if (OPEN_jfieldId == IntPtr.Zero)
						OPEN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OPEN", "Lorg/webrtc/DataChannel$State;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OPEN_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.DataChannel.State> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/webrtc/DataChannel$State", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (State); }
			}

			internal State (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='DataChannel.State']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/webrtc/DataChannel$State;", "")]
			public static unsafe global::Org.Webrtc.DataChannel.State ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lorg/webrtc/DataChannel$State;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Org.Webrtc.DataChannel.State __ret = global::Java.Lang.Object.GetObject<global::Org.Webrtc.DataChannel.State> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='DataChannel.State']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/webrtc/DataChannel$State;", "")]
			public static unsafe global::Org.Webrtc.DataChannel.State[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lorg/webrtc/DataChannel$State;");
				try {
					return (global::Org.Webrtc.DataChannel.State[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Webrtc.DataChannel.State));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/webrtc/DataChannel", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DataChannel); }
		}

		protected DataChannel (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.webrtc']/class[@name='DataChannel']/constructor[@name='DataChannel' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		public unsafe DataChannel (long p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (DataChannel)) {
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

		static Delegate cb_bufferedAmount;
#pragma warning disable 0169
		static Delegate GetBufferedAmountHandler ()
		{
			if (cb_bufferedAmount == null)
				cb_bufferedAmount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_BufferedAmount);
			return cb_bufferedAmount;
		}

		static long n_BufferedAmount (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.DataChannel __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.DataChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BufferedAmount ();
		}
#pragma warning restore 0169

		static IntPtr id_bufferedAmount;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='DataChannel']/method[@name='bufferedAmount' and count(parameter)=0]"
		[Register ("bufferedAmount", "()J", "GetBufferedAmountHandler")]
		public virtual unsafe long BufferedAmount ()
		{
			if (id_bufferedAmount == IntPtr.Zero)
				id_bufferedAmount = JNIEnv.GetMethodID (class_ref, "bufferedAmount", "()J");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod  (Handle, id_bufferedAmount);
				else
					return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "bufferedAmount", "()J"));
			} finally {
			}
		}

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.DataChannel __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.DataChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='DataChannel']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public virtual unsafe void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_close);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "close", "()V"));
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
			global::Org.Webrtc.DataChannel __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.DataChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dispose ();
		}
#pragma warning restore 0169

		static IntPtr id_dispose;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='DataChannel']/method[@name='dispose' and count(parameter)=0]"
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
			global::Org.Webrtc.DataChannel __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.DataChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Label ());
		}
#pragma warning restore 0169

		static IntPtr id_label;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='DataChannel']/method[@name='label' and count(parameter)=0]"
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

		static Delegate cb_registerObserver_Lorg_webrtc_DataChannel_Observer_;
#pragma warning disable 0169
		static Delegate GetRegisterObserver_Lorg_webrtc_DataChannel_Observer_Handler ()
		{
			if (cb_registerObserver_Lorg_webrtc_DataChannel_Observer_ == null)
				cb_registerObserver_Lorg_webrtc_DataChannel_Observer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RegisterObserver_Lorg_webrtc_DataChannel_Observer_);
			return cb_registerObserver_Lorg_webrtc_DataChannel_Observer_;
		}

		static void n_RegisterObserver_Lorg_webrtc_DataChannel_Observer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Webrtc.DataChannel __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.DataChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.DataChannel.IObserver p0 = (global::Org.Webrtc.DataChannel.IObserver)global::Java.Lang.Object.GetObject<global::Org.Webrtc.DataChannel.IObserver> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RegisterObserver (p0);
		}
#pragma warning restore 0169

		static IntPtr id_registerObserver_Lorg_webrtc_DataChannel_Observer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='DataChannel']/method[@name='registerObserver' and count(parameter)=1 and parameter[1][@type='org.webrtc.DataChannel.Observer']]"
		[Register ("registerObserver", "(Lorg/webrtc/DataChannel$Observer;)V", "GetRegisterObserver_Lorg_webrtc_DataChannel_Observer_Handler")]
		public virtual unsafe void RegisterObserver (global::Org.Webrtc.DataChannel.IObserver p0)
		{
			if (id_registerObserver_Lorg_webrtc_DataChannel_Observer_ == IntPtr.Zero)
				id_registerObserver_Lorg_webrtc_DataChannel_Observer_ = JNIEnv.GetMethodID (class_ref, "registerObserver", "(Lorg/webrtc/DataChannel$Observer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_registerObserver_Lorg_webrtc_DataChannel_Observer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "registerObserver", "(Lorg/webrtc/DataChannel$Observer;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_send_Lorg_webrtc_DataChannel_Buffer_;
#pragma warning disable 0169
		static Delegate GetSend_Lorg_webrtc_DataChannel_Buffer_Handler ()
		{
			if (cb_send_Lorg_webrtc_DataChannel_Buffer_ == null)
				cb_send_Lorg_webrtc_DataChannel_Buffer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Send_Lorg_webrtc_DataChannel_Buffer_);
			return cb_send_Lorg_webrtc_DataChannel_Buffer_;
		}

		static bool n_Send_Lorg_webrtc_DataChannel_Buffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Webrtc.DataChannel __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.DataChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.DataChannel.Buffer p0 = global::Java.Lang.Object.GetObject<global::Org.Webrtc.DataChannel.Buffer> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Send (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_send_Lorg_webrtc_DataChannel_Buffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='DataChannel']/method[@name='send' and count(parameter)=1 and parameter[1][@type='org.webrtc.DataChannel.Buffer']]"
		[Register ("send", "(Lorg/webrtc/DataChannel$Buffer;)Z", "GetSend_Lorg_webrtc_DataChannel_Buffer_Handler")]
		public virtual unsafe bool Send (global::Org.Webrtc.DataChannel.Buffer p0)
		{
			if (id_send_Lorg_webrtc_DataChannel_Buffer_ == IntPtr.Zero)
				id_send_Lorg_webrtc_DataChannel_Buffer_ = JNIEnv.GetMethodID (class_ref, "send", "(Lorg/webrtc/DataChannel$Buffer;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_send_Lorg_webrtc_DataChannel_Buffer_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "send", "(Lorg/webrtc/DataChannel$Buffer;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_state;
#pragma warning disable 0169
		static Delegate GetInvokeStateHandler ()
		{
			if (cb_state == null)
				cb_state = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_InvokeState);
			return cb_state;
		}

		static IntPtr n_InvokeState (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.DataChannel __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.DataChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InvokeState ());
		}
#pragma warning restore 0169

		static IntPtr id_state;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='DataChannel']/method[@name='state' and count(parameter)=0]"
		[Register ("state", "()Lorg/webrtc/DataChannel$State;", "GetInvokeStateHandler")]
		public virtual unsafe global::Org.Webrtc.DataChannel.State InvokeState ()
		{
			if (id_state == IntPtr.Zero)
				id_state = JNIEnv.GetMethodID (class_ref, "state", "()Lorg/webrtc/DataChannel$State;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.DataChannel.State> (JNIEnv.CallObjectMethod  (Handle, id_state), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Webrtc.DataChannel.State> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "state", "()Lorg/webrtc/DataChannel$State;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_unregisterObserver;
#pragma warning disable 0169
		static Delegate GetUnregisterObserverHandler ()
		{
			if (cb_unregisterObserver == null)
				cb_unregisterObserver = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_UnregisterObserver);
			return cb_unregisterObserver;
		}

		static void n_UnregisterObserver (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Webrtc.DataChannel __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.DataChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UnregisterObserver ();
		}
#pragma warning restore 0169

		static IntPtr id_unregisterObserver;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/class[@name='DataChannel']/method[@name='unregisterObserver' and count(parameter)=0]"
		[Register ("unregisterObserver", "()V", "GetUnregisterObserverHandler")]
		public virtual unsafe void UnregisterObserver ()
		{
			if (id_unregisterObserver == IntPtr.Zero)
				id_unregisterObserver = JNIEnv.GetMethodID (class_ref, "unregisterObserver", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_unregisterObserver);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "unregisterObserver", "()V"));
			} finally {
			}
		}

	}
}
