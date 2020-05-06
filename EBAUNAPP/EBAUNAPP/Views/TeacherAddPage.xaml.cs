using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using EBAUNAPP.Models;
using EBAUNAPP.Views;
using EBAUNAPP.ViewModels;
using System.Collections.ObjectModel;

namespace EBAUNAPP.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TeacherAddPage : ContentPage
    {
  
           ItemsViewModel viewModel;
        public Item Item { get; set; }
       
        public TeacherAddPage()
        {

            InitializeComponent();

            BindingContext = this;
            Item = new Item
            {
                Egitmen_adi = "İsminiz",
                Ders_adi="Ders Adi",
                Aciklama="Duyuru Açıklaması",
                Tarih="../../..",
                Sinif="1,2,3,4 ",
                
            };
            BindingContext = Item = new Item();
            BindingContext = viewModel = new ItemsViewModel();

        }
        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var item = args.SelectedItem as Item;
            if (item == null)
                return;

            await Navigation.PushAsync(new ItemDetailPage(new ItemDetailViewModel(item)));

            // Manually deselect item.
            ItemsListView.SelectedItem = null;
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
            else if (e.Column.MappingName == "Aciklama")
            {

                e.Column.TextAlignment = TextAlignment.Center;
            }
            else if (e.Column.MappingName == "Tarih")
            {

                e.Column.TextAlignment = TextAlignment.Center;
            }
            else if (e.Column.MappingName == "Sinif")
            {

                e.Column.TextAlignment = TextAlignment.Center;
            }

        }

        private void DataForm_AutoGeneratingDataFormItem(object sender, Syncfusion.XForms.DataForm.AutoGeneratingDataFormItemEventArgs e)
        {
            if (e.DataFormItem != null)
            {
                if (e.DataFormItem.Name == "Id")
                    e.DataFormItem.IsVisible = false;
            }
        }

     


      

        private void SfButton_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(this, "AddItem", Item);
        }
    }
}