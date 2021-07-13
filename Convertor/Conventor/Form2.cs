using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conventor
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            button1.Enabled = false;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label2.Text = "";
            if (textBox1.Text.Length == 0)
                button1.Enabled = false;
            else
                button1.Enabled = true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double km = Convert.ToDouble(textBox1.Text) * 1.609344;
                label2.Text = Convert.ToString(km) + " km";
            }
            catch
            {
                label2.Text = "Error";
                textBox1.Focus();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                return;
            
            if (e.KeyChar == '.')
                e.KeyChar = ',';
            
            if (e.KeyChar == ',')
            {
                if (textBox1.Text.IndexOf(',') != -1)
                    e.Handled = true;
                
                return;
            }

            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    button1.Focus();

                return;
            }
        }
    }
}
