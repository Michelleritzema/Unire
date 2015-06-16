using System;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using Unire_Android.Resources;
using Gcm.Client;
using Android.Util;
using System.Threading;
using Newtonsoft.Json;

namespace Unire_Android
{
    [Activity(Label = "Unire")]
    public class LoginConfirm : Activity
    {

        const string TAG = "GCM-CLIENT";
        TextView mUserID;
        TextView mUsername;
        User mLoggedOnUser;
       Button mGetStarted;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.LoginConfirm);

           
            mUsername = FindViewById<TextView>(Resource.Id.username);
            mUserID = FindViewById<TextView>(Resource.Id.userid);
            mLoggedOnUser = JsonConvert.DeserializeObject<User>(Intent.GetStringExtra("User"));
            mGetStarted = FindViewById<Button>(Resource.Id.GetStarted);
           // mUserID.Text = mLoggedOnUser.UserID.ToString();
            mUsername.Text = mLoggedOnUser.UserName;
           mGetStarted.Click += mGetStarted_Click;
            // Create your application here

           Thread.Sleep(10000);
			var registrationId = GcmClient.GetRegistrationId(this);
           	Toast.MakeText(this, registrationId, ToastLength.Long).Show();

           if (!string.IsNullOrEmpty(registrationId))
           {
               Log.Info(TAG, registrationId);
               
           }
         
        }

        private void mGetStarted_Click(object sender, EventArgs e)
        {
           Intent intent = new Intent(this, typeof(Homescreen));
           StartActivity(intent);

           
        }
    }
}