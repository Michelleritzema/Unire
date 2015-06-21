using System;

namespace Unire_Shared
{

    /* This class creates a WebClient that connects to the specific URL provided.
     * The content of the webpage is collected and saved in the string 'notification'.
     * Then the class CreateNotification is called, which creates a new notification
     * to alert the user.
     */

	public class Setup
	{

        private String loginURL;

        public Setup()
        {
            this.loginURL = "http://e-dragon-94311.appspot.com/login";
        }

        public String getLoginURL()
        {
            return loginURL;
        }
    }
}