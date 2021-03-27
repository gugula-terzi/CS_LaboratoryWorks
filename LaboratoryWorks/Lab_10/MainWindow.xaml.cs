using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Lab_10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<List<string>> fruits_array = new List<List<string>>() { new List<string>{ "apple", "Images\\Fruits\\apple.png" },
                                                                     new List<string>{ "orange", "Images\\Fruits\\orange.png" },
                                                                     new List<string>{ "pear", "Images\\Fruits\\pear.png" },
                                                                     new List<string>{ "pineapple", "Images\\Fruits\\pineapple.png" },
                                                                     new List<string>{ "lime", "Images\\Fruits\\lime.png" },
                                                                     new List<string>{ "mango", "Images\\Fruits\\mango.png" },
                                                                     new List<string>{ "lemon", "Images\\Fruits\\lemon.png" },
                                                                     new List<string>{ "peach", "Images\\Fruits\\peach.png" },
                                                                     new List<string>{ "kiwi", "Images\\Fruits\\kiwi.png" },
                                                                     new List<string>{ "banana", "Images\\Fruits\\banana.png" } };

        List<List<string>> clothes_array = new List<List<string>>() { new List<string>{ "coat", "Images\\Clothes\\coat.png" },
                                                                        new List<string>{ "dress", "Images\\Clothes\\dress.png" },
                                                                        new List<string>{ "jeans", "Images\\Clothes\\jeans.png" },
                                                                        new List<string>{ "shirt", "Images\\Clothes\\shirt.png" },
                                                                        new List<string>{ "gloves", "Images\\Clothes\\gloves.png" },
                                                                        new List<string>{ "sneakers", "Images\\Clothes\\sneakers.png" },
                                                                        new List<string>{ "socks", "Images\\Clothes\\socks.png" },
                                                                        new List<string>{ "sweater", "Images\\Clothes\\sweater.png" },
                                                                        new List<string>{ "tie", "Images\\Clothes\\tie.png" },
                                                                        new List<string>{ "tshirt", "Images\\Clothes\\tshirt.png" } };

        List<List<string>> furniture_array = new List<List<string>>() { new List<string>{ "bed", "Images\\Furniture\\bed.png" },
                                                                      new List<string>{ "mirror", "Images\\Furniture\\mirror.png" },
                                                                      new List<string>{ "sofa", "Images\\Furniture\\sofa.png" },
                                                                      new List<string>{ "bookshelf", "Images\\Furniture\\bookshelf.png" },
                                                                      new List<string>{ "chair", "Images\\Furniture\\chair.png" },
                                                                      new List<string>{ "chest", "Images\\Furniture\\chest.png" },
                                                                      new List<string>{ "stool", "Images\\Furniture\\stool.png" },
                                                                      new List<string>{ "table", "Images\\Furniture\\table.png" },
                                                                      new List<string>{ "wardrope", "Images\\Furniture\\wardrope.png" } };

        List<List<string>> all_array = new List<List<string>>() { new List<string>{ "apple", "Images\\Fruits\\apple.png" },
                                                                  new List<string>{ "orange", "Images\\Fruits\\orange.png" },
                                                                  new List<string>{ "pear", "Images\\Fruits\\pear.png" },
                                                                  new List<string>{ "pineapple", "Images\\Fruits\\pineapple.png" },
                                                                  new List<string>{ "lime", "Images\\Fruits\\lime.png" },
                                                                  new List<string>{ "mango", "Images\\Fruits\\mango.png" },
                                                                  new List<string>{ "lemon", "Images\\Fruits\\lemon.png" },
                                                                  new List<string>{ "peach", "Images\\Fruits\\peach.png" },
                                                                  new List<string>{ "kiwi", "Images\\Fruits\\kiwi.png" },
                                                                  new List<string>{ "banana", "Images\\Fruits\\banana.png" },
                                                                  new List<string>{ "coat", "Images\\Clothes\\coat.png" },
                                                                  new List<string>{ "dress", "Images\\Clothes\\dress.png" },
                                                                  new List<string>{ "jeans", "Images\\Clothes\\jeans.png" },
                                                                  new List<string>{ "shirt", "Images\\Clothes\\shirt.png" },
                                                                  new List<string>{ "gloves", "Images\\Clothes\\gloves.png" },
                                                                  new List<string>{ "sneakers", "Images\\Clothes\\sneakers.png" },
                                                                  new List<string>{ "socks", "Images\\Clothes\\socks.png" },
                                                                  new List<string>{ "sweater", "Images\\Clothes\\sweater.png" },
                                                                  new List<string>{ "tie", "Images\\Clothes\\tie.png" },
                                                                  new List<string>{ "tshirt", "Images\\Clothes\\tshirt.png" },
                                                                  new List<string>{ "bed", "Images\\Furniture\\bed.png" },
                                                                  new List<string>{ "mirror", "Images\\Furniture\\mirror.png" },
                                                                  new List<string>{ "sofa", "Images\\Furniture\\sofa.png" },
                                                                  new List<string>{ "bookshelf", "Images\\Furniture\\bookshelf.png" },
                                                                  new List<string>{ "chair", "Images\\Furniture\\chair.png" },
                                                                  new List<string>{ "chest", "Images\\Furniture\\chest.png" },
                                                                  new List<string>{ "stool", "Images\\Furniture\\stool.png" },
                                                                  new List<string>{ "table", "Images\\Furniture\\table.png" },
                                                                  new List<string>{ "wardrope", "Images\\Furniture\\wardrope.png" } };

        static Random random = new Random();
        public int random_item = 0;
        public int next_item = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void GrabWindow_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
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

        private DispatcherTimer timer;
        private void Timer_Tick(object sender, object e)
        {
            if (TimeRemainingProgressBar.Value > 0)
            {
                TimeRemainingProgressBar.Value--;
                TimeRemainingTextBlock.Text = TimeRemainingProgressBar.Value.ToString();
            }
            else
            {
                AnswerTextBox.IsEnabled = false;
                CheckBtn.IsEnabled = false;
                StartBtn.IsEnabled = true;
                StopBtn.IsEnabled = false;
                InfoBtn.IsEnabled = true;
                SaveBtn.IsEnabled = true;
                UserName.IsEnabled = true;
                ResultsTableBtn.IsEnabled = true;
                CategoryComboBox.IsEnabled = true;
                AnswerTextBox.Clear();
                ImageWindow.Visibility = Visibility.Hidden;
                TimeRemainingProgressBar.Value = 60;
                timer.Stop();
            }
        }

        private void StartBtn_Click(object sender, RoutedEventArgs e)
        {            
            if (CategoryComboBox.Text == "")
            {
                MessageWindow message = new MessageWindow("You didn't select a category!");
                message.ShowDialog();
                return;
            }
            if (UserName.Text == "")
            {
                MessageWindow message = new MessageWindow("You didn't enter your name!");
                message.ShowDialog();
                return;
            }
            else
            {
                timer = new DispatcherTimer();
                timer.Interval = new TimeSpan(0, 0, 1); // will 'tick' once every second
                timer.Tick += new EventHandler(Timer_Tick);
                timer.Start();

                TimeRemainingTextBlock.Text = TimeRemainingProgressBar.Value.ToString();
                ImageWindow.Visibility = Visibility.Visible;
                CategoryComboBox.IsEnabled = false;
                StartBtn.IsEnabled = false;
                SaveBtn.IsEnabled = false;
                InfoBtn.IsEnabled = false;
                StopBtn.IsEnabled = true;
                CorrectCount.Text = "0";
                WrongCount.Text = "0";
                ResultsTableBtn.IsEnabled = false;
                UserName.IsEnabled = false;
                AnswerTextBox.IsEnabled = true;
                CheckBtn.IsEnabled = true;

                if (CategoryComboBox.Text == "Fruits")
                {
                    var random_fruit = random.Next(0, fruits_array.Count);

                    string path = fruits_array[random_fruit][1];

                    BitmapImage src = new BitmapImage();
                    src.BeginInit();
                    src.UriSource = new Uri(@path, UriKind.Relative);
                    src.EndInit();
                    ImageWindow.Source = src;
                    random_item = random_fruit;
                }
                if (CategoryComboBox.Text == "Clothes")
                {
                    var random_clothing = random.Next(0, clothes_array.Count);

                    string path = clothes_array[random_clothing][1];

                    BitmapImage src = new BitmapImage();
                    src.BeginInit();
                    src.UriSource = new Uri(@path, UriKind.Relative);
                    src.EndInit();
                    ImageWindow.Source = src;
                    random_item = random_clothing;
                }
                if (CategoryComboBox.Text == "Furniture")
                {
                    var random_furniture = random.Next(0, furniture_array.Count);

                    string path = furniture_array[random_furniture][1];

                    BitmapImage src = new BitmapImage();
                    src.BeginInit();
                    src.UriSource = new Uri(@path, UriKind.Relative);
                    src.EndInit();
                    ImageWindow.Source = src;
                    random_item = random_furniture;
                }
                if (CategoryComboBox.Text == "All")
                {
                    var random_all = random.Next(0, all_array.Count);

                    string path = all_array[random_all][1];

                    BitmapImage src = new BitmapImage();
                    src.BeginInit();
                    src.UriSource = new Uri(@path, UriKind.Relative);
                    src.EndInit();
                    ImageWindow.Source = src;
                    random_item = random_all;
                }
            }
        }

        void CheckAnswer(string path, BitmapImage src, int random_fruit, List<List<string>> array)
        {
            src.UriSource = new Uri(@path, UriKind.Relative);
            ImageWindow.Source = src;

            if (AnswerTextBox.Text.ToLower() == array[random_fruit][0])
            {
                int correct = Convert.ToInt32(CorrectCount.Text);
                correct++;
                CorrectCount.Text = correct.ToString();
            }
            else
            {
                int wrong = Convert.ToInt32(WrongCount.Text);
                wrong++;
                WrongCount.Text = wrong.ToString();
            }
            AnswerTextBox.Clear();
        }

        private void CheckBtn_Click(object sender, RoutedEventArgs e)
        {
            int random_fruit = 0;
            string path = "";
            BitmapImage src = new BitmapImage();
            src.BeginInit();

            if (CorrectCount.Text == "0" && WrongCount.Text == "0")
            {
                random_fruit = random_item;

                if (CategoryComboBox.Text == "Fruits")
                {
                    path = fruits_array[random_fruit][1];
                    CheckAnswer(path, src, random_fruit, fruits_array);
                    AnswerTextBox.Clear();
                }
                if (CategoryComboBox.Text == "Furniture")
                {
                    path = furniture_array[random_fruit][1];
                    CheckAnswer(path, src, random_fruit, furniture_array);
                    AnswerTextBox.Clear();
                }
                if (CategoryComboBox.Text == "Clothes")
                {
                    path = clothes_array[random_fruit][1];
                    CheckAnswer(path, src, random_fruit, clothes_array);
                    AnswerTextBox.Clear();
                }
                if (CategoryComboBox.Text == "All")
                {
                    path = all_array[random_fruit][1];
                    CheckAnswer(path, src, random_fruit, all_array);
                    AnswerTextBox.Clear();
                }                  
            }
            else
            {
                random_fruit = next_item;
                switch (CategoryComboBox.Text)
                {
                    case "Fruits":
                        {
                            path = fruits_array[random_fruit][1];
                            CheckAnswer(path, src, random_fruit, fruits_array);
                            break;
                        }
                    case "Furniture":
                        {
                            path = furniture_array[random_fruit][1];
                            CheckAnswer(path, src, random_fruit, furniture_array);
                            AnswerTextBox.Clear();
                            break;
                        }
                    case "Clothes":
                        {
                            path = clothes_array[random_fruit][1];
                            CheckAnswer(path, src, random_fruit, clothes_array);
                            AnswerTextBox.Clear();
                            break;
                        }
                    case "All":
                        {
                            path = all_array[random_fruit][1];
                            CheckAnswer(path, src, random_fruit, all_array);
                            AnswerTextBox.Clear();
                            break;
                        }
                }
            }

            if (CategoryComboBox.Text == "Fruits")
            {
                random_fruit = random.Next(0, fruits_array.Count);
                next_item = random_fruit;
                path = fruits_array[random_fruit][1];
                src.UriSource = new Uri(@path, UriKind.Relative);
                ImageWindow.Source = src;
            }
            if (CategoryComboBox.Text == "Furniture")
            {
                random_fruit = random.Next(0, furniture_array.Count);
                next_item = random_fruit;
                path = furniture_array[random_fruit][1];
                src.UriSource = new Uri(@path, UriKind.Relative);
                ImageWindow.Source = src;
            }
            if (CategoryComboBox.Text == "Clothes")
            {
                random_fruit = random.Next(0, clothes_array.Count);
                next_item = random_fruit;
                path = clothes_array[random_fruit][1];
                src.UriSource = new Uri(@path, UriKind.Relative);
                ImageWindow.Source = src;
            }
            if (CategoryComboBox.Text == "All")
            {
                random_fruit = random.Next(0, all_array.Count);
                next_item = random_fruit;
                path = all_array[random_fruit][1];
                src.UriSource = new Uri(@path, UriKind.Relative);
                ImageWindow.Source = src;

            }
            src.EndInit();
        }

        private void StopBtn_Click(object sender, RoutedEventArgs e)
        {
            AnswerTextBox.IsEnabled = false;
            CheckBtn.IsEnabled = false;
            StartBtn.IsEnabled = true;
            StopBtn.IsEnabled = false;
            InfoBtn.IsEnabled = true;
            SaveBtn.IsEnabled = true; 
            UserName.IsEnabled = true;
            ResultsTableBtn.IsEnabled = true;
            CategoryComboBox.IsEnabled = true;
            AnswerTextBox.Clear();
            ImageWindow.Visibility = Visibility.Hidden;
            TimeRemainingProgressBar.Value = 60;
            timer.Stop();
        }
        private void InfoBtn_Click(object sender, RoutedEventArgs e)
        {
            RulesOfGame rules = new RulesOfGame();
            rules.ShowDialog();
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            if (UserName.Text == "")
            {
                MessageWindow message = new MessageWindow("You didn't enter your name!");
                message.ShowDialog();
                return;
            }
            else
            {
                List<string> score = new List<string>();
                DateTime date = DateTime.Now;
                string curDate = date.ToShortDateString();
                score.Add(curDate);
                score.Add(UserName.Text);
                score.Add(CorrectCount.Text);
                score.Add(WrongCount.Text);

                string path = @"score.txt";

                List<List<string>> matrix = new List<List<string>>();


                string[] lines = File.ReadAllLines(path);
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] row = lines[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                    matrix.Add(new List<string>(row));
                }

                using (var tw = new StreamWriter(path, true))
                {
                    tw.WriteLine($"{score[0]} {score[1]} {score[2]} {score[3]}");
                }
            }
        }

        private void ResultsTableBtn_Click(object sender, RoutedEventArgs e)
        {
            ResultTableWindow resultTable = new ResultTableWindow();
            resultTable.ShowDialog();
        }
    }
}
