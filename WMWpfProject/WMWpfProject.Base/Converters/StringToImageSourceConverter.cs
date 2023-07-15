using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace WMWpfProject.Base.Converters
{
    /// <summary>
    /// String 转换 为 ImageSource
    /// </summary>
    public class StringToImageSourceConverter : IValueConverter
    {
        /// <summary>
        /// 转换函数
        /// </summary>
        /// <param name="parameter">图片地址</param>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var imagePath = value as string;
            var bitmapImageSource = new BitmapImage();
            if (string.IsNullOrWhiteSpace(imagePath))
            {
                return bitmapImageSource;
            }

            bitmapImageSource = new BitmapImage(new Uri(imagePath));
            return bitmapImageSource;
        }


        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value != null && value.Equals(true) ? parameter : Binding.DoNothing;
        }
    }
}

