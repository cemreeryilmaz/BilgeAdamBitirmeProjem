using Shop.Core.Entities.Abstract;
using Shop.Entities.Concrete;

namespace Shop.Entities.DomainModels
{
    public class CartLine:IDomainModel
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}