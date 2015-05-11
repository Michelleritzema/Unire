using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support;
using Android.Support.V4.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
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
             
        protected override void OnCreate(Bundle bundle)
       
        {

            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);
 
            var button1 = FindViewById<ImageButton>(Resource.Id.ov);
            var button2 = FindViewById<ImageButton>(Resource.Id.imageButton2);
            var button3 = FindViewById<ImageButton>(Resource.Id.imageButton3);
            var button4 = FindViewById<ImageButton>(Resource.Id.imageButton4);
            var button5 = FindViewById<ImageButton>(Resource.Id.imageButton5);
            var button6 = FindViewById<ImageButton>(Resource.Id.imageButton6);
            mLeftDrawer = FindViewById<ListView>(Resource.Id.left_drawer);
           
            button1.Click += delegate
            {
                StartActivity(typeof(SendNotification));



            };

            button2.Click += delegate
            {
                StartActivity(typeof(Orange));



            };
            button3.Click += delegate
            {
                StartActivity(typeof(Purple));



            };
            button4.Click += delegate
            {
                StartActivity(typeof(Red));



            };
            button5.Click += delegate
            {
                StartActivity(typeof(Yellow));



            };
            button6.Click += delegate
            {
                StartActivity(typeof(Green));



            };



            mToolbar = FindViewById<SupportToolbar>(Resource.Id.toolbar);

            mDrawerLayout = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);

            mLeftDrawer = FindViewById<ListView>(Resource.Id.left_drawer);

            SetSupportActionBar(mToolbar);


            mLeftDataSet = new List<String>();
            mLeftDataSet.Add("left item 1");
            mLeftDataSet.Add("left item 2");
            mLeftAdapter = new ArrayAdapter<String>(this, Android.Resource.Layout.SimpleListItem1, mLeftDataSet);
            mLeftDrawer.Adapter = mLeftAdapter;

            
            mLeftDrawer.ItemClick +=mLeftDrawer_ItemClick;
            

          
               
             

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

            else { 
            
          //  first time App ran 
                SupportActionBar.SetTitle(Resource.String.closeDrawer);
            }
        }

        private void mLeftDrawer_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            StartActivity(typeof(Purple));
           // throw new NotImplementedException();
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

    

