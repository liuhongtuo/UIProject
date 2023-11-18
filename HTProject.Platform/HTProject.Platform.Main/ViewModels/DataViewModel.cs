using Caliburn.Micro;
using HTProject.Platform.Main.ViewModels.DataSubs;
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
    public class DataViewModel : Screen
    {
        public Screen CollectingStationDataView { get; set; }
        private CollectingStationDataViewModel _collectingStationDataViewModel;

        public Screen DispensingStationDataView { get; set; }
        private DispensingStationDataViewModel _dispensingStationDataViewModel;

        public Screen AssemblyStationDataView { get; set; }
        private AssemblyStationDataViewModel _assemblyStationDataViewModel;

        public Screen RecheckStationDataView { get; set; }
        private RecheckStationDataViewModel _recheckStationDataViewModel;

        public Screen TotalDataView { get; set; }
        private TotalDataViewModel _totalDataViewModel;

        public DataViewModel()
        {
            if (CollectingStationDataView == null)
            {
                _collectingStationDataViewModel = IoC.Get<CollectingStationDataViewModel>();
                CollectingStationDataView = _collectingStationDataViewModel;
            }
            if (DispensingStationDataView == null)
            {
                _dispensingStationDataViewModel = IoC.Get<DispensingStationDataViewModel>();
                DispensingStationDataView = _dispensingStationDataViewModel;
            }
            if (AssemblyStationDataView == null)
            {
                _assemblyStationDataViewModel = IoC.Get<AssemblyStationDataViewModel>();
                AssemblyStationDataView = _assemblyStationDataViewModel;
            }
            if (RecheckStationDataView == null)
            {
                _recheckStationDataViewModel = IoC.Get<RecheckStationDataViewModel>();
                RecheckStationDataView = _recheckStationDataViewModel;
            }
            if (TotalDataView == null)
            {
                _totalDataViewModel = IoC.Get<TotalDataViewModel>();
                TotalDataView = _totalDataViewModel;
            }
        }
    }
}
