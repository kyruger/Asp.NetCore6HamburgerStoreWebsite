using AutoMapper;
using Hamburger_Application.Areas.Admin.Models.ViewModels.Fries;
using Hamburger_Application.Entities.Concrete;

namespace Hamburger_Application.Mapper
{
	public class UpdateFriesVMProfile : Profile
	{
		public UpdateFriesVMProfile()
		{
			CreateMap<UpdateFriesVM, Fries>().ReverseMap().ForAllMembers(f => f.UseDestinationValue());
		}
	}
}
