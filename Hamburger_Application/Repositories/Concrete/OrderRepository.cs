using Hamburger_Application.Data;
using Hamburger_Application.Entities.Concrete;
using Hamburger_Application.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Hamburger_Application.Repositories.Concrete
{
	public class OrderRepository : GenericRepository<Order>, IOrderRepository
	{
		private readonly HamburgerDbContext context;

		public OrderRepository(HamburgerDbContext context):base(context) 
        {
			this.context = context;
		}
        public IEnumerable<Order> GetAllOrdersWithProducts()
		{
			return context.Orders.Include(x => x.Menus).Include(x => x.Fries).Include(x => x.Drinks).Include(x => x.Desserts).Include(x => x.Hamburgers).Include(x => x.Sauces);
		}

        public Order GetByUserId(int id,bool state)
        {
            return context.Orders.Include(x => x.Menus).Include(x => x.Fries).Include(x => x.Drinks).Include(x => x.Desserts).Include(x => x.Hamburgers).Include(x => x.Sauces).FirstOrDefault(x=>x.UserId==id && x.isAccepted==state);
        }
		public IEnumerable<Order> GetAllOrdersWithProductsWhere(Expression<Func<Order, bool>> expression) 
		{
			return context.Orders.Include(x => x.Menus).Include(x => x.Fries).Include(x => x.Drinks).Include(x => x.Desserts).Include(x => x.Hamburgers).Include(x => x.Sauces).Where(expression);
        }
      




    }
}
