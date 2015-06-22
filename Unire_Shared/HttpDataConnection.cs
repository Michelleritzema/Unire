using Android.Content;
using Android.Preferences;
using Android.Util;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Unire_Android;
using Unire_Android.Resources;


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
        private string newURL;
        private WebClient webclient;
        private string tag = "httpconnection";

        public HttpDataConnection(Context context)
        {
            webclient = new WebClient();
            gradesURL = new Setup().getGradesURL();
            newURL = new Setup().getNewURL();
        }

        public void createPullTask(Context context)
        {
            //Task task = AsyncPullNotifications(context);
            Log.Info(tag, "Start a new thread");
            ThreadPool.QueueUserWorkItem(o => continuousPull(context));
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

        public async Task continuousPull(Context context)
        {
            while (true)
            {
                string grade_noti = await getStringAsync(gradesURL);
                Setup setup = new Setup();
                string notification = setup.getGradeNotification(context);

                if (notification == null || !notification.Equals(grade_noti))
                {
                    setup.setGradeNotification(context, grade_noti);
                    createNotification(context, "Grade", grade_noti);
                }
                //Sleep for 5 minutes
                Thread.Sleep(1000 * 60 * 1);
            }
        }

        public void SendLoginInformation(string url, User user)
        {
            //Send the user credentials to the back-end
            DictionaryStrings(url, user);
        }

        async void DictionaryStrings(string url, User user)
        {
            var Client = new HttpClient();
            //fetch the login URL from the Setup class
            var values = new Dictionary<string, string>
            {
                { "username", user.userName},
                { "password", user.password},
                { "regId", user.key}
            };

            var content = new FormUrlEncodedContent(values);
            var response = await Client.PostAsync(url, content);
            var responseString = await response.Content.ReadAsStringAsync();
        }
    }
}