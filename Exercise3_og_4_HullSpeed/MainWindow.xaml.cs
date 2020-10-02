using System.Windows;

namespace HullSpeed
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            string userInputString = textBoxLength.Text;

            double userInputDouble = double.Parse(userInputString);

            double knots = 1.34 * System.Math.Sqrt(userInputDouble);

            tbxHullSpeed.Text = (knots).ToString();

            MessageBox.Show("The name of this ship is " + tbxName.Text + "\n"
                            + "Total knots: " + tbxHullSpeed.Text);
        }
    }
}

//HVordan sætter billeder ind
/* https://www.youtube.com/watch?v=affbgRZoeGc */