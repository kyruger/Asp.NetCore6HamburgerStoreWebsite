using AutoMapper;
using Hamburger_Application.Areas.User.Models.AppUserVMs;
using Hamburger_Application.Entities.Concrete;

namespace Hamburger_Application.Mapper.AppUserMapping
{
    public class AppUserThemeProfile : Profile
    {
        public AppUserThemeProfile()
        {
            CreateMap<AppUser, AppUserThemeVM>().ReverseMap().ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email));
            CreateMap<AppUser, AppUserThemeVM>().ReverseMap().ForMember(dest => dest.IsDark, opt => opt.MapFrom(src => src.IsDark));
        }
    }
}
