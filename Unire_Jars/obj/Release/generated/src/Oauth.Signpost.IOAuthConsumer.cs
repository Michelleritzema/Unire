using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Oauth.Signpost {

	// Metadata.xml XPath interface reference: path="/api/package[@name='oauth.signpost']/interface[@name='OAuthConsumer']"
	[Register ("oauth/signpost/OAuthConsumer", "", "Oauth.Signpost.IOAuthConsumerInvoker")]
	public partial interface IOAuthConsumer : global::Java.IO.ISerializable {

		string ConsumerKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost']/interface[@name='OAuthConsumer']/method[@name='getConsumerKey' and count(parameter)=0]"
			[Register ("getConsumerKey", "()Ljava/lang/String;", "GetGetConsumerKeyHandler:Oauth.Signpost.IOAuthConsumerInvoker, Unire_Jars")] get;
		}

		string ConsumerSecret {
			// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost']/interface[@name='OAuthConsumer']/method[@name='getConsumerSecret' and count(parameter)=0]"
			[Register ("getConsumerSecret", "()Ljava/lang/String;", "GetGetConsumerSecretHandler:Oauth.Signpost.IOAuthConsumerInvoker, Unire_Jars")] get;
		}

		global::Oauth.Signpost.Http.HttpParameters RequestParameters {
			// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost']/interface[@name='OAuthConsumer']/method[@name='getRequestParameters' and count(parameter)=0]"
			[Register ("getRequestParameters", "()Loauth/signpost/http/HttpParameters;", "GetGetRequestParametersHandler:Oauth.Signpost.IOAuthConsumerInvoker, Unire_Jars")] get;
		}

		string Token {
			// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost']/interface[@name='OAuthConsumer']/method[@name='getToken' and count(parameter)=0]"
			[Register ("getToken", "()Ljava/lang/String;", "GetGetTokenHandler:Oauth.Signpost.IOAuthConsumerInvoker, Unire_Jars")] get;
		}

		string TokenSecret {
			// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost']/interface[@name='OAuthConsumer']/method[@name='getTokenSecret' and count(parameter)=0]"
			[Register ("getTokenSecret", "()Ljava/lang/String;", "GetGetTokenSecretHandler:Oauth.Signpost.IOAuthConsumerInvoker, Unire_Jars")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost']/interface[@name='OAuthConsumer']/method[@name='setAdditionalParameters' and count(parameter)=1 and parameter[1][@type='oauth.signpost.http.HttpParameters']]"
		[Register ("setAdditionalParameters", "(Loauth/signpost/http/HttpParameters;)V", "GetSetAdditionalParameters_Loauth_signpost_http_HttpParameters_Handler:Oauth.Signpost.IOAuthConsumerInvoker, Unire_Jars")]
		void SetAdditionalParameters (global::Oauth.Signpost.Http.HttpParameters p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost']/interface[@name='OAuthConsumer']/method[@name='setMessageSigner' and count(parameter)=1 and parameter[1][@type='oauth.signpost.signature.OAuthMessageSigner']]"
		[Register ("setMessageSigner", "(Loauth/signpost/signature/OAuthMessageSigner;)V", "GetSetMessageSigner_Loauth_signpost_signature_OAuthMessageSigner_Handler:Oauth.Signpost.IOAuthConsumerInvoker, Unire_Jars")]
		void SetMessageSigner (global::Oauth.Signpost.Signature.OAuthMessageSigner p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost']/interface[@name='OAuthConsumer']/method[@name='setSendEmptyTokens' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setSendEmptyTokens", "(Z)V", "GetSetSendEmptyTokens_ZHandler:Oauth.Signpost.IOAuthConsumerInvoker, Unire_Jars")]
		void SetSendEmptyTokens (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost']/interface[@name='OAuthConsumer']/method[@name='setSigningStrategy' and count(parameter)=1 and parameter[1][@type='oauth.signpost.signature.SigningStrategy']]"
		[Register ("setSigningStrategy", "(Loauth/signpost/signature/SigningStrategy;)V", "GetSetSigningStrategy_Loauth_signpost_signature_SigningStrategy_Handler:Oauth.Signpost.IOAuthConsumerInvoker, Unire_Jars")]
		void SetSigningStrategy (global::Oauth.Signpost.Signature.ISigningStrategy p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost']/interface[@name='OAuthConsumer']/method[@name='setTokenWithSecret' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setTokenWithSecret", "(Ljava/lang/String;Ljava/lang/String;)V", "GetSetTokenWithSecret_Ljava_lang_String_Ljava_lang_String_Handler:Oauth.Signpost.IOAuthConsumerInvoker, Unire_Jars")]
		void SetTokenWithSecret (string p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost']/interface[@name='OAuthConsumer']/method[@name='sign' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("sign", "(Ljava/lang/Object;)Loauth/signpost/http/HttpRequest;", "GetSign_Ljava_lang_Object_Handler:Oauth.Signpost.IOAuthConsumerInvoker, Unire_Jars")]
		global::Oauth.Signpost.Http.IHttpRequest Sign (global::Java.Lang.Object p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost']/interface[@name='OAuthConsumer']/method[@name='sign' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("sign", "(Ljava/lang/String;)Ljava/lang/String;", "GetSign_Ljava_lang_String_Handler:Oauth.Signpost.IOAuthConsumerInvoker, Unire_Jars")]
		string Sign (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost']/interface[@name='OAuthConsumer']/method[@name='sign' and count(parameter)=1 and parameter[1][@type='oauth.signpost.http.HttpRequest']]"
		[Register ("sign", "(Loauth/signpost/http/HttpRequest;)Loauth/signpost/http/HttpRequest;", "GetSign_Loauth_signpost_http_HttpRequest_Handler:Oauth.Signpost.IOAuthConsumerInvoker, Unire_Jars")]
		global::Oauth.Signpost.Http.IHttpRequest Sign (global::Oauth.Signpost.Http.IHttpRequest p0);

	}

	[global::Android.Runtime.Register ("oauth/signpost/OAuthConsumer", DoNotGenerateAcw=true)]
	internal class IOAuthConsumerInvoker : global::Java.Lang.Object, IOAuthConsumer {

		static IntPtr java_class_ref = JNIEnv.FindClass ("oauth/signpost/OAuthConsumer");
		IntPtr class_ref;

		public static IOAuthConsumer GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOAuthConsumer> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "oauth.signpost.OAuthConsumer"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOAuthConsumerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IOAuthConsumerInvoker); }
		}

		static Delegate cb_getConsumerKey;
#pragma warning disable 0169
		static Delegate GetGetConsumerKeyHandler ()
		{
			if (cb_getConsumerKey == null)
				cb_getConsumerKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetConsumerKey);
			return cb_getConsumerKey;
		}

		static IntPtr n_GetConsumerKey (IntPtr jnienv, IntPtr native__this)
		{
			global::Oauth.Signpost.IOAuthConsumer __this = global::Java.Lang.Object.GetObject<global::Oauth.Signpost.IOAuthConsumer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ConsumerKey);
		}
#pragma warning restore 0169

		IntPtr id_getConsumerKey;
		public unsafe string ConsumerKey {
			get {
				if (id_getConsumerKey == IntPtr.Zero)
					id_getConsumerKey = JNIEnv.GetMethodID (class_ref, "getConsumerKey", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getConsumerKey), JniHandleOwnership.TransferLocalRef);
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
			global::Oauth.Signpost.IOAuthConsumer __this = global::Java.Lang.Object.GetObject<global::Oauth.Signpost.IOAuthConsumer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ConsumerSecret);
		}
#pragma warning restore 0169

		IntPtr id_getConsumerSecret;
		public unsafe string ConsumerSecret {
			get {
				if (id_getConsumerSecret == IntPtr.Zero)
					id_getConsumerSecret = JNIEnv.GetMethodID (class_ref, "getConsumerSecret", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getConsumerSecret), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getRequestParameters;
#pragma warning disable 0169
		static Delegate GetGetRequestParametersHandler ()
		{
			if (cb_getRequestParameters == null)
				cb_getRequestParameters = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRequestParameters);
			return cb_getRequestParameters;
		}

		static IntPtr n_GetRequestParameters (IntPtr jnienv, IntPtr native__this)
		{
			global::Oauth.Signpost.IOAuthConsumer __this = global::Java.Lang.Object.GetObject<global::Oauth.Signpost.IOAuthConsumer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RequestParameters);
		}
#pragma warning restore 0169

		IntPtr id_getRequestParameters;
		public unsafe global::Oauth.Signpost.Http.HttpParameters RequestParameters {
			get {
				if (id_getRequestParameters == IntPtr.Zero)
					id_getRequestParameters = JNIEnv.GetMethodID (class_ref, "getRequestParameters", "()Loauth/signpost/http/HttpParameters;");
				return global::Java.Lang.Object.GetObject<global::Oauth.Signpost.Http.HttpParameters> (JNIEnv.CallObjectMethod (Handle, id_getRequestParameters), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getToken;
#pragma warning disable 0169
		static Delegate GetGetTokenHandler ()
		{
			if (cb_getToken == null)
				cb_getToken = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetToken);
			return cb_getToken;
		}

		static IntPtr n_GetToken (IntPtr jnienv, IntPtr native__this)
		{
			global::Oauth.Signpost.IOAuthConsumer __this = global::Java.Lang.Object.GetObject<global::Oauth.Signpost.IOAuthConsumer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Token);
		}
#pragma warning restore 0169

		IntPtr id_getToken;
		public unsafe string Token {
			get {
				if (id_getToken == IntPtr.Zero)
					id_getToken = JNIEnv.GetMethodID (class_ref, "getToken", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getToken), JniHandleOwnership.TransferLocalRef);
			}
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
			global::Oauth.Signpost.IOAuthConsumer __this = global::Java.Lang.Object.GetObject<global::Oauth.Signpost.IOAuthConsumer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TokenSecret);
		}
#pragma warning restore 0169

		IntPtr id_getTokenSecret;
		public unsafe string TokenSecret {
			get {
				if (id_getTokenSecret == IntPtr.Zero)
					id_getTokenSecret = JNIEnv.GetMethodID (class_ref, "getTokenSecret", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getTokenSecret), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_setAdditionalParameters_Loauth_signpost_http_HttpParameters_;
#pragma warning disable 0169
		static Delegate GetSetAdditionalParameters_Loauth_signpost_http_HttpParameters_Handler ()
		{
			if (cb_setAdditionalParameters_Loauth_signpost_http_HttpParameters_ == null)
				cb_setAdditionalParameters_Loauth_signpost_http_HttpParameters_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAdditionalParameters_Loauth_signpost_http_HttpParameters_);
			return cb_setAdditionalParameters_Loauth_signpost_http_HttpParameters_;
		}

		static void n_SetAdditionalParameters_Loauth_signpost_http_HttpParameters_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Oauth.Signpost.IOAuthConsumer __this = global::Java.Lang.Object.GetObject<global::Oauth.Signpost.IOAuthConsumer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Oauth.Signpost.Http.HttpParameters p0 = global::Java.Lang.Object.GetObject<global::Oauth.Signpost.Http.HttpParameters> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetAdditionalParameters (p0);
		}
#pragma warning restore 0169

		IntPtr id_setAdditionalParameters_Loauth_signpost_http_HttpParameters_;
		public unsafe void SetAdditionalParameters (global::Oauth.Signpost.Http.HttpParameters p0)
		{
			if (id_setAdditionalParameters_Loauth_signpost_http_HttpParameters_ == IntPtr.Zero)
				id_setAdditionalParameters_Loauth_signpost_http_HttpParameters_ = JNIEnv.GetMethodID (class_ref, "setAdditionalParameters", "(Loauth/signpost/http/HttpParameters;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_setAdditionalParameters_Loauth_signpost_http_HttpParameters_, __args);
		}

		static Delegate cb_setMessageSigner_Loauth_signpost_signature_OAuthMessageSigner_;
#pragma warning disable 0169
		static Delegate GetSetMessageSigner_Loauth_signpost_signature_OAuthMessageSigner_Handler ()
		{
			if (cb_setMessageSigner_Loauth_signpost_signature_OAuthMessageSigner_ == null)
				cb_setMessageSigner_Loauth_signpost_signature_OAuthMessageSigner_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMessageSigner_Loauth_signpost_signature_OAuthMessageSigner_);
			return cb_setMessageSigner_Loauth_signpost_signature_OAuthMessageSigner_;
		}

		static void n_SetMessageSigner_Loauth_signpost_signature_OAuthMessageSigner_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Oauth.Signpost.IOAuthConsumer __this = global::Java.Lang.Object.GetObject<global::Oauth.Signpost.IOAuthConsumer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Oauth.Signpost.Signature.OAuthMessageSigner p0 = global::Java.Lang.Object.GetObject<global::Oauth.Signpost.Signature.OAuthMessageSigner> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetMessageSigner (p0);
		}
#pragma warning restore 0169

		IntPtr id_setMessageSigner_Loauth_signpost_signature_OAuthMessageSigner_;
		public unsafe void SetMessageSigner (global::Oauth.Signpost.Signature.OAuthMessageSigner p0)
		{
			if (id_setMessageSigner_Loauth_signpost_signature_OAuthMessageSigner_ == IntPtr.Zero)
				id_setMessageSigner_Loauth_signpost_signature_OAuthMessageSigner_ = JNIEnv.GetMethodID (class_ref, "setMessageSigner", "(Loauth/signpost/signature/OAuthMessageSigner;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_setMessageSigner_Loauth_signpost_signature_OAuthMessageSigner_, __args);
		}

		static Delegate cb_setSendEmptyTokens_Z;
#pragma warning disable 0169
		static Delegate GetSetSendEmptyTokens_ZHandler ()
		{
			if (cb_setSendEmptyTokens_Z == null)
				cb_setSendEmptyTokens_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetSendEmptyTokens_Z);
			return cb_setSendEmptyTokens_Z;
		}

		static void n_SetSendEmptyTokens_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Oauth.Signpost.IOAuthConsumer __this = global::Java.Lang.Object.GetObject<global::Oauth.Signpost.IOAuthConsumer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSendEmptyTokens (p0);
		}
#pragma warning restore 0169

		IntPtr id_setSendEmptyTokens_Z;
		public unsafe void SetSendEmptyTokens (bool p0)
		{
			if (id_setSendEmptyTokens_Z == IntPtr.Zero)
				id_setSendEmptyTokens_Z = JNIEnv.GetMethodID (class_ref, "setSendEmptyTokens", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_setSendEmptyTokens_Z, __args);
		}

		static Delegate cb_setSigningStrategy_Loauth_signpost_signature_SigningStrategy_;
#pragma warning disable 0169
		static Delegate GetSetSigningStrategy_Loauth_signpost_signature_SigningStrategy_Handler ()
		{
			if (cb_setSigningStrategy_Loauth_signpost_signature_SigningStrategy_ == null)
				cb_setSigningStrategy_Loauth_signpost_signature_SigningStrategy_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSigningStrategy_Loauth_signpost_signature_SigningStrategy_);
			return cb_setSigningStrategy_Loauth_signpost_signature_SigningStrategy_;
		}

		static void n_SetSigningStrategy_Loauth_signpost_signature_SigningStrategy_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Oauth.Signpost.IOAuthConsumer __this = global::Java.Lang.Object.GetObject<global::Oauth.Signpost.IOAuthConsumer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Oauth.Signpost.Signature.ISigningStrategy p0 = (global::Oauth.Signpost.Signature.ISigningStrategy)global::Java.Lang.Object.GetObject<global::Oauth.Signpost.Signature.ISigningStrategy> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetSigningStrategy (p0);
		}
#pragma warning restore 0169

		IntPtr id_setSigningStrategy_Loauth_signpost_signature_SigningStrategy_;
		public unsafe void SetSigningStrategy (global::Oauth.Signpost.Signature.ISigningStrategy p0)
		{
			if (id_setSigningStrategy_Loauth_signpost_signature_SigningStrategy_ == IntPtr.Zero)
				id_setSigningStrategy_Loauth_signpost_signature_SigningStrategy_ = JNIEnv.GetMethodID (class_ref, "setSigningStrategy", "(Loauth/signpost/signature/SigningStrategy;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_setSigningStrategy_Loauth_signpost_signature_SigningStrategy_, __args);
		}

		static Delegate cb_setTokenWithSecret_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTokenWithSecret_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_setTokenWithSecret_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_setTokenWithSecret_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetTokenWithSecret_Ljava_lang_String_Ljava_lang_String_);
			return cb_setTokenWithSecret_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_SetTokenWithSecret_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Oauth.Signpost.IOAuthConsumer __this = global::Java.Lang.Object.GetObject<global::Oauth.Signpost.IOAuthConsumer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetTokenWithSecret (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_setTokenWithSecret_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void SetTokenWithSecret (string p0, string p1)
		{
			if (id_setTokenWithSecret_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setTokenWithSecret_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTokenWithSecret", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (Handle, id_setTokenWithSecret_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_sign_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSign_Ljava_lang_Object_Handler ()
		{
			if (cb_sign_Ljava_lang_Object_ == null)
				cb_sign_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Sign_Ljava_lang_Object_);
			return cb_sign_Ljava_lang_Object_;
		}

		static IntPtr n_Sign_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Oauth.Signpost.IOAuthConsumer __this = global::Java.Lang.Object.GetObject<global::Oauth.Signpost.IOAuthConsumer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Sign (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_sign_Ljava_lang_Object_;
		public unsafe global::Oauth.Signpost.Http.IHttpRequest Sign (global::Java.Lang.Object p0)
		{
			if (id_sign_Ljava_lang_Object_ == IntPtr.Zero)
				id_sign_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "sign", "(Ljava/lang/Object;)Loauth/signpost/http/HttpRequest;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			global::Oauth.Signpost.Http.IHttpRequest __ret = global::Java.Lang.Object.GetObject<global::Oauth.Signpost.Http.IHttpRequest> (JNIEnv.CallObjectMethod (Handle, id_sign_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_sign_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSign_Ljava_lang_String_Handler ()
		{
			if (cb_sign_Ljava_lang_String_ == null)
				cb_sign_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Sign_Ljava_lang_String_);
			return cb_sign_Ljava_lang_String_;
		}

		static IntPtr n_Sign_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Oauth.Signpost.IOAuthConsumer __this = global::Java.Lang.Object.GetObject<global::Oauth.Signpost.IOAuthConsumer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Sign (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_sign_Ljava_lang_String_;
		public unsafe string Sign (string p0)
		{
			if (id_sign_Ljava_lang_String_ == IntPtr.Zero)
				id_sign_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "sign", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_sign_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_sign_Loauth_signpost_http_HttpRequest_;
#pragma warning disable 0169
		static Delegate GetSign_Loauth_signpost_http_HttpRequest_Handler ()
		{
			if (cb_sign_Loauth_signpost_http_HttpRequest_ == null)
				cb_sign_Loauth_signpost_http_HttpRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Sign_Loauth_signpost_http_HttpRequest_);
			return cb_sign_Loauth_signpost_http_HttpRequest_;
		}

		static IntPtr n_Sign_Loauth_signpost_http_HttpRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Oauth.Signpost.IOAuthConsumer __this = global::Java.Lang.Object.GetObject<global::Oauth.Signpost.IOAuthConsumer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Oauth.Signpost.Http.IHttpRequest p0 = (global::Oauth.Signpost.Http.IHttpRequest)global::Java.Lang.Object.GetObject<global::Oauth.Signpost.Http.IHttpRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Sign (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_sign_Loauth_signpost_http_HttpRequest_;
		public unsafe global::Oauth.Signpost.Http.IHttpRequest Sign (global::Oauth.Signpost.Http.IHttpRequest p0)
		{
			if (id_sign_Loauth_signpost_http_HttpRequest_ == IntPtr.Zero)
				id_sign_Loauth_signpost_http_HttpRequest_ = JNIEnv.GetMethodID (class_ref, "sign", "(Loauth/signpost/http/HttpRequest;)Loauth/signpost/http/HttpRequest;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			global::Oauth.Signpost.Http.IHttpRequest __ret = global::Java.Lang.Object.GetObject<global::Oauth.Signpost.Http.IHttpRequest> (JNIEnv.CallObjectMethod (Handle, id_sign_Loauth_signpost_http_HttpRequest_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
