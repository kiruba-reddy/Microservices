using UserLogin.Dto;
using UserLogin.Models;

namespace UserLogin.IRepository
{
    public interface IAuthService
    {
        Task<User> RegisterAsync(RegisterDto registerDto);
        Task<User> LoginAsync(LoginDto loginDto);
    }
}
