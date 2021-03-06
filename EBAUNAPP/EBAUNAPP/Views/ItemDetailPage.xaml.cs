﻿using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using EBAUNAPP.Models;
using EBAUNAPP.ViewModels;

namespace EBAUNAPP.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemDetailPage : ContentPage
    {
        ItemDetailViewModel viewModel;

        public ItemDetailPage(ItemDetailViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }

        public ItemDetailPage()
        {
            InitializeComponent();

            var item = new Item
            {
                Ders_adi = "Item 1",
                Aciklama = "This is an item description."
            };

            viewModel = new ItemDetailViewModel(item);
            BindingContext = viewModel;
        }
    }
}