using System.Collections.Generic;
using Shop.Entities.Concrete;

namespace Shop.WebUI.Models
{
    public class ProductAddViewModel
    {
        public Product Product { get; set; }
        public List<Category> Categories { get; internal set; }
    }
}