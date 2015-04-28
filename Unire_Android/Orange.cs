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

namespace Unire_Android
{
    [Activity(Label = "Orange")]
    public class Orange : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Orange);
            var textView = FindViewById<TextView>(Resource.Id.textView1);
            textView.Text = Intent.GetStringExtra("text");
        }
    }
}