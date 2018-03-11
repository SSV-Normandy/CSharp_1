using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
                ;
            else
                textBox2.Text += "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
                textBox2.Text = "1";
            else
                textBox2.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
                textBox2.Text = "2";
            else
                textBox2.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
                textBox2.Text = "3";
            else
                textBox2.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
                textBox2.Text = "4";
            else
                textBox2.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
                textBox2.Text = "5";
            else
                textBox2.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
                textBox2.Text = "6";
            else
                textBox2.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
                textBox2.Text = "7";
            else
                textBox2.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
                textBox2.Text = "8";
            else
                textBox2.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
                textBox2.Text = "9";
            else
                textBox2.Text += "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            switch (label3.Text)
            {
                case "=":
                    textBox1.Text = textBox2.Text;
                    break;
                case "+":
                    textBox1.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) + Convert.ToDouble(textBox2.Text));
                    break;
                case "-":
                    textBox1.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) - Convert.ToDouble(textBox2.Text));
                    break;
                case "*":
                    textBox1.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox2.Text));
                    break;
                case "/":
                    textBox1.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) / Convert.ToDouble(textBox2.Text));
                    break;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            label3.Text = "+";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            label3.Text = "-";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            label3.Text = "*";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            label3.Text = "/";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            label3.Text--;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            label3.Text = "=";
        }
    }
}
