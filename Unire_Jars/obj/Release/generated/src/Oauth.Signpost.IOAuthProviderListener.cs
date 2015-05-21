using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Oauth.Signpost {

	// Metadata.xml XPath interface reference: path="/api/package[@name='oauth.signpost']/interface[@name='OAuthProviderListener']"
	[Register ("oauth/signpost/OAuthProviderListener", "", "Oauth.Signpost.IOAuthProviderListenerInvoker")]
	public partial interface IOAuthProviderListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost']/interface[@name='OAuthProviderListener']/method[@name='onResponseReceived' and count(parameter)=2 and parameter[1][@type='oauth.signpost.http.HttpRequest'] and parameter[2][@type='oauth.signpost.http.HttpResponse']]"
		[Register ("onResponseReceived", "(Loauth/signpost/http/HttpRequest;Loauth/signpost/http/HttpResponse;)Z", "GetOnResponseReceived_Loauth_signpost_http_HttpRequest_Loauth_signpost_http_HttpResponse_Handler:Oauth.Signpost.IOAuthProviderListenerInvoker, Unire_Jars")]
		bool OnResponseReceived (global::Oauth.Signpost.Http.IHttpRequest p0, global::Oauth.Signpost.Http.IHttpResponse p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost']/interface[@name='OAuthProviderListener']/method[@name='prepareRequest' and count(parameter)=1 and parameter[1][@type='oauth.signpost.http.HttpRequest']]"
		[Register ("prepareRequest", "(Loauth/signpost/http/HttpRequest;)V", "GetPrepareRequest_Loauth_signpost_http_HttpRequest_Handler:Oauth.Signpost.IOAuthProviderListenerInvoker, Unire_Jars")]
		void PrepareRequest (global::Oauth.Signpost.Http.IHttpRequest p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost']/interface[@name='OAuthProviderListener']/method[@name='prepareSubmission' and count(parameter)=1 and parameter[1][@type='oauth.signpost.http.HttpRequest']]"
		[Register ("prepareSubmission", "(Loauth/signpost/http/HttpRequest;)V", "GetPrepareSubmission_Loauth_signpost_http_HttpRequest_Handler:Oauth.Signpost.IOAuthProviderListenerInvoker, Unire_Jars")]
		void PrepareSubmission (global::Oauth.Signpost.Http.IHttpRequest p0);

	}

	[global::Android.Runtime.Register ("oauth/signpost/OAuthProviderListener", DoNotGenerateAcw=true)]
	internal class IOAuthProviderListenerInvoker : global::Java.Lang.Object, IOAuthProviderListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("oauth/signpost/OAuthProviderListener");
		IntPtr class_ref;

		public static IOAuthProviderListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOAuthProviderListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "oauth.signpost.OAuthProviderListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOAuthProviderListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IOAuthProviderListenerInvoker); }
		}

		static Delegate cb_onResponseReceived_Loauth_signpost_http_HttpRequest_Loauth_signpost_http_HttpResponse_;
#pragma warning disable 0169
		static Delegate GetOnResponseReceived_Loauth_signpost_http_HttpRequest_Loauth_signpost_http_HttpResponse_Handler ()
		{
			if (cb_onResponseReceived_Loauth_signpost_http_HttpRequest_Loauth_signpost_http_HttpResponse_ == null)
				cb_onResponseReceived_Loauth_signpost_http_HttpRequest_Loauth_signpost_http_HttpResponse_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_OnResponseReceived_Loauth_signpost_http_HttpRequest_Loauth_signpost_http_HttpResponse_);
			return cb_onResponseReceived_Loauth_signpost_http_HttpRequest_Loauth_signpost_http_HttpResponse_;
		}

		static bool n_OnResponseReceived_Loauth_signpost_http_HttpRequest_Loauth_signpost_http_HttpResponse_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Oauth.Signpost.IOAuthProviderListener __this = global::Java.Lang.Object.GetObject<global::Oauth.Signpost.IOAuthProviderListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Oauth.Signpost.Http.IHttpRequest p0 = (global::Oauth.Signpost.Http.IHttpRequest)global::Java.Lang.Object.GetObject<global::Oauth.Signpost.Http.IHttpRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Oauth.Signpost.Http.IHttpResponse p1 = (global::Oauth.Signpost.Http.IHttpResponse)global::Java.Lang.Object.GetObject<global::Oauth.Signpost.Http.IHttpResponse> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnResponseReceived (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_onResponseReceived_Loauth_signpost_http_HttpRequest_Loauth_signpost_http_HttpResponse_;
		public unsafe bool OnResponseReceived (global::Oauth.Signpost.Http.IHttpRequest p0, global::Oauth.Signpost.Http.IHttpResponse p1)
		{
			if (id_onResponseReceived_Loauth_signpost_http_HttpRequest_Loauth_signpost_http_HttpResponse_ == IntPtr.Zero)
				id_onResponseReceived_Loauth_signpost_http_HttpRequest_Loauth_signpost_http_HttpResponse_ = JNIEnv.GetMethodID (class_ref, "onResponseReceived", "(Loauth/signpost/http/HttpRequest;Loauth/signpost/http/HttpResponse;)Z");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			bool __ret = JNIEnv.CallBooleanMethod (Handle, id_onResponseReceived_Loauth_signpost_http_HttpRequest_Loauth_signpost_http_HttpResponse_, __args);
			return __ret;
		}

		static Delegate cb_prepareRequest_Loauth_signpost_http_HttpRequest_;
#pragma warning disable 0169
		static Delegate GetPrepareRequest_Loauth_signpost_http_HttpRequest_Handler ()
		{
			if (cb_prepareRequest_Loauth_signpost_http_HttpRequest_ == null)
				cb_prepareRequest_Loauth_signpost_http_HttpRequest_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PrepareRequest_Loauth_signpost_http_HttpRequest_);
			return cb_prepareRequest_Loauth_signpost_http_HttpRequest_;
		}

		static void n_PrepareRequest_Loauth_signpost_http_HttpRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Oauth.Signpost.IOAuthProviderListener __this = global::Java.Lang.Object.GetObject<global::Oauth.Signpost.IOAuthProviderListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Oauth.Signpost.Http.IHttpRequest p0 = (global::Oauth.Signpost.Http.IHttpRequest)global::Java.Lang.Object.GetObject<global::Oauth.Signpost.Http.IHttpRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PrepareRequest (p0);
		}
#pragma warning restore 0169

		IntPtr id_prepareRequest_Loauth_signpost_http_HttpRequest_;
		public unsafe void PrepareRequest (global::Oauth.Signpost.Http.IHttpRequest p0)
		{
			if (id_prepareRequest_Loauth_signpost_http_HttpRequest_ == IntPtr.Zero)
				id_prepareRequest_Loauth_signpost_http_HttpRequest_ = JNIEnv.GetMethodID (class_ref, "prepareRequest", "(Loauth/signpost/http/HttpRequest;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_prepareRequest_Loauth_signpost_http_HttpRequest_, __args);
		}

		static Delegate cb_prepareSubmission_Loauth_signpost_http_HttpRequest_;
#pragma warning disable 0169
		static Delegate GetPrepareSubmission_Loauth_signpost_http_HttpRequest_Handler ()
		{
			if (cb_prepareSubmission_Loauth_signpost_http_HttpRequest_ == null)
				cb_prepareSubmission_Loauth_signpost_http_HttpRequest_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PrepareSubmission_Loauth_signpost_http_HttpRequest_);
			return cb_prepareSubmission_Loauth_signpost_http_HttpRequest_;
		}

		static void n_PrepareSubmission_Loauth_signpost_http_HttpRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Oauth.Signpost.IOAuthProviderListener __this = global::Java.Lang.Object.GetObject<global::Oauth.Signpost.IOAuthProviderListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Oauth.Signpost.Http.IHttpRequest p0 = (global::Oauth.Signpost.Http.IHttpRequest)global::Java.Lang.Object.GetObject<global::Oauth.Signpost.Http.IHttpRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PrepareSubmission (p0);
		}
#pragma warning restore 0169

		IntPtr id_prepareSubmission_Loauth_signpost_http_HttpRequest_;
		public unsafe void PrepareSubmission (global::Oauth.Signpost.Http.IHttpRequest p0)
		{
			if (id_prepareSubmission_Loauth_signpost_http_HttpRequest_ == IntPtr.Zero)
				id_prepareSubmission_Loauth_signpost_http_HttpRequest_ = JNIEnv.GetMethodID (class_ref, "prepareSubmission", "(Loauth/signpost/http/HttpRequest;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_prepareSubmission_Loauth_signpost_http_HttpRequest_, __args);
		}

	}

	public partial class ResponseReceivedEventArgs : global::System.EventArgs {

		public ResponseReceivedEventArgs (bool handled, global::Oauth.Signpost.Http.IHttpRequest p0, global::Oauth.Signpost.Http.IHttpResponse p1)
		{
			this.handled = handled;
			this.p0 = p0;
			this.p1 = p1;
		}

		bool handled;
		public bool Handled {
			get { return handled; }
			set { handled = value; }
		}

		global::Oauth.Signpost.Http.IHttpRequest p0;
		public global::Oauth.Signpost.Http.IHttpRequest P0 {
			get { return p0; }
		}

		global::Oauth.Signpost.Http.IHttpResponse p1;
		public global::Oauth.Signpost.Http.IHttpResponse P1 {
			get { return p1; }
		}
	}

	public partial class PrepareRequestEventArgs : global::System.EventArgs {

		public PrepareRequestEventArgs (global::Oauth.Signpost.Http.IHttpRequest p0)
		{
			this.p0 = p0;
		}

		global::Oauth.Signpost.Http.IHttpRequest p0;
		public global::Oauth.Signpost.Http.IHttpRequest P0 {
			get { return p0; }
		}
	}

	public partial class PrepareSubmissionEventArgs : global::System.EventArgs {

		public PrepareSubmissionEventArgs (global::Oauth.Signpost.Http.IHttpRequest p0)
		{
			this.p0 = p0;
		}

		global::Oauth.Signpost.Http.IHttpRequest p0;
		public global::Oauth.Signpost.Http.IHttpRequest P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/oauth/signpost/OAuthProviderListenerImplementor")]
	internal sealed partial class IOAuthProviderListenerImplementor : global::Java.Lang.Object, IOAuthProviderListener {

		object sender;

		public IOAuthProviderListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/oauth/signpost/OAuthProviderListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<ResponseReceivedEventArgs> OnResponseReceivedHandler;
#pragma warning restore 0649

		public bool OnResponseReceived (global::Oauth.Signpost.Http.IHttpRequest p0, global::Oauth.Signpost.Http.IHttpResponse p1)
		{
			var __h = OnResponseReceivedHandler;
			if (__h == null)
				return false;
			var __e = new ResponseReceivedEventArgs (true, p0, p1);
			__h (sender, __e);
			return __e.Handled;
		}
#pragma warning disable 0649
		public EventHandler<PrepareRequestEventArgs> PrepareRequestHandler;
#pragma warning restore 0649

		public void PrepareRequest (global::Oauth.Signpost.Http.IHttpRequest p0)
		{
			var __h = PrepareRequestHandler;
			if (__h != null)
				__h (sender, new PrepareRequestEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<PrepareSubmissionEventArgs> PrepareSubmissionHandler;
#pragma warning restore 0649

		public void PrepareSubmission (global::Oauth.Signpost.Http.IHttpRequest p0)
		{
			var __h = PrepareSubmissionHandler;
			if (__h != null)
				__h (sender, new PrepareSubmissionEventArgs (p0));
		}

		internal static bool __IsEmpty (IOAuthProviderListenerImplementor value)
		{
			return value.OnResponseReceivedHandler == null && value.PrepareRequestHandler == null && value.PrepareSubmissionHandler == null;
		}
	}

}
