using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kurs_Ishi
{
    public partial class AddTodoForm : Form
    {
        public AddTodoForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home home = new();
            home.Show();
            this.Close();
        }

        private void saveNewTodo_Click(object sender, EventArgs e)
        {
            Todo todo = Todos.AddTodo(textBox1.Text, textBox2.Text);
            DetailTodo.TodoId = todo.Id;
            DetailTodo detailTodo = new();
            detailTodo.Show();
            this.Close();
        }
    }
}
