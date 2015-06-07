using System.Collections.Generic;
using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;
using Android.Support.V4.Widget;
using Android.Support.V7.App;

using SupportToolbar = Android.Support.V7.Widget.Toolbar;


namespace Unire_Android
{
    [Activity(Label = "Unire", Icon = "@drawable/iconG", Theme = "@style/MyTheme")]
    public class Green : ActionBarActivity
    {
        
        /* This is the class for settings.
         * The user can visit this activity at all times, to view his/her settings.
         */

        private SupportToolbar toolbar;
        private MyActionBarDrawerToggle drawer_toggle;
        private DrawerLayout drawer_layout;
        private ListView drawer_list;
        private ListView oldNotificationsList;
        private TextView current_date;
        private TextView current_text;
        private string[] notifications;
        private List<string> old_notifications;
        private CategoryMethods basic_methods;
        
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Green);

            toolbar = FindViewById<SupportToolbar>(Resource.Id.toolbar);
            drawer_layout = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);
            drawer_list = FindViewById<ListView>(Resource.Id.left_drawer);
            current_date = FindViewById<TextView>(Resource.Id.current_date);
            current_text = FindViewById<TextView>(Resource.Id.current_text);
            oldNotificationsList = FindViewById<ListView>(Resource.Id.older_notifications);

            SetSupportActionBar(toolbar);
            drawer_toggle = new MyActionBarDrawerToggle(
                this, drawer_layout, Resource.String.actionBarTitle, Resource.String.actionBarTitle);
            drawer_layout.SetDrawerListener(drawer_toggle);
            SupportActionBar.SetHomeButtonEnabled(true);
            SupportActionBar.SetDisplayShowTitleEnabled(true);
            drawer_toggle.SyncState();
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            drawer_toggle.OnOptionsItemSelected(item);
            return base.OnOptionsItemSelected(item);
        }

        protected override void OnSaveInstanceState(Bundle outState)
        {
            if (drawer_layout.IsDrawerOpen((int)GravityFlags.Left))
            {
                outState.PutString("DrawerState", "Opened");
            }
            else
            {
                outState.PutString("DrawerState", "Closed");
            }
            base.OnSaveInstanceState(outState);
        }
    }
}