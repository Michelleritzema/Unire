using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Java.IO;
using Java.Net;
using Java.Lang;
using System.Net;
using System.Threading.Tasks;
using System.Net.Http;

using Unire_Android;

namespace Unire_Shared
{
	public class HttpDataConnection
	{
        public HttpDataConnection(string url, Context context)
        {
            System.Net.WebClient wc = new System.Net.WebClient();
            string notification = wc.DownloadString(url);
            CreateNotification new_notification = new CreateNotification(context, "Cijfer", notification, "noti_orange", 4);
        }
    }
}
