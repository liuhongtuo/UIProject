using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows;
using Prism.Commands;
using PropertyChanged;
using System.Windows.Controls;
using HTProject.Plugin.Control.Helper;

namespace HTProject.Plugin.Control.Controls
{
    /// <summary>
    /// 文本框图标位置类型
    /// </summary>
    public enum IconDirection
    {
        /// <summary>
        /// 图标位于文本框左侧
        /// </summary>
        Left = 0,

        /// <summary>
        /// 图标位于文本框右侧
        /// </summary>
        Right = 1,

        /// <summary>
        /// 无图标
        /// </summary>
        NoIcon = 2,
    }

    public class HTCustomTextBox : TextBox
    {
        static HTCustomTextBox()
        {
            FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(HTCustomTextBox), new FrameworkPropertyMetadata(typeof(HTCustomTextBox)));
        }

        public HTCustomTextBox()
        {
            //自定义RoutedUICommand事件，需要实现CanExecute和Executed事件
            CommandBinding iconClickBinding = new CommandBinding(IconClickCommand);
            iconClickBinding.CanExecute += IconClickBinding_CanExecute; ;
            iconClickBinding.Executed += IconClickBinding_Executed; ;

            this.CommandBindings.Add(iconClickBinding);
        }

        #region 文本框图标属性
        /// <summary>
        /// 文本框图标属性
        /// </summary>
        public ImageSource Icon
        {
            get
            {
                return (ImageSource)GetValue(IconProperty);
            }
            set
            {
                SetValue(IconProperty, value);
            }
        }

        /// <summary>
        /// 文本框图标属性
        /// </summary>
        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register("Icon", typeof(ImageSource), typeof(HTCustomTextBox), new PropertyMetadata(null));

        /// <summary>
        /// 文本框图标位置属性
        /// </summary>
        public IconDirection IconDirection
        {
            get
            {
                return (IconDirection)GetValue(IconDirectionProperty);
            }
            set
            {
                SetValue(IconDirectionProperty, value);
            }
        }

        /// <summary>
        /// 文本框图标位置属性
        /// </summary>
        public static readonly DependencyProperty IconDirectionProperty =
            DependencyProperty.Register("IconDirection", typeof(IconDirection), typeof(HTCustomTextBox), new PropertyMetadata(IconDirection.NoIcon));
        #endregion

        #region 文本框一般属性
        /// <summary>
        /// 文本框圆角属性
        /// </summary>
        public CornerRadius CornerRadius
        {
            get
            {
                return (CornerRadius)GetValue(CornerRadiusProperty);
            }
            set
            {
                SetValue(CornerRadiusProperty, value);
            }
        }

        /// <summary>
        /// 文本框圆角属性
        /// </summary>
        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register("CornerRadius", typeof(CornerRadius), typeof(HTCustomTextBox), new PropertyMetadata(new CornerRadius(0.0)));

        /// <summary>
        /// 文本框水印属性
        /// </summary>
        public string WaterMark
        {
            get
            {
                return (string)GetValue(WaterMarkProperty);
            }
            set
            {
                SetValue(WaterMarkProperty, value);
            }
        }

        /// <summary>
        /// 文本框水印属性
        /// </summary>
        public static readonly DependencyProperty WaterMarkProperty =
            DependencyProperty.Register("WaterMark", typeof(string), typeof(HTCustomTextBox), new PropertyMetadata(null));

        /// <summary>
        /// 文本框提示信息属性
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
        /// 文本框提示信息属性
        /// </summary>
        public static readonly DependencyProperty TxtToolTipProperty =
            DependencyProperty.Register("TxtToolTip", typeof(string), typeof(HTCustomTextBox), new PropertyMetadata(null));

        /// <summary>
        /// 文本框文本外边距属性
        /// </summary>
        public Thickness TxtMargin
        {
            get
            {
                return (Thickness)GetValue(TxtMarginProperty);
            }
            set
            {
                SetValue(TxtMarginProperty, value);
            }
        }

        /// <summary>
        /// 文本框文本外边距属性
        /// </summary>
        public static readonly DependencyProperty TxtMarginProperty =
            DependencyProperty.Register("TxtMargin", typeof(Thickness), typeof(HTCustomTextBox), new PropertyMetadata(null));
        #endregion

        #region 焦点时文本框属性
        /// <summary>
        /// 焦点时文本框边框刷属性
        /// </summary>
        public Brush MouseFocusBorderBrush
        {
            get
            {
                return (Brush)GetValue(MouseFocusBorderBrushProperty);
            }
            set
            {
                SetValue(MouseFocusBorderBrushProperty, value);
            }
        }

        /// <summary>
        /// 焦点时文本框边框刷属性
        /// </summary>
        public static readonly DependencyProperty MouseFocusBorderBrushProperty =
            DependencyProperty.Register("MouseFocusBorderBrush", typeof(Brush), typeof(HTCustomTextBox), new PropertyMetadata(null));
        #endregion

        #region 文本框禁用时属性
        /// <summary>
        /// 文本框禁用时文本颜色属性
        /// </summary>
        public Brush MouseDisableForeground
        {
            get
            {
                return (Brush)GetValue(MouseDisableForegroundProperty);
            }
            set
            {
                SetValue(MouseDisableForegroundProperty, value);
            }
        }

        /// <summary>
        /// 文本框禁用时文本颜色属性
        /// </summary>
        public static readonly DependencyProperty MouseDisableForegroundProperty =
            DependencyProperty.Register("MouseDisableForeground", typeof(Brush), typeof(HTCustomTextBox), new PropertyMetadata(null));

        /// <summary>
        /// 鼠标禁用时文本框边框刷属性
        /// </summary>
        public Brush MouseDisableBorderBrush
        {
            get
            {
                return (Brush)GetValue(MouseDisableBorderBrushProperty);
            }
            set
            {
                SetValue(MouseDisableBorderBrushProperty, value);
            }
        }

        /// <summary>
        /// 鼠标禁用时文本框边框刷属性
        /// </summary>
        public static readonly DependencyProperty MouseDisableBorderBrushProperty =
           DependencyProperty.Register("MouseDisableBorderBrush", typeof(Brush), typeof(HTCustomTextBox), new PropertyMetadata(null));

        /// <summary>
        /// 鼠标禁用时文本框背景色属性
        /// </summary>
        public Brush MouseDisableBackground
        {
            get
            {
                return (Brush)GetValue(MouseDisableBackgroundProperty);
            }
            set
            {
                SetValue(MouseDisableBackgroundProperty, value);
            }
        }

        /// <summary>
        /// 鼠标禁用时文本框背景色属性
        /// </summary>
        public static readonly DependencyProperty MouseDisableBackgroundProperty =
            DependencyProperty.Register("MouseDisableBackground", typeof(Brush), typeof(HTCustomTextBox), new PropertyMetadata(null));
        #endregion

        #region 只读时文本框属性
        /// <summary>
        /// 只读时文本框边框刷属性
        /// </summary>
        public Brush IsReadOnlyBorderBrush
        {
            get
            {
                return (Brush)GetValue(IsReadOnlyBorderBrushProperty);
            }
            set
            {
                SetValue(IsReadOnlyBorderBrushProperty, value);
            }
        }

        /// <summary>
        /// 只读时文本框边框刷属性
        /// </summary>
        public static readonly DependencyProperty IsReadOnlyBorderBrushProperty =
            DependencyProperty.Register("IsReadOnlyBorderBrush", typeof(Brush), typeof(HTCustomTextBox), new PropertyMetadata(null));

        /// <summary>
        /// 只读时文本框背景色属性
        /// </summary>
        public Brush IsReadOnlyBackground
        {
            get
            {
                return (Brush)GetValue(IsReadOnlyBackgroundProperty);
            }
            set
            {
                SetValue(IsReadOnlyBackgroundProperty, value);
            }
        }

        /// <summary>
        /// 只读时文本框背景色属性
        /// </summary>
        public static readonly DependencyProperty IsReadOnlyBackgroundProperty =
            DependencyProperty.Register("IsReadOnlyBackground", typeof(Brush), typeof(HTCustomTextBox), new PropertyMetadata(null));
        #endregion

        #region 文本框事件
        /// <summary>
        /// 文本框图标点击事件
        /// </summary>
        public static RoutedUICommand IconClickCommand = new RoutedUICommand("IconClickCommand", "IconClickCommand", typeof(RoutedUICommand));

        private void IconClickBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            this.Text = string.Empty;
        }

        private void IconClickBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }
        #endregion
    }

    [ImplementPropertyChanged]
    public class HTCustomNumticTextBox : HTCustomTextBox
    {
        static HTCustomNumticTextBox()
        {
            FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(HTCustomNumticTextBox), new FrameworkPropertyMetadata(typeof(HTCustomNumticTextBox)));
        }


        /// <summary>
        /// 是否是NumticTex,显示右侧上下按键
        /// </summary>
        public bool IsNumticText
        {
            get { return (bool)GetValue(IsNumticTextProperty); }
            set { SetValue(IsNumticTextProperty, value); }
        }

        public static readonly DependencyProperty IsNumticTextProperty =
           DependencyProperty.Register("IsNumticText", typeof(bool), typeof(HTCustomNumticTextBox), new PropertyMetadata(false, new PropertyChangedCallback((sender, arg) =>
           {

           }), new CoerceValueCallback((sender, value) =>
           {
               return value;
           })));


        public bool HasError { private set; get; } = false;

        [AlsoNotifyForAttribute("HasError")]
        public ToolTipType ToolTipType { set; get; }

        [AlsoNotifyForAttribute("HasError")]
        public Brush BorderDisplayBrush => HasError ? Brushes.Red : BorderBrush;

        internal void SetError(bool hasError, string errorMessage = "")
        {
            if (CustomToolTip != null)
            {
                if (hasError && CustomToolTip != null && !string.IsNullOrEmpty(errorMessage))
                {
                    this.TxtToolTip = errorMessage;
                    ToolTipType = ToolTipType.ErrorToolTip;
                    if (PART_ErrorBorder != null)
                    {
                        PART_ErrorBorder.BorderBrush = Brushes.DarkRed;
                    }
                    //SMEEToolTip.PlacementTarget = PART_ContentHost;
                    //SMEEToolTip.IsOpen = true;
                }
                else
                {
                    ResetToolTip();
                    ToolTipType = ToolTipType.NormalToolTip;
                    if (PART_ErrorBorder != null)
                    {
                        PART_ErrorBorder.BorderBrush = Brushes.Transparent;
                    }
                    //SMEEToolTip.IsOpen = false;
                }
            }
            this.Dispatcher.Invoke(() =>
            {
                HasError = hasError;
            });

            //ToolTipType = HasError ? BASE.OIGL.Controls.Model.ToolTipType.ErrorToolTip : BASE.OIGL.Controls.Model.ToolTipType.NormalToolTip;
            // BorderDisplayBrush = HasError? Brushes.Red: this.BorderBrush;
        }


        internal virtual string ResetToolTip()
        {
            return this.TxtToolTip;
        }


        public HTCustomToolTip CustomToolTip => PART_ContentHost?.ToolTip as HTCustomToolTip;

        public Border PART_ErrorBorder => this.Template?.FindName("PART_ErrorBorder", this) as Border;

        public ScrollViewer PART_ContentHost => this.Template?.FindName("PART_ContentHost", this) as ScrollViewer;
    }

    #region 数值自检控件

    /// <summary>
    /// 自带数值校验的Int类型TextBox
    /// </summary>
    [ImplementPropertyChanged]
    public class HTIntInputCustomNumticTextBox : HTCustomNumticTextBox
    {
        static HTIntInputCustomNumticTextBox()
        {
            TextProperty.OverrideMetadata(typeof(HTIntInputCustomNumticTextBox), new FrameworkPropertyMetadata(null, new PropertyChangedCallback((sender, arg) =>
            {
                var textbox = (HTIntInputCustomNumticTextBox)sender;
                textbox.IsNumticText = true;
                int v = 0;
                if (textbox.Text == null)
                {
                    textbox.Text = textbox.Value.ToString();
                }
                if (textbox.CheckSpell(out v))
                {
                    textbox.CheckValue(v);
                }
                textbox.AfterInputCommand?.Invoke(v);
            }), new CoerceValueCallback((sender, value) =>
            {
                var textbox = (HTIntInputCustomNumticTextBox)sender;
                return value;
            })));
        }

        public HTIntInputCustomNumticTextBox()
        {
            //this.IsNumticText = false;
        }

        public int Value
        {
            get { return (int)GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }

        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register("Value", typeof(int), typeof(HTIntInputCustomNumticTextBox), new PropertyMetadata(0, new PropertyChangedCallback((sender, arg) =>
            {
                var textbox = (HTIntInputCustomNumticTextBox)sender;
                textbox.CheckValue(textbox.Value);
            }), new CoerceValueCallback((sender, value) =>
            {
                var textbox = (HTIntInputCustomNumticTextBox)sender;
                textbox.Text = value.ToString();
                return value;
            })));


        public int? DefaultValue
        {
            get { return (int?)GetValue(DefaultValueProperty); }
            set { SetValue(DefaultValueProperty, value); }
        }

        public static readonly DependencyProperty DefaultValueProperty =
            DependencyProperty.Register("DefaultValue", typeof(int?), typeof(HTIntInputCustomNumticTextBox), new PropertyMetadata(null));

        public int Step
        {
            get { return (int)GetValue(StepProperty); }
            set { SetValue(StepProperty, value); }
        }

        public static readonly DependencyProperty StepProperty =
            DependencyProperty.Register("Step", typeof(int), typeof(HTIntInputCustomNumticTextBox), new PropertyMetadata(1));


        public ICommand ValueChangedCommand
        {
            get { return (ICommand)GetValue(ValueChangedCommandProperty); }
            set { SetValue(ValueChangedCommandProperty, value); }
        }

        public static readonly DependencyProperty ValueChangedCommandProperty =
            DependencyProperty.Register("ValueChangedCommand", typeof(ICommand), typeof(HTIntInputCustomNumticTextBox), new PropertyMetadata(null));

        public Action<int> AfterSelfCheckCommand
        {
            get { return (Action<int>)GetValue(AfterSelfCheckCommandProperty); }
            set { SetValue(AfterSelfCheckCommandProperty, value); }
        }

        public static readonly DependencyProperty AfterSelfCheckCommandProperty =
            DependencyProperty.Register("AfterSelfCheckCommand", typeof(Action<int>), typeof(HTIntInputCustomNumticTextBox), new PropertyMetadata(null));


        public Action<int> AfterInputCommand
        {
            get { return (Action<int>)GetValue(AfterInputCommandProperty); }
            set { SetValue(AfterInputCommandProperty, value); }
        }

        public static readonly DependencyProperty AfterInputCommandProperty =
            DependencyProperty.Register("AfterInputCommand", typeof(Action<int>), typeof(HTIntInputCustomNumticTextBox), new PropertyMetadata(null));


        #region Minimun && Maximun
        public int Maximum
        {
            get { return (int)GetValue(MaximumProperty); }
            set { SetValue(MaximumProperty, value); }
        }

        public static readonly DependencyProperty MaximumProperty =
            DependencyProperty.Register("Maximum", typeof(int), typeof(HTIntInputCustomNumticTextBox), new PropertyMetadata(int.MaxValue, new PropertyChangedCallback((sender, arg) =>
            {
                var textbox = (HTIntInputCustomNumticTextBox)sender;
                textbox.Value = (textbox.Value).Between(textbox.Maximum, textbox.Minimum);
                textbox.AfterSelfCheckCommand?.Invoke(textbox.Value);
                textbox.ValueChangedCommand?.Execute(null);
                textbox.ResetToolTip();
            }), new CoerceValueCallback((sender, value) =>
            {
                return value;
            })));


        public int Minimum
        {
            get { return (int)GetValue(MinimumProperty); }
            set { SetValue(MinimumProperty, value); }
        }

        public static readonly DependencyProperty MinimumProperty =
           DependencyProperty.Register("Minimum", typeof(int), typeof(HTIntInputCustomNumticTextBox), new PropertyMetadata(int.MinValue, new PropertyChangedCallback((sender, arg) =>
           {
               var textbox = (HTIntInputCustomNumticTextBox)sender;
               textbox.Value = (textbox.Value).Between(textbox.Maximum, textbox.Minimum);
               textbox.AfterSelfCheckCommand?.Invoke(textbox.Value);
               textbox.ValueChangedCommand?.Execute(null);
               textbox.ResetToolTip();
           }), new CoerceValueCallback((sender, value) =>
           {
               return value;
           })));

        internal override string ResetToolTip()
        {
            string min = Minimum == int.MinValue ? "-∞" : Minimum.ToString();
            string max = Maximum == int.MaxValue ? "+∞" : Maximum.ToString();
            this.TxtToolTip = string.Format("Value [{0},{1}]", min, max);
            return base.ResetToolTip();
        }
        #endregion


        /// <summary>
        /// 检查拼写是否错误
        /// </summary>
        /// <param name="input"></param>
        /// <param name="output"></param>
        /// <returns></returns>
        internal bool CheckSpell(out int value)
        {
            bool res = true;
            if (string.IsNullOrEmpty(this.Text))
            {
                value = 0;
            }
            else
            {
                res = int.TryParse(this.Text, out value);
            }
            if (!IsEnabled)
            {
                res = true;
            }
            SetError(!res, "Text Spell Error");
            return res;
        }

        /// <summary>
        /// 检查是否超越界限
        /// </summary>
        /// <returns></returns>
        internal bool CheckValue(int value)
        {
            bool hasError = false;
            if (value != value.Between(Maximum, Minimum, DefaultValue))
            {
                hasError = true;
            }
            string message = ResetToolTip();
            SetError(hasError, message);
            return hasError;
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            SelfCheck();
        }

        /// <summary>
        /// 失去焦点后自检
        /// </summary>
        /// <param name="e"></param>
        protected override void OnLostFocus(RoutedEventArgs e)
        {
            base.OnLostFocus(e);
            SelfCheck();
        }


        /// <summary>
        /// 鼠标离开区域时候自检
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseLeave(MouseEventArgs e)
        {
            base.OnMouseLeave(e);
            //SelfCheck();
        }


        public void SelfCheck()
        {
            int v = 0;
            if (int.TryParse(Text, out v))
            {
                v = v.Between(Maximum, Minimum, DefaultValue);
            }
            Value = v;
            Text = Value.ToString();
            AfterSelfCheckCommand?.Invoke(Value);
            ValueChangedCommand?.Execute(null);
            SetError(false);
        }


        public ICommand UpCommand => new DelegateCommand(() =>
        {
            this.Value += Step;
            SelfCheck();
            Keyboard.Focus(this);
        });

        public ICommand DownCommand => new DelegateCommand(() =>
        {
            this.Value -= Step;
            SelfCheck();
            Keyboard.Focus(this);
        });
    }

    /// <summary>
    /// 自带数值校验的Doublele类型TextBox
    /// </summary>
    [ImplementPropertyChanged]
    public class HTDoubleInputCustomNumticTextBox : HTCustomNumticTextBox
    {
        static HTDoubleInputCustomNumticTextBox()
        {
            TextProperty.OverrideMetadata(typeof(HTDoubleInputCustomNumticTextBox), new FrameworkPropertyMetadata(null, new PropertyChangedCallback((sender, arg) =>
            {
                var textbox = (HTDoubleInputCustomNumticTextBox)sender;
                double v = 0;
                if (textbox.Text == null)
                {
                    textbox.Text = textbox.Value.ToString();
                }
                if (textbox.CheckSpell(out v))
                {
                    textbox.CheckValue(v);
                }
                textbox.AfterInputCommand?.Invoke(v);
            }), new CoerceValueCallback((sender, value) =>
            {
                var textbox = (HTDoubleInputCustomNumticTextBox)sender;
                return value;
            })));
        }

        public HTDoubleInputCustomNumticTextBox()
        {
            this.IsNumticText = true;
        }

        public double Value
        {
            get { return (double)GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }

        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register("Value", typeof(double), typeof(HTDoubleInputCustomNumticTextBox), new PropertyMetadata(0.0, new PropertyChangedCallback((sender, arg) =>
            {
                var textbox = (HTDoubleInputCustomNumticTextBox)sender;
                textbox.CheckValue(textbox.Value);
            }), new CoerceValueCallback((sender, value) =>
            {
                var textbox = (HTDoubleInputCustomNumticTextBox)sender;
                textbox.Text = value.ToString();
                return value;
            })));


        public double? DefaultValue
        {
            get { return (double?)GetValue(DefaultValueProperty); }
            set { SetValue(DefaultValueProperty, value); }
        }

        public static readonly DependencyProperty DefaultValueProperty =
            DependencyProperty.Register("DefaultValue", typeof(double?), typeof(HTDoubleInputCustomNumticTextBox), new PropertyMetadata(null));

        public ICommand ValueChangedCommand
        {
            get { return (ICommand)GetValue(ValueChangedCommandProperty); }
            set { SetValue(ValueChangedCommandProperty, value); }
        }

        public static readonly DependencyProperty ValueChangedCommandProperty =
            DependencyProperty.Register("ValueChangedCommand", typeof(ICommand), typeof(HTDoubleInputCustomNumticTextBox), new PropertyMetadata(null));

        public Action<double> AfterSelfCheckCommand
        {
            get { return (Action<double>)GetValue(AfterSelfCheckCommandProperty); }
            set { SetValue(AfterSelfCheckCommandProperty, value); }
        }

        public static readonly DependencyProperty AfterSelfCheckCommandProperty =
            DependencyProperty.Register("AfterSelfCheckCommand", typeof(Action<double>), typeof(HTDoubleInputCustomNumticTextBox), new PropertyMetadata(null));


        public Action<double> AfterInputCommand
        {
            get { return (Action<double>)GetValue(AfterInputCommandProperty); }
            set { SetValue(AfterInputCommandProperty, value); }
        }

        public static readonly DependencyProperty AfterInputCommandProperty =
            DependencyProperty.Register("AfterInputCommand", typeof(Action<double>), typeof(HTDoubleInputCustomNumticTextBox), new PropertyMetadata(null));


        public double Step
        {
            get { return (double)GetValue(StepProperty); }
            set { SetValue(StepProperty, value); }
        }

        public static readonly DependencyProperty StepProperty =
            DependencyProperty.Register("Step", typeof(double), typeof(HTDoubleInputCustomNumticTextBox), new PropertyMetadata(1.0));


        #region Minimun && Maximun
        public double Maximum
        {
            get { return (double)GetValue(MaximumProperty); }
            set { SetValue(MaximumProperty, value); }
        }

        public static readonly DependencyProperty MaximumProperty =
            DependencyProperty.Register("Maximum", typeof(double), typeof(HTDoubleInputCustomNumticTextBox), new PropertyMetadata(double.MaxValue, new PropertyChangedCallback((sender, arg) =>
            {
                var textbox = (HTDoubleInputCustomNumticTextBox)sender;
                textbox.Value = (textbox.Value).Between(textbox.Maximum, textbox.Minimum, textbox.DefaultValue);
                textbox.AfterSelfCheckCommand?.Invoke(textbox.Value);
                textbox.ValueChangedCommand?.Execute(null);
                textbox.ResetToolTip();
            }), new CoerceValueCallback((sender, value) =>
            {
                return value;
            })));


        public double Minimum
        {
            get { return (double)GetValue(MinimumProperty); }
            set { SetValue(MinimumProperty, value); }
        }

        public static readonly DependencyProperty MinimumProperty =
           DependencyProperty.Register("Minimum", typeof(double), typeof(HTDoubleInputCustomNumticTextBox), new PropertyMetadata(double.MinValue, new PropertyChangedCallback((sender, arg) =>
           {
               var textbox = (HTDoubleInputCustomNumticTextBox)sender;
               textbox.Value = (textbox.Value).Between(textbox.Maximum, textbox.Minimum, textbox.DefaultValue);
               textbox.AfterSelfCheckCommand?.Invoke(textbox.Value);
               textbox.ValueChangedCommand?.Execute(null);
               textbox.ResetToolTip();
           }), new CoerceValueCallback((sender, value) =>
           {
               return value;
           })));

        internal override string ResetToolTip()
        {
            string min = Minimum == double.MinValue ? "-∞" : Minimum.ToString();
            string max = Maximum == double.MaxValue ? "+∞" : Maximum.ToString();
            this.TxtToolTip = string.Format("Value [{0},{1}]", min, max);
            return base.ResetToolTip();
        }
        #endregion

        /// <summary>
        /// 检查拼写是否错误
        /// </summary>
        /// <param name="input"></param>
        /// <param name="output"></param>
        /// <returns></returns>
        internal bool CheckSpell(out double value)
        {
            bool res = double.TryParse(this.Text, out value);
            SetError(!res, "Text Spell Error ");
            return res;
        }

        /// <summary>
        /// 检查是否超越界限
        /// </summary>
        /// <returns></returns>
        internal bool CheckValue(double value)
        {
            bool hasError = false;
            if (value != value.Between(Maximum, Minimum, DefaultValue))
            {
                hasError = true;
            }
            string message = ResetToolTip();
            SetError(hasError, message);
            return hasError;
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            SelfCheck();
        }

        protected override void OnMouseWheel(MouseWheelEventArgs e)
        {
            base.OnMouseWheel(e);
            this.Value += e.Delta / 120.0;
        }

        /// <summary>
        /// 失去焦点后自检
        /// </summary>
        /// <param name="e"></param>
        protected override void OnLostFocus(RoutedEventArgs e)
        {
            base.OnLostFocus(e);
            SelfCheck();
        }

        /// <summary>
        /// 鼠标离开区域时候自检
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseLeave(MouseEventArgs e)
        {
            base.OnMouseLeave(e);
            //SelfCheck();
        }

        public void SelfCheck()
        {
            double v = 0;
            if (double.TryParse(Text, out v))
            {
                v = v.Between(Maximum, Minimum, DefaultValue);
            }
            Value = v;
            Text = Value.ToString();
            AfterSelfCheckCommand?.Invoke(Value);
            ValueChangedCommand?.Execute(null);
            SetError(false);
        }

        public ICommand UpCommand => new DelegateCommand(() =>
        {
            this.Value += Step;
            SelfCheck();
            Keyboard.Focus(this);
        });

        public ICommand DownCommand => new DelegateCommand(() =>
        {
            this.Value -= Step;
            SelfCheck();
            Keyboard.Focus(this);
        });
    }

    #endregion
}
