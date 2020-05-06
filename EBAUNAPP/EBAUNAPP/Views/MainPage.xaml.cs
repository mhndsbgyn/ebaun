using EBAUNAPP.Models;
using Plugin.FirebasePushNotification;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EBAUNAPP.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MainPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;

            MenuPages.Add((int)MenuItemType.Duyurular, (NavigationPage)Detail);

            FireBase();
        }

        private void FireBase()
        {
            CrossFirebasePushNotification.Current.RegisterForPushNotifications();
            CrossFirebasePushNotification.Current.UnsubscribeAll();
            CrossFirebasePushNotification.Current.Subscribe("news");
            CrossFirebasePushNotification.Current.OnNotificationOpened += (s, p) =>
            {
                CrossFirebasePushNotification.Current.ClearAllNotifications();
            };
        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemType.Duyurular:
                        MenuPages.Add(id, new NavigationPage(new ItemsPage()));
                        break;
                    case (int)MenuItemType.Hakkında:
                        MenuPages.Add(id, new NavigationPage(new AboutPage()));
                        break;
                    case (int)MenuItemType.Egitmen_Girisi:
                        MenuPages.Add(id, new NavigationPage(new TeacherPage()));
                        break;
                    case (int)MenuItemType.Ayarlar:
                        MenuPages.Add(id, new NavigationPage(new SettingsPage()));
                        break;
                    case (int)MenuItemType.Egitmen_Duyuru_Sayfası:
                        MenuPages.Add(id, new NavigationPage(new TeacherAddPage()));
                        break;
                }
            }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }
    }
}