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

namespace Unire_Android
{
    [Activity(Label = "Yellow", Icon = "@drawable/iconY", Theme = "@style/MyTheme")]
    public class Yellow : ActionBarActivity
    {
        private SupportToolbar mToolbar;
        private MyActionBarDrawerToggle mDrawerToggle;
        private DrawerLayout mDrawerLayout;
        private ListView mLeftDrawer;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Yellow);
            var textView = FindViewById<TextView>(Resource.Id.textView1);
            //textView.Text = Intent.GetStringExtra("text");

            ConnectionHTTP http_connection = new ConnectionHTTP();
            String line = http_connection.Getline();
            textView.Text = line;

            mToolbar = FindViewById<SupportToolbar>(Resource.Id.toolbar);

            mDrawerLayout = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);

            mLeftDrawer = FindViewById<ListView>(Resource.Id.left_drawer);

            SetSupportActionBar(mToolbar);

            mDrawerToggle = new MyActionBarDrawerToggle(
                this, // host
                mDrawerLayout, // DrawwerLayout
                Resource.String.openDrawer, //opened message
                Resource.String.closeDrawer // closed message
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

                //  first time App ran 
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

    public class ConnectionHTTP : AsyncTask
    {
        String line;
        protected override void OnPreExecute()
        {
            String sURL = "http://www.e-dragon-94311.appspot.com";
            URL url = new URL(sURL);
            HttpURLConnection connection = (HttpURLConnection)url.OpenConnection();
            connection.Connect();
            BufferedReader br = new BufferedReader(new InputStreamReader(connection.InputStream));
            line = br.ReadLine();
            string tag = "unire";
            Log.Info(tag, line);
        }

        protected override Java.Lang.Object DoInBackground(params Java.Lang.Object[] @params)
        {
            return null;
        }

        protected override void OnPostExecute(Java.Lang.Object result)
        {
        }

        internal string Getline()
        {
            return line;
        }
    }
}