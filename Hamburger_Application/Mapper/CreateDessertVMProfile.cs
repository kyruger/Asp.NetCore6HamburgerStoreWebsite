using AutoMapper;
using Hamburger_Application.Entities.Concrete;
using Hamburger_Application.Models;

namespace Hamburger_Application.Mapper
{
    public class CreateDessertVMProfile:Profile
    {
        public CreateDessertVMProfile()
        {
            CreateMap<DessertCreateVM, Dessert>().ReverseMap().ForAllMembers(a => a.UseDestinationValue());
        }
    }
}
