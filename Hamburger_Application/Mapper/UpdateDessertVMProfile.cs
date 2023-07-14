using AutoMapper;
using Hamburger_Application.Areas.Admin.Models;
using Hamburger_Application.Entities.Concrete;

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
