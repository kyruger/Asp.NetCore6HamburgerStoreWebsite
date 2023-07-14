using AutoMapper;
using Hamburger_Application.Areas.Admin.Models;
using Hamburger_Application.Entities.Concrete;

namespace Hamburger_Application.Mapper
{
    public class UpdateDrinkVMProfile:Profile
    {
        public UpdateDrinkVMProfile()
        {
            CreateMap<DrinkUpdateVM, Drink>().ReverseMap().ForAllMembers(a => a.UseDestinationValue());
        }

    }
}
