package md5082d994e7a2812d3143c674da8e591a4;


public class Homescreen
	extends android.support.v7.app.ActionBarActivity
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("Unire_Android.Homescreen, Unire_Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", Homescreen.class, __md_methods);
	}


	public Homescreen () throws java.lang.Throwable
	{
		super ();
		if (getClass () == Homescreen.class)
			mono.android.TypeManager.Activate ("Unire_Android.Homescreen, Unire_Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
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
