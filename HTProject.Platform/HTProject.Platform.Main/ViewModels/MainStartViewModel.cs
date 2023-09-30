using Caliburn.Micro;
using HTProject.Platform.Main.Managers;
using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace HTProject.Platform.Main.ViewModels
{
    public class MainStartViewModel : Screen
    {
        private Page _currentShowPage = PageManager.HomeView;

        public Page CurrentShowPage
        {
            get { return _currentShowPage; }
            set
            {
                _currentShowPage = value;
                NotifyOfPropertyChange();
            }
        }

        public MainStartViewModel()
        {

        }

        //public DelegateCommand MainViewSelectMenuCommand => new DelegateCommand((name) => { });

        private void MainViewSelectMenu(object pageName)
        {
            switch (pageName.ToString())
            {
                case "Home":
                    CurrentShowPage = PageManager.HomeView;
                    break;
                case "Production":
                    CurrentShowPage = PageManager.ProductionView;
                    break;
                case "Engineering":
                    CurrentShowPage = PageManager.EngineeringView;
                    break;
                default:
                    CurrentShowPage = PageManager.HomeView;
                    break;
            }
        }
    }
}
