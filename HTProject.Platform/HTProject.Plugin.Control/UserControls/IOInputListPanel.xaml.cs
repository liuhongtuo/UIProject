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

        // Using a DependencyProperty as the backing store for IsCheckComplate.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsCheckComplateProperty =
            DependencyProperty.Register("IsCheckComplate", typeof(bool), typeof(IOInputListPanel), new PropertyMetadata(false));



        private void IOName_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            var ioInputListPanel = sender as IOInputListPanel;
            if (ioInputListPanel != null)
            {
                ioInputListPanel.IsCheckComplate = !ioInputListPanel.IsCheckComplate;
            }
        }

    }
}
