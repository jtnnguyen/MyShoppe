using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using ImageCircle.Forms.Plugin.Droid;
using Android.Graphics.Drawables;
using Microsoft.Azure.Mobile;
using Xamarin.Forms.Platform.Android;

namespace MyShop.Droid
{
	[Activity (Label = "My Shoppe", Icon = "@drawable/ic_launcher", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation, ScreenOrientation = ScreenOrientation.Portrait)]
	public class MainActivity : FormsAppCompatActivity
    {
		protected override void OnCreate (Bundle bundle)
		{
            MobileCenter.Configure("da6bcf42-3100-4df2-955f-4fcbce4bf6df");

            FormsAppCompatActivity.ToolbarResource = Resource.Layout.toolbar;
            FormsAppCompatActivity.TabLayoutResource = Resource.Layout.tabs;
            base.OnCreate (bundle);

			global::Xamarin.Forms.Forms.Init (this, bundle);
			global::Xamarin.FormsMaps.Init (this, bundle);

			Microsoft.WindowsAzure.MobileServices.CurrentPlatform.Init();
			
			LoadApplication (new App ());
			ImageCircleRenderer.Init();

		}
	}
}

