using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Java.IO;
using Java.Lang;
using Java.Net;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

using Unire_Android;


namespace Unire_Shared
{
	public class HttpDataConnection
	{

       /* This class creates a WebClient that connects to the specific URL provided.
        * The content of the webpage is collected and saved in the string 'notification'.
        * Then the class CreateNotification is called, which creates a new notification
        * to alert the user.
        */

        private string gradesURL;
        private WebClient webclient;

        public HttpDataConnection(Context context)
        {
            webclient = new WebClient();
            gradesURL = new Setup().getGradesURL();

            //This method runs every five minutes to check for notifications
            while(true)
            {
                string grade_noti = getGradeNotification(gradesURL);
                createNotification(context, "Grade", grade_noti);
                //Sleep for 5 minutes
                Thread.Sleep(1000 * 60 * 5);
            }
        }

        public string getGradeNotification(string url)
        {
            string notification = webclient.DownloadString(url);
            return notification;
        }

        public void createNotification(Context context, string title, string notification)
        {
            //This class creates a notification according to the data provided.
            string img_type = null;
            int noti_type = 0;
            switch (title)
            {
                case "Grade":
                    img_type = "noti_orange";
                    noti_type = 4;
                    break;
                default:
                    break;
            }
            if (img_type != null && noti_type != 0)
            {
                CreateNotification new_notification = new CreateNotification(
                    context, title, notification, img_type, noti_type);
            }
        }
    }
}