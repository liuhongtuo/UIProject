using Caliburn.Micro;
using HTProject.Common.Data.IOData;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTProject.Platform.Main.ViewModels.EngineeringSubs
{
    [Export]
    [PartCreationPolicy(CreationPolicy.Shared)]
    [ImplementPropertyChanged]
    public class IOOutputViewModel : Screen
    {
        public ObservableCollection<IOOutputData> IOOutputDatas { get; set; } = new ObservableCollection<IOOutputData>();

        public IOOutputViewModel()
        {
            for (int i = 0; i < 100; i++)
            {
                IOOutputDatas.Add(new IOOutputData() { IONumberName = i.ToString("D3"), IODescribe = "组装缓冲站流水线载具顶升气缸伸出", IDNumber = i });
            }
        }
    }
}
