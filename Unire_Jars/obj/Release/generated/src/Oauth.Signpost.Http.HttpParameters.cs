using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Oauth.Signpost.Http {

	// Metadata.xml XPath class reference: path="/api/package[@name='oauth.signpost.http']/class[@name='HttpParameters']"
	[global::Android.Runtime.Register ("oauth/signpost/http/HttpParameters", DoNotGenerateAcw=true)]
	public partial class HttpParameters : global::Java.Lang.Object, global::Java.IO.ISerializable, global::Java.Util.IMap {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("oauth/signpost/http/HttpParameters", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HttpParameters); }
		}

		protected HttpParameters (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='oauth.signpost.http']/class[@name='HttpParameters']/constructor[@name='HttpParameters' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe HttpParameters ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (HttpParameters)) {
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

		static Delegate cb_isEmpty;
#pragma warning disable 0169
		static Delegate GetIsEmptyHandler ()
		{
			if (cb_isEmpty == null)
				cb_isEmpty = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsEmpty);
			return cb_isEmpty;
		}

		static bool n_IsEmpty (IntPtr jnienv, IntPtr native__this)
		{
			global::Oauth.Signpost.Http.HttpParameters __this = global::Java.Lang.Object.GetObject<global::Oauth.Signpost.Http.HttpParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEmpty;
		}
#pragma warning restore 0169

		static IntPtr id_isEmpty;
		public virtual unsafe bool IsEmpty {
			// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost.http']/class[@name='HttpParameters']/method[@name='isEmpty' and count(parameter)=0]"
			[Register ("isEmpty", "()Z", "GetIsEmptyHandler")]
			get {
				if (id_isEmpty == IntPtr.Zero)
					id_isEmpty = JNIEnv.GetMethodID (class_ref, "isEmpty", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isEmpty);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isEmpty", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getOAuthParameters;
#pragma warning disable 0169
		static Delegate GetGetOAuthParametersHandler ()
		{
			if (cb_getOAuthParameters == null)
				cb_getOAuthParameters = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOAuthParameters);
			return cb_getOAuthParameters;
		}

		static IntPtr n_GetOAuthParameters (IntPtr jnienv, IntPtr native__this)
		{
			global::Oauth.Signpost.Http.HttpParameters __this = global::Java.Lang.Object.GetObject<global::Oauth.Signpost.Http.HttpParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OAuthParameters);
		}
#pragma warning restore 0169

		static IntPtr id_getOAuthParameters;
		public virtual unsafe global::Oauth.Signpost.Http.HttpParameters OAuthParameters {
			// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost.http']/class[@name='HttpParameters']/method[@name='getOAuthParameters' and count(parameter)=0]"
			[Register ("getOAuthParameters", "()Loauth/signpost/http/HttpParameters;", "GetGetOAuthParametersHandler")]
			get {
				if (id_getOAuthParameters == IntPtr.Zero)
					id_getOAuthParameters = JNIEnv.GetMethodID (class_ref, "getOAuthParameters", "()Loauth/signpost/http/HttpParameters;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Oauth.Signpost.Http.HttpParameters> (JNIEnv.CallObjectMethod  (Handle, id_getOAuthParameters), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Oauth.Signpost.Http.HttpParameters> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOAuthParameters", "()Loauth/signpost/http/HttpParameters;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Clear);
			return cb_clear;
		}

		static void n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			global::Oauth.Signpost.Http.HttpParameters __this = global::Java.Lang.Object.GetObject<global::Oauth.Signpost.Http.HttpParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		static IntPtr id_clear;
		// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost.http']/class[@name='HttpParameters']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler")]
		public virtual unsafe void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_clear);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clear", "()V"));
			} finally {
			}
		}

		static Delegate cb_containsKey_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetContainsKey_Ljava_lang_Object_Handler ()
		{
			if (cb_containsKey_Ljava_lang_Object_ == null)
				cb_containsKey_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_ContainsKey_Ljava_lang_Object_);
			return cb_containsKey_Ljava_lang_Object_;
		}

		static bool n_ContainsKey_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Oauth.Signpost.Http.HttpParameters __this = global::Java.Lang.Object.GetObject<global::Oauth.Signpost.Http.HttpParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ContainsKey (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_containsKey_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost.http']/class[@name='HttpParameters']/method[@name='containsKey' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("containsKey", "(Ljava/lang/Object;)Z", "GetContainsKey_Ljava_lang_Object_Handler")]
		public virtual unsafe bool ContainsKey (global::Java.Lang.Object p0)
		{
			if (id_containsKey_Ljava_lang_Object_ == IntPtr.Zero)
				id_containsKey_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "containsKey", "(Ljava/lang/Object;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_containsKey_Ljava_lang_Object_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "containsKey", "(Ljava/lang/Object;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_containsValue_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetContainsValue_Ljava_lang_Object_Handler ()
		{
			if (cb_containsValue_Ljava_lang_Object_ == null)
				cb_containsValue_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_ContainsValue_Ljava_lang_Object_);
			return cb_containsValue_Ljava_lang_Object_;
		}

		static bool n_ContainsValue_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Oauth.Signpost.Http.HttpParameters __this = global::Java.Lang.Object.GetObject<global::Oauth.Signpost.Http.HttpParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ContainsValue (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_containsValue_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost.http']/class[@name='HttpParameters']/method[@name='containsValue' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("containsValue", "(Ljava/lang/Object;)Z", "GetContainsValue_Ljava_lang_Object_Handler")]
		public virtual unsafe bool ContainsValue (global::Java.Lang.Object p0)
		{
			if (id_containsValue_Ljava_lang_Object_ == IntPtr.Zero)
				id_containsValue_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "containsValue", "(Ljava/lang/Object;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_containsValue_Ljava_lang_Object_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "containsValue", "(Ljava/lang/Object;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_entrySet;
#pragma warning disable 0169
		static Delegate GetEntrySetHandler ()
		{
			if (cb_entrySet == null)
				cb_entrySet = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_EntrySet);
			return cb_entrySet;
		}

		static IntPtr n_EntrySet (IntPtr jnienv, IntPtr native__this)
		{
			global::Oauth.Signpost.Http.HttpParameters __this = global::Java.Lang.Object.GetObject<global::Oauth.Signpost.Http.HttpParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<global::Java.Util.IMapEntry>.ToLocalJniHandle (__this.EntrySet ());
		}
#pragma warning restore 0169

		static IntPtr id_entrySet;
		// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost.http']/class[@name='HttpParameters']/method[@name='entrySet' and count(parameter)=0]"
		[Register ("entrySet", "()Ljava/util/Set;", "GetEntrySetHandler")]
		public virtual unsafe global::System.Collections.Generic.ICollection<global::Java.Util.IMapEntry> EntrySet ()
		{
			if (id_entrySet == IntPtr.Zero)
				id_entrySet = JNIEnv.GetMethodID (class_ref, "entrySet", "()Ljava/util/Set;");
			try {

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaSet<global::Java.Util.IMapEntry>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_entrySet), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaSet<global::Java.Util.IMapEntry>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "entrySet", "()Ljava/util/Set;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_get_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetGet_Ljava_lang_Object_Handler ()
		{
			if (cb_get_Ljava_lang_Object_ == null)
				cb_get_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Get_Ljava_lang_Object_);
			return cb_get_Ljava_lang_Object_;
		}

		static IntPtr n_Get_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Oauth.Signpost.Http.HttpParameters __this = global::Java.Lang.Object.GetObject<global::Oauth.Signpost.Http.HttpParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_get_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost.http']/class[@name='HttpParameters']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("get", "(Ljava/lang/Object;)Ljava/util/SortedSet;", "GetGet_Ljava_lang_Object_Handler")]
		public virtual unsafe global::Java.Util.ISortedSet Get (global::Java.Lang.Object p0)
		{
			if (id_get_Ljava_lang_Object_ == IntPtr.Zero)
				id_get_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "get", "(Ljava/lang/Object;)Ljava/util/SortedSet;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Java.Util.ISortedSet __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Util.ISortedSet> (JNIEnv.CallObjectMethod  (Handle, id_get_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Util.ISortedSet> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "(Ljava/lang/Object;)Ljava/util/SortedSet;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getAsHeaderElement_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetAsHeaderElement_Ljava_lang_String_Handler ()
		{
			if (cb_getAsHeaderElement_Ljava_lang_String_ == null)
				cb_getAsHeaderElement_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetAsHeaderElement_Ljava_lang_String_);
			return cb_getAsHeaderElement_Ljava_lang_String_;
		}

		static IntPtr n_GetAsHeaderElement_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Oauth.Signpost.Http.HttpParameters __this = global::Java.Lang.Object.GetObject<global::Oauth.Signpost.Http.HttpParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetAsHeaderElement (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getAsHeaderElement_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost.http']/class[@name='HttpParameters']/method[@name='getAsHeaderElement' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getAsHeaderElement", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetAsHeaderElement_Ljava_lang_String_Handler")]
		public virtual unsafe string GetAsHeaderElement (string p0)
		{
			if (id_getAsHeaderElement_Ljava_lang_String_ == IntPtr.Zero)
				id_getAsHeaderElement_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getAsHeaderElement", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getAsHeaderElement_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAsHeaderElement", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getAsQueryString_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetGetAsQueryString_Ljava_lang_Object_Handler ()
		{
			if (cb_getAsQueryString_Ljava_lang_Object_ == null)
				cb_getAsQueryString_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetAsQueryString_Ljava_lang_Object_);
			return cb_getAsQueryString_Ljava_lang_Object_;
		}

		static IntPtr n_GetAsQueryString_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Oauth.Signpost.Http.HttpParameters __this = global::Java.Lang.Object.GetObject<global::Oauth.Signpost.Http.HttpParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetAsQueryString (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getAsQueryString_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost.http']/class[@name='HttpParameters']/method[@name='getAsQueryString' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("getAsQueryString", "(Ljava/lang/Object;)Ljava/lang/String;", "GetGetAsQueryString_Ljava_lang_Object_Handler")]
		public virtual unsafe string GetAsQueryString (global::Java.Lang.Object p0)
		{
			if (id_getAsQueryString_Ljava_lang_Object_ == IntPtr.Zero)
				id_getAsQueryString_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "getAsQueryString", "(Ljava/lang/Object;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getAsQueryString_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAsQueryString", "(Ljava/lang/Object;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getAsQueryString_Ljava_lang_Object_Z;
#pragma warning disable 0169
		static Delegate GetGetAsQueryString_Ljava_lang_Object_ZHandler ()
		{
			if (cb_getAsQueryString_Ljava_lang_Object_Z == null)
				cb_getAsQueryString_Ljava_lang_Object_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool, IntPtr>) n_GetAsQueryString_Ljava_lang_Object_Z);
			return cb_getAsQueryString_Ljava_lang_Object_Z;
		}

		static IntPtr n_GetAsQueryString_Ljava_lang_Object_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Oauth.Signpost.Http.HttpParameters __this = global::Java.Lang.Object.GetObject<global::Oauth.Signpost.Http.HttpParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetAsQueryString (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getAsQueryString_Ljava_lang_Object_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost.http']/class[@name='HttpParameters']/method[@name='getAsQueryString' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='boolean']]"
		[Register ("getAsQueryString", "(Ljava/lang/Object;Z)Ljava/lang/String;", "GetGetAsQueryString_Ljava_lang_Object_ZHandler")]
		public virtual unsafe string GetAsQueryString (global::Java.Lang.Object p0, bool p1)
		{
			if (id_getAsQueryString_Ljava_lang_Object_Z == IntPtr.Zero)
				id_getAsQueryString_Ljava_lang_Object_Z = JNIEnv.GetMethodID (class_ref, "getAsQueryString", "(Ljava/lang/Object;Z)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getAsQueryString_Ljava_lang_Object_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAsQueryString", "(Ljava/lang/Object;Z)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getFirst_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetGetFirst_Ljava_lang_Object_Handler ()
		{
			if (cb_getFirst_Ljava_lang_Object_ == null)
				cb_getFirst_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetFirst_Ljava_lang_Object_);
			return cb_getFirst_Ljava_lang_Object_;
		}

		static IntPtr n_GetFirst_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Oauth.Signpost.Http.HttpParameters __this = global::Java.Lang.Object.GetObject<global::Oauth.Signpost.Http.HttpParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetFirst (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getFirst_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost.http']/class[@name='HttpParameters']/method[@name='getFirst' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("getFirst", "(Ljava/lang/Object;)Ljava/lang/String;", "GetGetFirst_Ljava_lang_Object_Handler")]
		public virtual unsafe string GetFirst (global::Java.Lang.Object p0)
		{
			if (id_getFirst_Ljava_lang_Object_ == IntPtr.Zero)
				id_getFirst_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "getFirst", "(Ljava/lang/Object;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getFirst_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFirst", "(Ljava/lang/Object;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getFirst_Ljava_lang_Object_Z;
#pragma warning disable 0169
		static Delegate GetGetFirst_Ljava_lang_Object_ZHandler ()
		{
			if (cb_getFirst_Ljava_lang_Object_Z == null)
				cb_getFirst_Ljava_lang_Object_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool, IntPtr>) n_GetFirst_Ljava_lang_Object_Z);
			return cb_getFirst_Ljava_lang_Object_Z;
		}

		static IntPtr n_GetFirst_Ljava_lang_Object_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Oauth.Signpost.Http.HttpParameters __this = global::Java.Lang.Object.GetObject<global::Oauth.Signpost.Http.HttpParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetFirst (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getFirst_Ljava_lang_Object_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost.http']/class[@name='HttpParameters']/method[@name='getFirst' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='boolean']]"
		[Register ("getFirst", "(Ljava/lang/Object;Z)Ljava/lang/String;", "GetGetFirst_Ljava_lang_Object_ZHandler")]
		public virtual unsafe string GetFirst (global::Java.Lang.Object p0, bool p1)
		{
			if (id_getFirst_Ljava_lang_Object_Z == IntPtr.Zero)
				id_getFirst_Ljava_lang_Object_Z = JNIEnv.GetMethodID (class_ref, "getFirst", "(Ljava/lang/Object;Z)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getFirst_Ljava_lang_Object_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFirst", "(Ljava/lang/Object;Z)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_keySet;
#pragma warning disable 0169
		static Delegate GetKeySetHandler ()
		{
			if (cb_keySet == null)
				cb_keySet = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_KeySet);
			return cb_keySet;
		}

		static IntPtr n_KeySet (IntPtr jnienv, IntPtr native__this)
		{
			global::Oauth.Signpost.Http.HttpParameters __this = global::Java.Lang.Object.GetObject<global::Oauth.Signpost.Http.HttpParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (__this.KeySet ());
		}
#pragma warning restore 0169

		static IntPtr id_keySet;
		// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost.http']/class[@name='HttpParameters']/method[@name='keySet' and count(parameter)=0]"
		[Register ("keySet", "()Ljava/util/Set;", "GetKeySetHandler")]
		public virtual unsafe global::System.Collections.Generic.ICollection<string> KeySet ()
		{
			if (id_keySet == IntPtr.Zero)
				id_keySet = JNIEnv.GetMethodID (class_ref, "keySet", "()Ljava/util/Set;");
			try {

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaSet<string>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_keySet), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaSet<string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "keySet", "()Ljava/util/Set;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_put_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_put_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_put_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Put_Ljava_lang_String_Ljava_lang_String_);
			return cb_put_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_Put_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Oauth.Signpost.Http.HttpParameters __this = global::Java.Lang.Object.GetObject<global::Oauth.Signpost.Http.HttpParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Put (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_put_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost.http']/class[@name='HttpParameters']/method[@name='put' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("put", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "GetPut_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe string Put (string p0, string p1)
		{
			if (id_put_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_put_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "put", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_put_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "put", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_put_Ljava_lang_String_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_lang_String_Ljava_lang_String_ZHandler ()
		{
			if (cb_put_Ljava_lang_String_Ljava_lang_String_Z == null)
				cb_put_Ljava_lang_String_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool, IntPtr>) n_Put_Ljava_lang_String_Ljava_lang_String_Z);
			return cb_put_Ljava_lang_String_Ljava_lang_String_Z;
		}

		static IntPtr n_Put_Ljava_lang_String_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, bool p2)
		{
			global::Oauth.Signpost.Http.HttpParameters __this = global::Java.Lang.Object.GetObject<global::Oauth.Signpost.Http.HttpParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Put (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_put_Ljava_lang_String_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost.http']/class[@name='HttpParameters']/method[@name='put' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
		[Register ("put", "(Ljava/lang/String;Ljava/lang/String;Z)Ljava/lang/String;", "GetPut_Ljava_lang_String_Ljava_lang_String_ZHandler")]
		public virtual unsafe string Put (string p0, string p1, bool p2)
		{
			if (id_put_Ljava_lang_String_Ljava_lang_String_Z == IntPtr.Zero)
				id_put_Ljava_lang_String_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "put", "(Ljava/lang/String;Ljava/lang/String;Z)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_put_Ljava_lang_String_Ljava_lang_String_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "put", "(Ljava/lang/String;Ljava/lang/String;Z)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_put_Ljava_lang_String_Ljava_util_SortedSet_;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_lang_String_Ljava_util_SortedSet_Handler ()
		{
			if (cb_put_Ljava_lang_String_Ljava_util_SortedSet_ == null)
				cb_put_Ljava_lang_String_Ljava_util_SortedSet_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Put_Ljava_lang_String_Ljava_util_SortedSet_);
			return cb_put_Ljava_lang_String_Ljava_util_SortedSet_;
		}

		static IntPtr n_Put_Ljava_lang_String_Ljava_util_SortedSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Oauth.Signpost.Http.HttpParameters __this = global::Java.Lang.Object.GetObject<global::Oauth.Signpost.Http.HttpParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.ISortedSet p1 = (global::Java.Util.ISortedSet)global::Java.Lang.Object.GetObject<global::Java.Util.ISortedSet> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Put (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_put_Ljava_lang_String_Ljava_util_SortedSet_;
		// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost.http']/class[@name='HttpParameters']/method[@name='put' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.SortedSet&lt;java.lang.String&gt;']]"
		[Register ("put", "(Ljava/lang/String;Ljava/util/SortedSet;)Ljava/util/SortedSet;", "GetPut_Ljava_lang_String_Ljava_util_SortedSet_Handler")]
		public virtual unsafe global::Java.Util.ISortedSet Put (string p0, global::Java.Util.ISortedSet p1)
		{
			if (id_put_Ljava_lang_String_Ljava_util_SortedSet_ == IntPtr.Zero)
				id_put_Ljava_lang_String_Ljava_util_SortedSet_ = JNIEnv.GetMethodID (class_ref, "put", "(Ljava/lang/String;Ljava/util/SortedSet;)Ljava/util/SortedSet;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				global::Java.Util.ISortedSet __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Util.ISortedSet> (JNIEnv.CallObjectMethod  (Handle, id_put_Ljava_lang_String_Ljava_util_SortedSet_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Util.ISortedSet> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "put", "(Ljava/lang/String;Ljava/util/SortedSet;)Ljava/util/SortedSet;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_put_Ljava_lang_String_Ljava_util_SortedSet_Z;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_lang_String_Ljava_util_SortedSet_ZHandler ()
		{
			if (cb_put_Ljava_lang_String_Ljava_util_SortedSet_Z == null)
				cb_put_Ljava_lang_String_Ljava_util_SortedSet_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool, IntPtr>) n_Put_Ljava_lang_String_Ljava_util_SortedSet_Z);
			return cb_put_Ljava_lang_String_Ljava_util_SortedSet_Z;
		}

		static IntPtr n_Put_Ljava_lang_String_Ljava_util_SortedSet_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, bool p2)
		{
			global::Oauth.Signpost.Http.HttpParameters __this = global::Java.Lang.Object.GetObject<global::Oauth.Signpost.Http.HttpParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.ISortedSet p1 = (global::Java.Util.ISortedSet)global::Java.Lang.Object.GetObject<global::Java.Util.ISortedSet> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Put (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_put_Ljava_lang_String_Ljava_util_SortedSet_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost.http']/class[@name='HttpParameters']/method[@name='put' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.SortedSet&lt;java.lang.String&gt;'] and parameter[3][@type='boolean']]"
		[Register ("put", "(Ljava/lang/String;Ljava/util/SortedSet;Z)Ljava/util/SortedSet;", "GetPut_Ljava_lang_String_Ljava_util_SortedSet_ZHandler")]
		public virtual unsafe global::Java.Util.ISortedSet Put (string p0, global::Java.Util.ISortedSet p1, bool p2)
		{
			if (id_put_Ljava_lang_String_Ljava_util_SortedSet_Z == IntPtr.Zero)
				id_put_Ljava_lang_String_Ljava_util_SortedSet_Z = JNIEnv.GetMethodID (class_ref, "put", "(Ljava/lang/String;Ljava/util/SortedSet;Z)Ljava/util/SortedSet;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				global::Java.Util.ISortedSet __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Util.ISortedSet> (JNIEnv.CallObjectMethod  (Handle, id_put_Ljava_lang_String_Ljava_util_SortedSet_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Util.ISortedSet> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "put", "(Ljava/lang/String;Ljava/util/SortedSet;Z)Ljava/util/SortedSet;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_putAll_arrayLjava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetPutAll_arrayLjava_lang_String_ZHandler ()
		{
			if (cb_putAll_arrayLjava_lang_String_Z == null)
				cb_putAll_arrayLjava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_PutAll_arrayLjava_lang_String_Z);
			return cb_putAll_arrayLjava_lang_String_Z;
		}

		static void n_PutAll_arrayLjava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Oauth.Signpost.Http.HttpParameters __this = global::Java.Lang.Object.GetObject<global::Oauth.Signpost.Http.HttpParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			__this.PutAll (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_putAll_arrayLjava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost.http']/class[@name='HttpParameters']/method[@name='putAll' and count(parameter)=2 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='boolean']]"
		[Register ("putAll", "([Ljava/lang/String;Z)V", "GetPutAll_arrayLjava_lang_String_ZHandler")]
		public virtual unsafe void PutAll (string[] p0, bool p1)
		{
			if (id_putAll_arrayLjava_lang_String_Z == IntPtr.Zero)
				id_putAll_arrayLjava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "putAll", "([Ljava/lang/String;Z)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_putAll_arrayLjava_lang_String_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "putAll", "([Ljava/lang/String;Z)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_putAll_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetPutAll_Ljava_util_Map_Handler ()
		{
			if (cb_putAll_Ljava_util_Map_ == null)
				cb_putAll_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PutAll_Ljava_util_Map_);
			return cb_putAll_Ljava_util_Map_;
		}

		static void n_PutAll_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Oauth.Signpost.Http.HttpParameters __this = global::Java.Lang.Object.GetObject<global::Oauth.Signpost.Http.HttpParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IDictionary<string, Java.Util.ISortedSet> p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Util.ISortedSet>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PutAll (p0);
		}
#pragma warning restore 0169

		static IntPtr id_putAll_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost.http']/class[@name='HttpParameters']/method[@name='putAll' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;? extends java.lang.String, ? extends java.util.SortedSet&lt;java.lang.String&gt;&gt;']]"
		[Register ("putAll", "(Ljava/util/Map;)V", "GetPutAll_Ljava_util_Map_Handler")]
		public virtual unsafe void PutAll (global::System.Collections.Generic.IDictionary<string, global::Java.Util.ISortedSet> p0)
		{
			if (id_putAll_Ljava_util_Map_ == IntPtr.Zero)
				id_putAll_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "putAll", "(Ljava/util/Map;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Util.ISortedSet>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_putAll_Ljava_util_Map_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "putAll", "(Ljava/util/Map;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_putAll_Ljava_util_Map_Z;
#pragma warning disable 0169
		static Delegate GetPutAll_Ljava_util_Map_ZHandler ()
		{
			if (cb_putAll_Ljava_util_Map_Z == null)
				cb_putAll_Ljava_util_Map_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_PutAll_Ljava_util_Map_Z);
			return cb_putAll_Ljava_util_Map_Z;
		}

		static void n_PutAll_Ljava_util_Map_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Oauth.Signpost.Http.HttpParameters __this = global::Java.Lang.Object.GetObject<global::Oauth.Signpost.Http.HttpParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IDictionary<string, Java.Util.ISortedSet> p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Util.ISortedSet>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PutAll (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_putAll_Ljava_util_Map_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost.http']/class[@name='HttpParameters']/method[@name='putAll' and count(parameter)=2 and parameter[1][@type='java.util.Map&lt;? extends java.lang.String, ? extends java.util.SortedSet&lt;java.lang.String&gt;&gt;'] and parameter[2][@type='boolean']]"
		[Register ("putAll", "(Ljava/util/Map;Z)V", "GetPutAll_Ljava_util_Map_ZHandler")]
		public virtual unsafe void PutAll (global::System.Collections.Generic.IDictionary<string, global::Java.Util.ISortedSet> p0, bool p1)
		{
			if (id_putAll_Ljava_util_Map_Z == IntPtr.Zero)
				id_putAll_Ljava_util_Map_Z = JNIEnv.GetMethodID (class_ref, "putAll", "(Ljava/util/Map;Z)V");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Util.ISortedSet>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_putAll_Ljava_util_Map_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "putAll", "(Ljava/util/Map;Z)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_putMap_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetPutMap_Ljava_util_Map_Handler ()
		{
			if (cb_putMap_Ljava_util_Map_ == null)
				cb_putMap_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PutMap_Ljava_util_Map_);
			return cb_putMap_Ljava_util_Map_;
		}

		static void n_PutMap_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Oauth.Signpost.Http.HttpParameters __this = global::Java.Lang.Object.GetObject<global::Oauth.Signpost.Http.HttpParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IDictionary<string, System.Collections.Generic.IList<string>> p0 = global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IList<string>>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PutMap (p0);
		}
#pragma warning restore 0169

		static IntPtr id_putMap_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost.http']/class[@name='HttpParameters']/method[@name='putMap' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.util.List&lt;java.lang.String&gt;&gt;']]"
		[Register ("putMap", "(Ljava/util/Map;)V", "GetPutMap_Ljava_util_Map_Handler")]
		public virtual unsafe void PutMap (global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IList<string>> p0)
		{
			if (id_putMap_Ljava_util_Map_ == IntPtr.Zero)
				id_putMap_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "putMap", "(Ljava/util/Map;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IList<string>>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_putMap_Ljava_util_Map_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "putMap", "(Ljava/util/Map;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_putNull_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPutNull_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_putNull_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_putNull_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_PutNull_Ljava_lang_String_Ljava_lang_String_);
			return cb_putNull_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_PutNull_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Oauth.Signpost.Http.HttpParameters __this = global::Java.Lang.Object.GetObject<global::Oauth.Signpost.Http.HttpParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.PutNull (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_putNull_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost.http']/class[@name='HttpParameters']/method[@name='putNull' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("putNull", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "GetPutNull_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe string PutNull (string p0, string p1)
		{
			if (id_putNull_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_putNull_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "putNull", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_putNull_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "putNull", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_remove_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetRemove_Ljava_lang_Object_Handler ()
		{
			if (cb_remove_Ljava_lang_Object_ == null)
				cb_remove_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Remove_Ljava_lang_Object_);
			return cb_remove_Ljava_lang_Object_;
		}

		static IntPtr n_Remove_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Oauth.Signpost.Http.HttpParameters __this = global::Java.Lang.Object.GetObject<global::Oauth.Signpost.Http.HttpParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Remove (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_remove_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost.http']/class[@name='HttpParameters']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("remove", "(Ljava/lang/Object;)Ljava/util/SortedSet;", "GetRemove_Ljava_lang_Object_Handler")]
		public virtual unsafe global::Java.Util.ISortedSet Remove (global::Java.Lang.Object p0)
		{
			if (id_remove_Ljava_lang_Object_ == IntPtr.Zero)
				id_remove_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "remove", "(Ljava/lang/Object;)Ljava/util/SortedSet;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Java.Util.ISortedSet __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Util.ISortedSet> (JNIEnv.CallObjectMethod  (Handle, id_remove_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Util.ISortedSet> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "remove", "(Ljava/lang/Object;)Ljava/util/SortedSet;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_size;
#pragma warning disable 0169
		static Delegate GetSizeHandler ()
		{
			if (cb_size == null)
				cb_size = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Size);
			return cb_size;
		}

		static int n_Size (IntPtr jnienv, IntPtr native__this)
		{
			global::Oauth.Signpost.Http.HttpParameters __this = global::Java.Lang.Object.GetObject<global::Oauth.Signpost.Http.HttpParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Size ();
		}
#pragma warning restore 0169

		static IntPtr id_size;
		// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost.http']/class[@name='HttpParameters']/method[@name='size' and count(parameter)=0]"
		[Register ("size", "()I", "GetSizeHandler")]
		public virtual unsafe int Size ()
		{
			if (id_size == IntPtr.Zero)
				id_size = JNIEnv.GetMethodID (class_ref, "size", "()I");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_size);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "size", "()I"));
			} finally {
			}
		}

		static Delegate cb_values;
#pragma warning disable 0169
		static Delegate GetValuesHandler ()
		{
			if (cb_values == null)
				cb_values = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Values);
			return cb_values;
		}

		static IntPtr n_Values (IntPtr jnienv, IntPtr native__this)
		{
			global::Oauth.Signpost.Http.HttpParameters __this = global::Java.Lang.Object.GetObject<global::Oauth.Signpost.Http.HttpParameters> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaCollection<global::Java.Util.ISortedSet>.ToLocalJniHandle (__this.Values ());
		}
#pragma warning restore 0169

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='oauth.signpost.http']/class[@name='HttpParameters']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()Ljava/util/Collection;", "GetValuesHandler")]
		public virtual unsafe global::System.Collections.Generic.ICollection<global::Java.Util.ISortedSet> Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetMethodID (class_ref, "values", "()Ljava/util/Collection;");
			try {

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaCollection<global::Java.Util.ISortedSet>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_values), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaCollection<global::Java.Util.ISortedSet>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "values", "()Ljava/util/Collection;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
