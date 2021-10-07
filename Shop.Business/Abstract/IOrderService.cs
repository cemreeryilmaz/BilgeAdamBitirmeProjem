using System.Collections.Generic;
using Shop.Entities.Concrete;

namespace Shop.Business.Abstract
{
    public interface IOrderService
    {
        List<Order> GetAll();
        Order GetById(int orderId);
        void Add(Order order);
        void Update(Order order);
        void Delete(Order order);

    }
}