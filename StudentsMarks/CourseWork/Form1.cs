namespace CourseWork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newStudent_Click(object sender, EventArgs e)
        {
            var form = new Form2();
            form.Show();
        }

        private void viewStudents_Click(object sender, EventArgs e)
        {
            var form = new Form3();
            form.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}