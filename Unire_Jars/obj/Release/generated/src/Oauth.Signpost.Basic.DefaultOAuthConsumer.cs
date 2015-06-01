using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Oauth.Signpost.Basic {

	// Metadata.xml XPath class reference: path="/api/package[@name='oauth.signpost.basic']/class[@name='DefaultOAuthConsumer']"
	[global::Android.Runtime.Register ("oauth/signpost/basic/DefaultOAuthConsumer", DoNotGenerateAcw=true)]
	public partial class DefaultOAuthConsumer : global::Oauth.Signpost.AbstractOAuthConsumer {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("oauth/signpost/basic/DefaultOAuthConsumer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DefaultOAuthConsumer); }
		}

		protected DefaultOAuthConsumer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='oauth.signpost.basic']/class[@name='DefaultOAuthConsumer']/constructor[@name='DefaultOAuthConsumer' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe DefaultOAuthConsumer (string p0, string p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				if (GetType () != typeof (DefaultOAuthConsumer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_wrap_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetWrap_Ljava_lang_Object_Handler ()
		{
			if (cb_wrap_Ljava_lang_Object_ == null)
				cb_wrap_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Wrap_Ljava_lang_Object_);
			return cb_wrap_Ljava_lang_Object_;
		}

		static IntPtr n_Wrap_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Oauth.Signpost.Basic.DefaultOAuthConsumer __this = global::Java.Lang.Object.GetObject<global::Oauth.Signpost.Basic.DefaultOAuthConsumer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Wrap (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_wrap_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost.basic']/class[@name='DefaultOAuthConsumer']/method[@name='wrap' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("wrap", "(Ljava/lang/Object;)Loauth/signpost/http/HttpRequest;", "GetWrap_Ljava_lang_Object_Handler")]
		protected override unsafe global::Oauth.Signpost.Http.IHttpRequest Wrap (global::Java.Lang.Object p0)
		{
			if (id_wrap_Ljava_lang_Object_ == IntPtr.Zero)
				id_wrap_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "wrap", "(Ljava/lang/Object;)Loauth/signpost/http/HttpRequest;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Oauth.Signpost.Http.IHttpRequest __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Oauth.Signpost.Http.IHttpRequest> (JNIEnv.CallObjectMethod  (Handle, id_wrap_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Oauth.Signpost.Http.IHttpRequest> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "wrap", "(Ljava/lang/Object;)Loauth/signpost/http/HttpRequest;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
