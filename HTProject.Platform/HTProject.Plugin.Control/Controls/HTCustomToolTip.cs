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
    public enum ToolTipType
    {
        NormalToolTip,
        ErrorToolTip
    }

    public class HTCustomToolTip : ToolTip
    {
        static HTCustomToolTip()
        {
            FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(HTCustomToolTip), new FrameworkPropertyMetadata(typeof(HTCustomToolTip)));
        }

        /// <summary>
        /// ToolTip类型属性（通用类型信息、错误类型信息）
        /// </summary>
        public ToolTipType ToolTipType
        {
            get
            {
                return (ToolTipType)GetValue(ToolTipTypeProperty);
            }
            set
            {
                SetValue(ToolTipTypeProperty, value);
            }
        }

        /// <summary>
        /// ToolTip类型属性（通用类型信息、错误类型信息）
        /// </summary>
        public static readonly DependencyProperty ToolTipTypeProperty =
          DependencyProperty.Register("ToolTipType", typeof(ToolTipType), typeof(HTCustomToolTip), new PropertyMetadata(ToolTipType.NormalToolTip));

        /// <summary>
        /// ToolTip圆角属性
        /// </summary>
        public CornerRadius CornerRadius
        {
            get
            {
                return (CornerRadius)GetValue(CornerRadiusProperty);
            }
            set
            {
                SetValue(CornerRadiusProperty, value);
            }
        }

        /// <summary>
        /// ToolTip圆角属性
        /// </summary>
        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register("CornerRadius", typeof(CornerRadius), typeof(HTCustomToolTip), new PropertyMetadata(new CornerRadius(0.0)));

        /// <summary>
        /// 通用类型信息背景色属性
        /// </summary>
        public Brush NormalToolTipBackground
        {
            get
            {
                return (Brush)GetValue(NormalToolTipBackgroundProperty);
            }
            set
            {
                SetValue(NormalToolTipBackgroundProperty, value);
            }
        }

        /// <summary>
        /// 通用类型信息背景色属性
        /// </summary>
        public static readonly DependencyProperty NormalToolTipBackgroundProperty =
            DependencyProperty.Register("NormalToolTipBackground", typeof(Brush), typeof(HTCustomToolTip), new PropertyMetadata(null));

        /// <summary>
        /// 错误类型信息背景色属性
        /// </summary>
        public Brush ErrorToolTipBackground
        {
            get
            {
                return (Brush)GetValue(ErrorToolTipBackgroundProperty);
            }
            set
            {
                SetValue(ErrorToolTipBackgroundProperty, value);
            }
        }

        /// <summary>
        /// 错误类型信息背景色属性
        /// </summary>
        public static readonly DependencyProperty ErrorToolTipBackgroundProperty =
            DependencyProperty.Register("ErrorToolTipBackground", typeof(Brush), typeof(HTCustomToolTip), new PropertyMetadata(null));
    }
}
