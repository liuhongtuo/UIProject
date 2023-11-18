using Caliburn.Micro;
using HTProject.Platform.Main.ViewModels.CalibrationSubs;
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
    public class CalibrationViewModel : Screen
    {
        public Screen LoadingStationCalibrationView { get; set; }
        private LoadingStationCalibrationViewModel _loadingStationCalibrationViewModel;

        public Screen UnloadingStationCalibrationView { get; set; }
        private UnloadingStationCalibrationViewModel _unloadingStationCalibrationViewModel;

        public Screen CollectingStationCalibrationView { get; set; }
        private CollectingStationCalibrationViewModel _collectingStationCalibrationViewModel;

        public Screen DispensingStationCalibrationView { get; set; }
        private DispensingStationCalibrationViewModel _dispensingStationCalibrationViewModel;

        public Screen AssemblyStationCalibrationView { get; set; }
        private AssemblyStationCalibrationViewModel _asssemblyStationCalibrationViewModel;

        public Screen RecheckStationCalibrationView { get; set; }
        private RecheckStationCalibrationViewModel _recheckStationCalibrationViewModel;


        public CalibrationViewModel()
        {
            if (LoadingStationCalibrationView == null)
            {
                _loadingStationCalibrationViewModel = IoC.Get<LoadingStationCalibrationViewModel>();
                LoadingStationCalibrationView = _loadingStationCalibrationViewModel;
            }
            if (UnloadingStationCalibrationView == null)
            {
                _unloadingStationCalibrationViewModel = IoC.Get<UnloadingStationCalibrationViewModel>();
                UnloadingStationCalibrationView = _unloadingStationCalibrationViewModel;
            }
            if (CollectingStationCalibrationView == null)
            {
                _collectingStationCalibrationViewModel = IoC.Get<CollectingStationCalibrationViewModel>();
                CollectingStationCalibrationView = _collectingStationCalibrationViewModel;
            }
            if (DispensingStationCalibrationView == null)
            {
                _dispensingStationCalibrationViewModel = IoC.Get<DispensingStationCalibrationViewModel>();
                DispensingStationCalibrationView = _dispensingStationCalibrationViewModel;
            }
            if (AssemblyStationCalibrationView == null)
            {
                _asssemblyStationCalibrationViewModel = IoC.Get<AssemblyStationCalibrationViewModel>();
                AssemblyStationCalibrationView = _asssemblyStationCalibrationViewModel;
            }
            if (RecheckStationCalibrationView == null)
            {
                _recheckStationCalibrationViewModel = IoC.Get<RecheckStationCalibrationViewModel>();
                RecheckStationCalibrationView = _recheckStationCalibrationViewModel;
            }
        }
    }
}
