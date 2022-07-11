namespace TraficRules
{
    public partial class Form1 : Form
    {
        Form2 form = new Form2();

        public Form1()
        {
            InitializeComponent();
        }

        private void OpenForm2()
        {
            form.Show();
            this.Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2.Type = "Warning";
            Form2.Title = button1.Text;
            OpenForm2();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2.Type = "Privileged";
            Form2.Title = button2.Text;
            OpenForm2();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2.Type = "Prohibition";
            Form2.Title = button3.Text;
            OpenForm2();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2.Type = "Commander";
            Form2.Title = button4.Text;
            OpenForm2();
        }
    }
}