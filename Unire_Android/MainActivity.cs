using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Unire_Android
{
    [Activity(Label = "Unire_Android", MainLauncher = false, Icon = "@drawable/icon")]

    public class MainActivity : Activity
    {

        protected override void OnCreate(Bundle bundle)
        {

            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Menu);
            var button1 = FindViewById<ImageButton> (Resource.Id.ov);
            var button2 = FindViewById<ImageButton>(Resource.Id.imageButton2);
            var button3 = FindViewById<ImageButton>(Resource.Id.imageButton3);
            var button4 = FindViewById<ImageButton>(Resource.Id.imageButton4);
            var button5 = FindViewById<ImageButton>(Resource.Id.imageButton5);
            var button6 = FindViewById<ImageButton>(Resource.Id.imageButton6);



            button1.Click += delegate
            
                {
                    StartActivity(typeof(Blue));

                
                
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

        }
    }
};


    

