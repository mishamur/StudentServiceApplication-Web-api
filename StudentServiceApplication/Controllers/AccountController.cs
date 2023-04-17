using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentServiceApplication.Models;
using StudentServiceApplication.ViewModels;
using System.ComponentModel;

namespace StudentServiceApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly ApplicationContext _context;
        public AccountController(ApplicationContext context)
        {
            _context = context;
        }

        //пароль хранить в базе не в явном виде!!!!
        [HttpPost("register")]
        public async Task<IActionResult> RegisterUser([FromBody]UserRegister? userRegister)
        {
            if(userRegister == null || !ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            //проверка на то что пользователь с таким email уже существует
            //можно вынести в отдельный метод
            if (FindByEmailAsync(userRegister.Email).Result)
            {
                return BadRequest("пользователь с таким именем уже зарегистрирован");
            }

            User user = new User { Email = userRegister.Email, Password = userRegister.Password};
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            return Ok(user);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] UserLogin userLogin)
        {
            if (userLogin == null || !ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var user = await _context.Users.SingleOrDefaultAsync(u => u.Email.Equals(userLogin.Email));

            if(user == null) { return Unauthorized("Неверный логин и(или) пароль"); }

            //должна быть проверка hash`ей
            if (user.Password.Equals(userLogin.Password))
                return Ok(user);
            return Unauthorized();
        }


        /// <summary>
        /// 
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
