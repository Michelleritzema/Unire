using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Widget;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Util;
using System;
using Gcm.Client;

using Unire_Shared;
using SupportToolbar = Android.Support.V7.Widget.Toolbar;


namespace Unire_Android
{
    [Activity(Label = "Unire", MainLauncher = false, Icon = "@drawable/icon", Theme = "@style/MyTheme")]
    public class Homescreen : ActionBarActivity
    {

        private SupportToolbar mToolbar;
        HttpDataConnection connection;
        private String url = "http://www.e-dragon-94311.appspot.com/grades";
             
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);
            connection = new HttpDataConnection(url, this);

			//GcmClient.CheckDevice(this);
			//GcmClient.CheckManifest(this);
			//Call to register
			//GcmClient.Register(this, GcmBroadcastReceiver.SENDER_IDS);

            mToolbar = FindViewById<SupportToolbar>(Resource.Id.toolbar);
            SetSupportActionBar(mToolbar);

            var button_ov = FindViewById<ImageButton>(Resource.Id.logo_ov);
            var button_tasks = FindViewById<ImageButton>(Resource.Id.logo_tasks);
            var button_notes = FindViewById<ImageButton>(Resource.Id.logo_notes);
            var button_calendar = FindViewById<ImageButton>(Resource.Id.logo_calendar);
            var button_weather = FindViewById<ImageButton>(Resource.Id.logo_weather);
            var button_settings = FindViewById<ImageButton>(Resource.Id.logo_settings);

            button_ov.Click += delegate { StartActivity(typeof(Blue)); };
            button_tasks.Click += delegate { StartActivity(typeof(Purple)); };
            button_notes.Click += delegate { StartActivity(typeof(Orange)); };
            button_calendar.Click += delegate { StartActivity(typeof(Red)); };
            button_weather.Click += delegate { StartActivity(typeof(Yellow)); };
            button_settings.Click += delegate { StartActivity(typeof(Green)); };
        }
    }
}