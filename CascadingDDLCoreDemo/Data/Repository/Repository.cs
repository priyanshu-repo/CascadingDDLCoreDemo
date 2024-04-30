using CascadingDDLCoreDemo.Data.Repository.IRepository;
using System.Data.Entity;

namespace CascadingDDLCoreDemo.Data.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _db;

        public Repository(ApplicationDbContext db)
        {
            _db = db;

            //catching category in navigation in product 
            _db.Products.Include(x=>x.Category).Include(x=>x.CategoryId);   
        }

        ////approach 1
        //public void Add(T entity)
        //{
        //    _db.Set<T>().Add(entity);
        //}

        //approach 2
        public void Add(T entity) => _db.Set<T>().Add(entity);

        public T Get(System.Linq.Expressions.Expression<Func<T, bool>>? filter = null)
        {
            IQueryable<T> query;
            query = _db.Set<T>().Where(filter).AsNoTracking();
            return query.FirstOrDefault();
        }

        public IEnumerable<T> GetAll(string? includeProperties = null)
        {
            IQueryable<T> query = _db.Set<T>();
            if (!string.IsNullOrEmpty(includeProperties))
            {
                foreach (var includeProp in includeProperties
               .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProp);
                }
            }
            return query.ToList();
        }

        ////Approach 1
        //public void Remove(T entity)
        //{
        //    _db.Set<T>().Remove(entity);
        //}

        //Approach 2
        public void Remove(T entity) => _db.Set<T>().Remove(entity);
    }
}
