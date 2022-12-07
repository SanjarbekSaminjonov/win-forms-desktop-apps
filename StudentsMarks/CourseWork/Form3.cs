namespace CourseWork
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            var form = new Form1();
            form.ShowDialog();
            Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            dataGridViewTable.DataSource = Students.GetAll();
        }

        private void printStudents_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var width = dataGridViewTable.Width;
            var height = dataGridViewTable.Height;
            Bitmap studentsTableBitmap = new Bitmap(width, height);
            dataGridViewTable.DrawToBitmap(studentsTableBitmap, new Rectangle(0, 0, width, height));
            e.Graphics.DrawImage(studentsTableBitmap, 0, 0);
        }

        private void print_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printStudents;
            printDialog.UseEXDialog = true;
            DialogResult dialogResult = printDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                printStudents.DocumentName = "Students list";
                printStudents.Print();
            }
        }
    }
}
