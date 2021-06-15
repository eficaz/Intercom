package crc6483587f0d766bb941;


public class JSBridge
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_InvokeAction:(Ljava/lang/String;)V:__export__\n" +
			"";
		mono.android.Runtime.register ("Intercomapp.Droid.JSBridge, Intercomapp.Android", JSBridge.class, __md_methods);
	}


	public JSBridge ()
	{
		super ();
		if (getClass () == JSBridge.class)
			mono.android.TypeManager.Activate ("Intercomapp.Droid.JSBridge, Intercomapp.Android", "", this, new java.lang.Object[] {  });
	}

	public JSBridge (crc6483587f0d766bb941.HybridWebViewRenderer p0)
	{
		super ();
		if (getClass () == JSBridge.class)
			mono.android.TypeManager.Activate ("Intercomapp.Droid.JSBridge, Intercomapp.Android", "Intercomapp.Droid.HybridWebViewRenderer, Intercomapp.Android", this, new java.lang.Object[] { p0 });
	}

	@android.webkit.JavascriptInterface

	public void invokeAction (java.lang.String p0)
	{
		n_InvokeAction (p0);
	}

	private native void n_InvokeAction (java.lang.String p0);

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
