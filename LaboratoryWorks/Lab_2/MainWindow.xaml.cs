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

namespace MyProject
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void NavPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void HideBtn_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void KilometerBtn_Click(object sender, RoutedEventArgs e)
        {
            DistanceConverter distance = new DistanceConverter();
            distance.Show();
        }
        private void TemperatureBtn_Click(object sender, RoutedEventArgs e)
        {
            TemperatureConverter temperature = new TemperatureConverter();
            temperature.Show();
        }
        private void WaterBtn_Click(object sender, RoutedEventArgs e)
        {
            LiquidConvert liquid = new LiquidConvert();
            liquid.Show();
        }

    }
}
