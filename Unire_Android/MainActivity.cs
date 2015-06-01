using Android.App;
using Android.Content;
using Android.Locations;
using Android.OS;
using Android.Runtime;
using Android.Support;
using Android.Support.V4.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;

using Unire_Shared;
using SupportToolbar = Android.Support.V7.Widget.Toolbar;


namespace Unire_Android
{
    [Activity(Label = "Unire_Android", MainLauncher = false, Icon = "@drawable/icon", Theme = "@style/MyTheme")]
    public class MainActivity : ActionBarActivity
    {

        private SupportToolbar mToolbar;
        private MyActionBarDrawerToggle mDrawerToggle;
        private DrawerLayout mDrawerLayout;
        private ListView mLeftDrawer;
        private ArrayAdapter  mLeftAdapter;
        private List<String> mLeftDataSet;
        private String url = "http://www.e-dragon-94311.appspot.com/grades";
             
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);
            HttpDataConnection connection = new HttpDataConnection(url);

            mToolbar = FindViewById<SupportToolbar>(Resource.Id.toolbar);
            SetSupportActionBar(mToolbar);
            /*mDrawerLayout = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);
            mLeftDrawer = FindViewById<ListView>(Resource.Id.left_drawer);
            mLeftDataSet = new List<String>();
            mLeftDataSet.Add("left item 1");
            mLeftDataSet.Add("left item 2");
            mLeftAdapter = new ArrayAdapter<String>(this, Android.Resource.Layout.SimpleListItem1, mLeftDataSet);
            mLeftDrawer.Adapter = mLeftAdapter;
            mLeftDrawer.ItemClick += mLeftDrawer_ItemClick;
            mDrawerToggle = new MyActionBarDrawerToggle (this, mDrawerLayout, 
                Resource.String.openDrawer, Resource.String.closeDrawer);
            mDrawerLayout.SetDrawerListener(mDrawerToggle);
            SupportActionBar.SetHomeButtonEnabled(true);
            SupportActionBar.SetDisplayShowTitleEnabled(true);
            mDrawerToggle.SyncState();
            if(bundle != null) {
                if(bundle.GetString("Drawer state") == "openend") {
                    SupportActionBar.SetTitle(Resource.String.openDrawer);
                } else {
                    SupportActionBar.SetTitle(Resource.String.closeDrawer);
                }
            } else { SupportActionBar.SetTitle(Resource.String.closeDrawer); }*/

            var button_weather = FindViewById<ImageButton>(Resource.Id.logo_weather);
            var button_tasks = FindViewById<ImageButton>(Resource.Id.logo_tasks);
            var button_notes = FindViewById<ImageButton>(Resource.Id.logo_notes);
            var button_calendar = FindViewById<ImageButton>(Resource.Id.logo_calendar);
            var button_ov = FindViewById<ImageButton>(Resource.Id.logo_ov);
            var button_settings = FindViewById<ImageButton>(Resource.Id.logo_settings);

            button_weather.Click += delegate { StartActivity(typeof(SendNotification)); };
            button_tasks.Click += delegate { StartActivity(typeof(Orange)); };
            button_notes.Click += delegate { StartActivity(typeof(Purple)); };
            button_calendar.Click += delegate { StartActivity(typeof(Red)); };
            button_ov.Click += delegate { StartActivity(typeof(Yellow)); };
            button_settings.Click += delegate { StartActivity(typeof(Green)); };
        }

        private void mLeftDrawer_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            StartActivity(typeof(Purple));
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {            
            mDrawerToggle.OnOptionsItemSelected(item);
 	        return base.OnOptionsItemSelected(item);
        }

        protected override void OnSaveInstanceState(Bundle outState)
        {
            if(mDrawerLayout.IsDrawerOpen((int)GravityFlags.Left)) {
                outState.PutString("DrawerState", "Opened");
            } else {
                outState.PutString("DrawerState", "Closed");
            }
            base.OnSaveInstanceState(outState);
        }                       
    }
}

    

