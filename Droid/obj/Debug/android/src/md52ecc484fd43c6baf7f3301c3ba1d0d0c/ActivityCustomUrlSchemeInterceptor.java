package md52ecc484fd43c6baf7f3301c3ba1d0d0c;


public class ActivityCustomUrlSchemeInterceptor
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("ComicBook.ActivityCustomUrlSchemeInterceptor, ComicBook.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", ActivityCustomUrlSchemeInterceptor.class, __md_methods);
	}


	public ActivityCustomUrlSchemeInterceptor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == ActivityCustomUrlSchemeInterceptor.class)
			mono.android.TypeManager.Activate ("ComicBook.ActivityCustomUrlSchemeInterceptor, ComicBook.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

	private java.util.ArrayList refList;
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
