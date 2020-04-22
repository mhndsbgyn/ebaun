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

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://balikesir.edu.tr")));
        }

        public ICommand OpenWebCommand { get; }
    }
}