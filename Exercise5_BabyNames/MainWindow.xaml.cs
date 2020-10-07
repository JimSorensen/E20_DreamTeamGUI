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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Exercise5_BabyNames
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

        
    private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            string[] lines = System.IO.File.ReadAllLines(
                AppDomain.CurrentDomain.BaseDirectory + "babynames.txt");
            List<BabyName> names = new List<BabyName>();

            for (int i = 0; i < 10; i++)
            {
                names.Add(new BabyName(lines[i]));

                lstDecadeTopNames.Items.Add(lines[i]);
            }
        }
    }
}
