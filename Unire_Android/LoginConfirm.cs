using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Unire_Android.Resources;
using Newtonsoft.Json;
using System.Threading;



namespace Unire_Android
{
    [Activity(Label = "LoginConfirm")]
    public class LoginConfirm : Activity
    {

        
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
         
        }

        private void mGetStarted_Click(object sender, EventArgs e)
        {
           Intent intent = new Intent(this, typeof(MainActivity));
           StartActivity(intent);

           
        }
    }
}