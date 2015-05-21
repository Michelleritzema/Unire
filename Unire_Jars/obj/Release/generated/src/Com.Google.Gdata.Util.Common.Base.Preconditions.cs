using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Gdata.Util.Common.Base {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.gdata.util.common.base']/class[@name='Preconditions']"
	[global::Android.Runtime.Register ("com/google/gdata/util/common/base/Preconditions", DoNotGenerateAcw=true)]
	public sealed partial class Preconditions : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/gdata/util/common/base/Preconditions", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Preconditions); }
		}

		internal Preconditions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_checkArgument_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gdata.util.common.base']/class[@name='Preconditions']/method[@name='checkArgument' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("checkArgument", "(Z)V", "")]
		public static unsafe void CheckArgument (bool p0)
		{
			if (id_checkArgument_Z == IntPtr.Zero)
				id_checkArgument_Z = JNIEnv.GetStaticMethodID (class_ref, "checkArgument", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_checkArgument_Z, __args);
			} finally {
			}
		}

		static IntPtr id_checkArgument_ZLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gdata.util.common.base']/class[@name='Preconditions']/method[@name='checkArgument' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='java.lang.Object']]"
		[Register ("checkArgument", "(ZLjava/lang/Object;)V", "")]
		public static unsafe void CheckArgument (bool p0, global::Java.Lang.Object p1)
		{
			if (id_checkArgument_ZLjava_lang_Object_ == IntPtr.Zero)
				id_checkArgument_ZLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "checkArgument", "(ZLjava/lang/Object;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_checkArgument_ZLjava_lang_Object_, __args);
			} finally {
			}
		}

		static IntPtr id_checkArgument_ZLjava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gdata.util.common.base']/class[@name='Preconditions']/method[@name='checkArgument' and count(parameter)=3 and parameter[1][@type='boolean'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("checkArgument", "(ZLjava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void CheckArgument (bool p0, string p1, params global:: Java.Lang.Object[] p2)
		{
			if (id_checkArgument_ZLjava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_checkArgument_ZLjava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "checkArgument", "(ZLjava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_checkArgument_ZLjava_lang_String_arrayLjava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static IntPtr id_checkContentsNotNull_Ljava_lang_Iterable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gdata.util.common.base']/class[@name='Preconditions']/method[@name='checkContentsNotNull' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("checkContentsNotNull", "(Ljava/lang/Iterable;)Ljava/lang/Iterable;", "")]
		public static unsafe global::Java.Lang.Object CheckContentsNotNull (global::Java.Lang.Object p0)
		{
			if (id_checkContentsNotNull_Ljava_lang_Iterable_ == IntPtr.Zero)
				id_checkContentsNotNull_Ljava_lang_Iterable_ = JNIEnv.GetStaticMethodID (class_ref, "checkContentsNotNull", "(Ljava/lang/Iterable;)Ljava/lang/Iterable;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_checkContentsNotNull_Ljava_lang_Iterable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_checkContentsNotNull_Ljava_lang_Iterable_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gdata.util.common.base']/class[@name='Preconditions']/method[@name='checkContentsNotNull' and count(parameter)=2 and parameter[1][@type='T'] and parameter[2][@type='java.lang.Object']]"
		[Register ("checkContentsNotNull", "(Ljava/lang/Iterable;Ljava/lang/Object;)Ljava/lang/Iterable;", "")]
		public static unsafe global::Java.Lang.Object CheckContentsNotNull (global::Java.Lang.Object p0, global::Java.Lang.Object p1)
		{
			if (id_checkContentsNotNull_Ljava_lang_Iterable_Ljava_lang_Object_ == IntPtr.Zero)
				id_checkContentsNotNull_Ljava_lang_Iterable_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "checkContentsNotNull", "(Ljava/lang/Iterable;Ljava/lang/Object;)Ljava/lang/Iterable;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_checkContentsNotNull_Ljava_lang_Iterable_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_checkContentsNotNull_Ljava_lang_Iterable_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gdata.util.common.base']/class[@name='Preconditions']/method[@name='checkContentsNotNull' and count(parameter)=3 and parameter[1][@type='T'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("checkContentsNotNull", "(Ljava/lang/Iterable;Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/Iterable;", "")]
		public static unsafe global::Java.Lang.Object CheckContentsNotNull (global::Java.Lang.Object p0, string p1, params global:: Java.Lang.Object[] p2)
		{
			if (id_checkContentsNotNull_Ljava_lang_Iterable_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_checkContentsNotNull_Ljava_lang_Iterable_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "checkContentsNotNull", "(Ljava/lang/Iterable;Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/Iterable;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_checkContentsNotNull_Ljava_lang_Iterable_Ljava_lang_String_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static IntPtr id_checkElementIndex_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gdata.util.common.base']/class[@name='Preconditions']/method[@name='checkElementIndex' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("checkElementIndex", "(II)V", "")]
		public static unsafe void CheckElementIndex (int p0, int p1)
		{
			if (id_checkElementIndex_II == IntPtr.Zero)
				id_checkElementIndex_II = JNIEnv.GetStaticMethodID (class_ref, "checkElementIndex", "(II)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_checkElementIndex_II, __args);
			} finally {
			}
		}

		static IntPtr id_checkElementIndex_IILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gdata.util.common.base']/class[@name='Preconditions']/method[@name='checkElementIndex' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("checkElementIndex", "(IILjava/lang/String;)V", "")]
		public static unsafe void CheckElementIndex (int p0, int p1, string p2)
		{
			if (id_checkElementIndex_IILjava_lang_String_ == IntPtr.Zero)
				id_checkElementIndex_IILjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "checkElementIndex", "(IILjava/lang/String;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_checkElementIndex_IILjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_checkNotNull_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gdata.util.common.base']/class[@name='Preconditions']/method[@name='checkNotNull' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("checkNotNull", "(Ljava/lang/Object;)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object CheckNotNull (global::Java.Lang.Object p0)
		{
			if (id_checkNotNull_Ljava_lang_Object_ == IntPtr.Zero)
				id_checkNotNull_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "checkNotNull", "(Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_checkNotNull_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_checkNotNull_Ljava_lang_Object_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gdata.util.common.base']/class[@name='Preconditions']/method[@name='checkNotNull' and count(parameter)=2 and parameter[1][@type='T'] and parameter[2][@type='java.lang.Object']]"
		[Register ("checkNotNull", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object CheckNotNull (global::Java.Lang.Object p0, global::Java.Lang.Object p1)
		{
			if (id_checkNotNull_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_checkNotNull_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "checkNotNull", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_checkNotNull_Ljava_lang_Object_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_checkNotNull_Ljava_lang_Object_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gdata.util.common.base']/class[@name='Preconditions']/method[@name='checkNotNull' and count(parameter)=3 and parameter[1][@type='T'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("checkNotNull", "(Ljava/lang/Object;Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object CheckNotNull (global::Java.Lang.Object p0, string p1, params global:: Java.Lang.Object[] p2)
		{
			if (id_checkNotNull_Ljava_lang_Object_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_checkNotNull_Ljava_lang_Object_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "checkNotNull", "(Ljava/lang/Object;Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_checkNotNull_Ljava_lang_Object_Ljava_lang_String_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static IntPtr id_checkPositionIndex_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gdata.util.common.base']/class[@name='Preconditions']/method[@name='checkPositionIndex' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("checkPositionIndex", "(II)V", "")]
		public static unsafe void CheckPositionIndex (int p0, int p1)
		{
			if (id_checkPositionIndex_II == IntPtr.Zero)
				id_checkPositionIndex_II = JNIEnv.GetStaticMethodID (class_ref, "checkPositionIndex", "(II)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_checkPositionIndex_II, __args);
			} finally {
			}
		}

		static IntPtr id_checkPositionIndex_IILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gdata.util.common.base']/class[@name='Preconditions']/method[@name='checkPositionIndex' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("checkPositionIndex", "(IILjava/lang/String;)V", "")]
		public static unsafe void CheckPositionIndex (int p0, int p1, string p2)
		{
			if (id_checkPositionIndex_IILjava_lang_String_ == IntPtr.Zero)
				id_checkPositionIndex_IILjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "checkPositionIndex", "(IILjava/lang/String;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_checkPositionIndex_IILjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_checkPositionIndexes_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gdata.util.common.base']/class[@name='Preconditions']/method[@name='checkPositionIndexes' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("checkPositionIndexes", "(III)V", "")]
		public static unsafe void CheckPositionIndexes (int p0, int p1, int p2)
		{
			if (id_checkPositionIndexes_III == IntPtr.Zero)
				id_checkPositionIndexes_III = JNIEnv.GetStaticMethodID (class_ref, "checkPositionIndexes", "(III)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_checkPositionIndexes_III, __args);
			} finally {
			}
		}

		static IntPtr id_checkState_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gdata.util.common.base']/class[@name='Preconditions']/method[@name='checkState' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("checkState", "(Z)V", "")]
		public static unsafe void CheckState (bool p0)
		{
			if (id_checkState_Z == IntPtr.Zero)
				id_checkState_Z = JNIEnv.GetStaticMethodID (class_ref, "checkState", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_checkState_Z, __args);
			} finally {
			}
		}

		static IntPtr id_checkState_ZLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gdata.util.common.base']/class[@name='Preconditions']/method[@name='checkState' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='java.lang.Object']]"
		[Register ("checkState", "(ZLjava/lang/Object;)V", "")]
		public static unsafe void CheckState (bool p0, global::Java.Lang.Object p1)
		{
			if (id_checkState_ZLjava_lang_Object_ == IntPtr.Zero)
				id_checkState_ZLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "checkState", "(ZLjava/lang/Object;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_checkState_ZLjava_lang_Object_, __args);
			} finally {
			}
		}

		static IntPtr id_checkState_ZLjava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gdata.util.common.base']/class[@name='Preconditions']/method[@name='checkState' and count(parameter)=3 and parameter[1][@type='boolean'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("checkState", "(ZLjava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void CheckState (bool p0, string p1, params global:: Java.Lang.Object[] p2)
		{
			if (id_checkState_ZLjava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_checkState_ZLjava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "checkState", "(ZLjava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_checkState_ZLjava_lang_String_arrayLjava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

	}
}
