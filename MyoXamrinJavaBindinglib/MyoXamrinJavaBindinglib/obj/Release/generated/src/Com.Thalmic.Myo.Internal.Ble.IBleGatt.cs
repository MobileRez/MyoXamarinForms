using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Thalmic.Myo.Internal.Ble {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.thalmic.myo.internal.ble']/interface[@name='BleGatt']"
	[Register ("com/thalmic/myo/internal/ble/BleGatt", "", "Com.Thalmic.Myo.Internal.Ble.IBleGattInvoker")]
	public partial interface IBleGatt : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo.internal.ble']/interface[@name='BleGatt']/method[@name='discoverServices' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("discoverServices", "(Ljava/lang/String;)V", "GetDiscoverServices_Ljava_lang_String_Handler:Com.Thalmic.Myo.Internal.Ble.IBleGattInvoker, MyoXamrinJavaBindinglib")]
		void DiscoverServices (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo.internal.ble']/interface[@name='BleGatt']/method[@name='readCharacteristic' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.UUID'] and parameter[3][@type='java.util.UUID']]"
		[Register ("readCharacteristic", "(Ljava/lang/String;Ljava/util/UUID;Ljava/util/UUID;)V", "GetReadCharacteristic_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_Handler:Com.Thalmic.Myo.Internal.Ble.IBleGattInvoker, MyoXamrinJavaBindinglib")]
		void ReadCharacteristic (string p0, global::Java.Util.UUID p1, global::Java.Util.UUID p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo.internal.ble']/interface[@name='BleGatt']/method[@name='readRemoteRssi' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("readRemoteRssi", "(Ljava/lang/String;)V", "GetReadRemoteRssi_Ljava_lang_String_Handler:Com.Thalmic.Myo.Internal.Ble.IBleGattInvoker, MyoXamrinJavaBindinglib")]
		void ReadRemoteRssi (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo.internal.ble']/interface[@name='BleGatt']/method[@name='setBleGattCallback' and count(parameter)=1 and parameter[1][@type='com.thalmic.myo.internal.ble.BleGattCallback']]"
		[Register ("setBleGattCallback", "(Lcom/thalmic/myo/internal/ble/BleGattCallback;)V", "GetSetBleGattCallback_Lcom_thalmic_myo_internal_ble_BleGattCallback_Handler:Com.Thalmic.Myo.Internal.Ble.IBleGattInvoker, MyoXamrinJavaBindinglib")]
		void SetBleGattCallback (global::Com.Thalmic.Myo.Internal.Ble.BleGattCallback p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo.internal.ble']/interface[@name='BleGatt']/method[@name='setCharacteristicNotification' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.UUID'] and parameter[3][@type='java.util.UUID'] and parameter[4][@type='boolean'] and parameter[5][@type='boolean']]"
		[Register ("setCharacteristicNotification", "(Ljava/lang/String;Ljava/util/UUID;Ljava/util/UUID;ZZ)V", "GetSetCharacteristicNotification_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_ZZHandler:Com.Thalmic.Myo.Internal.Ble.IBleGattInvoker, MyoXamrinJavaBindinglib")]
		void SetCharacteristicNotification (string p0, global::Java.Util.UUID p1, global::Java.Util.UUID p2, bool p3, bool p4);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo.internal.ble']/interface[@name='BleGatt']/method[@name='writeCharacteristic' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.UUID'] and parameter[3][@type='java.util.UUID'] and parameter[4][@type='byte[]']]"
		[Register ("writeCharacteristic", "(Ljava/lang/String;Ljava/util/UUID;Ljava/util/UUID;[B)V", "GetWriteCharacteristic_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_arrayBHandler:Com.Thalmic.Myo.Internal.Ble.IBleGattInvoker, MyoXamrinJavaBindinglib")]
		void WriteCharacteristic (string p0, global::Java.Util.UUID p1, global::Java.Util.UUID p2, byte[] p3);

	}

	[global::Android.Runtime.Register ("com/thalmic/myo/internal/ble/BleGatt", DoNotGenerateAcw=true)]
	internal class IBleGattInvoker : global::Java.Lang.Object, IBleGatt {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/thalmic/myo/internal/ble/BleGatt");
		IntPtr class_ref;

		public static IBleGatt GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBleGatt> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.thalmic.myo.internal.ble.BleGatt"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBleGattInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IBleGattInvoker); }
		}

		static Delegate cb_discoverServices_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDiscoverServices_Ljava_lang_String_Handler ()
		{
			if (cb_discoverServices_Ljava_lang_String_ == null)
				cb_discoverServices_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DiscoverServices_Ljava_lang_String_);
			return cb_discoverServices_Ljava_lang_String_;
		}

		static void n_DiscoverServices_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Thalmic.Myo.Internal.Ble.IBleGatt __this = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Internal.Ble.IBleGatt> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DiscoverServices (p0);
		}
#pragma warning restore 0169

		IntPtr id_discoverServices_Ljava_lang_String_;
		public void DiscoverServices (string p0)
		{
			if (id_discoverServices_Ljava_lang_String_ == IntPtr.Zero)
				id_discoverServices_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "discoverServices", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallVoidMethod (Handle, id_discoverServices_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_readCharacteristic_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_;
#pragma warning disable 0169
		static Delegate GetReadCharacteristic_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_Handler ()
		{
			if (cb_readCharacteristic_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_ == null)
				cb_readCharacteristic_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_ReadCharacteristic_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_);
			return cb_readCharacteristic_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_;
		}

		static void n_ReadCharacteristic_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Thalmic.Myo.Internal.Ble.IBleGatt __this = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Internal.Ble.IBleGatt> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.UUID p1 = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.UUID p2 = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.ReadCharacteristic (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_readCharacteristic_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_;
		public void ReadCharacteristic (string p0, global::Java.Util.UUID p1, global::Java.Util.UUID p2)
		{
			if (id_readCharacteristic_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_ == IntPtr.Zero)
				id_readCharacteristic_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_ = JNIEnv.GetMethodID (class_ref, "readCharacteristic", "(Ljava/lang/String;Ljava/util/UUID;Ljava/util/UUID;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallVoidMethod (Handle, id_readCharacteristic_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_, new JValue (native_p0), new JValue (p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_readRemoteRssi_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetReadRemoteRssi_Ljava_lang_String_Handler ()
		{
			if (cb_readRemoteRssi_Ljava_lang_String_ == null)
				cb_readRemoteRssi_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ReadRemoteRssi_Ljava_lang_String_);
			return cb_readRemoteRssi_Ljava_lang_String_;
		}

		static void n_ReadRemoteRssi_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Thalmic.Myo.Internal.Ble.IBleGatt __this = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Internal.Ble.IBleGatt> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ReadRemoteRssi (p0);
		}
#pragma warning restore 0169

		IntPtr id_readRemoteRssi_Ljava_lang_String_;
		public void ReadRemoteRssi (string p0)
		{
			if (id_readRemoteRssi_Ljava_lang_String_ == IntPtr.Zero)
				id_readRemoteRssi_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "readRemoteRssi", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallVoidMethod (Handle, id_readRemoteRssi_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_setBleGattCallback_Lcom_thalmic_myo_internal_ble_BleGattCallback_;
#pragma warning disable 0169
		static Delegate GetSetBleGattCallback_Lcom_thalmic_myo_internal_ble_BleGattCallback_Handler ()
		{
			if (cb_setBleGattCallback_Lcom_thalmic_myo_internal_ble_BleGattCallback_ == null)
				cb_setBleGattCallback_Lcom_thalmic_myo_internal_ble_BleGattCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBleGattCallback_Lcom_thalmic_myo_internal_ble_BleGattCallback_);
			return cb_setBleGattCallback_Lcom_thalmic_myo_internal_ble_BleGattCallback_;
		}

		static void n_SetBleGattCallback_Lcom_thalmic_myo_internal_ble_BleGattCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Thalmic.Myo.Internal.Ble.IBleGatt __this = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Internal.Ble.IBleGatt> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Thalmic.Myo.Internal.Ble.BleGattCallback p0 = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Internal.Ble.BleGattCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetBleGattCallback (p0);
		}
#pragma warning restore 0169

		IntPtr id_setBleGattCallback_Lcom_thalmic_myo_internal_ble_BleGattCallback_;
		public void SetBleGattCallback (global::Com.Thalmic.Myo.Internal.Ble.BleGattCallback p0)
		{
			if (id_setBleGattCallback_Lcom_thalmic_myo_internal_ble_BleGattCallback_ == IntPtr.Zero)
				id_setBleGattCallback_Lcom_thalmic_myo_internal_ble_BleGattCallback_ = JNIEnv.GetMethodID (class_ref, "setBleGattCallback", "(Lcom/thalmic/myo/internal/ble/BleGattCallback;)V");
			JNIEnv.CallVoidMethod (Handle, id_setBleGattCallback_Lcom_thalmic_myo_internal_ble_BleGattCallback_, new JValue (p0));
		}

		static Delegate cb_setCharacteristicNotification_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_ZZ;
#pragma warning disable 0169
		static Delegate GetSetCharacteristicNotification_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_ZZHandler ()
		{
			if (cb_setCharacteristicNotification_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_ZZ == null)
				cb_setCharacteristicNotification_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_ZZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool, bool>) n_SetCharacteristicNotification_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_ZZ);
			return cb_setCharacteristicNotification_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_ZZ;
		}

		static void n_SetCharacteristicNotification_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_ZZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, bool p3, bool p4)
		{
			global::Com.Thalmic.Myo.Internal.Ble.IBleGatt __this = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Internal.Ble.IBleGatt> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.UUID p1 = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.UUID p2 = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SetCharacteristicNotification (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		IntPtr id_setCharacteristicNotification_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_ZZ;
		public void SetCharacteristicNotification (string p0, global::Java.Util.UUID p1, global::Java.Util.UUID p2, bool p3, bool p4)
		{
			if (id_setCharacteristicNotification_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_ZZ == IntPtr.Zero)
				id_setCharacteristicNotification_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_ZZ = JNIEnv.GetMethodID (class_ref, "setCharacteristicNotification", "(Ljava/lang/String;Ljava/util/UUID;Ljava/util/UUID;ZZ)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallVoidMethod (Handle, id_setCharacteristicNotification_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_ZZ, new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_writeCharacteristic_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_arrayB;
#pragma warning disable 0169
		static Delegate GetWriteCharacteristic_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_arrayBHandler ()
		{
			if (cb_writeCharacteristic_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_arrayB == null)
				cb_writeCharacteristic_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_WriteCharacteristic_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_arrayB);
			return cb_writeCharacteristic_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_arrayB;
		}

		static void n_WriteCharacteristic_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Thalmic.Myo.Internal.Ble.IBleGatt __this = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Internal.Ble.IBleGatt> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.UUID p1 = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.UUID p2 = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_p2, JniHandleOwnership.DoNotTransfer);
			byte[] p3 = (byte[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.WriteCharacteristic (p0, p1, p2, p3);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
		}
#pragma warning restore 0169

		IntPtr id_writeCharacteristic_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_arrayB;
		public void WriteCharacteristic (string p0, global::Java.Util.UUID p1, global::Java.Util.UUID p2, byte[] p3)
		{
			if (id_writeCharacteristic_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_arrayB == IntPtr.Zero)
				id_writeCharacteristic_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_arrayB = JNIEnv.GetMethodID (class_ref, "writeCharacteristic", "(Ljava/lang/String;Ljava/util/UUID;Ljava/util/UUID;[B)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			JNIEnv.CallVoidMethod (Handle, id_writeCharacteristic_Ljava_lang_String_Ljava_util_UUID_Ljava_util_UUID_arrayB, new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (native_p3));
			JNIEnv.DeleteLocalRef (native_p0);
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

	}

}
