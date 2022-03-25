using SML.Core;
using SML.Stores;

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
