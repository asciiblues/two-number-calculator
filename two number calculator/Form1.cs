using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace two_number_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(number1.Text); //String (textbox) to double number
            double num2 = double.Parse(number2.Text);
            // funcution for +
            double result2 = num1 + num2;
            result.Text = result2.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(number1.Text); //String (textbox) to double number
            double num2 = double.Parse(number2.Text);
            // funcution for +
            double result2 = num1 - num2;
            result.Text = result2.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(number1.Text); //String (textbox) to double number
            double num2 = double.Parse(number2.Text);
            // funcution for +
            double result2 = num1 / num2; // + to /
            result.Text = result2.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(number1.Text); //String (textbox) to double number
            double num2 = double.Parse(number2.Text);
            // funcution for +
            double result2 = num1 * num2; // + to *
            result.Text = result2.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(result.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
