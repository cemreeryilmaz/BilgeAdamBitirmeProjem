using System.Collections.Generic;
using Shop.Business.Abstract;
using Shop.DataAccess.Abstract;
using Shop.Entities.Concrete;

namespace Shop.Business.Concrete
{
    public class OrderManager: IOrderService
    {
        private IOrderDal _orderDal;

        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }


        public List<Order> GetAll()
        {
            return _orderDal.GetList();
        }

        public Order GetById(int orderId)
        {
            return _orderDal.Get(o =>o.OrderId == orderId);
        }

        public void Add(Order order)
        {
            _orderDal.Add(order);
        }

        public void Update(Order order)
        {
            _orderDal.Update(order);
        }

        public void Delete(Order order)
        {
            _orderDal.Delete(order);
        }
    }
}