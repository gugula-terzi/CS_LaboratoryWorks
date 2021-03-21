using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LoginForm
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
                DragMove();
        }

        private void PasswordBox_GotFocus(object sender, RoutedEventArgs e)
        {
            Storyboard text_start = this.Resources["TextSizingStartPassword"] as Storyboard;

            if (PasswordBox.Password.Length == 0)
                text_start.Begin();
            else
                return;
        }

        private void PasswordBox_LostFocus(object sender, RoutedEventArgs e)
        {
            Storyboard text_start = this.Resources["TextSizingEndPassword"] as Storyboard;

            if (PasswordBox.Password.Length == 0)
                text_start.Begin();
            else
                return;
        }

        private void LoginBox_GotFocus(object sender, RoutedEventArgs e)
        {
            Storyboard text_start = this.Resources["TextSizingStart"] as Storyboard;

            if (LoginBox.Text.Length == 0)
                text_start.Begin();
            else
                return;
        }

        private void LoginBox_LostFocus(object sender, RoutedEventArgs e)
        {
            Storyboard text_start = this.Resources["TextSizingEnd"] as Storyboard;

            if (LoginBox.Text.Length == 0)
                text_start.Begin();
            else
                return;
        }

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var connectionString = ConfigurationManager.ConnectionStrings["HerokuDB"].ConnectionString; // getting connection string from "App.config" file

                NpgsqlConnection connection = new NpgsqlConnection(connectionString); // creating connection with database
                connection.Open(); 

                string user_login = LoginBox.Text;
                string user_password = PasswordBox.Password;
                string user_db = "_";
                string password_db = "_";

                string check_auth = $"SELECT user_login, user_password FROM users WHERE user_login = '{user_login}' AND user_password = '{user_password}'";

                var cmd = new NpgsqlCommand(check_auth, connection); // executes query on database

                NpgsqlDataReader rdr = cmd.ExecuteReader(); // getting all rows from the users table

                while (rdr.Read())
                {
                    user_db = rdr.GetString(0); // writing user_name from database to string variable
                    password_db = rdr.GetString(1); // writing user_password from database to string variable
                }

                //MessageBox.Show($"{user_db} : {password_db}");

                if (user_login == user_db && user_password == password_db)
                {
                    // if password is correct this animation will be played
                    Storyboard success_login = Resources["SuccessLoginAnimation"] as Storyboard;
                    success_login.Begin();
                }
                else
                {
                    // if password is wrong this animation will be played
                    Storyboard wrong_pass = Resources["WrongPassword"] as Storyboard;
                    wrong_pass.Begin();
                }

                connection.Close();
            }
            catch (Exception message)
            {
                MessageBox.Show(message.ToString());
            }
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
