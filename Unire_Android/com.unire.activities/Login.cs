using System;
using System.Collections.Generic;
using System.Net.Http;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Util;
using Android.Views.InputMethods;
using Android.Widget;

using Unire_Android.Resources;
using Unire_Shared;
using Gcm.Client;
using Newtonsoft.Json;
using System.Threading;


namespace Unire_Android
{
    [Activity(Label = "Unire", MainLauncher = false, Icon = "@drawable/icon", Theme = "@style/MyTheme")]
    public class Login : Activity
    {

        const string TAG = "Login";
        RelativeLayout mRelativeLayout;
        Button mButton;
        EditText mUsername;
        EditText mPassword;
        CheckBox mCbxRemMe;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Login);

            GcmClient.CheckDevice(this);
            GcmClient.CheckManifest(this);

            mButton = FindViewById<Button>(Resource.Id.btnLogin);
            mRelativeLayout = FindViewById<RelativeLayout>(Resource.Id.mainView);
            mUsername = FindViewById<EditText>(Resource.Id.txtUserName);
            mPassword = FindViewById<EditText>(Resource.Id.txtPassword);
            mCbxRemMe = FindViewById<CheckBox>(Resource.Id.cbxRememberMe);
            mRelativeLayout.Click += mRelativeLayout_Click;
            mButton.Click  += mButton_Click;
        }

        private void mButton_Click(object sender, EventArgs e)
        {
            GcmClient.Register(this, GcmBroadcastReceiver.SENDER_IDS);
            Thread.Sleep(10000);
            var registrationId = GcmClient.GetRegistrationId(this);
            Log.Info(TAG, "Using registrationId " + registrationId);
            Toast.MakeText(this, registrationId, ToastLength.Long).Show();
            
            User user = new User()
            {
                UserName = mUsername.Text,
                Password = mPassword.Text,
                Key = registrationId
            };
            DictionaryStrings(user);

            if (mCbxRemMe.Checked)
            {
                //ISharedPreferences pref = Application.Context.GetSharedPreferences("UserInfo", FileCreationMode.Private);
                //ISharedPreferencesEditor editor = pref.Edit();
                var prefs = Application.Context.GetSharedPreferences("UserInfo", FileCreationMode.Private);
                var editor = prefs.Edit();
                editor.PutString("Username", mUsername.Text.Trim());
                editor.PutString("Password", mPassword.Text.Trim());
                editor.PutString("RegistrationId", registrationId);
                editor.Apply();
            }

            Intent intent = new Intent(this, typeof(LoginConfirm));
            intent.PutExtra("User", JsonConvert.SerializeObject(user));
            this.StartActivity(intent);
            this.OverridePendingTransition(Resource.Animation.slide_in_top, Resource.Animation.slide_out_bottom);
            this.Finish();
        }

        void mRelativeLayout_Click(object sender, EventArgs e)
        {
            InputMethodManager inputManager = (InputMethodManager)this.GetSystemService(Activity.InputMethodService);
            inputManager.HideSoftInputFromWindow(this.CurrentFocus.WindowToken, HideSoftInputFlags.None);
        }

        async void DictionaryStrings(User user)
        {
            var Client = new HttpClient();
            string apiUrl = "http://e-dragon-94311.appspot.com/login";
            var values = new Dictionary<string, string>
            {
                { "username", user.UserName},
                { "password", user.Password},
                { "regId", user.Key}
            };

            var content = new FormUrlEncodedContent(values);
            var response = await Client.PostAsync(apiUrl, content);
            var responseString = await response.Content.ReadAsStringAsync();
        }
    }
}



