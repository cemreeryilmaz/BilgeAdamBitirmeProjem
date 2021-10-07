using System.Collections.Generic;
using Shop.Entities.Concrete;
using Shop.Entities.DomainModels;

namespace Shop.Business.Abstract
{
    public interface ICartService
    {
        void AddToCart(Cart cart, Product product);
        void RemoveFromCart(Cart cart, int productId);
        List<CartLine> List(Cart cart);
    }
}