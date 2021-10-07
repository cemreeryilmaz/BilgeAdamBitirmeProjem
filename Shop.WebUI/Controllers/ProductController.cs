using Microsoft.AspNetCore.Mvc;
using Shop.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop.Entities.Concrete;
using Shop.WebUI.Models;

namespace Shop.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _productService;
        private ICategoryService _categoryService;

        public ProductController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        public IActionResult Index(int category)
        {
            var model = new ProductListViewModel
            {
                Products = category>0?_productService.GetByCategory(category):_productService.GetAll()
            };
            return View(model);
        }

        public IActionResult ProductDetail(int id)
        {
            
            return View(id);

        }

        public ActionResult AdminProductIndex()
        {
            var productListViewModel = new ProductListViewModel
            {
                Products = _productService.GetAll(),
                Categories = _categoryService.GetAll()
            };
            return View(productListViewModel);

        }

        public ActionResult Add()
        {
            var model = new ProductAddViewModel
            {
                Product = new Product(),
                Categories = _categoryService.GetAll()
            };
            return View(model);

        }
        [HttpPost]
        public ActionResult Add(Product product)
        {
            if (ModelState.IsValid)
            {
                _productService.Add(product);
            }
           
            return RedirectToAction("AdminProductIndex");

        }

        public ActionResult Update(int productId)
        {
            var model = new ProductUpdateViewModel
            {
                Product = _productService.GetById(productId),
                Categories = _categoryService.GetAll()
            };
            return View(model);
        }

        [HttpPost]
        public ActionResult Update(Product product)
        {
            if (ModelState.IsValid)
            {
                _productService.Update(product);
            }

            return RedirectToAction("Update");

        }

        
        //public ActionResult Delete(int productId)
        //{
        //    _productService.Delete(productId);
        //    return RedirectToAction("AdminProductIndex");

        //}
    }
}
