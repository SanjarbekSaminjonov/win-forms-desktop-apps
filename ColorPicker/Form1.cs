using System;
using System.Windows.Forms;

namespace ColorPicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void xuiColorPicker1_SelectedColorChanged(object sender, EventArgs e)
        {
            panel1.BackColor = xuiColorPicker1.SelectedColor;
            textBox1.Text = xuiColorPicker1.SelectedColor.ToString();
        }
    }
}