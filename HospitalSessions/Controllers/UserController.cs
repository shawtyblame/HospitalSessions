using BLL.Interfaces;
using DAL.DTOS;
using Microsoft.AspNetCore.Mvc;

namespace HospitalSessions.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController(IUserService userService) : ControllerBase
    {
        private readonly IUserService _userService = userService;
        [Route("/Registration")]
        [HttpPost]
        public async Task<IActionResult> Registration(UserDTO userDTO)
        {
            return Ok(await _userService.Registration(userDTO));
        }
        [Route("/Validate")]
        [HttpPost]
        public async Task<IActionResult> Validate([FromBody]LoginDTO loginDto)
        {
            return Ok(await _userService.Validate(loginDto.Login, loginDto.Password));
        }
    }
} 