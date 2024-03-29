﻿using System.Windows;
using System.Windows.Controls;
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
        public ICommand ToNumberTheoryView { get; }
        public ICommand ShowDescription { get; }
        public ICommand DragWindow { get; }
        public ICommand Push { get; }
        private string _test;

        public string Test
        {
            get => _test;
            set
            {
                _test = value;
                OnPropertyChanged();
            }
        }
    
        public MainViewModel(NavigationStore navigationStore, Window window)
        {
            _window = window;
            _navigationStore = navigationStore;
            _navigationStore.CurrentVMChanged += OnCurrentVMChanged;
            Close = new RelayCommand((parameter) => {window.Close(); });
            DragWindow = new RelayCommand((parameter) => _window.DragMove());
            ToEquationSolverView = new NavigateCommand(_navigationStore, () => new EquationSolverViewModel(_navigationStore));
            ToHomeView = new NavigateCommand(_navigationStore, () => new HomeViewModel());
            ToTrigonometryView = new NavigateCommand(_navigationStore, () => new TrigonometryViewModel());
            ToNumberTheoryView = new NavigateCommand(_navigationStore, () => new NumberTheoryViewModel());
            ShowDescription = new RelayCommand((o =>
            {
                var v = new DescriptionView() {DataContext = new DescriptionViewModel()}; v.Show(); }));
            Push = new RelayCommand((o => MessageBox.Show(Test)));
            var a = new ComboBox();
        }
        private void OnCurrentVMChanged()
        {
            OnPropertyChanged(nameof(CurrentVM));
        }
    }
}
