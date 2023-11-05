using DevFreela.Application.InputModel;
using DevFreela.Application.Services.Interfaces;
using DevFreela.Models;
using Microsoft.AspNetCore.Mvc;


namespace DevFreela.Controllers
{
    [Route("api/user")]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        //api/users/1
        [HttpGet("{id}")]

        public  IActionResult GetById(int id)
        {
            var user = _userService.GetUser(id);

            if(user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        //api/users
        [HttpPost]
        public IActionResult Post([FromBody] CreateUserInputModel inputModel)
        {
            var id = _userService.Create(inputModel);
            return CreatedAtAction(nameof(GetById), new { id = id }, inputModel);
        }
        
        //api/users/1/login
        [HttpPut("{id}/login")]
        public IActionResult Login(int id, [FromBody] LoginModel login)
        {
            // Para o modulo de Autenticação e Autorização

            return NoContent();
        }
    }
}

