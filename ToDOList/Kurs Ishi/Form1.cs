namespace Kurs_Ishi
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void viewAllTodos_Click(object sender, EventArgs e)
        {
            AllTodos allTodos = new();
            allTodos.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addNewTodo_Click(object sender, EventArgs e)
        {
            AddTodoForm addTodoForm = new AddTodoForm();
            addTodoForm.Show();
            this.Hide();
        }
    }
}