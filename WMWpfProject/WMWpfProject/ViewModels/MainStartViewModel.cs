using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using WMWpfProject.Base.MVVM;
using WMWpfProject.Model;

namespace WMWpfProject.ViewModels
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

        public ICommand MainViewSelectMenuCommand => new DelegateCommand(name => MainViewSelectMenu(name));

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
