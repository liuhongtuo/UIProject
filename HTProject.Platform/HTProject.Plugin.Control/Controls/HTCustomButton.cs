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
    /// 按钮类型
    /// </summary>
    public enum ButtonTypeEnum
    {
        /// <summary>
        /// 纯文本按钮
        /// </summary>
        OnlyText = 0,

        /// <summary>
        /// 纯图标按钮
        /// </summary>
        OnlyIcon = 1,

        /// <summary>
        /// 图标与字符垂直排列
        /// </summary>
        VerticalIconAndText = 2,

        /// <summary>
        /// 图标与字符水平排列
        /// </summary>
        HorizontalIconAndText = 3
    }

    public class HTCustomButton : Button
    {
        static HTCustomButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(HTCustomButton), new FrameworkPropertyMetadata(typeof(HTCustomButton)));
        }

        #region 注册按钮一般属性

        /// <summary>
        /// 注册按钮类型属性
        /// </summary>
        public ButtonTypeEnum ButtonType
        {
            get { return (ButtonTypeEnum)GetValue(ButtonTypeProperty); }
            set { SetValue(ButtonTypeProperty, value); }
        }

        /// <summary>
        /// 注册按钮类型属性
        /// </summary>
        public static readonly DependencyProperty ButtonTypeProperty
            = DependencyProperty.Register("ButtonType", typeof(ButtonTypeEnum), typeof(HTCustomButton), new PropertyMetadata(ButtonTypeEnum.OnlyText));


        /// <summary>
        /// 注册按钮圆角属性
        /// </summary>
        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        /// <summary>
        /// 注册按钮圆角属性
        /// </summary>
        public static readonly DependencyProperty CornerRadiusProperty
            = DependencyProperty.Register("CornerRadius", typeof(CornerRadius), typeof(HTCustomButton), new PropertyMetadata(new CornerRadius(0)));


        /// <summary>
        /// 注册按钮提示信息属性
        /// </summary>
        public string TxtToolTip
        {
            get { return (string)GetValue(TxtToolTipProperty); }
            set { SetValue(TxtToolTipProperty, value); }
        }

        /// <summary>
        /// 注册按钮提示信息属性
        /// </summary>
        public static readonly DependencyProperty TxtToolTipProperty
            = DependencyProperty.Register("TxtToolTip", typeof(string), typeof(HTCustomButton), new PropertyMetadata(string.Empty));
        #endregion

        #region 注册鼠标未触发时图标属性
        /// <summary>
        /// 注册鼠标未触发时图标属性
        /// </summary>
        public ImageSource Icon
        {
            get { return (ImageSource)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }

        /// <summary>
        /// 注册鼠标未触发时图标属性
        /// </summary>
        public static readonly DependencyProperty IconProperty
            = DependencyProperty.Register("Icon", typeof(ImageSource), typeof(HTCustomButton), new PropertyMetadata(null));
        #endregion

        #region 注册鼠标禁用时属性

        /// <summary>
        /// 注册鼠标禁用时按钮背景色属性
        /// </summary>
        public Brush MouseDisableBackground
        {
            get { return (Brush)GetValue(MouseDisableBackgroundProperty); }
            set { SetValue(MouseDisableBackgroundProperty, value); }
        }

        /// <summary>
        /// 注册鼠标禁用时按钮背景色属性
        /// </summary>
        public static readonly DependencyProperty MouseDisableBackgroundProperty
            = DependencyProperty.Register("MouseDisableBackground", typeof(Brush), typeof(HTCustomButton), new PropertyMetadata(Brushes.Gray));

        /// <summary>
        /// 注册鼠标禁用时按钮边框刷属性
        /// </summary>
        public Brush MouseDisableBorderBrush
        {
            get { return (Brush)GetValue(MouseDisableBorderBrushProperty); }
            set { SetValue(MouseDisableBorderBrushProperty, value); }
        }

        /// <summary>
        /// 注册鼠标禁用时按钮边框刷属性
        /// </summary>
        public static readonly DependencyProperty MouseDisableBorderBrushProperty
            = DependencyProperty.Register("MouseDisableBorderBrush", typeof(Brush), typeof(HTCustomButton), new PropertyMetadata(Brushes.Gray));

        /// <summary>
        /// 注册鼠标禁用时按钮文本颜色属性
        /// </summary>
        public Brush MouseDisableForeground
        {
            get { return (Brush)GetValue(MouseDisableForegroundProperty); }
            set { SetValue(MouseDisableForegroundProperty, value); }
        }

        /// <summary>
        /// 注册鼠标禁用时按钮文本颜色属性
        /// </summary>
        public static readonly DependencyProperty MouseDisableForegroundProperty
            = DependencyProperty.Register("MouseDisableForeground", typeof(Brush), typeof(HTCustomButton), new PropertyMetadata(Brushes.Black));

        /// <summary>
        /// 注册鼠标禁用时图标属性
        /// </summary>
        public ImageSource MouseDisableIcon
        {
            get { return (ImageSource)GetValue(MouseDisableIconProperty); }
            set { SetValue(MouseDisableIconProperty, value); }
        }

        /// <summary>
        /// 注册鼠标禁用时图标属性
        /// </summary>
        public static readonly DependencyProperty MouseDisableIconProperty
            = DependencyProperty.Register("MouseDisableIcon", typeof(ImageSource), typeof(HTCustomButton), new PropertyMetadata(null));
        #endregion

        #region 注册鼠标悬浮时属性

        /// <summary>
        /// 注册鼠标悬浮时按钮背景色属性
        /// </summary>
        public Brush MouseOverBackground
        {
            get { return (Brush)GetValue(MouseOverBackgroundProperty); }
            set { SetValue(MouseOverBackgroundProperty, value); }
        }

        /// <summary>
        /// 注册鼠标悬浮时按钮背景色属性
        /// </summary>
        public static readonly DependencyProperty MouseOverBackgroundProperty
            = DependencyProperty.Register("MouseOverBackground", typeof(Brush), typeof(HTCustomButton), new PropertyMetadata(Brushes.Gray));

        /// <summary>
        /// 注册鼠标悬浮时按钮边框刷属性
        /// </summary>
        public Brush MouseOverBorderBrush
        {
            get { return (Brush)GetValue(MouseOverBorderBrushProperty); }
            set { SetValue(MouseOverBorderBrushProperty, value); }
        }

        /// <summary>
        /// 注册鼠标悬浮时按钮边框刷属性
        /// </summary>
        public static readonly DependencyProperty MouseOverBorderBrushProperty
            = DependencyProperty.Register("MouseOverBorderBrush", typeof(Brush), typeof(HTCustomButton), new PropertyMetadata(Brushes.Gray));

        /// <summary>
        /// 注册鼠标悬浮时按钮文本颜色属性
        /// </summary>
        public Brush MouseOverForeground
        {
            get { return (Brush)GetValue(MouseOverForegroundProperty); }
            set { SetValue(MouseOverForegroundProperty, value); }
        }

        /// <summary>
        /// 注册鼠标悬浮时按钮文本颜色属性
        /// </summary>
        public static readonly DependencyProperty MouseOverForegroundProperty
            = DependencyProperty.Register("MouseOverForeground", typeof(Brush), typeof(HTCustomButton), new PropertyMetadata(Brushes.Black));

        /// <summary>
        /// 注册鼠标悬浮时图标属性
        /// </summary>
        public ImageSource MouseOverIcon
        {
            get { return (ImageSource)GetValue(MouseOverIconProperty); }
            set { SetValue(MouseOverIconProperty, value); }
        }

        /// <summary>
        /// 注册鼠标悬浮时图标属性
        /// </summary>
        public static readonly DependencyProperty MouseOverIconProperty
            = DependencyProperty.Register("MouseOverIcon", typeof(ImageSource), typeof(HTCustomButton), new PropertyMetadata(null));
        #endregion

        #region 注册鼠标点击时属性

        /// <summary>
        /// 注册鼠标点击时按钮背景色属性
        /// </summary>
        public Brush MousePressedBackground
        {
            get { return (Brush)GetValue(MousePressedBackgroundProperty); }
            set { SetValue(MousePressedBackgroundProperty, value); }
        }

        /// <summary>
        /// 注册鼠标点击时按钮背景色属性
        /// </summary>
        public static readonly DependencyProperty MousePressedBackgroundProperty
            = DependencyProperty.Register("MousePressedBackground", typeof(Brush), typeof(HTCustomButton), new PropertyMetadata(Brushes.CornflowerBlue));

        /// <summary>
        /// 注册鼠标点击时按钮边框刷属性
        /// </summary>
        public Brush MousePressedBorderBrush
        {
            get { return (Brush)GetValue(MousePressedBorderBrushProperty); }
            set { SetValue(MousePressedBorderBrushProperty, value); }
        }

        /// <summary>
        /// 注册鼠标点击时按钮边框刷属性
        /// </summary>
        public static readonly DependencyProperty MousePressedBorderBrushProperty
            = DependencyProperty.Register("MousePressedBorderBrush", typeof(Brush), typeof(HTCustomButton), new PropertyMetadata(Brushes.Gray));

        /// <summary>
        /// 注册鼠标点击时按钮文本颜色属性
        /// </summary>
        public Brush MousePressedForeground
        {
            get { return (Brush)GetValue(MousePressedForegroundProperty); }
            set { SetValue(MousePressedForegroundProperty, value); }
        }

        /// <summary>
        /// 注册鼠标点击时按钮文本颜色属性
        /// </summary>
        public static readonly DependencyProperty MousePressedForegroundProperty
            = DependencyProperty.Register("MousePressedForeground", typeof(Brush), typeof(HTCustomButton), new PropertyMetadata(Brushes.Black));

        /// <summary>
        /// 注册鼠标点击时图标属性
        /// </summary>
        public ImageSource MousePressedIcon
        {
            get { return (ImageSource)GetValue(MousePressedIconProperty); }
            set { SetValue(MousePressedIconProperty, value); }
        }

        /// <summary>
        /// 注册鼠标点击时图标属性
        /// </summary>
        public static readonly DependencyProperty MousePressedIconProperty
            = DependencyProperty.Register("MousePressedIcon", typeof(ImageSource), typeof(HTCustomButton), new PropertyMetadata(null));
        #endregion

        #region 注册按钮图标属性

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
            DependencyProperty.Register("IconWidth", typeof(double), typeof(HTCustomButton), new PropertyMetadata(80.0));



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
            DependencyProperty.Register("IconHeight", typeof(double), typeof(HTCustomButton), new PropertyMetadata(80.0));

        #endregion
    }

    public class HTCustomIconButton : Button
    {
        static HTCustomIconButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(HTCustomIconButton), new FrameworkPropertyMetadata(typeof(HTCustomIconButton)));
        }

        #region 注册按钮一般属性

        /// <summary>
        /// 注册按钮类型属性
        /// </summary>
        public ButtonTypeEnum ButtonType
        {
            get { return (ButtonTypeEnum)GetValue(ButtonTypeProperty); }
            set { SetValue(ButtonTypeProperty, value); }
        }

        /// <summary>
        /// 注册按钮类型属性
        /// </summary>
        public static readonly DependencyProperty ButtonTypeProperty
            = DependencyProperty.Register("ButtonType", typeof(ButtonTypeEnum), typeof(HTCustomIconButton), new PropertyMetadata(ButtonTypeEnum.OnlyIcon));


        /// <summary>
        /// 注册按钮提示信息属性
        /// </summary>
        public string TxtToolTip
        {
            get { return (string)GetValue(TxtToolTipProperty); }
            set { SetValue(TxtToolTipProperty, value); }
        }

        /// <summary>
        /// 注册按钮提示信息属性
        /// </summary>
        public static readonly DependencyProperty TxtToolTipProperty
            = DependencyProperty.Register("TxtToolTip", typeof(string), typeof(HTCustomIconButton), new PropertyMetadata(string.Empty));
        #endregion

        #region 注册鼠标未触发时图标属性
        /// <summary>
        /// 注册鼠标未触发时图标属性
        /// </summary>
        public ImageSource Icon
        {
            get { return (ImageSource)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }

        /// <summary>
        /// 注册鼠标未触发时图标属性
        /// </summary>
        public static readonly DependencyProperty IconProperty
            = DependencyProperty.Register("Icon", typeof(ImageSource), typeof(HTCustomIconButton), new PropertyMetadata(null));
        #endregion

        #region 注册鼠标禁用时属性

        /// <summary>
        /// 注册鼠标禁用时图标属性
        /// </summary>
        public ImageSource MouseDisableIcon
        {
            get { return (ImageSource)GetValue(MouseDisableIconProperty); }
            set { SetValue(MouseDisableIconProperty, value); }
        }

        /// <summary>
        /// 注册鼠标禁用时图标属性
        /// </summary>
        public static readonly DependencyProperty MouseDisableIconProperty
            = DependencyProperty.Register("MouseDisableIcon", typeof(ImageSource), typeof(HTCustomIconButton), new PropertyMetadata(null));
        #endregion

        #region 注册鼠标悬浮时属性

        
        /// <summary>
        /// 注册鼠标悬浮时图标属性
        /// </summary>
        public ImageSource MouseOverIcon
        {
            get { return (ImageSource)GetValue(MouseOverIconProperty); }
            set { SetValue(MouseOverIconProperty, value); }
        }

        /// <summary>
        /// 注册鼠标悬浮时图标属性
        /// </summary>
        public static readonly DependencyProperty MouseOverIconProperty
            = DependencyProperty.Register("MouseOverIcon", typeof(ImageSource), typeof(HTCustomIconButton), new PropertyMetadata(null));
        #endregion

        #region 注册鼠标点击时属性
      
        /// <summary>
        /// 注册鼠标点击时图标属性
        /// </summary>
        public ImageSource MousePressedIcon
        {
            get { return (ImageSource)GetValue(MousePressedIconProperty); }
            set { SetValue(MousePressedIconProperty, value); }
        }

        /// <summary>
        /// 注册鼠标点击时图标属性
        /// </summary>
        public static readonly DependencyProperty MousePressedIconProperty
            = DependencyProperty.Register("MousePressedIcon", typeof(ImageSource), typeof(HTCustomIconButton), new PropertyMetadata(null));
        #endregion

        #region 注册按钮图标属性

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
            DependencyProperty.Register("IconWidth", typeof(double), typeof(HTCustomIconButton), new PropertyMetadata(80.0));

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
            DependencyProperty.Register("IconHeight", typeof(double), typeof(HTCustomIconButton), new PropertyMetadata(80.0));

        #endregion
    }
}
