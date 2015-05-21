using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Gdata.Util.Common.Base {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.gdata.util.common.base']/interface[@name='Escaper']"
	[Register ("com/google/gdata/util/common/base/Escaper", "", "Com.Google.Gdata.Util.Common.Base.IEscaperInvoker")]
	public partial interface IEscaper : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gdata.util.common.base']/interface[@name='Escaper']/method[@name='escape' and count(parameter)=1 and parameter[1][@type='java.lang.Appendable']]"
		[Register ("escape", "(Ljava/lang/Appendable;)Ljava/lang/Appendable;", "GetEscape_Ljava_lang_Appendable_Handler:Com.Google.Gdata.Util.Common.Base.IEscaperInvoker, Unire_Jars")]
		global::Java.Lang.IAppendable Escape (global::Java.Lang.IAppendable p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gdata.util.common.base']/interface[@name='Escaper']/method[@name='escape' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("escape", "(Ljava/lang/String;)Ljava/lang/String;", "GetEscape_Ljava_lang_String_Handler:Com.Google.Gdata.Util.Common.Base.IEscaperInvoker, Unire_Jars")]
		string Escape (string p0);

	}

	[global::Android.Runtime.Register ("com/google/gdata/util/common/base/Escaper", DoNotGenerateAcw=true)]
	internal class IEscaperInvoker : global::Java.Lang.Object, IEscaper {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/gdata/util/common/base/Escaper");
		IntPtr class_ref;

		public static IEscaper GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IEscaper> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.gdata.util.common.base.Escaper"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IEscaperInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IEscaperInvoker); }
		}

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
			global::Com.Google.Gdata.Util.Common.Base.IEscaper __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gdata.Util.Common.Base.IEscaper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IAppendable p0 = (global::Java.Lang.IAppendable)global::Java.Lang.Object.GetObject<global::Java.Lang.IAppendable> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Escape (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_escape_Ljava_lang_Appendable_;
		public unsafe global::Java.Lang.IAppendable Escape (global::Java.Lang.IAppendable p0)
		{
			if (id_escape_Ljava_lang_Appendable_ == IntPtr.Zero)
				id_escape_Ljava_lang_Appendable_ = JNIEnv.GetMethodID (class_ref, "escape", "(Ljava/lang/Appendable;)Ljava/lang/Appendable;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			global::Java.Lang.IAppendable __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.IAppendable> (JNIEnv.CallObjectMethod (Handle, id_escape_Ljava_lang_Appendable_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
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
			global::Com.Google.Gdata.Util.Common.Base.IEscaper __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gdata.Util.Common.Base.IEscaper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Escape (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_escape_Ljava_lang_String_;
		public unsafe string Escape (string p0)
		{
			if (id_escape_Ljava_lang_String_ == IntPtr.Zero)
				id_escape_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "escape", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_escape_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}

}
