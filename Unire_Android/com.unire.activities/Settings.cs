using Android.App;
using Android.OS;
using Android.Widget;
using System;


namespace Unire_Android.com.unire.activities
{
    [Activity(Label = "Unire", MainLauncher = false, Icon = "@drawable/icon", Theme = "@style/MyTheme")]
    public class Settings : Activity
    {
        private string days;
        RadioButton mDays1 = null;
        RadioButton mDays2 = null;
        RadioButton mDays3 = null;
        RadioButton mDays4 = null;
        TextView mDaysSet;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Green);

            RadioGroup radioGroup = FindViewById<RadioGroup>(Resource.Id.RadioGroup1);
            mDays1 = FindViewById<RadioButton>(Resource.Id.Radio1);
            mDays2 = FindViewById<RadioButton>(Resource.Id.Radio2);
            mDays3 = FindViewById<RadioButton>(Resource.Id.Radio3);
            mDays4 = FindViewById<RadioButton>(Resource.Id.Radio4);


            mDays1.Click += RadioButtonClick;
            mDays2.Click += RadioButtonClick;
            mDays3.Click += RadioButtonClick;
            mDays4.Click += RadioButtonClick;
            mDaysSet.Text = days;

        }

        public void RadioButtonClick(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            Toast.MakeText(this, rb.Text, ToastLength.Short).Show();
            days = rb.Text;

        }

    }
}




