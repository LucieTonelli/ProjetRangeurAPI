using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Rangeur.BLL.Interfaces;
using Rangeur.BLL.Services;
using Rangeur.Domain.Models;

namespace Rangeur.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly UserService _service;

        public UserController(UserService service)

        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<User>> GetAll()
        {
            return Ok(_service.GetAll());
        }


        [HttpGet("{idUser}")]
        public ActionResult<User> GetById (int idUser)
        {
            User? user = _service.GetById(idUser);
            if (user == null) 
            { 
            return NotFound();
            }
            return Ok(user);
        }




    } 
}
