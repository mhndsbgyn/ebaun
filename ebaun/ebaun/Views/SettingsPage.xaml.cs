using System;
using System.Collections.Generic;
using Syncfusion.SfDataGrid.XForms;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ebaun.ViewModels;
using ebaun.Models;

namespace ebaun.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SettingsPage : ContentPage
    {
        ClassesViewModel viewModel;
   

        public SettingsPage(ClassesViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = this.viewModel = viewModel;


        }
        public SettingsPage()
        {
            InitializeComponent();

            var classes = new Classes
            {
                Ders_adi = "web",
                Egitmen_adi = "herhangibiri"
            };

            viewModel = new ClassesViewModel(classes);
            BindingContext = viewModel;

        }

        async void Cancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        async void Save_Clicked(object sender, EventArgs e)
        {
           
            await Navigation.PopModalAsync();
        }
    }
}