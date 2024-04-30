using CascadingDDLCoreDemo.Data.Repository.IRepository;
using CascadingDDLCoreDemo.Models;

namespace CascadingDDLCoreDemo.Data.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db= db;
        }
        public void Update(Product product)
        {
            _db.Products.Update(product);
        }
    }
}
