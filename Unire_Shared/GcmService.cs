using System.Text;
using Android.App;
using Android.Content;
using Android.Util;
using Gcm.Client;
using Android.Preferences;

using Unire_Android;


namespace Unire_Shared
{

    /* This class communicates with the Google App Messenger. When the user visits
     * the app for the first time, a registration request is send and the id is saved.
     * The back-end uses this id to push notifications to a specific device.
     * After this, everytime the back-end makes a new notification, this class receives
     * the data and calls the CreateNotification class.
     */

    //Mandatory subclass
    //Important note: Make sure the package name does not start with an uppercase letter.
    [BroadcastReceiver(Permission = Constants.PERMISSION_GCM_INTENTS)]
    [IntentFilter(new string[] { Constants.INTENT_FROM_GCM_MESSAGE }, Categories = new string[] { "@PACKAGE_NAME@" })]
    [IntentFilter(new string[] { Constants.INTENT_FROM_GCM_REGISTRATION_CALLBACK }, Categories = new string[] { "@PACKAGE_NAME@" })]
    [IntentFilter(new string[] { Constants.INTENT_FROM_GCM_LIBRARY_RETRY }, Categories = new string[] { "@PACKAGE_NAME@" })]
    
    public class GcmBroadcastReceiver : GcmBroadcastReceiverBase<PushHandlerService>
    {
        //Sender ID (Your Google API Console App Project ID)
        public static string[] SENDER_IDS = new string[] { "587671955885" };
        public const string TAG = "Unire_GCM_Service";
    }

    [Service]
    public class PushHandlerService : GcmServiceBase
    {
        public PushHandlerService() : base(GcmBroadcastReceiver.SENDER_IDS) { }
        const string TAG = "Unire_Push_Handler";

        //This method is called when the user registers for the first time.
        protected override void OnRegistered(Context context, string registrationId)
        {
            Log.Verbose(TAG, "GCM Registered: " + registrationId);
            ISharedPreferences prefs = PreferenceManager.GetDefaultSharedPreferences(this); 
            ISharedPreferencesEditor editor = prefs.Edit();
            editor.PutString("registration_id", registrationId);
            editor.Apply();
        }

		protected override void OnUnRegistered(Context context, string registrationId)
		{
			Log.Info(TAG, "Unregistered");
		}

        //This method is called when a new notification is pushed from the server.
        protected override void OnMessage(Context context, Intent intent)
        {
            Log.Info(TAG, "GCM Message Received!");
            var msg = new StringBuilder();
            if (intent != null && intent.Extras != null)
            {
                foreach (var key in intent.Extras.KeySet())
                    msg.AppendLine(key + "=" + intent.Extras.Get(key).ToString());
            }
            //Store the message
            /*var prefs = GetSharedPreferences(context.PackageName, FileCreationMode.Private);
            var edit = prefs.Edit();
            edit.PutString("last_msg", msg.ToString());
            edit.Commit();*/

            CreateNotification new_notification = new CreateNotification(
                context, "Titel", msg.ToString(), "noti_orange", 4);
        }

        protected override bool OnRecoverableError(Context context, string errorId)
        {
            Log.Warn(TAG, "Recoverable Error: " + errorId);
            return base.OnRecoverableError(context, errorId);
        }

        protected override void OnError(Context context, string errorId)
        {
            Log.Error(TAG, "GCM Error: " + errorId);
        }
    }
}