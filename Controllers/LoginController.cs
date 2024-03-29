﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Web.Entity.Context;
using Web.Helper;
using Web.Model;

namespace Web.Controllers
{
    [Route("api")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly AppDbContext _dbContext;
        private readonly IMapper _mapper;
        private readonly IConfiguration _config;

        public LoginController(AppDbContext appDbContext, IMapper mapper, IConfiguration config)
        {
            _dbContext = appDbContext;
            _mapper = mapper;
            _config = config;
        }

        [HttpPost]
        [Route("login")]
        public async Task<ActionResult> AuthenticateUser([FromBody] LoginDto userDto)
        {
            if (userDto == null)
            {
                return BadRequest();
            }

            var user = await _dbContext.Users.FirstOrDefaultAsync(x => x.Username == userDto.Username && x.Password == userDto.Password);
            if (user == null)
            {
                return NotFound(new
                {
                    Message = "User Not Found!"
                });
            }

            var token = GenerateToken(user.Username);
            var mailtask = SendLoginNotification($"{user.FirstName} {user.LastName}");
            
            return Ok(new
            {
                StatusCode = 200,
                UserType = (byte)user.UserType,
                UserId = user.Id,
                Token = token,
                Name = $"{user.FirstName} {user.LastName}"
            });
        }

        private async Task SendLoginNotification(string loggedInUser)
        {
            string recipients = "noyal@phoenix-psych.com";
            string subject = $"Login : {loggedInUser}";
            string message = $"{loggedInUser} - Login Successfully @{DateTime.Now.ToLocalTime()}";
            var email = new EmailManager();
            if (false)
            {
                email.SendGmailMail(recipients, subject, message);
            }
        }

        private string GenerateToken(string username)
        {
            var handler = new JwtSecurityTokenHandler();
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var claims = new[]
            {
                new Claim(ClaimTypes.UserData, username),
                new Claim("Company", "AIMS")
            };

            var token = new JwtSecurityToken(
                issuer: _config["Jwt:Issuer"],
                audience: _config["Jwt:Audience"],
                claims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: credentials
                );

            return handler.WriteToken(token);
        }
    }
}
