using HTProject.Plugin.Control.Controls;
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
    /// Interaction logic for TricolourLight.xaml
    /// </summary>
    public partial class TricolourLight : UserControl
    {
        public TricolourLight()
        {
            InitializeComponent();
        }

        public LightState RedLightState
        {
            get { return (LightState)GetValue(RedLightStateProperty); }
            set { SetValue(RedLightStateProperty, value); }
        }

        public static readonly DependencyProperty RedLightStateProperty =
            DependencyProperty.Register("RedLightState", typeof(LightState), typeof(TricolourLight), new PropertyMetadata(LightState.Normal));





        public LightColourState LightColourState
        {
            get { return (LightColourState)GetValue(LightColourStateProperty); }
            set { SetValue(LightColourStateProperty, value); }
        }

        public static readonly DependencyProperty LightColourStateProperty =
            DependencyProperty.Register("LightColourState", typeof(LightColourState), typeof(TricolourLight), new FrameworkPropertyMetadata(LightColourState.Idle, OnStateChanged));

        private static void OnStateChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var lightControl = d as TricolourLight;
            if (lightControl != null)
            {
                lightControl.LightColourState = (LightColourState)e.NewValue;
                switch (lightControl.LightColourState)
                {
                    case LightColourState.Idle:
                        break;
                    case LightColourState.Initialize:
                        break;
                    case LightColourState.Running:
                        break;
                    case LightColourState.Warning:
                        break;
                    case LightColourState.Alarm:
                        break;
                    default:
                        break;
                }
            }
        }
    }

    public enum LightColourState
    {
        Idle,
        Initialize,
        Running,
        Warning,
        Alarm
    }

}
