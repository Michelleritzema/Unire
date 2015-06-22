using Android.App;
using Android.Content;
using Android.Preferences;
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
        private String newURL;

        public Setup()
        {
            this.loginURL = "http://e-dragon-94311.appspot.com/login";
            this.gradesURL = "http://e-dragon-94311.appspot.com/grades";
            this.newURL = "http://e-dragon-94311.appspot.com/newData";
        }

        public String getLoginURL()
        {
            return loginURL;
        }

        public String getGradesURL()
        {
            return gradesURL;
        }

        public String getNewURL()
        {
            return newURL;
        }

        public void saveSharedPreferences(Context context, string name, string notification)
        {
            ISharedPreferences prefs = PreferenceManager.GetDefaultSharedPreferences(context);
            ISharedPreferencesEditor editor = prefs.Edit();
            editor.PutString(name, notification);
            editor.Apply();
        }

        public string getSharedPreferences(Context context, string name)
        {
            ISharedPreferences prefs = PreferenceManager.GetDefaultSharedPreferences(context);
            string notification = prefs.GetString(name, null);
            return notification;
        }

        public String getGradeNotification(Context context)
        {
            return getSharedPreferences(context, "Grade");
        }

        public void setGradeNotification(Context context, string gradeNotification)
        {
            saveSharedPreferences(context, "Grade", gradeNotification);
        }
    }
}