using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Thalmic.Myo.Internal.Classifier {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.thalmic.myo.internal.classifier']/class[@name='Classifier']"
	[global::Android.Runtime.Register ("com/thalmic/myo/internal/classifier/Classifier", DoNotGenerateAcw=true)]
	public partial class Classifier : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.thalmic.myo.internal.classifier']/class[@name='Classifier']/field[@name='HARDWARE_REV_REVC']"
		[Register ("HARDWARE_REV_REVC")]
		public const int HardwareRevRevc = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.thalmic.myo.internal.classifier']/class[@name='Classifier']/field[@name='HARDWARE_REV_REVD']"
		[Register ("HARDWARE_REV_REVD")]
		public const int HardwareRevRevd = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.thalmic.myo.internal.classifier']/class[@name='Classifier']/field[@name='HARDWARE_REV_UNKNOWN']"
		[Register ("HARDWARE_REV_UNKNOWN")]
		public const int HardwareRevUnknown = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.thalmic.myo.internal.classifier']/class[@name='Classifier']/field[@name='MYO_ARM_LEFT']"
		[Register ("MYO_ARM_LEFT")]
		public const int MyoArmLeft = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.thalmic.myo.internal.classifier']/class[@name='Classifier']/field[@name='MYO_ARM_RIGHT']"
		[Register ("MYO_ARM_RIGHT")]
		public const int MyoArmRight = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.thalmic.myo.internal.classifier']/class[@name='Classifier']/field[@name='MYO_ARM_UNKNOWN']"
		[Register ("MYO_ARM_UNKNOWN")]
		public const int MyoArmUnknown = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.thalmic.myo.internal.classifier']/class[@name='Classifier']/field[@name='MYO_STATE_CLASSIFYING']"
		[Register ("MYO_STATE_CLASSIFYING")]
		public const int MyoStateClassifying = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.thalmic.myo.internal.classifier']/class[@name='Classifier']/field[@name='MYO_STATE_READY']"
		[Register ("MYO_STATE_READY")]
		public const int MyoStateReady = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.thalmic.myo.internal.classifier']/class[@name='Classifier']/field[@name='MYO_STATE_UNSTABLE']"
		[Register ("MYO_STATE_UNSTABLE")]
		public const int MyoStateUnstable = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.thalmic.myo.internal.classifier']/class[@name='Classifier']/field[@name='MYO_X_DIRECTION_TOWARD_ELBOW']"
		[Register ("MYO_X_DIRECTION_TOWARD_ELBOW")]
		public const int MyoXDirectionTowardElbow = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.thalmic.myo.internal.classifier']/class[@name='Classifier']/field[@name='MYO_X_DIRECTION_TOWARD_WRIST']"
		[Register ("MYO_X_DIRECTION_TOWARD_WRIST")]
		public const int MyoXDirectionTowardWrist = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.thalmic.myo.internal.classifier']/class[@name='Classifier']/field[@name='MYO_X_DIRECTION_UNKNOWN']"
		[Register ("MYO_X_DIRECTION_UNKNOWN")]
		public const int MyoXDirectionUnknown = (int) 65535;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.thalmic.myo.internal.classifier']/class[@name='Classifier']/field[@name='NUM_HARDWARE_REVS']"
		[Register ("NUM_HARDWARE_REVS")]
		public const int NumHardwareRevs = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.thalmic.myo.internal.classifier']/class[@name='Classifier']/field[@name='NUM_POSES']"
		[Register ("NUM_POSES")]
		public const int NumPoses = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.thalmic.myo.internal.classifier']/class[@name='Classifier']/field[@name='POSE_FINGERS_SPREAD']"
		[Register ("POSE_FINGERS_SPREAD")]
		public const int PoseFingersSpread = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.thalmic.myo.internal.classifier']/class[@name='Classifier']/field[@name='POSE_FIST']"
		[Register ("POSE_FIST")]
		public const int PoseFist = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.thalmic.myo.internal.classifier']/class[@name='Classifier']/field[@name='POSE_REST']"
		[Register ("POSE_REST")]
		public const int PoseRest = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.thalmic.myo.internal.classifier']/class[@name='Classifier']/field[@name='POSE_THUMB_TO_PINKY']"
		[Register ("POSE_THUMB_TO_PINKY")]
		public const int PoseThumbToPinky = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.thalmic.myo.internal.classifier']/class[@name='Classifier']/field[@name='POSE_UNKNOWN']"
		[Register ("POSE_UNKNOWN")]
		public const int PoseUnknown = (int) 65535;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.thalmic.myo.internal.classifier']/class[@name='Classifier']/field[@name='POSE_WAVE_IN']"
		[Register ("POSE_WAVE_IN")]
		public const int PoseWaveIn = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.thalmic.myo.internal.classifier']/class[@name='Classifier']/field[@name='POSE_WAVE_OUT']"
		[Register ("POSE_WAVE_OUT")]
		public const int PoseWaveOut = (int) 3;
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.thalmic.myo.internal.classifier']/interface[@name='Classifier.PoseClassifier']"
		[Register ("com/thalmic/myo/internal/classifier/Classifier$PoseClassifier", "", "Com.Thalmic.Myo.Internal.Classifier.Classifier/IPoseClassifierInvoker")]
		public partial interface IPoseClassifier : IJavaObject {

			int Arm {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo.internal.classifier']/interface[@name='Classifier.PoseClassifier']/method[@name='getArm' and count(parameter)=0]"
				[Register ("getArm", "()I", "GetGetArmHandler:Com.Thalmic.Myo.Internal.Classifier.Classifier/IPoseClassifierInvoker, MyoXamrinJavaBindinglib")] get;
			}

			bool IsTrained {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo.internal.classifier']/interface[@name='Classifier.PoseClassifier']/method[@name='isTrained' and count(parameter)=0]"
				[Register ("isTrained", "()Z", "GetIsTrainedHandler:Com.Thalmic.Myo.Internal.Classifier.Classifier/IPoseClassifierInvoker, MyoXamrinJavaBindinglib")] get;
			}

			int State {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo.internal.classifier']/interface[@name='Classifier.PoseClassifier']/method[@name='getState' and count(parameter)=0]"
				[Register ("getState", "()I", "GetGetStateHandler:Com.Thalmic.Myo.Internal.Classifier.Classifier/IPoseClassifierInvoker, MyoXamrinJavaBindinglib")] get;
			}

			int XDirection {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo.internal.classifier']/interface[@name='Classifier.PoseClassifier']/method[@name='getXDirection' and count(parameter)=0]"
				[Register ("getXDirection", "()I", "GetGetXDirectionHandler:Com.Thalmic.Myo.Internal.Classifier.Classifier/IPoseClassifierInvoker, MyoXamrinJavaBindinglib")] get;
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo.internal.classifier']/interface[@name='Classifier.PoseClassifier']/method[@name='classify' and count(parameter)=2 and parameter[1][@type='float[]'] and parameter[2][@type='short']]"
			[Register ("classify", "([FS)I", "GetClassify_arrayFSHandler:Com.Thalmic.Myo.Internal.Classifier.Classifier/IPoseClassifierInvoker, MyoXamrinJavaBindinglib")]
			int Classify (float[] p0, short p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo.internal.classifier']/interface[@name='Classifier.PoseClassifier']/method[@name='destroy' and count(parameter)=0]"
			[Register ("destroy", "()V", "GetDestroyHandler:Com.Thalmic.Myo.Internal.Classifier.Classifier/IPoseClassifierInvoker, MyoXamrinJavaBindinglib")]
			void Destroy ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo.internal.classifier']/interface[@name='Classifier.PoseClassifier']/method[@name='pushImuData' and count(parameter)=1 and parameter[1][@type='float[]']]"
			[Register ("pushImuData", "([F)V", "GetPushImuData_arrayFHandler:Com.Thalmic.Myo.Internal.Classifier.Classifier/IPoseClassifierInvoker, MyoXamrinJavaBindinglib")]
			void PushImuData (float[] p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo.internal.classifier']/interface[@name='Classifier.PoseClassifier']/method[@name='setHardwareRev' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setHardwareRev", "(I)V", "GetSetHardwareRev_IHandler:Com.Thalmic.Myo.Internal.Classifier.Classifier/IPoseClassifierInvoker, MyoXamrinJavaBindinglib")]
			void SetHardwareRev (int p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo.internal.classifier']/interface[@name='Classifier.PoseClassifier']/method[@name='train' and count(parameter)=1 and parameter[1][@type='com.thalmic.myo.internal.classifier.Classifier.TrainingData']]"
			[Register ("train", "(Lcom/thalmic/myo/internal/classifier/Classifier$TrainingData;)Z", "GetTrain_Lcom_thalmic_myo_internal_classifier_Classifier_TrainingData_Handler:Com.Thalmic.Myo.Internal.Classifier.Classifier/IPoseClassifierInvoker, MyoXamrinJavaBindinglib")]
			bool Train (global::Com.Thalmic.Myo.Internal.Classifier.Classifier.TrainingData p0);

		}

		[global::Android.Runtime.Register ("com/thalmic/myo/internal/classifier/Classifier$PoseClassifier", DoNotGenerateAcw=true)]
		internal class IPoseClassifierInvoker : global::Java.Lang.Object, IPoseClassifier {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/thalmic/myo/internal/classifier/Classifier$PoseClassifier");
			IntPtr class_ref;

			public static IPoseClassifier GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IPoseClassifier> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.thalmic.myo.internal.classifier.Classifier.PoseClassifier"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IPoseClassifierInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IPoseClassifierInvoker); }
			}

			static Delegate cb_getArm;
#pragma warning disable 0169
			static Delegate GetGetArmHandler ()
			{
				if (cb_getArm == null)
					cb_getArm = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetArm);
				return cb_getArm;
			}

			static int n_GetArm (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Thalmic.Myo.Internal.Classifier.Classifier.IPoseClassifier __this = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Internal.Classifier.Classifier.IPoseClassifier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Arm;
			}
#pragma warning restore 0169

			IntPtr id_getArm;
			public int Arm {
				get {
					if (id_getArm == IntPtr.Zero)
						id_getArm = JNIEnv.GetMethodID (class_ref, "getArm", "()I");
					return JNIEnv.CallIntMethod (Handle, id_getArm);
				}
			}

			static Delegate cb_isTrained;
#pragma warning disable 0169
			static Delegate GetIsTrainedHandler ()
			{
				if (cb_isTrained == null)
					cb_isTrained = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsTrained);
				return cb_isTrained;
			}

			static bool n_IsTrained (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Thalmic.Myo.Internal.Classifier.Classifier.IPoseClassifier __this = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Internal.Classifier.Classifier.IPoseClassifier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsTrained;
			}
#pragma warning restore 0169

			IntPtr id_isTrained;
			public bool IsTrained {
				get {
					if (id_isTrained == IntPtr.Zero)
						id_isTrained = JNIEnv.GetMethodID (class_ref, "isTrained", "()Z");
					return JNIEnv.CallBooleanMethod (Handle, id_isTrained);
				}
			}

			static Delegate cb_getState;
#pragma warning disable 0169
			static Delegate GetGetStateHandler ()
			{
				if (cb_getState == null)
					cb_getState = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetState);
				return cb_getState;
			}

			static int n_GetState (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Thalmic.Myo.Internal.Classifier.Classifier.IPoseClassifier __this = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Internal.Classifier.Classifier.IPoseClassifier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.State;
			}
#pragma warning restore 0169

			IntPtr id_getState;
			public int State {
				get {
					if (id_getState == IntPtr.Zero)
						id_getState = JNIEnv.GetMethodID (class_ref, "getState", "()I");
					return JNIEnv.CallIntMethod (Handle, id_getState);
				}
			}

			static Delegate cb_getXDirection;
#pragma warning disable 0169
			static Delegate GetGetXDirectionHandler ()
			{
				if (cb_getXDirection == null)
					cb_getXDirection = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetXDirection);
				return cb_getXDirection;
			}

			static int n_GetXDirection (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Thalmic.Myo.Internal.Classifier.Classifier.IPoseClassifier __this = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Internal.Classifier.Classifier.IPoseClassifier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.XDirection;
			}
#pragma warning restore 0169

			IntPtr id_getXDirection;
			public int XDirection {
				get {
					if (id_getXDirection == IntPtr.Zero)
						id_getXDirection = JNIEnv.GetMethodID (class_ref, "getXDirection", "()I");
					return JNIEnv.CallIntMethod (Handle, id_getXDirection);
				}
			}

			static Delegate cb_classify_arrayFS;
#pragma warning disable 0169
			static Delegate GetClassify_arrayFSHandler ()
			{
				if (cb_classify_arrayFS == null)
					cb_classify_arrayFS = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, short, int>) n_Classify_arrayFS);
				return cb_classify_arrayFS;
			}

			static int n_Classify_arrayFS (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, short p1)
			{
				global::Com.Thalmic.Myo.Internal.Classifier.Classifier.IPoseClassifier __this = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Internal.Classifier.Classifier.IPoseClassifier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				float[] p0 = (float[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (float));
				int __ret = __this.Classify (p0, p1);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_classify_arrayFS;
			public int Classify (float[] p0, short p1)
			{
				if (id_classify_arrayFS == IntPtr.Zero)
					id_classify_arrayFS = JNIEnv.GetMethodID (class_ref, "classify", "([FS)I");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				int __ret = JNIEnv.CallIntMethod (Handle, id_classify_arrayFS, new JValue (native_p0), new JValue (p1));
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				return __ret;
			}

			static Delegate cb_destroy;
#pragma warning disable 0169
			static Delegate GetDestroyHandler ()
			{
				if (cb_destroy == null)
					cb_destroy = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Destroy);
				return cb_destroy;
			}

			static void n_Destroy (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Thalmic.Myo.Internal.Classifier.Classifier.IPoseClassifier __this = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Internal.Classifier.Classifier.IPoseClassifier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Destroy ();
			}
#pragma warning restore 0169

			IntPtr id_destroy;
			public void Destroy ()
			{
				if (id_destroy == IntPtr.Zero)
					id_destroy = JNIEnv.GetMethodID (class_ref, "destroy", "()V");
				JNIEnv.CallVoidMethod (Handle, id_destroy);
			}

			static Delegate cb_pushImuData_arrayF;
#pragma warning disable 0169
			static Delegate GetPushImuData_arrayFHandler ()
			{
				if (cb_pushImuData_arrayF == null)
					cb_pushImuData_arrayF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PushImuData_arrayF);
				return cb_pushImuData_arrayF;
			}

			static void n_PushImuData_arrayF (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Thalmic.Myo.Internal.Classifier.Classifier.IPoseClassifier __this = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Internal.Classifier.Classifier.IPoseClassifier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				float[] p0 = (float[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (float));
				__this.PushImuData (p0);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
			}
#pragma warning restore 0169

			IntPtr id_pushImuData_arrayF;
			public void PushImuData (float[] p0)
			{
				if (id_pushImuData_arrayF == IntPtr.Zero)
					id_pushImuData_arrayF = JNIEnv.GetMethodID (class_ref, "pushImuData", "([F)V");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				JNIEnv.CallVoidMethod (Handle, id_pushImuData_arrayF, new JValue (native_p0));
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_setHardwareRev_I;
#pragma warning disable 0169
			static Delegate GetSetHardwareRev_IHandler ()
			{
				if (cb_setHardwareRev_I == null)
					cb_setHardwareRev_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetHardwareRev_I);
				return cb_setHardwareRev_I;
			}

			static void n_SetHardwareRev_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Thalmic.Myo.Internal.Classifier.Classifier.IPoseClassifier __this = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Internal.Classifier.Classifier.IPoseClassifier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.SetHardwareRev (p0);
			}
#pragma warning restore 0169

			IntPtr id_setHardwareRev_I;
			public void SetHardwareRev (int p0)
			{
				if (id_setHardwareRev_I == IntPtr.Zero)
					id_setHardwareRev_I = JNIEnv.GetMethodID (class_ref, "setHardwareRev", "(I)V");
				JNIEnv.CallVoidMethod (Handle, id_setHardwareRev_I, new JValue (p0));
			}

			static Delegate cb_train_Lcom_thalmic_myo_internal_classifier_Classifier_TrainingData_;
#pragma warning disable 0169
			static Delegate GetTrain_Lcom_thalmic_myo_internal_classifier_Classifier_TrainingData_Handler ()
			{
				if (cb_train_Lcom_thalmic_myo_internal_classifier_Classifier_TrainingData_ == null)
					cb_train_Lcom_thalmic_myo_internal_classifier_Classifier_TrainingData_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Train_Lcom_thalmic_myo_internal_classifier_Classifier_TrainingData_);
				return cb_train_Lcom_thalmic_myo_internal_classifier_Classifier_TrainingData_;
			}

			static bool n_Train_Lcom_thalmic_myo_internal_classifier_Classifier_TrainingData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Thalmic.Myo.Internal.Classifier.Classifier.IPoseClassifier __this = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Internal.Classifier.Classifier.IPoseClassifier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Thalmic.Myo.Internal.Classifier.Classifier.TrainingData p0 = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Internal.Classifier.Classifier.TrainingData> (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.Train (p0);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_train_Lcom_thalmic_myo_internal_classifier_Classifier_TrainingData_;
			public bool Train (global::Com.Thalmic.Myo.Internal.Classifier.Classifier.TrainingData p0)
			{
				if (id_train_Lcom_thalmic_myo_internal_classifier_Classifier_TrainingData_ == IntPtr.Zero)
					id_train_Lcom_thalmic_myo_internal_classifier_Classifier_TrainingData_ = JNIEnv.GetMethodID (class_ref, "train", "(Lcom/thalmic/myo/internal/classifier/Classifier$TrainingData;)Z");
				bool __ret = JNIEnv.CallBooleanMethod (Handle, id_train_Lcom_thalmic_myo_internal_classifier_Classifier_TrainingData_, new JValue (p0));
				return __ret;
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.thalmic.myo.internal.classifier']/class[@name='Classifier.TrainingData']"
		[global::Android.Runtime.Register ("com/thalmic/myo/internal/classifier/Classifier$TrainingData", DoNotGenerateAcw=true)]
		public partial class TrainingData : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.thalmic.myo.internal.classifier']/class[@name='Classifier.TrainingData']/field[@name='MAJOR_VERSION']"
			[Register ("MAJOR_VERSION")]
			public const int MajorVersion = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.thalmic.myo.internal.classifier']/class[@name='Classifier.TrainingData']/field[@name='MINOR_VERSION']"
			[Register ("MINOR_VERSION")]
			public const int MinorVersion = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.thalmic.myo.internal.classifier']/class[@name='Classifier.TrainingData']/field[@name='NUM_CHANNELS']"
			[Register ("NUM_CHANNELS")]
			public const int NumChannels = (int) 8;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.thalmic.myo.internal.classifier']/class[@name='Classifier.TrainingData']/field[@name='NUM_POSES']"
			[Register ("NUM_POSES")]
			public const int NumPoses = (int) 6;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.thalmic.myo.internal.classifier']/class[@name='Classifier.TrainingData']/field[@name='NUM_SAMPLES']"
			[Register ("NUM_SAMPLES")]
			public const int NumSamples = (int) 50;

			static IntPtr samples_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.thalmic.myo.internal.classifier']/class[@name='Classifier.TrainingData']/field[@name='samples']"
			[Register ("samples")]
			public IList<int[][]> Samples {
				get {
					if (samples_jfieldId == IntPtr.Zero)
						samples_jfieldId = JNIEnv.GetFieldID (class_ref, "samples", "[[[I");
					return JavaArray<int[][]>.FromJniHandle (JNIEnv.GetObjectField (Handle, samples_jfieldId), JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (samples_jfieldId == IntPtr.Zero)
						samples_jfieldId = JNIEnv.GetFieldID (class_ref, "samples", "[[[I");
					IntPtr native_value = JavaArray<int[][]>.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (Handle, samples_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/thalmic/myo/internal/classifier/Classifier$TrainingData", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (TrainingData); }
			}

			protected TrainingData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.thalmic.myo.internal.classifier']/class[@name='Classifier.TrainingData']/constructor[@name='Classifier.TrainingData' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public TrainingData () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (TrainingData)) {
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

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/thalmic/myo/internal/classifier/Classifier", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Classifier); }
		}

		protected Classifier (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.thalmic.myo.internal.classifier']/class[@name='Classifier']/constructor[@name='Classifier' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public Classifier () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Classifier)) {
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

		static Delegate cb_getArm;
#pragma warning disable 0169
		static Delegate GetGetArmHandler ()
		{
			if (cb_getArm == null)
				cb_getArm = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetArm);
			return cb_getArm;
		}

		static int n_GetArm (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Thalmic.Myo.Internal.Classifier.Classifier __this = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Internal.Classifier.Classifier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Arm;
		}
#pragma warning restore 0169

		static IntPtr id_getArm;
		public virtual int Arm {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo.internal.classifier']/class[@name='Classifier']/method[@name='getArm' and count(parameter)=0]"
			[Register ("getArm", "()I", "GetGetArmHandler")]
			get {
				if (id_getArm == IntPtr.Zero)
					id_getArm = JNIEnv.GetMethodID (class_ref, "getArm", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getArm);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getArm", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_isTrained;
#pragma warning disable 0169
		static Delegate GetIsTrainedHandler ()
		{
			if (cb_isTrained == null)
				cb_isTrained = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsTrained);
			return cb_isTrained;
		}

		static bool n_IsTrained (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Thalmic.Myo.Internal.Classifier.Classifier __this = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Internal.Classifier.Classifier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsTrained;
		}
#pragma warning restore 0169

		static IntPtr id_isTrained;
		public virtual bool IsTrained {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo.internal.classifier']/class[@name='Classifier']/method[@name='isTrained' and count(parameter)=0]"
			[Register ("isTrained", "()Z", "GetIsTrainedHandler")]
			get {
				if (id_isTrained == IntPtr.Zero)
					id_isTrained = JNIEnv.GetMethodID (class_ref, "isTrained", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isTrained);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isTrained", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getState;
#pragma warning disable 0169
		static Delegate GetGetStateHandler ()
		{
			if (cb_getState == null)
				cb_getState = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetState);
			return cb_getState;
		}

		static int n_GetState (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Thalmic.Myo.Internal.Classifier.Classifier __this = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Internal.Classifier.Classifier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.State;
		}
#pragma warning restore 0169

		static IntPtr id_getState;
		public virtual int State {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo.internal.classifier']/class[@name='Classifier']/method[@name='getState' and count(parameter)=0]"
			[Register ("getState", "()I", "GetGetStateHandler")]
			get {
				if (id_getState == IntPtr.Zero)
					id_getState = JNIEnv.GetMethodID (class_ref, "getState", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getState);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getState", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getXDirection;
#pragma warning disable 0169
		static Delegate GetGetXDirectionHandler ()
		{
			if (cb_getXDirection == null)
				cb_getXDirection = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetXDirection);
			return cb_getXDirection;
		}

		static int n_GetXDirection (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Thalmic.Myo.Internal.Classifier.Classifier __this = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Internal.Classifier.Classifier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.XDirection;
		}
#pragma warning restore 0169

		static IntPtr id_getXDirection;
		public virtual int XDirection {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo.internal.classifier']/class[@name='Classifier']/method[@name='getXDirection' and count(parameter)=0]"
			[Register ("getXDirection", "()I", "GetGetXDirectionHandler")]
			get {
				if (id_getXDirection == IntPtr.Zero)
					id_getXDirection = JNIEnv.GetMethodID (class_ref, "getXDirection", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getXDirection);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getXDirection", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_classify_arrayFS;
#pragma warning disable 0169
		static Delegate GetClassify_arrayFSHandler ()
		{
			if (cb_classify_arrayFS == null)
				cb_classify_arrayFS = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, short, int>) n_Classify_arrayFS);
			return cb_classify_arrayFS;
		}

		static int n_Classify_arrayFS (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, short p1)
		{
			global::Com.Thalmic.Myo.Internal.Classifier.Classifier __this = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Internal.Classifier.Classifier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			float[] p0 = (float[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (float));
			int __ret = __this.Classify (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_classify_arrayFS;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo.internal.classifier']/class[@name='Classifier']/method[@name='classify' and count(parameter)=2 and parameter[1][@type='float[]'] and parameter[2][@type='short']]"
		[Register ("classify", "([FS)I", "GetClassify_arrayFSHandler")]
		public virtual int Classify (float[] p0, short p1)
		{
			if (id_classify_arrayFS == IntPtr.Zero)
				id_classify_arrayFS = JNIEnv.GetMethodID (class_ref, "classify", "([FS)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod  (Handle, id_classify_arrayFS, new JValue (native_p0), new JValue (p1));
				else
					__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "classify", "([FS)I"), new JValue (native_p0), new JValue (p1));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_destroy;
#pragma warning disable 0169
		static Delegate GetDestroyHandler ()
		{
			if (cb_destroy == null)
				cb_destroy = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Destroy);
			return cb_destroy;
		}

		static void n_Destroy (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Thalmic.Myo.Internal.Classifier.Classifier __this = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Internal.Classifier.Classifier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Destroy ();
		}
#pragma warning restore 0169

		static IntPtr id_destroy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo.internal.classifier']/class[@name='Classifier']/method[@name='destroy' and count(parameter)=0]"
		[Register ("destroy", "()V", "GetDestroyHandler")]
		public virtual void Destroy ()
		{
			if (id_destroy == IntPtr.Zero)
				id_destroy = JNIEnv.GetMethodID (class_ref, "destroy", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_destroy);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "destroy", "()V"));
			} finally {
			}
		}

		static Delegate cb_pushImuData_arrayF;
#pragma warning disable 0169
		static Delegate GetPushImuData_arrayFHandler ()
		{
			if (cb_pushImuData_arrayF == null)
				cb_pushImuData_arrayF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PushImuData_arrayF);
			return cb_pushImuData_arrayF;
		}

		static void n_PushImuData_arrayF (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Thalmic.Myo.Internal.Classifier.Classifier __this = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Internal.Classifier.Classifier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			float[] p0 = (float[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (float));
			__this.PushImuData (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_pushImuData_arrayF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo.internal.classifier']/class[@name='Classifier']/method[@name='pushImuData' and count(parameter)=1 and parameter[1][@type='float[]']]"
		[Register ("pushImuData", "([F)V", "GetPushImuData_arrayFHandler")]
		public virtual void PushImuData (float[] p0)
		{
			if (id_pushImuData_arrayF == IntPtr.Zero)
				id_pushImuData_arrayF = JNIEnv.GetMethodID (class_ref, "pushImuData", "([F)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_pushImuData_arrayF, new JValue (native_p0));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "pushImuData", "([F)V"), new JValue (native_p0));
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_setHardwareRev_I;
#pragma warning disable 0169
		static Delegate GetSetHardwareRev_IHandler ()
		{
			if (cb_setHardwareRev_I == null)
				cb_setHardwareRev_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetHardwareRev_I);
			return cb_setHardwareRev_I;
		}

		static void n_SetHardwareRev_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Thalmic.Myo.Internal.Classifier.Classifier __this = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Internal.Classifier.Classifier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetHardwareRev (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setHardwareRev_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo.internal.classifier']/class[@name='Classifier']/method[@name='setHardwareRev' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setHardwareRev", "(I)V", "GetSetHardwareRev_IHandler")]
		public virtual void SetHardwareRev (int p0)
		{
			if (id_setHardwareRev_I == IntPtr.Zero)
				id_setHardwareRev_I = JNIEnv.GetMethodID (class_ref, "setHardwareRev", "(I)V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setHardwareRev_I, new JValue (p0));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHardwareRev", "(I)V"), new JValue (p0));
			} finally {
			}
		}

		static Delegate cb_train_Lcom_thalmic_myo_internal_classifier_Classifier_TrainingData_;
#pragma warning disable 0169
		static Delegate GetTrain_Lcom_thalmic_myo_internal_classifier_Classifier_TrainingData_Handler ()
		{
			if (cb_train_Lcom_thalmic_myo_internal_classifier_Classifier_TrainingData_ == null)
				cb_train_Lcom_thalmic_myo_internal_classifier_Classifier_TrainingData_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Train_Lcom_thalmic_myo_internal_classifier_Classifier_TrainingData_);
			return cb_train_Lcom_thalmic_myo_internal_classifier_Classifier_TrainingData_;
		}

		static bool n_Train_Lcom_thalmic_myo_internal_classifier_Classifier_TrainingData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Thalmic.Myo.Internal.Classifier.Classifier __this = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Internal.Classifier.Classifier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Thalmic.Myo.Internal.Classifier.Classifier.TrainingData p0 = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Internal.Classifier.Classifier.TrainingData> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Train (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_train_Lcom_thalmic_myo_internal_classifier_Classifier_TrainingData_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo.internal.classifier']/class[@name='Classifier']/method[@name='train' and count(parameter)=1 and parameter[1][@type='com.thalmic.myo.internal.classifier.Classifier.TrainingData']]"
		[Register ("train", "(Lcom/thalmic/myo/internal/classifier/Classifier$TrainingData;)Z", "GetTrain_Lcom_thalmic_myo_internal_classifier_Classifier_TrainingData_Handler")]
		public virtual bool Train (global::Com.Thalmic.Myo.Internal.Classifier.Classifier.TrainingData p0)
		{
			if (id_train_Lcom_thalmic_myo_internal_classifier_Classifier_TrainingData_ == IntPtr.Zero)
				id_train_Lcom_thalmic_myo_internal_classifier_Classifier_TrainingData_ = JNIEnv.GetMethodID (class_ref, "train", "(Lcom/thalmic/myo/internal/classifier/Classifier$TrainingData;)Z");
			try {

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_train_Lcom_thalmic_myo_internal_classifier_Classifier_TrainingData_, new JValue (p0));
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "train", "(Lcom/thalmic/myo/internal/classifier/Classifier$TrainingData;)Z"), new JValue (p0));
				return __ret;
			} finally {
			}
		}

	}
}
