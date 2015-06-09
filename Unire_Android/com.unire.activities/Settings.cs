using Android.App;
using Android.OS;

namespace Unire_Android
{
    [Activity(Label = "Unire", MainLauncher = false, Icon = "@drawable/icon", Theme = "@style/MyTheme")]
    public class Settings : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Settings);
        }
    }
}