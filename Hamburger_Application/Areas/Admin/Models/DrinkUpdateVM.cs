using Hamburger_Application.Entities.Enum;

namespace Hamburger_Application.Areas.Admin.Models
{
    public class DrinkUpdateVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool isActive { get; set; } = true;
        public decimal Price { get; set; }
        public int Piece { get; set; }
        public IFormFile imgCover { get; set; }
        public Size Size { get; set; }
    }
}
