using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Oauth.Signpost.Signature {

	// Metadata.xml XPath class reference: path="/api/package[@name='oauth.signpost.signature']/class[@name='OAuthMessageSigner']"
	[global::Android.Runtime.Register ("oauth/signpost/signature/OAuthMessageSigner", DoNotGenerateAcw=true)]
	public abstract partial class OAuthMessageSigner : global::Java.Lang.Object, global::Java.IO.ISerializable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("oauth/signpost/signature/OAuthMessageSigner", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OAuthMessageSigner); }
		}

		protected OAuthMessageSigner (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='oauth.signpost.signature']/class[@name='OAuthMessageSigner']/constructor[@name='OAuthMessageSigner' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe OAuthMessageSigner ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (OAuthMessageSigner)) {
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

		static Delegate cb_getConsumerSecret;
#pragma warning disable 0169
		static Delegate GetGetConsumerSecretHandler ()
		{
			if (cb_getConsumerSecret == null)
				cb_getConsumerSecret = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetConsumerSecret);
			return cb_getConsumerSecret;
		}

		static IntPtr n_GetConsumerSecret (IntPtr jnienv, IntPtr native__this)
		{
			global::Oauth.Signpost.Signature.OAuthMessageSigner __this = global::Java.Lang.Object.GetObject<global::Oauth.Signpost.Signature.OAuthMessageSigner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ConsumerSecret);
		}
#pragma warning restore 0169

		static Delegate cb_setConsumerSecret_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetConsumerSecret_Ljava_lang_String_Handler ()
		{
			if (cb_setConsumerSecret_Ljava_lang_String_ == null)
				cb_setConsumerSecret_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetConsumerSecret_Ljava_lang_String_);
			return cb_setConsumerSecret_Ljava_lang_String_;
		}

		static void n_SetConsumerSecret_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Oauth.Signpost.Signature.OAuthMessageSigner __this = global::Java.Lang.Object.GetObject<global::Oauth.Signpost.Signature.OAuthMessageSigner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ConsumerSecret = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getConsumerSecret;
		static IntPtr id_setConsumerSecret_Ljava_lang_String_;
		public virtual unsafe string ConsumerSecret {
			// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost.signature']/class[@name='OAuthMessageSigner']/method[@name='getConsumerSecret' and count(parameter)=0]"
			[Register ("getConsumerSecret", "()Ljava/lang/String;", "GetGetConsumerSecretHandler")]
			get {
				if (id_getConsumerSecret == IntPtr.Zero)
					id_getConsumerSecret = JNIEnv.GetMethodID (class_ref, "getConsumerSecret", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getConsumerSecret), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConsumerSecret", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost.signature']/class[@name='OAuthMessageSigner']/method[@name='setConsumerSecret' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setConsumerSecret", "(Ljava/lang/String;)V", "GetSetConsumerSecret_Ljava_lang_String_Handler")]
			set {
				if (id_setConsumerSecret_Ljava_lang_String_ == IntPtr.Zero)
					id_setConsumerSecret_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setConsumerSecret", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setConsumerSecret_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setConsumerSecret", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
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
			global::Oauth.Signpost.Signature.OAuthMessageSigner __this = global::Java.Lang.Object.GetObject<global::Oauth.Signpost.Signature.OAuthMessageSigner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SignatureMethod);
		}
#pragma warning restore 0169

		public abstract string SignatureMethod {
			// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost.signature']/class[@name='OAuthMessageSigner']/method[@name='getSignatureMethod' and count(parameter)=0]"
			[Register ("getSignatureMethod", "()Ljava/lang/String;", "GetGetSignatureMethodHandler")] get;
		}

		static Delegate cb_getTokenSecret;
#pragma warning disable 0169
		static Delegate GetGetTokenSecretHandler ()
		{
			if (cb_getTokenSecret == null)
				cb_getTokenSecret = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTokenSecret);
			return cb_getTokenSecret;
		}

		static IntPtr n_GetTokenSecret (IntPtr jnienv, IntPtr native__this)
		{
			global::Oauth.Signpost.Signature.OAuthMessageSigner __this = global::Java.Lang.Object.GetObject<global::Oauth.Signpost.Signature.OAuthMessageSigner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TokenSecret);
		}
#pragma warning restore 0169

		static Delegate cb_setTokenSecret_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTokenSecret_Ljava_lang_String_Handler ()
		{
			if (cb_setTokenSecret_Ljava_lang_String_ == null)
				cb_setTokenSecret_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTokenSecret_Ljava_lang_String_);
			return cb_setTokenSecret_Ljava_lang_String_;
		}

		static void n_SetTokenSecret_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Oauth.Signpost.Signature.OAuthMessageSigner __this = global::Java.Lang.Object.GetObject<global::Oauth.Signpost.Signature.OAuthMessageSigner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TokenSecret = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTokenSecret;
		static IntPtr id_setTokenSecret_Ljava_lang_String_;
		public virtual unsafe string TokenSecret {
			// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost.signature']/class[@name='OAuthMessageSigner']/method[@name='getTokenSecret' and count(parameter)=0]"
			[Register ("getTokenSecret", "()Ljava/lang/String;", "GetGetTokenSecretHandler")]
			get {
				if (id_getTokenSecret == IntPtr.Zero)
					id_getTokenSecret = JNIEnv.GetMethodID (class_ref, "getTokenSecret", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getTokenSecret), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTokenSecret", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost.signature']/class[@name='OAuthMessageSigner']/method[@name='setTokenSecret' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTokenSecret", "(Ljava/lang/String;)V", "GetSetTokenSecret_Ljava_lang_String_Handler")]
			set {
				if (id_setTokenSecret_Ljava_lang_String_ == IntPtr.Zero)
					id_setTokenSecret_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTokenSecret", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setTokenSecret_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTokenSecret", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_base64Encode_arrayB;
#pragma warning disable 0169
		static Delegate GetBase64Encode_arrayBHandler ()
		{
			if (cb_base64Encode_arrayB == null)
				cb_base64Encode_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Base64Encode_arrayB);
			return cb_base64Encode_arrayB;
		}

		static IntPtr n_Base64Encode_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Oauth.Signpost.Signature.OAuthMessageSigner __this = global::Java.Lang.Object.GetObject<global::Oauth.Signpost.Signature.OAuthMessageSigner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewString (__this.Base64Encode (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_base64Encode_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost.signature']/class[@name='OAuthMessageSigner']/method[@name='base64Encode' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("base64Encode", "([B)Ljava/lang/String;", "GetBase64Encode_arrayBHandler")]
		protected virtual unsafe string Base64Encode (byte[] p0)
		{
			if (id_base64Encode_arrayB == IntPtr.Zero)
				id_base64Encode_arrayB = JNIEnv.GetMethodID (class_ref, "base64Encode", "([B)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_base64Encode_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "base64Encode", "([B)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_decodeBase64_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDecodeBase64_Ljava_lang_String_Handler ()
		{
			if (cb_decodeBase64_Ljava_lang_String_ == null)
				cb_decodeBase64_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_DecodeBase64_Ljava_lang_String_);
			return cb_decodeBase64_Ljava_lang_String_;
		}

		static IntPtr n_DecodeBase64_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Oauth.Signpost.Signature.OAuthMessageSigner __this = global::Java.Lang.Object.GetObject<global::Oauth.Signpost.Signature.OAuthMessageSigner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.DecodeBase64 (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_decodeBase64_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost.signature']/class[@name='OAuthMessageSigner']/method[@name='decodeBase64' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("decodeBase64", "(Ljava/lang/String;)[B", "GetDecodeBase64_Ljava_lang_String_Handler")]
		protected virtual unsafe byte[] DecodeBase64 (string p0)
		{
			if (id_decodeBase64_Ljava_lang_String_ == IntPtr.Zero)
				id_decodeBase64_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "decodeBase64", "(Ljava/lang/String;)[B");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				byte[] __ret;
				if (GetType () == ThresholdType)
					__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_decodeBase64_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decodeBase64", "(Ljava/lang/String;)[B"), __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
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
			global::Oauth.Signpost.Signature.OAuthMessageSigner __this = global::Java.Lang.Object.GetObject<global::Oauth.Signpost.Signature.OAuthMessageSigner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Oauth.Signpost.Http.IHttpRequest p0 = (global::Oauth.Signpost.Http.IHttpRequest)global::Java.Lang.Object.GetObject<global::Oauth.Signpost.Http.IHttpRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Oauth.Signpost.Http.HttpParameters p1 = global::Java.Lang.Object.GetObject<global::Oauth.Signpost.Http.HttpParameters> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Sign (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost.signature']/class[@name='OAuthMessageSigner']/method[@name='sign' and count(parameter)=2 and parameter[1][@type='oauth.signpost.http.HttpRequest'] and parameter[2][@type='oauth.signpost.http.HttpParameters']]"
		[Register ("sign", "(Loauth/signpost/http/HttpRequest;Loauth/signpost/http/HttpParameters;)Ljava/lang/String;", "GetSign_Loauth_signpost_http_HttpRequest_Loauth_signpost_http_HttpParameters_Handler")]
		public abstract string Sign (global::Oauth.Signpost.Http.IHttpRequest p0, global::Oauth.Signpost.Http.HttpParameters p1);

	}

	[global::Android.Runtime.Register ("oauth/signpost/signature/OAuthMessageSigner", DoNotGenerateAcw=true)]
	internal partial class OAuthMessageSignerInvoker : OAuthMessageSigner {

		public OAuthMessageSignerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (OAuthMessageSignerInvoker); }
		}

		static IntPtr id_getSignatureMethod;
		public override unsafe string SignatureMethod {
			// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost.signature']/class[@name='OAuthMessageSigner']/method[@name='getSignatureMethod' and count(parameter)=0]"
			[Register ("getSignatureMethod", "()Ljava/lang/String;", "GetGetSignatureMethodHandler")]
			get {
				if (id_getSignatureMethod == IntPtr.Zero)
					id_getSignatureMethod = JNIEnv.GetMethodID (class_ref, "getSignatureMethod", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getSignatureMethod), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_sign_Loauth_signpost_http_HttpRequest_Loauth_signpost_http_HttpParameters_;
		// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost.signature']/class[@name='OAuthMessageSigner']/method[@name='sign' and count(parameter)=2 and parameter[1][@type='oauth.signpost.http.HttpRequest'] and parameter[2][@type='oauth.signpost.http.HttpParameters']]"
		[Register ("sign", "(Loauth/signpost/http/HttpRequest;Loauth/signpost/http/HttpParameters;)Ljava/lang/String;", "GetSign_Loauth_signpost_http_HttpRequest_Loauth_signpost_http_HttpParameters_Handler")]
		public override unsafe string Sign (global::Oauth.Signpost.Http.IHttpRequest p0, global::Oauth.Signpost.Http.HttpParameters p1)
		{
			if (id_sign_Loauth_signpost_http_HttpRequest_Loauth_signpost_http_HttpParameters_ == IntPtr.Zero)
				id_sign_Loauth_signpost_http_HttpRequest_Loauth_signpost_http_HttpParameters_ = JNIEnv.GetMethodID (class_ref, "sign", "(Loauth/signpost/http/HttpRequest;Loauth/signpost/http/HttpParameters;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_sign_Loauth_signpost_http_HttpRequest_Loauth_signpost_http_HttpParameters_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}

}
