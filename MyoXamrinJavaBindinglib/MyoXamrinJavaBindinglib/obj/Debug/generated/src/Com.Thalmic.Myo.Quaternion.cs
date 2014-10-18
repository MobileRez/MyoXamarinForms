using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Thalmic.Myo {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.thalmic.myo']/class[@name='Quaternion']"
	[global::Android.Runtime.Register ("com/thalmic/myo/Quaternion", DoNotGenerateAcw=true)]
	public partial class Quaternion : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/thalmic/myo/Quaternion", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Quaternion); }
		}

		protected Quaternion (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.thalmic.myo']/class[@name='Quaternion']/constructor[@name='Quaternion' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public Quaternion () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Quaternion)) {
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

		static IntPtr id_ctor_DDDD;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.thalmic.myo']/class[@name='Quaternion']/constructor[@name='Quaternion' and count(parameter)=4 and parameter[1][@type='double'] and parameter[2][@type='double'] and parameter[3][@type='double'] and parameter[4][@type='double']]"
		[Register (".ctor", "(DDDD)V", "")]
		public Quaternion (double p0, double p1, double p2, double p3) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Quaternion)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(DDDD)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(DDDD)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
					return;
				}

				if (id_ctor_DDDD == IntPtr.Zero)
					id_ctor_DDDD = JNIEnv.GetMethodID (class_ref, "<init>", "(DDDD)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_DDDD, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_DDDD, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
			} finally {
			}
		}

		static IntPtr id_ctor_Lcom_thalmic_myo_Quaternion_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.thalmic.myo']/class[@name='Quaternion']/constructor[@name='Quaternion' and count(parameter)=1 and parameter[1][@type='com.thalmic.myo.Quaternion']]"
		[Register (".ctor", "(Lcom/thalmic/myo/Quaternion;)V", "")]
		public Quaternion (global::Com.Thalmic.Myo.Quaternion p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Quaternion)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/thalmic/myo/Quaternion;)V", new JValue (p0)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/thalmic/myo/Quaternion;)V", new JValue (p0));
					return;
				}

				if (id_ctor_Lcom_thalmic_myo_Quaternion_ == IntPtr.Zero)
					id_ctor_Lcom_thalmic_myo_Quaternion_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/thalmic/myo/Quaternion;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_thalmic_myo_Quaternion_, new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_thalmic_myo_Quaternion_, new JValue (p0));
			} finally {
			}
		}

		static Delegate cb_inverse;
#pragma warning disable 0169
		static Delegate GetInverseHandler ()
		{
			if (cb_inverse == null)
				cb_inverse = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Inverse);
			return cb_inverse;
		}

		static void n_Inverse (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Thalmic.Myo.Quaternion __this = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Quaternion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Inverse ();
		}
#pragma warning restore 0169

		static IntPtr id_inverse;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo']/class[@name='Quaternion']/method[@name='inverse' and count(parameter)=0]"
		[Register ("inverse", "()V", "GetInverseHandler")]
		public virtual void Inverse ()
		{
			if (id_inverse == IntPtr.Zero)
				id_inverse = JNIEnv.GetMethodID (class_ref, "inverse", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_inverse);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "inverse", "()V"));
			} finally {
			}
		}

		static Delegate cb_length;
#pragma warning disable 0169
		static Delegate GetLengthHandler ()
		{
			if (cb_length == null)
				cb_length = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_Length);
			return cb_length;
		}

		static double n_Length (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Thalmic.Myo.Quaternion __this = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Quaternion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Length ();
		}
#pragma warning restore 0169

		static IntPtr id_length;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo']/class[@name='Quaternion']/method[@name='length' and count(parameter)=0]"
		[Register ("length", "()D", "GetLengthHandler")]
		public virtual double Length ()
		{
			if (id_length == IntPtr.Zero)
				id_length = JNIEnv.GetMethodID (class_ref, "length", "()D");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod  (Handle, id_length);
				else
					return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "length", "()D"));
			} finally {
			}
		}

		static Delegate cb_multiply_Lcom_thalmic_myo_Quaternion_;
#pragma warning disable 0169
		static Delegate GetMultiply_Lcom_thalmic_myo_Quaternion_Handler ()
		{
			if (cb_multiply_Lcom_thalmic_myo_Quaternion_ == null)
				cb_multiply_Lcom_thalmic_myo_Quaternion_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Multiply_Lcom_thalmic_myo_Quaternion_);
			return cb_multiply_Lcom_thalmic_myo_Quaternion_;
		}

		static void n_Multiply_Lcom_thalmic_myo_Quaternion_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Thalmic.Myo.Quaternion __this = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Quaternion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Thalmic.Myo.Quaternion p0 = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Quaternion> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Multiply (p0);
		}
#pragma warning restore 0169

		static IntPtr id_multiply_Lcom_thalmic_myo_Quaternion_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo']/class[@name='Quaternion']/method[@name='multiply' and count(parameter)=1 and parameter[1][@type='com.thalmic.myo.Quaternion']]"
		[Register ("multiply", "(Lcom/thalmic/myo/Quaternion;)V", "GetMultiply_Lcom_thalmic_myo_Quaternion_Handler")]
		public virtual void Multiply (global::Com.Thalmic.Myo.Quaternion p0)
		{
			if (id_multiply_Lcom_thalmic_myo_Quaternion_ == IntPtr.Zero)
				id_multiply_Lcom_thalmic_myo_Quaternion_ = JNIEnv.GetMethodID (class_ref, "multiply", "(Lcom/thalmic/myo/Quaternion;)V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_multiply_Lcom_thalmic_myo_Quaternion_, new JValue (p0));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "multiply", "(Lcom/thalmic/myo/Quaternion;)V"), new JValue (p0));
			} finally {
			}
		}

		static Delegate cb_normalized;
#pragma warning disable 0169
		static Delegate GetNormalizedHandler ()
		{
			if (cb_normalized == null)
				cb_normalized = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Normalized);
			return cb_normalized;
		}

		static IntPtr n_Normalized (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Thalmic.Myo.Quaternion __this = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Quaternion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Normalized ());
		}
#pragma warning restore 0169

		static IntPtr id_normalized;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo']/class[@name='Quaternion']/method[@name='normalized' and count(parameter)=0]"
		[Register ("normalized", "()Lcom/thalmic/myo/Quaternion;", "GetNormalizedHandler")]
		public virtual global::Com.Thalmic.Myo.Quaternion Normalized ()
		{
			if (id_normalized == IntPtr.Zero)
				id_normalized = JNIEnv.GetMethodID (class_ref, "normalized", "()Lcom/thalmic/myo/Quaternion;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Quaternion> (JNIEnv.CallObjectMethod  (Handle, id_normalized), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Quaternion> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "normalized", "()Lcom/thalmic/myo/Quaternion;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_pitch_Lcom_thalmic_myo_Quaternion_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo']/class[@name='Quaternion']/method[@name='pitch' and count(parameter)=1 and parameter[1][@type='com.thalmic.myo.Quaternion']]"
		[Register ("pitch", "(Lcom/thalmic/myo/Quaternion;)D", "")]
		public static double Pitch (global::Com.Thalmic.Myo.Quaternion p0)
		{
			if (id_pitch_Lcom_thalmic_myo_Quaternion_ == IntPtr.Zero)
				id_pitch_Lcom_thalmic_myo_Quaternion_ = JNIEnv.GetStaticMethodID (class_ref, "pitch", "(Lcom/thalmic/myo/Quaternion;)D");
			try {
				double __ret = JNIEnv.CallStaticDoubleMethod  (class_ref, id_pitch_Lcom_thalmic_myo_Quaternion_, new JValue (p0));
				return __ret;
			} finally {
			}
		}

		static IntPtr id_roll_Lcom_thalmic_myo_Quaternion_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo']/class[@name='Quaternion']/method[@name='roll' and count(parameter)=1 and parameter[1][@type='com.thalmic.myo.Quaternion']]"
		[Register ("roll", "(Lcom/thalmic/myo/Quaternion;)D", "")]
		public static double Roll (global::Com.Thalmic.Myo.Quaternion p0)
		{
			if (id_roll_Lcom_thalmic_myo_Quaternion_ == IntPtr.Zero)
				id_roll_Lcom_thalmic_myo_Quaternion_ = JNIEnv.GetStaticMethodID (class_ref, "roll", "(Lcom/thalmic/myo/Quaternion;)D");
			try {
				double __ret = JNIEnv.CallStaticDoubleMethod  (class_ref, id_roll_Lcom_thalmic_myo_Quaternion_, new JValue (p0));
				return __ret;
			} finally {
			}
		}

		static Delegate cb_set_Lcom_thalmic_myo_Quaternion_;
#pragma warning disable 0169
		static Delegate GetSet_Lcom_thalmic_myo_Quaternion_Handler ()
		{
			if (cb_set_Lcom_thalmic_myo_Quaternion_ == null)
				cb_set_Lcom_thalmic_myo_Quaternion_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Set_Lcom_thalmic_myo_Quaternion_);
			return cb_set_Lcom_thalmic_myo_Quaternion_;
		}

		static void n_Set_Lcom_thalmic_myo_Quaternion_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Thalmic.Myo.Quaternion __this = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Quaternion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Thalmic.Myo.Quaternion p0 = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Quaternion> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Set (p0);
		}
#pragma warning restore 0169

		static IntPtr id_set_Lcom_thalmic_myo_Quaternion_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo']/class[@name='Quaternion']/method[@name='set' and count(parameter)=1 and parameter[1][@type='com.thalmic.myo.Quaternion']]"
		[Register ("set", "(Lcom/thalmic/myo/Quaternion;)V", "GetSet_Lcom_thalmic_myo_Quaternion_Handler")]
		public virtual void Set (global::Com.Thalmic.Myo.Quaternion p0)
		{
			if (id_set_Lcom_thalmic_myo_Quaternion_ == IntPtr.Zero)
				id_set_Lcom_thalmic_myo_Quaternion_ = JNIEnv.GetMethodID (class_ref, "set", "(Lcom/thalmic/myo/Quaternion;)V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_set_Lcom_thalmic_myo_Quaternion_, new JValue (p0));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "set", "(Lcom/thalmic/myo/Quaternion;)V"), new JValue (p0));
			} finally {
			}
		}

		static Delegate cb_w;
#pragma warning disable 0169
		static Delegate GetWHandler ()
		{
			if (cb_w == null)
				cb_w = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_W);
			return cb_w;
		}

		static double n_W (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Thalmic.Myo.Quaternion __this = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Quaternion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.W ();
		}
#pragma warning restore 0169

		static IntPtr id_w;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo']/class[@name='Quaternion']/method[@name='w' and count(parameter)=0]"
		[Register ("w", "()D", "GetWHandler")]
		public virtual double W ()
		{
			if (id_w == IntPtr.Zero)
				id_w = JNIEnv.GetMethodID (class_ref, "w", "()D");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod  (Handle, id_w);
				else
					return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "w", "()D"));
			} finally {
			}
		}

		static Delegate cb_x;
#pragma warning disable 0169
		static Delegate GetXHandler ()
		{
			if (cb_x == null)
				cb_x = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_X);
			return cb_x;
		}

		static double n_X (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Thalmic.Myo.Quaternion __this = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Quaternion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.X ();
		}
#pragma warning restore 0169

		static IntPtr id_x;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo']/class[@name='Quaternion']/method[@name='x' and count(parameter)=0]"
		[Register ("x", "()D", "GetXHandler")]
		public virtual double X ()
		{
			if (id_x == IntPtr.Zero)
				id_x = JNIEnv.GetMethodID (class_ref, "x", "()D");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod  (Handle, id_x);
				else
					return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "x", "()D"));
			} finally {
			}
		}

		static Delegate cb_y;
#pragma warning disable 0169
		static Delegate GetYHandler ()
		{
			if (cb_y == null)
				cb_y = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_Y);
			return cb_y;
		}

		static double n_Y (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Thalmic.Myo.Quaternion __this = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Quaternion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Y ();
		}
#pragma warning restore 0169

		static IntPtr id_y;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo']/class[@name='Quaternion']/method[@name='y' and count(parameter)=0]"
		[Register ("y", "()D", "GetYHandler")]
		public virtual double Y ()
		{
			if (id_y == IntPtr.Zero)
				id_y = JNIEnv.GetMethodID (class_ref, "y", "()D");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod  (Handle, id_y);
				else
					return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "y", "()D"));
			} finally {
			}
		}

		static IntPtr id_yaw_Lcom_thalmic_myo_Quaternion_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo']/class[@name='Quaternion']/method[@name='yaw' and count(parameter)=1 and parameter[1][@type='com.thalmic.myo.Quaternion']]"
		[Register ("yaw", "(Lcom/thalmic/myo/Quaternion;)D", "")]
		public static double Yaw (global::Com.Thalmic.Myo.Quaternion p0)
		{
			if (id_yaw_Lcom_thalmic_myo_Quaternion_ == IntPtr.Zero)
				id_yaw_Lcom_thalmic_myo_Quaternion_ = JNIEnv.GetStaticMethodID (class_ref, "yaw", "(Lcom/thalmic/myo/Quaternion;)D");
			try {
				double __ret = JNIEnv.CallStaticDoubleMethod  (class_ref, id_yaw_Lcom_thalmic_myo_Quaternion_, new JValue (p0));
				return __ret;
			} finally {
			}
		}

		static Delegate cb_z;
#pragma warning disable 0169
		static Delegate GetZHandler ()
		{
			if (cb_z == null)
				cb_z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_Z);
			return cb_z;
		}

		static double n_Z (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Thalmic.Myo.Quaternion __this = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Quaternion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Z ();
		}
#pragma warning restore 0169

		static IntPtr id_z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo']/class[@name='Quaternion']/method[@name='z' and count(parameter)=0]"
		[Register ("z", "()D", "GetZHandler")]
		public virtual double Z ()
		{
			if (id_z == IntPtr.Zero)
				id_z = JNIEnv.GetMethodID (class_ref, "z", "()D");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod  (Handle, id_z);
				else
					return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "z", "()D"));
			} finally {
			}
		}

	}
}
