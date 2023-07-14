using AutoMapper;
using Hamburger_Application.Areas.Admin.Models;
using Hamburger_Application.Entities.Concrete;

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
