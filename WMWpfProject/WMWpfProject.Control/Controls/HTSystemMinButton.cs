using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WMWpfProject.Control.Controls
{
    public class HTSystemMinButton : HTSystemButton
    {
        Window targetWindow;
        public HTSystemMinButton()
        {
            Click += delegate
            {
                if (targetWindow == null)
                {
                    targetWindow = Window.GetWindow(this);
                }
                targetWindow.WindowState = WindowState.Minimized;
            };
        }
    }
}
