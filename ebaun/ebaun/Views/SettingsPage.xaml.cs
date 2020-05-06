using System;
using System.Collections.Generic;
using Syncfusion.SfDataGrid.XForms;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ebaun.ViewModels;
using ebaun.Models;
using Plugin.FirebasePushNotification;

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
            autoComplete.ValueChanged += AutoComplete_ValueChanged;
        }

        private void AutoComplete_ValueChanged(object sender, Syncfusion.SfAutoComplete.XForms.ValueChangedEventArgs e)
        {

        }

        private void AutoComplete_SelectionChanged(object sender, Syncfusion.SfAutoComplete.XForms.SelectionChangedEventArgs e)
        {
            List<string> removed = e.RemovedItems as List<string>;
            List<string> added = e.AddedItems as List<string>;
            foreach (string item in removed)
                CrossFirebasePushNotification.Current.Unsubscribe(item);
            foreach (string item in added)
                CrossFirebasePushNotification.Current.Subscribe(item);
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