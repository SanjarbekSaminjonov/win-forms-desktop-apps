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
    public partial class Form3 : Form
    {
        public static string name = "";
        public Form3()
        {
            InitializeComponent();
        }

        Animals animals = new Animals();

        private void Form3_Load(object sender, EventArgs e)
        {
            this.Text = name;
            Animal animal = animals.GetAnimal(name);
            titleLabel.Text = animal.Name;
            pictureBox1.Image = animal.Image1;
            pictureBox2.Image = animal.Image2;
            richTextBox1.Text = animal.Description;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
