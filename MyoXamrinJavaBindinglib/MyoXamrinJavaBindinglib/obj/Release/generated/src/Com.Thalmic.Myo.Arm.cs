using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Thalmic.Myo {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.thalmic.myo']/class[@name='Arm']"
	[global::Android.Runtime.Register ("com/thalmic/myo/Arm", DoNotGenerateAcw=true)]
	public sealed partial class Arm : global::Java.Lang.Enum {


		static IntPtr LEFT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.thalmic.myo']/class[@name='Arm']/field[@name='LEFT']"
		[Register ("LEFT")]
		public static global::Com.Thalmic.Myo.Arm Left {
			get {
				if (LEFT_jfieldId == IntPtr.Zero)
					LEFT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LEFT", "Lcom/thalmic/myo/Arm;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LEFT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Arm> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr RIGHT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.thalmic.myo']/class[@name='Arm']/field[@name='RIGHT']"
		[Register ("RIGHT")]
		public static global::Com.Thalmic.Myo.Arm Right {
			get {
				if (RIGHT_jfieldId == IntPtr.Zero)
					RIGHT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RIGHT", "Lcom/thalmic/myo/Arm;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RIGHT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Arm> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr UNKNOWN_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.thalmic.myo']/class[@name='Arm']/field[@name='UNKNOWN']"
		[Register ("UNKNOWN")]
		public static global::Com.Thalmic.Myo.Arm Unknown {
			get {
				if (UNKNOWN_jfieldId == IntPtr.Zero)
					UNKNOWN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNKNOWN", "Lcom/thalmic/myo/Arm;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNKNOWN_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Arm> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/thalmic/myo/Arm", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Arm); }
		}

		internal Arm (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo']/class[@name='Arm']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/thalmic/myo/Arm;", "")]
		public static global::Com.Thalmic.Myo.Arm ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/thalmic/myo/Arm;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				global::Com.Thalmic.Myo.Arm __ret = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Arm> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo']/class[@name='Arm']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/thalmic/myo/Arm;", "")]
		public static global::Com.Thalmic.Myo.Arm[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/thalmic/myo/Arm;");
			try {
				return (global::Com.Thalmic.Myo.Arm[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Thalmic.Myo.Arm));
			} finally {
			}
		}

	}
}
