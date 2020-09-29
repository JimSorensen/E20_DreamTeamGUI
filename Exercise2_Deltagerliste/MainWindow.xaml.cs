using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows;

namespace Exercise2_Deltagerliste
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

        private void LoadFiler(object sender, RoutedEventArgs e)
        {
            FileStream fs = null;
            StreamReader s = null;
            try
            {
                fs = new FileStream(@"C:\Users\Jim\source\repos\Gui_Øvelser\deltagerliste.csv", FileMode.Open, FileAccess.Read);
                s = new StreamReader(fs, Encoding.Default);
                string str;
                string[] tokens;
                char[] separators = { ',' };
                List<string> lines = new List<string>();
                string nextLine = "";
                str = s.ReadLine();

                while (!s.EndOfStream)
                {
                    str = s.ReadLine();
                    str = str.Replace("\"", string.Empty);
                    if (str != "")
                    {
                        tokens = str.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                        if (tokens[1].Length > 20)
                            tokens[1] = tokens[1].Substring(0, 20); // Limit first name to max 20 chars

                        nextLine = $"{tokens[1],-20} {tokens[0],-20}  {tokens[2],-12}";
                        lines.Add(nextLine);
                    }

                }

                lbxDeltagere.ItemsSource = lines;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "An error occured during file IO");
            }
            finally
            {
                s.Close();
                fs.Close();
            }
        }

    }
}
