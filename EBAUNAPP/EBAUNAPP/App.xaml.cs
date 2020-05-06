using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using EBAUNAPP.Views;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace EBAUNAPP
{
    public partial class App : Application
    {

        public App()
        {
          Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MjQ1NzI1QDMxMzgyZTMxMmUzME5VdjFOWGZqU1VENC9KMnBxVTVYUCt3bWZJWkw0ZGoxM2F4N0xrZ0M5Y0E9");



            InitializeComponent();


            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
