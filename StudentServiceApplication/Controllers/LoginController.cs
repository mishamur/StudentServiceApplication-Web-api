using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using StudentServiceApplication.Models;
using StudentServiceApplication.ViewModels;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace StudentServiceApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public LoginController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        //[AllowAnonymous]
        //[HttpPost]
        //public IActionResult Login([FromBody] UserLogin userLogin)
        //{
        //    var user = Authenticate(userLogin);
        //    if(user != null)
        //    {
        //        var token = Generate(user);
        //        return Ok(token);
        //    }
        //    return NotFound("User not found");
        //}


        [NonAction]
        private string Generate(User user)
        {
            var securKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
            var credentiols = new SigningCredentials(securKey, SecurityAlgorithms.HmacSha256);
            string s = _configuration["Jwt:Key"];
            var claims = new[]
            {
                //new Claim(ClaimTypes.NameIdentifier, user.Username),
                new Claim(ClaimTypes.Email, user.Email)
                //new Claim(ClaimTypes.GivenName, user.Lastname),
                //new Claim(ClaimTypes.Surname, user.Firstname)
            };

            var token = new JwtSecurityToken(_configuration["Jwt:Issuer"], _configuration["Audience"], claims,
                expires: DateTime.Now.AddMinutes(30), signingCredentials: credentiols);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        //[NonAction]
        //private UserModel Authenticate(UserLogin userLogin)
        //{
        //   var currentUser = UserConstants.Users.FirstOrDefault(o => o.Username.ToLower() == 
        //   userLogin.Username.ToLower() && o.Password == userLogin.Password);
        //   if(currentUser != null)
        //   {
        //        return currentUser;
        //   }
        //    return null;
        //}

    }
}
