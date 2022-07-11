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
    public partial class DetailTodo : Form
    {
        public static int TodoId = 1;
        public DetailTodo()
        {
            InitializeComponent();
        }

        private void DetailTodo_Load(object sender, EventArgs e)
        {
            Todo todo = Todos.GetById(TodoId);
            textBox1.Text = todo.Title;
            textBox2.Text = todo.Body;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AllTodos allTodos = new();
            allTodos.Show();
            this.Close();
        }
    }
}
