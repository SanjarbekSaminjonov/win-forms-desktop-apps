using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kurs_Ishi;

namespace Kurs_Ishi
{
    public partial class AllTodos : Form
    {
        public AllTodos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home home = new();
            home.Show();
            this.Close();
        }

        private void AllTodos_Load(object sender, EventArgs e)
        {
            foreach(var item in Todos.GetAllTodos())
            {
                listTodos.Items.Add($"{item.Id}. {item.Title}");
            }
        }

        private void listTodos_MouseClick(object sender, MouseEventArgs e)
        {
            int index = this.listTodos.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                DetailTodo.TodoId = index + 1;
                DetailTodo detailTodo = new DetailTodo();
                detailTodo.Show();
                this.Hide();
            }
        }
    }
}