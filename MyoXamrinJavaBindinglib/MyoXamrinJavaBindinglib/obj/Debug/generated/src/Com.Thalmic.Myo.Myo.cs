using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Thalmic.Myo {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.thalmic.myo']/class[@name='Myo']"
	[global::Android.Runtime.Register ("com/thalmic/myo/Myo", DoNotGenerateAcw=true)]
	public partial class Myo : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.thalmic.myo']/class[@name='Myo.ConnectionState']"
		[global::Android.Runtime.Register ("com/thalmic/myo/Myo$ConnectionState", DoNotGenerateAcw=true)]
		public sealed partial class ConnectionState : global::Java.Lang.Enum {


			static IntPtr CONNECTED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.thalmic.myo']/class[@name='Myo.ConnectionState']/field[@name='CONNECTED']"
			[Register ("CONNECTED")]
			public static global::Com.Thalmic.Myo.Myo.ConnectionState Connected {
				get {
					if (CONNECTED_jfieldId == IntPtr.Zero)
						CONNECTED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONNECTED", "Lcom/thalmic/myo/Myo$ConnectionState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CONNECTED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Myo.ConnectionState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CONNECTING_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.thalmic.myo']/class[@name='Myo.ConnectionState']/field[@name='CONNECTING']"
			[Register ("CONNECTING")]
			public static global::Com.Thalmic.Myo.Myo.ConnectionState Connecting {
				get {
					if (CONNECTING_jfieldId == IntPtr.Zero)
						CONNECTING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONNECTING", "Lcom/thalmic/myo/Myo$ConnectionState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CONNECTING_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Myo.ConnectionState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr DISCONNECTED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.thalmic.myo']/class[@name='Myo.ConnectionState']/field[@name='DISCONNECTED']"
			[Register ("DISCONNECTED")]
			public static global::Com.Thalmic.Myo.Myo.ConnectionState Disconnected {
				get {
					if (DISCONNECTED_jfieldId == IntPtr.Zero)
						DISCONNECTED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DISCONNECTED", "Lcom/thalmic/myo/Myo$ConnectionState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DISCONNECTED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Myo.ConnectionState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/thalmic/myo/Myo$ConnectionState", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ConnectionState); }
			}

			internal ConnectionState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo']/class[@name='Myo.ConnectionState']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/thalmic/myo/Myo$ConnectionState;", "")]
			public static global::Com.Thalmic.Myo.Myo.ConnectionState ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/thalmic/myo/Myo$ConnectionState;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					global::Com.Thalmic.Myo.Myo.ConnectionState __ret = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Myo.ConnectionState> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo']/class[@name='Myo.ConnectionState']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/thalmic/myo/Myo$ConnectionState;", "")]
			public static global::Com.Thalmic.Myo.Myo.ConnectionState[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/thalmic/myo/Myo$ConnectionState;");
				try {
					return (global::Com.Thalmic.Myo.Myo.ConnectionState[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Thalmic.Myo.Myo.ConnectionState));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.thalmic.myo']/class[@name='Myo.VibrationType']"
		[global::Android.Runtime.Register ("com/thalmic/myo/Myo$VibrationType", DoNotGenerateAcw=true)]
		public sealed partial class VibrationType : global::Java.Lang.Enum {


			static IntPtr LONG_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.thalmic.myo']/class[@name='Myo.VibrationType']/field[@name='LONG']"
			[Register ("LONG")]
			public static global::Com.Thalmic.Myo.Myo.VibrationType Long {
				get {
					if (LONG_jfieldId == IntPtr.Zero)
						LONG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LONG", "Lcom/thalmic/myo/Myo$VibrationType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LONG_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Myo.VibrationType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr MEDIUM_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.thalmic.myo']/class[@name='Myo.VibrationType']/field[@name='MEDIUM']"
			[Register ("MEDIUM")]
			public static global::Com.Thalmic.Myo.Myo.VibrationType Medium {
				get {
					if (MEDIUM_jfieldId == IntPtr.Zero)
						MEDIUM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MEDIUM", "Lcom/thalmic/myo/Myo$VibrationType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MEDIUM_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Myo.VibrationType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SHORT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.thalmic.myo']/class[@name='Myo.VibrationType']/field[@name='SHORT']"
			[Register ("SHORT")]
			public static global::Com.Thalmic.Myo.Myo.VibrationType Short {
				get {
					if (SHORT_jfieldId == IntPtr.Zero)
						SHORT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SHORT", "Lcom/thalmic/myo/Myo$VibrationType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SHORT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Myo.VibrationType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/thalmic/myo/Myo$VibrationType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (VibrationType); }
			}

			internal VibrationType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo']/class[@name='Myo.VibrationType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/thalmic/myo/Myo$VibrationType;", "")]
			public static global::Com.Thalmic.Myo.Myo.VibrationType ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/thalmic/myo/Myo$VibrationType;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					global::Com.Thalmic.Myo.Myo.VibrationType __ret = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Myo.VibrationType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo']/class[@name='Myo.VibrationType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/thalmic/myo/Myo$VibrationType;", "")]
			public static global::Com.Thalmic.Myo.Myo.VibrationType[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/thalmic/myo/Myo$VibrationType;");
				try {
					return (global::Com.Thalmic.Myo.Myo.VibrationType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Thalmic.Myo.Myo.VibrationType));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/thalmic/myo/Myo", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Myo); }
		}

		protected Myo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_isConnected;
#pragma warning disable 0169
		static Delegate GetIsConnectedHandler ()
		{
			if (cb_isConnected == null)
				cb_isConnected = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsConnected);
			return cb_isConnected;
		}

		static bool n_IsConnected (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Thalmic.Myo.Myo __this = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Myo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsConnected;
		}
#pragma warning restore 0169

		static IntPtr id_isConnected;
		public virtual bool IsConnected {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo']/class[@name='Myo']/method[@name='isConnected' and count(parameter)=0]"
			[Register ("isConnected", "()Z", "GetIsConnectedHandler")]
			get {
				if (id_isConnected == IntPtr.Zero)
					id_isConnected = JNIEnv.GetMethodID (class_ref, "isConnected", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isConnected);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isConnected", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isFirmwareVersionSupported;
#pragma warning disable 0169
		static Delegate GetIsFirmwareVersionSupportedHandler ()
		{
			if (cb_isFirmwareVersionSupported == null)
				cb_isFirmwareVersionSupported = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsFirmwareVersionSupported);
			return cb_isFirmwareVersionSupported;
		}

		static bool n_IsFirmwareVersionSupported (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Thalmic.Myo.Myo __this = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Myo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsFirmwareVersionSupported;
		}
#pragma warning restore 0169

		static IntPtr id_isFirmwareVersionSupported;
		public virtual bool IsFirmwareVersionSupported {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo']/class[@name='Myo']/method[@name='isFirmwareVersionSupported' and count(parameter)=0]"
			[Register ("isFirmwareVersionSupported", "()Z", "GetIsFirmwareVersionSupportedHandler")]
			get {
				if (id_isFirmwareVersionSupported == IntPtr.Zero)
					id_isFirmwareVersionSupported = JNIEnv.GetMethodID (class_ref, "isFirmwareVersionSupported", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isFirmwareVersionSupported);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isFirmwareVersionSupported", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getMacAddress;
#pragma warning disable 0169
		static Delegate GetGetMacAddressHandler ()
		{
			if (cb_getMacAddress == null)
				cb_getMacAddress = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMacAddress);
			return cb_getMacAddress;
		}

		static IntPtr n_GetMacAddress (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Thalmic.Myo.Myo __this = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Myo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MacAddress);
		}
#pragma warning restore 0169

		static IntPtr id_getMacAddress;
		public virtual string MacAddress {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo']/class[@name='Myo']/method[@name='getMacAddress' and count(parameter)=0]"
			[Register ("getMacAddress", "()Ljava/lang/String;", "GetGetMacAddressHandler")]
			get {
				if (id_getMacAddress == IntPtr.Zero)
					id_getMacAddress = JNIEnv.GetMethodID (class_ref, "getMacAddress", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getMacAddress), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMacAddress", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Thalmic.Myo.Myo __this = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Myo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		static IntPtr id_getName;
		public virtual string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo']/class[@name='Myo']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getConnectionState;
#pragma warning disable 0169
		static Delegate GetGetConnectionStateHandler ()
		{
			if (cb_getConnectionState == null)
				cb_getConnectionState = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetConnectionState);
			return cb_getConnectionState;
		}

		static IntPtr n_GetConnectionState (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Thalmic.Myo.Myo __this = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Myo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetConnectionState ());
		}
#pragma warning restore 0169

		static IntPtr id_getConnectionState;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo']/class[@name='Myo']/method[@name='getConnectionState' and count(parameter)=0]"
		[Register ("getConnectionState", "()Lcom/thalmic/myo/Myo$ConnectionState;", "GetGetConnectionStateHandler")]
		public virtual global::Com.Thalmic.Myo.Myo.ConnectionState GetConnectionState ()
		{
			if (id_getConnectionState == IntPtr.Zero)
				id_getConnectionState = JNIEnv.GetMethodID (class_ref, "getConnectionState", "()Lcom/thalmic/myo/Myo$ConnectionState;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Myo.ConnectionState> (JNIEnv.CallObjectMethod  (Handle, id_getConnectionState), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Myo.ConnectionState> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConnectionState", "()Lcom/thalmic/myo/Myo$ConnectionState;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_requestRssi;
#pragma warning disable 0169
		static Delegate GetRequestRssiHandler ()
		{
			if (cb_requestRssi == null)
				cb_requestRssi = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RequestRssi);
			return cb_requestRssi;
		}

		static void n_RequestRssi (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Thalmic.Myo.Myo __this = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Myo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RequestRssi ();
		}
#pragma warning restore 0169

		static IntPtr id_requestRssi;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo']/class[@name='Myo']/method[@name='requestRssi' and count(parameter)=0]"
		[Register ("requestRssi", "()V", "GetRequestRssiHandler")]
		public virtual void RequestRssi ()
		{
			if (id_requestRssi == IntPtr.Zero)
				id_requestRssi = JNIEnv.GetMethodID (class_ref, "requestRssi", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_requestRssi);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "requestRssi", "()V"));
			} finally {
			}
		}

		static Delegate cb_vibrate_Lcom_thalmic_myo_Myo_VibrationType_;
#pragma warning disable 0169
		static Delegate GetVibrate_Lcom_thalmic_myo_Myo_VibrationType_Handler ()
		{
			if (cb_vibrate_Lcom_thalmic_myo_Myo_VibrationType_ == null)
				cb_vibrate_Lcom_thalmic_myo_Myo_VibrationType_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Vibrate_Lcom_thalmic_myo_Myo_VibrationType_);
			return cb_vibrate_Lcom_thalmic_myo_Myo_VibrationType_;
		}

		static void n_Vibrate_Lcom_thalmic_myo_Myo_VibrationType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Thalmic.Myo.Myo __this = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Myo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Thalmic.Myo.Myo.VibrationType p0 = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Myo.VibrationType> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Vibrate (p0);
		}
#pragma warning restore 0169

		static IntPtr id_vibrate_Lcom_thalmic_myo_Myo_VibrationType_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo']/class[@name='Myo']/method[@name='vibrate' and count(parameter)=1 and parameter[1][@type='com.thalmic.myo.Myo.VibrationType']]"
		[Register ("vibrate", "(Lcom/thalmic/myo/Myo$VibrationType;)V", "GetVibrate_Lcom_thalmic_myo_Myo_VibrationType_Handler")]
		public virtual void Vibrate (global::Com.Thalmic.Myo.Myo.VibrationType p0)
		{
			if (id_vibrate_Lcom_thalmic_myo_Myo_VibrationType_ == IntPtr.Zero)
				id_vibrate_Lcom_thalmic_myo_Myo_VibrationType_ = JNIEnv.GetMethodID (class_ref, "vibrate", "(Lcom/thalmic/myo/Myo$VibrationType;)V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_vibrate_Lcom_thalmic_myo_Myo_VibrationType_, new JValue (p0));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "vibrate", "(Lcom/thalmic/myo/Myo$VibrationType;)V"), new JValue (p0));
			} finally {
			}
		}

	}
}
