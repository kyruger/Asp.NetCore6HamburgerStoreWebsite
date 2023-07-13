using AutoMapper;
using Hamburger_Application.Entities.Concrete;
using Hamburger_Application.Models;

namespace Hamburger_Application.Mapper
{
    public class UpdateDessertVMProfile:Profile
    {
        public UpdateDessertVMProfile()
        {
            CreateMap<DessertUpdateVM, Dessert>().ReverseMap().ForAllMembers(a => a.UseDestinationValue());
        }
    }
}
