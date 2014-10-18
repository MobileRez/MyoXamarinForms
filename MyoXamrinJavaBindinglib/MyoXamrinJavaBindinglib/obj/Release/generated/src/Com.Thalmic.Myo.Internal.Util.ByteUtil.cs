using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Thalmic.Myo.Internal.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.thalmic.myo.internal.util']/class[@name='ByteUtil']"
	[global::Android.Runtime.Register ("com/thalmic/myo/internal/util/ByteUtil", DoNotGenerateAcw=true)]
	public partial class ByteUtil : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/thalmic/myo/internal/util/ByteUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ByteUtil); }
		}

		protected ByteUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.thalmic.myo.internal.util']/class[@name='ByteUtil']/constructor[@name='ByteUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public ByteUtil () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ByteUtil)) {
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

		static IntPtr id_bytesToHex_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo.internal.util']/class[@name='ByteUtil']/method[@name='bytesToHex' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("bytesToHex", "([B)Ljava/lang/String;", "")]
		public static string BytesToHex (byte[] p0)
		{
			if (id_bytesToHex_arrayB == IntPtr.Zero)
				id_bytesToHex_arrayB = JNIEnv.GetStaticMethodID (class_ref, "bytesToHex", "([B)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_bytesToHex_arrayB, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_getString_arrayBI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo.internal.util']/class[@name='ByteUtil']/method[@name='getString' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("getString", "([BI)Ljava/lang/String;", "")]
		public static string GetString (byte[] p0, int p1)
		{
			if (id_getString_arrayBI == IntPtr.Zero)
				id_getString_arrayBI = JNIEnv.GetStaticMethodID (class_ref, "getString", "([BI)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getString_arrayBI, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_getUuidFromBytes_arrayBI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo.internal.util']/class[@name='ByteUtil']/method[@name='getUuidFromBytes' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("getUuidFromBytes", "([BI)Ljava/util/UUID;", "")]
		public static global::Java.Util.UUID GetUuidFromBytes (byte[] p0, int p1)
		{
			if (id_getUuidFromBytes_arrayBI == IntPtr.Zero)
				id_getUuidFromBytes_arrayBI = JNIEnv.GetStaticMethodID (class_ref, "getUuidFromBytes", "([BI)Ljava/util/UUID;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				global::Java.Util.UUID __ret = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getUuidFromBytes_arrayBI, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}
}
