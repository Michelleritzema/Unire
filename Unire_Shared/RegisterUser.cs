using Android.Content;
using Android.App;


public class RegisterUser
{
	public RegisterUser() {
		string senders = "<Google Cloud Messaging Sender ID>";
		Intent intent = new Intent("com.google.android.c2dm.intent.REGISTER");
		intent.SetPackage("com.google.android.gsf");
		intent.PutExtra("app", PendingIntent.GetBroadcast(context, 0, new Intent(), 0));
		intent.PutExtra("sender", senders);
		context.StartService(intent);
	}
}