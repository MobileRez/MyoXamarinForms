using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Thalmic.Myo {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.thalmic.myo']/class[@name='AbstractDeviceListener']"
	[global::Android.Runtime.Register ("com/thalmic/myo/AbstractDeviceListener", DoNotGenerateAcw=true)]
	public abstract partial class AbstractDeviceListener : global::Java.Lang.Object, global::Com.Thalmic.Myo.IDeviceListener {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/thalmic/myo/AbstractDeviceListener", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbstractDeviceListener); }
		}

		protected AbstractDeviceListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.thalmic.myo']/class[@name='AbstractDeviceListener']/constructor[@name='AbstractDeviceListener' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public AbstractDeviceListener () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (AbstractDeviceListener)) {
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

		static Delegate cb_onAccelerometerData_Lcom_thalmic_myo_Myo_JLcom_thalmic_myo_Vector3_;
#pragma warning disable 0169
		static Delegate GetOnAccelerometerData_Lcom_thalmic_myo_Myo_JLcom_thalmic_myo_Vector3_Handler ()
		{
			if (cb_onAccelerometerData_Lcom_thalmic_myo_Myo_JLcom_thalmic_myo_Vector3_ == null)
				cb_onAccelerometerData_Lcom_thalmic_myo_Myo_JLcom_thalmic_myo_Vector3_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long, IntPtr>) n_OnAccelerometerData_Lcom_thalmic_myo_Myo_JLcom_thalmic_myo_Vector3_);
			return cb_onAccelerometerData_Lcom_thalmic_myo_Myo_JLcom_thalmic_myo_Vector3_;
		}

		static void n_OnAccelerometerData_Lcom_thalmic_myo_Myo_JLcom_thalmic_myo_Vector3_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1, IntPtr native_p2)
		{
			global::Com.Thalmic.Myo.AbstractDeviceListener __this = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.AbstractDeviceListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Thalmic.Myo.Myo p0 = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Myo> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Thalmic.Myo.Vector3 p2 = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Vector3> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnAccelerometerData (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_onAccelerometerData_Lcom_thalmic_myo_Myo_JLcom_thalmic_myo_Vector3_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo']/class[@name='AbstractDeviceListener']/method[@name='onAccelerometerData' and count(parameter)=3 and parameter[1][@type='com.thalmic.myo.Myo'] and parameter[2][@type='long'] and parameter[3][@type='com.thalmic.myo.Vector3']]"
		[Register ("onAccelerometerData", "(Lcom/thalmic/myo/Myo;JLcom/thalmic/myo/Vector3;)V", "GetOnAccelerometerData_Lcom_thalmic_myo_Myo_JLcom_thalmic_myo_Vector3_Handler")]
		public virtual void OnAccelerometerData (global::Com.Thalmic.Myo.Myo p0, long p1, global::Com.Thalmic.Myo.Vector3 p2)
		{
			if (id_onAccelerometerData_Lcom_thalmic_myo_Myo_JLcom_thalmic_myo_Vector3_ == IntPtr.Zero)
				id_onAccelerometerData_Lcom_thalmic_myo_Myo_JLcom_thalmic_myo_Vector3_ = JNIEnv.GetMethodID (class_ref, "onAccelerometerData", "(Lcom/thalmic/myo/Myo;JLcom/thalmic/myo/Vector3;)V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onAccelerometerData_Lcom_thalmic_myo_Myo_JLcom_thalmic_myo_Vector3_, new JValue (p0), new JValue (p1), new JValue (p2));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onAccelerometerData", "(Lcom/thalmic/myo/Myo;JLcom/thalmic/myo/Vector3;)V"), new JValue (p0), new JValue (p1), new JValue (p2));
			} finally {
			}
		}

		static Delegate cb_onArmLost_Lcom_thalmic_myo_Myo_J;
#pragma warning disable 0169
		static Delegate GetOnArmLost_Lcom_thalmic_myo_Myo_JHandler ()
		{
			if (cb_onArmLost_Lcom_thalmic_myo_Myo_J == null)
				cb_onArmLost_Lcom_thalmic_myo_Myo_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long>) n_OnArmLost_Lcom_thalmic_myo_Myo_J);
			return cb_onArmLost_Lcom_thalmic_myo_Myo_J;
		}

		static void n_OnArmLost_Lcom_thalmic_myo_Myo_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			global::Com.Thalmic.Myo.AbstractDeviceListener __this = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.AbstractDeviceListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Thalmic.Myo.Myo p0 = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Myo> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnArmLost (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onArmLost_Lcom_thalmic_myo_Myo_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo']/class[@name='AbstractDeviceListener']/method[@name='onArmLost' and count(parameter)=2 and parameter[1][@type='com.thalmic.myo.Myo'] and parameter[2][@type='long']]"
		[Register ("onArmLost", "(Lcom/thalmic/myo/Myo;J)V", "GetOnArmLost_Lcom_thalmic_myo_Myo_JHandler")]
		public virtual void OnArmLost (global::Com.Thalmic.Myo.Myo p0, long p1)
		{
			if (id_onArmLost_Lcom_thalmic_myo_Myo_J == IntPtr.Zero)
				id_onArmLost_Lcom_thalmic_myo_Myo_J = JNIEnv.GetMethodID (class_ref, "onArmLost", "(Lcom/thalmic/myo/Myo;J)V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onArmLost_Lcom_thalmic_myo_Myo_J, new JValue (p0), new JValue (p1));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onArmLost", "(Lcom/thalmic/myo/Myo;J)V"), new JValue (p0), new JValue (p1));
			} finally {
			}
		}

		static Delegate cb_onArmRecognized_Lcom_thalmic_myo_Myo_JLcom_thalmic_myo_Arm_Lcom_thalmic_myo_XDirection_;
#pragma warning disable 0169
		static Delegate GetOnArmRecognized_Lcom_thalmic_myo_Myo_JLcom_thalmic_myo_Arm_Lcom_thalmic_myo_XDirection_Handler ()
		{
			if (cb_onArmRecognized_Lcom_thalmic_myo_Myo_JLcom_thalmic_myo_Arm_Lcom_thalmic_myo_XDirection_ == null)
				cb_onArmRecognized_Lcom_thalmic_myo_Myo_JLcom_thalmic_myo_Arm_Lcom_thalmic_myo_XDirection_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long, IntPtr, IntPtr>) n_OnArmRecognized_Lcom_thalmic_myo_Myo_JLcom_thalmic_myo_Arm_Lcom_thalmic_myo_XDirection_);
			return cb_onArmRecognized_Lcom_thalmic_myo_Myo_JLcom_thalmic_myo_Arm_Lcom_thalmic_myo_XDirection_;
		}

		static void n_OnArmRecognized_Lcom_thalmic_myo_Myo_JLcom_thalmic_myo_Arm_Lcom_thalmic_myo_XDirection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Thalmic.Myo.AbstractDeviceListener __this = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.AbstractDeviceListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Thalmic.Myo.Myo p0 = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Myo> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Thalmic.Myo.Arm p2 = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Arm> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Com.Thalmic.Myo.XDirection p3 = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.XDirection> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.OnArmRecognized (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_onArmRecognized_Lcom_thalmic_myo_Myo_JLcom_thalmic_myo_Arm_Lcom_thalmic_myo_XDirection_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo']/class[@name='AbstractDeviceListener']/method[@name='onArmRecognized' and count(parameter)=4 and parameter[1][@type='com.thalmic.myo.Myo'] and parameter[2][@type='long'] and parameter[3][@type='com.thalmic.myo.Arm'] and parameter[4][@type='com.thalmic.myo.XDirection']]"
		[Register ("onArmRecognized", "(Lcom/thalmic/myo/Myo;JLcom/thalmic/myo/Arm;Lcom/thalmic/myo/XDirection;)V", "GetOnArmRecognized_Lcom_thalmic_myo_Myo_JLcom_thalmic_myo_Arm_Lcom_thalmic_myo_XDirection_Handler")]
		public virtual void OnArmRecognized (global::Com.Thalmic.Myo.Myo p0, long p1, global::Com.Thalmic.Myo.Arm p2, global::Com.Thalmic.Myo.XDirection p3)
		{
			if (id_onArmRecognized_Lcom_thalmic_myo_Myo_JLcom_thalmic_myo_Arm_Lcom_thalmic_myo_XDirection_ == IntPtr.Zero)
				id_onArmRecognized_Lcom_thalmic_myo_Myo_JLcom_thalmic_myo_Arm_Lcom_thalmic_myo_XDirection_ = JNIEnv.GetMethodID (class_ref, "onArmRecognized", "(Lcom/thalmic/myo/Myo;JLcom/thalmic/myo/Arm;Lcom/thalmic/myo/XDirection;)V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onArmRecognized_Lcom_thalmic_myo_Myo_JLcom_thalmic_myo_Arm_Lcom_thalmic_myo_XDirection_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onArmRecognized", "(Lcom/thalmic/myo/Myo;JLcom/thalmic/myo/Arm;Lcom/thalmic/myo/XDirection;)V"), new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
			} finally {
			}
		}

		static Delegate cb_onConnect_Lcom_thalmic_myo_Myo_J;
#pragma warning disable 0169
		static Delegate GetOnConnect_Lcom_thalmic_myo_Myo_JHandler ()
		{
			if (cb_onConnect_Lcom_thalmic_myo_Myo_J == null)
				cb_onConnect_Lcom_thalmic_myo_Myo_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long>) n_OnConnect_Lcom_thalmic_myo_Myo_J);
			return cb_onConnect_Lcom_thalmic_myo_Myo_J;
		}

		static void n_OnConnect_Lcom_thalmic_myo_Myo_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			global::Com.Thalmic.Myo.AbstractDeviceListener __this = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.AbstractDeviceListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Thalmic.Myo.Myo p0 = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Myo> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnConnect (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onConnect_Lcom_thalmic_myo_Myo_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo']/class[@name='AbstractDeviceListener']/method[@name='onConnect' and count(parameter)=2 and parameter[1][@type='com.thalmic.myo.Myo'] and parameter[2][@type='long']]"
		[Register ("onConnect", "(Lcom/thalmic/myo/Myo;J)V", "GetOnConnect_Lcom_thalmic_myo_Myo_JHandler")]
		public virtual void OnConnect (global::Com.Thalmic.Myo.Myo p0, long p1)
		{
			if (id_onConnect_Lcom_thalmic_myo_Myo_J == IntPtr.Zero)
				id_onConnect_Lcom_thalmic_myo_Myo_J = JNIEnv.GetMethodID (class_ref, "onConnect", "(Lcom/thalmic/myo/Myo;J)V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onConnect_Lcom_thalmic_myo_Myo_J, new JValue (p0), new JValue (p1));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onConnect", "(Lcom/thalmic/myo/Myo;J)V"), new JValue (p0), new JValue (p1));
			} finally {
			}
		}

		static Delegate cb_onDisconnect_Lcom_thalmic_myo_Myo_J;
#pragma warning disable 0169
		static Delegate GetOnDisconnect_Lcom_thalmic_myo_Myo_JHandler ()
		{
			if (cb_onDisconnect_Lcom_thalmic_myo_Myo_J == null)
				cb_onDisconnect_Lcom_thalmic_myo_Myo_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long>) n_OnDisconnect_Lcom_thalmic_myo_Myo_J);
			return cb_onDisconnect_Lcom_thalmic_myo_Myo_J;
		}

		static void n_OnDisconnect_Lcom_thalmic_myo_Myo_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			global::Com.Thalmic.Myo.AbstractDeviceListener __this = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.AbstractDeviceListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Thalmic.Myo.Myo p0 = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Myo> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDisconnect (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onDisconnect_Lcom_thalmic_myo_Myo_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo']/class[@name='AbstractDeviceListener']/method[@name='onDisconnect' and count(parameter)=2 and parameter[1][@type='com.thalmic.myo.Myo'] and parameter[2][@type='long']]"
		[Register ("onDisconnect", "(Lcom/thalmic/myo/Myo;J)V", "GetOnDisconnect_Lcom_thalmic_myo_Myo_JHandler")]
		public virtual void OnDisconnect (global::Com.Thalmic.Myo.Myo p0, long p1)
		{
			if (id_onDisconnect_Lcom_thalmic_myo_Myo_J == IntPtr.Zero)
				id_onDisconnect_Lcom_thalmic_myo_Myo_J = JNIEnv.GetMethodID (class_ref, "onDisconnect", "(Lcom/thalmic/myo/Myo;J)V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onDisconnect_Lcom_thalmic_myo_Myo_J, new JValue (p0), new JValue (p1));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDisconnect", "(Lcom/thalmic/myo/Myo;J)V"), new JValue (p0), new JValue (p1));
			} finally {
			}
		}

		static Delegate cb_onGyroscopeData_Lcom_thalmic_myo_Myo_JLcom_thalmic_myo_Vector3_;
#pragma warning disable 0169
		static Delegate GetOnGyroscopeData_Lcom_thalmic_myo_Myo_JLcom_thalmic_myo_Vector3_Handler ()
		{
			if (cb_onGyroscopeData_Lcom_thalmic_myo_Myo_JLcom_thalmic_myo_Vector3_ == null)
				cb_onGyroscopeData_Lcom_thalmic_myo_Myo_JLcom_thalmic_myo_Vector3_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long, IntPtr>) n_OnGyroscopeData_Lcom_thalmic_myo_Myo_JLcom_thalmic_myo_Vector3_);
			return cb_onGyroscopeData_Lcom_thalmic_myo_Myo_JLcom_thalmic_myo_Vector3_;
		}

		static void n_OnGyroscopeData_Lcom_thalmic_myo_Myo_JLcom_thalmic_myo_Vector3_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1, IntPtr native_p2)
		{
			global::Com.Thalmic.Myo.AbstractDeviceListener __this = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.AbstractDeviceListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Thalmic.Myo.Myo p0 = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Myo> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Thalmic.Myo.Vector3 p2 = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Vector3> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnGyroscopeData (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_onGyroscopeData_Lcom_thalmic_myo_Myo_JLcom_thalmic_myo_Vector3_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo']/class[@name='AbstractDeviceListener']/method[@name='onGyroscopeData' and count(parameter)=3 and parameter[1][@type='com.thalmic.myo.Myo'] and parameter[2][@type='long'] and parameter[3][@type='com.thalmic.myo.Vector3']]"
		[Register ("onGyroscopeData", "(Lcom/thalmic/myo/Myo;JLcom/thalmic/myo/Vector3;)V", "GetOnGyroscopeData_Lcom_thalmic_myo_Myo_JLcom_thalmic_myo_Vector3_Handler")]
		public virtual void OnGyroscopeData (global::Com.Thalmic.Myo.Myo p0, long p1, global::Com.Thalmic.Myo.Vector3 p2)
		{
			if (id_onGyroscopeData_Lcom_thalmic_myo_Myo_JLcom_thalmic_myo_Vector3_ == IntPtr.Zero)
				id_onGyroscopeData_Lcom_thalmic_myo_Myo_JLcom_thalmic_myo_Vector3_ = JNIEnv.GetMethodID (class_ref, "onGyroscopeData", "(Lcom/thalmic/myo/Myo;JLcom/thalmic/myo/Vector3;)V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onGyroscopeData_Lcom_thalmic_myo_Myo_JLcom_thalmic_myo_Vector3_, new JValue (p0), new JValue (p1), new JValue (p2));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onGyroscopeData", "(Lcom/thalmic/myo/Myo;JLcom/thalmic/myo/Vector3;)V"), new JValue (p0), new JValue (p1), new JValue (p2));
			} finally {
			}
		}

		static Delegate cb_onOrientationData_Lcom_thalmic_myo_Myo_JLcom_thalmic_myo_Quaternion_;
#pragma warning disable 0169
		static Delegate GetOnOrientationData_Lcom_thalmic_myo_Myo_JLcom_thalmic_myo_Quaternion_Handler ()
		{
			if (cb_onOrientationData_Lcom_thalmic_myo_Myo_JLcom_thalmic_myo_Quaternion_ == null)
				cb_onOrientationData_Lcom_thalmic_myo_Myo_JLcom_thalmic_myo_Quaternion_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long, IntPtr>) n_OnOrientationData_Lcom_thalmic_myo_Myo_JLcom_thalmic_myo_Quaternion_);
			return cb_onOrientationData_Lcom_thalmic_myo_Myo_JLcom_thalmic_myo_Quaternion_;
		}

		static void n_OnOrientationData_Lcom_thalmic_myo_Myo_JLcom_thalmic_myo_Quaternion_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1, IntPtr native_p2)
		{
			global::Com.Thalmic.Myo.AbstractDeviceListener __this = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.AbstractDeviceListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Thalmic.Myo.Myo p0 = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Myo> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Thalmic.Myo.Quaternion p2 = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Quaternion> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnOrientationData (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_onOrientationData_Lcom_thalmic_myo_Myo_JLcom_thalmic_myo_Quaternion_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo']/class[@name='AbstractDeviceListener']/method[@name='onOrientationData' and count(parameter)=3 and parameter[1][@type='com.thalmic.myo.Myo'] and parameter[2][@type='long'] and parameter[3][@type='com.thalmic.myo.Quaternion']]"
		[Register ("onOrientationData", "(Lcom/thalmic/myo/Myo;JLcom/thalmic/myo/Quaternion;)V", "GetOnOrientationData_Lcom_thalmic_myo_Myo_JLcom_thalmic_myo_Quaternion_Handler")]
		public virtual void OnOrientationData (global::Com.Thalmic.Myo.Myo p0, long p1, global::Com.Thalmic.Myo.Quaternion p2)
		{
			if (id_onOrientationData_Lcom_thalmic_myo_Myo_JLcom_thalmic_myo_Quaternion_ == IntPtr.Zero)
				id_onOrientationData_Lcom_thalmic_myo_Myo_JLcom_thalmic_myo_Quaternion_ = JNIEnv.GetMethodID (class_ref, "onOrientationData", "(Lcom/thalmic/myo/Myo;JLcom/thalmic/myo/Quaternion;)V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onOrientationData_Lcom_thalmic_myo_Myo_JLcom_thalmic_myo_Quaternion_, new JValue (p0), new JValue (p1), new JValue (p2));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onOrientationData", "(Lcom/thalmic/myo/Myo;JLcom/thalmic/myo/Quaternion;)V"), new JValue (p0), new JValue (p1), new JValue (p2));
			} finally {
			}
		}

		static Delegate cb_onPair_Lcom_thalmic_myo_Myo_J;
#pragma warning disable 0169
		static Delegate GetOnPair_Lcom_thalmic_myo_Myo_JHandler ()
		{
			if (cb_onPair_Lcom_thalmic_myo_Myo_J == null)
				cb_onPair_Lcom_thalmic_myo_Myo_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long>) n_OnPair_Lcom_thalmic_myo_Myo_J);
			return cb_onPair_Lcom_thalmic_myo_Myo_J;
		}

		static void n_OnPair_Lcom_thalmic_myo_Myo_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			global::Com.Thalmic.Myo.AbstractDeviceListener __this = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.AbstractDeviceListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Thalmic.Myo.Myo p0 = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Myo> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnPair (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onPair_Lcom_thalmic_myo_Myo_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo']/class[@name='AbstractDeviceListener']/method[@name='onPair' and count(parameter)=2 and parameter[1][@type='com.thalmic.myo.Myo'] and parameter[2][@type='long']]"
		[Register ("onPair", "(Lcom/thalmic/myo/Myo;J)V", "GetOnPair_Lcom_thalmic_myo_Myo_JHandler")]
		public virtual void OnPair (global::Com.Thalmic.Myo.Myo p0, long p1)
		{
			if (id_onPair_Lcom_thalmic_myo_Myo_J == IntPtr.Zero)
				id_onPair_Lcom_thalmic_myo_Myo_J = JNIEnv.GetMethodID (class_ref, "onPair", "(Lcom/thalmic/myo/Myo;J)V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onPair_Lcom_thalmic_myo_Myo_J, new JValue (p0), new JValue (p1));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPair", "(Lcom/thalmic/myo/Myo;J)V"), new JValue (p0), new JValue (p1));
			} finally {
			}
		}

		static Delegate cb_onPose_Lcom_thalmic_myo_Myo_JLcom_thalmic_myo_Pose_;
#pragma warning disable 0169
		static Delegate GetOnPose_Lcom_thalmic_myo_Myo_JLcom_thalmic_myo_Pose_Handler ()
		{
			if (cb_onPose_Lcom_thalmic_myo_Myo_JLcom_thalmic_myo_Pose_ == null)
				cb_onPose_Lcom_thalmic_myo_Myo_JLcom_thalmic_myo_Pose_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long, IntPtr>) n_OnPose_Lcom_thalmic_myo_Myo_JLcom_thalmic_myo_Pose_);
			return cb_onPose_Lcom_thalmic_myo_Myo_JLcom_thalmic_myo_Pose_;
		}

		static void n_OnPose_Lcom_thalmic_myo_Myo_JLcom_thalmic_myo_Pose_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1, IntPtr native_p2)
		{
			global::Com.Thalmic.Myo.AbstractDeviceListener __this = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.AbstractDeviceListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Thalmic.Myo.Myo p0 = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Myo> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Thalmic.Myo.Pose p2 = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Pose> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnPose (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_onPose_Lcom_thalmic_myo_Myo_JLcom_thalmic_myo_Pose_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo']/class[@name='AbstractDeviceListener']/method[@name='onPose' and count(parameter)=3 and parameter[1][@type='com.thalmic.myo.Myo'] and parameter[2][@type='long'] and parameter[3][@type='com.thalmic.myo.Pose']]"
		[Register ("onPose", "(Lcom/thalmic/myo/Myo;JLcom/thalmic/myo/Pose;)V", "GetOnPose_Lcom_thalmic_myo_Myo_JLcom_thalmic_myo_Pose_Handler")]
		public virtual void OnPose (global::Com.Thalmic.Myo.Myo p0, long p1, global::Com.Thalmic.Myo.Pose p2)
		{
			if (id_onPose_Lcom_thalmic_myo_Myo_JLcom_thalmic_myo_Pose_ == IntPtr.Zero)
				id_onPose_Lcom_thalmic_myo_Myo_JLcom_thalmic_myo_Pose_ = JNIEnv.GetMethodID (class_ref, "onPose", "(Lcom/thalmic/myo/Myo;JLcom/thalmic/myo/Pose;)V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onPose_Lcom_thalmic_myo_Myo_JLcom_thalmic_myo_Pose_, new JValue (p0), new JValue (p1), new JValue (p2));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPose", "(Lcom/thalmic/myo/Myo;JLcom/thalmic/myo/Pose;)V"), new JValue (p0), new JValue (p1), new JValue (p2));
			} finally {
			}
		}

		static Delegate cb_onRssi_Lcom_thalmic_myo_Myo_JI;
#pragma warning disable 0169
		static Delegate GetOnRssi_Lcom_thalmic_myo_Myo_JIHandler ()
		{
			if (cb_onRssi_Lcom_thalmic_myo_Myo_JI == null)
				cb_onRssi_Lcom_thalmic_myo_Myo_JI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long, int>) n_OnRssi_Lcom_thalmic_myo_Myo_JI);
			return cb_onRssi_Lcom_thalmic_myo_Myo_JI;
		}

		static void n_OnRssi_Lcom_thalmic_myo_Myo_JI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1, int p2)
		{
			global::Com.Thalmic.Myo.AbstractDeviceListener __this = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.AbstractDeviceListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Thalmic.Myo.Myo p0 = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Myo> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnRssi (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_onRssi_Lcom_thalmic_myo_Myo_JI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo']/class[@name='AbstractDeviceListener']/method[@name='onRssi' and count(parameter)=3 and parameter[1][@type='com.thalmic.myo.Myo'] and parameter[2][@type='long'] and parameter[3][@type='int']]"
		[Register ("onRssi", "(Lcom/thalmic/myo/Myo;JI)V", "GetOnRssi_Lcom_thalmic_myo_Myo_JIHandler")]
		public virtual void OnRssi (global::Com.Thalmic.Myo.Myo p0, long p1, int p2)
		{
			if (id_onRssi_Lcom_thalmic_myo_Myo_JI == IntPtr.Zero)
				id_onRssi_Lcom_thalmic_myo_Myo_JI = JNIEnv.GetMethodID (class_ref, "onRssi", "(Lcom/thalmic/myo/Myo;JI)V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onRssi_Lcom_thalmic_myo_Myo_JI, new JValue (p0), new JValue (p1), new JValue (p2));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onRssi", "(Lcom/thalmic/myo/Myo;JI)V"), new JValue (p0), new JValue (p1), new JValue (p2));
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/thalmic/myo/AbstractDeviceListener", DoNotGenerateAcw=true)]
	internal partial class AbstractDeviceListenerInvoker : AbstractDeviceListener {

		public AbstractDeviceListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbstractDeviceListenerInvoker); }
		}

	}

}
