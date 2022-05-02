using SML.Core;
using SML.Models;
using System;
using System.Collections.Generic;
using SimpleMathLibrary;
using SML.MVVM.Models;
using System.Windows.Input;
using SML.Commands;

namespace SML.ViewModels
{
    internal class NumberTheoryViewModel : ObservableObject
    {
        public List<PresentatedFunction> TwoArgumentFunctions { get; set; }
        public List<PresentatedFunction> BooleanFunctions { get; set; }

        #region FullProperties

        private PresentatedFunction _twoArgumentFunctionSelected;

        public PresentatedFunction TwoArgumentFunctionSelected
        {
            get { return _twoArgumentFunctionSelected; }
            set 
            {
                _twoArgumentFunctionSelected = value;
                OnPropertyChanged();
            }
        }

        private PresentatedFunction _booleanFunctionSelected;

        public PresentatedFunction BooleanFunctionSelected
        {
            get { return _booleanFunctionSelected; }
            set 
            {
                _booleanFunctionSelected = value;
                OnPropertyChanged();
            }
        }
        private string _firstParam;

        public string FirstParam
        {
            get { return _firstParam; }
            set 
            {
                _firstParam = value;
                OnPropertyChanged();
            }
        }

        private string _secondParam;

        public string SecondParam
        {
            get { return _secondParam; }
            set 
            {
                _secondParam = value;
                OnPropertyChanged();
            }
        }

        private string _logBase;

        public string LogBase
        {
            get { return _logBase; }
            set 
            {
                _logBase = value;
                OnPropertyChanged();
            }
        }

        private string _logArg;

        public string LogArg
        {
            get { return _logArg; }
            set 
            {
                _logArg = value;
                OnPropertyChanged();
            }
        }

        private string _checkingNum;

        public string CheckingNum
        {
            get { return _checkingNum; }
            set { _checkingNum = value; OnPropertyChanged(); }
        }

        private string _decompNum;

        public string DecompNum
        {
            get { return _decompNum; }
            set { _decompNum = value; OnPropertyChanged(); }
        }

        private string _twoArgRes;

        public string TwoArgRes
        {
            get { return _twoArgRes; }
            set { _twoArgRes = value; OnPropertyChanged(); }
        }

        private string _boolRes;

        public string BoolRes
        {
            get { return _boolRes; }
            set { _boolRes = value; OnPropertyChanged(); }
        }

        private string _logRes;

        public string LogRes
        {
            get { return _logRes; }
            set { _logRes = value; OnPropertyChanged(); }
        }

        private string _decomp;

        public string Decomp
        {
            get { return _decomp; }
            set { _decomp = value; OnPropertyChanged(); }
        }


        #endregion
        public ICommand SolveTwoArgument { get; }
        public ICommand SolveBoolean { get; }
        public ICommand SolveLog { get; }
        public ICommand GetDecomp { get; }

        public NumberTheoryViewModel()
        {
            TwoArgumentFunctions = new List<PresentatedFunction>()
            {
                new PresentatedFunction("НОД", o =>
                {
                    var t = o as Tuple<int, int>;
                    return AppliedFunctions.GCD(t.Item1, t.Item2);
                }),
                new PresentatedFunction("НОК", o =>
                {
                   var t = o as Tuple<int, int>;
                    return AppliedFunctions.LCM(t.Item1, t.Item2);
                })
            };
            BooleanFunctions = new List<PresentatedFunction>()
            {
                new PresentatedFunction("Простое", o =>
                {
                    int a = (int) o;
                    return AppliedFunctions.IsPrime(a) ? "Простое" : "Составное";
                }),
                new PresentatedFunction("Квадрат числа", o =>
                {
                    int a = (int) o;
                    return AppliedFunctions.IsSqrt(a) ? "Квадрат" : "Нет";
                })
            };
            TwoArgumentFunctionSelected = TwoArgumentFunctions[0];
            BooleanFunctionSelected = BooleanFunctions[0];
            SolveTwoArgument = new RelayCommand((o) =>
            {
                Parser.ToTwoInts(FirstParam, SecondParam, out var a, out var b);
                TwoArgRes = TwoArgumentFunctionSelected.Function(new Tuple<int, int>(a, b)).ToString();
            }, b => Parser.CanParseToTwoInts(FirstParam, SecondParam));//, b => Parser.CanParseToTwoInts(FirstParam, SecondParam)
            SolveBoolean = new RelayCommand(o =>
            {
                Parser.ToInt(CheckingNum, out int a);
                BoolRes = BooleanFunctionSelected.Function(a).ToString();
            }, b => Parser.CanParseToInt(CheckingNum));
            SolveLog = new RelayCommand((o) =>
            {
                Parser.ToTwoInts(LogBase, LogArg, out int a, out int b);
                LogRes = Math.Round(AppliedFunctions.Log(a, b),5).ToString();
            }, b => Parser.CanParseToTwoInts(LogBase, LogArg)); //
            GetDecomp = new RelayCommand(o =>
            {
                Parser.ToInt(DecompNum, out var a);
                Decomp = AppliedFunctions.Decomposition(a).ToString();
            }, b => Parser.CanParseToInt(DecompNum));
        }
    }
}
