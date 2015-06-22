using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Views.InputMethods;
using Android.Widget;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;

using Unire_Android.Resources;
using Unire_Shared;
using Gcm.Client;


namespace Unire_Android
{
    [Activity(Label = "Unire", MainLauncher = false, NoHistory = true, Icon = "@drawable/icon", 
        Theme = "@style/MyTheme", ScreenOrientation = ScreenOrientation.Portrait)]
    public class Login : Activity
    {

       /* The login screen is used to collect the user's hint username and password.
        * These are saved in shared preferences and sent to the back-end.
        */

        private const string TAG = "Login";
        private RelativeLayout mRelativeLayout;
        private Button mButton;
        private EditText mUsername;
        private EditText mPassword;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Login);

            //The device and manifest must be checked to make sure everything is set up
            //correctly to use the Google Cloud Messaging (GCM)
            GcmClient.CheckDevice(this);
            GcmClient.CheckManifest(this);

            mButton = FindViewById<Button>(Resource.Id.btnLogin);
            mRelativeLayout = FindViewById<RelativeLayout>(Resource.Id.mainView);
            mUsername = FindViewById<EditText>(Resource.Id.txtUserName);
            mPassword = FindViewById<EditText>(Resource.Id.txtPassword);
            mRelativeLayout.Click += mRelativeLayout_Click;
            mButton.Click  += mButton_Click;
        }

        private void mButton_Click(object sender, EventArgs e)
        {
            //Generates a unique key to be used for the back-end
            GcmClient.Register(this, GcmBroadcastReceiver.SENDER_IDS);
            Thread.Sleep(5000);
            var registrationId = GcmClient.GetRegistrationId(this);
            
            //Create a new User to be sent with the intent
            User user = new User()
            {
                userName = mUsername.Text,
                password = mPassword.Text,
                key = registrationId
            };
            //Send the user credentials to the back-end
            DictionaryStrings(user);

            //Save the username, password and registrationId in shared preferences
            var prefs = Application.Context.GetSharedPreferences("UserInfo", FileCreationMode.Private);
            var editor = prefs.Edit();
            editor.PutString("Username", mUsername.Text.Trim());
            editor.PutString("Password", mPassword.Text.Trim());
            editor.PutString("RegistrationId", registrationId);
            editor.Apply();

            //Start a new intent of LoginConfirm, send the user object to the intent
            Intent intent = new Intent(this, typeof(LoginConfirm));
            intent.PutExtra("User", JsonConvert.SerializeObject(user));
            this.StartActivity(intent);
            this.OverridePendingTransition(Resource.Animation.slide_in_top, Resource.Animation.slide_out_bottom);
            this.Finish();
        }

        void mRelativeLayout_Click(object sender, EventArgs e)
        {
            //Hide the soft keyboard when the user taps on the relative layout
            InputMethodManager inputManager = (InputMethodManager)this.GetSystemService(Activity.InputMethodService);
            inputManager.HideSoftInputFromWindow(this.CurrentFocus.WindowToken, HideSoftInputFlags.None);
        }

        async void DictionaryStrings(User user)
        {
            var Client = new HttpClient();
            //fetch the login URL from the Setup class
            string apiUrl = new Setup().getLoginURL();
            var values = new Dictionary<string, string>
            {
                { "username", user.userName},
                { "password", user.password},
                { "regId", user.key}
            };

            var content = new FormUrlEncodedContent(values);
            var response = await Client.PostAsync(apiUrl, content);
            var responseString = await response.Content.ReadAsStringAsync();
        }
    }
}