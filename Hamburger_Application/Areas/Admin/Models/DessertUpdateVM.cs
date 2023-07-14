using Hamburger_Application.Entities.Concrete;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Hamburger_Application.Areas.Admin.Models
{
    public class DessertUpdateVM
    {
        public string Name { get; set; }
        public bool isActive { get; set; }
        public decimal? Price { get; set; }
        public int Piece { get; set; }
        public string? Photo { get; set; }



    }
}
