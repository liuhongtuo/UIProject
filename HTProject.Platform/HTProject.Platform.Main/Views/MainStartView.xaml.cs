﻿using Caliburn.Micro;
using HTProject.Plugin.Control.Windows;
using PropertyChanged;
using System;
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
using System.Windows.Shapes;

namespace HTProject.Platform.Main.Views
{
    /// <summary>
    /// Interaction logic for MainStartView.xaml
    /// </summary>
    [ImplementPropertyChanged]
    public partial class MainStartView : HTSkinSimpleWindow
    {
        public MainStartView()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        public bool IsContainXAxis { get; set; } = false;
    }
}
