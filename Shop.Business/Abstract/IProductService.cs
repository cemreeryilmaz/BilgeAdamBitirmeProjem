using Shop.Entities.Concrete;
using System.Collections.Generic;

namespace Shop.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetByCategory(int categoryId);

        Product GetById(int productId);

        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
    }
}