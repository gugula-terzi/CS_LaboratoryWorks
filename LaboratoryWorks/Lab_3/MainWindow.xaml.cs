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

namespace Lab_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public struct AuthorizationData
    {
        public string Login;
        public string Password;
    }
    public partial class MainWindow : Window
    {
        static public AuthorizationData AuthData;
        public MainWindow()
        {
            InitializeComponent();
            SigninBox.Text = AuthData.Login;
            PasswordBox.Password = AuthData.Password;
        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
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

        private void NavPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void EnterBtn_Click(object sender, RoutedEventArgs e)
        {
            if (SigninBox.Text == "admin" && PasswordBox.Password == "root")
            {
                Welcome welcome = new Welcome();
                welcome.Show();
                this.Close();
            }
        }

        private void RegisterBtn_Click(object sender, RoutedEventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Close();
        }

        private void ClearFields_MouseDown(object sender, MouseButtonEventArgs e)
        {
            SigninBox.Clear();
            PasswordBox.Clear();
        }
    }
}
