using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WMWpfProject.Views;

namespace WMWpfProject.Model
{
    internal class PageManager
    {
        private static HomeView _homeView = new HomeView();
        public static HomeView HomeView
        {
            get
            {
                if (_homeView == null)
                {
                    _homeView = new HomeView();
                }
                return _homeView;
            }
        }

        private static ProductionView _productionView = new ProductionView();
        public static ProductionView ProductionView
        {
            get
            {
                if (_productionView == null)
                {
                    _productionView = new ProductionView();
                }
                return _productionView;
            }
        }


        private static EngineeringView _engineeringView = new EngineeringView();
        public static EngineeringView EngineeringView
        {
            get
            {
                if (_engineeringView == null)
                {
                    _engineeringView = new EngineeringView();
                }
                return _engineeringView;
            }
        }

    }
}
