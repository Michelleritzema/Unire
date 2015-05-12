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

namespace Unire_Android
{
    [Activity(Label = "Red", Icon = "@drawable/iconR", Theme = "@style/MyTheme")]
    public class Red : ActionBarActivity
    {

        private SupportToolbar mToolbar;
        private MyActionBarDrawerToggle mDrawerToggle;
        private DrawerLayout mDrawerLayout;
        private ListView mLeftDrawer;
    
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Red);
           var textView = FindViewById<TextView>(Resource.Id.textView1);
            textView.Text = Intent.GetStringExtra("text");

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
}