using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static bool IsAnagram(string s1, string s2)
        {
            if (s1.Length != s2.Length || s1.Length < 2 || s2.Length < 2 || s1.ToLower() == s2.ToLower())
                return false;
            if (s1.Length != s2.Length)
                return false;
            var s1Array = s1.ToLower().ToCharArray();
            var s2Array = s2.ToLower().ToCharArray();

            Array.Sort(s1Array);
            Array.Sort(s2Array);

            s1 = new string(s1Array);
            s2 = new string(s2Array);

            return s1 == s2;
        }

        private void anagramma_Click(object sender, EventArgs e)
        {
            string anagram_output = "";
            string[] text = textBox1.Text.Split(new[] { ' ', '.', '?', '!', ',' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < text.Length; i++)
            {
                for (int j = i; j < text.Length; j++)
                {
                    if (IsAnagram(text[i], text[j]) && i != j)
                    {
                        anagram_output += text[i] + " – " + text[j] + "\n";
                    }
                }
            }
            if (anagram_output.Length < 1)
                MessageBox.Show("Анаграмм не найдено!", "Анаграммы");
            else
                MessageBox.Show(anagram_output, "Анаграммы");
        }

        private void encode_Click(object sender, EventArgs e)
        {
            var str = new StringBuilder(textBox1.Text);
            for (int i = 0; i < str.Length; i++)
            {
                str[i] = Convert.ToChar(str[i] + i % 3);
            }
            textBox2.Text = str.ToString();
        }

        private void decode_Click(object sender, EventArgs e)
        {
            var str = new StringBuilder(textBox2.Text);
            for (int i = 0; i < str.Length; i++)
            {
                str[i] = Convert.ToChar(str[i] - i % 3);
            }
            textBox2.Text = str.ToString();
        }

        private void countButton_Click(object sender, EventArgs e)
        {
            var text = textBox1.Text.Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            var number_of_sentence = text.Length;
            count.Text = Convert.ToString(number_of_sentence);
        }

        private void change_Click(object sender, EventArgs e)
        {
            string search_word = textBox3.Text;
            string replace_word = textBox4.Text;

            StringBuilder text = new StringBuilder(textBox1.Text);
            text.Replace(search_word, replace_word);
            textBox2.Text = Convert.ToString(text);
        }
    }   
}
