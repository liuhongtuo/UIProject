using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media;

namespace WMWpfProject.Control.Controls
{
    [DefaultProperty("MenuItems")]
    [ContentProperty("MenuItems")]
    [TemplatePart(Name = LB, Type = typeof(ListBox))]
    public class HTSideMenuItem : System.Windows.Controls.Control
    {
        private const string LB = "LB";
        private ListBox _listBox;
        public bool IsExpanded
        {
            get { return (bool)GetValue(IsExpandedProperty); }
            set { SetValue(IsExpandedProperty, value); }
        }
        public static readonly DependencyProperty IsExpandedProperty =
            DependencyProperty.Register("IsExpanded", typeof(bool), typeof(HTSideMenuItem), new PropertyMetadata(false));


        public List<object> MenuItems
        {
            get { return (List<object>)GetValue(MenuItemsProperty); }
            set { SetValue(MenuItemsProperty, value); }
        }
        public static readonly DependencyProperty MenuItemsProperty =
            DependencyProperty.Register("MenuItems", typeof(List<object>), typeof(HTSideMenuItem), new PropertyMetadata(default(List<object>)));


        public Brush ToggleBackground
        {
            get { return (Brush)GetValue(ToggleBackgroundProperty); }
            set { SetValue(ToggleBackgroundProperty, value); }
        }
        public static readonly DependencyProperty ToggleBackgroundProperty =
            DependencyProperty.Register("ToggleBackground", typeof(Brush), typeof(HTSideMenuItem), new PropertyMetadata(new SolidColorBrush(Color.FromRgb(0x2d, 0x2d, 0x30))));


        public Brush MenuItemBackground
        {
            get { return (Brush)GetValue(MenuItemBackgroundProperty); }
            set { SetValue(MenuItemBackgroundProperty, value); }
        }
        public static readonly DependencyProperty MenuItemBackgroundProperty =
            DependencyProperty.Register("MenuItemBackground", typeof(Brush), typeof(HTSideMenuItem), new PropertyMetadata(new SolidColorBrush(Color.FromRgb(0x16, 0x18, 0x1D))));


        public Brush MenuItemSelectedBackground
        {
            get { return (Brush)GetValue(MenuItemSelectedBackgroundProperty); }
            set { SetValue(MenuItemSelectedBackgroundProperty, value); }
        }
        public static readonly DependencyProperty MenuItemSelectedBackgroundProperty =
            DependencyProperty.Register("MenuItemSelectedBackground", typeof(Brush), typeof(HTSideMenuItem), new PropertyMetadata(Brushes.Green));


        public static readonly RoutedEvent MenuItemSelectedChangedEvent = EventManager.RegisterRoutedEvent("MenuItemSelectedChanged", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(HTSideMenuItem));


        public event RoutedEventHandler MenuItemSelectedChanged
        {
            add { AddHandler(MenuItemSelectedChangedEvent, value); }
            remove { RemoveHandler(MenuItemSelectedChangedEvent, value); }
        }
        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            _listBox = (GetTemplateChild(LB) as ListBox) ?? throw new Exception("listbox Named with \"LB\" not found in the Template");
            _listBox.SelectionChanged -= _listBoxSelectionChanged;
            _listBox.SelectionChanged += _listBoxSelectionChanged;
        }


        private void _listBoxSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (!(e.Source is ListBox)) return;
            RoutedEventArgs args = new RoutedEventArgs()
            {
                RoutedEvent = MenuItemSelectedChangedEvent,
                Source = _listBox,
            };
            RaiseEvent(args);
        }
    }

}





