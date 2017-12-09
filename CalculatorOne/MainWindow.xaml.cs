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
        bool q;

        public void StartCalc()
        {
            a = 0;
            b = 0;
            q = false;
            aString = "";
            bExist = false;
            TextBox1.Text = "0";
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
                aString = aString + "1";
            TextBox1.Text = Convert.ToString(aString);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            StartCalc();
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            aString = aString + '2';
            TextBox1.Text = Convert.ToString(aString);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            aString = aString + "3";
            TextBox1.Text = Convert.ToString(aString);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            aString = aString + "4";
            TextBox1.Text = Convert.ToString(aString);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            aString = aString + "5";
            TextBox1.Text = Convert.ToString(aString);
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            aString = aString + "6";
            TextBox1.Text = Convert.ToString(aString);
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            aString = aString + "7";
            TextBox1.Text = Convert.ToString(aString);
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            aString = aString + "8";
            TextBox1.Text = Convert.ToString(aString);
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            aString = aString + "9";
            TextBox1.Text = Convert.ToString(aString);
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            aString = aString + "0";
            TextBox1.Text = Convert.ToString(aString);
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            b = Convert.ToInt32(aString);
            if (q)
            {
                TextBox1.Text = Convert.ToString(a + b);
                aString = Convert.ToString(a + b);
            }
            else
            {
                TextBox1.Text = Convert.ToString(a - b);
                aString = Convert.ToString(a - b);
            }
            bExist = false;
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            q = false;
            if (bExist)
            {
                b = Convert.ToInt32(aString);
                a = a - b;
                TextBox1.Text = Convert.ToString(a);
            }
            else
            {
                a = Convert.ToInt32(aString);
                aString = "";
                bExist = true;
            }
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            q = true;
            if (bExist)
            {
                b = Convert.ToInt32(aString);
                a = a + b;
                TextBox1.Text = Convert.ToString(a);
            }
            else
            {
                a = Convert.ToInt32(aString);
                aString = "";
                bExist = true;
            }

        }
    }
}
