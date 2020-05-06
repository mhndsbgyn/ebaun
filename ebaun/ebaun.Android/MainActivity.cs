using Acr.UserDialogs;
using Android.App;
using Android.OS;
using Plugin.FirebasePushNotification;
using Xamarin.Forms.Platform.Android;

namespace ebaun.Droid
{
    [Activity(Label = "ebaun", Icon = "@drawable/xamarin_logo", Theme = "@style/MainTheme", MainLauncher = true)]
    public class MainActivity : FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;
            base.OnCreate(bundle);
            global::Xamarin.Forms.Forms.Init(this, bundle);

            UserDialogs.Init(this);
            LoadApplication(new App());
            FirebasePushNotificationManager.ProcessIntent(this, Intent);
          

        }

    }
}