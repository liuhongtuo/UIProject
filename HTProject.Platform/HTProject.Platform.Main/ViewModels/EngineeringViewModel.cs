using Caliburn.Micro;
using HTProject.Platform.Main.ViewModels.EngineeringSubs;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTProject.Platform.Main.ViewModels
{
    [Export]
    [PartCreationPolicy(CreationPolicy.Shared)]
    [ImplementPropertyChanged]
    public class EngineeringViewModel : Screen
    {
        public Screen ManualDebugView { get; set; }
        private ManualDebugViewModel _manualDebugViewModel;

        public Screen IOInputView { get; set; }
        private IOInputViewModel _ioInputViewModel;

        public Screen IOOutputView { get; set; }
        private IOOutputViewModel _ioOutputViewModel;

        public Screen MCFCSettingView { get; set; }
        private MCFCSettingViewModel _mcfcSettingViewModel;

        public EngineeringViewModel()
        {
            if (ManualDebugView == null)
            {
                _manualDebugViewModel = IoC.Get<ManualDebugViewModel>();
                ManualDebugView = _manualDebugViewModel;
            }
            if (IOInputView == null)
            {
                _ioInputViewModel = IoC.Get<IOInputViewModel>();
                IOInputView = _ioInputViewModel;
            }
            if (IOOutputView == null)
            {
                _ioOutputViewModel = IoC.Get<IOOutputViewModel>();
                IOOutputView = _ioOutputViewModel;
            }
            if (MCFCSettingView == null)
            {
                _mcfcSettingViewModel = IoC.Get<MCFCSettingViewModel>();
                MCFCSettingView = _mcfcSettingViewModel;
            }
        }
    }
}
