using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Thalmic.Myo.Internal.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.thalmic.myo.internal.util']/class[@name='FileUtil']"
	[global::Android.Runtime.Register ("com/thalmic/myo/internal/util/FileUtil", DoNotGenerateAcw=true)]
	public partial class FileUtil : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/thalmic/myo/internal/util/FileUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FileUtil); }
		}

		protected FileUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_readFileLineAsString_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo.internal.util']/class[@name='FileUtil']/method[@name='readFileLineAsString' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("readFileLineAsString", "(Ljava/io/File;)Ljava/lang/String;", "")]
		public static string ReadFileLineAsString (global::Java.IO.File p0)
		{
			if (id_readFileLineAsString_Ljava_io_File_ == IntPtr.Zero)
				id_readFileLineAsString_Ljava_io_File_ = JNIEnv.GetStaticMethodID (class_ref, "readFileLineAsString", "(Ljava/io/File;)Ljava/lang/String;");
			try {
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_readFileLineAsString_Ljava_io_File_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_readStringFromFile_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo.internal.util']/class[@name='FileUtil']/method[@name='readStringFromFile' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("readStringFromFile", "(Ljava/io/File;)Ljava/lang/String;", "")]
		public static string ReadStringFromFile (global::Java.IO.File p0)
		{
			if (id_readStringFromFile_Ljava_io_File_ == IntPtr.Zero)
				id_readStringFromFile_Ljava_io_File_ = JNIEnv.GetStaticMethodID (class_ref, "readStringFromFile", "(Ljava/io/File;)Ljava/lang/String;");
			try {
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_readStringFromFile_Ljava_io_File_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_writeStringToFile_Ljava_io_File_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.thalmic.myo.internal.util']/class[@name='FileUtil']/method[@name='writeStringToFile' and count(parameter)=2 and parameter[1][@type='java.io.File'] and parameter[2][@type='java.lang.String']]"
		[Register ("writeStringToFile", "(Ljava/io/File;Ljava/lang/String;)V", "")]
		public static void WriteStringToFile (global::Java.IO.File p0, string p1)
		{
			if (id_writeStringToFile_Ljava_io_File_Ljava_lang_String_ == IntPtr.Zero)
				id_writeStringToFile_Ljava_io_File_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "writeStringToFile", "(Ljava/io/File;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_writeStringToFile_Ljava_io_File_Ljava_lang_String_, new JValue (p0), new JValue (native_p1));
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
