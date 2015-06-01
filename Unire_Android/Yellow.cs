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
using System.Net;
using System.IO;
using Java.Net;
using Java.IO;
using Android.Util;
using Java.Lang;
using System.Threading.Tasks;
using System.Net.Http;
using Unire_Shared;


namespace Unire_Android
{
    [Activity(Label = "Yellow", Icon = "@drawable/iconY", Theme = "@style/MyTheme")]
    public class Yellow : ActionBarActivity
    {

        private SupportToolbar mToolbar;
        private MyActionBarDrawerToggle mDrawerToggle;
        private DrawerLayout mDrawerLayout;
        private ListView mLeftDrawer;
        TextView textView;
        string notification;


        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Yellow);
            textView = FindViewById<TextView>(Resource.Id.textView1);
            
            
            //Thread.Sleep(3500);
            
            //task.Start();
            //string contents = task.Result;
            //Toast.MakeText(Application.Context, contents, ToastLength.Short).Show();
            
            //string notificationData = connection.getNotificationData();
            //Toast.MakeText(Application.Context, notificationData, ToastLength.Short).Show();
            //textView.Text = notificationData;

            //textView.Text = Intent.GetStringExtra("text");
            //ConnectionHTTP http_connection = new ConnectionHTTP();
            //String line = http_connection.getLine();
			//Toast.MakeText (Application.Context, line, ToastLength.Long).Show();
            //textView.Text = line;

            mToolbar = FindViewById<SupportToolbar>(Resource.Id.toolbar);
            mDrawerLayout = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);
            mLeftDrawer = FindViewById<ListView>(Resource.Id.left_drawer);
            SetSupportActionBar(mToolbar);
            mDrawerToggle = new MyActionBarDrawerToggle(
                this, mDrawerLayout, Resource.String.openDrawer, Resource.String.closeDrawer 
            );
            mDrawerLayout.SetDrawerListener(mDrawerToggle);
            SupportActionBar.SetHomeButtonEnabled(true);
            SupportActionBar.SetDisplayShowTitleEnabled(true);
            mDrawerToggle.SyncState();

            if (bundle != null)
            {
                if (bundle.GetString("Drawer state") == "openend")
                {
                    SupportActionBar.SetTitle(Resource.String.openDrawer);
                }
                else
                {
                    SupportActionBar.SetTitle(Resource.String.closeDrawer);
                }
            }
            else
            {
                SupportActionBar.SetTitle(Resource.String.closeDrawer);
            }
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            mDrawerToggle.OnOptionsItemSelected(item);
            return base.OnOptionsItemSelected(item);
        }

        protected override void OnSaveInstanceState(Bundle outState)
        {
            if (mDrawerLayout.IsDrawerOpen((int)GravityFlags.Left))
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