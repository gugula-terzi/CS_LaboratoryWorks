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
        DataTable table;
        static string connectionString = ConfigurationManager.ConnectionStrings["HerokuDB"].ConnectionString;

        public StoreWindow()
        {
            InitializeComponent();
            SaveBtn.Visibility = Visibility.Hidden;
            CategoryComboBox.IsEnabled = false;
        }


        //public DataTable LoadTable(string sql_query, string ConnectionString)
        //{

        //    using (MySqlConnection connection = new MySqlConnection(ConnectionString))
        //    {
        //        try
        //        {
        //            connection.Open();

        //            MySqlDataAdapter adapter = new MySqlDataAdapter(sql_query, connection);
        //            DataTable dataTable = new DataTable();



        //            adapter.Fill(dataTable);
        //            dataTable.TableName = TableName;

        //            return dataTable;
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.Message);
        //        }
        //        finally
        //        {
        //            connection.Close();
        //        }
        //    }
        //    return null;
        //}

        public DataTable GetInfoFromTable(string table_name, List<string> col_names)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM " + table_name, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataTable.TableName = table_name;

                    return dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return null;
        }

        //private void UsersTableBtn_Click(object sender, RoutedEventArgs e)
        //{
        //    List<string> col_names = new List<string>() { "ID", "Login", "Hash", "Salt", "Name", "Last name", "Email", "Role", "Created at", "Last login" };
        //    string get_all_info = "SELECT user_id AS \"ID\", user_login AS \"Login\", password_hash AS \"Hash\", password_salt AS \"Salt\", user_name AS \"Name\", user_lastname AS \"Last name\", email AS \"Email\", user_role AS \"Role\", created_at AS \"Created at\", last_login AS \"Last login\" FROM users;";
        //    table = GetInfoFromTable(get_all_info, col_names);
        //    InfoGrid.ItemsSource = table.DefaultView;
        //    CategoryComboBox.ItemsSource = col_names;
        //    CategoryComboBox.IsEnabled = true;
        //}

        private void InfoGrid_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            e.Row.Header = (e.Row.GetIndex()).ToString();
        }

        //private void RolesTableBtn_Click(object sender, RoutedEventArgs e)
        //{
        //    List<string> col_names = new List<string>() { "ID", "Role type" };
        //    string get_all_info = "SELECT role_id, role_type FROM roles;";
        //    table = GetInfoFromTable(get_all_info, col_names);
        //    InfoGrid.ItemsSource = table.DefaultView;
        //    CategoryComboBox.ItemsSource = col_names;
        //    CategoryComboBox.IsEnabled = true;
        //}

        private void GraphicsCardTableBtn_Click(object sender, RoutedEventArgs e)
        {
            List<string> col_names = new List<string>() { "ID", "Name", "VRAM Type", "Capacity", "Price" };
            //string get_all_info = "SELECT product_id, product_name, vram_type, vram_capacity, price FROM graphics_card;";
            table = GetInfoFromTable("graphics_card", col_names);
            InfoGrid.ItemsSource = table.DefaultView;
            CategoryComboBox.ItemsSource = col_names;
            CategoryComboBox.IsEnabled = true;
        }

        private void ProcessorTableBtn_Click(object sender, RoutedEventArgs e)
        {
            List<string> col_names = new List<string>() { "ID", "Name", "Socket", "Cores", "Threads", "Frequency GHz", "Price" };
            //string get_all_info = "SELECT product_id, product_name, cpu_socket, cpu_cores, threads, cpu_speed, price FROM processor;";
            table = GetInfoFromTable("processor", col_names);
            InfoGrid.ItemsSource = table.DefaultView;
            CategoryComboBox.ItemsSource = col_names;
            CategoryComboBox.IsEnabled = true;
        }

        private void RAMTableBtn_Click(object sender, RoutedEventArgs e)
        {
            List<string> col_names = new List<string>() { "ID", "Name", "DDR Type", "Frequency MHz", "Capacity", "Price" };
            //string get_all_info = "SELECT product_id, product_name , ddr_type, frequency_MHz, capacity_gb, price FROM ram;";
            table = GetInfoFromTable("ram", col_names);
            InfoGrid.ItemsSource = table.DefaultView;
            CategoryComboBox.ItemsSource = col_names;
            CategoryComboBox.IsEnabled = true;
        }

        private void NavPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        public void Save()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand("SELECT * FROM " + table.TableName, connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(adapter);

                    
                    adapter.UpdateCommand = commandBuilder.GetUpdateCommand();
                    adapter.DeleteCommand = commandBuilder.GetDeleteCommand();
                    adapter.Update(table);
                    table.AcceptChanges();
                }
                catch (Exception ex)
                {
                    if (ex.ToString().Contains("Duplicate entry"))
                    {
                        MessageWindow message = new MessageWindow("This id is already exists", "error");
                        message.Show();
                    }    
                    else
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void SearchBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            Save();
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            SaveBtn.Visibility = Visibility.Visible;
            InfoGrid.IsReadOnly = false;
        }

    }
}
