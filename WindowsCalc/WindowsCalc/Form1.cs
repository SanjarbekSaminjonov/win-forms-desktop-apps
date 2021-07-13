using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsCalc
{
    public partial class Form1 : Form
    {
        public string str = "", str1 = "";
        public char amal;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
            str1 = str;
            amal = '*';
            str = "";
            textBox1.Text = str;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            str1 = str;
            amal = '/';
            str = "";
            textBox1.Text = str;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            str1 = str;
            amal = '-';
            str = "";
            textBox1.Text = str;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            str1 = str;
            amal = '+';
            str = "";
            textBox1.Text = str;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if ((str != "") && (amal == '+' || amal == '-' || amal == '*' || amal == '/'))
            {
                double a = double.Parse(str1), b = double.Parse(str);
                if (amal == '+')
                {
                    str = Convert.ToString(a + b);
                    textBox1.Text = str;
                    amal = ' ';
                }
                if (amal == '-')
                {
                    str = Convert.ToString(a - b);
                    textBox1.Text = str;
                    amal = ' ';
                }
                if (amal == '*')
                {
                    str = Convert.ToString(a * b);
                    textBox1.Text = str;
                    amal = ' ';
                }
                if (amal == '/')
                {
                    str = Convert.ToString(a / b);
                    textBox1.Text = str;
                    amal = ' ';
                }

            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (str == "")
            {
                str += "0,";
                textBox1.Text = str;
            }
            else
            {
                str += ",";
                textBox1.Text = str;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (str != "")
            {
                str += "0";
                textBox1.Text = str;
            } 
        }

        private void button9_Click(object sender, EventArgs e)
        {
            str += "9";
            textBox1.Text = str;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            str += "8";
            textBox1.Text = str;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            str += "7";
            textBox1.Text = str;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            str += "6";
            textBox1.Text = str;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            str += "5";
            textBox1.Text = str;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            str += "4";
            textBox1.Text = str;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            str += "3";
            textBox1.Text = str;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            str += "2";
            textBox1.Text = str;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            str += "1";
            textBox1.Text = str;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            amal = ' ';
            str = "";
            str1 = "";
            textBox1.Text = str;
        }
    }
}
