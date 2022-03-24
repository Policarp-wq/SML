using SML.Core;
using SML.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SML.ViewModels
{
    internal class EquationSolverViewModel : ObservableObject
    {
        private NavigationStore _navigationStore;
        public EquationSolverViewModel(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }
    }
}
