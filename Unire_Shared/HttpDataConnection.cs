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

    /* This class creates a WebClient that connects to the specific URL provided.
     * The content of the webpage is collected and saved in the string 'notification'.
     * Then the class CreateNotification is called, which creates a new notification
     * to alert the user.
     */

	public class HttpDataConnection
	{
        public HttpDataConnection(string url, Context context)
        {
            System.Net.WebClient wc = new System.Net.WebClient();
            string notification = wc.DownloadString(url);
            //CreateNotification new_notification = new CreateNotification(
            //    context, "Cijfer", notification, "noti_orange", 4);
        }
    }
}