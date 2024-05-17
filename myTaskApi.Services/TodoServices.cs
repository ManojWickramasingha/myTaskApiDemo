using myTaskApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myTaskApi.Services
{
    public class TodoServices : ITodoReposatory
    {
        public List<Todo> AllTodos()
        {
            var todos = new List<Todo>();

            var todo1 = new Todo
            {
                id = 1,
                title = "get book for school",
                Description = "Get some text books for school",
                created = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                status = TodoStatus.New,
            };
            todos.Add(todo1);

            var todo2 = new Todo
            {
                id = 2,
                title = "get book for Library",
                Description = "Get some text books for Library",
                created = DateTime.Now,
                Due = DateTime.Now.AddDays(7),
                status = TodoStatus.inprgress,
            };

            todos.Add(todo2);

            var todo3 = new Todo
            {
                id = 3,
                title = "get book for children",
                Description = "Get some text books for classroom",
                created = DateTime.Now,
                Due = DateTime.Now.AddDays(4),
                status = TodoStatus.completed,
            };
            todos.Add(todo3);

            return todos;
        }
    }
}
