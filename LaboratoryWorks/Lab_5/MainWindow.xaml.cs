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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab_5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public string loan_amount { get; set; }

        public string one_time_commission_fee { get; set; }

        public string income { get; set; }

        public string total_payment_due { get; set; }

        public string credit_date { get; set; }

        public string interest_rate_str { get; set; }


        private void NavPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void MinimizeBtn_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void LoanPeriodTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.Text, 0));
        }

        private void CheckInput_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9.]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void InterestRateComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem typeItem = (ComboBoxItem)InterestRateComboBox.SelectedItem;
            string value = typeItem.Content.ToString();

            if (value == "Credit imobiliar Prima Casă")
                InterestRateTextBox.Text = "5,8%";
            else if (value == "Multiopţional")
                InterestRateTextBox.Text = "9%";
            else if (value == "Cheltuieli personale")
                InterestRateTextBox.Text = "8%";
            else if (value == "Credit Espresso")
                InterestRateTextBox.Text = "2%";
        }

        private void CalculateBtn_Click(object sender, RoutedEventArgs e)
        {
            if (AmountOfLoanTextBox.Text == "" || LoanPeriodTextBox.Text == "" || InterestRateComboBox.Text == "" || CreditCreationDate.Text == "")
            {
                MessageBox.Show("You didn't fill in all the fields",
                                "Error",
                                MessageBoxButton.OK,
                                MessageBoxImage.Error);
            }
            else
            {
                MessageBoxResult result_of_messagebox = MessageBox.Show("Do you want to keep the automatic\ninterest rate or do you want to enter it manually?",
                                                                        "Interest rate",
                                                                        MessageBoxButton.YesNo,
                                                                        MessageBoxImage.Question);

                ComboBoxItem typeItem = (ComboBoxItem)InterestRateComboBox.SelectedItem;
                string value = typeItem.Content.ToString();
                double interest_rate = 0;

                if (result_of_messagebox == MessageBoxResult.Yes)
                {
                    InterestRateWindow rateWindow = new InterestRateWindow();
                    rateWindow.ShowDialog();
                    interest_rate = rateWindow.custom_interest_rate;
                }
                else 
                {
                    if (value == "Credit imobiliar Prima Casă")
                        interest_rate = 5.8;
                    else if (value == "Multiopţional")
                        interest_rate = 9;
                    else if (value == "Cheltuieli personale")
                        interest_rate = 8;
                    else if (value == "Credit Espresso")
                        interest_rate = 2;
                }



                double amount_of_loan = Convert.ToDouble(AmountOfLoanTextBox.Text);
                double loan_period = Convert.ToDouble(LoanPeriodTextBox.Text);
                string date = CreditCreationDate.Text;
                interest_rate_str = Convert.ToString(interest_rate);
                interest_rate = (interest_rate / 12) / 100;
                double result = 0;
                double one_time_comission = amount_of_loan * 0.01;
                double amount_of_income = 0;
                double left = amount_of_loan;

                for (int i = 0; i < loan_period; i++)
                {
                    result = left * interest_rate;
                    left -= amount_of_loan / loan_period;
                    amount_of_income += result;
                }

                double payment_per_month = amount_of_loan * ((interest_rate * Math.Pow(1 + interest_rate, loan_period)) / (Math.Pow(1 + interest_rate, loan_period) - 1));
                payment_per_month = Math.Round(payment_per_month, 2);
                double total_amount = one_time_comission + amount_of_income + amount_of_loan;

                credit_date = Convert.ToString(date);
                loan_amount = Convert.ToString(amount_of_loan);
                one_time_commission_fee = Convert.ToString(one_time_comission);
                total_payment_due = Convert.ToString(total_amount);
                income = Convert.ToString(amount_of_income);
                CreditResultWindow creditResultWindow = new CreditResultWindow(loan_amount, one_time_commission_fee, income, total_payment_due, date, interest_rate_str, Convert.ToString(payment_per_month));
                creditResultWindow.ShowDialog();
            }
        }

    }
}
