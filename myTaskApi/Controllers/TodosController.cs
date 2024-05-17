using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using myTaskApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myTaskApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        
        private ITodoReposatory _todoServices; 

        public TodosController(ITodoReposatory reposatory)
        {
            _todoServices =reposatory;
        }
        [HttpGet("{id?}")]
       public IActionResult getTodos(int? id)
        {
            var myTodos = _todoServices.AllTodos();

            if (id is null) return Ok(myTodos);

            myTodos = myTodos.Where(t => t.id == id).ToList();

            return Ok(myTodos);
            
        }
        //get todos----
       
    }
}
