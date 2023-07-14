using Hamburger_Application.Entities.Concrete;

namespace Hamburger_Application.Repositories.Abstract
{
    public interface IMenuRepository : IRepository<Menu> 
    {
        IEnumerable<Menu> GetAllIncludeFriesIncludeDrinkIncludeHamburger(bool state);
    }
}
