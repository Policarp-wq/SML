using SML.Core;
using SML.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SML.ViewModels
{
    internal class MainViewModel : ObservableObject
    {
        private NavigationStore _navigationStore;
        public ObservableObject CurrentVM => _navigationStore.CurrentVM;    

        public MainViewModel(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
            _navigationStore.CurrentVMChanged += OnCurrentVMChanged;
        }

        private void OnCurrentVMChanged()
        {
            OnPropertyChanged(nameof(CurrentVM));
        }
    }
}
