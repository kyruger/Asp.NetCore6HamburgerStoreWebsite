using Hamburger_Application.Entities.Concrete;
using Hamburger_Application.Entities.Enum;

namespace Hamburger_Application.Areas.Admin.Models
{
    public class DrinkCreatVM
    {
        public string Name { get; set; }

        public decimal? Price { get; set; }
        public int Piece { get; set; }
        public Size Size { get; set; }
        public IFormFile imgCover { get; set; }

    }
}
