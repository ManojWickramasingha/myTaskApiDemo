using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using myTaskApi.Services.Admins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace myTaskApi.Controllers
{
    [Route("api/admins")]
    [ApiController]
    public class AdminsController : ControllerBase
    {

        private readonly IAdminReposatory _service;
        public AdminsController(IAdminReposatory service)
        {
            _service = service;
        }
      
        [HttpGet]
        public IActionResult GetAdmins()
        {
            var admins = _service.GetAllAdmins();
            return Ok(admins);
        }

     
        [HttpGet("{id}")]
        public IActionResult GetAdmin(int id)
        {
            var admin = _service.GetAdmin(id);
            if(admin is null)
            {
                return NotFound();
            }
            return Ok(admin);
        }
    }
}
