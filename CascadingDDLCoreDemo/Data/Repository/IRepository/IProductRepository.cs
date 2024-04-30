using CascadingDDLCoreDemo.Models;

namespace CascadingDDLCoreDemo.Data.Repository.IRepository
{
    public interface IProductRepository:IRepository<Product>
    {
        void Update(Product product);
    }
}
