using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using myTaskApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using myTaskApi.Services.Users;
using myTaskApi.Services.ViewModels;
using AutoMapper;
using System.Collections;

namespace myTaskApi.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserReposatory _userService;
        private readonly IMapper _mapper;
        public UsersController(IUserReposatory service,IMapper mapper)
        {
            _userService = service;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<ICollection<UserDTO>> GetUsers()
        {
            var users = _userService.GetAllUser();
           

           var mapUsers =_mapper.Map<ICollection<UserDTO>>(users);
            return Ok(mapUsers);
        }

        [HttpGet("{id}")]
        public IActionResult GetUser(int id)
        {
            var user = _userService.GetUser(id);
            if(user is null)
            {
                return NotFound();
            }

            var mapUser = _mapper.Map<ICollection<UserDTO>>(user);
            return Ok(mapUser);
        }
    }
}
