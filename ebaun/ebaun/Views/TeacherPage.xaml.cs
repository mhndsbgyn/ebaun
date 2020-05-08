using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ebaun.DTO;
using Acr.UserDialogs;
using Syncfusion.XForms.DataForm;
using System.Resources;

namespace ebaun.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TeacherPage : ContentPage
    {
        public Teacher Item { get; set; }
        public TeacherPage(Teacher Item = null)
        {
            InitializeComponent();
            this.Item = Item;
        }
        public TeacherPage()
        {
            InitializeComponent();

            Item = new Teacher
            {
               Email = "E-mail",
               Sifre = "Şifre"
            };

            BindingContext = this;
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
    
            if (Item == null)
            {
                using (UserDialogs.Instance.Loading("yükleniyor"))
                {
                   Item = await App.Databases.TeacherDataBase.CreateNew();
                }
            }

            dataForm.DataObject = Item;
      
        }

       

        async void Save_Clicked(object sender, EventArgs e)
        {
            if (dataForm.Validate())
            {
                using (UserDialogs.Instance.Loading("ekleniyor"))
                {
                    await App.Databases.TeacherDataBase.SaveAsync(Item);
                }
                await Navigation.PopToRootAsync();
            }
        }

        async void Cancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        private void DataForm_AutoGeneratingDataFormItem(object sender, Syncfusion.XForms.DataForm.AutoGeneratingDataFormItemEventArgs e)
        {
            if (e.DataFormItem != null)
            {
                if (e.DataFormItem.Name == "Id")
                    e.DataFormItem.IsVisible = false;
            }
        }
    }
}