using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Thalmic.Myo {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.thalmic.myo']/class[@name='Pose']"
	[global::Android.Runtime.Register ("com/thalmic/myo/Pose", DoNotGenerateAcw=true)]
	public sealed partial class Pose : global::Java.Lang.Enum {


		static IntPtr FINGERS_SPREAD_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.thalmic.myo']/class[@name='Pose']/field[@name='FINGERS_SPREAD']"
		[Register ("FINGERS_SPREAD")]
		public static global::Com.Thalmic.Myo.Pose FingersSpread {
			get {
				if (FINGERS_SPREAD_jfieldId == IntPtr.Zero)
					FINGERS_SPREAD_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FINGERS_SPREAD", "Lcom/thalmic/myo/Pose;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FINGERS_SPREAD_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Pose> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr FIST_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.thalmic.myo']/class[@name='Pose']/field[@name='FIST']"
		[Register ("FIST")]
		public static global::Com.Thalmic.Myo.Pose Fist {
			get {
				if (FIST_jfieldId == IntPtr.Zero)
					FIST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FIST", "Lcom/thalmic/myo/Pose;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FIST_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Pose> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr REST_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.thalmic.myo']/class[@name='Pose']/field[@name='REST']"
		[Register ("REST")]
		public static global::Com.Thalmic.Myo.Pose Rest {
			get {
				if (REST_jfieldId == IntPtr.Zero)
					REST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REST", "Lcom/thalmic/myo/Pose;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, REST_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Pose> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr THUMB_TO_PINKY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.thalmic.myo']/class[@name='Pose']/field[@name='THUMB_TO_PINKY']"
		[Register ("THUMB_TO_PINKY")]
		public static global::Com.Thalmic.Myo.Pose ThumbToPinky {
			get {
				if (THUMB_TO_PINKY_jfieldId == IntPtr.Zero)
					THUMB_TO_PINKY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "THUMB_TO_PINKY", "Lcom/thalmic/myo/Pose;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, THUMB_TO_PINKY_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Pose> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr UNKNOWN_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.thalmic.myo']/class[@name='Pose']/field[@name='UNKNOWN']"
		[Register ("UNKNOWN")]
		public static global::Com.Thalmic.Myo.Pose Unknown {
			get {
				if (UNKNOWN_jfieldId == IntPtr.Zero)
					UNKNOWN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNKNOWN", "Lcom/thalmic/myo/Pose;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNKNOWN_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Pose> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr WAVE_IN_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.thalmic.myo']/class[@name='Pose']/field[@name='WAVE_IN']"
		[Register ("WAVE_IN")]
		public static global::Com.Thalmic.Myo.Pose WaveIn {
			get {
				if (WAVE_IN_jfieldId == IntPtr.Zero)
					WAVE_IN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WAVE_IN", "Lcom/thalmic/myo/Pose;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, WAVE_IN_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Pose> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr WAVE_OUT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.thalmic.myo']/class[@name='Pose']/field[@name='WAVE_OUT']"
		[Register ("WAVE_OUT")]
		public static global::Com.Thalmic.Myo.Pose WaveOut {
			get {
				if (WAVE_OUT_jfieldId == IntPtr.Zero)
					WAVE_OUT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WAVE_OUT", "Lcom/thalmic/myo/Pose;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, WAVE_OUT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Pose> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/thalmic/myo/Pose", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Pose); }
		}

		internal Pose (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo']/class[@name='Pose']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/thalmic/myo/Pose;", "")]
		public static global::Com.Thalmic.Myo.Pose ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/thalmic/myo/Pose;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				global::Com.Thalmic.Myo.Pose __ret = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Pose> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo']/class[@name='Pose']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/thalmic/myo/Pose;", "")]
		public static global::Com.Thalmic.Myo.Pose[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/thalmic/myo/Pose;");
			try {
				return (global::Com.Thalmic.Myo.Pose[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Thalmic.Myo.Pose));
			} finally {
			}
		}

	}
}
