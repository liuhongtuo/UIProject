using HTProject.Plugin.Control.Controls;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HTProject.Plugin.Control.UserControls
{
    /// <summary>
    /// Interaction logic for TricolourLight.xaml
    /// </summary>
    [ImplementPropertyChanged]
    public partial class TricolourLight : UserControl
    {
        public TricolourLight()
        {
            InitializeComponent();
        }


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
                        lightControl.RedLight.State = LightState.Normal;
                        lightControl.YellowLight.State = LightState.Normal;
                        lightControl.BlueLight.State = LightState.Flash;
                        lightControl.GreenLight.State = LightState.Normal;
                        break;
                    case LightColourState.Initialize:
                        lightControl.RedLight.State = LightState.Normal;
                        lightControl.YellowLight.State = LightState.Normal;
                        lightControl.BlueLight.State = LightState.Flash;
                        lightControl.GreenLight.State = LightState.Normal;
                        break;
                    case LightColourState.Running:
                        lightControl.RedLight.State = LightState.Normal;
                        lightControl.YellowLight.State = LightState.Normal;
                        lightControl.RedLight.State = LightState.Normal;
                        lightControl.GreenLight.State = LightState.Flash;
                        break;
                    case LightColourState.Warning:
                        lightControl.RedLight.State = LightState.Normal;
                        lightControl.YellowLight.State = LightState.Flash;
                        lightControl.BlueLight.State = LightState.Normal;
                        lightControl.GreenLight.State = LightState.Normal;
                        break;
                    case LightColourState.Alarm:
                        lightControl.RedLight.State = LightState.Flash;
                        lightControl.YellowLight.State = LightState.Normal;
                        lightControl.BlueLight.State = LightState.Normal;
                        lightControl.GreenLight.State = LightState.Normal;
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
