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

namespace Lab_5
{
    /// <summary>
    /// Interaction logic for CreditResultWindow.xaml
    /// </summary>
    public partial class CreditResultWindow : Window
    {
        public CreditResultWindow(string loan_amount, string one_time_commission_fee, string income, string total_payment_due, string credit_date, string interest_rate, string payment_per_month)
        {
            InitializeComponent();
            LoanAmountTextBox.Text = loan_amount;
            OneTimeCommissionTextBox.Text = one_time_commission_fee;
            AmountOfIncomeTextBox.Text = income;
            TotalPaymentDueTextBox.Text = total_payment_due;
            CreditDateTextBox.Text = credit_date;
            InterestRateTextBox.Text = interest_rate + "%";
            PaymentPerMonthTextBox.Text = payment_per_month;
        }
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
    }
}
