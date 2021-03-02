using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MyProject
{
    /// <summary>
    /// Interaction logic for TemperatureConverter.xaml
    /// </summary>
    public partial class TemperatureConverter : Window
    {
        public TemperatureConverter()
        {
            InitializeComponent();
            ConvertDestanceBtn.IsEnabled = false;
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


        private void ConvertDestanceBtn_Click(object sender, RoutedEventArgs e)
        {
            float Kelvin, Farenheit, Celsius, Reamur, Rankin;

            Celsius = Convert.ToSingle(DegreeTextBox.Text);

            Kelvin = Celsius + float.Parse("273,15");
            Farenheit = Celsius * (9 / 5) + 32;
            Reamur = Celsius * (Convert.ToSingle(4) / 5);
            Rankin = (Celsius + float.Parse("273,15")) * (Convert.ToSingle(9) / 5);

            KelvinLabel.Content = Kelvin;
            FarenheitLabel.Content = Farenheit;
            ReamurLabel.Content = Reamur;
            RankinLabel.Content = Math.Round(Convert.ToDouble(Rankin), 2);
        }



        private void DegreeTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            //e.Handled = !(Char.IsDigit(e.Text, 0));
            Regex regex = new Regex("[^0-9-]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void DegreeTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (DegreeTextBox.Text == "")
                ConvertDestanceBtn.IsEnabled = false;
            else
                ConvertDestanceBtn.IsEnabled = true;
        }
    }
}
