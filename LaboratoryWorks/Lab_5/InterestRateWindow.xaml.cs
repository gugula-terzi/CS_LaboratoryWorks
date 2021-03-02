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

namespace Lab_5
{
    /// <summary>
    /// Interaction logic for InterestRateWindow.xaml
    /// </summary>
    public partial class InterestRateWindow : Window
    {
        public InterestRateWindow()
        {
            InitializeComponent();
        }

        public double custom_interest_rate { get; set; }

        private void NavPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MinimizeBtn_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void CheckInput_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9.]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void SubmitInterestRateBtn_Click(object sender, RoutedEventArgs e)
        {
            if (CustomInterestRate.Text == "")
            {
                MessageBox.Show("You didn't fill in your interest rate",
                                "Error",
                                MessageBoxButton.OK,
                                MessageBoxImage.Error);
            }
            else
            {
                custom_interest_rate = Convert.ToDouble(CustomInterestRate.Text);
                this.Close();
            }
        }
    }
}
