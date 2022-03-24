using SML.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SML.Stores
{
    internal class NavigationStore : ObservableObject
    {
        private ObservableObject _currentVM;
        public ObservableObject CurrentVM
        {
            get { return _currentVM; }
            set 
            {
                _currentVM = value;
                OnCurrentVMChanged();
            }
        }
        public event Action CurrentVMChanged;

        private void OnCurrentVMChanged()
        {
            CurrentVMChanged?.Invoke();
        }

    }
}
