using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop.Business.Abstract;
using Shop.Entities.Concrete;
using Shop.Entities.DomainModels;
using Shop.WebUI.Helpers;
using Shop.WebUI.Models;

namespace Shop.WebUI.Controllers
{
    public class CartController : Controller
    {
        private ICartService _cartService;
        private ICartSessionHelper _cartSessionHelper;
        private IProductService _productService;

        public CartController(ICartService cartService, ICartSessionHelper cartSessionHelper, IProductService productService)
        {
            _cartService = cartService;
            _cartSessionHelper = cartSessionHelper;
            _productService = productService;
        }


        public IActionResult AddToCart(int productId)
        {

            Product product = _productService.GetById(productId);

            var cart = _cartSessionHelper.GetCart("cart");

            _cartService.AddToCart(cart, product);

            _cartSessionHelper.SetCart("cart", cart);

            TempData.Add("message", product.ProductName + " sepete eklendi!");

            return RedirectToAction("Index", "Product");
        }

        public IActionResult Index()
        {
            var model = new CartListViewModel
            {
                Cart = _cartSessionHelper.GetCart("cart")

            };
            return View(model);
        }

        public IActionResult RemoveFromCart(int productId)
        {
            Product product = _productService.GetById(productId);

            var cart = _cartSessionHelper.GetCart("cart");

            _cartService.RemoveFromCart(cart, productId);
            _cartSessionHelper.SetCart("cart", cart);

            TempData.Add("message", product.ProductName + " sepetten silindi!");

            return RedirectToAction("Index", "Cart");
        }


    }
}
