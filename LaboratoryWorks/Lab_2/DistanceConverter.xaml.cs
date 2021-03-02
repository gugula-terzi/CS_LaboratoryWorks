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
    /// Interaction logic for DistanceConverter.xaml
    /// </summary>
    public partial class DistanceConverter : Window
    {
        public DistanceConverter()
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
            float mile, foot, league, lieue, kilometers;
                            
            kilometers = Convert.ToSingle(DegreeTextBox.Text);

            mile = kilometers / float.Parse("1,609344");
            foot = kilometers / (float.Parse("0,3048") / 1000);
            league = kilometers / float.Parse("4,828032");
            lieue = kilometers / float.Parse("4,44");

            MileLabel.Content = Math.Round(Convert.ToDouble(mile), 4);
            FootLabel.Content = Math.Round(Convert.ToDouble(foot), 4);
            LeagueLabel.Content = Math.Round(Convert.ToDouble(league), 4);
            LieueLabel.Content = Math.Round(Convert.ToDouble(lieue), 4);
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
