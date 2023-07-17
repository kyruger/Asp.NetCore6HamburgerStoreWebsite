using Hamburger_Application.Data;
using Hamburger_Application.Entities.Abstract;
using Hamburger_Application.Repositories.Abstract;
using System.Linq.Expressions;

namespace Hamburger_Application.Repositories.Concrete
{
    public class GenericRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly HamburgerDbContext db;
        public GenericRepository(HamburgerDbContext db)
        {
            this.db = db;
        }

        public bool Add(T entity)
        {
            try
            {
                db.Set<T>().Add(entity);
                return db.SaveChanges() > 0;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(T entity)
        {
            try
            {
                entity.IsActive = false;
                db.Set<T>().Update(entity);
                return db.SaveChanges() > 0;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(T entity)
        {
            try
            {
                db.Set<T>().Update(entity);
                return db.SaveChanges() > 0;
            }
            catch
            {
                return false;
            }
        }

        public IEnumerable<T> GetAll()
        {
            return db.Set<T>();
        }

        public T GetById(int id)
        {
            return db.Set<T>().Find(id);
        }

        public IEnumerable<T> GetWhere(Expression<Func<T, bool>> expression)
        {
            return db.Set<T>().Where(expression);
        }

        public IEnumerable<T> GetAllTrue(bool state)
        {
            return db.Set<T>().Where(a => a.IsActive == state);
        }
    }
}
