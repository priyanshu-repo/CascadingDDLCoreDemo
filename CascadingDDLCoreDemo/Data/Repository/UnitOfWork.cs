using CascadingDDLCoreDemo.Data.Repository.IRepository;

namespace CascadingDDLCoreDemo.Data.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _db;
        private ICategoryRepository _catRepo;
        private IProductRepository _productRepo;

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
        }
        public ICategoryRepository Category
        {
            get
            {
                if (_catRepo == null)
                {
                    _catRepo = new CategoryRepository(_db);
                }
                return _catRepo;
            }
        }

        public IProductRepository Product
        {
            get
            {
                if (_productRepo == null)
                {
                    _productRepo = new ProductRepository(_db);
                }
                return _productRepo;
            }
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
