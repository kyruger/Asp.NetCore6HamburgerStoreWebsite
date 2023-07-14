using AutoMapper;
using Hamburger_Application.Areas.Admin.Models;
using Hamburger_Application.Entities.Concrete;

namespace Hamburger_Application.Mapper
{
    public class CreateDrinkVMProfile:Profile
    {
        public CreateDrinkVMProfile()
        {
            CreateMap<DrinkCreatVM, Drink>().ReverseMap().ForAllMembers(a => a.UseDestinationValue());
        }
    }
}
