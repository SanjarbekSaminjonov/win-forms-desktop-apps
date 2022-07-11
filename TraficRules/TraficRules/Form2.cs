using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TraficRules
{
    public partial class Form2 : Form
    {
        public static string Type;
        public static string Title;
        public Form2()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            title.Text = Title;

            List<Rule> rules = Rules.GetRuleByType(Type);

            int n = rules.Count;

            RuleItem[] ruleItems = new RuleItem[n];

            flowLayoutPanel1.Controls.Clear();

            for (int i = 0; i < n; i++)
            {
                ruleItems[i] = new RuleItem();
                ruleItems[i].Image = rules[i].ImgFile;
                ruleItems[i].ImgAlt = rules[i].ImgAlt;
                flowLayoutPanel1.Controls.Add(ruleItems[i]);
            }
        }
    }
}
