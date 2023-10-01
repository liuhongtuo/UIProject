using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows;
using System.Windows.Controls;

namespace HTProject.Plugin.Control.Controls
{
    public enum LightState
    {
        Normal,
        Flash
    }


    /// <summary>
    /// 自定义Lab风格
    /// </summary>
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
            var labEx = d as HTCustomStateLabel;

            if (labEx != null)
            {
                labEx.State = (LightState)e.NewValue;

                switch (labEx.State)
                {
                    case LightState.Normal:
                        labEx.StateIcon = labEx.NormalIcon;
                        break;
                    case LightState.Flash:
                        labEx.StateIcon = labEx.FlashIcon;
                        break;
                    default:
                        break;
                }
            }
        }

    }

    /// <summary>
    /// 自定义Lab风格
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
    }
}
