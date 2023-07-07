using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WMWpfProject.ViewModels;

namespace WMWpfProject
{
    public class HelloBootStrapper : BootstrapperBase
    {
        public HelloBootStrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewForAsync<MainStartViewModel>();
            
        }
    }
}
