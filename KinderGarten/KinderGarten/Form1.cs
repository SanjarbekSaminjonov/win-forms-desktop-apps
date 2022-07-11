using System.ComponentModel;
using System.Data;

namespace KinderGarten
{
    public partial class Form1 : Form
    {
        int selectedId = 0;

        public Form1()
        {
            InitializeComponent();
        }

        void LoadData()
        {
            var childen = Children.GetAll();

            DataTable table = new DataTable();
            
            table.Columns.Clear();

            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("Ism", typeof(string));
            table.Columns.Add("Familiya", typeof(string));
            table.Columns.Add("Mas'ul shaxs", typeof(string));
            table.Columns.Add("Yoshi", typeof(string));
            table.Columns.Add("Manzil", typeof(string));

            foreach (var child in childen)
            {
                table.Rows.Add(child.Id, child.FirstName, child.LastName, child.ResponsiblePerson, child.Age, child.Address);
            }

            dataGridView1.DataSource = table;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedId = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            BtnShow();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Rostdan ham o'chirmoqchisiz?", "Xabarnoma", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                Children.Delete(selectedId);
                BtnHide();
                LoadData();
            }
        }

        void BtnShow()
        {
            button2.Visible = true;
            button3.Visible = true;
        }

        void BtnHide()
        {
            button2.Visible = false;
            button3.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2.isNew = false;
            Form2.updateId = selectedId;
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}