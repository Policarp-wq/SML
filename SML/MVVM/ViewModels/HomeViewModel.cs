using System.Windows;
using System.Windows.Input;
using SML.Commands;
using SML.Core;
using SML.Stores;

namespace SML.ViewModels
{
    internal class HomeViewModel : ObservableObject
    {
        private readonly NavigationStore _navigationStore;
        public ICommand Testing { get; }

        private string _test = "Ebat345t";

        public string Test
        {
            get { return _test; }
            set 
            {
                _test = value;
                OnPropertyChanged();
            }
        }


        public HomeViewModel(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
            Testing = new RelayCommand((a) =>
            {
                MessageBox.Show(_test);
            });
        }
    }
}