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

namespace Unire_Android {
    [Activity(Label = "Unire_Android", MainLauncher = false)]
    public class SendNotification : Activity {
        Button purple_notification;
        Button blue_notification;
        Button green_notification;
        Button yellow_notification;
        Button orange_notification;
        Button red_notification;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);

            purple_notification = FindViewById<Button>(Resource.Id.Purple);
            purple_notification.Click += delegate { notification("Purple", "Notification: purple", "noti_purple", 0); };
            blue_notification = FindViewById<Button>(Resource.Id.Blue);
            blue_notification.Click += delegate { notification("Blue", "Notification: blue", "noti_blue", 1); };
            green_notification = FindViewById<Button>(Resource.Id.Green);
            green_notification.Click += delegate { notification("Green", "Notification: green", "noti_green", 2); };
            yellow_notification = FindViewById<Button>(Resource.Id.Yellow);
            yellow_notification.Click += delegate { notification("Yellow", "Notification: yellow", "noti_yellow", 3); };
            orange_notification = FindViewById<Button>(Resource.Id.Orange);
            orange_notification.Click += delegate { notification("Orange", "Notification: orange", "noti_orange", 4); };
            red_notification = FindViewById<Button>(Resource.Id.Red);
            red_notification.Click += delegate { notification("Red", "Notification: red", "noti_red", 5); };
        }

        public void notification(String title, String text, String icon, int id)
        {
            Intent intent;
            PendingIntent pendingIntent;
            switch(title) 
            {
                case "Purple":
                    intent = new Intent(this, typeof(Purple));
                    intent.PutExtra("title", title);
                    intent.PutExtra("text", text);
                    pendingIntent = purpleIntent(intent);
                    break;
                case "Blue":
                    intent = new Intent(this, typeof(Blue));
                    intent.PutExtra("title", title);
                    intent.PutExtra("text", text);
                    pendingIntent = blueIntent(intent);
                    break;
                case "Green":
                    intent = new Intent(this, typeof(Green));
                    intent.PutExtra("title", title);
                    intent.PutExtra("text", text);
                    pendingIntent = greenIntent(intent);
                    break;
                case "Yellow":
                    intent = new Intent(this, typeof(Yellow));
                    intent.PutExtra("title", title);
                    intent.PutExtra("text", text);
                    pendingIntent = yellowIntent(intent);
                    break;
                case "Orange":
                    intent = new Intent(this, typeof(Orange));
                    intent.PutExtra("title", title);
                    intent.PutExtra("text", text);
                    pendingIntent = orangeIntent(intent);
                    break;
                case "Red":
                    intent = new Intent(this, typeof(Red));
                    intent.PutExtra("title", title);
                    intent.PutExtra("text", text);
                    pendingIntent = redIntent(intent);
                    break;
                default:
                    intent = new Intent(this, typeof(Purple));
                    intent.PutExtra("title", title);
                    intent.PutExtra("text", text);
                    pendingIntent = purpleIntent(intent);
                    break;
            }

            Notification.Builder builder = new Notification.Builder(this)
                .SetContentTitle(title)
                .SetContentText(text)
                .SetContentIntent(pendingIntent)
                .SetDefaults(NotificationDefaults.Sound | NotificationDefaults.Vibrate);

            switch (title)
            {
                case "Purple":
                    builder.SetSmallIcon(Resource.Drawable.noti_purple); break;
                case "Blue":
                    builder.SetSmallIcon(Resource.Drawable.noti_blue); break;
                case "Green":
                    builder.SetSmallIcon(Resource.Drawable.noti_green); break;
                case "Yellow":
                    builder.SetSmallIcon(Resource.Drawable.noti_yellow); break;
                case "Orange":
                    builder.SetSmallIcon(Resource.Drawable.noti_orange); break;
                case "Red":
                    builder.SetSmallIcon(Resource.Drawable.noti_red); break;
                default:
                    builder.SetSmallIcon(Resource.Drawable.noti_purple); break;
            }

            Notification notification = builder.Build();
            notification.Flags = NotificationFlags.AutoCancel;
            NotificationManager notificationManager =
                GetSystemService(Context.NotificationService) as NotificationManager;

            switch (id)
            {
                case 0:
                    launchPurple(notification, notificationManager); break;
                case 1:
                    launchBlue(notification, notificationManager); break;
                case 2:
                    launchGreen(notification, notificationManager); break;
                case 3:
                    launchYellow(notification, notificationManager); break;
                case 4:
                    launchOrange(notification, notificationManager); break;
                case 5:
                    launchRed(notification, notificationManager); break;
                default:
                    launchPurple(notification, notificationManager); break;
            }
        }

        public PendingIntent purpleIntent(Intent intent)
        {
            const int pendingIntentId = 0;
            PendingIntent pendingIntent =
                PendingIntent.GetActivity(this, pendingIntentId, intent, PendingIntentFlags.OneShot);
            return pendingIntent;
        }

        public PendingIntent blueIntent(Intent intent)
        {
            const int pendingIntentId = 1;
            PendingIntent pendingIntent =
                PendingIntent.GetActivity(this, pendingIntentId, intent, PendingIntentFlags.OneShot);
            return pendingIntent;
        }

        public PendingIntent greenIntent(Intent intent)
        {
            const int pendingIntentId = 2;
            PendingIntent pendingIntent =
                PendingIntent.GetActivity(this, pendingIntentId, intent, PendingIntentFlags.OneShot);
            return pendingIntent;
        }

        public PendingIntent yellowIntent(Intent intent)
        {
            const int pendingIntentId = 3;
            PendingIntent pendingIntent =
                PendingIntent.GetActivity(this, pendingIntentId, intent, PendingIntentFlags.OneShot);
            return pendingIntent;
        }

        public PendingIntent orangeIntent(Intent intent)
        {
            const int pendingIntentId = 4;
            PendingIntent pendingIntent =
                PendingIntent.GetActivity(this, pendingIntentId, intent, PendingIntentFlags.OneShot);
            return pendingIntent;
        }

        public PendingIntent redIntent(Intent intent)
        {
            const int pendingIntentId = 5;
            PendingIntent pendingIntent =
                PendingIntent.GetActivity(this, pendingIntentId, intent, PendingIntentFlags.OneShot);
            return pendingIntent;
        }

        public void launchPurple(Notification notification, NotificationManager notificationManager)
        {
            const int notificationId = 0;
            notificationManager.Notify(notificationId, notification);
        }

        public void launchBlue(Notification notification, NotificationManager notificationManager)
        {
            const int notificationId = 1;
            notificationManager.Notify(notificationId, notification);
        }

        public void launchGreen(Notification notification, NotificationManager notificationManager)
        {
            const int notificationId = 2;
            notificationManager.Notify(notificationId, notification);
        }

        public void launchYellow(Notification notification, NotificationManager notificationManager)
        {
            const int notificationId = 3;
            notificationManager.Notify(notificationId, notification);
        }

        public void launchOrange(Notification notification, NotificationManager notificationManager)
        {
            const int notificationId = 4;
            notificationManager.Notify(notificationId, notification);
        }

        public void launchRed(Notification notification, NotificationManager notificationManager)
        {
            const int notificationId = 5;
            notificationManager.Notify(notificationId, notification);
        }

    }
}