using ebaun.Models;
using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ebaun.Views
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
                new HomeMenuItem {Id = MenuItemType.Duyurular, Title="Duyurular" },
                new HomeMenuItem {Id = MenuItemType.Egitmen_Girisi, Title="Eğitmen Girişi" },
                new HomeMenuItem {Id = MenuItemType.Ayarlar, Title="Ayarlar/Ders Seçim" },
                new HomeMenuItem {Id = MenuItemType.Egitmen_Duyuru_Sayfası, Title="Egitmen Duyuru Sayfası" },
                new HomeMenuItem {Id = MenuItemType.Hakkında, Title="Hakkında" }
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

      
            private void ViewCell_Tapped(object sender, System.EventArgs e)
            {
          
           
        }
    }
}