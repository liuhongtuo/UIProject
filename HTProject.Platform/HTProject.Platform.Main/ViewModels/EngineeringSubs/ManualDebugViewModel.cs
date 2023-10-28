using Caliburn.Micro;
using HTProject.Platform.Main.ViewModels.EngineeringSubs.DebugSubs;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTProject.Platform.Main.ViewModels.EngineeringSubs
{
    [Export]
    [PartCreationPolicy(CreationPolicy.Shared)]
    [ImplementPropertyChanged]
    public class ManualDebugViewModel : Screen
    {
        public Screen LoadingStationView { get; set; }
        private LoadingStationViewModel _loadingStationViewModel;

        public Screen UnloadingStationView { get; set; }
        private UnloadingStationViewModel _unloadingStationViewModel;

        public Screen CollectingStationView { get; set; }
        private CollectingStationViewModel _collectingStationViewModel;

        public Screen DispensingStationView { get; set; }
        private DispensingStationViewModel _dispensingStationViewModel;

        public Screen AssemblyStationView { get; set; }
        private AssemblyStationViewModel _asssemblyStationViewModel;

        public Screen RecheckStationView { get; set; }
        private RecheckStationViewModel _recheckStationViewModel;


        public ManualDebugViewModel()
        {
            if (LoadingStationView == null)
            {
                _loadingStationViewModel = IoC.Get<LoadingStationViewModel>();
                LoadingStationView = _loadingStationViewModel;
            }
            if (UnloadingStationView == null)
            {
                _unloadingStationViewModel = IoC.Get<UnloadingStationViewModel>();
                UnloadingStationView = _unloadingStationViewModel;
            }
            if (CollectingStationView == null)
            {
                _collectingStationViewModel = IoC.Get<CollectingStationViewModel>();
                CollectingStationView = _collectingStationViewModel;
            }
            if (DispensingStationView == null)
            {
                _dispensingStationViewModel = IoC.Get<DispensingStationViewModel>();
                DispensingStationView = _dispensingStationViewModel;
            }
            if (AssemblyStationView == null)
            {
                _asssemblyStationViewModel = IoC.Get<AssemblyStationViewModel>();
                AssemblyStationView = _asssemblyStationViewModel;
            }
            if (RecheckStationView == null)
            {
                _recheckStationViewModel = IoC.Get<RecheckStationViewModel>();
                RecheckStationView = _recheckStationViewModel;
            }
        }
    }
}
