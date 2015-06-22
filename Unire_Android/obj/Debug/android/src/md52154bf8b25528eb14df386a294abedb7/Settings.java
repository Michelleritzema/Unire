package md52154bf8b25528eb14df386a294abedb7;


public class Settings
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("Unire_Android.com.unire.activities.Settings, Unire_Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", Settings.class, __md_methods);
	}


	public Settings () throws java.lang.Throwable
	{
		super ();
		if (getClass () == Settings.class)
			mono.android.TypeManager.Activate ("Unire_Android.com.unire.activities.Settings, Unire_Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

	java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
