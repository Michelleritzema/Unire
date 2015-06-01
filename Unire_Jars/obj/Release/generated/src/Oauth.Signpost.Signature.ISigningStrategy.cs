using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Oauth.Signpost.Signature {

	// Metadata.xml XPath interface reference: path="/api/package[@name='oauth.signpost.signature']/interface[@name='SigningStrategy']"
	[Register ("oauth/signpost/signature/SigningStrategy", "", "Oauth.Signpost.Signature.ISigningStrategyInvoker")]
	public partial interface ISigningStrategy : global::Java.IO.ISerializable {

		// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost.signature']/interface[@name='SigningStrategy']/method[@name='writeSignature' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='oauth.signpost.http.HttpRequest'] and parameter[3][@type='oauth.signpost.http.HttpParameters']]"
		[Register ("writeSignature", "(Ljava/lang/String;Loauth/signpost/http/HttpRequest;Loauth/signpost/http/HttpParameters;)Ljava/lang/String;", "GetWriteSignature_Ljava_lang_String_Loauth_signpost_http_HttpRequest_Loauth_signpost_http_HttpParameters_Handler:Oauth.Signpost.Signature.ISigningStrategyInvoker, Unire_Jars")]
		string WriteSignature (string p0, global::Oauth.Signpost.Http.IHttpRequest p1, global::Oauth.Signpost.Http.HttpParameters p2);

	}

	[global::Android.Runtime.Register ("oauth/signpost/signature/SigningStrategy", DoNotGenerateAcw=true)]
	internal class ISigningStrategyInvoker : global::Java.Lang.Object, ISigningStrategy {

		static IntPtr java_class_ref = JNIEnv.FindClass ("oauth/signpost/signature/SigningStrategy");
		IntPtr class_ref;

		public static ISigningStrategy GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISigningStrategy> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "oauth.signpost.signature.SigningStrategy"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISigningStrategyInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (ISigningStrategyInvoker); }
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
			global::Oauth.Signpost.Signature.ISigningStrategy __this = global::Java.Lang.Object.GetObject<global::Oauth.Signpost.Signature.ISigningStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Oauth.Signpost.Http.IHttpRequest p1 = (global::Oauth.Signpost.Http.IHttpRequest)global::Java.Lang.Object.GetObject<global::Oauth.Signpost.Http.IHttpRequest> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Oauth.Signpost.Http.HttpParameters p2 = global::Java.Lang.Object.GetObject<global::Oauth.Signpost.Http.HttpParameters> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.WriteSignature (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_writeSignature_Ljava_lang_String_Loauth_signpost_http_HttpRequest_Loauth_signpost_http_HttpParameters_;
		public unsafe string WriteSignature (string p0, global::Oauth.Signpost.Http.IHttpRequest p1, global::Oauth.Signpost.Http.HttpParameters p2)
		{
			if (id_writeSignature_Ljava_lang_String_Loauth_signpost_http_HttpRequest_Loauth_signpost_http_HttpParameters_ == IntPtr.Zero)
				id_writeSignature_Ljava_lang_String_Loauth_signpost_http_HttpRequest_Loauth_signpost_http_HttpParameters_ = JNIEnv.GetMethodID (class_ref, "writeSignature", "(Ljava/lang/String;Loauth/signpost/http/HttpRequest;Loauth/signpost/http/HttpParameters;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_writeSignature_Ljava_lang_String_Loauth_signpost_http_HttpRequest_Loauth_signpost_http_HttpParameters_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}

}
