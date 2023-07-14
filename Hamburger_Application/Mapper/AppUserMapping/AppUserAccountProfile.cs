using AutoMapper;
using Hamburger_Application.Areas.User.Models.AppUserVMs;
using Hamburger_Application.Entities.Concrete;

namespace Hamburger_Application.Mapper.AppUserMapping
{
    public class AppUserAccountProfile : Profile
    {
        public AppUserAccountProfile()
        {
            CreateMap<AppUser, AppUserAccountVM>().ReverseMap().ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.FirstName));
            CreateMap<AppUser, AppUserAccountVM>().ReverseMap().ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.LastName));
            CreateMap<AppUser, AppUserAccountVM>().ReverseMap().ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.UserName));
            CreateMap<AppUser, AppUserAccountVM>().ReverseMap().ForMember(dest => dest.Address, opt => opt.MapFrom(src => src.Address));
            CreateMap<AppUser, AppUserAccountVM>().ReverseMap().ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email));
            CreateMap<AppUser, AppUserAccountVM>().ReverseMap().ForMember(dest => dest.ConfirmCode, opt => opt.MapFrom(src => src.ConfirmCode));
            CreateMap<AppUser, AppUserAccountVM>().ReverseMap().ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive));
            CreateMap<AppUser, AppUserAccountVM>().ReverseMap().ForMember(dest => dest.Orders, opt => opt.MapFrom(src => src.Orders));
        }
    }
}
