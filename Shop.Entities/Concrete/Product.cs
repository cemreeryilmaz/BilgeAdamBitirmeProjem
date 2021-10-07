using Shop.Core.Entities.Abstract;

namespace Shop.Entities.Concrete
{
    public class Product : IEntity
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public string ImagePath { get; set; }
        public int Status { get; set; }
        public string ProductDetail { get; set; }

    }
}