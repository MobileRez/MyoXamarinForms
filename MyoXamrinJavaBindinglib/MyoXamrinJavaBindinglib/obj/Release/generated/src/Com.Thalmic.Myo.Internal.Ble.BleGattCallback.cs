using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Thalmic.Myo.Internal.Ble {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.thalmic.myo.internal.ble']/class[@name='BleGattCallback']"
	[global::Android.Runtime.Register ("com/thalmic/myo/internal/ble/BleGattCallback", DoNotGenerateAcw=true)]
	public abstract partial class BleGattCallback : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/thalmic/myo/internal/ble/BleGattCallback", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BleGattCallback); }
		}

		protected BleGattCallback (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.thalmic.myo.internal.ble']/class[@name='BleGattCallback']/constructor[@name='BleGattCallback' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public BleGattCallback () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (BleGattCallback)) {
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

		static Delegate cb_onCharacteristicChanged_Lcom_thalmic_myo_internal_ble_Address_Ljava_util_UUID_arrayB;
#pragma warning disable 0169
		static Delegate GetOnCharacteristicChanged_Lcom_thalmic_myo_internal_ble_Address_Ljava_util_UUID_arrayBHandler ()
		{
			if (cb_onCharacteristicChanged_Lcom_thalmic_myo_internal_ble_Address_Ljava_util_UUID_arrayB == null)
				cb_onCharacteristicChanged_Lcom_thalmic_myo_internal_ble_Address_Ljava_util_UUID_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnCharacteristicChanged_Lcom_thalmic_myo_internal_ble_Address_Ljava_util_UUID_arrayB);
			return cb_onCharacteristicChanged_Lcom_thalmic_myo_internal_ble_Address_Ljava_util_UUID_arrayB;
		}

		static void n_OnCharacteristicChanged_Lcom_thalmic_myo_internal_ble_Address_Ljava_util_UUID_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Thalmic.Myo.Internal.Ble.BleGattCallback __this = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Internal.Ble.BleGattCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Thalmic.Myo.Internal.Ble.Address p0 = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Internal.Ble.Address> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.UUID p1 = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_p1, JniHandleOwnership.DoNotTransfer);
			byte[] p2 = (byte[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.OnCharacteristicChanged (p0, p1, p2);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		static IntPtr id_onCharacteristicChanged_Lcom_thalmic_myo_internal_ble_Address_Ljava_util_UUID_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo.internal.ble']/class[@name='BleGattCallback']/method[@name='onCharacteristicChanged' and count(parameter)=3 and parameter[1][@type='com.thalmic.myo.internal.ble.Address'] and parameter[2][@type='java.util.UUID'] and parameter[3][@type='byte[]']]"
		[Register ("onCharacteristicChanged", "(Lcom/thalmic/myo/internal/ble/Address;Ljava/util/UUID;[B)V", "GetOnCharacteristicChanged_Lcom_thalmic_myo_internal_ble_Address_Ljava_util_UUID_arrayBHandler")]
		public virtual void OnCharacteristicChanged (global::Com.Thalmic.Myo.Internal.Ble.Address p0, global::Java.Util.UUID p1, byte[] p2)
		{
			if (id_onCharacteristicChanged_Lcom_thalmic_myo_internal_ble_Address_Ljava_util_UUID_arrayB == IntPtr.Zero)
				id_onCharacteristicChanged_Lcom_thalmic_myo_internal_ble_Address_Ljava_util_UUID_arrayB = JNIEnv.GetMethodID (class_ref, "onCharacteristicChanged", "(Lcom/thalmic/myo/internal/ble/Address;Ljava/util/UUID;[B)V");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onCharacteristicChanged_Lcom_thalmic_myo_internal_ble_Address_Ljava_util_UUID_arrayB, new JValue (p0), new JValue (p1), new JValue (native_p2));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCharacteristicChanged", "(Lcom/thalmic/myo/internal/ble/Address;Ljava/util/UUID;[B)V"), new JValue (p0), new JValue (p1), new JValue (native_p2));
			} finally {
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static Delegate cb_onCharacteristicRead_Lcom_thalmic_myo_internal_ble_Address_Ljava_util_UUID_arrayBZ;
#pragma warning disable 0169
		static Delegate GetOnCharacteristicRead_Lcom_thalmic_myo_internal_ble_Address_Ljava_util_UUID_arrayBZHandler ()
		{
			if (cb_onCharacteristicRead_Lcom_thalmic_myo_internal_ble_Address_Ljava_util_UUID_arrayBZ == null)
				cb_onCharacteristicRead_Lcom_thalmic_myo_internal_ble_Address_Ljava_util_UUID_arrayBZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_OnCharacteristicRead_Lcom_thalmic_myo_internal_ble_Address_Ljava_util_UUID_arrayBZ);
			return cb_onCharacteristicRead_Lcom_thalmic_myo_internal_ble_Address_Ljava_util_UUID_arrayBZ;
		}

		static void n_OnCharacteristicRead_Lcom_thalmic_myo_internal_ble_Address_Ljava_util_UUID_arrayBZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, bool p3)
		{
			global::Com.Thalmic.Myo.Internal.Ble.BleGattCallback __this = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Internal.Ble.BleGattCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Thalmic.Myo.Internal.Ble.Address p0 = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Internal.Ble.Address> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.UUID p1 = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_p1, JniHandleOwnership.DoNotTransfer);
			byte[] p2 = (byte[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.OnCharacteristicRead (p0, p1, p2, p3);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		static IntPtr id_onCharacteristicRead_Lcom_thalmic_myo_internal_ble_Address_Ljava_util_UUID_arrayBZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo.internal.ble']/class[@name='BleGattCallback']/method[@name='onCharacteristicRead' and count(parameter)=4 and parameter[1][@type='com.thalmic.myo.internal.ble.Address'] and parameter[2][@type='java.util.UUID'] and parameter[3][@type='byte[]'] and parameter[4][@type='boolean']]"
		[Register ("onCharacteristicRead", "(Lcom/thalmic/myo/internal/ble/Address;Ljava/util/UUID;[BZ)V", "GetOnCharacteristicRead_Lcom_thalmic_myo_internal_ble_Address_Ljava_util_UUID_arrayBZHandler")]
		public virtual void OnCharacteristicRead (global::Com.Thalmic.Myo.Internal.Ble.Address p0, global::Java.Util.UUID p1, byte[] p2, bool p3)
		{
			if (id_onCharacteristicRead_Lcom_thalmic_myo_internal_ble_Address_Ljava_util_UUID_arrayBZ == IntPtr.Zero)
				id_onCharacteristicRead_Lcom_thalmic_myo_internal_ble_Address_Ljava_util_UUID_arrayBZ = JNIEnv.GetMethodID (class_ref, "onCharacteristicRead", "(Lcom/thalmic/myo/internal/ble/Address;Ljava/util/UUID;[BZ)V");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onCharacteristicRead_Lcom_thalmic_myo_internal_ble_Address_Ljava_util_UUID_arrayBZ, new JValue (p0), new JValue (p1), new JValue (native_p2), new JValue (p3));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCharacteristicRead", "(Lcom/thalmic/myo/internal/ble/Address;Ljava/util/UUID;[BZ)V"), new JValue (p0), new JValue (p1), new JValue (native_p2), new JValue (p3));
			} finally {
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static Delegate cb_onCharacteristicWrite_Lcom_thalmic_myo_internal_ble_Address_Ljava_util_UUID_Z;
#pragma warning disable 0169
		static Delegate GetOnCharacteristicWrite_Lcom_thalmic_myo_internal_ble_Address_Ljava_util_UUID_ZHandler ()
		{
			if (cb_onCharacteristicWrite_Lcom_thalmic_myo_internal_ble_Address_Ljava_util_UUID_Z == null)
				cb_onCharacteristicWrite_Lcom_thalmic_myo_internal_ble_Address_Ljava_util_UUID_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_OnCharacteristicWrite_Lcom_thalmic_myo_internal_ble_Address_Ljava_util_UUID_Z);
			return cb_onCharacteristicWrite_Lcom_thalmic_myo_internal_ble_Address_Ljava_util_UUID_Z;
		}

		static void n_OnCharacteristicWrite_Lcom_thalmic_myo_internal_ble_Address_Ljava_util_UUID_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, bool p2)
		{
			global::Com.Thalmic.Myo.Internal.Ble.BleGattCallback __this = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Internal.Ble.BleGattCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Thalmic.Myo.Internal.Ble.Address p0 = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Internal.Ble.Address> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.UUID p1 = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnCharacteristicWrite (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_onCharacteristicWrite_Lcom_thalmic_myo_internal_ble_Address_Ljava_util_UUID_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo.internal.ble']/class[@name='BleGattCallback']/method[@name='onCharacteristicWrite' and count(parameter)=3 and parameter[1][@type='com.thalmic.myo.internal.ble.Address'] and parameter[2][@type='java.util.UUID'] and parameter[3][@type='boolean']]"
		[Register ("onCharacteristicWrite", "(Lcom/thalmic/myo/internal/ble/Address;Ljava/util/UUID;Z)V", "GetOnCharacteristicWrite_Lcom_thalmic_myo_internal_ble_Address_Ljava_util_UUID_ZHandler")]
		public virtual void OnCharacteristicWrite (global::Com.Thalmic.Myo.Internal.Ble.Address p0, global::Java.Util.UUID p1, bool p2)
		{
			if (id_onCharacteristicWrite_Lcom_thalmic_myo_internal_ble_Address_Ljava_util_UUID_Z == IntPtr.Zero)
				id_onCharacteristicWrite_Lcom_thalmic_myo_internal_ble_Address_Ljava_util_UUID_Z = JNIEnv.GetMethodID (class_ref, "onCharacteristicWrite", "(Lcom/thalmic/myo/internal/ble/Address;Ljava/util/UUID;Z)V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onCharacteristicWrite_Lcom_thalmic_myo_internal_ble_Address_Ljava_util_UUID_Z, new JValue (p0), new JValue (p1), new JValue (p2));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCharacteristicWrite", "(Lcom/thalmic/myo/internal/ble/Address;Ljava/util/UUID;Z)V"), new JValue (p0), new JValue (p1), new JValue (p2));
			} finally {
			}
		}

		static Delegate cb_onDeviceConnected_Lcom_thalmic_myo_internal_ble_Address_;
#pragma warning disable 0169
		static Delegate GetOnDeviceConnected_Lcom_thalmic_myo_internal_ble_Address_Handler ()
		{
			if (cb_onDeviceConnected_Lcom_thalmic_myo_internal_ble_Address_ == null)
				cb_onDeviceConnected_Lcom_thalmic_myo_internal_ble_Address_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDeviceConnected_Lcom_thalmic_myo_internal_ble_Address_);
			return cb_onDeviceConnected_Lcom_thalmic_myo_internal_ble_Address_;
		}

		static void n_OnDeviceConnected_Lcom_thalmic_myo_internal_ble_Address_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Thalmic.Myo.Internal.Ble.BleGattCallback __this = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Internal.Ble.BleGattCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Thalmic.Myo.Internal.Ble.Address p0 = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Internal.Ble.Address> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDeviceConnected (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onDeviceConnected_Lcom_thalmic_myo_internal_ble_Address_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo.internal.ble']/class[@name='BleGattCallback']/method[@name='onDeviceConnected' and count(parameter)=1 and parameter[1][@type='com.thalmic.myo.internal.ble.Address']]"
		[Register ("onDeviceConnected", "(Lcom/thalmic/myo/internal/ble/Address;)V", "GetOnDeviceConnected_Lcom_thalmic_myo_internal_ble_Address_Handler")]
		public virtual void OnDeviceConnected (global::Com.Thalmic.Myo.Internal.Ble.Address p0)
		{
			if (id_onDeviceConnected_Lcom_thalmic_myo_internal_ble_Address_ == IntPtr.Zero)
				id_onDeviceConnected_Lcom_thalmic_myo_internal_ble_Address_ = JNIEnv.GetMethodID (class_ref, "onDeviceConnected", "(Lcom/thalmic/myo/internal/ble/Address;)V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onDeviceConnected_Lcom_thalmic_myo_internal_ble_Address_, new JValue (p0));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDeviceConnected", "(Lcom/thalmic/myo/internal/ble/Address;)V"), new JValue (p0));
			} finally {
			}
		}

		static Delegate cb_onDeviceConnectionFailed_Lcom_thalmic_myo_internal_ble_Address_;
#pragma warning disable 0169
		static Delegate GetOnDeviceConnectionFailed_Lcom_thalmic_myo_internal_ble_Address_Handler ()
		{
			if (cb_onDeviceConnectionFailed_Lcom_thalmic_myo_internal_ble_Address_ == null)
				cb_onDeviceConnectionFailed_Lcom_thalmic_myo_internal_ble_Address_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDeviceConnectionFailed_Lcom_thalmic_myo_internal_ble_Address_);
			return cb_onDeviceConnectionFailed_Lcom_thalmic_myo_internal_ble_Address_;
		}

		static void n_OnDeviceConnectionFailed_Lcom_thalmic_myo_internal_ble_Address_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Thalmic.Myo.Internal.Ble.BleGattCallback __this = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Internal.Ble.BleGattCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Thalmic.Myo.Internal.Ble.Address p0 = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Internal.Ble.Address> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDeviceConnectionFailed (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onDeviceConnectionFailed_Lcom_thalmic_myo_internal_ble_Address_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo.internal.ble']/class[@name='BleGattCallback']/method[@name='onDeviceConnectionFailed' and count(parameter)=1 and parameter[1][@type='com.thalmic.myo.internal.ble.Address']]"
		[Register ("onDeviceConnectionFailed", "(Lcom/thalmic/myo/internal/ble/Address;)V", "GetOnDeviceConnectionFailed_Lcom_thalmic_myo_internal_ble_Address_Handler")]
		public virtual void OnDeviceConnectionFailed (global::Com.Thalmic.Myo.Internal.Ble.Address p0)
		{
			if (id_onDeviceConnectionFailed_Lcom_thalmic_myo_internal_ble_Address_ == IntPtr.Zero)
				id_onDeviceConnectionFailed_Lcom_thalmic_myo_internal_ble_Address_ = JNIEnv.GetMethodID (class_ref, "onDeviceConnectionFailed", "(Lcom/thalmic/myo/internal/ble/Address;)V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onDeviceConnectionFailed_Lcom_thalmic_myo_internal_ble_Address_, new JValue (p0));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDeviceConnectionFailed", "(Lcom/thalmic/myo/internal/ble/Address;)V"), new JValue (p0));
			} finally {
			}
		}

		static Delegate cb_onDeviceDisconnected_Lcom_thalmic_myo_internal_ble_Address_;
#pragma warning disable 0169
		static Delegate GetOnDeviceDisconnected_Lcom_thalmic_myo_internal_ble_Address_Handler ()
		{
			if (cb_onDeviceDisconnected_Lcom_thalmic_myo_internal_ble_Address_ == null)
				cb_onDeviceDisconnected_Lcom_thalmic_myo_internal_ble_Address_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDeviceDisconnected_Lcom_thalmic_myo_internal_ble_Address_);
			return cb_onDeviceDisconnected_Lcom_thalmic_myo_internal_ble_Address_;
		}

		static void n_OnDeviceDisconnected_Lcom_thalmic_myo_internal_ble_Address_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Thalmic.Myo.Internal.Ble.BleGattCallback __this = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Internal.Ble.BleGattCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Thalmic.Myo.Internal.Ble.Address p0 = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Internal.Ble.Address> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDeviceDisconnected (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onDeviceDisconnected_Lcom_thalmic_myo_internal_ble_Address_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo.internal.ble']/class[@name='BleGattCallback']/method[@name='onDeviceDisconnected' and count(parameter)=1 and parameter[1][@type='com.thalmic.myo.internal.ble.Address']]"
		[Register ("onDeviceDisconnected", "(Lcom/thalmic/myo/internal/ble/Address;)V", "GetOnDeviceDisconnected_Lcom_thalmic_myo_internal_ble_Address_Handler")]
		public virtual void OnDeviceDisconnected (global::Com.Thalmic.Myo.Internal.Ble.Address p0)
		{
			if (id_onDeviceDisconnected_Lcom_thalmic_myo_internal_ble_Address_ == IntPtr.Zero)
				id_onDeviceDisconnected_Lcom_thalmic_myo_internal_ble_Address_ = JNIEnv.GetMethodID (class_ref, "onDeviceDisconnected", "(Lcom/thalmic/myo/internal/ble/Address;)V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onDeviceDisconnected_Lcom_thalmic_myo_internal_ble_Address_, new JValue (p0));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDeviceDisconnected", "(Lcom/thalmic/myo/internal/ble/Address;)V"), new JValue (p0));
			} finally {
			}
		}

		static Delegate cb_onReadRemoteRssi_Lcom_thalmic_myo_internal_ble_Address_IZ;
#pragma warning disable 0169
		static Delegate GetOnReadRemoteRssi_Lcom_thalmic_myo_internal_ble_Address_IZHandler ()
		{
			if (cb_onReadRemoteRssi_Lcom_thalmic_myo_internal_ble_Address_IZ == null)
				cb_onReadRemoteRssi_Lcom_thalmic_myo_internal_ble_Address_IZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, bool>) n_OnReadRemoteRssi_Lcom_thalmic_myo_internal_ble_Address_IZ);
			return cb_onReadRemoteRssi_Lcom_thalmic_myo_internal_ble_Address_IZ;
		}

		static void n_OnReadRemoteRssi_Lcom_thalmic_myo_internal_ble_Address_IZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, bool p2)
		{
			global::Com.Thalmic.Myo.Internal.Ble.BleGattCallback __this = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Internal.Ble.BleGattCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Thalmic.Myo.Internal.Ble.Address p0 = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Internal.Ble.Address> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnReadRemoteRssi (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_onReadRemoteRssi_Lcom_thalmic_myo_internal_ble_Address_IZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo.internal.ble']/class[@name='BleGattCallback']/method[@name='onReadRemoteRssi' and count(parameter)=3 and parameter[1][@type='com.thalmic.myo.internal.ble.Address'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("onReadRemoteRssi", "(Lcom/thalmic/myo/internal/ble/Address;IZ)V", "GetOnReadRemoteRssi_Lcom_thalmic_myo_internal_ble_Address_IZHandler")]
		public virtual void OnReadRemoteRssi (global::Com.Thalmic.Myo.Internal.Ble.Address p0, int p1, bool p2)
		{
			if (id_onReadRemoteRssi_Lcom_thalmic_myo_internal_ble_Address_IZ == IntPtr.Zero)
				id_onReadRemoteRssi_Lcom_thalmic_myo_internal_ble_Address_IZ = JNIEnv.GetMethodID (class_ref, "onReadRemoteRssi", "(Lcom/thalmic/myo/internal/ble/Address;IZ)V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onReadRemoteRssi_Lcom_thalmic_myo_internal_ble_Address_IZ, new JValue (p0), new JValue (p1), new JValue (p2));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onReadRemoteRssi", "(Lcom/thalmic/myo/internal/ble/Address;IZ)V"), new JValue (p0), new JValue (p1), new JValue (p2));
			} finally {
			}
		}

		static Delegate cb_onServicesDiscovered_Lcom_thalmic_myo_internal_ble_Address_Z;
#pragma warning disable 0169
		static Delegate GetOnServicesDiscovered_Lcom_thalmic_myo_internal_ble_Address_ZHandler ()
		{
			if (cb_onServicesDiscovered_Lcom_thalmic_myo_internal_ble_Address_Z == null)
				cb_onServicesDiscovered_Lcom_thalmic_myo_internal_ble_Address_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_OnServicesDiscovered_Lcom_thalmic_myo_internal_ble_Address_Z);
			return cb_onServicesDiscovered_Lcom_thalmic_myo_internal_ble_Address_Z;
		}

		static void n_OnServicesDiscovered_Lcom_thalmic_myo_internal_ble_Address_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Thalmic.Myo.Internal.Ble.BleGattCallback __this = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Internal.Ble.BleGattCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Thalmic.Myo.Internal.Ble.Address p0 = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Internal.Ble.Address> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnServicesDiscovered (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onServicesDiscovered_Lcom_thalmic_myo_internal_ble_Address_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo.internal.ble']/class[@name='BleGattCallback']/method[@name='onServicesDiscovered' and count(parameter)=2 and parameter[1][@type='com.thalmic.myo.internal.ble.Address'] and parameter[2][@type='boolean']]"
		[Register ("onServicesDiscovered", "(Lcom/thalmic/myo/internal/ble/Address;Z)V", "GetOnServicesDiscovered_Lcom_thalmic_myo_internal_ble_Address_ZHandler")]
		public virtual void OnServicesDiscovered (global::Com.Thalmic.Myo.Internal.Ble.Address p0, bool p1)
		{
			if (id_onServicesDiscovered_Lcom_thalmic_myo_internal_ble_Address_Z == IntPtr.Zero)
				id_onServicesDiscovered_Lcom_thalmic_myo_internal_ble_Address_Z = JNIEnv.GetMethodID (class_ref, "onServicesDiscovered", "(Lcom/thalmic/myo/internal/ble/Address;Z)V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onServicesDiscovered_Lcom_thalmic_myo_internal_ble_Address_Z, new JValue (p0), new JValue (p1));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onServicesDiscovered", "(Lcom/thalmic/myo/internal/ble/Address;Z)V"), new JValue (p0), new JValue (p1));
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/thalmic/myo/internal/ble/BleGattCallback", DoNotGenerateAcw=true)]
	internal partial class BleGattCallbackInvoker : BleGattCallback {

		public BleGattCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (BleGattCallbackInvoker); }
		}

	}

}
