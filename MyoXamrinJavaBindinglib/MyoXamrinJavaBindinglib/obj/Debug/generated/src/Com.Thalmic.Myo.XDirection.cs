using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Thalmic.Myo {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.thalmic.myo']/class[@name='XDirection']"
	[global::Android.Runtime.Register ("com/thalmic/myo/XDirection", DoNotGenerateAcw=true)]
	public sealed partial class XDirection : global::Java.Lang.Enum {


		static IntPtr TOWARD_ELBOW_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.thalmic.myo']/class[@name='XDirection']/field[@name='TOWARD_ELBOW']"
		[Register ("TOWARD_ELBOW")]
		public static global::Com.Thalmic.Myo.XDirection TowardElbow {
			get {
				if (TOWARD_ELBOW_jfieldId == IntPtr.Zero)
					TOWARD_ELBOW_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TOWARD_ELBOW", "Lcom/thalmic/myo/XDirection;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TOWARD_ELBOW_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.XDirection> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TOWARD_WRIST_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.thalmic.myo']/class[@name='XDirection']/field[@name='TOWARD_WRIST']"
		[Register ("TOWARD_WRIST")]
		public static global::Com.Thalmic.Myo.XDirection TowardWrist {
			get {
				if (TOWARD_WRIST_jfieldId == IntPtr.Zero)
					TOWARD_WRIST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TOWARD_WRIST", "Lcom/thalmic/myo/XDirection;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TOWARD_WRIST_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.XDirection> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr UNKNOWN_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.thalmic.myo']/class[@name='XDirection']/field[@name='UNKNOWN']"
		[Register ("UNKNOWN")]
		public static global::Com.Thalmic.Myo.XDirection Unknown {
			get {
				if (UNKNOWN_jfieldId == IntPtr.Zero)
					UNKNOWN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNKNOWN", "Lcom/thalmic/myo/XDirection;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNKNOWN_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.XDirection> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/thalmic/myo/XDirection", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (XDirection); }
		}

		internal XDirection (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo']/class[@name='XDirection']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/thalmic/myo/XDirection;", "")]
		public static global::Com.Thalmic.Myo.XDirection ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/thalmic/myo/XDirection;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				global::Com.Thalmic.Myo.XDirection __ret = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.XDirection> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo']/class[@name='XDirection']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/thalmic/myo/XDirection;", "")]
		public static global::Com.Thalmic.Myo.XDirection[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/thalmic/myo/XDirection;");
			try {
				return (global::Com.Thalmic.Myo.XDirection[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Thalmic.Myo.XDirection));
			} finally {
			}
		}

	}
}
