using Caliburn.Micro;
using HTProject.Platform.Main.Managers;
using HTProject.Plugin.Control.Controls;
using Prism.Commands;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using CommonLog = Common.Logging;
using System.Windows.Input;
using System.Windows;

namespace HTProject.Platform.Main.ViewModels
{
    [Export]
    [PartCreationPolicy(CreationPolicy.Shared)]
    [ImplementPropertyChanged]
    public class MainStartViewModel : Screen
    {
        #region Field
        private readonly CommonLog.ILog logger = CommonLog.LogManager.GetLogger(typeof(MainStartViewModel));
        private Window _targetWindow;
        #endregion

        #region Properity
        #region Main Menu Select

        public Screen HomeView { get; set; }
        private HomeViewModel _homeViewModel;

        public Screen ProductionView { get; set; }
        private ProductionViewModel _productionViewModel;

        public Screen EngineeringView { get; set; }
        private EngineeringViewModel _engineeringViewModel;

        public Screen CalibrationView { get; set; }
        private CalibrationViewModel _calibrationViewModel;

        public Screen DataView { get; set; }
        private DataViewModel _dataViewModel;

        public Screen WarningView { get; set; }
        private WarningViewModel _warningViewModel;

        public Screen ScreenContent { get; set; }
        #endregion

        public LightState RedState { get; set; } = LightState.Normal;
        public LightState YellowState { get; set; } = LightState.Normal;
        public LightState BlueState { get; set; } = LightState.Normal;
        public LightState GreenState { get; set; } = LightState.Normal;
        #endregion


        public MainStartViewModel()
        {
            if (HomeView == null)
            {
                _homeViewModel = IoC.Get<HomeViewModel>();
                HomeView = _homeViewModel;
            }
            if (ProductionView == null)
            {
                _productionViewModel = IoC.Get<ProductionViewModel>();
                ProductionView = _productionViewModel;
            }
            if (EngineeringView == null)
            {
                _engineeringViewModel = IoC.Get<EngineeringViewModel>();
                EngineeringView = _engineeringViewModel;
            }
            if (CalibrationView == null)
            {
                _calibrationViewModel = IoC.Get<CalibrationViewModel>();
                CalibrationView = _calibrationViewModel;
            }
            if (DataView == null)
            {
                _dataViewModel = IoC.Get<DataViewModel>();
                DataView = _dataViewModel;
            }
            if (WarningView == null)
            {
                _warningViewModel = IoC.Get<WarningViewModel>();
                WarningView = _warningViewModel;
            }
            ScreenContent = HomeView;
        }

        public ICommand MainViewSelectMenuCommand => new DelegateCommand<object>(parameter => { MainViewSelectMenu(parameter); });

        private void MainViewSelectMenu(object parameter)
        {
            string Commandparameter = parameter as string;
            if (Commandparameter == null) return;
            switch (Commandparameter)
            {
                case "Home":
                    if (_homeViewModel != null)
                    {
                        ScreenContent = HomeView;
                    }
                    break;
                case "Production":
                    if (_productionViewModel != null)
                    {
                        ScreenContent = ProductionView;
                    }
                    break;
                case "Engineering":
                    if (_engineeringViewModel != null)
                    {
                        ScreenContent = EngineeringView;
                    }
                    break;
                case "Calibration":
                    if (_calibrationViewModel != null)
                    {
                        ScreenContent = CalibrationView;
                    }
                    break;
                case "Data":
                    if (_dataViewModel != null)
                    {
                        ScreenContent = DataView;
                    }
                    break;
                case "Warning":
                    if (_warningViewModel != null)
                    {
                        ScreenContent = WarningView;
                    }
                    break;
                default:
                    if (_homeViewModel != null)
                    {
                        ScreenContent = HomeView;
                    }
                    break;
            }
            NotifyOfPropertyChange(nameof(ScreenContent));
        }

        public void MinimizedWindowClickCommand(object sender, RoutedEventArgs e)
        {
            var window = Application.Current.MainWindow;
            if (window == null) return;
            window.WindowState = WindowState.Minimized;
        }

        public void ClosedWindowClickCommand(object sender, RoutedEventArgs e)
        {
            var window = Application.Current.MainWindow;
            if (window == null) return;
            window.Close();
            Application.Current.Shutdown(0);
        }

    }
}
