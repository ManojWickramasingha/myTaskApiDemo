using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myTaskApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        [HttpGet]
        public  IActionResult Task() {
            var tasks = new string[] { "Task 1", "Task 2", "Task 3" };
            return Ok(tasks);
        }
        [HttpPost]
        public IActionResult NewTask()
        {
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateTask()
        {
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteTask()
        {
            var somethingwentwrong = true;
            if (somethingwentwrong)
                return BadRequest();
            return Ok();
        }
    }
}
