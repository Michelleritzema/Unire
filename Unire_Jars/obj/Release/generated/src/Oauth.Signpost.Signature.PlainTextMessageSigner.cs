using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Oauth.Signpost.Signature {

	// Metadata.xml XPath class reference: path="/api/package[@name='oauth.signpost.signature']/class[@name='PlainTextMessageSigner']"
	[global::Android.Runtime.Register ("oauth/signpost/signature/PlainTextMessageSigner", DoNotGenerateAcw=true)]
	public partial class PlainTextMessageSigner : global::Oauth.Signpost.Signature.OAuthMessageSigner {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("oauth/signpost/signature/PlainTextMessageSigner", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PlainTextMessageSigner); }
		}

		protected PlainTextMessageSigner (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='oauth.signpost.signature']/class[@name='PlainTextMessageSigner']/constructor[@name='PlainTextMessageSigner' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PlainTextMessageSigner ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (PlainTextMessageSigner)) {
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

		static Delegate cb_getSignatureMethod;
#pragma warning disable 0169
		static Delegate GetGetSignatureMethodHandler ()
		{
			if (cb_getSignatureMethod == null)
				cb_getSignatureMethod = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSignatureMethod);
			return cb_getSignatureMethod;
		}

		static IntPtr n_GetSignatureMethod (IntPtr jnienv, IntPtr native__this)
		{
			global::Oauth.Signpost.Signature.PlainTextMessageSigner __this = global::Java.Lang.Object.GetObject<global::Oauth.Signpost.Signature.PlainTextMessageSigner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SignatureMethod);
		}
#pragma warning restore 0169

		static IntPtr id_getSignatureMethod;
		public override unsafe string SignatureMethod {
			// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost.signature']/class[@name='PlainTextMessageSigner']/method[@name='getSignatureMethod' and count(parameter)=0]"
			[Register ("getSignatureMethod", "()Ljava/lang/String;", "GetGetSignatureMethodHandler")]
			get {
				if (id_getSignatureMethod == IntPtr.Zero)
					id_getSignatureMethod = JNIEnv.GetMethodID (class_ref, "getSignatureMethod", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getSignatureMethod), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSignatureMethod", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_sign_Loauth_signpost_http_HttpRequest_Loauth_signpost_http_HttpParameters_;
#pragma warning disable 0169
		static Delegate GetSign_Loauth_signpost_http_HttpRequest_Loauth_signpost_http_HttpParameters_Handler ()
		{
			if (cb_sign_Loauth_signpost_http_HttpRequest_Loauth_signpost_http_HttpParameters_ == null)
				cb_sign_Loauth_signpost_http_HttpRequest_Loauth_signpost_http_HttpParameters_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Sign_Loauth_signpost_http_HttpRequest_Loauth_signpost_http_HttpParameters_);
			return cb_sign_Loauth_signpost_http_HttpRequest_Loauth_signpost_http_HttpParameters_;
		}

		static IntPtr n_Sign_Loauth_signpost_http_HttpRequest_Loauth_signpost_http_HttpParameters_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Oauth.Signpost.Signature.PlainTextMessageSigner __this = global::Java.Lang.Object.GetObject<global::Oauth.Signpost.Signature.PlainTextMessageSigner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Oauth.Signpost.Http.IHttpRequest p0 = (global::Oauth.Signpost.Http.IHttpRequest)global::Java.Lang.Object.GetObject<global::Oauth.Signpost.Http.IHttpRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Oauth.Signpost.Http.HttpParameters p1 = global::Java.Lang.Object.GetObject<global::Oauth.Signpost.Http.HttpParameters> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Sign (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_sign_Loauth_signpost_http_HttpRequest_Loauth_signpost_http_HttpParameters_;
		// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost.signature']/class[@name='PlainTextMessageSigner']/method[@name='sign' and count(parameter)=2 and parameter[1][@type='oauth.signpost.http.HttpRequest'] and parameter[2][@type='oauth.signpost.http.HttpParameters']]"
		[Register ("sign", "(Loauth/signpost/http/HttpRequest;Loauth/signpost/http/HttpParameters;)Ljava/lang/String;", "GetSign_Loauth_signpost_http_HttpRequest_Loauth_signpost_http_HttpParameters_Handler")]
		public override unsafe string Sign (global::Oauth.Signpost.Http.IHttpRequest p0, global::Oauth.Signpost.Http.HttpParameters p1)
		{
			if (id_sign_Loauth_signpost_http_HttpRequest_Loauth_signpost_http_HttpParameters_ == IntPtr.Zero)
				id_sign_Loauth_signpost_http_HttpRequest_Loauth_signpost_http_HttpParameters_ = JNIEnv.GetMethodID (class_ref, "sign", "(Loauth/signpost/http/HttpRequest;Loauth/signpost/http/HttpParameters;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_sign_Loauth_signpost_http_HttpRequest_Loauth_signpost_http_HttpParameters_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sign", "(Loauth/signpost/http/HttpRequest;Loauth/signpost/http/HttpParameters;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
