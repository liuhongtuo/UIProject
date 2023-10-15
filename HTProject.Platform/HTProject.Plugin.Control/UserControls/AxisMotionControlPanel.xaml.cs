using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HTProject.Plugin.Control.UserControls
{
    /// <summary>
    /// AxisMotionControlPanel.xaml 的交互逻辑
    /// </summary>
    [ImplementPropertyChanged]
    public partial class AxisMotionControlPanel : UserControl
    {
        public AxisMotionControlPanel()
        {
            InitializeComponent();
        }


        /// <summary>
        /// 控制面板是否包含X轴
        /// </summary>
        public bool IsContainXAxis
        {
            get { return (bool)GetValue(IsContainXAxisProperty); }
            set { SetValue(IsContainXAxisProperty, value); }
        }

        public static readonly DependencyProperty IsContainXAxisProperty =
            DependencyProperty.Register("IsContainXAxis", typeof(bool), typeof(AxisMotionControlPanel), new PropertyMetadata(true, new PropertyChangedCallback((sender, args) =>
            {
                var axisMotionControlPanel = (AxisMotionControlPanel)sender;
                if (axisMotionControlPanel.IsContainXAxis)
                {
                    axisMotionControlPanel.DataGrid_X.Visibility = Visibility.Visible;
                }
                else
                {
                    axisMotionControlPanel.DataGrid_X.Visibility = Visibility.Collapsed;
                }
            })));


        /// <summary>
        /// 控制面板是否包含Y轴
        /// </summary>
        public bool IsContainYAxis
        {
            get { return (bool)GetValue(IsContainYAxisProperty); }
            set { SetValue(IsContainYAxisProperty, value); }
        }

        public static readonly DependencyProperty IsContainYAxisProperty =
            DependencyProperty.Register("IsContainYAxis", typeof(bool), typeof(AxisMotionControlPanel), new PropertyMetadata(true, new PropertyChangedCallback((sender, args) =>
            {
                var axisMotionControlPanel = (AxisMotionControlPanel)sender;
                if (axisMotionControlPanel.IsContainYAxis)
                {
                    axisMotionControlPanel.DataGrid_Y.Visibility = Visibility.Visible;
                }
                else
                {
                    axisMotionControlPanel.DataGrid_Y.Visibility = Visibility.Collapsed;
                }
            })));


        /// <summary>
        /// 控制面板是否包含Z轴
        /// </summary>
        public bool IsContainZAxis
        {
            get { return (bool)GetValue(IsContainZAxisProperty); }
            set { SetValue(IsContainZAxisProperty, value); }
        }

        public static readonly DependencyProperty IsContainZAxisProperty =
            DependencyProperty.Register("IsContainZAxis", typeof(bool), typeof(AxisMotionControlPanel), new PropertyMetadata(true, new PropertyChangedCallback((sender, args) =>
            {
                var axisMotionControlPanel = (AxisMotionControlPanel)sender;
                if (axisMotionControlPanel.IsContainZAxis)
                {
                    axisMotionControlPanel.DataGrid_Z.Visibility = Visibility.Visible;
                }
                else
                {
                    axisMotionControlPanel.DataGrid_Z.Visibility = Visibility.Collapsed;
                }
            })));


        /// <summary>
        /// 控制面板是否包含RX轴
        /// </summary>
        public bool IsContainRXAxis
        {
            get { return (bool)GetValue(IsContainRXAxisProperty); }
            set { SetValue(IsContainRXAxisProperty, value); }
        }

        public static readonly DependencyProperty IsContainRXAxisProperty =
            DependencyProperty.Register("IsContainRXAxis", typeof(bool), typeof(AxisMotionControlPanel), new PropertyMetadata(true, new PropertyChangedCallback((sender, args) =>
            {
                var axisMotionControlPanel = (AxisMotionControlPanel)sender;
                if (axisMotionControlPanel.IsContainRXAxis)
                {
                    axisMotionControlPanel.DataGrid_RX.Visibility = Visibility.Visible;
                }
                else
                {
                    axisMotionControlPanel.DataGrid_RX.Visibility = Visibility.Collapsed;
                }
            })));


        /// <summary>
        /// 控制面板是否包含RY轴
        /// </summary>
        public bool IsContainRYAxis
        {
            get { return (bool)GetValue(IsContainRYAxisProperty); }
            set { SetValue(IsContainRYAxisProperty, value); }
        }

        public static readonly DependencyProperty IsContainRYAxisProperty =
            DependencyProperty.Register("IsContainRYAxis", typeof(bool), typeof(AxisMotionControlPanel), new PropertyMetadata(true, new PropertyChangedCallback((sender, args) =>
            {
                var axisMotionControlPanel = (AxisMotionControlPanel)sender;
                if (axisMotionControlPanel.IsContainRYAxis)
                {
                    axisMotionControlPanel.DataGrid_RY.Visibility = Visibility.Visible;
                }
                else
                {
                    axisMotionControlPanel.DataGrid_RY.Visibility = Visibility.Collapsed;
                }
            })));

        /// <summary>
        /// 控制面板是否包含RZ轴
        /// </summary>
        public bool IsContainRZAxis
        {
            get { return (bool)GetValue(IsContainRZAxisProperty); }
            set { SetValue(IsContainRZAxisProperty, value); }
        }

        public static readonly DependencyProperty IsContainRZAxisProperty =
            DependencyProperty.Register("IsContainRZAxis", typeof(bool), typeof(AxisMotionControlPanel), new PropertyMetadata(true, new PropertyChangedCallback((sender, args) =>
            {
                var axisMotionControlPanel = (AxisMotionControlPanel)sender;
                if (axisMotionControlPanel.IsContainRZAxis)
                {
                    axisMotionControlPanel.DataGrid_RZ.Visibility = Visibility.Visible;
                }
                else
                {
                    axisMotionControlPanel.DataGrid_RZ.Visibility = Visibility.Collapsed;
                }
            })));


        public bool IsShowSlantDirection
        {
            get { return (bool)GetValue(IsShowSlantDirectionProperty); }
            set { SetValue(IsShowSlantDirectionProperty, value); }
        }

        public static readonly DependencyProperty IsShowSlantDirectionProperty =
            DependencyProperty.Register("IsShowSlantDirection", typeof(bool), typeof(AxisMotionControlPanel), new PropertyMetadata(true));

    }

    /// <summary>
    /// 定义数据代理，用于绑定DataGrid的列
    /// DataGridtextColumn不能直接绑定显示隐藏原因是其不在可视化树中
    /// 不能继承UserControl的DataContext
    /// </summary>
    public class BindingProxy : Freezable
    {
        protected override Freezable CreateInstanceCore() => new BindingProxy();

        public object Data
        {
            get { return (object)GetValue(DataProperty); }
            set { SetValue(DataProperty, value); }
        }

        public static readonly DependencyProperty DataProperty =
            DependencyProperty.Register("Data", typeof(object), typeof(BindingProxy), new UIPropertyMetadata(null));

    }
}
