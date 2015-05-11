using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.Support;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SupportActionBarDrawerToggle = Android.Support.V7.App.ActionBarDrawerToggle;
using Android.Support.V7.App;
using Android.Support.V4.Widget;

namespace Unire_Android
{
    [Activity(Label = "MyActionBarDrawerToggle")]
    public class MyActionBarDrawerToggle : SupportActionBarDrawerToggle
    {
        private ActionBarActivity mHostActivity;
        private int mOpendResource;
        private int mClosedResource;

        public MyActionBarDrawerToggle(ActionBarActivity host,DrawerLayout drawerlayout,int opendedResource,int closedResource)
        :base(host,drawerlayout,opendedResource,closedResource){
        
            mHostActivity = host;
            mOpendResource = opendedResource;
            mClosedResource = closedResource;
            // Create your application here
        }
         public override void OnDrawerOpened(View drawerView)
         {            
             int drawerType = (int)drawerView.Tag;

             if (drawerType == 0)
             {
                 base.OnDrawerOpened(drawerView);
                 mHostActivity.SupportActionBar.SetTitle(mOpendResource);
             }  
        }

         public override void OnDrawerClosed(View drawerView)
         {
             int drawerType = (int)drawerView.Tag;

             if (drawerType == 0)
             {

                 base.OnDrawerClosed(drawerView);
                 mHostActivity.SupportActionBar.SetTitle(mClosedResource);
             }
         }
         public override void OnDrawerSlide(View drawerView, float slideOffset)
         {
             int drawerType = (int)drawerView.Tag;

             if (drawerType == 0)
             {
                 base.OnDrawerSlide(drawerView, slideOffset);
             }

         }
    }  
}
