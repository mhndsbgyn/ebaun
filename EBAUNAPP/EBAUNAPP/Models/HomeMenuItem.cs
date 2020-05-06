using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace EBAUNAPP.Models
{
    public enum MenuItemType
    {
        Duyurular,
        Egitmen_Girisi,
        Egitmen_Duyuru_Sayfası,
        Hakkında,
        Ayarlar
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }
        public ImageSource Icon { get; set; }
        public string Title { get; set; }
    }
}
