using Prism.Mvvm;

namespace prismWPF.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "PrismWPF";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainWindowViewModel()
        {

        }
    }
}
