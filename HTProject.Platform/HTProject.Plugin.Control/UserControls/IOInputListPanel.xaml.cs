﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HTProject.Plugin.Control.UserControls
{
    /// <summary>
    /// IOInputListPanel.xaml 的交互逻辑
    /// </summary>
    public partial class IOInputListPanel : ListView
    {
        public IOInputListPanel()
        {
            InitializeComponent();
        }

        public string StateString
        {
            get { return (string)GetValue(StateStringProperty); }
            set { SetValue(StateStringProperty, value); }
        }
        public static readonly DependencyProperty StateStringProperty =
            DependencyProperty.Register("StateString", typeof(string), typeof(IOInputListPanel), new PropertyMetadata("✔"));


        public int Columns
        {
            get { return (int)GetValue(ColumnsProperty); }
            set { SetValue(ColumnsProperty, value); }
        }
        public static readonly DependencyProperty ColumnsProperty =
            DependencyProperty.Register("Columns", typeof(int), typeof(IOInputListPanel), new PropertyMetadata(4));


        public bool IsCheckComplate
        {
            get { return (bool)GetValue(IsCheckComplateProperty); }
            set { SetValue(IsCheckComplateProperty, value); }
        }
        public static readonly DependencyProperty IsCheckComplateProperty =
            DependencyProperty.Register("IsCheckComplate", typeof(bool), typeof(IOInputListPanel), new PropertyMetadata(false));


        public int ImageWidth
        {
            get { return (int)GetValue(ImageWidthProperty); }
            set { SetValue(ImageWidthProperty, value); }
        }
        public static readonly DependencyProperty ImageWidthProperty =
            DependencyProperty.Register("ImageWidth", typeof(int), typeof(IOInputListPanel), new PropertyMetadata(20));


        public int ImageHeight
        {
            get { return (int)GetValue(ImageHeightProperty); }
            set { SetValue(ImageHeightProperty, value); }
        }
        public static readonly DependencyProperty ImageHeightProperty =
            DependencyProperty.Register("ImageHeight", typeof(int), typeof(IOInputListPanel), new PropertyMetadata(20));


        public int DescribeWidth
        {
            get { return (int)GetValue(DescribeWidthProperty); }
            set { SetValue(DescribeWidthProperty, value); }
        }

        // Using a DependencyProperty as the backing store for DescribeWidth.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DescribeWidthProperty =
            DependencyProperty.Register("DescribeWidth", typeof(int), typeof(IOInputListPanel), new PropertyMetadata(200));

        private void IODescribe_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            var textBlock = sender as TextBlock;
            if (textBlock != null)
            {
                if (textBlock.Tag == null)
                {
                    textBlock.Tag = "Completed";
                }
                else
                {
                    textBlock.Tag = null;
                }
            }
        }
    }
}
