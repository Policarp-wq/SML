using System;
using SML.Core;
using SML.ViewModels;

namespace SML.Commands
{
    public class TrigonometricCommand : CommandBase
    {
        private TrigonometryViewModel _trigVM;

        public TrigonometricCommand(TrigonometryViewModel trigVm)
        {
            _trigVM = trigVm;
        }
        
        public override void Execute(object parameter)
        {
            
            if(_trigVM.TrigStr != null)
                _trigVM.TrigStr = _trigVM.SelectedTrig.Function(Tuple.Create(double.Parse(_trigVM.TrigStr), _trigVM.IsRadian)).ToString();
            if(_trigVM.ArcTrigStr != null)
                _trigVM.ArcTrigStr = _trigVM.SelectedArcTrig.Function(Tuple.Create(_trigVM.ArcTrigStr, _trigVM.IsRadian)).ToString();
        }
    }
}