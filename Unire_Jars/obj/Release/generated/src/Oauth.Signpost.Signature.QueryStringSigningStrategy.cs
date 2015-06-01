using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Oauth.Signpost.Signature {

	// Metadata.xml XPath class reference: path="/api/package[@name='oauth.signpost.signature']/class[@name='QueryStringSigningStrategy']"
	[global::Android.Runtime.Register ("oauth/signpost/signature/QueryStringSigningStrategy", DoNotGenerateAcw=true)]
	public partial class QueryStringSigningStrategy : global::Java.Lang.Object, global::Oauth.Signpost.Signature.ISigningStrategy {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("oauth/signpost/signature/QueryStringSigningStrategy", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (QueryStringSigningStrategy); }
		}

		protected QueryStringSigningStrategy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='oauth.signpost.signature']/class[@name='QueryStringSigningStrategy']/constructor[@name='QueryStringSigningStrategy' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe QueryStringSigningStrategy ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (QueryStringSigningStrategy)) {
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

		static Delegate cb_writeSignature_Ljava_lang_String_Loauth_signpost_http_HttpRequest_Loauth_signpost_http_HttpParameters_;
#pragma warning disable 0169
		static Delegate GetWriteSignature_Ljava_lang_String_Loauth_signpost_http_HttpRequest_Loauth_signpost_http_HttpParameters_Handler ()
		{
			if (cb_writeSignature_Ljava_lang_String_Loauth_signpost_http_HttpRequest_Loauth_signpost_http_HttpParameters_ == null)
				cb_writeSignature_Ljava_lang_String_Loauth_signpost_http_HttpRequest_Loauth_signpost_http_HttpParameters_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_WriteSignature_Ljava_lang_String_Loauth_signpost_http_HttpRequest_Loauth_signpost_http_HttpParameters_);
			return cb_writeSignature_Ljava_lang_String_Loauth_signpost_http_HttpRequest_Loauth_signpost_http_HttpParameters_;
		}

		static IntPtr n_WriteSignature_Ljava_lang_String_Loauth_signpost_http_HttpRequest_Loauth_signpost_http_HttpParameters_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Oauth.Signpost.Signature.QueryStringSigningStrategy __this = global::Java.Lang.Object.GetObject<global::Oauth.Signpost.Signature.QueryStringSigningStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Oauth.Signpost.Http.IHttpRequest p1 = (global::Oauth.Signpost.Http.IHttpRequest)global::Java.Lang.Object.GetObject<global::Oauth.Signpost.Http.IHttpRequest> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Oauth.Signpost.Http.HttpParameters p2 = global::Java.Lang.Object.GetObject<global::Oauth.Signpost.Http.HttpParameters> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.WriteSignature (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_writeSignature_Ljava_lang_String_Loauth_signpost_http_HttpRequest_Loauth_signpost_http_HttpParameters_;
		// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost.signature']/class[@name='QueryStringSigningStrategy']/method[@name='writeSignature' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='oauth.signpost.http.HttpRequest'] and parameter[3][@type='oauth.signpost.http.HttpParameters']]"
		[Register ("writeSignature", "(Ljava/lang/String;Loauth/signpost/http/HttpRequest;Loauth/signpost/http/HttpParameters;)Ljava/lang/String;", "GetWriteSignature_Ljava_lang_String_Loauth_signpost_http_HttpRequest_Loauth_signpost_http_HttpParameters_Handler")]
		public virtual unsafe string WriteSignature (string p0, global::Oauth.Signpost.Http.IHttpRequest p1, global::Oauth.Signpost.Http.HttpParameters p2)
		{
			if (id_writeSignature_Ljava_lang_String_Loauth_signpost_http_HttpRequest_Loauth_signpost_http_HttpParameters_ == IntPtr.Zero)
				id_writeSignature_Ljava_lang_String_Loauth_signpost_http_HttpRequest_Loauth_signpost_http_HttpParameters_ = JNIEnv.GetMethodID (class_ref, "writeSignature", "(Ljava/lang/String;Loauth/signpost/http/HttpRequest;Loauth/signpost/http/HttpParameters;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_writeSignature_Ljava_lang_String_Loauth_signpost_http_HttpRequest_Loauth_signpost_http_HttpParameters_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeSignature", "(Ljava/lang/String;Loauth/signpost/http/HttpRequest;Loauth/signpost/http/HttpParameters;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
