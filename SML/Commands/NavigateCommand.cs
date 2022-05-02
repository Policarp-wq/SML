using SML.Core;
using SML.Stores;
using System;

namespace SML.Commands
{
    internal class NavigateCommand : CommandBase
    {
        private NavigationStore _navigationStore;
        private Func<ObservableObject> _createVM;
        public NavigateCommand(NavigationStore navigationStore ,Func<ObservableObject> createVM)
        {
            _navigationStore = navigationStore;
            _createVM = createVM;
        }
        public override void Execute(object parameter)
        {
            _navigationStore.CurrentVM = _createVM();
        }
    }
}
