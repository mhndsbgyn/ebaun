using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace ebaun.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {

            Title = "Hakkında";



        }

        public ICommand OpenWebCommand { get; }
    }
}