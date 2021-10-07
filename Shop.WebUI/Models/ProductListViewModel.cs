using System.Collections.Generic;
using Shop.Entities.Concrete;
using Shop.Entities.DomainModels;

namespace Shop.WebUI.Models
{
    public class ProductListViewModel
    {
        public List<Product> Products { get; set; }
        public List<Category> Categories { get; internal set; }
    }
}