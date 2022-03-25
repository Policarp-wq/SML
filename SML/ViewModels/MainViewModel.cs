using SML.Commands;
using SML.Core;
using SML.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace SML.ViewModels
{
    internal class MainViewModel : ObservableObject
    {
        private NavigationStore _navigationStore;
        public ObservableObject CurrentVM => _navigationStore.CurrentVM;
        public ICommand Close { get; }
        public MainViewModel(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
            _navigationStore.CurrentVMChanged += OnCurrentVMChanged;
            Close = new RelayCommand((parameter) => {Window window = parameter as Window; window.Close(); });
        }

        private void OnCurrentVMChanged()
        {
            OnPropertyChanged(nameof(CurrentVM));
        }
    }
}
