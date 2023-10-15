using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Globalization;

namespace HTProject.Plugin.Base.Converters
{
    public class VisibilityToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Visibility visibleVal = (Visibility)value;
            if (visibleVal == Visibility.Collapsed || visibleVal == Visibility.Hidden)
            {
                return Visibility.Collapsed;
            }
            return Visibility.Visible;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Visibility visibleVal = (Visibility)value;
            if (visibleVal == Visibility.Collapsed || visibleVal == Visibility.Hidden)
            {
                return Visibility.Collapsed;
            }
            return Visibility.Visible;
        }
    }

    public class BoolToVisibilityConverter : IValueConverter
    {
        /// <summary>
        /// bool 转为 visibility
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter">是否取反</param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool bVal = (bool)value;
            if (parameter != null && parameter.ToString() == "Reverse")
            {
                bVal = !bVal;
            }
            if (bVal) return Visibility.Visible;
            return Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Visibility val = (Visibility)value;
            var bVal = false;

            if (val == Visibility.Visible)
            {
                bVal = true;
            }
            else
            {
                bVal = false;
            }
            if (parameter != null && parameter.ToString() == "Reverse")
            {
                bVal = !bVal;
            }
            return bVal;
        }
    }

    public class NullToCollapsedConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
            {
                return Visibility.Collapsed;
            }
            else
            {
                return Visibility.Visible;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }

    public class StringToCollapsedConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (string.IsNullOrWhiteSpace(value.ToString()))
            {
                return Visibility.Collapsed;
            }
            else
            {
                return Visibility.Visible;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }

    public class EqualToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null && parameter != null)
            {
                if (value.ToString() == parameter.ToString())
                {
                    return Visibility.Visible;
                }
            }
            return Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null && value is Visibility)
            {
                if (value.Equals(Visibility.Visible))
                {
                    return parameter;
                }
            }
            return null;
        }
    }

    public class MultiBoolToVisibilityConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values == null || values.Count() < 2
                || values[0] == DependencyProperty.UnsetValue
                || values[1] == DependencyProperty.UnsetValue)
            {
                return Visibility.Collapsed;
            }

            bool isDirection1Visibility = System.Convert.ToBoolean(values[0]);
            bool isDirection2Visibility = System.Convert.ToBoolean(values[1]);

            if (isDirection1Visibility || isDirection2Visibility)
            {
                return Visibility.Visible;
            }
            return Visibility.Collapsed;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
