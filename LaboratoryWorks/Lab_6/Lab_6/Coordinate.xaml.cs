using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Lab_6
{
    /// <summary>
    /// Логика взаимодействия для Coordinate.xaml
    /// </summary>
    public partial class Coordinate : Window
    {
        List<Point> points = new List<Point>();
        public Coordinate()
        {
            InitializeComponent();
        }

        /*
         
         private void pictureBox1_Click(object sender, EventArgs e)
        {
            int x = pictureBox1.PointToClient(Cursor.Position).X;
            int y = pictureBox1.PointToClient(Cursor.Position).Y;
            Point p = new Point(x, y);
            points.Add(p);
            pictureBox1.Refresh();
        }

        private void Form4_Shown(object sender, EventArgs e)
        {
            Bitmap buf = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(buf);
            pictureBox1.Image = buf;
            Pen line = new Pen(Color.Red, 2);
            g.DrawLine(line, 0, pictureBox1.Height / 2, pictureBox1.Width, pictureBox1.Height / 2);
            g.DrawLine(line, pictureBox1.Width / 2, 0, pictureBox1.Width / 2, pictureBox1.Height);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Brush dot = new SolidBrush(Color.Blue);
            Pen circle = new Pen(Color.Red, 2);
            double max = 0;
            foreach (var p in points)
            {
                double k = Math.Sqrt(Math.Pow(p.X - pictureBox1.Width / 2, 2) + Math.Pow(p.Y - pictureBox1.Height / 2, 2));
                if (k > max)
                    max = k;
                e.Graphics.FillRectangle(dot, p.X, p.Y, 2, 2);
            }
            float size = (float)max;
            e.Graphics.DrawEllipse(circle, pictureBox1.Width / 2 - size, pictureBox1.Height / 2 - size, size2, size2);
        }
         */
    }
}
