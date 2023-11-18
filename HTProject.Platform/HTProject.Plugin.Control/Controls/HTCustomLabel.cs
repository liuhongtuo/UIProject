using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows;
using System.Windows.Controls;
using PropertyChanged;

namespace HTProject.Plugin.Control.Controls
{
    public enum LightState
    {
        Normal,
        Flash
    }

    public enum StationState
    {
        Initialize,
        Idle,
        Unknown,
        Error
    }

    /// <summary>
    /// 状态灯Lab风格
    /// </summary>
    [ImplementPropertyChanged]
    public class HTCustomStateLabel : Label
    {

        static HTCustomStateLabel()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(HTCustomStateLabel), new FrameworkPropertyMetadata(typeof(HTCustomStateLabel)));
        }

        /// <summary>
        /// StateIcon
        /// </summary>
        public ImageSource StateIcon
        {
            get
            {
                return (ImageSource)GetValue(StateIconProperty);
            }
            set
            {
                SetValue(StateIconProperty, value);
            }
        }

        /// <summary>
        /// 状态属性
        /// </summary>
        public static readonly DependencyProperty StateIconProperty
            = DependencyProperty.Register("StateIcon", typeof(ImageSource), typeof(HTCustomStateLabel), new PropertyMetadata(null));


        /// <summary>
        /// NormalIcon
        /// </summary>
        public ImageSource NormalIcon
        {
            get
            {
                return (ImageSource)GetValue(NormalIconProperty);
            }
            set
            {
                SetValue(NormalIconProperty, value);
            }
        }


        /// <summary>
        /// Nomal图片属性
        /// </summary>
        public static readonly DependencyProperty NormalIconProperty
            = DependencyProperty.Register("NormalIcon", typeof(ImageSource), typeof(HTCustomStateLabel), new PropertyMetadata(null));

        /// <summary>
        /// FlashIcon
        /// </summary>
        public ImageSource FlashIcon
        {
            get
            {
                return (ImageSource)GetValue(FlashIconProperty);
            }
            set
            {
                SetValue(FlashIconProperty, value);
            }
        }

        /// <summary>
        /// 点亮图片属性
        /// </summary>
        public static readonly DependencyProperty FlashIconProperty
            = DependencyProperty.Register("FlashIcon", typeof(ImageSource), typeof(HTCustomStateLabel), new PropertyMetadata(null));


        public LightState State
        {
            get { return (LightState)GetValue(StateProperty); }
            set { SetValue(StateProperty, value); }
        }

        public static readonly DependencyProperty StateProperty =
            DependencyProperty.Register("State", typeof(LightState), typeof(HTCustomStateLabel), new FrameworkPropertyMetadata(LightState.Normal, OnStateChanged));

        private static void OnStateChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var stateLabel = d as HTCustomStateLabel;

            if (stateLabel != null)
            {
                stateLabel.State = (LightState)e.NewValue;

                switch (stateLabel.State)
                {
                    case LightState.Normal:
                        stateLabel.StateIcon = stateLabel.NormalIcon;
                        break;
                    case LightState.Flash:
                        stateLabel.StateIcon = stateLabel.FlashIcon;
                        break;
                    default:
                        break;
                }
            }
        }

    }

    /// <summary>
    /// 图标Lab风格
    /// </summary>
    public class HTCustomIconLabel : Label
    {

        static HTCustomIconLabel()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(HTCustomIconLabel), new FrameworkPropertyMetadata(typeof(HTCustomIconLabel)));
        }


        /// <summary>
        /// NormalIcon
        /// </summary>
        public ImageSource NormalIcon
        {
            get
            {
                return (ImageSource)GetValue(NormalIconProperty);
            }
            set
            {
                SetValue(NormalIconProperty, value);
            }
        }

        /// <summary>
        /// Nomal图片属性
        /// </summary>
        public static readonly DependencyProperty NormalIconProperty
            = DependencyProperty.Register("NormalIcon", typeof(ImageSource), typeof(HTCustomIconLabel), new PropertyMetadata(null));

        /// <summary>
        /// 注册按钮图标宽度属性
        /// </summary>
        public double IconWidth
        {
            get { return (double)GetValue(IconWidthProperty); }
            set { SetValue(IconWidthProperty, value); }
        }

        /// <summary>
        /// 注册按钮图标宽度属性
        /// </summary>
        public static readonly DependencyProperty IconWidthProperty =
            DependencyProperty.Register("IconWidth", typeof(double), typeof(HTCustomIconLabel), new PropertyMetadata(25.0));



        /// <summary>
        /// 注册按钮图标高度属性
        /// </summary>
        public double IconHeight
        {
            get { return (double)GetValue(IconHeightProperty); }
            set { SetValue(IconHeightProperty, value); }
        }

        /// <summary>
        /// 注册按钮图标高度属性
        /// </summary>
        public static readonly DependencyProperty IconHeightProperty =
            DependencyProperty.Register("IconHeight", typeof(double), typeof(HTCustomIconLabel), new PropertyMetadata(25.0));
    }

    /// <summary>
    /// 工站4种状态Lab风格
    /// </summary>
    [ImplementPropertyChanged]
    public class HTCustomStationStateLabel : Label
    {

        static HTCustomStationStateLabel()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(HTCustomStationStateLabel), new FrameworkPropertyMetadata(typeof(HTCustomStationStateLabel)));
        }

        /// <summary>
        /// StateIcon
        /// </summary>
        public ImageSource StationStateIcon
        {
            get
            {
                return (ImageSource)GetValue(StationStateIconProperty);
            }
            set
            {
                SetValue(StationStateIconProperty, value);
            }
        }

        /// <summary>
        /// 状态属性
        /// </summary>
        public static readonly DependencyProperty StationStateIconProperty
            = DependencyProperty.Register("StationStateIconProperty", typeof(ImageSource), typeof(HTCustomStationStateLabel), new PropertyMetadata(null));


        public ImageSource StationInitializeIcon
        {
            get { return (ImageSource)GetValue(StationInitializeIconProperty); }
            set { SetValue(StationInitializeIconProperty, value); }
        }

        public static readonly DependencyProperty StationInitializeIconProperty =
            DependencyProperty.Register("StationInitializeIcon", typeof(ImageSource), typeof(HTCustomStationStateLabel), new PropertyMetadata(null));



        public ImageSource StationIdleIcon
        {
            get { return (ImageSource)GetValue(StationIdleIconProperty); }
            set { SetValue(StationIdleIconProperty, value); }
        }

        public static readonly DependencyProperty StationIdleIconProperty =
            DependencyProperty.Register("StationIdleIcon", typeof(ImageSource), typeof(HTCustomStationStateLabel), new PropertyMetadata(null));


        public ImageSource StationUnknownIcon
        {
            get { return (ImageSource)GetValue(StationUnknownIconProperty); }
            set { SetValue(StationUnknownIconProperty, value); }
        }

        public static readonly DependencyProperty StationUnknownIconProperty =
            DependencyProperty.Register("StationUnknownIcon", typeof(ImageSource), typeof(HTCustomStationStateLabel), new PropertyMetadata(null));


        public ImageSource StationErrorIcon
        {
            get { return (ImageSource)GetValue(StationErrorIconProperty); }
            set { SetValue(StationErrorIconProperty, value); }
        }

        public static readonly DependencyProperty StationErrorIconProperty =
            DependencyProperty.Register("StationErrorIcon", typeof(ImageSource), typeof(HTCustomStationStateLabel), new PropertyMetadata(null));

        public StationState State
        {
            get { return (StationState)GetValue(StateProperty); }
            set { SetValue(StateProperty, value); }
        }

        public static readonly DependencyProperty StateProperty =
            DependencyProperty.Register("State", typeof(StationState), typeof(HTCustomStationStateLabel), new FrameworkPropertyMetadata(StationState.Initialize, OnStateChanged));

        private static void OnStateChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var stateLabel = d as HTCustomStationStateLabel;

            if (stateLabel != null)
            {
                stateLabel.State = (StationState)e.NewValue;

                switch (stateLabel.State)
                {
                    case StationState.Initialize:
                        stateLabel.StationStateIcon = stateLabel.StationInitializeIcon;
                        break;
                    case StationState.Idle:
                        stateLabel.StationStateIcon = stateLabel.StationIdleIcon;
                        break;
                    case StationState.Unknown:
                        stateLabel.StationStateIcon = stateLabel.StationUnknownIcon;
                        break;
                    case StationState.Error:
                        stateLabel.StationStateIcon = stateLabel.StationErrorIcon;
                        break;
                    default:
                        break;
                }
            }
        }

        /// <summary>
        /// 注册按钮图标宽度属性
        /// </summary>
        public double IconWidth
        {
            get { return (double)GetValue(IconWidthProperty); }
            set { SetValue(IconWidthProperty, value); }
        }

        /// <summary>
        /// 注册按钮图标宽度属性
        /// </summary>
        public static readonly DependencyProperty IconWidthProperty =
            DependencyProperty.Register("IconWidth", typeof(double), typeof(HTCustomStationStateLabel), new PropertyMetadata(25.0));



        /// <summary>
        /// 注册按钮图标高度属性
        /// </summary>
        public double IconHeight
        {
            get { return (double)GetValue(IconHeightProperty); }
            set { SetValue(IconHeightProperty, value); }
        }

        /// <summary>
        /// 注册按钮图标高度属性
        /// </summary>
        public static readonly DependencyProperty IconHeightProperty =
            DependencyProperty.Register("IconHeight", typeof(double), typeof(HTCustomStationStateLabel), new PropertyMetadata(25.0));
    }
}
