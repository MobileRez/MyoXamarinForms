using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Thalmic.Myo {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.thalmic.myo']/interface[@name='DeviceListener']"
	[Register ("com/thalmic/myo/DeviceListener", "", "Com.Thalmic.Myo.IDeviceListenerInvoker")]
	public partial interface IDeviceListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo']/interface[@name='DeviceListener']/method[@name='onAccelerometerData' and count(parameter)=3 and parameter[1][@type='com.thalmic.myo.Myo'] and parameter[2][@type='long'] and parameter[3][@type='com.thalmic.myo.Vector3']]"
		[Register ("onAccelerometerData", "(Lcom/thalmic/myo/Myo;JLcom/thalmic/myo/Vector3;)V", "GetOnAccelerometerData_Lcom_thalmic_myo_Myo_JLcom_thalmic_myo_Vector3_Handler:Com.Thalmic.Myo.IDeviceListenerInvoker, MyoXamrinJavaBindinglib")]
		void OnAccelerometerData (global::Com.Thalmic.Myo.Myo p0, long p1, global::Com.Thalmic.Myo.Vector3 p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo']/interface[@name='DeviceListener']/method[@name='onArmLost' and count(parameter)=2 and parameter[1][@type='com.thalmic.myo.Myo'] and parameter[2][@type='long']]"
		[Register ("onArmLost", "(Lcom/thalmic/myo/Myo;J)V", "GetOnArmLost_Lcom_thalmic_myo_Myo_JHandler:Com.Thalmic.Myo.IDeviceListenerInvoker, MyoXamrinJavaBindinglib")]
		void OnArmLost (global::Com.Thalmic.Myo.Myo p0, long p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo']/interface[@name='DeviceListener']/method[@name='onArmRecognized' and count(parameter)=4 and parameter[1][@type='com.thalmic.myo.Myo'] and parameter[2][@type='long'] and parameter[3][@type='com.thalmic.myo.Arm'] and parameter[4][@type='com.thalmic.myo.XDirection']]"
		[Register ("onArmRecognized", "(Lcom/thalmic/myo/Myo;JLcom/thalmic/myo/Arm;Lcom/thalmic/myo/XDirection;)V", "GetOnArmRecognized_Lcom_thalmic_myo_Myo_JLcom_thalmic_myo_Arm_Lcom_thalmic_myo_XDirection_Handler:Com.Thalmic.Myo.IDeviceListenerInvoker, MyoXamrinJavaBindinglib")]
		void OnArmRecognized (global::Com.Thalmic.Myo.Myo p0, long p1, global::Com.Thalmic.Myo.Arm p2, global::Com.Thalmic.Myo.XDirection p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo']/interface[@name='DeviceListener']/method[@name='onConnect' and count(parameter)=2 and parameter[1][@type='com.thalmic.myo.Myo'] and parameter[2][@type='long']]"
		[Register ("onConnect", "(Lcom/thalmic/myo/Myo;J)V", "GetOnConnect_Lcom_thalmic_myo_Myo_JHandler:Com.Thalmic.Myo.IDeviceListenerInvoker, MyoXamrinJavaBindinglib")]
		void OnConnect (global::Com.Thalmic.Myo.Myo p0, long p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo']/interface[@name='DeviceListener']/method[@name='onDisconnect' and count(parameter)=2 and parameter[1][@type='com.thalmic.myo.Myo'] and parameter[2][@type='long']]"
		[Register ("onDisconnect", "(Lcom/thalmic/myo/Myo;J)V", "GetOnDisconnect_Lcom_thalmic_myo_Myo_JHandler:Com.Thalmic.Myo.IDeviceListenerInvoker, MyoXamrinJavaBindinglib")]
		void OnDisconnect (global::Com.Thalmic.Myo.Myo p0, long p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo']/interface[@name='DeviceListener']/method[@name='onGyroscopeData' and count(parameter)=3 and parameter[1][@type='com.thalmic.myo.Myo'] and parameter[2][@type='long'] and parameter[3][@type='com.thalmic.myo.Vector3']]"
		[Register ("onGyroscopeData", "(Lcom/thalmic/myo/Myo;JLcom/thalmic/myo/Vector3;)V", "GetOnGyroscopeData_Lcom_thalmic_myo_Myo_JLcom_thalmic_myo_Vector3_Handler:Com.Thalmic.Myo.IDeviceListenerInvoker, MyoXamrinJavaBindinglib")]
		void OnGyroscopeData (global::Com.Thalmic.Myo.Myo p0, long p1, global::Com.Thalmic.Myo.Vector3 p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo']/interface[@name='DeviceListener']/method[@name='onOrientationData' and count(parameter)=3 and parameter[1][@type='com.thalmic.myo.Myo'] and parameter[2][@type='long'] and parameter[3][@type='com.thalmic.myo.Quaternion']]"
		[Register ("onOrientationData", "(Lcom/thalmic/myo/Myo;JLcom/thalmic/myo/Quaternion;)V", "GetOnOrientationData_Lcom_thalmic_myo_Myo_JLcom_thalmic_myo_Quaternion_Handler:Com.Thalmic.Myo.IDeviceListenerInvoker, MyoXamrinJavaBindinglib")]
		void OnOrientationData (global::Com.Thalmic.Myo.Myo p0, long p1, global::Com.Thalmic.Myo.Quaternion p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo']/interface[@name='DeviceListener']/method[@name='onPair' and count(parameter)=2 and parameter[1][@type='com.thalmic.myo.Myo'] and parameter[2][@type='long']]"
		[Register ("onPair", "(Lcom/thalmic/myo/Myo;J)V", "GetOnPair_Lcom_thalmic_myo_Myo_JHandler:Com.Thalmic.Myo.IDeviceListenerInvoker, MyoXamrinJavaBindinglib")]
		void OnPair (global::Com.Thalmic.Myo.Myo p0, long p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo']/interface[@name='DeviceListener']/method[@name='onPose' and count(parameter)=3 and parameter[1][@type='com.thalmic.myo.Myo'] and parameter[2][@type='long'] and parameter[3][@type='com.thalmic.myo.Pose']]"
		[Register ("onPose", "(Lcom/thalmic/myo/Myo;JLcom/thalmic/myo/Pose;)V", "GetOnPose_Lcom_thalmic_myo_Myo_JLcom_thalmic_myo_Pose_Handler:Com.Thalmic.Myo.IDeviceListenerInvoker, MyoXamrinJavaBindinglib")]
		void OnPose (global::Com.Thalmic.Myo.Myo p0, long p1, global::Com.Thalmic.Myo.Pose p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo']/interface[@name='DeviceListener']/method[@name='onRssi' and count(parameter)=3 and parameter[1][@type='com.thalmic.myo.Myo'] and parameter[2][@type='long'] and parameter[3][@type='int']]"
		[Register ("onRssi", "(Lcom/thalmic/myo/Myo;JI)V", "GetOnRssi_Lcom_thalmic_myo_Myo_JIHandler:Com.Thalmic.Myo.IDeviceListenerInvoker, MyoXamrinJavaBindinglib")]
		void OnRssi (global::Com.Thalmic.Myo.Myo p0, long p1, int p2);

	}

	[global::Android.Runtime.Register ("com/thalmic/myo/DeviceListener", DoNotGenerateAcw=true)]
	internal class IDeviceListenerInvoker : global::Java.Lang.Object, IDeviceListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/thalmic/myo/DeviceListener");
		IntPtr class_ref;

		public static IDeviceListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDeviceListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.thalmic.myo.DeviceListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDeviceListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IDeviceListenerInvoker); }
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
			global::Com.Thalmic.Myo.IDeviceListener __this = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.IDeviceListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Thalmic.Myo.Myo p0 = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Myo> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Thalmic.Myo.Vector3 p2 = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Vector3> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnAccelerometerData (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onAccelerometerData_Lcom_thalmic_myo_Myo_JLcom_thalmic_myo_Vector3_;
		public void OnAccelerometerData (global::Com.Thalmic.Myo.Myo p0, long p1, global::Com.Thalmic.Myo.Vector3 p2)
		{
			if (id_onAccelerometerData_Lcom_thalmic_myo_Myo_JLcom_thalmic_myo_Vector3_ == IntPtr.Zero)
				id_onAccelerometerData_Lcom_thalmic_myo_Myo_JLcom_thalmic_myo_Vector3_ = JNIEnv.GetMethodID (class_ref, "onAccelerometerData", "(Lcom/thalmic/myo/Myo;JLcom/thalmic/myo/Vector3;)V");
			JNIEnv.CallVoidMethod (Handle, id_onAccelerometerData_Lcom_thalmic_myo_Myo_JLcom_thalmic_myo_Vector3_, new JValue (p0), new JValue (p1), new JValue (p2));
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
			global::Com.Thalmic.Myo.IDeviceListener __this = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.IDeviceListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Thalmic.Myo.Myo p0 = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Myo> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnArmLost (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onArmLost_Lcom_thalmic_myo_Myo_J;
		public void OnArmLost (global::Com.Thalmic.Myo.Myo p0, long p1)
		{
			if (id_onArmLost_Lcom_thalmic_myo_Myo_J == IntPtr.Zero)
				id_onArmLost_Lcom_thalmic_myo_Myo_J = JNIEnv.GetMethodID (class_ref, "onArmLost", "(Lcom/thalmic/myo/Myo;J)V");
			JNIEnv.CallVoidMethod (Handle, id_onArmLost_Lcom_thalmic_myo_Myo_J, new JValue (p0), new JValue (p1));
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
			global::Com.Thalmic.Myo.IDeviceListener __this = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.IDeviceListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Thalmic.Myo.Myo p0 = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Myo> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Thalmic.Myo.Arm p2 = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Arm> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Com.Thalmic.Myo.XDirection p3 = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.XDirection> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.OnArmRecognized (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_onArmRecognized_Lcom_thalmic_myo_Myo_JLcom_thalmic_myo_Arm_Lcom_thalmic_myo_XDirection_;
		public void OnArmRecognized (global::Com.Thalmic.Myo.Myo p0, long p1, global::Com.Thalmic.Myo.Arm p2, global::Com.Thalmic.Myo.XDirection p3)
		{
			if (id_onArmRecognized_Lcom_thalmic_myo_Myo_JLcom_thalmic_myo_Arm_Lcom_thalmic_myo_XDirection_ == IntPtr.Zero)
				id_onArmRecognized_Lcom_thalmic_myo_Myo_JLcom_thalmic_myo_Arm_Lcom_thalmic_myo_XDirection_ = JNIEnv.GetMethodID (class_ref, "onArmRecognized", "(Lcom/thalmic/myo/Myo;JLcom/thalmic/myo/Arm;Lcom/thalmic/myo/XDirection;)V");
			JNIEnv.CallVoidMethod (Handle, id_onArmRecognized_Lcom_thalmic_myo_Myo_JLcom_thalmic_myo_Arm_Lcom_thalmic_myo_XDirection_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
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
			global::Com.Thalmic.Myo.IDeviceListener __this = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.IDeviceListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Thalmic.Myo.Myo p0 = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Myo> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnConnect (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onConnect_Lcom_thalmic_myo_Myo_J;
		public void OnConnect (global::Com.Thalmic.Myo.Myo p0, long p1)
		{
			if (id_onConnect_Lcom_thalmic_myo_Myo_J == IntPtr.Zero)
				id_onConnect_Lcom_thalmic_myo_Myo_J = JNIEnv.GetMethodID (class_ref, "onConnect", "(Lcom/thalmic/myo/Myo;J)V");
			JNIEnv.CallVoidMethod (Handle, id_onConnect_Lcom_thalmic_myo_Myo_J, new JValue (p0), new JValue (p1));
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
			global::Com.Thalmic.Myo.IDeviceListener __this = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.IDeviceListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Thalmic.Myo.Myo p0 = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Myo> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDisconnect (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onDisconnect_Lcom_thalmic_myo_Myo_J;
		public void OnDisconnect (global::Com.Thalmic.Myo.Myo p0, long p1)
		{
			if (id_onDisconnect_Lcom_thalmic_myo_Myo_J == IntPtr.Zero)
				id_onDisconnect_Lcom_thalmic_myo_Myo_J = JNIEnv.GetMethodID (class_ref, "onDisconnect", "(Lcom/thalmic/myo/Myo;J)V");
			JNIEnv.CallVoidMethod (Handle, id_onDisconnect_Lcom_thalmic_myo_Myo_J, new JValue (p0), new JValue (p1));
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
			global::Com.Thalmic.Myo.IDeviceListener __this = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.IDeviceListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Thalmic.Myo.Myo p0 = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Myo> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Thalmic.Myo.Vector3 p2 = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Vector3> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnGyroscopeData (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onGyroscopeData_Lcom_thalmic_myo_Myo_JLcom_thalmic_myo_Vector3_;
		public void OnGyroscopeData (global::Com.Thalmic.Myo.Myo p0, long p1, global::Com.Thalmic.Myo.Vector3 p2)
		{
			if (id_onGyroscopeData_Lcom_thalmic_myo_Myo_JLcom_thalmic_myo_Vector3_ == IntPtr.Zero)
				id_onGyroscopeData_Lcom_thalmic_myo_Myo_JLcom_thalmic_myo_Vector3_ = JNIEnv.GetMethodID (class_ref, "onGyroscopeData", "(Lcom/thalmic/myo/Myo;JLcom/thalmic/myo/Vector3;)V");
			JNIEnv.CallVoidMethod (Handle, id_onGyroscopeData_Lcom_thalmic_myo_Myo_JLcom_thalmic_myo_Vector3_, new JValue (p0), new JValue (p1), new JValue (p2));
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
			global::Com.Thalmic.Myo.IDeviceListener __this = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.IDeviceListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Thalmic.Myo.Myo p0 = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Myo> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Thalmic.Myo.Quaternion p2 = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Quaternion> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnOrientationData (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onOrientationData_Lcom_thalmic_myo_Myo_JLcom_thalmic_myo_Quaternion_;
		public void OnOrientationData (global::Com.Thalmic.Myo.Myo p0, long p1, global::Com.Thalmic.Myo.Quaternion p2)
		{
			if (id_onOrientationData_Lcom_thalmic_myo_Myo_JLcom_thalmic_myo_Quaternion_ == IntPtr.Zero)
				id_onOrientationData_Lcom_thalmic_myo_Myo_JLcom_thalmic_myo_Quaternion_ = JNIEnv.GetMethodID (class_ref, "onOrientationData", "(Lcom/thalmic/myo/Myo;JLcom/thalmic/myo/Quaternion;)V");
			JNIEnv.CallVoidMethod (Handle, id_onOrientationData_Lcom_thalmic_myo_Myo_JLcom_thalmic_myo_Quaternion_, new JValue (p0), new JValue (p1), new JValue (p2));
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
			global::Com.Thalmic.Myo.IDeviceListener __this = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.IDeviceListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Thalmic.Myo.Myo p0 = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Myo> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnPair (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onPair_Lcom_thalmic_myo_Myo_J;
		public void OnPair (global::Com.Thalmic.Myo.Myo p0, long p1)
		{
			if (id_onPair_Lcom_thalmic_myo_Myo_J == IntPtr.Zero)
				id_onPair_Lcom_thalmic_myo_Myo_J = JNIEnv.GetMethodID (class_ref, "onPair", "(Lcom/thalmic/myo/Myo;J)V");
			JNIEnv.CallVoidMethod (Handle, id_onPair_Lcom_thalmic_myo_Myo_J, new JValue (p0), new JValue (p1));
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
			global::Com.Thalmic.Myo.IDeviceListener __this = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.IDeviceListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Thalmic.Myo.Myo p0 = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Myo> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Thalmic.Myo.Pose p2 = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Pose> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnPose (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onPose_Lcom_thalmic_myo_Myo_JLcom_thalmic_myo_Pose_;
		public void OnPose (global::Com.Thalmic.Myo.Myo p0, long p1, global::Com.Thalmic.Myo.Pose p2)
		{
			if (id_onPose_Lcom_thalmic_myo_Myo_JLcom_thalmic_myo_Pose_ == IntPtr.Zero)
				id_onPose_Lcom_thalmic_myo_Myo_JLcom_thalmic_myo_Pose_ = JNIEnv.GetMethodID (class_ref, "onPose", "(Lcom/thalmic/myo/Myo;JLcom/thalmic/myo/Pose;)V");
			JNIEnv.CallVoidMethod (Handle, id_onPose_Lcom_thalmic_myo_Myo_JLcom_thalmic_myo_Pose_, new JValue (p0), new JValue (p1), new JValue (p2));
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
			global::Com.Thalmic.Myo.IDeviceListener __this = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.IDeviceListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Thalmic.Myo.Myo p0 = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Myo> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnRssi (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onRssi_Lcom_thalmic_myo_Myo_JI;
		public void OnRssi (global::Com.Thalmic.Myo.Myo p0, long p1, int p2)
		{
			if (id_onRssi_Lcom_thalmic_myo_Myo_JI == IntPtr.Zero)
				id_onRssi_Lcom_thalmic_myo_Myo_JI = JNIEnv.GetMethodID (class_ref, "onRssi", "(Lcom/thalmic/myo/Myo;JI)V");
			JNIEnv.CallVoidMethod (Handle, id_onRssi_Lcom_thalmic_myo_Myo_JI, new JValue (p0), new JValue (p1), new JValue (p2));
		}

	}

	public partial class AccelerometerDataEventArgs : global::System.EventArgs {

		public AccelerometerDataEventArgs (global::Com.Thalmic.Myo.Myo p0, long p1, global::Com.Thalmic.Myo.Vector3 p2)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
		}

		global::Com.Thalmic.Myo.Myo p0;
		public global::Com.Thalmic.Myo.Myo P0 {
			get { return p0; }
		}

		long p1;
		public long P1 {
			get { return p1; }
		}

		global::Com.Thalmic.Myo.Vector3 p2;
		public global::Com.Thalmic.Myo.Vector3 P2 {
			get { return p2; }
		}
	}

	public partial class ArmLostEventArgs : global::System.EventArgs {

		public ArmLostEventArgs (global::Com.Thalmic.Myo.Myo p0, long p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Com.Thalmic.Myo.Myo p0;
		public global::Com.Thalmic.Myo.Myo P0 {
			get { return p0; }
		}

		long p1;
		public long P1 {
			get { return p1; }
		}
	}

	public partial class ArmRecognizedEventArgs : global::System.EventArgs {

		public ArmRecognizedEventArgs (global::Com.Thalmic.Myo.Myo p0, long p1, global::Com.Thalmic.Myo.Arm p2, global::Com.Thalmic.Myo.XDirection p3)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
			this.p3 = p3;
		}

		global::Com.Thalmic.Myo.Myo p0;
		public global::Com.Thalmic.Myo.Myo P0 {
			get { return p0; }
		}

		long p1;
		public long P1 {
			get { return p1; }
		}

		global::Com.Thalmic.Myo.Arm p2;
		public global::Com.Thalmic.Myo.Arm P2 {
			get { return p2; }
		}

		global::Com.Thalmic.Myo.XDirection p3;
		public global::Com.Thalmic.Myo.XDirection P3 {
			get { return p3; }
		}
	}

	public partial class ConnectEventArgs : global::System.EventArgs {

		public ConnectEventArgs (global::Com.Thalmic.Myo.Myo p0, long p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Com.Thalmic.Myo.Myo p0;
		public global::Com.Thalmic.Myo.Myo P0 {
			get { return p0; }
		}

		long p1;
		public long P1 {
			get { return p1; }
		}
	}

	public partial class DisconnectEventArgs : global::System.EventArgs {

		public DisconnectEventArgs (global::Com.Thalmic.Myo.Myo p0, long p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Com.Thalmic.Myo.Myo p0;
		public global::Com.Thalmic.Myo.Myo P0 {
			get { return p0; }
		}

		long p1;
		public long P1 {
			get { return p1; }
		}
	}

	public partial class GyroscopeDataEventArgs : global::System.EventArgs {

		public GyroscopeDataEventArgs (global::Com.Thalmic.Myo.Myo p0, long p1, global::Com.Thalmic.Myo.Vector3 p2)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
		}

		global::Com.Thalmic.Myo.Myo p0;
		public global::Com.Thalmic.Myo.Myo P0 {
			get { return p0; }
		}

		long p1;
		public long P1 {
			get { return p1; }
		}

		global::Com.Thalmic.Myo.Vector3 p2;
		public global::Com.Thalmic.Myo.Vector3 P2 {
			get { return p2; }
		}
	}

	public partial class OrientationDataEventArgs : global::System.EventArgs {

		public OrientationDataEventArgs (global::Com.Thalmic.Myo.Myo p0, long p1, global::Com.Thalmic.Myo.Quaternion p2)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
		}

		global::Com.Thalmic.Myo.Myo p0;
		public global::Com.Thalmic.Myo.Myo P0 {
			get { return p0; }
		}

		long p1;
		public long P1 {
			get { return p1; }
		}

		global::Com.Thalmic.Myo.Quaternion p2;
		public global::Com.Thalmic.Myo.Quaternion P2 {
			get { return p2; }
		}
	}

	public partial class PairEventArgs : global::System.EventArgs {

		public PairEventArgs (global::Com.Thalmic.Myo.Myo p0, long p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Com.Thalmic.Myo.Myo p0;
		public global::Com.Thalmic.Myo.Myo P0 {
			get { return p0; }
		}

		long p1;
		public long P1 {
			get { return p1; }
		}
	}

	public partial class PoseEventArgs : global::System.EventArgs {

		public PoseEventArgs (global::Com.Thalmic.Myo.Myo p0, long p1, global::Com.Thalmic.Myo.Pose p2)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
		}

		global::Com.Thalmic.Myo.Myo p0;
		public global::Com.Thalmic.Myo.Myo P0 {
			get { return p0; }
		}

		long p1;
		public long P1 {
			get { return p1; }
		}

		global::Com.Thalmic.Myo.Pose p2;
		public global::Com.Thalmic.Myo.Pose P2 {
			get { return p2; }
		}
	}

	public partial class RssiEventArgs : global::System.EventArgs {

		public RssiEventArgs (global::Com.Thalmic.Myo.Myo p0, long p1, int p2)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
		}

		global::Com.Thalmic.Myo.Myo p0;
		public global::Com.Thalmic.Myo.Myo P0 {
			get { return p0; }
		}

		long p1;
		public long P1 {
			get { return p1; }
		}

		int p2;
		public int P2 {
			get { return p2; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/thalmic/myo/DeviceListenerImplementor")]
	internal sealed partial class IDeviceListenerImplementor : global::Java.Lang.Object, IDeviceListener {

		object sender;

		public IDeviceListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/thalmic/myo/DeviceListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<AccelerometerDataEventArgs> OnAccelerometerDataHandler;
#pragma warning restore 0649

		public void OnAccelerometerData (global::Com.Thalmic.Myo.Myo p0, long p1, global::Com.Thalmic.Myo.Vector3 p2)
		{
			var __h = OnAccelerometerDataHandler;
			if (__h != null)
				__h (sender, new AccelerometerDataEventArgs (p0, p1, p2));
		}
#pragma warning disable 0649
		public EventHandler<ArmLostEventArgs> OnArmLostHandler;
#pragma warning restore 0649

		public void OnArmLost (global::Com.Thalmic.Myo.Myo p0, long p1)
		{
			var __h = OnArmLostHandler;
			if (__h != null)
				__h (sender, new ArmLostEventArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler<ArmRecognizedEventArgs> OnArmRecognizedHandler;
#pragma warning restore 0649

		public void OnArmRecognized (global::Com.Thalmic.Myo.Myo p0, long p1, global::Com.Thalmic.Myo.Arm p2, global::Com.Thalmic.Myo.XDirection p3)
		{
			var __h = OnArmRecognizedHandler;
			if (__h != null)
				__h (sender, new ArmRecognizedEventArgs (p0, p1, p2, p3));
		}
#pragma warning disable 0649
		public EventHandler<ConnectEventArgs> OnConnectHandler;
#pragma warning restore 0649

		public void OnConnect (global::Com.Thalmic.Myo.Myo p0, long p1)
		{
			var __h = OnConnectHandler;
			if (__h != null)
				__h (sender, new ConnectEventArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler<DisconnectEventArgs> OnDisconnectHandler;
#pragma warning restore 0649

		public void OnDisconnect (global::Com.Thalmic.Myo.Myo p0, long p1)
		{
			var __h = OnDisconnectHandler;
			if (__h != null)
				__h (sender, new DisconnectEventArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler<GyroscopeDataEventArgs> OnGyroscopeDataHandler;
#pragma warning restore 0649

		public void OnGyroscopeData (global::Com.Thalmic.Myo.Myo p0, long p1, global::Com.Thalmic.Myo.Vector3 p2)
		{
			var __h = OnGyroscopeDataHandler;
			if (__h != null)
				__h (sender, new GyroscopeDataEventArgs (p0, p1, p2));
		}
#pragma warning disable 0649
		public EventHandler<OrientationDataEventArgs> OnOrientationDataHandler;
#pragma warning restore 0649

		public void OnOrientationData (global::Com.Thalmic.Myo.Myo p0, long p1, global::Com.Thalmic.Myo.Quaternion p2)
		{
			var __h = OnOrientationDataHandler;
			if (__h != null)
				__h (sender, new OrientationDataEventArgs (p0, p1, p2));
		}
#pragma warning disable 0649
		public EventHandler<PairEventArgs> OnPairHandler;
#pragma warning restore 0649

		public void OnPair (global::Com.Thalmic.Myo.Myo p0, long p1)
		{
			var __h = OnPairHandler;
			if (__h != null)
				__h (sender, new PairEventArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler<PoseEventArgs> OnPoseHandler;
#pragma warning restore 0649

		public void OnPose (global::Com.Thalmic.Myo.Myo p0, long p1, global::Com.Thalmic.Myo.Pose p2)
		{
			var __h = OnPoseHandler;
			if (__h != null)
				__h (sender, new PoseEventArgs (p0, p1, p2));
		}
#pragma warning disable 0649
		public EventHandler<RssiEventArgs> OnRssiHandler;
#pragma warning restore 0649

		public void OnRssi (global::Com.Thalmic.Myo.Myo p0, long p1, int p2)
		{
			var __h = OnRssiHandler;
			if (__h != null)
				__h (sender, new RssiEventArgs (p0, p1, p2));
		}

		internal static bool __IsEmpty (IDeviceListenerImplementor value)
		{
			return value.OnAccelerometerDataHandler == null && value.OnArmLostHandler == null && value.OnArmRecognizedHandler == null && value.OnConnectHandler == null && value.OnDisconnectHandler == null && value.OnGyroscopeDataHandler == null && value.OnOrientationDataHandler == null && value.OnPairHandler == null && value.OnPoseHandler == null && value.OnRssiHandler == null;
		}
	}

}
