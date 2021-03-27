using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
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

namespace LoginForm
{
    /// <summary>
    /// Interaction logic for StoreWindow.xaml
    /// </summary>
    public partial class StoreWindow : Window
    {
        public StoreWindow()
        {
            InitializeComponent();
        }

        

        public void GetInfoFromTable(string sql_query, List<string> column_names)
        {
            DataTable dt = new DataTable();

            var connectionString = ConfigurationManager.ConnectionStrings["HerokuDB"].ConnectionString; // getting connection string from "App.config" file
            

            MySqlConnection connection = new MySqlConnection(connectionString); // creating connection with database
            connection.Open();

            MySqlCommand createCommand = new MySqlCommand(sql_query, connection);
            createCommand.ExecuteNonQuery();

            MySqlDataAdapter dataAdp = new MySqlDataAdapter(createCommand);
            dataAdp.Fill(dt);

            for (int i = 0; i < dt.Columns.Count; i++)
            {
                dt.Columns[i].ColumnName = column_names[i];
            }

            InfoGrid.ItemsSource = dt.DefaultView;
            connection.Close();
        }

        private void UsersTableBtn_Click(object sender, RoutedEventArgs e)
        {
            List<string> col_names = new List<string>() { "ID", "Login", "Hash", "Salt", "Name", "Last name", "Email", "Role", "Created at", "Last login" };
            string get_all_info = "SELECT user_id, user_login, password_hash, password_salt, user_name, user_lastname, email, user_role, created_at, last_login FROM users;";
            GetInfoFromTable(get_all_info, col_names);            
        }

        private void InfoGrid_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            e.Row.Header = (e.Row.GetIndex()).ToString();
        }

        private void RolesTableBtn_Click(object sender, RoutedEventArgs e)
        {
            List<string> col_names = new List<string>() { "ID", "Role type" };
            string get_all_info = "SELECT role_id, role_type FROM roles;";
            GetInfoFromTable(get_all_info, col_names);
        }

        private void GraphicsCardTableBtn_Click(object sender, RoutedEventArgs e)
        {
            List<string> col_names = new List<string>() { "ID", "Name", "VRAM Type", "Capacity", "Price" };
            string get_all_info = "SELECT product_id, product_name, vram_type, vram_capacity, price FROM graphics_card;";
            GetInfoFromTable(get_all_info, col_names);
        }

        private void ProcessorTableBtn_Click(object sender, RoutedEventArgs e)
        {
            List<string> col_names = new List<string>() { "ID", "Name", "Socket", "Cores", "Threads", "Frequency GHz", "Price" };
            string get_all_info = "SELECT product_id, product_name, cpu_socket, cpu_cores, threads, cpu_speed, price FROM processor;";
            GetInfoFromTable(get_all_info, col_names);
        }

        private void RAMTableBtn_Click(object sender, RoutedEventArgs e)
        {
            List<string> col_names = new List<string>() { "ID", "Name", "DDR Type", "Frequency MHz", "Capacity", "Price" };
            string get_all_info = "SELECT product_id, product_name, ddr_type, frequency_MHz, capacity_gb, price FROM ram;";
            GetInfoFromTable(get_all_info, col_names);
        }
    }
}
