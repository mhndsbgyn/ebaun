using Syncfusion.XForms.DataForm;
using System;
using Xamarin.Forms;
using Xamarin.Essentials;
using Syncfusion.DataSource;
using Syncfusion.GridCommon;
using Syncfusion.Data;
using Syncfusion.SfDataGrid;
namespace ebaun.Models
{
    public class Item
    {
        public string Id { get; set; }
        public string Ders_adi { get; set; }
        public string Aciklama { get; set; }
        public string Tarih { get; set; }
        public string Egitmen_adi { get; set; }
        public string Sinif { get; set; }
    }
}