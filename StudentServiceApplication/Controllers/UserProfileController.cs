using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.IIS.Core;
using Microsoft.Extensions.Configuration.UserSecrets;
using StudentServiceApplication.Models;
using StudentServiceApplication.ViewModels;

namespace StudentServiceApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserProfileController : ControllerBase
    {
        private readonly ApplicationContext _context;
        public UserProfileController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> PutProfile(UserProfileView userProfileView)
        {
            //проверка на то что это действительно он
            if (!ModelState.IsValid)
            {
                return ValidationProblem(ModelState);
            }
            if(!IsUserExist(userProfileView.UserId))
            {
                return BadRequest("UserId не найден");
            }
            List<Guid> havingSkills = userProfileView.HavingSkills.ToList();

            //функция, которая принимает тип или коллекцию типов, ..проверка в базе
            throw new NotImplementedException();
        }

        [NonAction]
        public bool IsUserExist(Guid userId)
        {
            return (_context.Users?.Any(u => u.UserId == userId)).GetValueOrDefault();
        }
    }
}
