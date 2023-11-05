using Caliburn.Micro;
using HTProject.Common.Data.MCFCData;
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
    public class MCFCSettingViewModel : Screen
    {
        #region Property
        public List<ItemNodeInfo> TotalMCFCList { get; set; } = new List<ItemNodeInfo>();
        public ItemNodeInfo SystemMCFCInfo { get; set; } = new ItemNodeInfo();
        public ItemNodeInfo DispensingStationMCFCInfo { get; set; } = new ItemNodeInfo();
        public ItemNodeInfo AssemblyStationMCFCInfo { get; set; } = new ItemNodeInfo();
        public ItemNodeInfo RecheckStationMCFCInfo { get; set; } = new ItemNodeInfo();
        #endregion

        #region Constructor
        public MCFCSettingViewModel()
        {
            LoadSystemMCFCList();
            LoadDispensingStationMCFC();
            LoadAssemblyStationMCFC();
            LoadRecheckStationMCFC();
            TotalMCFCList.Add(SystemMCFCInfo);
            TotalMCFCList.Add(DispensingStationMCFCInfo);
            TotalMCFCList.Add(AssemblyStationMCFCInfo);
            TotalMCFCList.Add(RecheckStationMCFCInfo);
        }
        #endregion

        #region Private Method
        private void LoadSystemMCFCList()
        {
            ItemNodeInfo nodeInfo1 = new ItemNodeInfo()
            {
                Name = "System1",
                Description = "This is a system mcfc"
            };
            ItemNodeInfo nodeInfo2 = new ItemNodeInfo()
            {
                Name = "System2",
                Description = "This is a system mcfc"
            };
            ItemNodeInfo nodeInfo3 = new ItemNodeInfo()
            {
                Name = "System3",
                Description = "This is a system mcfc"
            };
            SystemMCFCInfo.Name = "SystemMCFC";
            SystemMCFCInfo.Description = "This is System MCFC";
            SystemMCFCInfo.ChildrenItems.Add(nodeInfo1);
            SystemMCFCInfo.ChildrenItems.Add(nodeInfo2);
            SystemMCFCInfo.ChildrenItems.Add(nodeInfo3);
        }

        private void LoadDispensingStationMCFC()
        {
            ItemNodeInfo nodeInfo1 = new ItemNodeInfo()
            {
                Name = "DispensingStation1",
                Description = "This is a DispensingStation mcfc"
            };
            ItemNodeInfo nodeInfo2 = new ItemNodeInfo()
            {
                Name = "DispensingStation2",
                Description = "This is a DispensingStation mcfc"
            };
            ItemNodeInfo nodeInfo3 = new ItemNodeInfo()
            {
                Name = "DispensingStation3",
                Description = "This is a system mcfc"
            };
            DispensingStationMCFCInfo.Name = "DispensingStationMCFC";
            DispensingStationMCFCInfo.Description = "This is DispensingStatio MCFC";
            DispensingStationMCFCInfo.ChildrenItems.Add(nodeInfo1);
            DispensingStationMCFCInfo.ChildrenItems.Add(nodeInfo2);
            DispensingStationMCFCInfo.ChildrenItems.Add(nodeInfo3);
        }

        private void LoadAssemblyStationMCFC()
        {
            ItemNodeInfo nodeInfo1 = new ItemNodeInfo()
            {
                Name = "AssemblyStation1",
                Description = "This is a system mcfc"
            };
            ItemNodeInfo nodeInfo2 = new ItemNodeInfo()
            {
                Name = "AssemblyStation2",
                Description = "This is a system mcfc"
            };
            ItemNodeInfo nodeInfo3 = new ItemNodeInfo()
            {
                Name = "AssemblyStation3",
                Description = "This is a system mcfc"
            };
            AssemblyStationMCFCInfo.Name = "AssemblyStationMCFC";
            AssemblyStationMCFCInfo.Description = "This is AssemblyStation MCFC";
            AssemblyStationMCFCInfo.ChildrenItems.Add(nodeInfo1);
            AssemblyStationMCFCInfo.ChildrenItems.Add(nodeInfo2);
            AssemblyStationMCFCInfo.ChildrenItems.Add(nodeInfo3);
        }

        private void LoadRecheckStationMCFC()
        {
            ItemNodeInfo nodeInfo1 = new ItemNodeInfo()
            {
                Name = "RecheckStation1",
                Description = "This is a system mcfc"
            };
            ItemNodeInfo nodeInfo2 = new ItemNodeInfo()
            {
                Name = "RecheckStation2",
                Description = "This is a system mcfc"
            };
            ItemNodeInfo nodeInfo3 = new ItemNodeInfo()
            {
                Name = "RecheckStation3",
                Description = "This is a system mcfc"
            };
            RecheckStationMCFCInfo.Name = "RecheckStationMCFC";
            RecheckStationMCFCInfo.Description = "This is RecheckStation MCFC";
            RecheckStationMCFCInfo.ChildrenItems.Add(nodeInfo1);
            RecheckStationMCFCInfo.ChildrenItems.Add(nodeInfo2);
            RecheckStationMCFCInfo.ChildrenItems.Add(nodeInfo3);
        }
        #endregion
    }
}
