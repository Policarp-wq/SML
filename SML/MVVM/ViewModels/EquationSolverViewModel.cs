using Equation;
using SML.Commands;
using SML.Core;
using SML.Models;
using SML.Stores;
using System;
using System.IO;
using System.Windows;
using System.Windows.Input;

namespace SML.ViewModels
{
    internal class EquationSolverViewModel : ObservableObject
    {
        private static string _path = @"./Additional Files/Equation tips.txt";
        private NavigationStore _navigationStore;
        private string _equationString = "";
        public string EqTips { get; set; }

        public string EquationString
        {
            get => _equationString; 
            set 
            {
                _equationString = value;
                OnPropertyChanged();
            }
        }
        private string _results = "Ответы здеся";

        public string Results
        {
            get { return _results; }
            set 
            {
                _results = value;
                OnPropertyChanged();
            }
        }

        public ICommand Solve { get; }
        public EquationSolverViewModel(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
            Solve = new RelayCommand((o) =>
            {
                try
                {
                    Results =  EquationSolver.GetSolutions(EquationString).ToString();
                }
                catch (Exception ex)
                {
                    Results = ex.Message;
                }
            });
            try
            {
                EqTips = TextManager.GetTextFromFile(_path);
            }
            catch (Exception ex)
            {
                EqTips = ex.Message;
            }
        }
    }
}
