using AutoMapper;
using Pizzeria.Modules.Users.DTOs;
using Pizzeria.Modules.Users.Models;

namespace Pizzeria.Modules.Mapper;

public class AutoMapperProfiles : Profile
{
    public AutoMapperProfiles()
    {
        CreateMap<RegisterDto, AppUser>();
    }
}
