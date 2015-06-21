using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using Newtonsoft.Json;
using System;
using System.Threading;

using Unire_Android.Resources;


namespace Unire_Android
{
    [Activity(Theme = "@style/Theme.Splash", MainLauncher = true, NoHistory = true)]
    public class SplashScreen : Activity
    {

       /* This is the splash screen for the application.
        * Once this activity is finished, it is destroyed.
        */

        private string userName;
        private string password;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            //Get the shared preferences under 'UserInfo'
            ISharedPreferences pref = Application.Context.GetSharedPreferences("UserInfo", FileCreationMode.Private);
            userName = pref.GetString("Username", String.Empty);
            password = pref.GetString("Password", String.Empty);
            
            // Sleep and check which activity to start
            Thread.Sleep(1000);
            if(userName == String.Empty || password == String.Empty)
            {
                //No saved credentials, take user to login screen
                Intent intent = new Intent(this, typeof(Login));
                this.StartActivity(intent);
            }
            else
            {
                //There are saved credentials, go to homescreen
                Intent intent = new Intent(this, typeof(Homescreen));
                User user = new User()
                {
                    userName = userName,
                    password = password
                };
                //Send user object with intent in a json string
                intent.PutExtra("User", JsonConvert.SerializeObject(user));
                string json = JsonConvert.SerializeObject(user);
                this.StartActivity(intent);
            }
            this.Finish(); 
        }
    }
}