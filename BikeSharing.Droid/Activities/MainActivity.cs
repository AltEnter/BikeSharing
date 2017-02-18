using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content.PM;

using FFImageLoading.Forms.Droid;

namespace BikeSharing.Droid
{
    [Activity(
        Label             = "BikeSharing.Droid",
        Icon              = "@drawable/icon",
        Theme             = "@style/MainTheme",
        ScreenOrientation = ScreenOrientation.Portrait
        )]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            CachedImageRenderer.Init();
            LoadApplication(new App());
        }
    }
}

