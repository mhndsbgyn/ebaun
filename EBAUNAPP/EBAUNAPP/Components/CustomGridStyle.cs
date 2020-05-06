using System;
using Syncfusion.XForms.DataForm;
using Syncfusion.SfDataGrid.XForms;
namespace EBAUNAPP.Components
{
    public class CustomGridStyle : DataGridStyle
    {
        public override Xamarin.Forms.Color GetHeaderBackgroundColor()
        {
            return Xamarin.Forms.Color.FromHex(AppResources.Colors.Primary.ToHex());
        }
        public override Xamarin.Forms.Color GetHeaderForegroundColor()
        {
            return Xamarin.Forms.Color.White;
        }
        public override Xamarin.Forms.Color GetBorderColor()
        {
            return Xamarin.Forms.Color.FromHex(AppResources.Colors.Primary.ToHex());
        }
        public override Xamarin.Forms.Color GetHeaderBorderColor()
        {
            return Xamarin.Forms.Color.FromHex(AppResources.Colors.Primary.ToHex());
        }
    }
}