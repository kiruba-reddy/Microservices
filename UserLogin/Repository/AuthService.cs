
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using UserLogin.Automapper;
using UserLogin.Data;
using UserLogin.Dto;
using UserLogin.IRepository;
using UserLogin.Models;

namespace UserLogin.Repository
{
    public class AuthService : IAuthService
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        public AuthService(AppDbContext context, IMapper loginmapper)
        {
            _context = context;
            _mapper = loginmapper;
        }
        public async Task<User> LoginAsync(LoginDto loginDto)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Email == loginDto.Email && u.Password == loginDto.Password);
        }

        public async Task<User> RegisterAsync(RegisterDto registerDto)
        {
            var address = new Address { City = registerDto.City,Country = registerDto.Country,PostalCode=registerDto.PostalCode };
            _context.Address.Add(address);
            var user = new User { Email = registerDto.Email,Name=registerDto.Name,Password=registerDto.Password,Phone=registerDto.Phone };
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return user;
        }
    }
}
