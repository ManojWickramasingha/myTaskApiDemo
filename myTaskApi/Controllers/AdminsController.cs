using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using myTaskApi.Services.Admins;
using myTaskApi.Services.ViewModels;
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
        private readonly IMapper _mapper;
        public AdminsController(IAdminReposatory service,IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
      
        [HttpGet]
        public ActionResult<ICollection<AdminDTO>> GetAdmins()
        {
            var admins = _service.GetAllAdmins();
            var mapadmins = _mapper.Map<ICollection<AdminDTO>>(admins);
            return Ok(mapadmins);
        }

     
        [HttpGet("{id}")]
        public ActionResult<AdminDTO> GetAdmin(int id)
        {
            var admin = _service.GetAdmin(id);
            if(admin is null)
            {
                return NotFound();
            }
            var mapadmin = _mapper.Map<AdminDTO>(admin);
            return Ok(mapadmin);
        }
    }
}
