using System.Windows;
using System.Windows.Input;

namespace HullSpeed
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 


    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();

        }

        public void calculateButton_Click(object sender, RoutedEventArgs e)
        {



            //string userInput = textBoxLength.ToString();
            //Console.WriteLine(userInput);



            string userInputString = textBoxLength.Text;

            double userInputDouble = double.Parse(userInputString);

            double knots = 1.34 * System.Math.Sqrt(userInputDouble);

            tbxHullSpeed.Text = (knots).ToString();





            MessageBox.Show("The name of this ship is " + tbxName.Text + "\n" + "Total knots: " + tbxHullSpeed.Text);




            //int calculateLength =  1.34 * System.Math.Sqrt(Length);

            //tbxHullSpeed.Text = length;
            //MessageBox.Show(x);
        }

        //private void stackPanelMain_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.Key == Key.L)
        //    {
        //        //MessageBox.Show("KeyDown L");
        //        ZoomIn();
        //    }
        //    else if (e.Key == Key.S)
        //    {
        //        //MessageBox.Show("KeyDown: S");
        //        ZoomOut();
        //    }
        //}
    }
}