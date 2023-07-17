using Hamburger_Application.Data;
using Hamburger_Application.Entities.Concrete;
using Hamburger_Application.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Hamburger_Application.Repositories.Concrete
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        private readonly HamburgerDbContext db;

        public OrderRepository(HamburgerDbContext db) : base(db)
        {
            this.db = db;
        }

        public IEnumerable<Order> GetAllOrdersWithProducts()
        {
            return db.Orders.Include(x => x.Menus).Include(x => x.Fries).Include(x => x.Drinks).Include(x => x.Desserts).Include(x => x.Hamburgers).Include(x => x.Sauces);
        }

        public Order GetByUserId(int id, bool state)
        {
            return db.Orders.Include(x => x.Menus).Include(x => x.Fries).Include(x => x.Drinks).Include(x => x.Desserts).Include(x => x.Hamburgers).Include(x => x.Sauces).FirstOrDefault(x => x.UserId == id && x.IsAccepted == state);
        }

        public IEnumerable<Order> GetAllOrdersWithProductsWhere(Expression<Func<Order, bool>> expression)
        {
            return db.Orders.Include(x => x.Menus).Include(x => x.Fries).Include(x => x.Drinks).Include(x => x.Desserts).Include(x => x.Hamburgers).Include(x => x.Sauces).Where(expression);
        }

        public IEnumerable<Order> GetOrderWithAllProductsWhere(Expression<Func<Order, bool>> expression)
        {
            return db.Orders.Include(x => x.Menus).Include(x => x.Fries).Include(x => x.Drinks).Include(x => x.Desserts).Include(x => x.Hamburgers).Include(x => x.Sauces).Where(expression);
        }
    }
}
