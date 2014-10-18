using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Thalmic.Myo {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.thalmic.myo']/class[@name='Vector3']"
	[global::Android.Runtime.Register ("com/thalmic/myo/Vector3", DoNotGenerateAcw=true)]
	public partial class Vector3 : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/thalmic/myo/Vector3", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Vector3); }
		}

		protected Vector3 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_DDD;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.thalmic.myo']/class[@name='Vector3']/constructor[@name='Vector3' and count(parameter)=3 and parameter[1][@type='double'] and parameter[2][@type='double'] and parameter[3][@type='double']]"
		[Register (".ctor", "(DDD)V", "")]
		public Vector3 (double p0, double p1, double p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Vector3)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(DDD)V", new JValue (p0), new JValue (p1), new JValue (p2)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(DDD)V", new JValue (p0), new JValue (p1), new JValue (p2));
					return;
				}

				if (id_ctor_DDD == IntPtr.Zero)
					id_ctor_DDD = JNIEnv.GetMethodID (class_ref, "<init>", "(DDD)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_DDD, new JValue (p0), new JValue (p1), new JValue (p2)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_DDD, new JValue (p0), new JValue (p1), new JValue (p2));
			} finally {
			}
		}

		static IntPtr id_ctor_Lcom_thalmic_myo_Vector3_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.thalmic.myo']/class[@name='Vector3']/constructor[@name='Vector3' and count(parameter)=1 and parameter[1][@type='com.thalmic.myo.Vector3']]"
		[Register (".ctor", "(Lcom/thalmic/myo/Vector3;)V", "")]
		public Vector3 (global::Com.Thalmic.Myo.Vector3 p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Vector3)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/thalmic/myo/Vector3;)V", new JValue (p0)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/thalmic/myo/Vector3;)V", new JValue (p0));
					return;
				}

				if (id_ctor_Lcom_thalmic_myo_Vector3_ == IntPtr.Zero)
					id_ctor_Lcom_thalmic_myo_Vector3_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/thalmic/myo/Vector3;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_thalmic_myo_Vector3_, new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_thalmic_myo_Vector3_, new JValue (p0));
			} finally {
			}
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.thalmic.myo']/class[@name='Vector3']/constructor[@name='Vector3' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public Vector3 () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Vector3)) {
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

		static Delegate cb_add_Lcom_thalmic_myo_Vector3_;
#pragma warning disable 0169
		static Delegate GetAdd_Lcom_thalmic_myo_Vector3_Handler ()
		{
			if (cb_add_Lcom_thalmic_myo_Vector3_ == null)
				cb_add_Lcom_thalmic_myo_Vector3_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Add_Lcom_thalmic_myo_Vector3_);
			return cb_add_Lcom_thalmic_myo_Vector3_;
		}

		static void n_Add_Lcom_thalmic_myo_Vector3_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Thalmic.Myo.Vector3 __this = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Vector3> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Thalmic.Myo.Vector3 p0 = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Vector3> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Add (p0);
		}
#pragma warning restore 0169

		static IntPtr id_add_Lcom_thalmic_myo_Vector3_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo']/class[@name='Vector3']/method[@name='add' and count(parameter)=1 and parameter[1][@type='com.thalmic.myo.Vector3']]"
		[Register ("add", "(Lcom/thalmic/myo/Vector3;)V", "GetAdd_Lcom_thalmic_myo_Vector3_Handler")]
		public virtual void Add (global::Com.Thalmic.Myo.Vector3 p0)
		{
			if (id_add_Lcom_thalmic_myo_Vector3_ == IntPtr.Zero)
				id_add_Lcom_thalmic_myo_Vector3_ = JNIEnv.GetMethodID (class_ref, "add", "(Lcom/thalmic/myo/Vector3;)V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_add_Lcom_thalmic_myo_Vector3_, new JValue (p0));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "add", "(Lcom/thalmic/myo/Vector3;)V"), new JValue (p0));
			} finally {
			}
		}

		static Delegate cb_divide_D;
#pragma warning disable 0169
		static Delegate GetDivide_DHandler ()
		{
			if (cb_divide_D == null)
				cb_divide_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_Divide_D);
			return cb_divide_D;
		}

		static void n_Divide_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Com.Thalmic.Myo.Vector3 __this = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Vector3> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Divide (p0);
		}
#pragma warning restore 0169

		static IntPtr id_divide_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo']/class[@name='Vector3']/method[@name='divide' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("divide", "(D)V", "GetDivide_DHandler")]
		public virtual void Divide (double p0)
		{
			if (id_divide_D == IntPtr.Zero)
				id_divide_D = JNIEnv.GetMethodID (class_ref, "divide", "(D)V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_divide_D, new JValue (p0));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "divide", "(D)V"), new JValue (p0));
			} finally {
			}
		}

		static Delegate cb_dot_Lcom_thalmic_myo_Vector3_;
#pragma warning disable 0169
		static Delegate GetDot_Lcom_thalmic_myo_Vector3_Handler ()
		{
			if (cb_dot_Lcom_thalmic_myo_Vector3_ == null)
				cb_dot_Lcom_thalmic_myo_Vector3_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, double>) n_Dot_Lcom_thalmic_myo_Vector3_);
			return cb_dot_Lcom_thalmic_myo_Vector3_;
		}

		static double n_Dot_Lcom_thalmic_myo_Vector3_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Thalmic.Myo.Vector3 __this = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Vector3> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Thalmic.Myo.Vector3 p0 = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Vector3> (native_p0, JniHandleOwnership.DoNotTransfer);
			double __ret = __this.Dot (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_dot_Lcom_thalmic_myo_Vector3_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo']/class[@name='Vector3']/method[@name='dot' and count(parameter)=1 and parameter[1][@type='com.thalmic.myo.Vector3']]"
		[Register ("dot", "(Lcom/thalmic/myo/Vector3;)D", "GetDot_Lcom_thalmic_myo_Vector3_Handler")]
		public virtual double Dot (global::Com.Thalmic.Myo.Vector3 p0)
		{
			if (id_dot_Lcom_thalmic_myo_Vector3_ == IntPtr.Zero)
				id_dot_Lcom_thalmic_myo_Vector3_ = JNIEnv.GetMethodID (class_ref, "dot", "(Lcom/thalmic/myo/Vector3;)D");
			try {

				double __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallDoubleMethod  (Handle, id_dot_Lcom_thalmic_myo_Vector3_, new JValue (p0));
				else
					__ret = JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dot", "(Lcom/thalmic/myo/Vector3;)D"), new JValue (p0));
				return __ret;
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
			global::Com.Thalmic.Myo.Vector3 __this = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Vector3> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Length ();
		}
#pragma warning restore 0169

		static IntPtr id_length;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo']/class[@name='Vector3']/method[@name='length' and count(parameter)=0]"
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

		static Delegate cb_multiply_D;
#pragma warning disable 0169
		static Delegate GetMultiply_DHandler ()
		{
			if (cb_multiply_D == null)
				cb_multiply_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_Multiply_D);
			return cb_multiply_D;
		}

		static void n_Multiply_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Com.Thalmic.Myo.Vector3 __this = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Vector3> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Multiply (p0);
		}
#pragma warning restore 0169

		static IntPtr id_multiply_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo']/class[@name='Vector3']/method[@name='multiply' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("multiply", "(D)V", "GetMultiply_DHandler")]
		public virtual void Multiply (double p0)
		{
			if (id_multiply_D == IntPtr.Zero)
				id_multiply_D = JNIEnv.GetMethodID (class_ref, "multiply", "(D)V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_multiply_D, new JValue (p0));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "multiply", "(D)V"), new JValue (p0));
			} finally {
			}
		}

		static Delegate cb_normalize;
#pragma warning disable 0169
		static Delegate GetNormalizeHandler ()
		{
			if (cb_normalize == null)
				cb_normalize = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Normalize);
			return cb_normalize;
		}

		static void n_Normalize (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Thalmic.Myo.Vector3 __this = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Vector3> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Normalize ();
		}
#pragma warning restore 0169

		static IntPtr id_normalize;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo']/class[@name='Vector3']/method[@name='normalize' and count(parameter)=0]"
		[Register ("normalize", "()V", "GetNormalizeHandler")]
		public virtual void Normalize ()
		{
			if (id_normalize == IntPtr.Zero)
				id_normalize = JNIEnv.GetMethodID (class_ref, "normalize", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_normalize);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "normalize", "()V"));
			} finally {
			}
		}

		static Delegate cb_set_Lcom_thalmic_myo_Vector3_;
#pragma warning disable 0169
		static Delegate GetSet_Lcom_thalmic_myo_Vector3_Handler ()
		{
			if (cb_set_Lcom_thalmic_myo_Vector3_ == null)
				cb_set_Lcom_thalmic_myo_Vector3_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Set_Lcom_thalmic_myo_Vector3_);
			return cb_set_Lcom_thalmic_myo_Vector3_;
		}

		static void n_Set_Lcom_thalmic_myo_Vector3_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Thalmic.Myo.Vector3 __this = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Vector3> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Thalmic.Myo.Vector3 p0 = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Vector3> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Set (p0);
		}
#pragma warning restore 0169

		static IntPtr id_set_Lcom_thalmic_myo_Vector3_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo']/class[@name='Vector3']/method[@name='set' and count(parameter)=1 and parameter[1][@type='com.thalmic.myo.Vector3']]"
		[Register ("set", "(Lcom/thalmic/myo/Vector3;)V", "GetSet_Lcom_thalmic_myo_Vector3_Handler")]
		public virtual void Set (global::Com.Thalmic.Myo.Vector3 p0)
		{
			if (id_set_Lcom_thalmic_myo_Vector3_ == IntPtr.Zero)
				id_set_Lcom_thalmic_myo_Vector3_ = JNIEnv.GetMethodID (class_ref, "set", "(Lcom/thalmic/myo/Vector3;)V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_set_Lcom_thalmic_myo_Vector3_, new JValue (p0));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "set", "(Lcom/thalmic/myo/Vector3;)V"), new JValue (p0));
			} finally {
			}
		}

		static Delegate cb_subtract_Lcom_thalmic_myo_Vector3_;
#pragma warning disable 0169
		static Delegate GetSubtract_Lcom_thalmic_myo_Vector3_Handler ()
		{
			if (cb_subtract_Lcom_thalmic_myo_Vector3_ == null)
				cb_subtract_Lcom_thalmic_myo_Vector3_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Subtract_Lcom_thalmic_myo_Vector3_);
			return cb_subtract_Lcom_thalmic_myo_Vector3_;
		}

		static void n_Subtract_Lcom_thalmic_myo_Vector3_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Thalmic.Myo.Vector3 __this = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Vector3> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Thalmic.Myo.Vector3 p0 = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Vector3> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Subtract (p0);
		}
#pragma warning restore 0169

		static IntPtr id_subtract_Lcom_thalmic_myo_Vector3_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo']/class[@name='Vector3']/method[@name='subtract' and count(parameter)=1 and parameter[1][@type='com.thalmic.myo.Vector3']]"
		[Register ("subtract", "(Lcom/thalmic/myo/Vector3;)V", "GetSubtract_Lcom_thalmic_myo_Vector3_Handler")]
		public virtual void Subtract (global::Com.Thalmic.Myo.Vector3 p0)
		{
			if (id_subtract_Lcom_thalmic_myo_Vector3_ == IntPtr.Zero)
				id_subtract_Lcom_thalmic_myo_Vector3_ = JNIEnv.GetMethodID (class_ref, "subtract", "(Lcom/thalmic/myo/Vector3;)V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_subtract_Lcom_thalmic_myo_Vector3_, new JValue (p0));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "subtract", "(Lcom/thalmic/myo/Vector3;)V"), new JValue (p0));
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
			global::Com.Thalmic.Myo.Vector3 __this = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Vector3> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.X ();
		}
#pragma warning restore 0169

		static IntPtr id_x;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo']/class[@name='Vector3']/method[@name='x' and count(parameter)=0]"
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
			global::Com.Thalmic.Myo.Vector3 __this = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Vector3> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Y ();
		}
#pragma warning restore 0169

		static IntPtr id_y;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo']/class[@name='Vector3']/method[@name='y' and count(parameter)=0]"
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
			global::Com.Thalmic.Myo.Vector3 __this = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Vector3> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Z ();
		}
#pragma warning restore 0169

		static IntPtr id_z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo']/class[@name='Vector3']/method[@name='z' and count(parameter)=0]"
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
