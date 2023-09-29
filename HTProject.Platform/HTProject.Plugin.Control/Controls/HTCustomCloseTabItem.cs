using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace HTProject.Plugin.Control.Controls
{
    public class HTCustomCloseTabItem : TabItem
    {
        static HTCustomCloseTabItem()
        {
            FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(HTCustomCloseTabItem), new FrameworkPropertyMetadata(typeof(HTCustomCloseTabItem)));
        }

        /// <summary>
        /// Tab关闭图标
        /// </summary>
        public ImageSource CloseIcon
        {
            get
            {
                return (ImageSource)GetValue(CloseIconProperty);
            }
            set
            {
                SetValue(CloseIconProperty, value);
            }
        }

        /// <summary>
        /// Tab关闭图标
        /// </summary>
        public static readonly DependencyProperty CloseIconProperty =
            DependencyProperty.Register("CloseIcon", typeof(ImageSource), typeof(HTCustomCloseTabItem), new PropertyMetadata(null));

        /// <summary>
        /// 鼠标悬浮时Tab背景色
        /// </summary>
        public Brush MouseOverBackground
        {
            get
            {
                return (Brush)GetValue(MouseOverBackgroundProperty);
            }
            set
            {
                SetValue(MouseOverBackgroundProperty, value);
            }
        }

        /// <summary>
        /// 鼠标悬浮时Tab背景色
        /// </summary>
        public static readonly DependencyProperty MouseOverBackgroundProperty =
            DependencyProperty.Register("MouseOverBackground", typeof(Brush), typeof(HTCustomCloseTabItem), new PropertyMetadata(null));

        /// <summary>
        /// 鼠标点击时Tab背景色
        /// </summary>
        public Brush MousePressedBackground
        {
            get
            {
                return (Brush)GetValue(MousePressedBackgroundProperty);
            }
            set
            {
                SetValue(MousePressedBackgroundProperty, value);
            }
        }

        /// <summary>
        /// 鼠标点击时Tab背景色
        /// </summary>
        public static readonly DependencyProperty MousePressedBackgroundProperty =
            DependencyProperty.Register("MousePressedBackground", typeof(Brush), typeof(HTCustomCloseTabItem), new PropertyMetadata(null));

        /// <summary>
        /// 鼠标点击时Tab文本颜色属性
        /// </summary>
        public Brush MousePressedForeground
        {
            get
            {
                return (Brush)GetValue(MousePressedForegroundProperty);
            }
            set
            {
                SetValue(MousePressedForegroundProperty, value);
            }
        }

        /// <summary>
        /// 鼠标点击时Tab文本颜色属性
        /// </summary>
        public static readonly DependencyProperty MousePressedForegroundProperty =
            DependencyProperty.Register("MousePressedForeground", typeof(Brush), typeof(HTCustomCloseTabItem), new PropertyMetadata(null));

        /// <summary>
        /// 注册Tab关闭路由事件
        /// </summary>
        public event RoutedEventHandler CloseItem
        {
            add
            {
                AddHandler(CloseItemEvent, value);
            }
            remove
            {
                RemoveHandler(CloseItemEvent, value);
            }
        }

        /// <summary>
        /// 注册Tab关闭路由事件
        /// </summary>
        public static readonly RoutedEvent CloseItemEvent =
            EventManager.RegisterRoutedEvent("CloseItem", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(HTCustomCloseTabItem));
    }

    public class HTCustomIconCloseTabItem : HTCustomCloseTabItem
    {
        static HTCustomIconCloseTabItem()
        {
            FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(HTCustomIconCloseTabItem), new FrameworkPropertyMetadata(typeof(HTCustomIconCloseTabItem)));
        }

        /// <summary>
        /// 注册鼠标悬浮时Tab关闭图标属性
        /// </summary>
        public ImageSource MouseOverCloseIcon
        {
            get { return (ImageSource)GetValue(MouseOverCloseIconProperty); }
            set { SetValue(MouseOverCloseIconProperty, value); }
        }

        /// <summary>
        /// 注册鼠标悬浮时Tab关闭图标属性
        /// </summary>
        public static readonly DependencyProperty MouseOverCloseIconProperty
            = DependencyProperty.Register("MouseOverCloseIcon", typeof(ImageSource), typeof(HTCustomIconCloseTabItem), new PropertyMetadata(null));

        /// <summary>
        /// 注册鼠标点击时Tab关闭图标属性
        /// </summary>
        public ImageSource MousePressedCloseIcon
        {
            get { return (ImageSource)GetValue(MousePressedCloseIconProperty); }
            set { SetValue(MousePressedCloseIconProperty, value); }
        }

        /// <summary>
        /// 注册鼠标点击时Tab关闭图标属性
        /// </summary>
        public static readonly DependencyProperty MousePressedCloseIconProperty
            = DependencyProperty.Register("MousePressedCloseIcon", typeof(ImageSource), typeof(HTCustomIconCloseTabItem), new PropertyMetadata(null));

        /// <summary>
        /// 注册鼠标点击时Tab关闭图标属性
        /// </summary>
        public ImageSource MouseDisabledCloseIcon
        {
            get { return (ImageSource)GetValue(MouseDisabledCloseIconProperty); }
            set { SetValue(MouseDisabledCloseIconProperty, value); }
        }

        /// <summary>
        /// 注册鼠标点击时Tab关闭图标属性
        /// </summary>
        public static readonly DependencyProperty MouseDisabledCloseIconProperty
            = DependencyProperty.Register("MouseDisabledCloseIcon", typeof(ImageSource), typeof(HTCustomIconCloseTabItem), new PropertyMetadata(null));

        #region TabControl图标属性

        /// <summary>
        /// 注册按钮图标宽度属性
        /// </summary>
        public double CloseIconWidth
        {
            get { return (double)GetValue(CloseIconWidthProperty); }
            set { SetValue(CloseIconWidthProperty, value); }
        }

        /// <summary>
        /// 注册按钮图标宽度属性
        /// </summary>
        public static readonly DependencyProperty CloseIconWidthProperty =
            DependencyProperty.Register("CloseIconWidth", typeof(double), typeof(HTCustomIconCloseTabItem), new PropertyMetadata(40.0));


        /// <summary>
        /// 注册按钮图标高度属性
        /// </summary>
        public double CloseIconHeight
        {
            get { return (double)GetValue(CloseIconHeightProperty); }
            set { SetValue(CloseIconHeightProperty, value); }
        }

        /// <summary>
        /// 注册按钮图标高度属性
        /// </summary>
        public static readonly DependencyProperty CloseIconHeightProperty =
            DependencyProperty.Register("CloseIconHeight", typeof(double), typeof(HTCustomIconCloseTabItem), new PropertyMetadata(40.0));

        #endregion
    }
}
