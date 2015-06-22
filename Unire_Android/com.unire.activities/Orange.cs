using Android.App;
using Android.OS;
using Android.Support.V4.Widget;
using Android.Support.V7.App;
using Android.Util;
using Android.Views;
using Android.Widget;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using Unire_Android.com.unire.other;
using SupportToolbar = Android.Support.V7.Widget.Toolbar;
using System;


namespace Unire_Android
{
    [Activity(Label = "Unire", Icon = "@drawable/iconO", Theme = "@style/MyTheme")]
    public class Orange : ActionBarActivity
    {

        /* This is the class for grades information.
         * The user can visit this activity at all times, to view older notifications.
         * Once a new orange notification is created, the user is guided to this class.
         */

        private SupportToolbar toolbar;
        private MyActionBarDrawerToggle drawer_toggle;
        private DrawerLayout drawer_layout;
        private ListView drawer_list;
        private ListView oldNotificationsList;
        private TextView current_date;
		private TextView current_module;
        private TextView current_text;
        private string[] notifications;
        private List<string> old_notifications;
        private CategoryMethods basic_methods;
        
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Orange);

            Button BTNGETALL = FindViewById<Button>(Resource.Id.GTAll);
            BTNGETALL.Click += BTNGETALL_Click;

            toolbar = FindViewById<SupportToolbar>(Resource.Id.toolbar);
            drawer_layout = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);
            drawer_list = FindViewById<ListView>(Resource.Id.left_drawer);
            current_date = FindViewById<TextView>(Resource.Id.current_date);
			current_module = FindViewById<TextView>(Resource.Id.current_module);
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
            notifications = new string[] { "09-02-2015 DEV04 9,1", "08-02-2015 INF04 6,3", "06-02-2015 SLC02 7,5" };
            old_notifications = basic_methods.setOlderNotifications(notifications);
            NotificationAdapter adapter = new NotificationAdapter(this, old_notifications);
            oldNotificationsList.Adapter = adapter;

            if (Intent.GetStringExtra("text") != null)
            {
                string text = Intent.GetStringExtra("text");
                Grade deserializedProduct = JsonConvert.DeserializeObject<Grade>(text);
                string module = deserializedProduct.vak_code;
                double grade = deserializedProduct.grade;
              
				DateTime dateTime = DateTime.UtcNow.Date;
				current_date.Text = dateTime.ToString ("dd-MM-yyyy");
				current_module.Text = module;
				current_text.Text = grade.ToString();
            }
            else
            {
                current_date.Visibility = ViewStates.Gone;
				current_module.Visibility = ViewStates.Gone;
                current_text.Visibility = ViewStates.Gone;
            }
        }

        void BTNGETALL_Click(object sender, System.EventArgs e)
        {
            DataBaseRepository dbr = new DataBaseRepository();
            var result = dbr.GettAllRecords();
            Toast.MakeText(this, result, ToastLength.Short).Show();
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