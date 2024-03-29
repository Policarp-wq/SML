﻿using System;
using System.Collections.Generic;
using System.Windows.Input;
using SimpleMathLibrary;
using SML.Commands;
using SML.Core;
using SML.Models;

namespace SML.ViewModels
{
    public class TrigonometryViewModel : ObservableObject
    {
        public List<PresentatedFunction> Functions { get; set; }
        public List<PresentatedFunction> ArcFunctions { get; set; }
        
        public bool IsRadian { get; set; }
        
        public ICommand SolveAngle { get; }
        public ICommand SolveArc { get; }


        private PresentatedFunction _selectedtrig;
        public PresentatedFunction SelectedTrig
        {
            get => _selectedtrig;
            set
            {
                _selectedtrig = value;
                OnPropertyChanged();
            }
        }
        private PresentatedFunction _selectedArcTrig;
        public PresentatedFunction SelectedArcTrig
        {
            get => _selectedArcTrig;
            set
            {
                _selectedArcTrig = value;
                OnPropertyChanged();
            }
        }
    

        public PresentatedFunction SelectedFunction { get; set; }


        private string _trigStr;

        public string TrigStr
        {
            get => _trigStr;
            set
            {
                _trigStr = value;
                OnPropertyChanged();
            }
        }

        private string _arcTrigStr;

        public string ArcTrigStr
        {
            get => _arcTrigStr;
            set
            {
                _arcTrigStr = value;
                OnPropertyChanged();
            }
        }
        
//ToDo При использовании . вместо , происходит закрытие проги, нужен валидатор!
        public TrigonometryViewModel()
        { 
            Functions = new List<PresentatedFunction>()
            {
                new PresentatedFunction("Sin", o =>
                {
                    var t = o as Tuple<double, bool>;
                    if(t is null)
                        return "Wrong input";
                    return Math.Round(TrigonometricFunctions.Sin(t.Item1, t.Item2), 1);
                }),
                new PresentatedFunction("Cos", o =>
                {
                    var t = o as Tuple<double, bool>;
                    if(t is null)
                        return "Wrong input";
                    return Math.Round(TrigonometricFunctions.Cos(t.Item1, t.Item2), 1);
                }),
                new PresentatedFunction("Tan", o =>
                {
                    var t = o as Tuple<double, bool>;
                    if(t is null)
                        return "Wrong input";
                    return Math.Round(TrigonometricFunctions.Tan(t.Item1, t.Item2), 1);
                }),   
            };
            ArcFunctions = new List<PresentatedFunction>()
            {
                new PresentatedFunction("ArcSin", o =>
                {
                    var t = o as Tuple<double, bool>;
                    if(t is null)
                        return "Wrong input";
                    return Math.Round(TrigonometricFunctions.Asin(t.Item1, t.Item2), 5);
                }),
                new PresentatedFunction("ArcCos", o =>
                {
                    var t = o as Tuple<double, bool>;
                    if(t is null)
                        return "Wrong input";
                    return Math.Round(TrigonometricFunctions.Acos(t.Item1, t.Item2), 5);
                }),
                new PresentatedFunction("ArcTan", o =>
                {
                    var t = o as Tuple<double, bool>;
                    if(t is null)
                        return "Wrong input";
                    return Math.Round(TrigonometricFunctions.Atan(t.Item1, t.Item2), 5);
                })
            };
            SelectedTrig = Functions[0];
            SelectedArcTrig = ArcFunctions[0];
            SolveAngle = new RelayCommand((o) =>
            {
                TrigStr = SelectedTrig.Function(new Tuple<double, bool>(double.Parse(TrigStr), IsRadian)).ToString();
            }, o => !(o is null));
            SolveArc = new RelayCommand((o) =>
            {
                ArcTrigStr = SelectedArcTrig.Function(new Tuple<double, bool>(double.Parse(ArcTrigStr), IsRadian)).ToString();
            }, o => !(o is null));
        }
    }
}
