using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Oauth.Signpost.Commonshttp {

	// Metadata.xml XPath class reference: path="/api/package[@name='oauth.signpost.commonshttp']/class[@name='HttpRequestAdapter']"
	[global::Android.Runtime.Register ("oauth/signpost/commonshttp/HttpRequestAdapter", DoNotGenerateAcw=true)]
	public partial class HttpRequestAdapter : global::Java.Lang.Object, global::Oauth.Signpost.Http.IHttpRequest {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("oauth/signpost/commonshttp/HttpRequestAdapter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HttpRequestAdapter); }
		}

		protected HttpRequestAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_apache_http_client_methods_HttpUriRequest_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='oauth.signpost.commonshttp']/class[@name='HttpRequestAdapter']/constructor[@name='HttpRequestAdapter' and count(parameter)=1 and parameter[1][@type='org.apache.http.client.methods.HttpUriRequest']]"
		[Register (".ctor", "(Lorg/apache/http/client/methods/HttpUriRequest;)V", "")]
		public unsafe HttpRequestAdapter (global::Org.Apache.Http.Client.Methods.IHttpUriRequest p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (HttpRequestAdapter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/apache/http/client/methods/HttpUriRequest;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/apache/http/client/methods/HttpUriRequest;)V", __args);
					return;
				}

				if (id_ctor_Lorg_apache_http_client_methods_HttpUriRequest_ == IntPtr.Zero)
					id_ctor_Lorg_apache_http_client_methods_HttpUriRequest_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/apache/http/client/methods/HttpUriRequest;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_apache_http_client_methods_HttpUriRequest_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_apache_http_client_methods_HttpUriRequest_, __args);
			} finally {
			}
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
			global::Oauth.Signpost.Commonshttp.HttpRequestAdapter __this = global::Java.Lang.Object.GetObject<global::Oauth.Signpost.Commonshttp.HttpRequestAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.AllHeaders);
		}
#pragma warning restore 0169

		static IntPtr id_getAllHeaders;
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> AllHeaders {
			// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost.commonshttp']/class[@name='HttpRequestAdapter']/method[@name='getAllHeaders' and count(parameter)=0]"
			[Register ("getAllHeaders", "()Ljava/util/Map;", "GetGetAllHeadersHandler")]
			get {
				if (id_getAllHeaders == IntPtr.Zero)
					id_getAllHeaders = JNIEnv.GetMethodID (class_ref, "getAllHeaders", "()Ljava/util/Map;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getAllHeaders), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAllHeaders", "()Ljava/util/Map;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::Oauth.Signpost.Commonshttp.HttpRequestAdapter __this = global::Java.Lang.Object.GetObject<global::Oauth.Signpost.Commonshttp.HttpRequestAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ContentType);
		}
#pragma warning restore 0169

		static IntPtr id_getContentType;
		public virtual unsafe string ContentType {
			// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost.commonshttp']/class[@name='HttpRequestAdapter']/method[@name='getContentType' and count(parameter)=0]"
			[Register ("getContentType", "()Ljava/lang/String;", "GetGetContentTypeHandler")]
			get {
				if (id_getContentType == IntPtr.Zero)
					id_getContentType = JNIEnv.GetMethodID (class_ref, "getContentType", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getContentType), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContentType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::Oauth.Signpost.Commonshttp.HttpRequestAdapter __this = global::Java.Lang.Object.GetObject<global::Oauth.Signpost.Commonshttp.HttpRequestAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.MessagePayload);
		}
#pragma warning restore 0169

		static IntPtr id_getMessagePayload;
		public virtual unsafe global::System.IO.Stream MessagePayload {
			// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost.commonshttp']/class[@name='HttpRequestAdapter']/method[@name='getMessagePayload' and count(parameter)=0]"
			[Register ("getMessagePayload", "()Ljava/io/InputStream;", "GetGetMessagePayloadHandler")]
			get {
				if (id_getMessagePayload == IntPtr.Zero)
					id_getMessagePayload = JNIEnv.GetMethodID (class_ref, "getMessagePayload", "()Ljava/io/InputStream;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getMessagePayload), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessagePayload", "()Ljava/io/InputStream;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::Oauth.Signpost.Commonshttp.HttpRequestAdapter __this = global::Java.Lang.Object.GetObject<global::Oauth.Signpost.Commonshttp.HttpRequestAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Method);
		}
#pragma warning restore 0169

		static IntPtr id_getMethod;
		public virtual unsafe string Method {
			// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost.commonshttp']/class[@name='HttpRequestAdapter']/method[@name='getMethod' and count(parameter)=0]"
			[Register ("getMethod", "()Ljava/lang/String;", "GetGetMethodHandler")]
			get {
				if (id_getMethod == IntPtr.Zero)
					id_getMethod = JNIEnv.GetMethodID (class_ref, "getMethod", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getMethod), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMethod", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::Oauth.Signpost.Commonshttp.HttpRequestAdapter __this = global::Java.Lang.Object.GetObject<global::Oauth.Signpost.Commonshttp.HttpRequestAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Oauth.Signpost.Commonshttp.HttpRequestAdapter __this = global::Java.Lang.Object.GetObject<global::Oauth.Signpost.Commonshttp.HttpRequestAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RequestUrl = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getRequestUrl;
		static IntPtr id_setRequestUrl_Ljava_lang_String_;
		public virtual unsafe string RequestUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost.commonshttp']/class[@name='HttpRequestAdapter']/method[@name='getRequestUrl' and count(parameter)=0]"
			[Register ("getRequestUrl", "()Ljava/lang/String;", "GetGetRequestUrlHandler")]
			get {
				if (id_getRequestUrl == IntPtr.Zero)
					id_getRequestUrl = JNIEnv.GetMethodID (class_ref, "getRequestUrl", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getRequestUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRequestUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost.commonshttp']/class[@name='HttpRequestAdapter']/method[@name='setRequestUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setRequestUrl", "(Ljava/lang/String;)V", "GetSetRequestUrl_Ljava_lang_String_Handler")]
			set {
				if (id_setRequestUrl_Ljava_lang_String_ == IntPtr.Zero)
					id_setRequestUrl_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setRequestUrl", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setRequestUrl_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRequestUrl", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
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
			global::Oauth.Signpost.Commonshttp.HttpRequestAdapter __this = global::Java.Lang.Object.GetObject<global::Oauth.Signpost.Commonshttp.HttpRequestAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetHeader (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getHeader_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost.commonshttp']/class[@name='HttpRequestAdapter']/method[@name='getHeader' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getHeader", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetHeader_Ljava_lang_String_Handler")]
		public virtual unsafe string GetHeader (string p0)
		{
			if (id_getHeader_Ljava_lang_String_ == IntPtr.Zero)
				id_getHeader_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getHeader", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getHeader_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHeader", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
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
			global::Oauth.Signpost.Commonshttp.HttpRequestAdapter __this = global::Java.Lang.Object.GetObject<global::Oauth.Signpost.Commonshttp.HttpRequestAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetHeader (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setHeader_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost.commonshttp']/class[@name='HttpRequestAdapter']/method[@name='setHeader' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setHeader", "(Ljava/lang/String;Ljava/lang/String;)V", "GetSetHeader_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void SetHeader (string p0, string p1)
		{
			if (id_setHeader_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setHeader_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setHeader", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setHeader_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHeader", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
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
			global::Oauth.Signpost.Commonshttp.HttpRequestAdapter __this = global::Java.Lang.Object.GetObject<global::Oauth.Signpost.Commonshttp.HttpRequestAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Unwrap ());
		}
#pragma warning restore 0169

		static IntPtr id_unwrap;
		// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost.commonshttp']/class[@name='HttpRequestAdapter']/method[@name='unwrap' and count(parameter)=0]"
		[Register ("unwrap", "()Ljava/lang/Object;", "GetUnwrapHandler")]
		public virtual unsafe global::Java.Lang.Object Unwrap ()
		{
			if (id_unwrap == IntPtr.Zero)
				id_unwrap = JNIEnv.GetMethodID (class_ref, "unwrap", "()Ljava/lang/Object;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_unwrap), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "unwrap", "()Ljava/lang/Object;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
