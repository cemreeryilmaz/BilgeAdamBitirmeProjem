using Shop.Core.DataAccess.Concrete.EntityFramework;
using Shop.DataAccess.Abstract;
using Shop.DataAccess.Concrete.EntityFramework.Contexts;
using Shop.Entities.Concrete;

namespace Shop.DataAccess.Concrete.EntityFramework
{
    public class EfTicketDal : EfEntityRepositoryBase<Ticket, ShopContext>, ITicketDal
    {
        
    }
}