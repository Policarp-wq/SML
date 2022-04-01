using System.Windows.Input;
using SML.Commands;
using SML.Core;
using SML.Stores;

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