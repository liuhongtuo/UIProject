﻿using HTProject.Plugin.Base.Win32;
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using SystemCommands = HTProject.Plugin.Base.Win32.SystemCommands;
using System.Windows.Media.Animation;

namespace HTProject.Plugin.Control.Windows
{
    /// <summary>
    /// 单层窗体 - 嵌入GDI+组件的时候 会出现空域问题。
    /// </summary>
    public class HTSkinSimpleWindow : Window
    {
        #region 初始化
        public HTSkinSimpleWindow()
        {
            InitializeWindowStyle();

            //绑定窗体操作函数
            SourceInitialized += MainWindow_SourceInitialized;
            StateChanged += MainWindow_StateChanged;
            MouseLeftButtonDown += MainWindow_MouseLeftButtonDown;
        }
        #endregion

        #region 窗口模式
        /// <summary>
        /// 慢慢显示的动画
        /// </summary>
        Storyboard StoryboardSlowShow;

        /// <summary>
        /// 慢慢隐藏的动画
        /// </summary>
        Storyboard StoryboardSlowHide;

        /// <summary>
        /// 加载双层窗口的样式
        /// </summary>
        private void InitializeWindowStyle()
        {
            //ResourceDictionary dic = new ResourceDictionary { Source = new Uri(@"/HTProject.Plugin.Control;component/Windows/HTSkinSimpleWindow.xaml", UriKind.Relative) };
            //Resources.MergedDictionaries.Add(dic);
            //Style = (Style)dic["HTSkinSimpleWindow"];

            //string packUriAnimation = @"/WMWpfProject.Control;component/Styles/HTAnimation.xaml";
            //ResourceDictionary dicAnimation = new ResourceDictionary { Source = new Uri(packUriAnimation, UriKind.Relative) };
            //Resources.MergedDictionaries.Add(dicAnimation);

            //StoryboardSlowShow = (Storyboard)FindResource("SlowShow");
            //StoryboardSlowHide = (Storyboard)FindResource("SlowHide");
            
        }
        #endregion

        #region XAML动画
        /// <summary>
        /// 执行最小化窗体
        /// </summary>
        private void StoryboardHide()
        {
            //启动最小化动画
            //StoryboardSlowHide.Begin(this);
            Task.Factory.StartNew(() =>
            {
                Thread.Sleep(1000);
                Dispatcher.Invoke(new Action(() =>
                {
                    WindowState = WindowState.Minimized;
                }));
            });
        }

        /// <summary>
        /// 恢复窗体
        /// </summary>
        private void WindowRestore()
        {
            Opacity = 0;
            //StoryboardSlowShow.Begin(this);
            Task.Factory.StartNew(() =>
            {
                Thread.Sleep(20);
                Dispatcher.Invoke(new Action(() =>
                {
                    WindowState = WindowState.Normal;
                    //Opacity = 1;
                }));
            });
        }
        #endregion

        #region 系统函数
        IntPtr Handle = IntPtr.Zero;
        HwndSource source;
        private void MainWindow_SourceInitialized(object sender, EventArgs e)
        {
            Handle = new WindowInteropHelper(this).Handle;
            source = HwndSource.FromHwnd(Handle);
            if (source == null)
            { throw new Exception("Cannot get HwndSource instance."); }
            //source.AddHook(new HwndSourceHook(this.WndProc));
        }

        private IntPtr WndProc(IntPtr hwnd, int msg, IntPtr wParam, IntPtr lParam, ref bool handled)
        {
            switch (msg)
            {
                //获取窗口的最大化最小化信息
                case (int)WindowMessages.WM_GETMINMAXINFO:
                    WmGetMinMaxInfo(hwnd, lParam);
                    if (wParam.ToInt32() == (int)SystemCommands.SC_MINIMIZE)//最小化消息
                    {
                        StoryboardHide();//执行最小化动画
                        handled = true;
                    }
                    handled = true;
                    break;
                //case Win32.WM_NCHITTEST:
                //     return WmNCHitTest(lParam, ref handled);
                case (int)WindowMessages.WM_SYSCOMMAND:
                    //if (wParam.ToInt32() == (int)SystemCommands.SC_MINIMIZE)//最小化消息
                    //{
                    //    StoryboardHide();//执行最小化动画
                    //    handled = true;
                    //}
                    if (wParam.ToInt32() == (int)SystemCommands.SC_RESTORE)//恢复消息
                    {
                        WindowRestore();//执行恢复动画
                        handled = true;
                    }
                    break;
                    //case Win32.WM_NCPAINT:
                    //    break;
                    //case Win32.WM_NCCALCSIZE:
                    //    handled = true;
                    //    break;
                    //case Win32.WM_NCUAHDRAWCAPTION:
                    //case Win32.WM_NCUAHDRAWFRAME:
                    //    handled = true;
                    //    break;
                    //case Win32.WM_NCACTIVATE:
                    //    if (wParam == (IntPtr)Win32.WM_TRUE)
                    //    {
                    //        handled = true;
                    //    }
                    //    break;
            }
            return IntPtr.Zero;
        }

        private void WmGetMinMaxInfo(IntPtr hwnd, IntPtr lParam)
        {
            // MINMAXINFO structure  
            MINMAXINFO mmi = (MINMAXINFO)Marshal.PtrToStructure(lParam, typeof(MINMAXINFO));

            //拿到最靠近当前软件的显示器
            IntPtr hMonitor = NativeMethods.MonitorFromWindow(Handle, NativeConstants.MONITOR_DEFAULTTONEAREST);

            // Get monitor info   显示屏
            MONITORINFOEX monitorInfo = new MONITORINFOEX();

            monitorInfo.cbSize = Marshal.SizeOf(monitorInfo);
            NativeMethods.GetMonitorInfo(new HandleRef(this, hMonitor), monitorInfo);

            // Convert working area  
            RECT workingArea = monitorInfo.rcWork;

            //设置最大化的时候的坐标 
            mmi.ptMaxPosition.x = workingArea.left;
            mmi.ptMaxPosition.y = workingArea.top;

            if (source == null)
                throw new Exception("Cannot get HwndSource instance.");
            if (source.CompositionTarget == null)
                throw new Exception("Cannot get HwndTarget instance.");

            Matrix matrix = source.CompositionTarget.TransformToDevice;

            Point dpiIndenpendentTrackingSize = matrix.Transform(new Point(
               this.MinWidth,
               this.MinHeight));

            if (HTFullScreen)
            {
                Point dpiSize = matrix.Transform(new Point(
              SystemParameters.PrimaryScreenWidth,
              SystemParameters.PrimaryScreenHeight
              ));

                mmi.ptMaxSize.x = (int)dpiSize.X;
                mmi.ptMaxSize.y = (int)dpiSize.Y;
            }
            else
            {
                //设置窗口最大化的尺寸
                mmi.ptMaxSize.x = workingArea.right - workingArea.left;
                mmi.ptMaxSize.y = workingArea.bottom;
            }

            //设置最小跟踪大小
            mmi.ptMinTrackSize.x = (int)dpiIndenpendentTrackingSize.X;
            mmi.ptMinTrackSize.y = (int)dpiIndenpendentTrackingSize.Y;

            Marshal.StructureToPtr(mmi, lParam, true);
        }

        Thickness MaxThickness = new Thickness(0);
        Thickness NormalThickness = new Thickness(20);

        /// <summary>
        /// 窗体最大化 隐藏阴影
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainWindow_StateChanged(object sender, EventArgs e)
        {
            //最大化
            if (WindowState == WindowState.Maximized)
            {
                BorderThickness = MaxThickness;
            }
            //默认大小
            if (WindowState == WindowState.Normal)
            {
                BorderThickness = NormalThickness;
            }
            //最小化-隐藏阴影
            if (WindowState == WindowState.Minimized)
            {
            }
        }

        /// <summary>
        /// 窗体移动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainWindow_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.OriginalSource is Grid || e.OriginalSource is Window || e.OriginalSource is Border)
            {
                NativeMethods.SendMessage(Handle, (int)WindowMessages.WM_NCLBUTTONDOWN, (IntPtr)HitTest.HTCAPTION, IntPtr.Zero);
                return;
            }
        }

        #endregion

        #region 窗体属性
        [Description("全屏是否保留任务栏显示"), Category("HTSkin")]
        public bool HTFullScreen
        {
            get { return (bool)GetValue(HTFullScreenProperty); }
            set { SetValue(HTFullScreenProperty, value); }
        }
        public static readonly DependencyProperty HTFullScreenProperty =
            DependencyProperty.Register("HTFullScreen", typeof(bool), typeof(HTSkinSimpleWindow), new PropertyMetadata(false));

        [Description("窗体阴影大小"), Category("HTSkin")]
        public double HTWindowShadowSize
        {
            get { return (double)GetValue(HTWindowShadowSizeProperty); }
            set { SetValue(HTWindowShadowSizeProperty, value); }
        }
        public static readonly DependencyProperty HTWindowShadowSizeProperty =
            DependencyProperty.Register("HTWindowShadowSize", typeof(double), typeof(HTSkinSimpleWindow), new PropertyMetadata(10.0));

        [Description("窗体阴影颜色"), Category("HTSkin")]
        public Color HTWindowShadowColor
        {
            get { return (Color)GetValue(HTWindowShadowColorProperty); }
            set { SetValue(HTWindowShadowColorProperty, value); }
        }
        public static readonly DependencyProperty HTWindowShadowColorProperty =
            DependencyProperty.Register("HTWindowShadowColor", typeof(Color), typeof(HTSkinSimpleWindow), new PropertyMetadata(Color.FromArgb(255, 200, 200, 200)));

        [Description("窗体阴影透明度"), Category("HTSkin")]
        public double HTWindowShadowOpacity
        {
            get { return (double)GetValue(HTWindowShadowOpacityProperty); }
            set { SetValue(HTWindowShadowOpacityProperty, value); }
        }
        public static readonly DependencyProperty HTWindowShadowOpacityProperty =
            DependencyProperty.Register("HTWindowShadowOpacity", typeof(double), typeof(HTSkinSimpleWindow), new PropertyMetadata(1.0));
        #endregion
    }
}

