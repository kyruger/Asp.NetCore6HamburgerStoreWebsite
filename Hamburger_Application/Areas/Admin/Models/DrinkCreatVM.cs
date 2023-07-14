using Hamburger_Application.Entities.Concrete;

namespace Hamburger_Application.Areas.Admin.Models
{
    public class DrinkCreatVM
    {
        public string Name { get; set; }

        public decimal? Price { get; set; }
        public int Piece { get; set; }
        public string Photo { get; set; }

    }
}
