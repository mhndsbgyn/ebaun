using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using ebaun.Models;
using ebaun.Views;
using ebaun.ViewModels;

namespace ebaun.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TeacherAddPage : ContentPage
    {
        ItemsViewModel viewModel;
      
        public TeacherAddPage()
        {
          

        InitializeComponent();
          
            BindingContext = viewModel = new ItemsViewModel();
        
        }
        

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.Items.Count == 0)
                viewModel.LoadItemsCommand.Execute(null);
        }

        private void DataMeasureGrid_AutoGeneratingColumn(object sender, Syncfusion.SfDataGrid.XForms.AutoGeneratingColumnEventArgs e)
        {
            if (e.Column.MappingName == "Id" || e.Column.MappingName == "Id")
            {
                e.Cancel = true;
            }
            else if (e.Column.MappingName == "Ders_adi")
            {
               
                e.Column.TextAlignment = TextAlignment.Center;
            }
            else if (e.Column.MappingName == "Egitmen_adi")
            {
               
                e.Column.TextAlignment = TextAlignment.Center;
            }
          
        }
    }
}