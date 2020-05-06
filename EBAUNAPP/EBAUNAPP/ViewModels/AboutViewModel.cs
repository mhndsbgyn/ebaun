using System.Windows.Input;

namespace EBAUNAPP.ViewModels
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