using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WMWpfProject.Control.Controls
{
    public class HTSystemCloseButton : HTSystemButton
    {
        Window targetWindow;
        public HTSystemCloseButton()
        {
            SystemButtonHoverColor = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));

            Click += delegate
            {
                if (targetWindow == null)
                {
                    targetWindow = Window.GetWindow(this);
                }
                targetWindow.Close();
            };
        }
    }
}
