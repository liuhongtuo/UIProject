using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace WMWpfProject.Control.Controls
{
    public class HTRadioButton : RadioButton
    {
        public SolidColorBrush IconColor
        {
            get { return (SolidColorBrush)GetValue(IconColorProperty); }
            set { SetValue(IconColorProperty, value); }
        }
        public static readonly DependencyProperty IconColorProperty =
            DependencyProperty.Register("IconColor", typeof(SolidColorBrush), typeof(HTRadioButton), new PropertyMetadata(new SolidColorBrush(Color.FromArgb(255, 255, 255, 255))));
    }

    public class HTIconRadioButton : RadioButton
    {

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
        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }
        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register("CornerRadius", typeof(CornerRadius), typeof(HTImageRadioButton), new PropertyMetadata(null));

        public ImageSource ImageSource
        {
            get
            {
                return (ImageSource)GetValue(ImageSourceProperty);
            }
            set
            {
                SetValue(ImageSourceProperty, value);
            }
        }

        public static readonly DependencyProperty ImageSourceProperty = DependencyProperty.Register("ImageSource", typeof(ImageSource), typeof(HTImageRadioButton), new PropertyMetadata(null));

        public string ImageRadioButton_Icon
        {
            get { return (string)GetValue(ImageRadioButton_IconProperty); }
            set { SetValue(ImageRadioButton_IconProperty, value); }
        }

        public static readonly DependencyProperty ImageRadioButton_IconProperty =
            DependencyProperty.Register("ImageRadioButton_Icon", typeof(string), typeof(HTImageRadioButton), new PropertyMetadata(string.Empty));

        public string ImageRadioButton_MouseOverIcon
        {
            get { return (string)GetValue(ImageRadioButton_MouseOverIconProperty); }
            set { SetValue(ImageRadioButton_MouseOverIconProperty, value); }
        }

        public static readonly DependencyProperty ImageRadioButton_MouseOverIconProperty =
            DependencyProperty.Register("ImageRadioButton_MouseOverIcon", typeof(string), typeof(HTImageRadioButton), new PropertyMetadata(string.Empty));

        public string ImageRadioButton_MousePressedIcon
        {
            get { return (string)GetValue(ImageRadioButton_MousePressedIconProperty); }
            set { SetValue(ImageRadioButton_MousePressedIconProperty, value); }
        }

        public static readonly DependencyProperty ImageRadioButton_MousePressedIconProperty =
            DependencyProperty.Register("ImageRadioButton_MousePressedIcon", typeof(string), typeof(HTImageRadioButton), new PropertyMetadata(string.Empty));

        private static void OnImgSourceChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            HTImageRadioButton radioButton = d as HTImageRadioButton;
            string newImgPath = e.NewValue as string;
            if (radioButton == null) return;
            var bitmapImageSource = new BitmapImage();
            if (string.IsNullOrWhiteSpace(newImgPath))
            {
                radioButton.ImageSource = bitmapImageSource;
                return;
            }

            bitmapImageSource = new BitmapImage(new Uri(newImgPath));
            radioButton.ImageSource = bitmapImageSource;
            //using (var ms = new MemoryStream(File.ReadAllBytes(newImgPath)))
            //{
            //    bitmapImageSource.BeginInit();
            //    bitmapImageSource.CacheOption = BitmapCacheOption.OnLoad;
            //    bitmapImageSource.StreamSource = ms;
            //    bitmapImageSource.EndInit();
            //    bitmapImageSource.Freeze();
            //}
        }

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
}
