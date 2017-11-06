using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rekenmachine
{
    public partial class Rekenmachine : Form
    {
        // Calculator memory
        string input = string.Empty;                  // String storing user input
        string operand1 = string.Empty;          // String storing first operand
        string operand2 = string.Empty;          // String storing second operand
        char operation;                                     // Char for operation
        double result = 0.0;                              // Calculated result
        // Programm event handlers (button press)
        public Rekenmachine()
        {
            InitializeComponent();
        }
        // One button 1
        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += '1';
            this.textBox1.Text += input;
        }
        // Two button 2
        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += '2';
            this.textBox1.Text += input;
        }
        // Three button 3
        private void button3_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += '3';
            this.textBox1.Text += input;
        }
        // Four button 4
        private void button4_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += '4';
            this.textBox1.Text += input;
        }
        // Five button 5
        private void button5_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += '5';
            this.textBox1.Text += input;
        } 
        // Six button 6
        private void button6_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += '6';
            this.textBox1.Text += input;
        }
        // Seven button 7
        private void button7_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += '7';
            this.textBox1.Text += input;
        }
        // Eight button 8
        private void button8_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += '8';
            this.textBox1.Text += input;
        }
        // Nine button 9
        private void button9_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += '9';
            this.textBox1.Text += input;
        }
        // Zero button 0
        private void button10_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += '0';
            this.textBox1.Text += input;
        }
        // Decimale button .
        private void button11_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += ',';
            this.textBox1.Text += input;
        }
        // Clear button C
        private void button12_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;
        }
        // Add button +
        private void button13_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '+';
            input = string.Empty;
        }
        // Minus button -
        private void button14_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '-';
            input = string.Empty;
        }
        // Divide button /
        private void button15_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '/';
            input = string.Empty;
        }
        // Multiply button x
        private void button16_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '*';
            input = string.Empty;
        }
        // Percentage button %
        private void button17_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '%';
            input = string.Empty;
        }
        // Guilden to Euro convertor fl/€
        private void button18_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '€';
            input = string.Empty;
        }
        // Answer button =
        private void button19_Click(object sender, EventArgs e)
        {
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);
        // Clears input and operand strings
            this.textBox1.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;
        // Where the magic happens
            if (operation == '+')
            {
                result = num1 + num2;
                textBox1.Text = result.ToString();
            }
            else if (operation == '-')
            {
                result = num1 - num2;
                textBox1.Text = result.ToString();
            }
            else if (operation == '*')
            {
                result = num1 * num2;
                textBox1.Text = result.ToString();
            }
            else if (operation == '/')
            {
                result = num1 / num2;
                textBox1.Text = result.ToString();
            }
            else if (operation == '%')
            {
                result = num1 / 100 * num2;
                textBox1.Text = result.ToString();
            }
            else if (operation == '€')
            {
                result = num1 / 2.2;
                textBox1.Text = result.ToString();
            }
        }
    }
}
