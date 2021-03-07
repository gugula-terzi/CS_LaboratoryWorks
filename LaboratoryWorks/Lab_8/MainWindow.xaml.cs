using BenchmarkDotNet.Exporters.Csv;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
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

namespace Lab_8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        List<List<string>> matrix;
        public static RoutedCommand MenuRoutedCommand = new RoutedCommand();

        public MainWindow()
        {
            InitializeComponent();
            matrix = new List<List<string>>();
            WeatherInfo.Visibility = Visibility.Hidden;
        }

        

        private void NavPanel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void MinimizeBtn_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void MaximizeBtn_Click(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Normal)
                WindowState = WindowState.Maximized;
            else
                WindowState = WindowState.Normal;
        }

        private void OpenMenuItem_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();

            string file_path = "";

            if (file.ShowDialog() == true)
                file_path = file.FileName;
            else
                return;

            matrix.Clear();
            string[] lines = File.ReadAllLines(file_path);
            for (int i = 0; i < lines.Length; i++)
            {
                string[] row = lines[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                matrix.Add(new List<string>(row));
            }

            DataTable info_table = new DataTable();
            string[] col_names = { "Date", "Temperature", "Humidity", "Weather" };
            string[] cell = new string[matrix[0].Count];

            for (int i = 0; i < matrix.Count; i++)
            {
                for (int j = 0; j < matrix[0].Count; j++)
                {
                    cell[j] = matrix[i][j].ToString();
                    if (i == 0) info_table.Columns.Add(col_names[j]);
                }
                info_table.Rows.Add(cell);
            }

            WeatherInfo.ItemsSource = info_table.DefaultView;
            WeatherInfo.Visibility = Visibility.Visible;
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            if (matrix.Count == 0)
                return;
            else if (DateTextBox.Text == "" || TemperatureTextBox.Text == "" || HumidityTextBox.Text == "" || WeatherTypeTextBox.Text == "")
                MessageBox.Show("You didn't enter anything!",
                                "Error",
                                MessageBoxButton.OK,
                                MessageBoxImage.Error);
            else
            {
                string[] new_row = { DateTextBox.Text, TemperatureTextBox.Text, HumidityTextBox.Text + "%", WeatherTypeTextBox.Text };

                matrix.Add(new List<string>(new_row));

                DataTable info_table = new DataTable();
                string[] col_names = { "Date", "Temperature", "Humidity", "Weather" };
                string[] cell = new string[matrix[0].Count];

                for (int i = 0; i < matrix.Count; i++)
                {
                    for (int j = 0; j < matrix[0].Count; j++)
                    {
                        cell[j] = matrix[i][j].ToString();
                        if (i == 0) info_table.Columns.Add(col_names[j]);
                    }
                    info_table.Rows.Add(cell);
                }

                WeatherInfo.ItemsSource = info_table.DefaultView;
            }
        }

        private void DateTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9.]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void TemperatureTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9-+]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void HumidityTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void SaveMenuItem_Click(object sender, RoutedEventArgs e)
        {
            if (matrix.Count == 0)
                return;
            else
            {
                matrix.Clear();

                DataTable info_table = new DataTable();
                info_table = ((DataView)WeatherInfo.ItemsSource).ToTable();

                for (int i = 0; i < info_table.Rows.Count; i++)
                {
                    matrix.Add(new List<string>());
                    for (int j = 0; j < info_table.Columns.Count; j++)
                    {
                        matrix[i].Add((string)info_table.Rows[i][j]);
                    }
                }

                SaveFileDialog saveFileDialog1 = new SaveFileDialog();


                if (saveFileDialog1.ShowDialog() == true)
                {
                    using (StreamWriter sw = new StreamWriter(saveFileDialog1.OpenFile(), System.Text.Encoding.Default))
                    {
                        for (int i = 0; i < matrix.Count; i++)
                        {
                            for (int j = 0; j < matrix[0].Count; j++)
                            {
                                sw.Write(matrix[i][j] + " ");
                            }
                            sw.Write("\n");
                        }
                        sw.Close();
                    }
                }
            }
        }

        private void NoEditMenuItem_Click(object sender, RoutedEventArgs e)
        {
            WeatherInfo.IsReadOnly = true;
            AddBtn.IsEnabled = false;
        }

        private void EditMenuItem_Click(object sender, RoutedEventArgs e)
        {
            WeatherInfo.IsReadOnly = false;
            AddBtn.IsEnabled = true;
        }

        private void ShowChartMenuItem_Click(object sender, RoutedEventArgs e)
        {
            if (matrix.Count == 0)
                return;
            else
            {
                matrix.Clear();

                DataTable info_table = new DataTable();
                info_table = ((DataView)WeatherInfo.ItemsSource).ToTable();

                for (int i = 0; i < info_table.Rows.Count; i++)
                {
                    matrix.Add(new List<string>());
                    for (int j = 0; j < info_table.Columns.Count; j++)
                    {
                        matrix[i].Add((string)info_table.Rows[i][j]);
                    }
                }

                List<List<string>> data = new List<List<string>>();

                for (int i = 0; i < matrix.Count; i++)
                {
                    data.Add(new List<string>());
                    for (int j = 0; j < matrix[0].Count; j++)
                    {
                        if (j == 0)
                            data[i].Add(matrix[i][0]);
                        if (j == 1)
                            data[i].Add(matrix[i][1]);
                    }
                }

                Chart chart = new Chart(data);
                chart.ShowDialog();
            }
        }

        private void OpenCommandBinding_Executed(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

    }
}
