using HTProject.Plugin.Base.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HTProject.Plugin.Control.Windows
{
    /// <summary>
    /// Interaction logic for ShadowWindow.xaml
    /// </summary>
    public partial class ShadowWindow : Window, INotifyPropertyChanged
    {
        #region UI更新接口
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            if (PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        private double _HTWindowShadowSize = 10.0;
        [Description("窗体阴影大小"), Category("HTSkin")]
        public double HTWindowShadowSize
        {
            get
            {
                return _HTWindowShadowSize;
            }

            set
            {
                _HTWindowShadowSize = value;
                OnPropertyChanged("HTWindowShadowSize");
            }
        }

        private Color _HTWindowShadowColor = Color.FromArgb(255, 200, 200, 200);
        [Description("窗体阴影颜色"), Category("HTSkin")]
        public Color HTWindowShadowColor
        {
            get
            {
                return _HTWindowShadowColor;
            }

            set
            {
                _HTWindowShadowColor = value;
                OnPropertyChanged("HTWindowShadowColor");
            }
        }


        private Brush _HTWindowShadowBackColor = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
        [Description("窗体阴影背景颜色"), Category("HTSkin")]
        public Brush HTWindowShadowBackColor
        {
            get
            {
                return _HTWindowShadowBackColor;
            }

            set
            {
                _HTWindowShadowBackColor = value;
                OnPropertyChanged("HTWindowShadowBackColor");
            }
        }

        public ShadowWindow()
        {
            InitializeComponent();
            DataContext = this;
            SourceInitialized += MainWindow_SourceInitialized;
        }

        private void MainWindow_SourceInitialized(object sender, EventArgs e)
        {
            IntPtr Handle = new WindowInteropHelper(this).Handle;
            int exStyle = (int)NativeMethods.GetWindowLong(Handle, -20);
            exStyle = NativeConstants.WS_EX_TOOLWINDOW;
            NativeMethods.SetWindowLong(Handle, -20, (IntPtr)exStyle);
        }
    }
}
