using LiveCharts;
using LiveCharts.Wpf;
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

namespace Lab_10
{
    /// <summary>
    /// Interaction logic for ResultTableWindow.xaml
    /// </summary>
    public partial class ResultTableWindow : Window
    {
        public ResultTableWindow()
        {
            InitializeComponent();

            List<List<string>> matrix = new List<List<string>>();
            labels = new List<string>();
            ChartValues<double> correct = new ChartValues<double>();
            ChartValues<double> wrong = new ChartValues<double>();

            string file_path = "score.txt";

            string[] lines = File.ReadAllLines(file_path);
            for (int i = 0; i < lines.Length; i++)
            {
                string[] row = lines[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                matrix.Add(new List<string>(row));
            }

            for (int i = 0; i < matrix.Count; i++)
            {
                // getting all users from file
                labels.Add(matrix[i][1]);
            }

            for (int i = 0; i < matrix.Count; i++)
            {
                // getting all correct scores
                correct.Add(Convert.ToDouble(matrix[i][2]));
            }

            for (int i = 0; i < matrix.Count; i++)
            {
                // getting all wrong scores
                wrong.Add(Convert.ToDouble(matrix[i][3]));
            }

            SeriesCollection = new SeriesCollection
            {
                new RowSeries
                {
                    Title = "Correct: ",
                    Values = correct
                }
            };

            //adding series will update and animate the chart automatically
            SeriesCollection.Add(new RowSeries
            {
                Title = "Wrong: ",
                Values = wrong
            });

            //Labels = new[] { "Maria", "Susan", "Charles", "Frida" };
            Labels = labels.ToArray();
            Formatter = value => value.ToString("N");

            LiveChart.AxisY[0].Separator.StrokeThickness = 0;
            DataContext = this;
        }

        public SeriesCollection SeriesCollection { get; set; }
        public string[] Labels { get; set; }
        public List<string> labels { get; set; }
        public Func<double, string> Formatter { get; set; }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }
    }
}
