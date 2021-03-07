using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using LiveCharts;
using LiveCharts.Wpf;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Text.RegularExpressions;
using SeriesCollection = LiveCharts.SeriesCollection;
using Axis = LiveCharts.Wpf.Axis;

namespace Lab_8
{
    /// <summary>
    /// Interaction logic for Chart.xaml
    /// </summary>
    public partial class Chart : Window
    {
        List<string> dates;
        ChartValues<int> temperature;
        public Chart(List<List<string>> info)
        {
            InitializeComponent();

            dates = new List<string>();
            temperature = new ChartValues<int>();

            for (int i = 0; i < info.Count; i++)
            {
                int value;
                int.TryParse(string.Join("", info[i][1].Where(c => char.IsDigit(c))), out value);
                temperature.Add(value);

                dates.Add(info[i][0]);
            }
        }

        public ChartValues<int> temperatures { get; set; }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            SeriesCollection series = new SeriesCollection();

            new_chart.AxisX.Clear();
            new_chart.AxisX.Add(new Axis() 
            {
                Title = "Dates",
                Labels = dates
            });

            LineSeries line = new LineSeries();
            line.Title = "Temperature °C";
            line.Values = temperature;

            series.Add(line);
            new_chart.Series = series;
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
    }
}
