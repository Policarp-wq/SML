﻿using SML.Core;
using System;

namespace SML.Commands
{
    internal class RelayCommand : CommandBase
    {
        private Action<object> _execute;
        private Func<object, bool> _canExecute;
        public RelayCommand(Action <object> execute, Func<object, bool> canExecute = null)
        {
            _execute = execute;
            _canExecute = canExecute;
        }
        public override void Execute(object parameter)
        {
            _execute(parameter);
        }
        public override bool CanExecute(object parameter)
        {
            return _canExecute == null || _canExecute(parameter);
        }
    }
}
