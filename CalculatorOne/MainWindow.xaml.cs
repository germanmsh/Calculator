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

namespace CalculatorOne
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {     
        public MainWindow()
        {
            InitializeComponent();
            StartCalc();
        }
        string aString;
        bool bExist;
        int a;
        int b;
        int q;

        public void StartCalc()
        {
            a = 0;
            b = 0;
            q = 0;
            aString = "";
            bExist = false;
            TextBox1.Text = "0";
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
                aString = aString + "1";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            StartCalc();
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            aString = aString + "2";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            aString = aString + "3";
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            aString = aString + "4";
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            aString = aString + "5";
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            aString = aString + "6";
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            aString = aString + "7";
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            aString = aString + "8";
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            aString = aString + "9";
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            aString = aString + "0";
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            TextBox1.Text = Convert.ToString(a + b);
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            q = 1;
        }
    }
}
