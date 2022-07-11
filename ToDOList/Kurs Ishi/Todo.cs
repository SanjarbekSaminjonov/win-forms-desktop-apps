using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs_Ishi
{
    public class Todo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }

    public static class Todos
    {
        public static List<Todo> todos = new List<Todo>
        {
            new Todo()
            {
                Id = 1,
                Title = "Stive Jobs kitobi",
                Body = "Kitob do'koniga borganda Stive Jobs kitobini sotib olishim kerak",
            },

            new Todo()
            {
                Id = 2,
                Title = "Matematika vazifasi",
                Body = "Matematika fanidan berilgan vazifalarni shu hafta oxirigacha ishlshim zarur",
            },
        };

        public static List<Todo> GetAllTodos()
        {
            return todos;
        }

        public static Todo AddTodo(string Title, string Body)
        {
            int Id = todos.Last().Id + 1;
            Todo todo = new Todo() { Id = Id, Title = Title, Body = Body };
            todos.Add(todo);
            return todo;
        }

        public static Todo GetById(int Id)
        {
            return todos.FirstOrDefault(todo => todo.Id == Id);
        }
    }
}
