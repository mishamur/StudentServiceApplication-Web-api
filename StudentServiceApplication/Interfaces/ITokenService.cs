using StudentServiceApplication.Models;

namespace StudentServiceApplication.Interfaces
{
    public interface ITokenService
    {
        public string CreateToken(User user);
    }
}
