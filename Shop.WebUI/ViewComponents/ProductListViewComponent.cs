using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Shop.Business.Abstract;
using Shop.DataAccess.Abstract;
using Shop.WebUI.Models;

namespace Shop.WebUI.ViewComponents
{
    public class ProductListViewComponent : ViewComponent
    {
        private IProductService _productService;

        public ProductListViewComponent(IProductService productService)
        {
            _productService = productService;
        }

        public ViewViewComponentResult Invoke()
        {
            var model = new ProductListViewModel
            {
                Products = _productService.GetAll()
            };
            return View(model);
        }
    }
}
