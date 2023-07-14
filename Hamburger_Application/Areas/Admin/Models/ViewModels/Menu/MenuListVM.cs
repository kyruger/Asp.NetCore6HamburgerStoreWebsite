namespace Hamburger_Application.Areas.Admin.Models.ViewModels.Menu
{
    using Hamburger_Application.Entities.Concrete;
    public class MenuListVM
    {
        public MenuListVM() 
        {
            Menus = new List<Menu>();
        }
        public IEnumerable<Menu> Menus { get; set; }
    }
}
