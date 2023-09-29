using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace HTProject.Plugin.Control.Controls
{
    public class HTCustomCheckBox : CheckBox
    {
        static HTCustomCheckBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(HTCustomCheckBox), new FrameworkPropertyMetadata(typeof(HTCustomCheckBox)));
        }

        /// <summary>
        /// 复选项提示信息属性
        /// </summary>
        public string TxtToolTip
        {
            get { return (string)GetValue(TxtToolTipProperty); }
            set { SetValue(TxtToolTipProperty, value); }
        }

        /// <summary>
        /// 复选项提示信息属性
        /// </summary>
        public static readonly DependencyProperty TxtToolTipProperty
            = DependencyProperty.Register("TxtToolTip", typeof(string), typeof(HTCustomCheckBox), new PropertyMetadata(string.Empty));
    }

    public class HTCustomBulletCheckBox : CheckBox
    {
        static HTCustomBulletCheckBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(HTCustomBulletCheckBox), new FrameworkPropertyMetadata(typeof(HTCustomBulletCheckBox)));
        }

        /// <summary>
        /// 复选项提示信息属性
        /// </summary>
        public string TxtToolTip
        {
            get { return (string)GetValue(TxtToolTipProperty); }
            set { SetValue(TxtToolTipProperty, value); }
        }

        /// <summary>
        /// 复选项提示信息属性
        /// </summary>
        public static readonly DependencyProperty TxtToolTipProperty
            = DependencyProperty.Register("TxtToolTip", typeof(string), typeof(HTCustomBulletCheckBox), new PropertyMetadata(string.Empty));

        /// <summary>
        /// 选中时复选项信息属性
        /// </summary>
        public string CheckedTxt
        {
            get { return (string)GetValue(CheckedTxtProperty); }
            set { SetValue(CheckedTxtProperty, value); }
        }

        /// <summary>
        /// 选中时复选项信息属性
        /// </summary>
        public static readonly DependencyProperty CheckedTxtProperty =
            DependencyProperty.Register("CheckedTxt", typeof(string), typeof(HTCustomBulletCheckBox), new PropertyMetadata("OFF"));

        /// <summary>
        /// 未选中时复选项信息属性
        /// </summary>
        public string UncheckedTxt
        {
            get { return (string)GetValue(UncheckedTxtProperty); }
            set { SetValue(UncheckedTxtProperty, value); }
        }

        /// <summary>
        /// 未选中时复选项信息属性
        /// </summary>
        public static readonly DependencyProperty UncheckedTxtProperty =
            DependencyProperty.Register("UncheckedTxt", typeof(string), typeof(HTCustomBulletCheckBox), new PropertyMetadata("ON"));
    }
}
