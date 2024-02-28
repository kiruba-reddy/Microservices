
using Microsoft.EntityFrameworkCore;
using UserLogin.Data;
using UserLogin.Dto;
using UserLogin.IRepository;
using UserLogin.Models;

namespace UserLogin.Repository
{
    public class AuthService : IAuthService
    {
        private readonly AppDbContext _context;
        public AuthService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<User> LoginAsync(LoginDto loginDto)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Email == loginDto.Email && u.Password == loginDto.Password);
        }

        public async Task<User> RegisterAsync(RegisterDto registerDto)
        {
            
            var user = new User { UserId = registerDto.UserId,Email = registerDto.Email,Name=registerDto.Name,Password=registerDto.Password,Phone=registerDto.Phone};
            _context.Users.Add(user);
            var address = new Address { UserId = registerDto.UserId,City = registerDto.City, Country = registerDto.Country, PostalCode = registerDto.PostalCode };
            _context.Address.Add(address);
            await _context.SaveChangesAsync();
            return user;
        }
    }
}
