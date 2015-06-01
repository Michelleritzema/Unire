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
using Android.Support;
using Android.Support.V4.Widget;
using Android.Support.V7.App;

using SupportToolbar = Android.Support.V7.Widget.Toolbar;
using Java.Util;

namespace Unire_Android
{
    [Activity(Label = "Blue", Icon = "@drawable/iconB", Theme = "@style/MyTheme")]
    public class Blue : ActionBarActivity
    {

        private SupportToolbar mToolbar;
        private MyActionBarDrawerToggle mDrawerToggle;
        private DrawerLayout mDrawerLayout;
        private ListView mLeftDrawer;
        private ListView oldNotificationsList;
        private string[] notifications;
        private List<string> old_notifications;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Blue);
            mToolbar = FindViewById<SupportToolbar>(Resource.Id.toolbar);
            SetSupportActionBar(mToolbar);
            mDrawerLayout = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);
            mLeftDrawer = FindViewById<ListView>(Resource.Id.left_drawer);

            oldNotificationsList = FindViewById<ListView>(Resource.Id.older_notifications);
            notifications = new string[] { "09-02-2015 Trein van 10:05 rijdt niet", "08-02-2015 Vertrek nu van huis om de trein te halen", "06-02-2015 Vertraging tussen Schiedam Centrum en Rotterdam Centraal" };
            old_notifications = new List<string>();
            for(int i = 0; i < notifications.Length; i++) {
                old_notifications.Add(notifications[i]);
            }

            NotificationAdapter adapter = new NotificationAdapter(this, old_notifications);
            oldNotificationsList.Adapter = adapter;

            mDrawerToggle = new MyActionBarDrawerToggle( 
                this,  mDrawerLayout, Resource.String.openDrawer, Resource.String.closeDrawer);
            mDrawerLayout.SetDrawerListener(mDrawerToggle);
            SupportActionBar.SetHomeButtonEnabled(true);
            SupportActionBar.SetDisplayShowTitleEnabled(true);
            mDrawerToggle.SyncState();

            if (bundle != null) {
                if (bundle.GetString("Drawer state") == "openend") {
                    SupportActionBar.SetTitle(Resource.String.openDrawer);
                } else {
                    SupportActionBar.SetTitle(Resource.String.closeDrawer);
                }
            } else {
                SupportActionBar.SetTitle(Resource.String.closeDrawer);
            }

            var current_text = FindViewById<TextView>(Resource.Id.current_text);
            //blue_current_text.Text = Intent.GetStringExtra("text");            
        }
        
        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            mDrawerToggle.OnOptionsItemSelected(item);
            return base.OnOptionsItemSelected(item);
        }

        protected override void OnSaveInstanceState(Bundle outState)
        {
            if (mDrawerLayout.IsDrawerOpen((int)GravityFlags.Left)) {
                outState.PutString("DrawerState", "Opened");
            } else {
                outState.PutString("DrawerState", "Closed");
            }
            base.OnSaveInstanceState(outState);
        }
    }
}