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
    /// <summary>
    /// 自定义Lab风格
    /// </summary>
    public class HTCustomStateLabel : Label
    {
        /// <summary>
        /// 状态属性
        /// </summary>
        public static readonly DependencyProperty StateIconProperty
            = DependencyProperty.Register("StateIcon", typeof(ImageSource), typeof(HTCustomStateLabel), new PropertyMetadata(null));

        /// <summary>
        /// Nomal图片属性
        /// </summary>
        public static readonly DependencyProperty NormalIconProperty
            = DependencyProperty.Register("NormalIcon", typeof(ImageSource), typeof(HTCustomStateLabel), new PropertyMetadata(null));

        /// <summary>
        /// 点亮图片属性
        /// </summary>
        public static readonly DependencyProperty FlashIconProperty
            = DependencyProperty.Register("FlashIcon", typeof(ImageSource), typeof(HTCustomStateLabel), new PropertyMetadata(null));

        /// <summary>
        /// 状态属性
        /// </summary>
        public static readonly DependencyProperty StateProperty
            = DependencyProperty.Register("State", typeof(string), typeof(HTCustomStateLabel), new FrameworkPropertyMetadata(OnStateChanged));

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
        /// State
        /// </summary>
        public string State
        {
            get
            {
                return ((string)GetValue(StateProperty)).ToString();
            }
            set
            {
                SetValue(StateProperty, value);
            }
        }

        private static void OnStateChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var labEx = d as HTCustomStateLabel;

            if (labEx != null)
            {
                labEx.State = (string)e.NewValue;

                switch (labEx.State)
                {
                    case "Normal":
                        labEx.StateIcon = labEx.NormalIcon;
                        break;
                    case "Flash":
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
