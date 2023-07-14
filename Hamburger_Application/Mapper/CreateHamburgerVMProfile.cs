using AutoMapper;
using Hamburger_Application.Areas.Admin.Models.ViewModels.Hamburger;
using Hamburger_Application.Entities.Concrete;

namespace Hamburger_Application.Mapper
{
	public class CreateHamburgerVMProfile : Profile
	{
		public CreateHamburgerVMProfile()
		{
			CreateMap<CreateHamburgerVM, Hamburger>().ReverseMap().ForAllMembers(f => f.UseDestinationValue());

		}
	}
}
