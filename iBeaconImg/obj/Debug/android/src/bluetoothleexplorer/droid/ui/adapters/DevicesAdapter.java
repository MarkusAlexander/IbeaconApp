package bluetoothleexplorer.droid.ui.adapters;


public class DevicesAdapter
	extends bluetoothleexplorer.droid.GenericAdapterBase_1
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_getView:(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;:GetGetView_ILandroid_view_View_Landroid_view_ViewGroup_Handler\n" +
			"";
		mono.android.Runtime.register ("BluetoothLEExplorer.Droid.UI.Adapters.DevicesAdapter, iBeaconImg, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", DevicesAdapter.class, __md_methods);
	}


	public DevicesAdapter () throws java.lang.Throwable
	{
		super ();
		if (getClass () == DevicesAdapter.class)
			mono.android.TypeManager.Activate ("BluetoothLEExplorer.Droid.UI.Adapters.DevicesAdapter, iBeaconImg, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public android.view.View getView (int p0, android.view.View p1, android.view.ViewGroup p2)
	{
		return n_getView (p0, p1, p2);
	}

	private native android.view.View n_getView (int p0, android.view.View p1, android.view.ViewGroup p2);

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
