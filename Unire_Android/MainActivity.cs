using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Unire_Android {
    [Activity(Label = "Unire_Android", MainLauncher = false, Icon = "@drawable/icon")]
    
	public class MainActivity : Activity {

        protected override void OnCreate(Bundle bundle) {
            //base.OnCreate(bundle);
            //SetContentView(Resource.Layout.Main);

            Intent intent = new Intent(this, typeof(SendNotification));
            StartActivity(intent);
            //Finish();

        }

    }
}

