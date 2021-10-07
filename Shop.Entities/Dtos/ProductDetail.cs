using Shop.Core.Entities.Abstract;

namespace Shop.Entities.Dtos
{
    public class ProductDetail:IDto
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string CategoryName { get; set; }
    }
}