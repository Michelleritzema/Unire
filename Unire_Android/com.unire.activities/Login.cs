using System;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using Android.Views.InputMethods;
using Unire_Android.Resources;
using Newtonsoft.Json;
using Gcm.Client;
using Unire_Shared;
using Android.Util;

namespace Unire_Android
{
    [Activity(Label = "Unire", MainLauncher = false, Icon = "@drawable/icon", Theme = "@style/MyTheme")]
    public class Login : Activity
    {

        const string TAG = "GCM-CLIENT";
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
            Intent intent = new Intent(this,typeof(LoginConfirm));
           // var c = GetSharedPreferences(GetString)
            User user = new User()
            {
                UserName = mUsername.Text,
                Password = mPassword.Text
            };

            intent.PutExtra("User", JsonConvert.SerializeObject(user));

            if (mCbxRemMe.Checked)
            {
              // ISharedPreferences pref = Application.Context.GetSharedPreferences("UserInfo", FileCreationMode.Private);
              //  ISharedPreferencesEditor editor = pref.Edit();
                var prefs = Application.Context.GetSharedPreferences("UserInfo", FileCreationMode.Private);
                var editor= prefs.Edit();
                editor.PutString("Username", mUsername.Text.Trim());
                editor.PutString("Password", mPassword.Text.Trim());
                editor.Apply();
            }

            GcmClient.Register(this, GcmBroadcastReceiver.SENDER_IDS);

            this.StartActivity(intent);
            this.OverridePendingTransition(Resource.Animation.slide_in_top, Resource.Animation.slide_out_bottom);
            this.Finish();
        }

        
   

        void mRelativeLayout_Click(object sender, EventArgs e)
        {
            InputMethodManager inputManager = (InputMethodManager)this.GetSystemService(Activity.InputMethodService);
            inputManager.HideSoftInputFromWindow(this.CurrentFocus.WindowToken, HideSoftInputFlags.None);
        }
    }
}



