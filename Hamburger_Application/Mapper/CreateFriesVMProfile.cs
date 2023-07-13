using AutoMapper;
using Hamburger_Application.Areas.Admin.Models.ViewModels.Fries;
using Hamburger_Application.Entities.Concrete;

namespace Hamburger_Application.Mapper
{
	public class CreateFriesVMProfile : Profile
	{
		public CreateFriesVMProfile()
		{
			CreateMap<CreateFriesVM, Fries>().ReverseMap().ForAllMembers(f => f.UseDestinationValue());
		}
	}
}
