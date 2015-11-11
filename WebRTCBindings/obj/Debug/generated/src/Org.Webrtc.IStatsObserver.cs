using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Webrtc {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.webrtc']/interface[@name='StatsObserver']"
	[Register ("org/webrtc/StatsObserver", "", "Org.Webrtc.IStatsObserverInvoker")]
	public partial interface IStatsObserver : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.webrtc']/interface[@name='StatsObserver']/method[@name='onComplete' and count(parameter)=1 and parameter[1][@type='org.webrtc.StatsReport[]']]"
		[Register ("onComplete", "([Lorg/webrtc/StatsReport;)V", "GetOnComplete_arrayLorg_webrtc_StatsReport_Handler:Org.Webrtc.IStatsObserverInvoker, WebRTCBindings")]
		void OnComplete (global::Org.Webrtc.StatsReport[] p0);

	}

	[global::Android.Runtime.Register ("org/webrtc/StatsObserver", DoNotGenerateAcw=true)]
	internal class IStatsObserverInvoker : global::Java.Lang.Object, IStatsObserver {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/webrtc/StatsObserver");
		IntPtr class_ref;

		public static IStatsObserver GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IStatsObserver> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.webrtc.StatsObserver"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IStatsObserverInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IStatsObserverInvoker); }
		}

		static Delegate cb_onComplete_arrayLorg_webrtc_StatsReport_;
#pragma warning disable 0169
		static Delegate GetOnComplete_arrayLorg_webrtc_StatsReport_Handler ()
		{
			if (cb_onComplete_arrayLorg_webrtc_StatsReport_ == null)
				cb_onComplete_arrayLorg_webrtc_StatsReport_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnComplete_arrayLorg_webrtc_StatsReport_);
			return cb_onComplete_arrayLorg_webrtc_StatsReport_;
		}

		static void n_OnComplete_arrayLorg_webrtc_StatsReport_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Webrtc.IStatsObserver __this = global::Java.Lang.Object.GetObject<global::Org.Webrtc.IStatsObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Webrtc.StatsReport[] p0 = (global::Org.Webrtc.StatsReport[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Org.Webrtc.StatsReport));
			__this.OnComplete (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_onComplete_arrayLorg_webrtc_StatsReport_;
		public unsafe void OnComplete (global::Org.Webrtc.StatsReport[] p0)
		{
			if (id_onComplete_arrayLorg_webrtc_StatsReport_ == IntPtr.Zero)
				id_onComplete_arrayLorg_webrtc_StatsReport_ = JNIEnv.GetMethodID (class_ref, "onComplete", "([Lorg/webrtc/StatsReport;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (Handle, id_onComplete_arrayLorg_webrtc_StatsReport_, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}

}
