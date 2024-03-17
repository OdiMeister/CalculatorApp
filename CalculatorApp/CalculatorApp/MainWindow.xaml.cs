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

namespace CalculatorApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double memoryNumber = 0;
        double lastInputNumber = 0;
        char lastSign = ' ';

        public void operation()
        {
            switch (lastSign)
            {
                case '+':
                    memoryNumber=memoryNumber + lastInputNumber;
                    break;

                case '-':
                    memoryNumber=memoryNumber - lastInputNumber;
                    break;

                case '/':
                    memoryNumber=memoryNumber / lastInputNumber;
                    break;

                case '*':
                    memoryNumber=memoryNumber * lastInputNumber;
                    break;

                case '%':
                    memoryNumber = memoryNumber % lastInputNumber ;
                    break;

                case ' ':
                    break;
            }
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ResetCalculatorButton_Click(object sender, RoutedEventArgs e)
        {
            memoryNumber = 0;
            lastInputNumber = 0;
            lastSign = ' ';
            MainTextBox.Text = "";
            MemoryNumberLabel.Content = "";
        }

        private void BackspaceButton_Click(object sender, RoutedEventArgs e)
        {
            if (MainTextBox.Text != "")
            { 
                MainTextBox.Text = MainTextBox.Text.Remove((MainTextBox.Text.Length) - 1);
            }
        }

        private void ModuloButton_Click(object sender, RoutedEventArgs e)
        {
            lastInputNumber = Convert.ToDouble(MainTextBox.Text);
            MainTextBox.Text = "";
            if (lastSign != ' ')
            {
                operation();
                lastSign = '%';
                MemoryNumberLabel.Content = Convert.ToString(memoryNumber) + lastSign;
            }
            else
            {
                memoryNumber = lastInputNumber;
                lastSign = '%';
                MemoryNumberLabel.Content = Convert.ToString(memoryNumber) + lastSign;
            }
        }

        private void MultiplyButton_Click(object sender, RoutedEventArgs e)
        {
            lastInputNumber = Convert.ToDouble(MainTextBox.Text);
            MainTextBox.Text = "";
            if (lastSign != ' ')
            {
                operation();
                lastSign = '*';
                MemoryNumberLabel.Content = Convert.ToString(memoryNumber) + lastSign;
            }
            else
            {
                memoryNumber = lastInputNumber;
                lastSign = '*';
                MemoryNumberLabel.Content = Convert.ToString(memoryNumber) + lastSign;
            }

        }

        private void PlusButton_Click(object sender, RoutedEventArgs e)
        {
            lastInputNumber = Convert.ToDouble(MainTextBox.Text);
            MainTextBox.Text = "";
            if (lastSign != ' ')
            {
                operation();
                lastSign = '+';
                MemoryNumberLabel.Content = Convert.ToString(memoryNumber) + lastSign;
            }
            else
            {
                memoryNumber = lastInputNumber;
                lastSign = '+';
                MemoryNumberLabel.Content=Convert.ToString(memoryNumber) + lastSign;
            }

        }

        private void DivideButton_Click(object sender, RoutedEventArgs e)
        {
            lastInputNumber = Convert.ToDouble(MainTextBox.Text);
            MainTextBox.Text = "";
            if (lastSign != ' ')
            {
                operation();
                lastSign = '/';
                MemoryNumberLabel.Content = Convert.ToString(memoryNumber) + lastSign;
            }
            else
            {
                memoryNumber = lastInputNumber;
                lastSign = '/';
                MemoryNumberLabel.Content = Convert.ToString(memoryNumber) + lastSign;
            }
        }

        private void MinusButton_Click(object sender, RoutedEventArgs e)
        {
            //?
            if (MainTextBox.Text == "")
            {
                MainTextBox.Text = "-";
            }
            else if (MainTextBox.Text == "-")
            {

            }
            else
            {
                lastInputNumber = Convert.ToDouble(MainTextBox.Text);
                MainTextBox.Text = "";
                if (lastSign != ' ')
                {
                    operation();
                    lastSign = '-';
                    MemoryNumberLabel.Content = Convert.ToString(memoryNumber) + lastSign;
                }
                else
                {
                    memoryNumber = lastInputNumber;
                    lastSign = '-';
                    MemoryNumberLabel.Content = Convert.ToString(memoryNumber) + lastSign;
                }
            }
        }

        private void EqualsButton_Click(object sender, RoutedEventArgs e)
        {
            lastInputNumber = Convert.ToDouble(MainTextBox.Text);
            if (lastSign != ' ')
            {
                operation();
                lastSign = ' ';
                MemoryNumberLabel.Content = "";
                MainTextBox.Text = Convert.ToString(memoryNumber);
            }
        }

        private void NumberSevenButton_Click(object sender, RoutedEventArgs e)
        {
            MainTextBox.Text = MainTextBox.Text + "7";
        }

        private void NumberEightButton_Click(object sender, RoutedEventArgs e)
        {
            MainTextBox.Text = MainTextBox.Text + "8";
        }

        private void NumberNineButton_Click(object sender, RoutedEventArgs e)
        {
            MainTextBox.Text = MainTextBox.Text + "9";
        }

        private void NumberFourButton_Click(object sender, RoutedEventArgs e)
        {
            MainTextBox.Text = MainTextBox.Text + "4";
        }

        private void NumberFiveButton_Click(object sender, RoutedEventArgs e)
        {
            MainTextBox.Text = MainTextBox.Text + "5";
        }

        private void NumberSixButton_Click(object sender, RoutedEventArgs e)
        {
            MainTextBox.Text = MainTextBox.Text + "6";
        }

        private void NumberOneButton_Click(object sender, RoutedEventArgs e)
        {
            MainTextBox.Text = MainTextBox.Text + "1";
        }

        private void NumberTwoButton_Click(object sender, RoutedEventArgs e)
        {
            MainTextBox.Text = MainTextBox.Text + "2";
        }

        private void NumberThreeButton_Click(object sender, RoutedEventArgs e)
        {
            MainTextBox.Text = MainTextBox.Text + "3";
        }

        private void NumberZeroButton_Click(object sender, RoutedEventArgs e)
        {
            if (MainTextBox.Text == "0")
            {

            }
            else
            {
                MainTextBox.Text = MainTextBox.Text + "0";
            }
        }

        private void DotButton_Click(object sender, RoutedEventArgs e)
        {
            if (MainTextBox.Text.Contains('.'))
            {

            }
            else
            {
                if (MainTextBox.Text != "")
                {
                    MainTextBox.Text = MainTextBox.Text + ".";
                }
                else if (MainTextBox.Text == "")
                {
                    MainTextBox.Text = MainTextBox.Text + "0.";
                }
            }
        }
    }
}
