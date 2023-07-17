using Hamburger_Application.Entities.Concrete;
using System.Linq.Expressions;

namespace Hamburger_Application.Repositories.Abstract
{
	public interface IOrderRepository:IRepository<Order>
	{
        IEnumerable<Order> GetAllOrdersWithProductsWhere(Expression<Func<Order, bool>> expression);
        IEnumerable<Order> GetAllOrdersWithProducts();
		Order GetByUserId(int id,bool state);
        IEnumerable<Order> GetOrderWithAllProductsWhere(Expression<Func<Order, bool>> expression);
	}
}
