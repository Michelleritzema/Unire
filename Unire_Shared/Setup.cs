using System;

namespace Unire_Shared
{

   /* In this class all the general settings are set.
    * It contains all the URLs that the app gets its data from.
    */

	public class Setup
	{

        private String loginURL;
        private String gradesURL;

        public Setup()
        {
            this.loginURL = "http://e-dragon-94311.appspot.com/login";
            this.gradesURL = "http://e-dragon-94311.appspot.com/grades";
        }

        public String getLoginURL()
        {
            return loginURL;
        }

        public String getGradesURL()
        {
            return gradesURL;
        }
    }
}