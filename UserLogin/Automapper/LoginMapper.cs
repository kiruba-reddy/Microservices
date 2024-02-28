using AutoMapper;
using UserLogin.Dto;
using UserLogin.Models;
namespace UserLogin.Automapper
{
    public class LoginMapper:Profile
    {
        public LoginMapper() { 
            CreateMap<User,RegisterDto>().ReverseMap();
            CreateMap<Address,RegisterDto>().ReverseMap();
        }
    }
}
