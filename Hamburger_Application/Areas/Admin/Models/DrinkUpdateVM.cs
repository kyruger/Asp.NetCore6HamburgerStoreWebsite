using Hamburger_Application.Entities.Enum;

namespace Hamburger_Application.Areas.Admin.Models
{
    public class DrinkUpdateVM
    {
        public string Name { get; set; }
        public bool isActive { get; set; }
        public decimal? Price { get; set; }
        public int Piece { get; set; }
        public string? Photo { get; set; }
        public Size Size { get; set; }

    }
}
