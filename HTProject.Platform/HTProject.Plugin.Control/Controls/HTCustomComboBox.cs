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
    public class HTCustomComboBox : ComboBox
    {
        static HTCustomComboBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(HTCustomComboBox), new FrameworkPropertyMetadata(typeof(HTCustomComboBox)));
        }

        #region 下拉菜单一般属性
        /// <summary>
        /// 下拉菜单圆角属性
        /// </summary>
        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        /// <summary>
        /// 下拉菜单圆角属性
        /// </summary>
        public static readonly DependencyProperty CornerRadiusProperty
            = DependencyProperty.Register("CornerRadius", typeof(CornerRadius), typeof(HTCustomComboBox), new PropertyMetadata(new CornerRadius(0)));


        /// <summary>
        /// 下拉菜单提示信息属性
        /// </summary>
        public string TxtToolTip
        {
            get { return (string)GetValue(TxtToolTipProperty); }
            set { SetValue(TxtToolTipProperty, value); }
        }

        /// <summary>
        /// 下拉菜单提示信息属性
        /// </summary>
        public static readonly DependencyProperty TxtToolTipProperty
            = DependencyProperty.Register("TxtToolTip", typeof(string), typeof(HTCustomComboBox), new PropertyMetadata(string.Empty));
        #endregion

        #region 下拉菜单属性
        /// <summary>
        /// 下拉菜单背景色属性
        /// </summary>
        public Brush ComboMenuBackground
        {
            get { return (Brush)GetValue(ComboMenuBackgroundProperty); }
            set { SetValue(ComboMenuBackgroundProperty, value); }
        }

        /// <summary>
        /// 下拉菜单背景色属性
        /// </summary>
        public static readonly DependencyProperty ComboMenuBackgroundProperty =
            DependencyProperty.Register("ComboMenuBackground", typeof(Brush), typeof(HTCustomComboBox), new PropertyMetadata());


        /// <summary>
        /// 下拉菜单边框刷属性
        /// </summary>
        public Brush ComboMenuBorderBrush
        {
            get { return (Brush)GetValue(ComboMenuBorderBrushProperty); }
            set { SetValue(ComboMenuBorderBrushProperty, value); }
        }

        /// <summary>
        /// 下拉菜单边框刷属性
        /// </summary>
        public static readonly DependencyProperty ComboMenuBorderBrushProperty =
            DependencyProperty.Register("ComboMenuBorderBrush", typeof(Brush), typeof(HTCustomComboBox), new PropertyMetadata());
        #endregion

        #region 鼠标禁用时下拉菜单属性
        /// <summary>
        /// 鼠标禁用时下拉菜单背景色属性
        /// </summary>
        public Brush MouseDisableComboBackground
        {
            get { return (Brush)GetValue(MouseDisableComboBackgroundProperty); }
            set { SetValue(MouseDisableComboBackgroundProperty, value); }
        }

        /// <summary>
        /// 鼠标禁用时下拉菜单背景色属性
        /// </summary>
        public static readonly DependencyProperty MouseDisableComboBackgroundProperty =
            DependencyProperty.Register("MouseDisableComboBackground", typeof(Brush), typeof(HTCustomComboBox), new PropertyMetadata());



        /// <summary>
        /// 鼠标禁用时下拉菜单边框刷属性
        /// </summary>
        public Brush MouseDisableComboBorderBrush
        {
            get { return (Brush)GetValue(MouseDisableComboBorderBrushProperty); }
            set { SetValue(MouseDisableComboBorderBrushProperty, value); }
        }

        /// <summary>
        /// 鼠标禁用时下拉菜单边框刷属性
        /// </summary>
        public static readonly DependencyProperty MouseDisableComboBorderBrushProperty =
            DependencyProperty.Register("MouseDisableComboBorderBrush", typeof(Brush), typeof(HTCustomComboBox), new PropertyMetadata());
        #endregion

        #region 鼠标悬浮时下拉菜单属性
        /// <summary>
        /// 鼠标悬浮时下拉菜单背景色属性
        /// </summary>
        public Brush MouseOverComboBackground
        {
            get { return (Brush)GetValue(MouseOverComboBackgroundProperty); }
            set { SetValue(MouseOverComboBackgroundProperty, value); }
        }

        /// <summary>
        /// 鼠标悬浮时下拉菜单背景色属性
        /// </summary>
        public static readonly DependencyProperty MouseOverComboBackgroundProperty =
            DependencyProperty.Register("MouseOverComboBackground", typeof(Brush), typeof(HTCustomComboBox), new PropertyMetadata());



        /// <summary>
        /// 鼠标悬浮时下拉菜单边框刷属性
        /// </summary>
        public Brush MouseOverComboBorderBrush
        {
            get { return (Brush)GetValue(MouseOverComboBorderBrushProperty); }
            set { SetValue(MouseOverComboBorderBrushProperty, value); }
        }

        /// <summary>
        /// 鼠标悬浮时下拉菜单边框刷属性
        /// </summary>
        public static readonly DependencyProperty MouseOverComboBorderBrushProperty =
            DependencyProperty.Register("MouseOverComboBorderBrush", typeof(Brush), typeof(HTCustomComboBox), new PropertyMetadata());
        #endregion

        #region 鼠标点击时下拉菜单属性
        /// <summary>
        /// 鼠标点击时下拉菜单背景色属性
        /// </summary>
        public Brush MousePressedComboBackground
        {
            get { return (Brush)GetValue(MousePressedComboBackgroundProperty); }
            set { SetValue(MousePressedComboBackgroundProperty, value); }
        }

        /// <summary>
        /// 鼠标点击时下拉菜单背景色属性
        /// </summary>
        public static readonly DependencyProperty MousePressedComboBackgroundProperty =
            DependencyProperty.Register("MousePressedComboBackground", typeof(Brush), typeof(HTCustomComboBox), new PropertyMetadata());



        /// <summary>
        /// 鼠标点击时下拉菜单边框刷属性
        /// </summary>
        public Brush MousePressedComboBorderBrush
        {
            get { return (Brush)GetValue(MousePressedComboBorderBrushProperty); }
            set { SetValue(MousePressedComboBorderBrushProperty, value); }
        }

        /// <summary>
        /// 鼠标点击时下拉菜单边框刷属性
        /// </summary>
        public static readonly DependencyProperty MousePressedComboBorderBrushProperty =
            DependencyProperty.Register("MousePressedComboBorderBrush", typeof(Brush), typeof(HTCustomComboBox), new PropertyMetadata());
        #endregion
    }
}
