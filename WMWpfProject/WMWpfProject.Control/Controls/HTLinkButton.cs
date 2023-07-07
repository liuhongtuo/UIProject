using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace WMWpfProject.Control.Controls
{
    public class HTLinkButton : HTSystemButton
    {
        public bool DisplayLine
        {
            get { return (bool)GetValue(DisplayLineProperty); }
            set { SetValue(DisplayLineProperty, value); }
        }
        public static readonly DependencyProperty DisplayLineProperty =
            DependencyProperty.Register("DisplayLine", typeof(bool), typeof(HTLinkButton), new PropertyMetadata(true));
    }
}
