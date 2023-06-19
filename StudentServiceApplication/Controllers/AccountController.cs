using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentServiceApplication.Interfaces;
using StudentServiceApplication.Models;
using StudentServiceApplication.ViewModels;

namespace StudentServiceApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly ApplicationContext _context;
        private readonly ITokenService _tokenService;
        private readonly IHashService _hashService;
        public AccountController(ApplicationContext context, ITokenService tokenService, IHashService hashService)
        {
            _context = context;
            _tokenService = tokenService;
            _hashService = hashService;
        }
        [EnableCors("_myAllowSpecificOrigins")]
        [HttpPost("register")]
        public async Task<IActionResult> RegisterUser([FromBody]UserRegister? userRegister)
        {
            if(userRegister == null || !ModelState.IsValid)
            {
                return ValidationProblem(ModelState);
                
            }
            if (FindByEmailAsync(userRegister.Email).Result)
            {
                return StatusCode(400, "пользователь с таким именем уже зарегистрирован");
            }

            User user = new User { Email = userRegister.Email, Password = _hashService.HashPassword(userRegister.Password)};
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            
            return Ok(new {Email = user.Email, Token =  _tokenService.CreateToken(user)});
        }
        [EnableCors("_myAllowSpecificOrigins")]
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] UserLogin userLogin)
        {
            if (userLogin == null || !ModelState.IsValid)
            {
                return ValidationProblem(ModelState);
            }
            var listUsers = _context.Users.ToList();
            var user = await _context.Users.SingleOrDefaultAsync(u => u.Email.Equals(userLogin.Email));

            if(user == null) { return StatusCode(102, "Неверный логин и(или) пароль"); }

            //должна быть проверка hash`ей
            if(_hashService.VerifyPassword(userLogin.Password, user.Password))
                return Ok(new { Email = user.Email, Token = _tokenService.CreateToken(user) });
            return BadRequest();
        }

        /// <summary>
        /// Поиск пользователя по заданному email
        /// </summary>
        /// <param name="email"></param>
        /// <returns>true, if finded. false if not finded</returns>
        [NonAction]
        public async Task<bool> FindByEmailAsync(string email)
        {
            return await _context.Users.SingleOrDefaultAsync(u => u.Email.Equals(email)) != null;
        }
    }
}
