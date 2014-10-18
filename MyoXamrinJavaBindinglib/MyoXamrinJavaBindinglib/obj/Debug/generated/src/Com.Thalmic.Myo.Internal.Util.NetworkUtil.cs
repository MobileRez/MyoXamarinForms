using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Thalmic.Myo.Internal.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.thalmic.myo.internal.util']/class[@name='NetworkUtil']"
	[global::Android.Runtime.Register ("com/thalmic/myo/internal/util/NetworkUtil", DoNotGenerateAcw=true)]
	public partial class NetworkUtil : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/thalmic/myo/internal/util/NetworkUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NetworkUtil); }
		}

		protected NetworkUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.thalmic.myo.internal.util']/class[@name='NetworkUtil']/constructor[@name='NetworkUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public NetworkUtil () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (NetworkUtil)) {
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

		static Delegate cb_postJsonToUrl_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPostJsonToUrl_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_postJsonToUrl_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_postJsonToUrl_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_PostJsonToUrl_Ljava_lang_String_Ljava_lang_String_);
			return cb_postJsonToUrl_Ljava_lang_String_Ljava_lang_String_;
		}

		static int n_PostJsonToUrl_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Thalmic.Myo.Internal.Util.NetworkUtil __this = global::Java.Lang.Object.GetObject<global::Com.Thalmic.Myo.Internal.Util.NetworkUtil> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.PostJsonToUrl (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_postJsonToUrl_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo.internal.util']/class[@name='NetworkUtil']/method[@name='postJsonToUrl' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("postJsonToUrl", "(Ljava/lang/String;Ljava/lang/String;)I", "GetPostJsonToUrl_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual int PostJsonToUrl (string p0, string p1)
		{
			if (id_postJsonToUrl_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_postJsonToUrl_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "postJsonToUrl", "(Ljava/lang/String;Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod  (Handle, id_postJsonToUrl_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
				else
					__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "postJsonToUrl", "(Ljava/lang/String;Ljava/lang/String;)I"), new JValue (native_p0), new JValue (native_p1));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
