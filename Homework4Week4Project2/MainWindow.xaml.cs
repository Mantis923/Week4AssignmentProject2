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

namespace Homework4Week4Project2
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
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //double priceOfItem = 0, Dollar = 1.00, quarter = .25, dimes = .10, nickel = .05;
            int quarters = 0, dimes = 0, nickels = 0;
            int valueCost = 0, change = 0;

            const int Payment = 100;

            Console.WriteLine("Enter price of item from .25 cents to 1.00 dollar(increments of 5)");

            //valueCost = Int32.Parse(Console.ReadLine());
            valueCost = int.Parse(PriceOfItemTextbox.Text);
            change = Payment - valueCost;

            // for coins

            quarters = change / 25;

            change -= quarters * 25;

            dimes = change / 10;

            change -= dimes * 10;

            nickels = change / 5;

            change -= nickels * 5;




            MessageBox.Show(quarters + " " + "quarters" + " " + dimes + " " + "dimes" + " "
                + nickels + " " + "nickels");

        }
    }
}

    

