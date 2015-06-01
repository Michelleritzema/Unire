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
using Android.Views.InputMethods;
using Unire_Android.Resources;
using Newtonsoft.Json;

namespace Unire_Android
{
    [Activity(Label = "Unire_Android", MainLauncher = false, Icon = "@drawable/icon", Theme = "@style/MyTheme")]
    public class Login : Activity
    {
        RelativeLayout mRelativeLayout;
        Button mButton;
        EditText mUsername;
        EditText mPassword;
        CheckBox mCbxRemMe;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Login);

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
          
            User user = new User()
            {
               
                UserName = mUsername.Text,
                Password = mPassword.Text
            };

            intent.PutExtra("User", JsonConvert.SerializeObject(user));

            if (mCbxRemMe.Checked)
            {
                ISharedPreferences pref = Application.Context.GetSharedPreferences("UserInfo", FileCreationMode.Private);
                ISharedPreferencesEditor edit = pref.Edit();
                edit.PutString("Username", mUsername.Text.Trim());
                edit.PutString("Password", mPassword.Text.Trim());
                edit.Apply();
                

            }         

            this.StartActivity(intent);
            this.OverridePendingTransition(Resource.Animation.slide_in_top, Resource.Animation.slide_out_bottom);
           // this.Finish();
        }

        void mRelativeLayout_Click(object sender, EventArgs e)
        {
            InputMethodManager inputManager = (InputMethodManager)this.GetSystemService(Activity.InputMethodService);
            inputManager.HideSoftInputFromWindow(this.CurrentFocus.WindowToken, HideSoftInputFlags.None);
        }
    }
}




