using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mp3Player
{
    public partial class Form1 : Form
    {
        private Mp3Player mp3Player = new Mp3Player();

        public static bool ps = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Mp3 Files|*.mp3";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    mp3Player.open(ofd.FileName);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (ps)
            {
                mp3Player.play();
                ps = false;
            }
            else
            {
                mp3Player.stop();
                ps = true;
            }
        }
    }
}
