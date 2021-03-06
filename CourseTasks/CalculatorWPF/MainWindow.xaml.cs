﻿using System;
using System.Windows;


namespace CalculatorWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double number1, number2, result;

        string operation = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = Convert.ToDouble(textDisplay.Text) + 1;
                textDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = 1;
                textDisplay.Text += number2.ToString();
            }
        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = Convert.ToDouble(textDisplay.Text) + 2;
                textDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = 2;
                textDisplay.Text += number2.ToString();
            }
        }

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = Convert.ToDouble(textDisplay.Text) + 3;
                textDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = 3;
                textDisplay.Text += number2.ToString();
            }
        }

        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = Convert.ToDouble(textDisplay.Text) + 4;
                textDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = 4;
                textDisplay.Text += number2.ToString();
            }
        }

        private void Btn5_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = Convert.ToDouble(textDisplay.Text) + 5;
                textDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = 5;
                textDisplay.Text += number2.ToString();
            }
        }

        private void Btn6_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = Convert.ToDouble(textDisplay.Text) + 6;
                textDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = 6;
                textDisplay.Text += number2.ToString();
            }
        }

        private void Btn7_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = Convert.ToDouble(textDisplay.Text) + 7;
                textDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = 7;
                textDisplay.Text += number2.ToString();
            }
        }

        private void Btn8_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = Convert.ToDouble(textDisplay.Text) + 8;
                textDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = 8;
                textDisplay.Text += number2.ToString();
            }
        }

        private void Btn9_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = Convert.ToDouble(textDisplay.Text) + 9;
                textDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = 9;
                textDisplay.Text += number2.ToString();
            }
        }

        private void Btn0_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = Convert.ToDouble(textDisplay.Text) + 0;
                textDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = 0;
                textDisplay.Text += number2.ToString();
            }
        }

        private void BtnPlus_Click(object sender, RoutedEventArgs e)
        {
            operation = "+";
            textDisplay.Text = number1.ToString() + "+";
        }

        private void BtnMinus_Click(object sender, RoutedEventArgs e)
        {
            operation = "-";
            textDisplay.Text = number1.ToString() + "-";
        }

        private void BtnTimes_Click(object sender, RoutedEventArgs e)
        {
            operation = "*";
            textDisplay.Text = number1.ToString() + "*";
        }

        private void BtnDivide_Click(object sender, RoutedEventArgs e)
        {
            operation = "/";
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
            if (operation == "")
            {
                number1 = 0;
                textDisplay.Text = "0";
            }
            else
            {
                number2 = 0;
                textDisplay.Text = number1 + operation;
            }
        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            number1 = 0;
            number2 = 0;
            operation = "";
            textDisplay.Text = "0";
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
    }
}
