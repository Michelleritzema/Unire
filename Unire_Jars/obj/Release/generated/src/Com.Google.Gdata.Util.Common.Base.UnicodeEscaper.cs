using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Gdata.Util.Common.Base {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.gdata.util.common.base']/class[@name='UnicodeEscaper']"
	[global::Android.Runtime.Register ("com/google/gdata/util/common/base/UnicodeEscaper", DoNotGenerateAcw=true)]
	public abstract partial class UnicodeEscaper : global::Java.Lang.Object, global::Com.Google.Gdata.Util.Common.Base.IEscaper {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/gdata/util/common/base/UnicodeEscaper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UnicodeEscaper); }
		}

		protected UnicodeEscaper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.gdata.util.common.base']/class[@name='UnicodeEscaper']/constructor[@name='UnicodeEscaper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UnicodeEscaper ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (UnicodeEscaper)) {
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

		static IntPtr id_codePointAt_Ljava_lang_CharSequence_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gdata.util.common.base']/class[@name='UnicodeEscaper']/method[@name='codePointAt' and count(parameter)=3 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("codePointAt", "(Ljava/lang/CharSequence;II)I", "")]
		protected static unsafe int CodePointAt (global::Java.Lang.ICharSequence p0, int p1, int p2)
		{
			if (id_codePointAt_Ljava_lang_CharSequence_II == IntPtr.Zero)
				id_codePointAt_Ljava_lang_CharSequence_II = JNIEnv.GetStaticMethodID (class_ref, "codePointAt", "(Ljava/lang/CharSequence;II)I");
			IntPtr native_p0 = CharSequence.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_codePointAt_Ljava_lang_CharSequence_II, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		protected static int CodePointAt (string p0, int p1, int p2)
		{
			global::Java.Lang.String jls_p0 = p0 == null ? null : new global::Java.Lang.String (p0);
			int __result = CodePointAt (jls_p0, p1, p2);
			if (jls_p0 != null) jls_p0.Dispose ();
			return __result;
		}

		static Delegate cb_escape_I;
#pragma warning disable 0169
		static Delegate GetEscape_IHandler ()
		{
			if (cb_escape_I == null)
				cb_escape_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_Escape_I);
			return cb_escape_I;
		}

		static IntPtr n_Escape_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Google.Gdata.Util.Common.Base.UnicodeEscaper __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gdata.Util.Common.Base.UnicodeEscaper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.Escape (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gdata.util.common.base']/class[@name='UnicodeEscaper']/method[@name='escape' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("escape", "(I)[C", "GetEscape_IHandler")]
		protected abstract char[] Escape (int p0);

		static Delegate cb_escape_Ljava_lang_Appendable_;
#pragma warning disable 0169
		static Delegate GetEscape_Ljava_lang_Appendable_Handler ()
		{
			if (cb_escape_Ljava_lang_Appendable_ == null)
				cb_escape_Ljava_lang_Appendable_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Escape_Ljava_lang_Appendable_);
			return cb_escape_Ljava_lang_Appendable_;
		}

		static IntPtr n_Escape_Ljava_lang_Appendable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Gdata.Util.Common.Base.UnicodeEscaper __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gdata.Util.Common.Base.UnicodeEscaper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IAppendable p0 = (global::Java.Lang.IAppendable)global::Java.Lang.Object.GetObject<global::Java.Lang.IAppendable> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Escape (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_escape_Ljava_lang_Appendable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gdata.util.common.base']/class[@name='UnicodeEscaper']/method[@name='escape' and count(parameter)=1 and parameter[1][@type='java.lang.Appendable']]"
		[Register ("escape", "(Ljava/lang/Appendable;)Ljava/lang/Appendable;", "GetEscape_Ljava_lang_Appendable_Handler")]
		public virtual unsafe global::Java.Lang.IAppendable Escape (global::Java.Lang.IAppendable p0)
		{
			if (id_escape_Ljava_lang_Appendable_ == IntPtr.Zero)
				id_escape_Ljava_lang_Appendable_ = JNIEnv.GetMethodID (class_ref, "escape", "(Ljava/lang/Appendable;)Ljava/lang/Appendable;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Java.Lang.IAppendable __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.IAppendable> (JNIEnv.CallObjectMethod  (Handle, id_escape_Ljava_lang_Appendable_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.IAppendable> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "escape", "(Ljava/lang/Appendable;)Ljava/lang/Appendable;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_escape_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetEscape_Ljava_lang_String_Handler ()
		{
			if (cb_escape_Ljava_lang_String_ == null)
				cb_escape_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Escape_Ljava_lang_String_);
			return cb_escape_Ljava_lang_String_;
		}

		static IntPtr n_Escape_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Gdata.Util.Common.Base.UnicodeEscaper __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gdata.Util.Common.Base.UnicodeEscaper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Escape (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_escape_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gdata.util.common.base']/class[@name='UnicodeEscaper']/method[@name='escape' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("escape", "(Ljava/lang/String;)Ljava/lang/String;", "GetEscape_Ljava_lang_String_Handler")]
		public virtual unsafe string Escape (string p0)
		{
			if (id_escape_Ljava_lang_String_ == IntPtr.Zero)
				id_escape_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "escape", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_escape_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "escape", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_escapeSlow_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gdata.util.common.base']/class[@name='UnicodeEscaper']/method[@name='escapeSlow' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("escapeSlow", "(Ljava/lang/String;I)Ljava/lang/String;", "")]
		protected unsafe string EscapeSlow (string p0, int p1)
		{
			if (id_escapeSlow_Ljava_lang_String_I == IntPtr.Zero)
				id_escapeSlow_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "escapeSlow", "(Ljava/lang/String;I)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_escapeSlow_Ljava_lang_String_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_nextEscapeIndex_Ljava_lang_CharSequence_II;
#pragma warning disable 0169
		static Delegate GetNextEscapeIndex_Ljava_lang_CharSequence_IIHandler ()
		{
			if (cb_nextEscapeIndex_Ljava_lang_CharSequence_II == null)
				cb_nextEscapeIndex_Ljava_lang_CharSequence_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, int>) n_NextEscapeIndex_Ljava_lang_CharSequence_II);
			return cb_nextEscapeIndex_Ljava_lang_CharSequence_II;
		}

		static int n_NextEscapeIndex_Ljava_lang_CharSequence_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Com.Google.Gdata.Util.Common.Base.UnicodeEscaper __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gdata.Util.Common.Base.UnicodeEscaper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.ICharSequence p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.NextEscapeIndex (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_nextEscapeIndex_Ljava_lang_CharSequence_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gdata.util.common.base']/class[@name='UnicodeEscaper']/method[@name='nextEscapeIndex' and count(parameter)=3 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("nextEscapeIndex", "(Ljava/lang/CharSequence;II)I", "GetNextEscapeIndex_Ljava_lang_CharSequence_IIHandler")]
		protected virtual unsafe int NextEscapeIndex (global::Java.Lang.ICharSequence p0, int p1, int p2)
		{
			if (id_nextEscapeIndex_Ljava_lang_CharSequence_II == IntPtr.Zero)
				id_nextEscapeIndex_Ljava_lang_CharSequence_II = JNIEnv.GetMethodID (class_ref, "nextEscapeIndex", "(Ljava/lang/CharSequence;II)I");
			IntPtr native_p0 = CharSequence.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod  (Handle, id_nextEscapeIndex_Ljava_lang_CharSequence_II, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "nextEscapeIndex", "(Ljava/lang/CharSequence;II)I"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		protected int NextEscapeIndex (string p0, int p1, int p2)
		{
			global::Java.Lang.String jls_p0 = p0 == null ? null : new global::Java.Lang.String (p0);
			int __result = NextEscapeIndex (jls_p0, p1, p2);
			if (jls_p0 != null) jls_p0.Dispose ();
			return __result;
		}

	}

	[global::Android.Runtime.Register ("com/google/gdata/util/common/base/UnicodeEscaper", DoNotGenerateAcw=true)]
	internal partial class UnicodeEscaperInvoker : UnicodeEscaper {

		public UnicodeEscaperInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (UnicodeEscaperInvoker); }
		}

		static IntPtr id_escape_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gdata.util.common.base']/class[@name='UnicodeEscaper']/method[@name='escape' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("escape", "(I)[C", "GetEscape_IHandler")]
		protected override unsafe char[] Escape (int p0)
		{
			if (id_escape_I == IntPtr.Zero)
				id_escape_I = JNIEnv.GetMethodID (class_ref, "escape", "(I)[C");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return (char[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_escape_I, __args), JniHandleOwnership.TransferLocalRef, typeof (char));
			} finally {
			}
		}

	}

}
