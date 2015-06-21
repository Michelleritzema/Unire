using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Unire_Android.Resources
{

    /* This User class contains a username, password and a key.
     * The user object will be sent to the back-end of this application.
     * The key is a randomly generated string by Google, used to
     * send push messages to a particular device.
     */
    
    class User
    {
        public string userName { get; set; }
        public string password { get; set; }
        public string key { get; set; }
    }
}