using AutoMapper;
using Hamburger_Application.Areas.User.Models.AppUserVMs;
using Hamburger_Application.Entities.Concrete;

namespace Hamburger_Application.Mapper.AppUserMapping
{
    public class AppUserCreateProfile : Profile
    {
        public AppUserCreateProfile()
        {
            CreateMap<AppUser, AppUserCreateVM>().ReverseMap().ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.FirstName));
            CreateMap<AppUser, AppUserCreateVM>().ReverseMap().ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.LastName));
            CreateMap<AppUser, AppUserCreateVM>().ReverseMap().ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email));
        }
    }
}
