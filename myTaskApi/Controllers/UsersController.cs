using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using myTaskApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using myTaskApi.Services.Users;

namespace myTaskApi.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserReposatory _userService;

        public UsersController(IUserReposatory service)
        {
            _userService = service;
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            var users = _userService.GetAllUser();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public IActionResult GetUser(int id)
        {
            var user = _userService.GetUser(id);
            if(user is null)
            {
                return NotFound();
            }
            return Ok(user);
        }
    }
}
