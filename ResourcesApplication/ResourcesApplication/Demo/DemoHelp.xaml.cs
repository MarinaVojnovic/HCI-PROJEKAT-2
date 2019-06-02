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
using System.Windows.Threading;

namespace ResourcesApplication.Demo
{
    /// <summary>
    /// Interaction logic for DemoHelp.xaml
    /// </summary>
    
    public partial class DemoHelp : Window
    {
        public DemoHelp()
        {
            InitializeComponent();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }

        void timer_Tick(object sender, EventArgs e)
        {
            if (DemoPlayer.Source != null)
            {
                if (DemoPlayer.NaturalDuration.HasTimeSpan)
                    lblStatus.Content = String.Format("{0} / {1}", DemoPlayer.Position.ToString(@"mm\:ss"), DemoPlayer.NaturalDuration.TimeSpan.ToString(@"mm\:ss"));
            }
            else
                lblStatus.Content = "No file selected...";
        }

        private void btnDemoPlay_Click(object sender, RoutedEventArgs e)
        {
            DemoPlayer.Play();
        }

        private void btnDemoPause_Click(object sender, RoutedEventArgs e)
        {
            DemoPlayer.Pause();
        }

        private void btnDemoStop_Click(object sender, RoutedEventArgs e)
        {
            DemoPlayer.Stop();
        }

        private void DemoLoad(object sender, RoutedEventArgs e)
        {
            DemoPlayer.Play();

        }
    }
}
