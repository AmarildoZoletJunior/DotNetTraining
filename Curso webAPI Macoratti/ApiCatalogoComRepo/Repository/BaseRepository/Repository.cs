using ApiCatalogo.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ApiCatalogo.Repository.BaseRepository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly CatalogoContext _context;
        public Repository(CatalogoContext context)
        {
            _context = context;
        }


        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public IQueryable<T> GetAll()
        {
            return _context.Set<T>().AsNoTracking();
        }

        public T GetPorId(Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().AsNoTracking().SingleOrDefault(predicate);
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }
        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }
    }
}
