using System.Windows;
using System.Windows.Input;
using SML.Commands;
using SML.Core;
using SML.Stores;
using SML.Views;

namespace SML.ViewModels
{
    internal class MainViewModel : ObservableObject
    {
        private NavigationStore _navigationStore;
        private Window _window;
        public ObservableObject CurrentVM => _navigationStore.CurrentVM;
        public ICommand Close { get; }
        public ICommand ToEquationSolverView { get; }
        public ICommand ToHomeView { get; }
        public ICommand ToTrigonometryView { get; }
        public ICommand ShowDescription { get; }
        public ICommand DragWindow { get; }
        public MainViewModel(NavigationStore navigationStore, Window window)
        {
            _window = window;
            _navigationStore = navigationStore;
            _navigationStore.CurrentVMChanged += OnCurrentVMChanged;
            Close = new RelayCommand((parameter) => {window.Close(); });
            DragWindow = new RelayCommand((parameter) => _window.DragMove());
            ToEquationSolverView = new NavigateCommand(_navigationStore, () => new EquationSolverViewModel(_navigationStore));
            ToHomeView = new NavigateCommand(_navigationStore, () => new HomeViewModel(_navigationStore));
            ToTrigonometryView = new NavigateCommand(_navigationStore, () => new TrigonometryViewModel());
            ShowDescription = new RelayCommand((o =>
            {
                var v = new DescriptionView() {DataContext = new DescriptionViewModel()}; v.Show(); }));
        }
        private void OnCurrentVMChanged()
        {
            OnPropertyChanged(nameof(CurrentVM));
        }
    }
}
