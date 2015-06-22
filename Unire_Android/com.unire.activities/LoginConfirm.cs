using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Util;
using Android.Widget;
using Newtonsoft.Json;
using System;

using Unire_Android.Resources;
using Gcm.Client;


namespace Unire_Android
{
    [Activity(Label = "Unire", NoHistory = true, Icon = "@drawable/icon", 
        Theme = "@style/MyTheme", ScreenOrientation = ScreenOrientation.Portrait)]
    public class LoginConfirm : Activity
    {

       /* The LoginConfirm class shows the user that the login succeeded
        */

        private const string TAG = "LoginConfirm";
        private TextView mUserID;
        private TextView mUsername;
        private User mLoggedOnUser;
        private Button mGetStarted;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.LoginConfirm);

            mUsername = FindViewById<TextView>(Resource.Id.username);
            mUserID = FindViewById<TextView>(Resource.Id.userid);
            //Get the username from the user object sent with the intent
            mLoggedOnUser = JsonConvert.DeserializeObject<User>(Intent.GetStringExtra("User"));
            mGetStarted = FindViewById<Button>(Resource.Id.GetStarted);
            mUsername.Text = mLoggedOnUser.userName;
            mGetStarted.Click += mGetStarted_Click;

			var registrationId = GcmClient.GetRegistrationId(this);
            Log.Info(TAG, "Using registrationId " + registrationId);
           	Toast.MakeText(this, registrationId, ToastLength.Long).Show();   
        }

        private void mGetStarted_Click(object sender, EventArgs e)
        {
           Intent intent = new Intent(this, typeof(Homescreen));
           StartActivity(intent);
           this.Finish();
        }
    }
}