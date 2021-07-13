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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 s = new Form2();
            s.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 s = new Form3();
            s.ShowDialog();
        }
    }
}
