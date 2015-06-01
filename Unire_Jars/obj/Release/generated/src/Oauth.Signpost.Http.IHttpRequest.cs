using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Oauth.Signpost.Http {

	// Metadata.xml XPath interface reference: path="/api/package[@name='oauth.signpost.http']/interface[@name='HttpRequest']"
	[Register ("oauth/signpost/http/HttpRequest", "", "Oauth.Signpost.Http.IHttpRequestInvoker")]
	public partial interface IHttpRequest : IJavaObject {

		global::System.Collections.Generic.IDictionary<string, string> AllHeaders {
			// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost.http']/interface[@name='HttpRequest']/method[@name='getAllHeaders' and count(parameter)=0]"
			[Register ("getAllHeaders", "()Ljava/util/Map;", "GetGetAllHeadersHandler:Oauth.Signpost.Http.IHttpRequestInvoker, Unire_Jars")] get;
		}

		string ContentType {
			// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost.http']/interface[@name='HttpRequest']/method[@name='getContentType' and count(parameter)=0]"
			[Register ("getContentType", "()Ljava/lang/String;", "GetGetContentTypeHandler:Oauth.Signpost.Http.IHttpRequestInvoker, Unire_Jars")] get;
		}

		global::System.IO.Stream MessagePayload {
			// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost.http']/interface[@name='HttpRequest']/method[@name='getMessagePayload' and count(parameter)=0]"
			[Register ("getMessagePayload", "()Ljava/io/InputStream;", "GetGetMessagePayloadHandler:Oauth.Signpost.Http.IHttpRequestInvoker, Unire_Jars")] get;
		}

		string Method {
			// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost.http']/interface[@name='HttpRequest']/method[@name='getMethod' and count(parameter)=0]"
			[Register ("getMethod", "()Ljava/lang/String;", "GetGetMethodHandler:Oauth.Signpost.Http.IHttpRequestInvoker, Unire_Jars")] get;
		}

		string RequestUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost.http']/interface[@name='HttpRequest']/method[@name='getRequestUrl' and count(parameter)=0]"
			[Register ("getRequestUrl", "()Ljava/lang/String;", "GetGetRequestUrlHandler:Oauth.Signpost.Http.IHttpRequestInvoker, Unire_Jars")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost.http']/interface[@name='HttpRequest']/method[@name='setRequestUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setRequestUrl", "(Ljava/lang/String;)V", "GetSetRequestUrl_Ljava_lang_String_Handler:Oauth.Signpost.Http.IHttpRequestInvoker, Unire_Jars")] set;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost.http']/interface[@name='HttpRequest']/method[@name='getHeader' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getHeader", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetHeader_Ljava_lang_String_Handler:Oauth.Signpost.Http.IHttpRequestInvoker, Unire_Jars")]
		string GetHeader (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost.http']/interface[@name='HttpRequest']/method[@name='setHeader' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setHeader", "(Ljava/lang/String;Ljava/lang/String;)V", "GetSetHeader_Ljava_lang_String_Ljava_lang_String_Handler:Oauth.Signpost.Http.IHttpRequestInvoker, Unire_Jars")]
		void SetHeader (string p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost.http']/interface[@name='HttpRequest']/method[@name='unwrap' and count(parameter)=0]"
		[Register ("unwrap", "()Ljava/lang/Object;", "GetUnwrapHandler:Oauth.Signpost.Http.IHttpRequestInvoker, Unire_Jars")]
		global::Java.Lang.Object Unwrap ();

	}

	[global::Android.Runtime.Register ("oauth/signpost/http/HttpRequest", DoNotGenerateAcw=true)]
	internal class IHttpRequestInvoker : global::Java.Lang.Object, IHttpRequest {

		static IntPtr java_class_ref = JNIEnv.FindClass ("oauth/signpost/http/HttpRequest");
		IntPtr class_ref;

		public static IHttpRequest GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IHttpRequest> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "oauth.signpost.http.HttpRequest"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IHttpRequestInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IHttpRequestInvoker); }
		}

		static Delegate cb_getAllHeaders;
#pragma warning disable 0169
		static Delegate GetGetAllHeadersHandler ()
		{
			if (cb_getAllHeaders == null)
				cb_getAllHeaders = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAllHeaders);
			return cb_getAllHeaders;
		}

		static IntPtr n_GetAllHeaders (IntPtr jnienv, IntPtr native__this)
		{
			global::Oauth.Signpost.Http.IHttpRequest __this = global::Java.Lang.Object.GetObject<global::Oauth.Signpost.Http.IHttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.AllHeaders);
		}
#pragma warning restore 0169

		IntPtr id_getAllHeaders;
		public unsafe global::System.Collections.Generic.IDictionary<string, string> AllHeaders {
			get {
				if (id_getAllHeaders == IntPtr.Zero)
					id_getAllHeaders = JNIEnv.GetMethodID (class_ref, "getAllHeaders", "()Ljava/util/Map;");
				return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod (Handle, id_getAllHeaders), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getContentType;
#pragma warning disable 0169
		static Delegate GetGetContentTypeHandler ()
		{
			if (cb_getContentType == null)
				cb_getContentType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContentType);
			return cb_getContentType;
		}

		static IntPtr n_GetContentType (IntPtr jnienv, IntPtr native__this)
		{
			global::Oauth.Signpost.Http.IHttpRequest __this = global::Java.Lang.Object.GetObject<global::Oauth.Signpost.Http.IHttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ContentType);
		}
#pragma warning restore 0169

		IntPtr id_getContentType;
		public unsafe string ContentType {
			get {
				if (id_getContentType == IntPtr.Zero)
					id_getContentType = JNIEnv.GetMethodID (class_ref, "getContentType", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getContentType), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getMessagePayload;
#pragma warning disable 0169
		static Delegate GetGetMessagePayloadHandler ()
		{
			if (cb_getMessagePayload == null)
				cb_getMessagePayload = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMessagePayload);
			return cb_getMessagePayload;
		}

		static IntPtr n_GetMessagePayload (IntPtr jnienv, IntPtr native__this)
		{
			global::Oauth.Signpost.Http.IHttpRequest __this = global::Java.Lang.Object.GetObject<global::Oauth.Signpost.Http.IHttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.MessagePayload);
		}
#pragma warning restore 0169

		IntPtr id_getMessagePayload;
		public unsafe global::System.IO.Stream MessagePayload {
			get {
				if (id_getMessagePayload == IntPtr.Zero)
					id_getMessagePayload = JNIEnv.GetMethodID (class_ref, "getMessagePayload", "()Ljava/io/InputStream;");
				return global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod (Handle, id_getMessagePayload), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getMethod;
#pragma warning disable 0169
		static Delegate GetGetMethodHandler ()
		{
			if (cb_getMethod == null)
				cb_getMethod = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMethod);
			return cb_getMethod;
		}

		static IntPtr n_GetMethod (IntPtr jnienv, IntPtr native__this)
		{
			global::Oauth.Signpost.Http.IHttpRequest __this = global::Java.Lang.Object.GetObject<global::Oauth.Signpost.Http.IHttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Method);
		}
#pragma warning restore 0169

		IntPtr id_getMethod;
		public unsafe string Method {
			get {
				if (id_getMethod == IntPtr.Zero)
					id_getMethod = JNIEnv.GetMethodID (class_ref, "getMethod", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getMethod), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getRequestUrl;
#pragma warning disable 0169
		static Delegate GetGetRequestUrlHandler ()
		{
			if (cb_getRequestUrl == null)
				cb_getRequestUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRequestUrl);
			return cb_getRequestUrl;
		}

		static IntPtr n_GetRequestUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Oauth.Signpost.Http.IHttpRequest __this = global::Java.Lang.Object.GetObject<global::Oauth.Signpost.Http.IHttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RequestUrl);
		}
#pragma warning restore 0169

		static Delegate cb_setRequestUrl_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetRequestUrl_Ljava_lang_String_Handler ()
		{
			if (cb_setRequestUrl_Ljava_lang_String_ == null)
				cb_setRequestUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRequestUrl_Ljava_lang_String_);
			return cb_setRequestUrl_Ljava_lang_String_;
		}

		static void n_SetRequestUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Oauth.Signpost.Http.IHttpRequest __this = global::Java.Lang.Object.GetObject<global::Oauth.Signpost.Http.IHttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RequestUrl = p0;
		}
#pragma warning restore 0169

		IntPtr id_getRequestUrl;
		IntPtr id_setRequestUrl_Ljava_lang_String_;
		public unsafe string RequestUrl {
			get {
				if (id_getRequestUrl == IntPtr.Zero)
					id_getRequestUrl = JNIEnv.GetMethodID (class_ref, "getRequestUrl", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getRequestUrl), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setRequestUrl_Ljava_lang_String_ == IntPtr.Zero)
					id_setRequestUrl_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setRequestUrl", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				JNIEnv.CallVoidMethod (Handle, id_setRequestUrl_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getHeader_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetHeader_Ljava_lang_String_Handler ()
		{
			if (cb_getHeader_Ljava_lang_String_ == null)
				cb_getHeader_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetHeader_Ljava_lang_String_);
			return cb_getHeader_Ljava_lang_String_;
		}

		static IntPtr n_GetHeader_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Oauth.Signpost.Http.IHttpRequest __this = global::Java.Lang.Object.GetObject<global::Oauth.Signpost.Http.IHttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetHeader (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getHeader_Ljava_lang_String_;
		public unsafe string GetHeader (string p0)
		{
			if (id_getHeader_Ljava_lang_String_ == IntPtr.Zero)
				id_getHeader_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getHeader", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getHeader_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_setHeader_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetHeader_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_setHeader_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_setHeader_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetHeader_Ljava_lang_String_Ljava_lang_String_);
			return cb_setHeader_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_SetHeader_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Oauth.Signpost.Http.IHttpRequest __this = global::Java.Lang.Object.GetObject<global::Oauth.Signpost.Http.IHttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetHeader (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_setHeader_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void SetHeader (string p0, string p1)
		{
			if (id_setHeader_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setHeader_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setHeader", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (Handle, id_setHeader_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_unwrap;
#pragma warning disable 0169
		static Delegate GetUnwrapHandler ()
		{
			if (cb_unwrap == null)
				cb_unwrap = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Unwrap);
			return cb_unwrap;
		}

		static IntPtr n_Unwrap (IntPtr jnienv, IntPtr native__this)
		{
			global::Oauth.Signpost.Http.IHttpRequest __this = global::Java.Lang.Object.GetObject<global::Oauth.Signpost.Http.IHttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Unwrap ());
		}
#pragma warning restore 0169

		IntPtr id_unwrap;
		public unsafe global::Java.Lang.Object Unwrap ()
		{
			if (id_unwrap == IntPtr.Zero)
				id_unwrap = JNIEnv.GetMethodID (class_ref, "unwrap", "()Ljava/lang/Object;");
			return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (Handle, id_unwrap), JniHandleOwnership.TransferLocalRef);
		}

	}

}
