using System.Windows;
using System.Windows.Input;
using SML.Commands;
using SML.Core;
using SML.Models;
using SML.Stores;
using SimpleMathLibrary;
using Equation;
using System;

namespace SML.ViewModels
{
    internal class HomeViewModel : ObservableObject
    {
        private static string _path = @"./Additional Files/Home text.txt";

        private string _description;

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        private string _calculation;

        public string Calculation
        {
            get { return _calculation; }
            set 
            {
                _calculation = value;
                OnPropertyChanged();
            }
        }

        public ICommand Calculate { get; }
        public HomeViewModel()
        {
            Description = TextManager.GetTextFromFile(_path);
            Calculate = new RelayCommand(o =>
            {
                try
                {
                    Calculation = Separator.GetExpression(Calculation).ToString();
                }
                catch (Exception ex)
                {
                    Calculation = ex.Message;
                }
            });
        }
    }
}