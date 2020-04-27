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
                Ders_adi = "Item 1",
                Egitmen_adi = "This is an item description."
            };

            viewModel = new ClassesViewModel(classes);
            BindingContext = viewModel;

        }

      

    }
}