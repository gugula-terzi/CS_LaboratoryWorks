using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Text.RegularExpressions;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Lab_3
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        public Register()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void NavPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void MinimizeBtn_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void MaximizeBtn_Click(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Maximized)
            {
                WindowState = WindowState.Normal;
            }
            else
            {
                WindowState = WindowState.Maximized;
            }
        }

        private void ClearBtn_Click(object sender, RoutedEventArgs e)
        {
            LoginBox.Clear();
            PassBox.Clear();
            EmailBox.Clear();
            NameBox.Clear();
            SurnameBox.Clear();
            PatronymicBox.Clear();
            FemBtn.IsChecked = false;
            MascBtn.IsChecked = false;
            EnBox.IsChecked = false;
            GeBox.IsChecked = false;
            FrBox.IsChecked = false;
            MainLanguage.SelectedItem = null;
            DateOfBirth.SelectedDate = null;
        }

        private void ConfirmBtn_Click(object sender, RoutedEventArgs e)
        {
            if (LoginBox.Text == "")
            {
                MessageBox.Show("You didn't enter your login");
            }
            else if (PassBox.Password.Length < 8)
            {
                MessageBox.Show("Password is too short");
            }
            else if (!isValid(EmailBox.Text))
            {
                MessageBox.Show("Wrong email");
            }
            else if (MascBtn.IsChecked == false && FemBtn.IsChecked == false)
            {
                MessageBox.Show("You didn't chose your gender");
            }
            else if (MainLanguage.SelectedItem == null)
            {
                MessageBox.Show("You didn't choose your main language");
            }
            else
            {
                MainWindow.AuthData.Login = LoginBox.Text;
                MainWindow.AuthData.Password = PassBox.Password;
                MainWindow main = new MainWindow();
                main.Show();
                this.Close();
            }
        }

        public bool isValid(string email)
        {
            string pattern = "[.\\-_a-z0-9]+@([a-z0-9][\\-a-z0-9]+\\.)+[a-z]{2,6}";
            Match isMatch = Regex.Match(email, pattern, RegexOptions.IgnoreCase);
            return isMatch.Success;
        }

    }
}
