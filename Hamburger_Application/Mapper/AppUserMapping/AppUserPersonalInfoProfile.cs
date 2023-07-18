using AutoMapper;
using Hamburger_Application.Areas.User.Models.AppUserVMs;
using Hamburger_Application.Entities.Concrete;

namespace Hamburger_Application.Mapper.AppUserMapping
{
    public class AppUserPersonalInfoProfile : Profile
    {
        public AppUserPersonalInfoProfile()
        {
            CreateMap<AppUser, AppUserPersonalInfoVM>().ReverseMap().ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.FirstName));
            CreateMap<AppUser, AppUserPersonalInfoVM>().ReverseMap().ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.LastName));
            CreateMap<AppUser, AppUserPersonalInfoVM>().ReverseMap().ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.UserName));
            CreateMap<AppUser, AppUserPersonalInfoVM>().ReverseMap().ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email));

            
        }
    }
}
