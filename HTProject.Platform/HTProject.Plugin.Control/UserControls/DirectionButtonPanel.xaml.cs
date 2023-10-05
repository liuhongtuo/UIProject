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
    /// Interaction logic for DirectionButtonPanel.xaml
    /// </summary>
    public partial class DirectionButtonPanel : UserControl
    {
        public DirectionButtonPanel()
        {
            InitializeComponent();
        }

        #region DependencyProperty

        #region BtnAdjustLeft
        public string BtnAdjustLeft_Icon
        {
            get { return (string)GetValue(BtnAdjustLeft_IconProperty); }
            set { SetValue(BtnAdjustLeft_IconProperty, value); }
        }


        public static readonly DependencyProperty BtnAdjustLeft_IconProperty =
            DependencyProperty.Register("BtnAdjustLeft_Icon", typeof(string), typeof(DirectionButtonPanel), new PropertyMetadata(@"pack://application:,,,/HTProject.Plugin.Control;Component/Icons/EngineeringIcons/ArrowLeft_64x64_Normal.png"));
        public string BtnAdjustLeft_MouseOverIcon
        {
            get { return (string)GetValue(BtnAdjustLeft_MouseOverIconProperty); }
            set { SetValue(BtnAdjustLeft_MouseOverIconProperty, value); }
        }


        public static readonly DependencyProperty BtnAdjustLeft_MouseOverIconProperty =
            DependencyProperty.Register("BtnAdjustLeft_MouseOverIcon", typeof(string), typeof(DirectionButtonPanel), new PropertyMetadata(@"pack://application:,,,/HTProject.Plugin.Control;Component/Icons/EngineeringIcons/ArrowLeft_64x64_Pressed.png"));
        public string BtnAdjustLeft_MousePressedIcon
        {
            get { return (string)GetValue(BtnAdjustLeft_MousePressedIconProperty); }
            set { SetValue(BtnAdjustLeft_MousePressedIconProperty, value); }
        }


        public static readonly DependencyProperty BtnAdjustLeft_MousePressedIconProperty =
            DependencyProperty.Register("BtnAdjustLeft_MousePressedIcon", typeof(string), typeof(DirectionButtonPanel), new PropertyMetadata(@"pack://application:,,,/HTProject.Plugin.Control;Component/Icons/EngineeringIcons/ArrowLeft_64x64_Pressed.png"));
        public string BtnAdjustLeft_MouseDisableIcon
        {
            get { return (string)GetValue(BtnAdjustLeft_MouseDisableIconProperty); }
            set { SetValue(BtnAdjustLeft_MouseDisableIconProperty, value); }
        }

        public static readonly DependencyProperty BtnAdjustLeft_MouseDisableIconProperty =
            DependencyProperty.Register("BtnAdjustLeft_MouseDisableIcon", typeof(string), typeof(DirectionButtonPanel), new PropertyMetadata(@"pack://application:,,,/HTProject.Plugin.Control;Component/Icons/EngineeringIcons/ArrowLeft_64x64_disable.png"));

        public string BtnAdjustLeft_TxtToolTip
        {
            get { return (string)GetValue(BtnAdjustLeft_TxtToolTipProperty); }
            set { SetValue(BtnAdjustLeft_TxtToolTipProperty, value); }
        }

        public static readonly DependencyProperty BtnAdjustLeft_TxtToolTipProperty =
            DependencyProperty.Register("BtnAdjustLeft_TxtToolTip", typeof(string), typeof(DirectionButtonPanel), new PropertyMetadata(string.Empty));

        #endregion

        #region BtnAdjustRight
        public string BtnAdjustRight_Icon
        {
            get { return (string)GetValue(BtnAdjustRight_IconProperty); }
            set { SetValue(BtnAdjustRight_IconProperty, value); }
        }

        public static readonly DependencyProperty BtnAdjustRight_IconProperty =
            DependencyProperty.Register("BtnAdjustRight_Icon", typeof(string), typeof(DirectionButtonPanel), new PropertyMetadata(@"pack://application:,,,/HTProject.Plugin.Control;Component/Icons/EngineeringIcons/ArrowRight_64x64_Normal.png"));
        public string BtnAdjustRight_MouseOverIcon
        {
            get { return (string)GetValue(BtnAdjustRight_MouseOverIconProperty); }
            set { SetValue(BtnAdjustRight_MouseOverIconProperty, value); }
        }

        public static readonly DependencyProperty BtnAdjustRight_MouseOverIconProperty =
            DependencyProperty.Register("BtnAdjustRight_MouseOverIcon", typeof(string), typeof(DirectionButtonPanel), new PropertyMetadata(@"pack://application:,,,/HTProject.Plugin.Control;Component/Icons/EngineeringIcons/ArrowRight_64x64_Pressed.png"));
        public string BtnAdjustRight_MousePressedIcon
        {
            get { return (string)GetValue(BtnAdjustRight_MousePressedIconProperty); }
            set { SetValue(BtnAdjustRight_MousePressedIconProperty, value); }
        }

        public static readonly DependencyProperty BtnAdjustRight_MousePressedIconProperty =
            DependencyProperty.Register("BtnAdjustRight_MousePressedIcon", typeof(string), typeof(DirectionButtonPanel), new PropertyMetadata(@"pack://application:,,,/HTProject.Plugin.Control;Component/Icons/EngineeringIcons/ArrowRight_64x64_Pressed.png"));
        public string BtnAdjustRight_MouseDisableIcon
        {
            get { return (string)GetValue(BtnAdjustRight_MouseDisableIconProperty); }
            set { SetValue(BtnAdjustRight_MouseDisableIconProperty, value); }
        }

        public static readonly DependencyProperty BtnAdjustRight_MouseDisableIconProperty =
            DependencyProperty.Register("BtnAdjustRight_MouseDisableIcon", typeof(string), typeof(DirectionButtonPanel), new PropertyMetadata(@"pack://application:,,,/HTProject.Plugin.Control;Component/Icons/EngineeringIcons/ArrowRight_64x64_disable.png"));

        public string BtnAdjustRight_TxtToolTip
        {
            get { return (string)GetValue(BtnAdjustRight_TxtToolTipProperty); }
            set { SetValue(BtnAdjustRight_TxtToolTipProperty, value); }
        }

        public static readonly DependencyProperty BtnAdjustRight_TxtToolTipProperty =
            DependencyProperty.Register("BtnAdjustRight_TxtToolTip", typeof(string), typeof(DirectionButtonPanel), new PropertyMetadata(string.Empty));
        #endregion

        #region BtnAdjustUp
        public string BtnAdjustUp_Icon
        {
            get { return (string)GetValue(BtnAdjustUp_IconProperty); }
            set { SetValue(BtnAdjustUp_IconProperty, value); }
        }

        public static readonly DependencyProperty BtnAdjustUp_IconProperty =
            DependencyProperty.Register("BtnAdjustUp_Icon", typeof(string), typeof(DirectionButtonPanel), new PropertyMetadata(@"pack://application:,,,/HTProject.Plugin.Control;Component/Icons/EngineeringIcons/ArrowUp_64x64_Normal.png"));
        public string BtnAdjustUp_MouseOverIcon
        {
            get { return (string)GetValue(BtnAdjustUp_MouseOverIconProperty); }
            set { SetValue(BtnAdjustUp_MouseOverIconProperty, value); }
        }

        public static readonly DependencyProperty BtnAdjustUp_MouseOverIconProperty =
            DependencyProperty.Register("BtnAdjustUp_MouseOverIcon", typeof(string), typeof(DirectionButtonPanel), new PropertyMetadata(@"pack://application:,,,/HTProject.Plugin.Control;Component/Icons/EngineeringIcons/ArrowUp_64x64_Pressed.png"));
        public string BtnAdjustUp_MousePressedIcon
        {
            get { return (string)GetValue(BtnAdjustUp_MousePressedIconProperty); }
            set { SetValue(BtnAdjustUp_MousePressedIconProperty, value); }
        }

        public static readonly DependencyProperty BtnAdjustUp_MousePressedIconProperty =
            DependencyProperty.Register("BtnAdjustUp_MousePressedIcon", typeof(string), typeof(DirectionButtonPanel), new PropertyMetadata(@"pack://application:,,,/HTProject.Plugin.Control;Component/Icons/EngineeringIcons/ArrowUp_64x64_Pressed.png"));
        public string BtnAdjustUp_MouseDisableIcon
        {
            get { return (string)GetValue(BtnAdjustUp_MouseDisableIconProperty); }
            set { SetValue(BtnAdjustUp_MouseDisableIconProperty, value); }
        }

        public static readonly DependencyProperty BtnAdjustUp_MouseDisableIconProperty =
            DependencyProperty.Register("BtnAdjustUp_MouseDisableIcon", typeof(string), typeof(DirectionButtonPanel), new PropertyMetadata(@"pack://application:,,,/HTProject.Plugin.Control;Component/Icons/EngineeringIcons/ArrowUp_64x64_disable.png"));

        public string BtnAdjustUp_TxtToolTip
        {
            get { return (string)GetValue(BtnAdjustUp_TxtToolTipProperty); }
            set { SetValue(BtnAdjustUp_TxtToolTipProperty, value); }
        }

        public static readonly DependencyProperty BtnAdjustUp_TxtToolTipProperty =
            DependencyProperty.Register("BtnAdjustUp_TxtToolTip", typeof(string), typeof(DirectionButtonPanel), new PropertyMetadata(string.Empty));

        #endregion

        #region BtnAdjustDown
        public string BtnAdjustDown_Icon
        {
            get { return (string)GetValue(BtnAdjustDown_IconProperty); }
            set { SetValue(BtnAdjustDown_IconProperty, value); }
        }

        public static readonly DependencyProperty BtnAdjustDown_IconProperty =
            DependencyProperty.Register("BtnAdjustDown_Icon", typeof(string), typeof(DirectionButtonPanel), new PropertyMetadata(@"pack://application:,,,/HTProject.Plugin.Control;Component/Icons/EngineeringIcons/ArrowDown_64x64_Normal.png"));
        public string BtnAdjustDown_MouseOverIcon
        {
            get { return (string)GetValue(BtnAdjustDown_MouseOverIconProperty); }
            set { SetValue(BtnAdjustDown_MouseOverIconProperty, value); }
        }

        public static readonly DependencyProperty BtnAdjustDown_MouseOverIconProperty =
            DependencyProperty.Register("BtnAdjustDown_MouseOverIcon", typeof(string), typeof(DirectionButtonPanel), new PropertyMetadata(@"pack://application:,,,/HTProject.Plugin.Control;Component/Icons/EngineeringIcons/ArrowDown_64x64_Pressed.png"));
        public string BtnAdjustDown_MousePressedIcon
        {
            get { return (string)GetValue(BtnAdjustDown_MousePressedIconProperty); }
            set { SetValue(BtnAdjustDown_MousePressedIconProperty, value); }
        }

        public static readonly DependencyProperty BtnAdjustDown_MousePressedIconProperty =
            DependencyProperty.Register("BtnAdjustDown_MousePressedIcon", typeof(string), typeof(DirectionButtonPanel), new PropertyMetadata(@"pack://application:,,,/HTProject.Plugin.Control;Component/Icons/EngineeringIcons/ArrowDown_64x64_Pressed.png"));
        public string BtnAdjustDown_MouseDisableIcon
        {
            get { return (string)GetValue(BtnAdjustDown_MouseDisableIconProperty); }
            set { SetValue(BtnAdjustDown_MouseDisableIconProperty, value); }
        }

        public static readonly DependencyProperty BtnAdjustDown_MouseDisableIconProperty =
            DependencyProperty.Register("BtnAdjustDown_MouseDisableIcon", typeof(string), typeof(DirectionButtonPanel), new PropertyMetadata(@"pack://application:,,,/HTProject.Plugin.Control;Component/Icons/EngineeringIcons/ArrowDown_64x64_disable.png"));

        public string BtnAdjustDown_TxtToolTip
        {
            get { return (string)GetValue(BtnAdjustDown_TxtToolTipProperty); }
            set { SetValue(BtnAdjustDown_TxtToolTipProperty, value); }
        }

        public static readonly DependencyProperty BtnAdjustDown_TxtToolTipProperty =
            DependencyProperty.Register("BtnAdjustDown_TxtToolTip", typeof(string), typeof(DirectionButtonPanel), new PropertyMetadata(string.Empty));

        #endregion

        #region BtnAdjustLeftUp
        public string BtnAdjustLeftUp_Icon
        {
            get { return (string)GetValue(BtnAdjustLeftUp_IconProperty); }
            set { SetValue(BtnAdjustLeftUp_IconProperty, value); }
        }


        public static readonly DependencyProperty BtnAdjustLeftUp_IconProperty =
            DependencyProperty.Register("BtnAdjustLeftUp_Icon", typeof(string), typeof(DirectionButtonPanel), new PropertyMetadata(@"pack://application:,,,/HTProject.Plugin.Control;Component/Icons/EngineeringIcons/ArrowLeftUp_64x64_Normal.png"));
        public string BtnAdjustLeftUp_MouseOverIcon
        {
            get { return (string)GetValue(BtnAdjustLeftUp_MouseOverIconProperty); }
            set { SetValue(BtnAdjustLeftUp_MouseOverIconProperty, value); }
        }

        public static readonly DependencyProperty BtnAdjustLeftUp_MouseOverIconProperty =
            DependencyProperty.Register("BtnAdjustLeftUp_MouseOverIcon", typeof(string), typeof(DirectionButtonPanel), new PropertyMetadata(@"pack://application:,,,/HTProject.Plugin.Control;Component/Icons/EngineeringIcons/ArrowLeftUp_64x64_Pressed.png"));
        public string BtnAdjustLeftUp_MousePressedIcon
        {
            get { return (string)GetValue(BtnAdjustLeftUp_MousePressedIconProperty); }
            set { SetValue(BtnAdjustLeftUp_MousePressedIconProperty, value); }
        }

        public static readonly DependencyProperty BtnAdjustLeftUp_MousePressedIconProperty =
            DependencyProperty.Register("BtnAdjustLeftUp_MousePressedIcon", typeof(string), typeof(DirectionButtonPanel), new PropertyMetadata(@"pack://application:,,,/HTProject.Plugin.Control;Component/Icons/EngineeringIcons/ArrowLeftUp_64x64_Pressed.png"));
        public string BtnAdjustLeftUp_MouseDisableIcon
        {
            get { return (string)GetValue(BtnAdjustLeftUp_MouseDisableIconProperty); }
            set { SetValue(BtnAdjustLeftUp_MouseDisableIconProperty, value); }
        }

        public static readonly DependencyProperty BtnAdjustLeftUp_MouseDisableIconProperty =
            DependencyProperty.Register("BtnAdjustLeftUp_MouseDisableIcon", typeof(string), typeof(DirectionButtonPanel), new PropertyMetadata(@"pack://application:,,,/HTProject.Plugin.Control;Component/Icons/EngineeringIcons/ArrowLeftUp_64x64_Disable.png"));

        public string BtnAdjustLeftUp_TxtToolTip
        {
            get { return (string)GetValue(BtnAdjustLeftUp_TxtToolTipProperty); }
            set { SetValue(BtnAdjustLeftUp_TxtToolTipProperty, value); }
        }

        public static readonly DependencyProperty BtnAdjustLeftUp_TxtToolTipProperty =
            DependencyProperty.Register("BtnAdjustLeftUp_TxtToolTip", typeof(string), typeof(DirectionButtonPanel), new PropertyMetadata(string.Empty));

        #endregion

        #region BtnAdjustRightUp
        public string BtnAdjustRightUp_Icon
        {
            get { return (string)GetValue(BtnAdjustRightUp_IconProperty); }
            set { SetValue(BtnAdjustRightUp_IconProperty, value); }
        }

        public static readonly DependencyProperty BtnAdjustRightUp_IconProperty =
            DependencyProperty.Register("BtnAdjustRightUp_Icon", typeof(string), typeof(DirectionButtonPanel), new PropertyMetadata(@"pack://application:,,,/HTProject.Plugin.Control;Component/Icons/EngineeringIcons/ArrowRightUp_64x64_Normal.png"));
        public string BtnAdjustRightUp_MouseOverIcon
        {
            get { return (string)GetValue(BtnAdjustRightUp_MouseOverIconProperty); }
            set { SetValue(BtnAdjustRightUp_MouseOverIconProperty, value); }
        }

        public static readonly DependencyProperty BtnAdjustRightUp_MouseOverIconProperty =
            DependencyProperty.Register("BtnAdjustRightUp_MouseOverIcon", typeof(string), typeof(DirectionButtonPanel), new PropertyMetadata(@"pack://application:,,,/HTProject.Plugin.Control;Component/Icons/EngineeringIcons/ArrowRightUp_64x64_Pressed.png"));
        public string BtnAdjustRightUp_MousePressedIcon
        {
            get { return (string)GetValue(BtnAdjustRightUp_MousePressedIconProperty); }
            set { SetValue(BtnAdjustRightUp_MousePressedIconProperty, value); }
        }

        public static readonly DependencyProperty BtnAdjustRightUp_MousePressedIconProperty =
            DependencyProperty.Register("BtnAdjustRightUp_MousePressedIcon", typeof(string), typeof(DirectionButtonPanel), new PropertyMetadata(@"pack://application:,,,/HTProject.Plugin.Control;Component/Icons/EngineeringIcons/ArrowRightUp_64x64_Pressed.png"));
        public string BtnAdjustRightUp_MouseDisableIcon
        {
            get { return (string)GetValue(BtnAdjustRightUp_MouseDisableIconProperty); }
            set { SetValue(BtnAdjustRightUp_MouseDisableIconProperty, value); }
        }

        public static readonly DependencyProperty BtnAdjustRightUp_MouseDisableIconProperty =
            DependencyProperty.Register("BtnAdjustRightUp_MouseDisableIcon", typeof(string), typeof(DirectionButtonPanel), new PropertyMetadata(@"pack://application:,,,/HTProject.Plugin.Control;Component/Icons/EngineeringIcons/ArrowRightUp_64x64_Disable.png"));

        public string BtnAdjustRightUp_TxtToolTip
        {
            get { return (string)GetValue(BtnAdjustRightUp_TxtToolTipProperty); }
            set { SetValue(BtnAdjustRightUp_TxtToolTipProperty, value); }
        }

        public static readonly DependencyProperty BtnAdjustRightUp_TxtToolTipProperty =
            DependencyProperty.Register("BtnAdjustRightUp_TxtToolTip", typeof(string), typeof(DirectionButtonPanel), new PropertyMetadata(string.Empty));

        #endregion

        #region BtnAdjustLeftDown
        public string BtnAdjustLeftDown_Icon
        {
            get { return (string)GetValue(BtnAdjustLeftDown_IconProperty); }
            set { SetValue(BtnAdjustLeftDown_IconProperty, value); }
        }

        public static readonly DependencyProperty BtnAdjustLeftDown_IconProperty =
            DependencyProperty.Register("BtnAdjustLeftDown_Icon", typeof(string), typeof(DirectionButtonPanel), new PropertyMetadata(@"pack://application:,,,/HTProject.Plugin.Control;Component/Icons/EngineeringIcons/ArrowLeftDown_64x64_Normal.png"));
        public string BtnAdjustLeftDown_MouseOverIcon
        {
            get { return (string)GetValue(BtnAdjustLeftDown_MouseOverIconProperty); }
            set { SetValue(BtnAdjustLeftDown_MouseOverIconProperty, value); }
        }

        public static readonly DependencyProperty BtnAdjustLeftDown_MouseOverIconProperty =
            DependencyProperty.Register("BtnAdjustLeftDown_MouseOverIcon", typeof(string), typeof(DirectionButtonPanel), new PropertyMetadata(@"pack://application:,,,/HTProject.Plugin.Control;Component/Icons/EngineeringIcons/ArrowLeftDown_64x64_Pressed.png"));
        public string BtnAdjustLeftDown_MousePressedIcon
        {
            get { return (string)GetValue(BtnAdjustLeftDown_MousePressedIconProperty); }
            set { SetValue(BtnAdjustLeftDown_MousePressedIconProperty, value); }
        }

        public static readonly DependencyProperty BtnAdjustLeftDown_MousePressedIconProperty =
            DependencyProperty.Register("BtnAdjustLeftDown_MousePressedIcon", typeof(string), typeof(DirectionButtonPanel), new PropertyMetadata(@"pack://application:,,,/HTProject.Plugin.Control;Component/Icons/EngineeringIcons/ArrowLeftDown_64x64_Pressed.png"));
        public string BtnAdjustLeftDown_MouseDisableIcon
        {
            get { return (string)GetValue(BtnAdjustLeftDown_MouseDisableIconProperty); }
            set { SetValue(BtnAdjustLeftDown_MouseDisableIconProperty, value); }
        }

        public static readonly DependencyProperty BtnAdjustLeftDown_MouseDisableIconProperty =
            DependencyProperty.Register("BtnAdjustLeftDown_MouseDisableIcon", typeof(string), typeof(DirectionButtonPanel), new PropertyMetadata(@"pack://application:,,,/HTProject.Plugin.Control;Component/Icons/EngineeringIcons/ArrowLeftDown_64x64_Disable.png"));

        public string BtnAdjustLeftDown_TxtToolTip
        {
            get { return (string)GetValue(BtnAdjustLeftDown_TxtToolTipProperty); }
            set { SetValue(BtnAdjustLeftDown_TxtToolTipProperty, value); }
        }

        public static readonly DependencyProperty BtnAdjustLeftDown_TxtToolTipProperty =
            DependencyProperty.Register("BtnAdjustLeftDown_TxtToolTip", typeof(string), typeof(DirectionButtonPanel), new PropertyMetadata(string.Empty));
        #endregion

        #region BtnAdjustRightDown
        public string BtnAdjustRightDown_Icon
        {
            get { return (string)GetValue(BtnAdjustRightDown_IconProperty); }
            set { SetValue(BtnAdjustRightDown_IconProperty, value); }
        }

        public static readonly DependencyProperty BtnAdjustRightDown_IconProperty =
            DependencyProperty.Register("BtnAdjustRightDown_Icon", typeof(string), typeof(DirectionButtonPanel), new PropertyMetadata(@"pack://application:,,,/HTProject.Plugin.Control;Component/Icons/EngineeringIcons/ArrowRightDown_64x64_Normal.png"));
        public string BtnAdjustRightDown_MouseOverIcon
        {
            get { return (string)GetValue(BtnAdjustRightDown_MouseOverIconProperty); }
            set { SetValue(BtnAdjustRightDown_MouseOverIconProperty, value); }
        }

        public static readonly DependencyProperty BtnAdjustRightDown_MouseOverIconProperty =
            DependencyProperty.Register("BtnAdjustRightDown_MouseOverIcon", typeof(string), typeof(DirectionButtonPanel), new PropertyMetadata(@"pack://application:,,,/HTProject.Plugin.Control;Component/Icons/EngineeringIcons/ArrowRightDown_64x64_Pressed.png"));
        public string BtnAdjustRightDown_MousePressedIcon
        {
            get { return (string)GetValue(BtnAdjustRightDown_MousePressedIconProperty); }
            set { SetValue(BtnAdjustRightDown_MousePressedIconProperty, value); }
        }

        public static readonly DependencyProperty BtnAdjustRightDown_MousePressedIconProperty =
            DependencyProperty.Register("BtnAdjustRightDown_MousePressedIcon", typeof(string), typeof(DirectionButtonPanel), new PropertyMetadata(@"pack://application:,,,/HTProject.Plugin.Control;Component/Icons/EngineeringIcons/ArrowRightDown_64x64_Pressed.png"));
        public string BtnAdjustRightDown_MouseDisableIcon
        {
            get { return (string)GetValue(BtnAdjustRightDown_MouseDisableIconProperty); }
            set { SetValue(BtnAdjustRightDown_MouseDisableIconProperty, value); }
        }

        public static readonly DependencyProperty BtnAdjustRightDown_MouseDisableIconProperty =
            DependencyProperty.Register("BtnAdjustRightDown_MouseDisableIcon", typeof(string), typeof(DirectionButtonPanel), new PropertyMetadata(@"pack://application:,,,/HTProject.Plugin.Control;Component/Icons/EngineeringIcons/ArrowRightDown_64x64_Disable.png"));

        public string BtnAdjustRightDown_TxtToolTip
        {
            get { return (string)GetValue(BtnAdjustRightDown_TxtToolTipProperty); }
            set { SetValue(BtnAdjustRightDown_TxtToolTipProperty, value); }
        }

        public static readonly DependencyProperty BtnAdjustRightDown_TxtToolTipProperty =
            DependencyProperty.Register("BtnAdjustRightDown_TxtToolTip", typeof(string), typeof(DirectionButtonPanel), new PropertyMetadata(string.Empty));

        #endregion

        #region TextBox

        public double TxtAdjustStep
        {
            get { return (double)GetValue(TxtAdjustStepProperty); }
            set { SetValue(TxtAdjustStepProperty, value); }
        }

        public static readonly DependencyProperty TxtAdjustStepProperty =
            DependencyProperty.Register("TxtAdjustStep", typeof(double), typeof(DirectionButtonPanel), new PropertyMetadata(1.0));

        public string TxtStep_TxtToolTip
        {
            get { return (string)GetValue(TxtStep_TxtToolTipProperty); }
            set { SetValue(TxtStep_TxtToolTipProperty, value); }
        }

        public static readonly DependencyProperty TxtStep_TxtToolTipProperty =
            DependencyProperty.Register("TxtStep_TxtToolTip", typeof(string), typeof(DirectionButtonPanel), new PropertyMetadata(string.Empty));

        #endregion

        #region Background
        public Brush PanelBrush
        {
            get { return (Brush)GetValue(PanelBrushProperty); }
            set { SetValue(PanelBrushProperty, value); }
        }

        public static readonly DependencyProperty PanelBrushProperty =
            DependencyProperty.Register("PanelBrush", typeof(Brush), typeof(DirectionButtonPanel), new PropertyMetadata(Brushes.Transparent));
        #endregion

        #region BtnCapture

        public string BtnCapture_Icon
        {
            get { return (string)GetValue(BtnCapture_IconProperty); }
            set { SetValue(BtnCapture_IconProperty, value); }
        }

        public static readonly DependencyProperty BtnCapture_IconProperty =
            DependencyProperty.Register("BtnCapture_Icon", typeof(string), typeof(DirectionButtonPanel), new PropertyMetadata(@"pack://application:,,,/HTProject.Plugin.Control;Component/Icons/EngineeringIcons/CameraControl.png"));
        public string BtnCapture_MouseOverIcon
        {
            get { return (string)GetValue(BtnCapture_MouseOverIconProperty); }
            set { SetValue(BtnCapture_MouseOverIconProperty, value); }
        }

        public static readonly DependencyProperty BtnCapture_MouseOverIconProperty =
            DependencyProperty.Register("BtnCapture_MouseOverIcon", typeof(string), typeof(DirectionButtonPanel), new PropertyMetadata(@"pack://application:,,,/HTProject.Plugin.Control;Component/Icons/EngineeringIcons/CameraControl.png"));
        public string BtnCapture_MousePressedIcon
        {
            get { return (string)GetValue(BtnCapture_MousePressedIconProperty); }
            set { SetValue(BtnCapture_MousePressedIconProperty, value); }
        }

        public static readonly DependencyProperty BtnCapture_MousePressedIconProperty =
            DependencyProperty.Register("BtnCapture_MousePressedIcon", typeof(string), typeof(DirectionButtonPanel), new PropertyMetadata(@"pack://application:,,,/HTProject.Plugin.Control;Component/Icons/EngineeringIcons/CameraControl.png"));
        public string BtnCapture_MouseDisableIcon
        {
            get { return (string)GetValue(BtnCapture_MouseDisableIconProperty); }
            set { SetValue(BtnCapture_MouseDisableIconProperty, value); }
        }

        public static readonly DependencyProperty BtnCapture_MouseDisableIconProperty =
            DependencyProperty.Register("BtnCapture_MouseDisableIcon", typeof(string), typeof(DirectionButtonPanel), new PropertyMetadata(@"pack://application:,,,/HTProject.Plugin.Control;Component/Icons/EngineeringIcons/CameraControl.png"));

        public string BtnCapture_TxtToolTip
        {
            get { return (string)GetValue(BtnCapture_TxtToolTipProperty); }
            set { SetValue(BtnCapture_TxtToolTipProperty, value); }
        }

        public static readonly DependencyProperty BtnCapture_TxtToolTipProperty =
            DependencyProperty.Register("BtnCapture_TxtToolTip", typeof(string), typeof(DirectionButtonPanel), new PropertyMetadata(string.Empty));

        #endregion

        #region Command

        public ICommand BtnAdjustCommand
        {
            get { return (ICommand)GetValue(BtnAdjustCommandProperty); }
            set { SetValue(BtnAdjustCommandProperty, value); }
        }

        public static readonly DependencyProperty BtnAdjustCommandProperty =
            DependencyProperty.Register("BtnAdjustCommand", typeof(ICommand), typeof(DirectionButtonPanel), new PropertyMetadata(null));

        public ICommand BtnCaptureCommand
        {
            get { return (ICommand)GetValue(BtnCaptureCommandProperty); }
            set { SetValue(BtnCaptureCommandProperty, value); }
        }

        public static readonly DependencyProperty BtnCaptureCommandProperty =
            DependencyProperty.Register("BtnCaptureCommand", typeof(ICommand), typeof(DirectionButtonPanel), new PropertyMetadata(null));

        public object BtnAdjustLeft_CommandParameter
        {
            get { return (object)GetValue(BtnAdjustLeft_CommandParameterProperty); }
            set { SetValue(BtnAdjustLeft_CommandParameterProperty, value); }
        }

        public static readonly DependencyProperty BtnAdjustLeft_CommandParameterProperty =
            DependencyProperty.Register("BtnAdjustLeft_CommandParameter", typeof(object), typeof(DirectionButtonPanel), new PropertyMetadata("Left"));

        public object BtnAdjustRight_CommandParameter
        {
            get { return (object)GetValue(BtnAdjustRight_CommandParameterProperty); }
            set { SetValue(BtnAdjustRight_CommandParameterProperty, value); }
        }

        public static readonly DependencyProperty BtnAdjustRight_CommandParameterProperty =
            DependencyProperty.Register("BtnAdjustRight_CommandParameter", typeof(object), typeof(DirectionButtonPanel), new PropertyMetadata("Right"));

        public object BtnAdjustUp_CommandParameter
        {
            get { return (object)GetValue(BtnAdjustUp_CommandParameterProperty); }
            set { SetValue(BtnAdjustUp_CommandParameterProperty, value); }
        }

        public static readonly DependencyProperty BtnAdjustUp_CommandParameterProperty =
            DependencyProperty.Register("BtnAdjustUp_CommandParameter", typeof(object), typeof(DirectionButtonPanel), new PropertyMetadata("Up"));

        public object BtnAdjustDown_CommandParameter
        {
            get { return (object)GetValue(BtnAdjustDown_CommandParameterProperty); }
            set { SetValue(BtnAdjustDown_CommandParameterProperty, value); }
        }

        public static readonly DependencyProperty BtnAdjustDown_CommandParameterProperty =
            DependencyProperty.Register("BtnAdjustDown_CommandParameter", typeof(object), typeof(DirectionButtonPanel), new PropertyMetadata("Down"));


        public object BtnCapture_CommandParameter
        {
            get { return (object)GetValue(BtnCapture_CommandParameterProperty); }
            set { SetValue(BtnCapture_CommandParameterProperty, value); }
        }

        public static readonly DependencyProperty BtnCapture_CommandParameterProperty =
            DependencyProperty.Register("BtnCapture_CommandParameter", typeof(object), typeof(DirectionButtonPanel), new PropertyMetadata("Capture"));

        public object BtnAdjustLeftUp_CommandParameter
        {
            get { return (object)GetValue(BtnAdjustLeftUp_CommandParameterProperty); }
            set { SetValue(BtnAdjustLeftUp_CommandParameterProperty, value); }
        }

        public static readonly DependencyProperty BtnAdjustLeftUp_CommandParameterProperty =
            DependencyProperty.Register("BtnAdjustLeftUp_CommandParameter", typeof(object), typeof(DirectionButtonPanel), new PropertyMetadata("LeftUp"));

        public object BtnAdjustRightUp_CommandParameter
        {
            get { return (object)GetValue(BtnAdjustRightUp_CommandParameterProperty); }
            set { SetValue(BtnAdjustRightUp_CommandParameterProperty, value); }
        }

        public static readonly DependencyProperty BtnAdjustRightUp_CommandParameterProperty =
            DependencyProperty.Register("BtnAdjustRightUp_CommandParameter", typeof(object), typeof(DirectionButtonPanel), new PropertyMetadata("RightUp"));

        public object BtnAdjustLeftDown_CommandParameter
        {
            get { return (object)GetValue(BtnAdjustLeftDown_CommandParameterProperty); }
            set { SetValue(BtnAdjustLeftDown_CommandParameterProperty, value); }
        }

        public static readonly DependencyProperty BtnAdjustLeftDown_CommandParameterProperty =
            DependencyProperty.Register("BtnAdjustLeftDown_CommandParameter", typeof(object), typeof(DirectionButtonPanel), new PropertyMetadata("LeftDown"));

        public object BtnAdjustRightDown_CommandParameter
        {
            get { return (object)GetValue(BtnAdjustRightDown_CommandParameterProperty); }
            set { SetValue(BtnAdjustRightDown_CommandParameterProperty, value); }
        }

        public static readonly DependencyProperty BtnAdjustRightDown_CommandParameterProperty =
            DependencyProperty.Register("BtnAdjustRightDown_CommandParameter", typeof(object), typeof(DirectionButtonPanel), new PropertyMetadata("RightDown"));
        #endregion

        #region Visibility

        public bool IsShowSlantDirection
        {
            get { return (bool)GetValue(IsShowSlantDirectionProperty); }
            set { SetValue(IsShowSlantDirectionProperty, value); }
        }

        public static readonly DependencyProperty IsShowSlantDirectionProperty =
            DependencyProperty.Register("IsShowSlantDirection", typeof(bool), typeof(DirectionButtonPanel), new PropertyMetadata(false));

        public bool IsShowCapture
        {
            get { return (bool)GetValue(IsShowCaptureProperty); }
            set { SetValue(IsShowCaptureProperty, value); }
        }

        public static readonly DependencyProperty IsShowCaptureProperty =
            DependencyProperty.Register("IsShowCapture", typeof(bool), typeof(DirectionButtonPanel), new PropertyMetadata(false));

        public bool IsShowHorizontalDirection
        {
            get { return (bool)GetValue(IsShowHorizontalDirectionProperty); }
            set { SetValue(IsShowHorizontalDirectionProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IsShowHorizontalDirection.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsShowHorizontalDirectionProperty =
            DependencyProperty.Register("IsShowHorizontalDirection", typeof(bool), typeof(DirectionButtonPanel), new PropertyMetadata(true));


        public bool IsShowVerticalDirection
        {
            get { return (bool)GetValue(IsShowVerticalDirectionProperty); }
            set { SetValue(IsShowVerticalDirectionProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IsShowVerticalDirection.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsShowVerticalDirectionProperty =
            DependencyProperty.Register("IsShowVerticalDirection", typeof(bool), typeof(DirectionButtonPanel), new PropertyMetadata(true));


        #endregion

        #endregion

    }
}
