using StudentServiceApplication.Interfaces;
using BCrypt.Net;

namespace StudentServiceApplication.Services
{
    public class BCryptHashService : IHashService
    {
        public string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);   
        }

        public bool VerifyPassword(string password, string hashPassword)
        {
            return BCrypt.Net.BCrypt.Verify(password, hashPassword);
        }
    }
}
