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
using Java.Util;

using SupportToolbar = Android.Support.V7.Widget.Toolbar;

namespace Unire_Android
{
    [Activity(Label = "Blue", Icon = "@drawable/iconB", Theme = "@style/MyTheme")]
    public class CategoryMethods
    {

        public List<string> setOlderNotifications(string[] notifications)
        {
            List<string> old_notifications;
            old_notifications = new List<string>();
            for (int i = 0; i < notifications.Length; i++)
            {
                old_notifications.Add(notifications[i]);
            }
            return old_notifications;
        }
    }
}