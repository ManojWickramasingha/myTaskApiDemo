using myTaskApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myTaskApi.Services.Todos
{
    public class TodoServices : ITodoReposatory
    {
        public List<Todo> AllTodos()
        {
            var todos = new List<Todo>();

            var todo1 = new Todo
            {
                Id = 1,
                Title = "get book for school",
                Description = "Get some text books for school",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = TodoStatus.New,
            };
            todos.Add(todo1);

            var todo2 = new Todo
            {
                Id = 2,
                Title = "get book for Library",
                Description = "Get some text books for Library",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(7),
                Status = TodoStatus.inprgress,
            };

            todos.Add(todo2);

            var todo3 = new Todo
            {
                Id = 3,
                Title = "get book for children",
                Description = "Get some text books for classroom",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(4),
                Status = TodoStatus.completed,
            };
            todos.Add(todo3);

            return todos;
        }
    }
}
