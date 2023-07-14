using Hamburger_Application.Data;
using Hamburger_Application.Entities.Concrete;
using Hamburger_Application.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;

namespace Hamburger_Application.Repositories.Concrete
{
    public class MenuRepository : GenericRepository<Menu>, IMenuRepository
    {
        private readonly HamburgerDbContext context;

        public MenuRepository(HamburgerDbContext context) : base(context) 
        {
            this.context = context;
        }

        public IEnumerable<Menu> GetAllIncludeFriesIncludeDrinkIncludeHamburger()
        {
            return context.Menus.Include(m=>m.Fries).Include(m=>m.Drink).Include(m=>m.Hamburger);
        }
    }
}
