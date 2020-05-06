using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

using EBAUNAPP.Models;
using EBAUNAPP.Views;

namespace EBAUNAPP.ViewModels
{
    public class ClassesViewModel : BaseViewModel
    {
        public Classes Classes { get; set; }
        public ObservableCollection<Classes> classes { get; set; }
        public Command LoadClassesCommand { get; set; }

        public ClassesViewModel(Classes classes = null)
        {
            Title = "Ders Seçimi/Ayarlar";
            Classes = classes;
        }

    }
}