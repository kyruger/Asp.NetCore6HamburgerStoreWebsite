using Hamburger_Application.Entities.Concrete;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Hamburger_Application.Areas.Admin.Models
{
    public class DessertUpdateVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool isActive { get; set; } = true;
        public decimal? Price { get; set; }
        public int Piece { get; set; }
		public IFormFile imgCover { get; set; }




	}
}
