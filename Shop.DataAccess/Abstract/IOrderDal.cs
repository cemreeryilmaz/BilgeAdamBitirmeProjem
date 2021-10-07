using Shop.Core.DataAccess.Abstract;
using Shop.Entities.Concrete;

namespace Shop.DataAccess.Abstract
{
    public interface IOrderDal:IEntityRepository<Order>
    {
        
    }
}