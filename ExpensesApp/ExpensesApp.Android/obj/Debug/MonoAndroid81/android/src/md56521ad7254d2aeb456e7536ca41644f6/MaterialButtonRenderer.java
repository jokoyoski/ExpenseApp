package md56521ad7254d2aeb456e7536ca41644f6;


public class MaterialButtonRenderer
	extends md58432a647068b097f9637064b8985a5e0.ButtonRenderer
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("XF.Material.Droid.Renderers.MaterialButtonRenderer, XF.Material.Droid", MaterialButtonRenderer.class, __md_methods);
	}


	public MaterialButtonRenderer (android.content.Context p0)
	{
		super (p0);
		if (getClass () == MaterialButtonRenderer.class)
			mono.android.TypeManager.Activate ("XF.Material.Droid.Renderers.MaterialButtonRenderer, XF.Material.Droid", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public MaterialButtonRenderer (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == MaterialButtonRenderer.class)
			mono.android.TypeManager.Activate ("XF.Material.Droid.Renderers.MaterialButtonRenderer, XF.Material.Droid", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public MaterialButtonRenderer (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == MaterialButtonRenderer.class)
			mono.android.TypeManager.Activate ("XF.Material.Droid.Renderers.MaterialButtonRenderer, XF.Material.Droid", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}

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
