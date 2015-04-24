using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Unire_Android {
    [Activity(Label = "Unire_Android", MainLauncher = true, Icon = "@drawable/icon")]
    
	public class MainActivity : Activity {

        protected override void OnCreate(Bundle bundle) {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);

            Button purple_notification = FindViewById<Button>(Resource.Id.Purple);
            purple_notification.Click += delegate { notification("Purple", "Notification: purple", "noti_purple"); };
            Button blue_notification = FindViewById<Button>(Resource.Id.Blue);
            blue_notification.Click += delegate { notification("Blue", "Notification: blue", "noti_blue"); };
            Button green_notification = FindViewById<Button>(Resource.Id.Green);
            green_notification.Click += delegate { notification("Green", "Notification: green", "noti_green"); };
            Button yellow_notification = FindViewById<Button>(Resource.Id.Yellow);
            yellow_notification.Click += delegate { notification("Yellow", "Notification: yellow", "noti_yellow"); };
            Button orange_notification = FindViewById<Button>(Resource.Id.Orange);
            orange_notification.Click += delegate { notification("Orange", "Notification: orange", "noti_orange"); };
            Button red_notification = FindViewById<Button>(Resource.Id.Red);
            red_notification.Click += delegate { notification("Red", "Notification: red", "noti_red"); };
        }

		public void notification(String title, String text, String icon) {
			// Instantiate the builder and set notification elements:
            Notification.Builder builder = new Notification.Builder(this)
                .SetContentTitle(title)
                .SetContentText(text)
                .SetDefaults(NotificationDefaults.Sound | NotificationDefaults.Vibrate);
				
            switch() {
                case Purple:

            }

                builder.SetSmallIcon(Resource.Drawable.noti_purple);
                
                

			// Build the notification:
			Notification notification = builder.Build();

			// Get the notification manager:
			NotificationManager notificationManager =
				GetSystemService(Context.NotificationService) as NotificationManager;

			// Publish the notification:
			const int notificationId = 0;
			notificationManager.Notify(notificationId, notification);
		}
    }
}

