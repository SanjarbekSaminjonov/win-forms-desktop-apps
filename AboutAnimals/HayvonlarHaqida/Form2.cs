using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HayvonlarHaqida
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();  
        }

        Form3 form3 = new Form3();

        private void button1_Click(object sender, EventArgs e)
        {
            Form3.name = button1.Text;
            form3.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3.name = button2.Text;
            form3.ShowDialog();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Form3.name = button3.Text;
            form3.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form3.name = button6.Text;
            form3.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3.name = button5.Text;
            form3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3.name = button4.Text;
            form3.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form3.name = button9.Text;
            form3.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form3.name = button8.Text;
            form3.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form3.name = button7.Text;
            form3.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form3.name = button12.Text;
            form3.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form3.name = button11.Text;
            form3.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form3.name = button10.Text;
            form3.ShowDialog();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Form3.name = button15.Text;
            form3.ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form3.name = button14.Text;
            form3.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form3.name = button13.Text;
            form3.ShowDialog();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Form3.name = button18.Text;
            form3.ShowDialog();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Form3.name = button17.Text;
            form3.ShowDialog();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Form3.name = button16.Text;
            form3.ShowDialog();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
