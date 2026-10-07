using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using UsersApi.Data.Dtos;
using UsersApi.Domain.interfaces;
using UsersApi.Domain.Models;

namespace UsersApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController(IUserService userService) : ControllerBase
    {
        private readonly IUserService _userService = userService;

        [HttpGet("{id}")]
        [Authorize(Policy = "IdadeMinima")]
        public async Task<IActionResult> GetUserById(string id)
        {
            var user = await _userService.GetUserByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateUser(CreateUserDto userDto)
        {
            await _userService.CreateUserAsync(userDto);
            return Ok("Usuário criado com sucesso!");
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginDto loginDto)
        {
            var token = await _userService.Login(loginDto);
            return Ok(token);
        }
    }

}


