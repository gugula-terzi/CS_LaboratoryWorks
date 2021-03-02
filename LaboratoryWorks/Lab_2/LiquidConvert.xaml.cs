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
    /// Interaction logic for LiquidConvert.xaml
    /// </summary>
    public partial class LiquidConvert : Window
    {
        public LiquidConvert()
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
            float gallon, cubic_meter, barrel, bushe, liter;

            liter = Convert.ToSingle(DegreeTextBox.Text);

            gallon = liter / float.Parse("4,55");
            cubic_meter = liter / float.Parse("1000");
            barrel = liter / float.Parse("163,65");
            bushe = liter / float.Parse("36,36872");

            BusheLabel.Content = Math.Round(Convert.ToDouble(bushe), 4);
            GallonLabel.Content = Math.Round(Convert.ToDouble(gallon), 4);
            BarrelLabel.Content = Math.Round(Convert.ToDouble(barrel), 4);
            CubicMeterLabel.Content = Math.Round(Convert.ToDouble(cubic_meter), 4);
        }



        private void DegreeTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            //e.Handled = !(Char.IsDigit(e.Text, 0));
            Regex regex = new Regex("[^0-9]+");
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
