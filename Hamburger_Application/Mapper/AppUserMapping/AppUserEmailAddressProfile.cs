using AutoMapper;
using Hamburger_Application.Areas.User.Models.AppUserVMs;
using Hamburger_Application.Entities.Concrete;

namespace Hamburger_Application.Mapper.AppUserMapping
{
    public class AppUserEmailAddressProfile : Profile
    {
        public AppUserEmailAddressProfile()
        {
            CreateMap<AppUser, AppUserAccountVM>().ReverseMap().ForMember(dest => dest.Address, opt => opt.MapFrom(src => src.Address));
            CreateMap<AppUser, AppUserAccountVM>().ReverseMap().ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email));
        }
    }
}
