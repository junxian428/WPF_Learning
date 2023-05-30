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

namespace WPFPractice1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        bool running = false;

        public MainWindow()
        {
            InitializeComponent();

            TextBlock1.Text = "Hello World 2";
            btnRun.Content = "STOP";
        }

        private void btnRun_Click(object sender, RoutedEventArgs e)
        {

            if (running)
            {
                btnRun.Content = "Stopped";
                TextBlock1.Text = "Stopped";
            }
            else
            {
                btnRun.Content = "Running";
                TextBlock1.Text = "Running";
            }

            running = !running;
        }
    }
}
