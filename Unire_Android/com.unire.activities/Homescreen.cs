using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Support.V7.App;
using Android.Widget;

using SupportToolbar = Android.Support.V7.Widget.Toolbar;
using Unire_Shared;


namespace Unire_Android
{
    [Activity(Label = "Unire", MainLauncher = false, Icon = "@drawable/icon", 
        Theme = "@style/MyTheme", ScreenOrientation = ScreenOrientation.Portrait)]
    public class Homescreen : ActionBarActivity
    {

       /* This is the homescreen. The user always goes back to this activity.
        * The buttons all activate different intents. From the homescreen, the
        * async task GetNewNotifications is frequently checking if new notifications
        * have arrived.
        */

        private SupportToolbar mToolbar;
        private HttpDataConnection connection;
             
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);
            connection = new HttpDataConnection(this);

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