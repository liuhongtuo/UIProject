﻿using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WMWpfProject.Control.Controls
{
    public class HTSystemMaxButton : HTSystemButton
    {
        Window targetWindow;
        public HTSystemMaxButton()
        {
            Click += delegate
            {
                if (targetWindow == null)
                {
                    targetWindow = Window.GetWindow(this);
                    targetWindow.StateChanged += delegate
                    {
                        if (targetWindow.WindowState == WindowState.Normal)
                        {
                            IsMax = false;
                        }
                        else if (targetWindow.WindowState == WindowState.Maximized)
                        {
                            IsMax = true;
                        }
                    };
                }
                if (targetWindow.WindowState == WindowState.Normal)
                {
                    targetWindow.WindowState = WindowState.Maximized;
                }
                else if (targetWindow.WindowState == WindowState.Maximized)
                {
                    targetWindow.WindowState = WindowState.Normal;
                }
            };
        }

        public bool IsMax
        {
            get { return (bool)GetValue(IsMaxProperty); }
            set
            {
                SetValue(IsMaxProperty, value);
            }
        }

        public static readonly DependencyProperty IsMaxProperty =
            DependencyProperty.Register("IsMax", typeof(bool), typeof(HTSystemMaxButton), new PropertyMetadata(false));
    }
}
