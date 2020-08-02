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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        float number1, number2;
        float result;

        string operation = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = float.Parse(textDisplay.Text + 1);
                textDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = float.Parse(textDisplay.Text + 1);
                textDisplay.Text = number2.ToString();
            }
        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = float.Parse(textDisplay.Text + 2);
                textDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = float.Parse(textDisplay.Text + 2);
                textDisplay.Text = number2.ToString();
            }
        }

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = float.Parse(textDisplay.Text + 3);
                textDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = float.Parse(textDisplay.Text + 3);
                textDisplay.Text = number2.ToString();
            }
        }

        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = float.Parse(textDisplay.Text + 4);
                textDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = float.Parse(textDisplay.Text + 4);
                textDisplay.Text = number2.ToString();
            }
        }

        private void Btn5_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = float.Parse(textDisplay.Text + 5);
                textDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = float.Parse(textDisplay.Text + 5);
                textDisplay.Text = number2.ToString();
            }
        }

        private void Btn6_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = float.Parse(textDisplay.Text + 6);
                textDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = float.Parse(textDisplay.Text + 6);
                textDisplay.Text = number2.ToString();
            }
        }

        private void Btn7_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = float.Parse(textDisplay.Text + 7);
                textDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = float.Parse(textDisplay.Text + 7);
                textDisplay.Text = number2.ToString();
            }
        }

        private void Btn8_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = float.Parse(textDisplay.Text + 8);
                textDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = float.Parse(textDisplay.Text + 8);
                textDisplay.Text = number2.ToString();
            }
        }

        private void Btn9_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = float.Parse(textDisplay.Text + 9);
                textDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = float.Parse(textDisplay.Text + 9);
                textDisplay.Text = number2.ToString();
            }
        }

        private void Btn0_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = float.Parse(textDisplay.Text + 0);
                textDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = float.Parse(textDisplay.Text + 0);
                textDisplay.Text = number2.ToString();
            }
        }

        private void BtnPlus_Click(object sender, RoutedEventArgs e)
        {
            operation = "+";
            number1 = float.Parse(textDisplay.Text);
            textDisplay.Text = number1.ToString() + "+";
        }

        private void BtnMinus_Click(object sender, RoutedEventArgs e)
        {
            operation = "-";
            number1 = float.Parse(textDisplay.Text);
            textDisplay.Text = number1.ToString() + "-";
        }

        private void BtnTimes_Click(object sender, RoutedEventArgs e)
        {
            operation = "*";
            number1 = float.Parse(textDisplay.Text);
            textDisplay.Text = number1.ToString() + "*";
        }

        private void BtnDivide_Click(object sender, RoutedEventArgs e)
        {
            operation = "/";
            number1 = float.Parse(textDisplay.Text);
            textDisplay.Text = number1.ToString() + "/";
        }

        private void calculate()
        {
            switch (operation)
            {
                case "+":
                    result = number1 + number2;
                    textDisplay.Text = result.ToString();
                    break;
                case "-":
                    result = number1 - number2;
                    textDisplay.Text = result.ToString();
                    break;
                case "*":
                    result = number1 * number2;
                    textDisplay.Text = result.ToString();
                    break;
                case "/":
                    result = number1 / number2;
                    textDisplay.Text = result.ToString();
                    break;
                default:
                    break;
            }
        }

        private void BtnEquals_Click(object sender, RoutedEventArgs e)
        {
            calculate();
        }

        private void BtnClearEntry_Click(object sender, RoutedEventArgs e)
        {
            number1 = 0;
            number2 = 0;
            operation = "";
            textDisplay.Text = "";
        }

        private void BtnBackspace_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 / 10);
                textDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 / 10);
                textDisplay.Text = number2.ToString();
            }
        }

        private void BtnPositiveNegative_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 *= -1;
                textDisplay.Text = number1.ToString();
            }
            else
            {
                number2 *= -1;
                textDisplay.Text = number2.ToString();
            }
        }

        private void BtnFractional_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                textDisplay.Text = number1.ToString() + ",";
            }
            else
            {
                textDisplay.Text = number2.ToString() + ",";
            }
        }
    }
}
