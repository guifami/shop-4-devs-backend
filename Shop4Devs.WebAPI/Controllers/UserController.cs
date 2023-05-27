using Microsoft.AspNetCore.Mvc;
using Shop4Devs.Application.Interfaces;
using Shop4Devs.Domain.Entities;

namespace Shop4Devs.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetUserById(Guid id)
        {
            var user = await _userService.GetUserById(id);

            if (user == null) return StatusCode(404);

            return StatusCode(200, user);
        }

        [HttpGet("{username}")]
        public async Task<IActionResult> GetUserByUsername(string username)
        {
            var user = await _userService.GetByUsername(username);

            if (user == null) return StatusCode(404);

            return StatusCode(200, user);
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] User user)
        {
            try
            {
                await _userService.CreateUser(user);
                return StatusCode(200, $"Usuário {user.Name} criado com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
