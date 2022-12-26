using System.Linq.Expressions;

namespace ApiCatalogo.Repository.BaseRepository
{
    public interface IRepository<T>
    {
        public IQueryable<T> GetAll();
        public T GetPorId(Expression<Func<T,bool>> predicate);
        public void Update (T entity);
        public void Delete (T entity);
        public void Add(T entity);  
    }
}
