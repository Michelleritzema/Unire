using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Oauth.Signpost {

	// Metadata.xml XPath class reference: path="/api/package[@name='oauth.signpost']/class[@name='OAuth']"
	[global::Android.Runtime.Register ("oauth/signpost/OAuth", DoNotGenerateAcw=true)]
	public partial class OAuth : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='oauth.signpost']/class[@name='OAuth']/field[@name='ENCODING']"
		[Register ("ENCODING")]
		public const string Encoding = (string) "UTF-8";

		// Metadata.xml XPath field reference: path="/api/package[@name='oauth.signpost']/class[@name='OAuth']/field[@name='FORM_ENCODED']"
		[Register ("FORM_ENCODED")]
		public const string FormEncoded = (string) "application/x-www-form-urlencoded";

		// Metadata.xml XPath field reference: path="/api/package[@name='oauth.signpost']/class[@name='OAuth']/field[@name='HTTP_AUTHORIZATION_HEADER']"
		[Register ("HTTP_AUTHORIZATION_HEADER")]
		public const string HttpAuthorizationHeader = (string) "Authorization";

		// Metadata.xml XPath field reference: path="/api/package[@name='oauth.signpost']/class[@name='OAuth']/field[@name='OAUTH_CALLBACK']"
		[Register ("OAUTH_CALLBACK")]
		public const string OauthCallback = (string) "oauth_callback";

		// Metadata.xml XPath field reference: path="/api/package[@name='oauth.signpost']/class[@name='OAuth']/field[@name='OAUTH_CALLBACK_CONFIRMED']"
		[Register ("OAUTH_CALLBACK_CONFIRMED")]
		public const string OauthCallbackConfirmed = (string) "oauth_callback_confirmed";

		// Metadata.xml XPath field reference: path="/api/package[@name='oauth.signpost']/class[@name='OAuth']/field[@name='OAUTH_CONSUMER_KEY']"
		[Register ("OAUTH_CONSUMER_KEY")]
		public const string OauthConsumerKey = (string) "oauth_consumer_key";

		// Metadata.xml XPath field reference: path="/api/package[@name='oauth.signpost']/class[@name='OAuth']/field[@name='OAUTH_NONCE']"
		[Register ("OAUTH_NONCE")]
		public const string OauthNonce = (string) "oauth_nonce";

		// Metadata.xml XPath field reference: path="/api/package[@name='oauth.signpost']/class[@name='OAuth']/field[@name='OAUTH_SIGNATURE']"
		[Register ("OAUTH_SIGNATURE")]
		public const string OauthSignature = (string) "oauth_signature";

		// Metadata.xml XPath field reference: path="/api/package[@name='oauth.signpost']/class[@name='OAuth']/field[@name='OAUTH_SIGNATURE_METHOD']"
		[Register ("OAUTH_SIGNATURE_METHOD")]
		public const string OauthSignatureMethod = (string) "oauth_signature_method";

		// Metadata.xml XPath field reference: path="/api/package[@name='oauth.signpost']/class[@name='OAuth']/field[@name='OAUTH_TIMESTAMP']"
		[Register ("OAUTH_TIMESTAMP")]
		public const string OauthTimestamp = (string) "oauth_timestamp";

		// Metadata.xml XPath field reference: path="/api/package[@name='oauth.signpost']/class[@name='OAuth']/field[@name='OAUTH_TOKEN']"
		[Register ("OAUTH_TOKEN")]
		public const string OauthToken = (string) "oauth_token";

		// Metadata.xml XPath field reference: path="/api/package[@name='oauth.signpost']/class[@name='OAuth']/field[@name='OAUTH_TOKEN_SECRET']"
		[Register ("OAUTH_TOKEN_SECRET")]
		public const string OauthTokenSecret = (string) "oauth_token_secret";

		// Metadata.xml XPath field reference: path="/api/package[@name='oauth.signpost']/class[@name='OAuth']/field[@name='OAUTH_VERIFIER']"
		[Register ("OAUTH_VERIFIER")]
		public const string OauthVerifier = (string) "oauth_verifier";

		// Metadata.xml XPath field reference: path="/api/package[@name='oauth.signpost']/class[@name='OAuth']/field[@name='OAUTH_VERSION']"
		[Register ("OAUTH_VERSION")]
		public const string OauthVersion = (string) "oauth_version";

		// Metadata.xml XPath field reference: path="/api/package[@name='oauth.signpost']/class[@name='OAuth']/field[@name='OUT_OF_BAND']"
		[Register ("OUT_OF_BAND")]
		public const string OutOfBand = (string) "oob";

		// Metadata.xml XPath field reference: path="/api/package[@name='oauth.signpost']/class[@name='OAuth']/field[@name='VERSION_1_0']"
		[Register ("VERSION_1_0")]
		public const string Version10 = (string) "1.0";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("oauth/signpost/OAuth", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OAuth); }
		}

		protected OAuth (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='oauth.signpost']/class[@name='OAuth']/constructor[@name='OAuth' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe OAuth ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (OAuth)) {
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

		static IntPtr id_addQueryParameters_Ljava_lang_String_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost']/class[@name='OAuth']/method[@name='addQueryParameters' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String...']]"
		[Register ("addQueryParameters", "(Ljava/lang/String;[Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string AddQueryParameters (string p0, params  string[] p1)
		{
			if (id_addQueryParameters_Ljava_lang_String_arrayLjava_lang_String_ == IntPtr.Zero)
				id_addQueryParameters_Ljava_lang_String_arrayLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "addQueryParameters", "(Ljava/lang/String;[Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_addQueryParameters_Ljava_lang_String_arrayLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_addQueryParameters_Ljava_lang_String_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost']/class[@name='OAuth']/method[@name='addQueryParameters' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("addQueryParameters", "(Ljava/lang/String;Ljava/util/Map;)Ljava/lang/String;", "")]
		public static unsafe string AddQueryParameters (string p0, global::System.Collections.Generic.IDictionary<string, string> p1)
		{
			if (id_addQueryParameters_Ljava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
				id_addQueryParameters_Ljava_lang_String_Ljava_util_Map_ = JNIEnv.GetStaticMethodID (class_ref, "addQueryParameters", "(Ljava/lang/String;Ljava/util/Map;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_addQueryParameters_Ljava_lang_String_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_addQueryString_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost']/class[@name='OAuth']/method[@name='addQueryString' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("addQueryString", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string AddQueryString (string p0, string p1)
		{
			if (id_addQueryString_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_addQueryString_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "addQueryString", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_addQueryString_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_debugOut_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost']/class[@name='OAuth']/method[@name='debugOut' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("debugOut", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void DebugOut (string p0, string p1)
		{
			if (id_debugOut_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_debugOut_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "debugOut", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_debugOut_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_decodeForm_Ljava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost']/class[@name='OAuth']/method[@name='decodeForm' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("decodeForm", "(Ljava/io/InputStream;)Loauth/signpost/http/HttpParameters;", "")]
		public static unsafe global::Oauth.Signpost.Http.HttpParameters DecodeForm (global::System.IO.Stream p0)
		{
			if (id_decodeForm_Ljava_io_InputStream_ == IntPtr.Zero)
				id_decodeForm_Ljava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "decodeForm", "(Ljava/io/InputStream;)Loauth/signpost/http/HttpParameters;");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Oauth.Signpost.Http.HttpParameters __ret = global::Java.Lang.Object.GetObject<global::Oauth.Signpost.Http.HttpParameters> (JNIEnv.CallStaticObjectMethod  (class_ref, id_decodeForm_Ljava_io_InputStream_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_decodeForm_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost']/class[@name='OAuth']/method[@name='decodeForm' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("decodeForm", "(Ljava/lang/String;)Loauth/signpost/http/HttpParameters;", "")]
		public static unsafe global::Oauth.Signpost.Http.HttpParameters DecodeForm (string p0)
		{
			if (id_decodeForm_Ljava_lang_String_ == IntPtr.Zero)
				id_decodeForm_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "decodeForm", "(Ljava/lang/String;)Loauth/signpost/http/HttpParameters;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Oauth.Signpost.Http.HttpParameters __ret = global::Java.Lang.Object.GetObject<global::Oauth.Signpost.Http.HttpParameters> (JNIEnv.CallStaticObjectMethod  (class_ref, id_decodeForm_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_formEncode_Ljava_util_Collection_;
		// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost']/class[@name='OAuth']/method[@name='formEncode' and count(parameter)=1 and parameter[1][@type='java.util.Collection&lt;T&gt;']]"
		[Register ("formEncode", "(Ljava/util/Collection;)Ljava/lang/String;", "")]
		public static unsafe string FormEncode (global::System.Collections.ICollection p0)
		{
			if (id_formEncode_Ljava_util_Collection_ == IntPtr.Zero)
				id_formEncode_Ljava_util_Collection_ = JNIEnv.GetStaticMethodID (class_ref, "formEncode", "(Ljava/util/Collection;)Ljava/lang/String;");
			IntPtr native_p0 = global::Android.Runtime.JavaCollection.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_formEncode_Ljava_util_Collection_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_formEncode_Ljava_util_Collection_Ljava_io_OutputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost']/class[@name='OAuth']/method[@name='formEncode' and count(parameter)=2 and parameter[1][@type='java.util.Collection&lt;T&gt;'] and parameter[2][@type='java.io.OutputStream']]"
		[Register ("formEncode", "(Ljava/util/Collection;Ljava/io/OutputStream;)V", "")]
		public static unsafe void FormEncode (global::System.Collections.ICollection p0, global::System.IO.Stream p1)
		{
			if (id_formEncode_Ljava_util_Collection_Ljava_io_OutputStream_ == IntPtr.Zero)
				id_formEncode_Ljava_util_Collection_Ljava_io_OutputStream_ = JNIEnv.GetStaticMethodID (class_ref, "formEncode", "(Ljava/util/Collection;Ljava/io/OutputStream;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaCollection.ToLocalJniHandle (p0);
			IntPtr native_p1 = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_formEncode_Ljava_util_Collection_Ljava_io_OutputStream_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_isEmpty_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost']/class[@name='OAuth']/method[@name='isEmpty' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isEmpty", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool IsEmpty (string p0)
		{
			if (id_isEmpty_Ljava_lang_String_ == IntPtr.Zero)
				id_isEmpty_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "isEmpty", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isEmpty_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_oauthHeaderToParamsMap_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost']/class[@name='OAuth']/method[@name='oauthHeaderToParamsMap' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("oauthHeaderToParamsMap", "(Ljava/lang/String;)Loauth/signpost/http/HttpParameters;", "")]
		public static unsafe global::Oauth.Signpost.Http.HttpParameters OauthHeaderToParamsMap (string p0)
		{
			if (id_oauthHeaderToParamsMap_Ljava_lang_String_ == IntPtr.Zero)
				id_oauthHeaderToParamsMap_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "oauthHeaderToParamsMap", "(Ljava/lang/String;)Loauth/signpost/http/HttpParameters;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Oauth.Signpost.Http.HttpParameters __ret = global::Java.Lang.Object.GetObject<global::Oauth.Signpost.Http.HttpParameters> (JNIEnv.CallStaticObjectMethod  (class_ref, id_oauthHeaderToParamsMap_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_percentDecode_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost']/class[@name='OAuth']/method[@name='percentDecode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("percentDecode", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string PercentDecode (string p0)
		{
			if (id_percentDecode_Ljava_lang_String_ == IntPtr.Zero)
				id_percentDecode_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "percentDecode", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_percentDecode_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_percentEncode_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost']/class[@name='OAuth']/method[@name='percentEncode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("percentEncode", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string PercentEncode (string p0)
		{
			if (id_percentEncode_Ljava_lang_String_ == IntPtr.Zero)
				id_percentEncode_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "percentEncode", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_percentEncode_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_prepareOAuthHeader_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost']/class[@name='OAuth']/method[@name='prepareOAuthHeader' and count(parameter)=1 and parameter[1][@type='java.lang.String...']]"
		[Register ("prepareOAuthHeader", "([Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string PrepareOAuthHeader (params  string[] p0)
		{
			if (id_prepareOAuthHeader_arrayLjava_lang_String_ == IntPtr.Zero)
				id_prepareOAuthHeader_arrayLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "prepareOAuthHeader", "([Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_prepareOAuthHeader_arrayLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_safeToString_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost']/class[@name='OAuth']/method[@name='safeToString' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("safeToString", "(Ljava/lang/Object;)Ljava/lang/String;", "")]
		public static unsafe string SafeToString (global::Java.Lang.Object p0)
		{
			if (id_safeToString_Ljava_lang_Object_ == IntPtr.Zero)
				id_safeToString_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "safeToString", "(Ljava/lang/Object;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_safeToString_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_toHeaderElement_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost']/class[@name='OAuth']/method[@name='toHeaderElement' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("toHeaderElement", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string ToHeaderElement (string p0, string p1)
		{
			if (id_toHeaderElement_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_toHeaderElement_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "toHeaderElement", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_toHeaderElement_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_toMap_Ljava_util_Collection_;
		// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost']/class[@name='OAuth']/method[@name='toMap' and count(parameter)=1 and parameter[1][@type='java.util.Collection&lt;T&gt;']]"
		[Register ("toMap", "(Ljava/util/Collection;)Ljava/util/Map;", "")]
		public static unsafe global::System.Collections.Generic.IDictionary<string, string> ToMap (global::System.Collections.ICollection p0)
		{
			if (id_toMap_Ljava_util_Collection_ == IntPtr.Zero)
				id_toMap_Ljava_util_Collection_ = JNIEnv.GetStaticMethodID (class_ref, "toMap", "(Ljava/util/Collection;)Ljava/util/Map;");
			IntPtr native_p0 = global::Android.Runtime.JavaCollection.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::System.Collections.Generic.IDictionary<string, string> __ret = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_toMap_Ljava_util_Collection_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
