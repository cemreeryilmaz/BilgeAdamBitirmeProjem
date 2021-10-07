using Shop.DataAccess.Abstract;
using Shop.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Shop.Core.DataAccess.Concrete.EntityFramework;
using Shop.DataAccess.Concrete.EntityFramework.Contexts;

namespace Shop.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product,ShopContext>, IProductDal
    {
        
    }
}