using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Employees_details
{
    public partial class MainWindow : Form
    {
        SqlConnection sqlConnection = null;
        SqlDataAdapter sqlDataAdapter = null;
        SqlCommand sqlCommand = null;
        DataTable dataTable = null;

        bool save_bool, search_bool, b = true;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            this.dash.Location = new System.Drawing.Point(0, 0);
            search_bool = false;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void Sizer()
        {
            this.dash.Width = 300;
            this.dash.Location = new System.Drawing.Point(0, 0);

            this.labelMain.Font = new System.Drawing.Font("Algerian", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMain.Location = new System.Drawing.Point(26, 46);

            this.home.Size = new System.Drawing.Size(220, 70);
            this.home.Location = new System.Drawing.Point(40, 210);

            this.data.Size = new System.Drawing.Size(220, 70);
            this.data.Location = new System.Drawing.Point(40, 350);

            this.add.Size = new System.Drawing.Size(220, 70);
            this.add.Location = new System.Drawing.Point(40, 490);

            this.exit.Size = new System.Drawing.Size(220, 70);
            this.exit.Location = new System.Drawing.Point(40, 630);

            this.contentForm.BackColor = System.Drawing.Color.Yellow;
            this.contentForm.Controls.Add(this.guna2DataGridView1);
            this.contentForm.Controls.Add(this.Navbar);
            this.contentForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.contentForm.Location = new System.Drawing.Point(300, 0);
            this.contentForm.Name = "contentForm";
            this.contentForm.Size = new System.Drawing.Size(1100, 800);
            this.contentForm.TabIndex = 10;
        }

        void Resizer()
        {
            this.dash.Size = new System.Drawing.Size(1400, 800);

            this.labelMain.Location = new System.Drawing.Point(13, 12);
            this.labelMain.Size = new System.Drawing.Size(625, 190);
            this.labelMain.Font = new System.Drawing.Font("Algerian", 64F, System.Drawing.FontStyle.Bold);

            this.home.Location = new System.Drawing.Point(1228, 22);
            this.home.Size = new System.Drawing.Size(150, 150);

            this.data.Location = new System.Drawing.Point(1228, 208);
            this.data.Size = new System.Drawing.Size(150, 150);

            this.add.Location = new System.Drawing.Point(1228, 394);
            this.add.Size = new System.Drawing.Size(150, 150);
            
            this.exit.Location = new System.Drawing.Point(1228, 580);
            this.exit.Size = new System.Drawing.Size(150, 150);
        }

        private void home_Click(object sender, EventArgs e)
        {
            Visibler();
            if (b)
            {
                Sizer();
                b = false;
            }
            else
            {
                Resizer();
                b = true;
            }
        }

        public void Load_database()
        {
            try
            {
                sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\source\repos\Employees_details01\Database1.mdf;Integrated Security=True");
                sqlConnection.Open();
                sqlDataAdapter = new SqlDataAdapter("SELECT * FROM [Employees]", sqlConnection);
                dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                guna2DataGridView1.DataSource = dataTable;
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void data_Click(object sender, EventArgs e)
        {
            if (b)
            {
                Sizer();
                b = false;
            }
            Visibler();
            contentForm.Visible = true;
            Load_database();
        }

        private void back_Click(object sender, EventArgs e)
        {
            contentForm.Visible = false;
            guna2GradientButton3.Visible = false;
            guna2GradientButton2.Visible = false;
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            Load_database();
            guna2GradientButton3.Visible = false;
            guna2GradientButton2.Visible = false;
        }

        //add btn
        private void add_Click(object sender, EventArgs e)
        {
            if (b)
            {
                Sizer();
                b = false;
            }
            save_bool = true;
            Visibler();
            edit_add.Visible = true;
        }


        //search btn
        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            if (!search_bool)
            {
                guna2TextBox1.Visible = true;
                search_bool = true;
            }
            else
            {
                guna2TextBox1.Visible = false;
                search_bool = false;
            }
        }



        //edit btn
        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            first_name.Text = guna2DataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            last_name.Text = guna2DataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            email.Text = guna2DataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            region.Text = guna2DataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            position.Text = guna2DataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            salary.Text = guna2DataGridView1.SelectedRows[0].Cells[5].Value.ToString();


            save_bool = false;
            contentForm.Visible = false;
            edit_add.Visible = true;
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Cleaner();
            edit_add.Visible = false;
            guna2GradientButton3.Visible = false;
            guna2GradientButton2.Visible = false;
            if (!b) contentForm.Visible = true;
        }


        //save btn
        private void save_btn_Click(object sender, EventArgs e)
        {
            if (save_bool)
            {
                // add
                try
                {
                    sqlConnection.Open();
                    sqlDataAdapter = new SqlDataAdapter($"INSERT INTO Employees (First_name, Last_name, Email, Region, Position, Salary) VALUES ('{first_name.Text}', '{last_name.Text}', '{email.Text}', '{region.Text}', '{position.Text}', '{salary.Text}')", sqlConnection);
                    sqlDataAdapter.SelectCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                    MessageBox.Show("Information saved!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            { // edit
                try
                {
                    string ml = guna2DataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                    sqlCommand = new SqlCommand($"UPDATE Employees SET First_name = '{first_name.Text}', Last_name = '{last_name.Text}', Email = '{email.Text}', Region = '{region.Text}', Position = '{position.Text}', Salary = '{salary.Text}' WHERE Email = '{ml}'", sqlConnection);
                    sqlCommand.CommandType = CommandType.Text;
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                    MessageBox.Show("Information updated!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Load_database();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            contentForm.Visible = true;
            edit_add.Visible = false;
            guna2GradientButton3.Visible = false;
            guna2GradientButton2.Visible = false;
            Load_database();
            Cleaner();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            sqlDataAdapter = new SqlDataAdapter($"SELECT * FROM Employees WHERE First_name LIKE '%{guna2TextBox1.Text}%'", sqlConnection);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            guna2DataGridView1.DataSource = dataTable;
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            guna2GradientButton3.Visible = false;
            guna2GradientButton2.Visible = false;
        }

        private void Navbar_Click(object sender, EventArgs e)
        {
            guna2GradientButton3.Visible = false;
            guna2GradientButton2.Visible = false;
        }

        private void guna2DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            guna2GradientButton3.Visible = true;
            guna2GradientButton2.Visible = true;
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure, delete this information ?", "Important", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    sqlConnection.Open();
                    string pst = guna2DataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                    sqlCommand = new SqlCommand($"Delete FROM Employees WHERE Email = '{pst}'", sqlConnection);
                    sqlCommand.CommandType = CommandType.Text;
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                    MessageBox.Show("Information deleted!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    sqlDataAdapter.Update(dataTable);
                    Load_database();
                }
                else if (result == DialogResult.No) Load_database();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void Visibler()
        {
            contentForm.Visible = false;
            edit_add.Visible = false;
        }

        void Cleaner()
        {
            first_name.Clear();
            last_name.Clear();
            email.Clear();
            region.Text = "jjjj";
            position.Text = "";
            salary.Clear();
        }
    }
}
