using Hamburger_Application.Data;
using Hamburger_Application.Entities.Concrete;
using Hamburger_Application.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;

namespace Hamburger_Application.Repositories.Concrete
{
    public class MenuRepository : GenericRepository<Menu>, IMenuRepository
    {
        private readonly HamburgerDbContext db;

        public MenuRepository(HamburgerDbContext db) : base(db)
        {
            this.db = db;
        }

        public IEnumerable<Menu> GetAllIncludeFriesIncludeDrinkIncludeHamburger(bool state)
        {
            //return db.Menus.Where(m => m.IsActive == state).Include(m => m.Fries).Include(m => m.Drink).Include(m => m.Hamburger);
            return db.Menus.Include(m => m.Fries).Include(m => m.Drink).Include(m => m.Hamburger);
        }
    }
}
