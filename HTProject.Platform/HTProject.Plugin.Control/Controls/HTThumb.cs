﻿using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Media;

namespace HTProject.Plugin.Control.Controls
{
    public class HTThumb : Thumb
    {
        #region 滑块默认颜色
        public SolidColorBrush ThemeColor
        {
            get { return (SolidColorBrush)GetValue(ThemeColorProperty); }
            set { SetValue(ThemeColorProperty, value); }
        }
        /// <summary>
        /// 滑块默认颜色
        /// </summary>
        public static readonly DependencyProperty ThemeColorProperty =
            DependencyProperty.Register("ThemeColor", typeof(SolidColorBrush), typeof(HTThumb), new PropertyMetadata(new SolidColorBrush(Color.FromArgb(255, 200, 200, 200))));
        #endregion

        #region 滑块悬浮颜色
        public SolidColorBrush ThemeColorMouseOver
        {
            get { return (SolidColorBrush)GetValue(ThemeColorMouseOverProperty); }
            set { SetValue(ThemeColorMouseOverProperty, value); }
        }
        /// <summary>
        /// 滑块悬浮颜色
        /// </summary>
        public static readonly DependencyProperty ThemeColorMouseOverProperty =
            DependencyProperty.Register("ThemeColorMouseOver", typeof(SolidColorBrush), typeof(HTThumb), new PropertyMetadata(new SolidColorBrush(Color.FromArgb(255, 180, 180, 180))));
        #endregion

        #region 滑块悬浮按下颜色
        public SolidColorBrush ThemeColorPressed
        {
            get { return (SolidColorBrush)GetValue(ThemeColorPressedProperty); }
            set { SetValue(ThemeColorPressedProperty, value); }
        }
        /// <summary>
        /// 滑块悬浮按下颜色
        /// </summary>
        public static readonly DependencyProperty ThemeColorPressedProperty =
            DependencyProperty.Register("ThemeColorPressed", typeof(SolidColorBrush), typeof(HTThumb), new PropertyMetadata(new SolidColorBrush(Color.FromArgb(255, 190, 190, 190))));
        #endregion

        #region 圆角值X
        /// <summary>
        /// 圆角值X
        /// </summary>
        public double RadiusX
        {
            get { return (double)GetValue(RadiusXProperty); }
            set { SetValue(RadiusXProperty, value); }
        }
        public static readonly DependencyProperty RadiusXProperty =
            DependencyProperty.Register("RadiusX", typeof(double), typeof(HTThumb), new PropertyMetadata(2.0));
        #endregion

        #region 圆角值Y
        /// <summary>
        /// 圆角值Y
        /// </summary>
        public double RadiusY
        {
            get { return (double)GetValue(RadiusYProperty); }
            set { SetValue(RadiusYProperty, value); }
        }
        public static readonly DependencyProperty RadiusYProperty =
            DependencyProperty.Register("RadiusY", typeof(double), typeof(HTThumb), new PropertyMetadata(2.0));
        #endregion
    }
}
