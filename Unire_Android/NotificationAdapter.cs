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


namespace Unire_Android
{
    [Activity(Label = "Unire_Android", MainLauncher = false, Icon = "@drawable/icon", Theme = "@style/MyTheme")]
    public class NotificationAdapter : BaseAdapter<string>
    {
        private List<string> notifications;
        private Context activityContext;

        public NotificationAdapter(Context context, List<string> items)
        {
            notifications = items;
            activityContext = context;
        }

        public override int Count
        {
            get { return notifications.Count; }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override string this[int position]
        {
            get { return notifications[position]; }
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View row = convertView;
            if(row == null) {
                row = LayoutInflater.From(activityContext).Inflate(Resource.Layout.NotificationRow, null, false);
            }
            TextView notification_row = row.FindViewById<TextView>(Resource.Id.notification_row);
            notification_row.Text = notifications[position];

            return row;
        }
    }
}

    

