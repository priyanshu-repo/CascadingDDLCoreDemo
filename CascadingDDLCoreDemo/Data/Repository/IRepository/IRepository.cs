using System.Linq.Expressions;

namespace CascadingDDLCoreDemo.Data.Repository.IRepository
{
    public interface IRepository<T> where T:class
    {
        IEnumerable<T> GetAll(string? includeProperties = null);
        T Get(Expression<Func<T, bool>>? filter = null);
        void Add(T entity);
        void Remove(T entity);
    }
}
