using AutoMapper;
using Hamburger_Application.Entities.Concrete;
using Hamburger_Application.Models;

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
