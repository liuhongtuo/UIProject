﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace WMWpfProject.Control.Controls
{
    public class HTNumericBox : TextBox
    {
        public string ShowText
        {
            get { return (string)GetValue(ShowTextProperty); }
            set { SetValue(ShowTextProperty, value); }
        }
        public static readonly DependencyProperty ShowTextProperty =
            DependencyProperty.Register("ShowText", typeof(string), typeof(HTNumericBox), new PropertyMetadata(string.Empty));


        public override void OnApplyTemplate()
        {
            Button BtnAdd = Template.FindName("BtnAdd",this) as Button;
            Button BtnReduce = Template.FindName("BtnReduce", this) as Button;

            BtnReduce.Click +=delegate{
                if (Value <= MinValue)
                {
                    Value = MinValue;
                    return;
                }
                Value--;
            };

            BtnAdd.Click += delegate {
                if (Value>=MaxValue)
                {
                    Value = MaxValue;
                    return;
                }
                Value++;
            };
        }


        public int Value
        {
            get { return (int)GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }

        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register("Value", typeof(int), typeof(HTNumericBox), new PropertyMetadata(0));


        public int MinValue
        {
            get { return (int)GetValue(MinValueProperty); }
            set { SetValue(MinValueProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MinValue.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MinValueProperty =
            DependencyProperty.Register("MinValue", typeof(int), typeof(HTNumericBox), new PropertyMetadata(0));


        public int MaxValue
        {
            get { return (int)GetValue(MaxValueProperty); }
            set { SetValue(MaxValueProperty, value); }
        }

        public static readonly DependencyProperty MaxValueProperty =
            DependencyProperty.Register("MaxValue", typeof(int), typeof(HTNumericBox), new PropertyMetadata(100));

    }
}
