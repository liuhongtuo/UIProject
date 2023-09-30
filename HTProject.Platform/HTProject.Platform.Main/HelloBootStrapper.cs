using Caliburn.Micro;
using HTProject.Platform.Main.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HTProject.Platform.Main
{
    public class HelloBootStrapper : BootstrapperBase
    {
        public HelloBootStrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<MainStartViewModel>();
        }
    }
}
