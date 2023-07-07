using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WMWpfProject.Control.Controls
{
    public class HTSystemButton : Button
    {
        [Description("窗体系统按钮大小"), Category("ButtonSkin")]
        public double SystemButtonSize
        {
            get { return (double)GetValue(SystemButtonSizeProperty); }
            set { SetValue(SystemButtonSizeProperty, value); }
        }
        public static readonly DependencyProperty SystemButtonSizeProperty =
            DependencyProperty.Register("SystemButtonSize", typeof(double), typeof(HTSystemButton), new PropertyMetadata(30.0));

        [Description("窗体系统按钮鼠标悬浮背景颜色"), Category("ButtonSkin")]
        public SolidColorBrush SystemButtonHoverColor
        {
            get { return (SolidColorBrush)GetValue(SystemButtonHoverColorProperty); }
            set { SetValue(SystemButtonHoverColorProperty, value); }
        }
        public static readonly DependencyProperty SystemButtonHoverColorProperty =
            DependencyProperty.Register("SystemButtonHoverColor", typeof(SolidColorBrush), typeof(HTSystemButton), new PropertyMetadata(new SolidColorBrush(Color.FromArgb(50, 50, 50, 50))));



        [Description("窗体系统按钮颜色"), Category("ButtonSkin")]
        public SolidColorBrush SystemButtonForeground
        {
            get { return (SolidColorBrush)GetValue(SystemButtonForegroundProperty); }
            set { SetValue(SystemButtonForegroundProperty, value); }
        }
        public static readonly DependencyProperty SystemButtonForegroundProperty =
            DependencyProperty.Register("SystemButtonForeground", typeof(SolidColorBrush), typeof(HTSystemButton), new PropertyMetadata(new SolidColorBrush(Color.FromArgb(255, 255, 255, 255))));



        [Description("窗体系统按钮鼠标悬按钮颜色"), Category("ButtonSkin")]
        public SolidColorBrush SystemButtonHoverForeground
        {
            get { return (SolidColorBrush)GetValue(SystemButtonHoverForegroundProperty); }
            set { SetValue(SystemButtonHoverForegroundProperty, value); }
        }
        public static readonly DependencyProperty SystemButtonHoverForegroundProperty =
            DependencyProperty.Register("SystemButtonHoverForeground", typeof(SolidColorBrush), typeof(HTSystemButton), new PropertyMetadata(new SolidColorBrush(Color.FromArgb(255, 255, 255, 255))));


        /// <summary>
        /// 图标
        /// </summary>
        [Description("图标"), Category("ButtonSkin")]
        public Geometry Icon
        {
            get { return (Geometry)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }
        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register("Icon", typeof(Geometry), typeof(HTSystemButton), new PropertyMetadata(null));

        /// <summary>
        /// 图标宽度
        /// </summary>
        public double IconWidth
        {
            get { return (double)GetValue(IconWidthProperty); }
            set { SetValue(IconWidthProperty, value); }
        }
        public static readonly DependencyProperty IconWidthProperty =
            DependencyProperty.Register("IconWidth", typeof(double), typeof(HTSystemButton), new PropertyMetadata(15.0));

        /// <summary>
        /// 图标高度
        /// </summary>
        public double IconHeight
        {
            get { return (double)GetValue(IconHeightProperty); }
            set { SetValue(IconHeightProperty, value); }
        }
        public static readonly DependencyProperty IconHeightProperty =
            DependencyProperty.Register("IconHeight", typeof(double), typeof(HTSystemButton), new PropertyMetadata(15.0));



    }
}
