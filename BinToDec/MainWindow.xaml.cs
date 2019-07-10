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

using System.Text.RegularExpressions;

namespace BinToDec
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

        private void ButtonConvert_Click(object sender, RoutedEventArgs e)
        {
            string inputBinary = TextBinary.Text;
            int inputLength = inputBinary.Length;

            double demicalNum = 0;

            for (int i = inputLength - 1;i>=0;i--)
            {
                demicalNum +=  double.Parse(inputBinary[i].ToString()) * Math.Pow(2, inputLength - 1 - i);
            }
            
            TextDemical.Text = demicalNum.ToString();
           
        }

        private void BinaryValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0,1]");
            e.Handled = regex.IsMatch(e.Text);
        }


    }
}
