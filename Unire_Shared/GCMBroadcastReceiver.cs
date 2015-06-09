using Android.Content;


[Unire_Shared(Permission = "com.google.android.c2dm.permission.SEND")]
[IntentFilter(new string[] { "com.google.android.c2dm.intent.RECEIVE" }, Categories = new string[] { "@PACKAGE_NAME@" })]
[IntentFilter(new string[] { "com.google.android.c2dm.intent.REGISTRATION" }, Categories = new string[] { "@PACKAGE_NAME@" })]
[IntentFilter(new string[] { "com.google.android.gcm.intent.RETRY" }, Categories = new string[] { "@PACKAGE_NAME@" })]

    /* Description here
     */

public class GCMBroadcastReceiver : BroadcastReceiver
{
    const string TAG = "PushHandlerBroadcastReceiver";
    public override void OnReceive(Context context, Intent intent)
    {
        MyIntentService.RunIntentInService(context, intent);
        SetResult(Result.Ok, null, null);
    }
}