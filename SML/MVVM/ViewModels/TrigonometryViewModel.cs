using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
using SimpleMathLibrary;
using SML.Commands;
using SML.Core;
using SML.Models;

namespace SML.ViewModels
{
    internal class TrigonometryViewModel : ObservableObject
    {
        private string _angleValue = string.Empty;
        public List<PresentatedFunction> Functions { get; set; }
        public List<PresentatedFunction> ArcFunctions { get; set; }
        public PresentatedFunction SelectedFunction { get; set; }
        public bool IsRadian { get; set; }
        public ICommand ShowDialog { get; }

        public string AngleValue
        {
            get => _angleValue;
            set
            {
                _angleValue = value;
                OnPropertyChanged();
            }
        }

        public PresentatedFunction SelectedTrig;
        public PresentatedFunction SelectedArcTrig;
        public TrigonometryViewModel()
        {
            ShowDialog = new RelayCommand((o => MessageBox.Show("Testing")));
            Functions = new List<PresentatedFunction>()
            {
                new PresentatedFunction("Sin", o => TrigonometricFunctions.Sin((double) o)),
                new PresentatedFunction("Cos", o => TrigonometricFunctions.Cos((double) o)),
                new PresentatedFunction("Tan", o => TrigonometricFunctions.Tan((double) o)),
            };
            ArcFunctions = new List<PresentatedFunction>()
            {
                new PresentatedFunction("ArcSin", o => TrigonometricFunctions.Asin((double) o)),
                new PresentatedFunction("ArcCos", o => TrigonometricFunctions.Acos((double) o)),
                new PresentatedFunction("ArcTan", o => TrigonometricFunctions.Atan((double) o)),
            };
        }
    }
}
