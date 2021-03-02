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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab_6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Point> CirclePoints;
        public MainWindow()
        {
            InitializeComponent();
            CirclePoints = new List<Point>();
        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void MaximizeBtn_Click(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Maximized)
                WindowState = WindowState.Normal;
            else
                WindowState = WindowState.Maximized;
        }

        private void MinimizeBtn_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void NavPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void DrawRainBtn_Click(object sender, RoutedEventArgs e)
        {
            coord.Opacity = 0;
            coordCanvas.Opacity = 0;
            Storyboard draw_rain = this.Resources["DrawRain"] as Storyboard;
            draw_rain.Begin();
        }

        private void Canvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Canvas c = sender as Canvas;
            Point pos = e.GetPosition(c);
            AddPoint(pos);
        }

        private void AddPoint(Point position)
        {
            CirclePoints.Add(position);

            Ellipse e = new Ellipse();
            e.Height = 5;
            e.Width = 5;
            e.Fill = Brushes.White;
            coordCanvas.Children.Add(e);
            Canvas.SetLeft(e, position.X - 2.5);
            Canvas.SetTop(e, position.Y - 2.5);

            ChangeEllipse();
        }

        private void ChangeEllipse()
        {
            double centerX = coordCanvas.Width / 2;
            double centerY = coordCanvas.Height / 2;
            double max = 0;

            foreach (var point in CirclePoints)
            {
                double distance = Math.Sqrt(Math.Pow(point.X - centerX, 2) + Math.Pow(point.Y - centerY, 2));
                if (max < distance)
                {
                    max = distance;
                }
            }

            ellips.Width = max * 2;
            ellips.Height = max * 2;
            Canvas.SetTop(ellips, centerY - max);
            Canvas.SetLeft(ellips, centerX - max);
        }

        private void EnableFieldBtn_Click(object sender, RoutedEventArgs e)
        {
            coord.Opacity = 1;
            coordCanvas.Opacity = 0.5;
        }

        private void DrawSunBtn_Click(object sender, RoutedEventArgs e)
        {
            coord.Opacity = 0;
            coordCanvas.Opacity = 0;
            Storyboard draw_sun = this.Resources["DrawSun"] as Storyboard;
            draw_sun.Begin();
        }
    }
}
