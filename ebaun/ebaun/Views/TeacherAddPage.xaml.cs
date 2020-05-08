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
using System.Collections.ObjectModel;
using Plugin.FirebasePushNotification;
using ebaun.Services;

namespace ebaun.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TeacherAddPage : ContentPage
    {
  
         ItemsViewModel viewModel;
        public Classes Item { get; set; }
        
        public TeacherAddPage()
        {

            InitializeComponent();

            BindingContext = this;
            Item = new Classes
            {
                Egitmen_adi = "İsminiz",
                Ders_adi="Ders Adi", 
                Sinif="1,2,3,4 ",
                
            };
            dataGrid.AutoGeneratingColumn += GridAutoGeneratingColumns; 
            BindingContext = Item = new Classes();
            BindingContext = viewModel = new ItemsViewModel();

        }
        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var item = args.SelectedItem as Item;
            if (item == null)
                return;

            await Navigation.PushAsync(new ItemDetailPage(new ItemDetailViewModel(item)));

            // Manually deselect item.
     
        }



        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.Items.Count == 0)
                viewModel.LoadItemsCommand.Execute(null);
        }
       
        private void GridAutoGeneratingColumns(object sender, Syncfusion.SfDataGrid.XForms.AutoGeneratingColumnEventArgs e)
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

     


      

        private async void SfButton_Clicked(object sender, EventArgs e)
        {
            using (Acr.UserDialogs.UserDialogs.Instance.Loading("Mesaj gönderiliyor..."))
            {
                await Notificator.SendMessage("Programlama","Yeni Ders Eklendi","Dersiniz eklendi..");
            }
        }
    }
}