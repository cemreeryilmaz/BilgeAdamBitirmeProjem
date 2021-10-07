using System.Collections.Generic;
using Shop.Entities.Concrete;

namespace Shop.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();

        Category GetById(int categoryId);
        void Add(Category category);
        void Update(Category category);
        void Delete(Category category);

    }
}