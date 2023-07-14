using Hamburger_Application.Entities.Concrete;

namespace Hamburger_Application.Areas.Admin.Models
{
    public class DessertListVM
    {
        public DessertListVM()
        {
            Desserts = new List<Dessert>();
        }
        public List<Dessert> Desserts { get; set; }
    }
}
