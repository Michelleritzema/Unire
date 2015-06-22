using Android.Content;
using Java.Lang;
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
            //This method is called to check for new notifications asynchronously
            Task task = AsyncPullNotifications(context);
        }

        public void createNotification(Context context, string title, string notification)
        {
            //This class creates a notification according to the data provided.
            switch (title)
            {
                case "Grade":
                    CreateNotification new_notification = new CreateNotification(
                        context, title, notification, "noti_orange", 4); break;
                default:
                    break;
            }
        }

        public static async Task<string> getStringAsync(string url)
        {
            var httpClient = new HttpClient();
            return await httpClient.GetStringAsync(url);
        }


        public async Task AsyncPullNotifications(Context context)
        {
            while(true)
            {
                //System.Console.WriteLine(await getStringAsync(gradesURL));
                string grade_noti = await getStringAsync(gradesURL);
                createNotification(context, "Grade", grade_noti);
                //Sleep for 5 minutes
                Thread.Sleep(1000 * 60 * 5);
            }
        }
    }
}