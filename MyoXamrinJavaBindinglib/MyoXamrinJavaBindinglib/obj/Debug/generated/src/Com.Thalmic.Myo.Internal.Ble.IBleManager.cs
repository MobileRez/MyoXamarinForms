using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Thalmic.Myo.Internal.Ble {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.thalmic.myo.internal.ble']/interface[@name='BleManager.BleScanCallback']"
	[Register ("com/thalmic/myo/internal/ble/BleManager$BleScanCallback", "", "Com.Thalmic.Myo.Internal.Ble.IBleManagerBleScanCallbackInvoker")]
	public partial interface IBleManagerBleScanCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo.internal.ble']/interface[@name='BleManager.BleScanCallback']/method[@name='onBleScan' and count(parameter)=3 and parameter[1][@type='com.thalmic.myo.internal.ble.Address'] and parameter[2][@type='int'] and parameter[3][@type='java.util.UUID']]"
		[Register ("onBleScan", "(Lcom/thalmic/myo/internal/ble/Address;ILjava/util/UUID;)V", "GetOnBleScan_Lcom_thalmic_myo_internal_ble_Address_ILjava_util_UUID_Handler:Com.Thalmic.Myo.Internal.Ble.IBleManagerBleScanCallbackInvoker, MyoXamrinJavaBindinglib")]
		void OnBleScan (global::Com.Thalmic.Myo.Internal.Ble.Address p0, int p1, global::Java.Util.UUID p2);

	}

	[global::Android.Runtime.Register ("com/thalmic/myo/internal/ble/BleManager$BleScanCallback", DoNotGenerateAcw=true)]
	internal class IBleManagerBleScanCallbackInvoker : global::Java.Lang.Object, IBleManagerBleScanCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/thalmic/myo/internal/ble/BleManager$BleScanCallback");
		IntPtr class_ref;

		public static IBleManagerBleScanCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBleManagerBleScanCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.thalmic.myo.internal.ble.BleManager.BleScanCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBleManagerBleScanCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IBleManagerBleScanCallbackInvoker); }
		}

		static Delegate cb_onBleScan_Lcom_thalmic_myo_internal_ble_Address_ILjava_util_UUID_;
#pragma warning disable 0169
		static Delegate GetOnBleScan_Lcom_thalmic_myo_internal_ble_Address_ILjava_util_UUID_Handler ()
		{
			if (cb_onBleScan_Lcom_thalmic_myo_internal_ble_Address_ILjava_util_UUID_ == null)
				cb_onBleScan_Lcom_thalmic_myo_internal_ble_Address_ILjava_util_UUID_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_OnBleScan_Lcom_thalmic_myo_internal_ble_Address_ILjava_util_UUID_);
			return cb_onBleScan_Lcom_thalmic_myo_internal_ble_Address_ILjava_util_UUID_;
		}

		static void n_OnBleScan_Lcom_thalmic_myo_internal_ble_Address_ILjava_util_UUID_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
		{
			global::Com.Thalmic.Myo.Internal.Ble.IBleManagerBleScanCallback __this = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Internal.Ble.IBleManagerBleScanCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Thalmic.Myo.Internal.Ble.Address p0 = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Internal.Ble.Address> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.UUID p2 = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnBleScan (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onBleScan_Lcom_thalmic_myo_internal_ble_Address_ILjava_util_UUID_;
		public void OnBleScan (global::Com.Thalmic.Myo.Internal.Ble.Address p0, int p1, global::Java.Util.UUID p2)
		{
			if (id_onBleScan_Lcom_thalmic_myo_internal_ble_Address_ILjava_util_UUID_ == IntPtr.Zero)
				id_onBleScan_Lcom_thalmic_myo_internal_ble_Address_ILjava_util_UUID_ = JNIEnv.GetMethodID (class_ref, "onBleScan", "(Lcom/thalmic/myo/internal/ble/Address;ILjava/util/UUID;)V");
			JNIEnv.CallVoidMethod (Handle, id_onBleScan_Lcom_thalmic_myo_internal_ble_Address_ILjava_util_UUID_, new JValue (p0), new JValue (p1), new JValue (p2));
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.thalmic.myo.internal.ble']/interface[@name='BleManager']"
	[Register ("com/thalmic/myo/internal/ble/BleManager", "", "Com.Thalmic.Myo.Internal.Ble.IBleManagerInvoker")]
	public partial interface IBleManager : IJavaObject {

		global::Com.Thalmic.Myo.Internal.Ble.IBleGatt BleGatt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo.internal.ble']/interface[@name='BleManager']/method[@name='getBleGatt' and count(parameter)=0]"
			[Register ("getBleGatt", "()Lcom/thalmic/myo/internal/ble/BleGatt;", "GetGetBleGattHandler:Com.Thalmic.Myo.Internal.Ble.IBleManagerInvoker, MyoXamrinJavaBindinglib")] get;
		}

		bool IsBluetoothSupported {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo.internal.ble']/interface[@name='BleManager']/method[@name='isBluetoothSupported' and count(parameter)=0]"
			[Register ("isBluetoothSupported", "()Z", "GetIsBluetoothSupportedHandler:Com.Thalmic.Myo.Internal.Ble.IBleManagerInvoker, MyoXamrinJavaBindinglib")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo.internal.ble']/interface[@name='BleManager']/method[@name='connect' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("connect", "(Ljava/lang/String;Z)Z", "GetConnect_Ljava_lang_String_ZHandler:Com.Thalmic.Myo.Internal.Ble.IBleManagerInvoker, MyoXamrinJavaBindinglib")]
		bool Connect (string p0, bool p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo.internal.ble']/interface[@name='BleManager']/method[@name='disconnect' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("disconnect", "(Ljava/lang/String;)V", "GetDisconnect_Ljava_lang_String_Handler:Com.Thalmic.Myo.Internal.Ble.IBleManagerInvoker, MyoXamrinJavaBindinglib")]
		void Disconnect (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo.internal.ble']/interface[@name='BleManager']/method[@name='dispose' and count(parameter)=0]"
		[Register ("dispose", "()V", "GetDisposeHandler:Com.Thalmic.Myo.Internal.Ble.IBleManagerInvoker, MyoXamrinJavaBindinglib")]
		void Dispose ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo.internal.ble']/interface[@name='BleManager']/method[@name='startBleScan' and count(parameter)=1 and parameter[1][@type='com.thalmic.myo.internal.ble.BleManager.BleScanCallback']]"
		[Register ("startBleScan", "(Lcom/thalmic/myo/internal/ble/BleManager$BleScanCallback;)Z", "GetStartBleScan_Lcom_thalmic_myo_internal_ble_BleManager_BleScanCallback_Handler:Com.Thalmic.Myo.Internal.Ble.IBleManagerInvoker, MyoXamrinJavaBindinglib")]
		bool StartBleScan (global::Com.Thalmic.Myo.Internal.Ble.IBleManagerBleScanCallback p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo.internal.ble']/interface[@name='BleManager']/method[@name='stopBleScan' and count(parameter)=1 and parameter[1][@type='com.thalmic.myo.internal.ble.BleManager.BleScanCallback']]"
		[Register ("stopBleScan", "(Lcom/thalmic/myo/internal/ble/BleManager$BleScanCallback;)V", "GetStopBleScan_Lcom_thalmic_myo_internal_ble_BleManager_BleScanCallback_Handler:Com.Thalmic.Myo.Internal.Ble.IBleManagerInvoker, MyoXamrinJavaBindinglib")]
		void StopBleScan (global::Com.Thalmic.Myo.Internal.Ble.IBleManagerBleScanCallback p0);

	}

	[global::Android.Runtime.Register ("com/thalmic/myo/internal/ble/BleManager", DoNotGenerateAcw=true)]
	internal class IBleManagerInvoker : global::Java.Lang.Object, IBleManager {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/thalmic/myo/internal/ble/BleManager");
		IntPtr class_ref;

		public static IBleManager GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBleManager> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.thalmic.myo.internal.ble.BleManager"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBleManagerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IBleManagerInvoker); }
		}

		static Delegate cb_getBleGatt;
#pragma warning disable 0169
		static Delegate GetGetBleGattHandler ()
		{
			if (cb_getBleGatt == null)
				cb_getBleGatt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBleGatt);
			return cb_getBleGatt;
		}

		static IntPtr n_GetBleGatt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Thalmic.Myo.Internal.Ble.IBleManager __this = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Internal.Ble.IBleManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BleGatt);
		}
#pragma warning restore 0169

		IntPtr id_getBleGatt;
		public global::Com.Thalmic.Myo.Internal.Ble.IBleGatt BleGatt {
			get {
				if (id_getBleGatt == IntPtr.Zero)
					id_getBleGatt = JNIEnv.GetMethodID (class_ref, "getBleGatt", "()Lcom/thalmic/myo/internal/ble/BleGatt;");
				return global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Internal.Ble.IBleGatt> (JNIEnv.CallObjectMethod (Handle, id_getBleGatt), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_isBluetoothSupported;
#pragma warning disable 0169
		static Delegate GetIsBluetoothSupportedHandler ()
		{
			if (cb_isBluetoothSupported == null)
				cb_isBluetoothSupported = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsBluetoothSupported);
			return cb_isBluetoothSupported;
		}

		static bool n_IsBluetoothSupported (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Thalmic.Myo.Internal.Ble.IBleManager __this = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Internal.Ble.IBleManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsBluetoothSupported;
		}
#pragma warning restore 0169

		IntPtr id_isBluetoothSupported;
		public bool IsBluetoothSupported {
			get {
				if (id_isBluetoothSupported == IntPtr.Zero)
					id_isBluetoothSupported = JNIEnv.GetMethodID (class_ref, "isBluetoothSupported", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isBluetoothSupported);
			}
		}

		static Delegate cb_connect_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetConnect_Ljava_lang_String_ZHandler ()
		{
			if (cb_connect_Ljava_lang_String_Z == null)
				cb_connect_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool, bool>) n_Connect_Ljava_lang_String_Z);
			return cb_connect_Ljava_lang_String_Z;
		}

		static bool n_Connect_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Thalmic.Myo.Internal.Ble.IBleManager __this = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Internal.Ble.IBleManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Connect (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_connect_Ljava_lang_String_Z;
		public bool Connect (string p0, bool p1)
		{
			if (id_connect_Ljava_lang_String_Z == IntPtr.Zero)
				id_connect_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "connect", "(Ljava/lang/String;Z)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			bool __ret = JNIEnv.CallBooleanMethod (Handle, id_connect_Ljava_lang_String_Z, new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_disconnect_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDisconnect_Ljava_lang_String_Handler ()
		{
			if (cb_disconnect_Ljava_lang_String_ == null)
				cb_disconnect_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Disconnect_Ljava_lang_String_);
			return cb_disconnect_Ljava_lang_String_;
		}

		static void n_Disconnect_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Thalmic.Myo.Internal.Ble.IBleManager __this = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Internal.Ble.IBleManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Disconnect (p0);
		}
#pragma warning restore 0169

		IntPtr id_disconnect_Ljava_lang_String_;
		public void Disconnect (string p0)
		{
			if (id_disconnect_Ljava_lang_String_ == IntPtr.Zero)
				id_disconnect_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "disconnect", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallVoidMethod (Handle, id_disconnect_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
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
			global::Com.Thalmic.Myo.Internal.Ble.IBleManager __this = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Internal.Ble.IBleManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dispose ();
		}
#pragma warning restore 0169

		IntPtr id_dispose;
		public void Dispose ()
		{
			if (id_dispose == IntPtr.Zero)
				id_dispose = JNIEnv.GetMethodID (class_ref, "dispose", "()V");
			JNIEnv.CallVoidMethod (Handle, id_dispose);
		}

		static Delegate cb_startBleScan_Lcom_thalmic_myo_internal_ble_BleManager_BleScanCallback_;
#pragma warning disable 0169
		static Delegate GetStartBleScan_Lcom_thalmic_myo_internal_ble_BleManager_BleScanCallback_Handler ()
		{
			if (cb_startBleScan_Lcom_thalmic_myo_internal_ble_BleManager_BleScanCallback_ == null)
				cb_startBleScan_Lcom_thalmic_myo_internal_ble_BleManager_BleScanCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_StartBleScan_Lcom_thalmic_myo_internal_ble_BleManager_BleScanCallback_);
			return cb_startBleScan_Lcom_thalmic_myo_internal_ble_BleManager_BleScanCallback_;
		}

		static bool n_StartBleScan_Lcom_thalmic_myo_internal_ble_BleManager_BleScanCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Thalmic.Myo.Internal.Ble.IBleManager __this = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Internal.Ble.IBleManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Thalmic.Myo.Internal.Ble.IBleManagerBleScanCallback p0 = (global::Com.Thalmic.Myo.Internal.Ble.IBleManagerBleScanCallback)global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Internal.Ble.IBleManagerBleScanCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.StartBleScan (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_startBleScan_Lcom_thalmic_myo_internal_ble_BleManager_BleScanCallback_;
		public bool StartBleScan (global::Com.Thalmic.Myo.Internal.Ble.IBleManagerBleScanCallback p0)
		{
			if (id_startBleScan_Lcom_thalmic_myo_internal_ble_BleManager_BleScanCallback_ == IntPtr.Zero)
				id_startBleScan_Lcom_thalmic_myo_internal_ble_BleManager_BleScanCallback_ = JNIEnv.GetMethodID (class_ref, "startBleScan", "(Lcom/thalmic/myo/internal/ble/BleManager$BleScanCallback;)Z");
			bool __ret = JNIEnv.CallBooleanMethod (Handle, id_startBleScan_Lcom_thalmic_myo_internal_ble_BleManager_BleScanCallback_, new JValue (p0));
			return __ret;
		}

		static Delegate cb_stopBleScan_Lcom_thalmic_myo_internal_ble_BleManager_BleScanCallback_;
#pragma warning disable 0169
		static Delegate GetStopBleScan_Lcom_thalmic_myo_internal_ble_BleManager_BleScanCallback_Handler ()
		{
			if (cb_stopBleScan_Lcom_thalmic_myo_internal_ble_BleManager_BleScanCallback_ == null)
				cb_stopBleScan_Lcom_thalmic_myo_internal_ble_BleManager_BleScanCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_StopBleScan_Lcom_thalmic_myo_internal_ble_BleManager_BleScanCallback_);
			return cb_stopBleScan_Lcom_thalmic_myo_internal_ble_BleManager_BleScanCallback_;
		}

		static void n_StopBleScan_Lcom_thalmic_myo_internal_ble_BleManager_BleScanCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Thalmic.Myo.Internal.Ble.IBleManager __this = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Internal.Ble.IBleManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Thalmic.Myo.Internal.Ble.IBleManagerBleScanCallback p0 = (global::Com.Thalmic.Myo.Internal.Ble.IBleManagerBleScanCallback)global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Internal.Ble.IBleManagerBleScanCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.StopBleScan (p0);
		}
#pragma warning restore 0169

		IntPtr id_stopBleScan_Lcom_thalmic_myo_internal_ble_BleManager_BleScanCallback_;
		public void StopBleScan (global::Com.Thalmic.Myo.Internal.Ble.IBleManagerBleScanCallback p0)
		{
			if (id_stopBleScan_Lcom_thalmic_myo_internal_ble_BleManager_BleScanCallback_ == IntPtr.Zero)
				id_stopBleScan_Lcom_thalmic_myo_internal_ble_BleManager_BleScanCallback_ = JNIEnv.GetMethodID (class_ref, "stopBleScan", "(Lcom/thalmic/myo/internal/ble/BleManager$BleScanCallback;)V");
			JNIEnv.CallVoidMethod (Handle, id_stopBleScan_Lcom_thalmic_myo_internal_ble_BleManager_BleScanCallback_, new JValue (p0));
		}

	}

}
