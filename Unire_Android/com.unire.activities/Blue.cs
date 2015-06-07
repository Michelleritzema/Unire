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
    [Activity(Label = "Unire", Icon = "@drawable/iconB", Theme = "@style/MyTheme")]
    public class Blue : ActionBarActivity
    {

        /* This is the class for public transportation information.
         * The user can visit this activity at all times, to view older notifications.
         * Once a new blue notification is created, the user is guided to this class.
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
            SetContentView(Resource.Layout.Blue);

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

            basic_methods = new CategoryMethods();
            notifications = new string[] { "09-02-2015 Trein van 10:05 rijdt niet", 
                "08-02-2015 Vertrek nu van huis om de trein te halen", 
                "06-02-2015 Vertraging tussen Schiedam Centrum en Rotterdam Centraal" };
            old_notifications = basic_methods.setOlderNotifications(notifications);
            NotificationAdapter adapter = new NotificationAdapter(this, old_notifications);
            oldNotificationsList.Adapter = adapter;

            if (Intent.GetStringExtra("text") != null)
            {
                current_text.Text = Intent.GetStringExtra("text");   
            }
            else
            {
                current_date.Visibility = ViewStates.Gone;
                current_text.Visibility = ViewStates.Gone;
            }
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