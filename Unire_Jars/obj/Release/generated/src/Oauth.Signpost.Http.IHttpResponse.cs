using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Oauth.Signpost.Http {

	// Metadata.xml XPath interface reference: path="/api/package[@name='oauth.signpost.http']/interface[@name='HttpResponse']"
	[Register ("oauth/signpost/http/HttpResponse", "", "Oauth.Signpost.Http.IHttpResponseInvoker")]
	public partial interface IHttpResponse : IJavaObject {

		global::System.IO.Stream Content {
			// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost.http']/interface[@name='HttpResponse']/method[@name='getContent' and count(parameter)=0]"
			[Register ("getContent", "()Ljava/io/InputStream;", "GetGetContentHandler:Oauth.Signpost.Http.IHttpResponseInvoker, Unire_Jars")] get;
		}

		string ReasonPhrase {
			// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost.http']/interface[@name='HttpResponse']/method[@name='getReasonPhrase' and count(parameter)=0]"
			[Register ("getReasonPhrase", "()Ljava/lang/String;", "GetGetReasonPhraseHandler:Oauth.Signpost.Http.IHttpResponseInvoker, Unire_Jars")] get;
		}

		int StatusCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost.http']/interface[@name='HttpResponse']/method[@name='getStatusCode' and count(parameter)=0]"
			[Register ("getStatusCode", "()I", "GetGetStatusCodeHandler:Oauth.Signpost.Http.IHttpResponseInvoker, Unire_Jars")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost.http']/interface[@name='HttpResponse']/method[@name='unwrap' and count(parameter)=0]"
		[Register ("unwrap", "()Ljava/lang/Object;", "GetUnwrapHandler:Oauth.Signpost.Http.IHttpResponseInvoker, Unire_Jars")]
		global::Java.Lang.Object Unwrap ();

	}

	[global::Android.Runtime.Register ("oauth/signpost/http/HttpResponse", DoNotGenerateAcw=true)]
	internal class IHttpResponseInvoker : global::Java.Lang.Object, IHttpResponse {

		static IntPtr java_class_ref = JNIEnv.FindClass ("oauth/signpost/http/HttpResponse");
		IntPtr class_ref;

		public static IHttpResponse GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IHttpResponse> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "oauth.signpost.http.HttpResponse"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IHttpResponseInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IHttpResponseInvoker); }
		}

		static Delegate cb_getContent;
#pragma warning disable 0169
		static Delegate GetGetContentHandler ()
		{
			if (cb_getContent == null)
				cb_getContent = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContent);
			return cb_getContent;
		}

		static IntPtr n_GetContent (IntPtr jnienv, IntPtr native__this)
		{
			global::Oauth.Signpost.Http.IHttpResponse __this = global::Java.Lang.Object.GetObject<global::Oauth.Signpost.Http.IHttpResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.Content);
		}
#pragma warning restore 0169

		IntPtr id_getContent;
		public unsafe global::System.IO.Stream Content {
			get {
				if (id_getContent == IntPtr.Zero)
					id_getContent = JNIEnv.GetMethodID (class_ref, "getContent", "()Ljava/io/InputStream;");
				return global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod (Handle, id_getContent), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getReasonPhrase;
#pragma warning disable 0169
		static Delegate GetGetReasonPhraseHandler ()
		{
			if (cb_getReasonPhrase == null)
				cb_getReasonPhrase = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetReasonPhrase);
			return cb_getReasonPhrase;
		}

		static IntPtr n_GetReasonPhrase (IntPtr jnienv, IntPtr native__this)
		{
			global::Oauth.Signpost.Http.IHttpResponse __this = global::Java.Lang.Object.GetObject<global::Oauth.Signpost.Http.IHttpResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ReasonPhrase);
		}
#pragma warning restore 0169

		IntPtr id_getReasonPhrase;
		public unsafe string ReasonPhrase {
			get {
				if (id_getReasonPhrase == IntPtr.Zero)
					id_getReasonPhrase = JNIEnv.GetMethodID (class_ref, "getReasonPhrase", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getReasonPhrase), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getStatusCode;
#pragma warning disable 0169
		static Delegate GetGetStatusCodeHandler ()
		{
			if (cb_getStatusCode == null)
				cb_getStatusCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetStatusCode);
			return cb_getStatusCode;
		}

		static int n_GetStatusCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Oauth.Signpost.Http.IHttpResponse __this = global::Java.Lang.Object.GetObject<global::Oauth.Signpost.Http.IHttpResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StatusCode;
		}
#pragma warning restore 0169

		IntPtr id_getStatusCode;
		public unsafe int StatusCode {
			get {
				if (id_getStatusCode == IntPtr.Zero)
					id_getStatusCode = JNIEnv.GetMethodID (class_ref, "getStatusCode", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getStatusCode);
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
			global::Oauth.Signpost.Http.IHttpResponse __this = global::Java.Lang.Object.GetObject<global::Oauth.Signpost.Http.IHttpResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
