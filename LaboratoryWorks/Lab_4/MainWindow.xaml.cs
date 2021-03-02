using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab_4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MinimizeBtn_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
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

        private void NavPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
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

        private void CountSentencesTextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var translateArraySourceTexts = MainTextBox.Text.Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            var count = translateArraySourceTexts.Length;
            DescriptionLabel.Content = "Number of sentences: ";
            NumberOfSentenceLabel.Text = Convert.ToString(count);
        }

        private void AnagramBtn_Click(object sender, RoutedEventArgs e)
        {
            string anagram_output = "";
            string[] text = MainTextBox.Text.Split(new[] { ' ', '.', '?', '!', ',' }, StringSplitOptions.RemoveEmptyEntries);
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
                MessageBox.Show("No anagrams found!", "Anagrams");
            else
                MessageBox.Show(anagram_output, "Anagrams");
        }

        private void ReplaceBtn_Click(object sender, RoutedEventArgs e)
        {
            string search_word = SearchWordBox.Text;
            string replace_word = ReplaceWithBox.Text;

            StringBuilder text = new StringBuilder(MainTextBox.Text);
            text.Replace(search_word, replace_word);
            MainTextBox.Text = Convert.ToString(text);
        }

        private void CapitalizeBtn_Click(object sender, RoutedEventArgs e)
        {
            var str = new StringBuilder(MainTextBox.Text);
            if (str.Length == 0)
            {
                MessageBox.Show("You didn't entered anything");
                return;
            }
            str[0] = char.ToUpper(str[0]);
            for (int i = 0; i < str.Length; i++)
            {

                if ((str[i] == '.' || str[i] == '!' || str[i] == '?') && i < str.Length - 1)
                {
                    str[i + 2] = char.ToUpper(str[i + 2]);
                }
            }
            MainTextBox.Text = str.ToString();
        }

        private void EncryptBtn_Click(object sender, RoutedEventArgs e)
        {
            var str = new StringBuilder(MainTextBox.Text);
            for (int i = 0; i < str.Length; i++)
            {
                str[i] = Convert.ToChar(str[i] + i % 3);
            }
            MainTextBox.Text = str.ToString();
        }

        private void DecipherBtn_Click(object sender, RoutedEventArgs e)
        {
            var str = new StringBuilder(MainTextBox.Text);
            for (int i = 0; i < str.Length; i++)
            {
                str[i] = Convert.ToChar(str[i] - i % 3);
            }
            MainTextBox.Text = str.ToString();
        }

        private void ResolveTextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                string str = MainTextBox.Text + ' ';
                int signIndex = 0;
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == '+' || str[i] == '-' || str[i] == '*' || str[i] == '/')
                    {
                        signIndex = i;
                    }
                }
                if (signIndex == 0)
                {
                    MessageBox.Show("Arithmetic sign not found");
                }
                else
                {
                    string n1 = str.Substring(0, signIndex);
                    string n2 = str.Substring(signIndex + 1);

                    double d1 = Convert.ToDouble(n1);
                    double d2 = Convert.ToDouble(n2);
                    double result;
                    switch (str[signIndex])
                    {
                        case '+': result = d1 + d2; break;
                        case '-': result = d1 - d2; break;
                        case '*': result = d1 * d2; break;
                        case '/': result = d1 / d2; break;
                        default: result = d1 + d2; break;
                    }
                    result = Math.Round(result * 1000) / 1000;
                    DescriptionLabel.Content = "Result = ";
                    NumberOfSentenceLabel.Text = result.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Wrong format!");
            }
        }
    }
}
