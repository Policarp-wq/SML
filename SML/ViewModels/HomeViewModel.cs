using SML.Commands;
using SML.Core;
using SML.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SML.ViewModels
{
    internal class HomeViewModel : ObservableObject
    {
        private readonly NavigationStore _navigationStore;
        public ICommand NavigateToEquationSolver { get; }

        public HomeViewModel(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
            NavigateToEquationSolver =
                new NavigateCommand(_navigationStore, () => new EquationSolverViewModel(navigationStore));
        }
    }
}