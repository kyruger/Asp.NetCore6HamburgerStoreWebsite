using Hamburger_Application.Entities.Concrete;

namespace Hamburger_Application.Areas.Admin.Models
{
    public class DrinkListVM
    {
        public DrinkListVM()
        {
            Drinks = new List<Drink>();
        }
        public List<Drink> Drinks { get; set; }
    }
}
