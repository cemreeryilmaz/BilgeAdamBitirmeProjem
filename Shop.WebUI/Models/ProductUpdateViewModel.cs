using Shop.Entities.Concrete;
using System.Collections.Generic;

namespace Shop.WebUI
{
    public class ProductUpdateViewModel
    {
        public Product Product { get; set; }
        public List<Category> Categories { get; set; }
    }
}