using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Text;
using System.Threading.Tasks;
using HTProject.Plugin.Control.Helper;

namespace HTProject.Plugin.Control.Controls
{
    public class HTCustomDataGrid : DataGrid
    {
        static HTCustomDataGrid()
        {
            FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(HTCustomDataGrid), new FrameworkPropertyMetadata(typeof(HTCustomDataGrid)));
        }

        public HTCustomDataGrid()
        {
            base.AddHandler(UIElement.MouseWheelEvent, new MouseWheelEventHandler(this.datagridHorizontalMouseWheel), true);
        }

        private void datagridHorizontalMouseWheel(object sender, MouseWheelEventArgs e)
        {
            HTCustomDataGrid itemsControl = (HTCustomDataGrid)sender;
            bool flag = itemsControl.ActualHeight / 40.0 > (double)(base.Items.Count + 1);
            if (flag)
            {
                ScrollViewer scrollViewer = itemsControl.FindViewTreeChild<ScrollViewer>();
                if (scrollViewer != null)
                {
                    int delta = e.Delta;
                    if (delta > 0)
                    {
                        scrollViewer.LineRight();
                    }
                    else
                    {
                        scrollViewer.LineLeft();
                    }
                }
            }
        }
    }
}
