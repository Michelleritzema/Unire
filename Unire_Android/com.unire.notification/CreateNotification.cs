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
using System.Linq;
using System.Text;

using SupportToolbar = Android.Support.V7.Widget.Toolbar;


namespace Unire_Android {
    public class CreateNotification
    {

       /* This class creates a notification for the user. It requires a notification title,
        * a body, an icon and an id (to determine the type of notification).
        */

        public CreateNotification(Context context, String title, String text, String icon, int id)
        {
            Intent intent;
            PendingIntent pendingIntent;
            switch (title)
            {
                case "Purple":
                    intent = new Intent(context, typeof(Purple));
                    intent.PutExtra("title", title);
                    intent.PutExtra("text", text);
                    pendingIntent = purpleIntent(intent, context);
                    break;
                case "Blue":
                    intent = new Intent(context, typeof(CategoryMethods));
                    intent.PutExtra("title", title);
                    intent.PutExtra("text", text);
                    pendingIntent = blueIntent(intent, context);
                    break;
                case "Green":
                    intent = new Intent(context, typeof(Green));
                    intent.PutExtra("title", title);
                    intent.PutExtra("text", text);
                    pendingIntent = greenIntent(intent, context);
                    break;
                case "Yellow":
                    intent = new Intent(context, typeof(Yellow));
                    intent.PutExtra("title", title);
                    intent.PutExtra("text", text);
                    pendingIntent = yellowIntent(intent, context);
                    break;
                case "Grade":
                    intent = new Intent(context, typeof(Orange));
                    intent.PutExtra("title", title);
                    intent.PutExtra("text", text);
                    pendingIntent = orangeIntent(intent, context);
                    break;
                case "Red":
                    intent = new Intent(context, typeof(Red));
                    intent.PutExtra("title", title);
                    intent.PutExtra("text", text);
                    pendingIntent = redIntent(intent, context);
                    break;
                default:
                    intent = new Intent(context, typeof(Purple));
                    intent.PutExtra("title", title);
                    intent.PutExtra("text", text);
                    pendingIntent = purpleIntent(intent, context);
                    break;
            }

            //The notification builder sets the notification's title and text
            // It also gives the notification permission to use sound and vibrate the device
            Notification.Builder builder = new Notification.Builder(context)
                .SetContentTitle(title)
                .SetContentText(text)
                .SetContentIntent(pendingIntent)
                .SetDefaults(NotificationDefaults.Sound | NotificationDefaults.Vibrate);

            //Determine which notification logo to use
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
                case "Grade":
                    builder.SetSmallIcon(Resource.Drawable.noti_orange); break;
                case "Red":
                    builder.SetSmallIcon(Resource.Drawable.noti_red); break;
                default:
                    builder.SetSmallIcon(Resource.Drawable.noti_purple); break;
            }

            Notification notification = builder.Build();
            notification.Flags = NotificationFlags.AutoCancel;
            NotificationManager notificationManager =
                context.GetSystemService(Context.NotificationService) as NotificationManager;

            //Launch the creation of the notification
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

        public PendingIntent purpleIntent(Intent intent, Context context)
        {
            const int pendingIntentId = 0;
            PendingIntent pendingIntent =
                PendingIntent.GetActivity(context, pendingIntentId, intent, PendingIntentFlags.OneShot);
            return pendingIntent;
        }

        public PendingIntent blueIntent(Intent intent, Context context)
        {
            const int pendingIntentId = 1;
            PendingIntent pendingIntent =
                PendingIntent.GetActivity(context, pendingIntentId, intent, PendingIntentFlags.OneShot);
            return pendingIntent;
        }

        public PendingIntent greenIntent(Intent intent, Context context)
        {
            const int pendingIntentId = 2;
            PendingIntent pendingIntent =
                PendingIntent.GetActivity(context, pendingIntentId, intent, PendingIntentFlags.OneShot);
            return pendingIntent;
        }

        public PendingIntent yellowIntent(Intent intent, Context context)
        {
            const int pendingIntentId = 3;
            PendingIntent pendingIntent =
                PendingIntent.GetActivity(context, pendingIntentId, intent, PendingIntentFlags.OneShot);
            return pendingIntent;
        }

        public PendingIntent orangeIntent(Intent intent, Context context)
        {
            const int pendingIntentId = 4;
            PendingIntent pendingIntent =
                PendingIntent.GetActivity(context, pendingIntentId, intent, PendingIntentFlags.OneShot);
            return pendingIntent;
        }

        public PendingIntent redIntent(Intent intent, Context context)
        {
            const int pendingIntentId = 5;
            PendingIntent pendingIntent =
                PendingIntent.GetActivity(context, pendingIntentId, intent, PendingIntentFlags.OneShot);
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