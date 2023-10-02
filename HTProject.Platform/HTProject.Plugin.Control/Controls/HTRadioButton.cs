using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace HTProject.Plugin.Control.Controls
{
    public class HTIconRadioButton : RadioButton
    {
        static HTIconRadioButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(HTIconRadioButton), new FrameworkPropertyMetadata(typeof(HTIconRadioButton)));
        }

        /// <summary>
        /// 图标
        /// </summary>
        [Description("图标"), Category("Skin")]
        public Geometry Icon
        {
            get { return (Geometry)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }
        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register("Icon", typeof(Geometry), typeof(HTIconRadioButton), new PropertyMetadata(null));


        /// <summary>
        /// 图标宽度
        /// </summary>
        public double IconWidth
        {
            get { return (double)GetValue(IconWidthProperty); }
            set { SetValue(IconWidthProperty, value); }
        }
        public static readonly DependencyProperty IconWidthProperty =
            DependencyProperty.Register("IconWidth", typeof(double), typeof(HTIconRadioButton), new PropertyMetadata(12.0));


        /// <summary>
        /// 图标高度
        /// </summary>
        public double IconHeight
        {
            get { return (double)GetValue(IconHeightProperty); }
            set { SetValue(IconHeightProperty, value); }
        }
        public static readonly DependencyProperty IconHeightProperty =
            DependencyProperty.Register("IconHeight", typeof(double), typeof(HTIconRadioButton), new PropertyMetadata(12.0));

    }

    public class HTImageRadioButton : RadioButton
    {
        static HTImageRadioButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(HTImageRadioButton), new FrameworkPropertyMetadata(typeof(HTImageRadioButton)));
        }

        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register("CornerRadius", typeof(CornerRadius), typeof(HTImageRadioButton), new PropertyMetadata(null));

        public ImageSource ImageRadioButton_Icon
        {
            get { return (ImageSource)GetValue(ImageRadioButton_IconProperty); }
            set { SetValue(ImageRadioButton_IconProperty, value); }
        }

        public static readonly DependencyProperty ImageRadioButton_IconProperty =
            DependencyProperty.Register("ImageRadioButton_Icon", typeof(ImageSource), typeof(HTImageRadioButton), new PropertyMetadata(null));

        public ImageSource ImageRadioButton_MouseOverIcon
        {
            get { return (ImageSource)GetValue(ImageRadioButton_MouseOverIconProperty); }
            set { SetValue(ImageRadioButton_MouseOverIconProperty, value); }
        }

        public static readonly DependencyProperty ImageRadioButton_MouseOverIconProperty =
            DependencyProperty.Register("ImageRadioButton_MouseOverIcon", typeof(ImageSource), typeof(HTImageRadioButton), new PropertyMetadata(null));

        public ImageSource ImageRadioButton_MousePressedIcon
        {
            get { return (ImageSource)GetValue(ImageRadioButton_MousePressedIconProperty); }
            set { SetValue(ImageRadioButton_MousePressedIconProperty, value); }
        }

        public static readonly DependencyProperty ImageRadioButton_MousePressedIconProperty =
            DependencyProperty.Register("ImageRadioButton_MousePressedIcon", typeof(ImageSource), typeof(HTImageRadioButton), new PropertyMetadata(null));

        public double ImageWidth
        {
            get { return (double)GetValue(ImageWidthProperty); }
            set { SetValue(ImageWidthProperty, value); }
        }

        public static readonly DependencyProperty ImageWidthProperty =
            DependencyProperty.Register("ImageWidth", typeof(double), typeof(HTImageRadioButton), new PropertyMetadata(15.0));

        public double ImageHeight
        {
            get { return (double)GetValue(ImageHeightProperty); }
            set { SetValue(ImageHeightProperty, value); }
        }

        public static readonly DependencyProperty ImageHeightProperty =
            DependencyProperty.Register("ImageHeight", typeof(double), typeof(HTImageRadioButton), new PropertyMetadata(15.0));

    }

    public class HTCustomRadioButton : RadioButton
    {
        static HTCustomRadioButton()
        {
            FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(HTCustomRadioButton), new FrameworkPropertyMetadata(typeof(HTCustomRadioButton)));
        }

        /// <summary>
        /// 单选项文本属性
        /// </summary>
        public string OptionTxt
        {
            get
            {
                return (string)GetValue(OptionTxtProperty);
            }
            set
            {
                SetValue(OptionTxtProperty, value);
            }
        }

        /// <summary>
        /// 单选项文本属性
        /// </summary>
        public static readonly DependencyProperty OptionTxtProperty = DependencyProperty.Register("OptionTxt", typeof(string), typeof(HTCustomRadioButton), new PropertyMetadata(null));

        /// <summary>
        /// 单选项提示信息属性
        /// </summary>
        public string TxtToolTip
        {
            get
            {
                return (string)GetValue(TxtToolTipProperty);
            }
            set
            {
                SetValue(TxtToolTipProperty, value);
            }
        }

        /// <summary>
        /// 单选项提示信息属性
        /// </summary>
        public static readonly DependencyProperty TxtToolTipProperty = DependencyProperty.Register("TxtToolTip", typeof(string), typeof(HTCustomRadioButton), new PropertyMetadata(null));
    }
}
