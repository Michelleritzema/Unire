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
using System.Threading;
using Unire_Android.Resources;
using Newtonsoft.Json;
namespace Unire_Android
{
    [Activity(Theme = "@style/Theme.Splash", MainLauncher = true, NoHistory = true)]
    public class SplashScreen : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            ISharedPreferences pref = Application.Context.GetSharedPreferences("UserInfo", FileCreationMode.Private);
            string userName = pref.GetString("Username", String.Empty);
            string password = pref.GetString("Password", String.Empty);
            // Create your application here
            Thread.Sleep(1000);
            StartActivity(typeof(Login));
            


            if (userName == String.Empty || password == String.Empty)
            {
                //No saved credentials, take user to login screen
                Intent intent = new Intent(this, typeof(Login));
                this.StartActivity(intent);

            }

            else
            {
                //There are saved credentials

                /*This is where you would query the database
                .
                .
                .
                Done querying*/

                if (userName == "Anny" && password == "Unire")
                {
                    //Successful take the user to application
                    Intent intent = new Intent(this, typeof(MainActivity));

                    User user = new User()
                    {

                        UserName = userName,
                        Password = password
                    };

                    intent.PutExtra("User", JsonConvert.SerializeObject(user));

                    this.StartActivity(intent);
                }

                else 
                {
                    Toast.MakeText(this, "niet opgeslagen naam", ToastLength.Long).Show();

                    //Unsuccesful, take user to login screen
                    ISharedPreferencesEditor edit = pref.Edit();
                    edit.Apply();
                    Intent intent = new Intent(this,typeof(Login));

                    this.StartActivity(intent);
                    this.Finish();
                  
                    
                    
                }
            }
        }
    }
}