using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;
using System.Globalization;

namespace HTProject.Plugin.Base.Converters
{
    public class IndentConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double indent = 31.0;
            double offset = 31.0;
            UIElement uIElement = value as TreeViewItem;
            while (uIElement.GetType() != typeof(TreeView))
            {
                uIElement = (UIElement)VisualTreeHelper.GetParent(uIElement);
                bool flag = uIElement.GetType() == typeof(TreeViewItem);
                if (flag)
                {
                    offset += indent;
                }
            }
            object margin = new Thickness(offset, 0.0, 0.0, 0.0);
            return margin;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
