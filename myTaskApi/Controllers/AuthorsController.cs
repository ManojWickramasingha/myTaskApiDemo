using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using myTaskApi.Services.Authors;
namespace myTaskApi.Controllers
{
    [Route("api/authors")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {

        private readonly IAuthorReposatory _service;
        public AuthorsController(IAuthorReposatory service)
        {
            _service = service;
        }
        [HttpGet]
        public IActionResult GetAuthors()
        {
            var Authors = _service.GetAllAuthors();
            return Ok(Authors);
        }

        [HttpGet ("(id)")]
        public IActionResult GetAuthor(int id)
        {
            var Author = _service.GetAuthor(id);
            return Ok(Author);
        }
    }
}
