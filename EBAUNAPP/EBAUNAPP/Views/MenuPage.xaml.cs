using EBAUNAPP.Models;
using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace EBAUNAPP.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }
        List<HomeMenuItem> menuItems;
       

       
        public MenuPage()
        {
            InitializeComponent();

            menuItems = new List<HomeMenuItem>
            {
                new HomeMenuItem {Id = MenuItemType.Duyurular , Icon = ImageSource.FromResource(AppResources.Icons.Menu.Duyurular), Title="Duyurular" },

                new HomeMenuItem {Id = MenuItemType.Egitmen_Girisi, Title="Eğitmen Girişi" , Icon=ImageSource.FromResource(AppResources.Icons.Menu.Egitmen_Girisi) },
             

                new HomeMenuItem {Id = MenuItemType.Egitmen_Duyuru_Sayfası, Title="Egitmen Duyuru Sayfası" ,Icon=ImageSource.FromResource(AppResources.Icons.Menu.Egitmen_Duyuru_Sayfası)  },

                new HomeMenuItem {Id = MenuItemType.Hakkında, Title="Hakkında" ,Icon=ImageSource.FromResource(AppResources.Icons.Menu.Hakkında) },

                new HomeMenuItem {Id = MenuItemType.Ayarlar, Title="Ayarlar/DersSeçim" ,Icon=ImageSource.FromResource(AppResources.Icons.Menu.Ayarlar) }

              
            };

            ListViewMenu.ItemsSource = menuItems;

            ListViewMenu.SelectedItem = menuItems[0];
            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                var id = (int)((HomeMenuItem)e.SelectedItem).Id;
                await RootPage.NavigateFromMenu(id);
            };
        }

        private void SetTapUrl(Image image, string url)
        {
            TapGestureRecognizer insTapped = new TapGestureRecognizer();
            insTapped.Tapped += delegate
            {
                Launcher.TryOpenAsync(new Uri(url));
            };
            image.GestureRecognizers.Add(insTapped);
        }

        private void ViewCell_Tapped(object sender, System.EventArgs e)
            {
          
           
        }
    }
}