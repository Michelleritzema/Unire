using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Oauth.Signpost.Signature {

	// Metadata.xml XPath class reference: path="/api/package[@name='oauth.signpost.signature']/class[@name='SignatureBaseString']"
	[global::Android.Runtime.Register ("oauth/signpost/signature/SignatureBaseString", DoNotGenerateAcw=true)]
	public partial class SignatureBaseString : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("oauth/signpost/signature/SignatureBaseString", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SignatureBaseString); }
		}

		protected SignatureBaseString (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Loauth_signpost_http_HttpRequest_Loauth_signpost_http_HttpParameters_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='oauth.signpost.signature']/class[@name='SignatureBaseString']/constructor[@name='SignatureBaseString' and count(parameter)=2 and parameter[1][@type='oauth.signpost.http.HttpRequest'] and parameter[2][@type='oauth.signpost.http.HttpParameters']]"
		[Register (".ctor", "(Loauth/signpost/http/HttpRequest;Loauth/signpost/http/HttpParameters;)V", "")]
		public unsafe SignatureBaseString (global::Oauth.Signpost.Http.IHttpRequest p0, global::Oauth.Signpost.Http.HttpParameters p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (SignatureBaseString)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Loauth/signpost/http/HttpRequest;Loauth/signpost/http/HttpParameters;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Loauth/signpost/http/HttpRequest;Loauth/signpost/http/HttpParameters;)V", __args);
					return;
				}

				if (id_ctor_Loauth_signpost_http_HttpRequest_Loauth_signpost_http_HttpParameters_ == IntPtr.Zero)
					id_ctor_Loauth_signpost_http_HttpRequest_Loauth_signpost_http_HttpParameters_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Loauth/signpost/http/HttpRequest;Loauth/signpost/http/HttpParameters;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Loauth_signpost_http_HttpRequest_Loauth_signpost_http_HttpParameters_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Loauth_signpost_http_HttpRequest_Loauth_signpost_http_HttpParameters_, __args);
			} finally {
			}
		}

		static Delegate cb_generate;
#pragma warning disable 0169
		static Delegate GetGenerateHandler ()
		{
			if (cb_generate == null)
				cb_generate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Generate);
			return cb_generate;
		}

		static IntPtr n_Generate (IntPtr jnienv, IntPtr native__this)
		{
			global::Oauth.Signpost.Signature.SignatureBaseString __this = global::Java.Lang.Object.GetObject<global::Oauth.Signpost.Signature.SignatureBaseString> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Generate ());
		}
#pragma warning restore 0169

		static IntPtr id_generate;
		// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost.signature']/class[@name='SignatureBaseString']/method[@name='generate' and count(parameter)=0]"
		[Register ("generate", "()Ljava/lang/String;", "GetGenerateHandler")]
		public virtual unsafe string Generate ()
		{
			if (id_generate == IntPtr.Zero)
				id_generate = JNIEnv.GetMethodID (class_ref, "generate", "()Ljava/lang/String;");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_generate), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "generate", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_normalizeRequestParameters;
#pragma warning disable 0169
		static Delegate GetNormalizeRequestParametersHandler ()
		{
			if (cb_normalizeRequestParameters == null)
				cb_normalizeRequestParameters = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_NormalizeRequestParameters);
			return cb_normalizeRequestParameters;
		}

		static IntPtr n_NormalizeRequestParameters (IntPtr jnienv, IntPtr native__this)
		{
			global::Oauth.Signpost.Signature.SignatureBaseString __this = global::Java.Lang.Object.GetObject<global::Oauth.Signpost.Signature.SignatureBaseString> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.NormalizeRequestParameters ());
		}
#pragma warning restore 0169

		static IntPtr id_normalizeRequestParameters;
		// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost.signature']/class[@name='SignatureBaseString']/method[@name='normalizeRequestParameters' and count(parameter)=0]"
		[Register ("normalizeRequestParameters", "()Ljava/lang/String;", "GetNormalizeRequestParametersHandler")]
		public virtual unsafe string NormalizeRequestParameters ()
		{
			if (id_normalizeRequestParameters == IntPtr.Zero)
				id_normalizeRequestParameters = JNIEnv.GetMethodID (class_ref, "normalizeRequestParameters", "()Ljava/lang/String;");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_normalizeRequestParameters), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "normalizeRequestParameters", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_normalizeRequestUrl;
#pragma warning disable 0169
		static Delegate GetNormalizeRequestUrlHandler ()
		{
			if (cb_normalizeRequestUrl == null)
				cb_normalizeRequestUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_NormalizeRequestUrl);
			return cb_normalizeRequestUrl;
		}

		static IntPtr n_NormalizeRequestUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Oauth.Signpost.Signature.SignatureBaseString __this = global::Java.Lang.Object.GetObject<global::Oauth.Signpost.Signature.SignatureBaseString> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.NormalizeRequestUrl ());
		}
#pragma warning restore 0169

		static IntPtr id_normalizeRequestUrl;
		// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost.signature']/class[@name='SignatureBaseString']/method[@name='normalizeRequestUrl' and count(parameter)=0]"
		[Register ("normalizeRequestUrl", "()Ljava/lang/String;", "GetNormalizeRequestUrlHandler")]
		public virtual unsafe string NormalizeRequestUrl ()
		{
			if (id_normalizeRequestUrl == IntPtr.Zero)
				id_normalizeRequestUrl = JNIEnv.GetMethodID (class_ref, "normalizeRequestUrl", "()Ljava/lang/String;");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_normalizeRequestUrl), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "normalizeRequestUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
