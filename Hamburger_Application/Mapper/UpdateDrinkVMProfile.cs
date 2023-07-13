using AutoMapper;
using Hamburger_Application.Entities.Concrete;
using Hamburger_Application.Models;

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
