using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile(@"pictures\gorbusha.jpg");
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile(@"pictures\ersh.jpg");
        }

        private void label9_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile(@"pictures\karasj.jpg");
        }

        private void label13_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile(@"pictures\karp.jpg");
        }

        private void label12_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile(@"pictures\lesch.jpg");
        }

        private void label11_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile(@"pictures\okunj.jpg");
        }

        private void label10_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile(@"pictures\sazan.jpg");
        }
    }
}
