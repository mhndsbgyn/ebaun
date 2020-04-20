using System;
using System.Collections.Generic;
using System.Text;

namespace ebaun.Models
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

        public string Title { get; set; }
    }
}
