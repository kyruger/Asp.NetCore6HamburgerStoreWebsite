using AutoMapper;
using Hamburger_Application.Areas.Admin.Models.ViewModels.Sauce;
using Hamburger_Application.Entities.Concrete;

namespace Hamburger_Application.Mapper
{
	public class UpdateSauceVMProfile : Profile
	{
		public UpdateSauceVMProfile()
		{
			CreateMap<UpdateSauceVM, Sauce>().ReverseMap().ForAllMembers(f => f.UseDestinationValue());
		}
	}
}
