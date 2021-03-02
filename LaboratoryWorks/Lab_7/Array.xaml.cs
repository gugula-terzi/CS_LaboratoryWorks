using System;
using System.Collections.Generic;
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

namespace Lab_7
{
    /// <summary>
    /// Interaction logic for Array.xaml
    /// </summary>
    public partial class Array : Window
    {
        List<long> arr;
        public Array()
        {
            InitializeComponent();
            datagrid_array.Visibility = Visibility.Hidden;
            arr = new List<long>();
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

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void CreateArrayBtn_Click(object sender, RoutedEventArgs e)
        {
            if (ColumnCountTextBox.Text == "")
            {
                MessageBox.Show("You didn't enter the array size!",
                                "Error",
                                MessageBoxButton.OK,
                                MessageBoxImage.Error);
            }
            else
            {
                arr.Clear();
                // Creating array and fills it with random numbers
                int array_lenght = Convert.ToInt32(ColumnCountTextBox.Text);
                Random random = new Random();

                DataTable info_table = new DataTable();
                string[] cell = new string[array_lenght];
                for (int i = 0; i < 1; i++)
                {
                    for (int j = 0; j < array_lenght; j++)
                    {
                        cell[j] = random.Next(-100, 100).ToString();
                        arr.Add(Convert.ToInt64(cell[j]));
                        if (i == 0) info_table.Columns.Add(j.ToString());
                    }
                    info_table.Rows.Add(cell);
                }

                datagrid_array.ItemsSource = info_table.DefaultView;
                datagrid_array.Visibility = Visibility.Visible;
            }

        }

        private void DeleteArrayElementBtn_Click(object sender, RoutedEventArgs e)
        {
            if (arr.Count == 0)
                return;
            else
            {
                int delete_element = Convert.ToInt32(DeleteElementTextBox.Text);

                for (int i = 0; i < arr.Count; i++)
                {
                    if (arr[i] == (long)delete_element)
                    {
                        arr.RemoveAt(i);
                    }

                }

                DataTable info_table = new DataTable();
                string[] cell = new string[arr.Count];
                for (int i = 0; i < 1; i++)
                {
                    for (int j = 0; j < arr.Count; j++)
                    {
                        cell[j] = arr[j].ToString();
                        if (i == 0) info_table.Columns.Add(j.ToString());
                    }
                    info_table.Rows.Add(cell);
                }

                datagrid_array.ItemsSource = info_table.DefaultView;
            }
        }

        private void FindEvenOddNumbersBtn_Click(object sender, RoutedEventArgs e)
        {
            if (arr.Count == 0)
                return;
            else
            {
                // Counting even and odd numbers
                int OddNumbers = 0;
                int EvenNumbers = 0;
                for (int i = 0; i < arr.Count; i++)
                {
                    if (arr[i] % 2 == 0)
                        EvenNumbers++;
                    else
                        OddNumbers++;
                }

                EvenCountTextBlock.Text = Convert.ToString(EvenNumbers);
                OddCountTextBlock.Text = Convert.ToString(OddNumbers);
            }
        }

        private void FindMaxBtn_Click(object sender, RoutedEventArgs e)
        {
            // Finding the maximum number
            if (arr.Count == 0)
                return;
            else
            {
                long max_num = arr[0];
                for (int i = 0; i < arr.Count; i++)
                {
                    if (arr[i] > max_num)
                        max_num = arr[i];
                }

                MaxNumTextBlock.Text = Convert.ToString(max_num);
            }
        }

        private void CalcSumBtn_Click(object sender, RoutedEventArgs e)
        {
            if (arr.Count == 0)
                return;
            else
            {
                long sum_result = 1;

                // The multiplication of all elements in the array
                for (int i = 0; i < arr.Count; i++)
                {
                    sum_result *= arr[i];
                }

                SumTextBlock.Text = Convert.ToString(sum_result);
            }
        }

        private void SortArrayBtn_Click(object sender, RoutedEventArgs e)
        {
            if (arr.Count == 0)
                return;
            else
            {
                arr.Sort();

                DataTable sorted_table = new DataTable();
                string[] cell = new string[arr.Count];
                for (int i = 0; i < 1; i++)
                {
                    for (int j = 0; j < arr.Count; j++)
                    {
                        cell[j] = arr[j].ToString();
                        if (i == 0) sorted_table.Columns.Add(j.ToString());
                    }
                    sorted_table.Rows.Add(cell);
                }

                datagrid_array.ItemsSource = sorted_table.DefaultView;
            }
        }

        private void SortArrayReverseBtn_Click(object sender, RoutedEventArgs e)
        {
            if (arr.Count == 0)
                return;
            else
            {
                arr.Sort();
                arr.Reverse();

                DataTable sorted_table = new DataTable();
                string[] cell = new string[arr.Count];
                for (int i = 0; i < 1; i++)
                {
                    for (int j = 0; j < arr.Count; j++)
                    {
                        cell[j] = arr[j].ToString();
                        if (i == 0) sorted_table.Columns.Add(j.ToString());
                    }
                    sorted_table.Rows.Add(cell);
                }

                datagrid_array.ItemsSource = sorted_table.DefaultView;
            }
        }
    }
}
