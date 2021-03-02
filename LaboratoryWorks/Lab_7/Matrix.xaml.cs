using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
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
    /// Interaction logic for Matrix.xaml
    /// </summary>
    public partial class Matrix : Window
    {
        List<List<int>> matrix;
        public Matrix()
        {
            InitializeComponent();
            MatrixGrid.Visibility = Visibility.Hidden;
            matrix = new List<List<int>>();
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

        private void CreateMatrixBtn_Click(object sender, RoutedEventArgs e)
        {
            if (RowsCountTextBox.Text == "" || ColumnsCountTextBox.Text == "")
                MessageBox.Show("You didn't enter the array size!",
                                "Error",
                                MessageBoxButton.OK,
                                MessageBoxImage.Error);
            else
            {
                matrix.Clear();

                int rows = Convert.ToInt32(RowsCountTextBox.Text);
                int columns = Convert.ToInt32(ColumnsCountTextBox.Text);

                Random random = new Random();

                DataTable info_table = new DataTable();
                string[] cell = new string[columns];

                for (int i = 0; i < rows; i++)
                {
                    matrix.Add(new List<int>());
                    for (int j = 0; j < columns; j++)
                    {
                        matrix[i].Add(random.Next(-100, 100));
                        cell[j] = matrix[i][j].ToString();
                        if (i == 0) info_table.Columns.Add(j.ToString());
                    }
                    info_table.Rows.Add(cell);
                }

                MatrixGrid.ItemsSource = info_table.DefaultView;
                MatrixGrid.Visibility = Visibility.Visible;
            }
        }

        private void CalcSumBtn_Click(object sender, RoutedEventArgs e)
        {
            if (matrix.Count == 0)
                return;
            else
            {
                long sum_result = 0;

                for (int i = 0; i < matrix.Count; i++)
                {
                    sum_result += (long)matrix[i].ToArray().Sum();
                }

                SumTextBlock.Text = sum_result.ToString();
            }
        }

        private void FindMinimumBtn_Click(object sender, RoutedEventArgs e)
        {
            if (matrix.Count == 0)
                return;
            else
            {
                /* Finding minimum numbers in each column of matrix */
                int[] min_array = new int[matrix[0].Count];
                string message = "";
                int min = 0;

                for (int j = 0; j < matrix[0].Count; j++)
                {
                    min = matrix[0][j];
                    for (int i = 0; i < matrix.Count; i++)
                    {
                        if (min > matrix[i][j])
                        {

                            min = matrix[i][j];
                        }
                        min_array[j] = min;
                    }
                    message += $"column #{j}: {min}\n";
                }

                MessageBox.Show($"{message}");
            }
        }

        private void ReadMatrixBtn_Click(object sender, RoutedEventArgs e)
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
                int[] row = lines[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(Int32.Parse).ToArray();

                matrix.Add(new List<int>(row));
            }

            /* Checking information from file
             
            string message = "";
            for (int i = 0; i < matrix.Count; i++)
            {
                for (int j = 0; j < matrix[0].Count; j++)
                {
                    message += $"{matrix[i][j]}\t";
                }
                message += "\n";
            }

            MessageBox.Show(message);
             */

            DataTable info_table = new DataTable();
            string[] cell = new string[matrix[0].Count];

            for (int i = 0; i < matrix.Count; i++)
            {
                for (int j = 0; j < matrix[0].Count; j++)
                {
                    cell[j] = matrix[i][j].ToString();
                    if (i == 0) info_table.Columns.Add(j.ToString());
                }
                info_table.Rows.Add(cell);
            }

            MatrixGrid.ItemsSource = info_table.DefaultView;
            MatrixGrid.Visibility = Visibility.Visible;
        }

        private void AnalyzeRowBtn_Click(object sender, RoutedEventArgs e)
        {
            if (matrix.Count == 0)
                return;
            else
            {
                int zeros = 0, positive_numbers = 0, negative_numbers = 0;

                string message = "";
                for (int i = 0; i < matrix.Count; i++)
                {
                    for (int j = 0; j < matrix[0].Count; j++)
                    {
                        if (matrix[i][j] == 0)
                            zeros++;
                        if (matrix[i][j] > 0)
                            positive_numbers++;
                        if (matrix[i][j] < 0)
                            negative_numbers++;
                    }
                    message += $"row #{i}: Zeros = {zeros}; Positive numbers = {positive_numbers}; Negative numbers = {negative_numbers}\n";
                    zeros = 0;
                    positive_numbers = 0;
                    negative_numbers = 0;
                }

                MessageBox.Show(message);
            }
        }

        private void DeleteRowBtn_Click(object sender, RoutedEventArgs e)
        {
            if (matrix.Count == 0)
                return;
            else
            {
                int delete_col = Convert.ToInt32(DeleteRowTextBox.Text);
                List<List<int>> minus_col_array = new List<List<int>>();

                for (int i = 0; i < matrix.Count; i++)
                {
                    minus_col_array.Add(new List<int>());
                    for (int j = 0; j < matrix[i].Count; j++)
                    {
                        if (j == delete_col)
                            continue;
                        else
                            minus_col_array[i].Add(matrix[i][j]);
                    }
                }

                matrix.Clear();

                /*
                string message = "";
                for (int i = 0; i < minus_col_array.Count; i++)
                {
                    for (int j = 0; j < minus_col_array[0].Count; j++)
                    {
                        message += $"{minus_col_array[i][j]}\t";
                    }
                    message += "\n";
                }


                MessageBox.Show(message);
                */

                DataTable info_table = new DataTable();
                string[] cell = new string[minus_col_array[0].Count];

                for (int i = 0; i < minus_col_array.Count; i++)
                {
                    matrix.Add(new List<int>());
                    for (int j = 0; j < minus_col_array[i].Count; j++)
                    {
                        matrix[i].Add(minus_col_array[i][j]);
                        cell[j] = minus_col_array[i][j].ToString();
                        if (i == 0) info_table.Columns.Add(j.ToString());
                    }
                    info_table.Rows.Add(cell);
                }

                MatrixGrid.ItemsSource = info_table.DefaultView;
            }
        }

        private void AddRowBtn_Click(object sender, RoutedEventArgs e)
        {
            if (matrix.Count == 0)
                return;
            else
            {
                Random random = new Random();
                List<int> new_row = new List<int>();

                for (int i = 0; i < matrix[0].Count; i++)
                    new_row.Add(random.Next(-100, 100));

                matrix.Add(new_row);

                DataTable info_table = new DataTable();
                string[] cell = new string[matrix[0].Count];

                for (int i = 0; i < matrix.Count; i++)
                {
                    for (int j = 0; j < matrix[i].Count; j++)
                    {
                        cell[j] = matrix[i][j].ToString();
                        if (i == 0) info_table.Columns.Add(j.ToString());
                    }
                    info_table.Rows.Add(cell);
                }

                MatrixGrid.ItemsSource = info_table.DefaultView;
            }
        }

        private void SortColAscendingBtn_Click(object sender, RoutedEventArgs e)
        {
            if (matrix.Count == 0)
                return;
            else
            {
                for (int j = 0; j < matrix[0].Count; j++)
                {
                    for (int i = 0; i < matrix.Count; i++)
                    {
                        for (int z = i; z < matrix.Count; z++)
                        {
                            if (matrix[z][j] < matrix[i][j])
                            {
                                int temp = matrix[z][j];
                                matrix[z][j] = matrix[i][j];
                                matrix[i][j] = temp;
                            }
                        }
                    }
                }

                DataTable info_table = new DataTable();
                string[] cell = new string[matrix[0].Count];

                for (int i = 0; i < matrix.Count; i++)
                {
                    for (int j = 0; j < matrix[0].Count; j++)
                    {
                        cell[j] = matrix[i][j].ToString();
                        if (i == 0) info_table.Columns.Add(j.ToString());
                    }
                    info_table.Rows.Add(cell);
                }

                MatrixGrid.ItemsSource = info_table.DefaultView;
            }
        }

        private void SortColDescendingBtn_Click(object sender, RoutedEventArgs e)
        {
            if (matrix.Count == 0)
                return;
            else
            {
                for (int j = 0; j < matrix[0].Count; j++)
                {
                    for (int i = 0; i < matrix.Count; i++)
                    {
                        for (int z = i; z < matrix.Count; z++)
                        {
                            if (matrix[z][j] > matrix[i][j])
                            {
                                int temp = matrix[z][j];
                                matrix[z][j] = matrix[i][j];
                                matrix[i][j] = temp;
                            }
                        }
                    }
                }

                DataTable info_table = new DataTable();
                string[] cell = new string[matrix[0].Count];

                for (int i = 0; i < matrix.Count; i++)
                {
                    for (int j = 0; j < matrix[0].Count; j++)
                    {
                        cell[j] = matrix[i][j].ToString();
                        if (i == 0) info_table.Columns.Add(j.ToString());
                    }
                    info_table.Rows.Add(cell);
                }

                MatrixGrid.ItemsSource = info_table.DefaultView;
            }
        }

        private void Button_Click()
        {

        }
    }
}
