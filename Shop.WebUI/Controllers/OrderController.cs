using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop.Business.Abstract;
using Shop.Entities.Concrete;
using Shop.WebUI.Models;

namespace Shop.WebUI.Controllers
{
    public class OrderController : Controller
    {
        private IOrderService _orderService;
        private IUserService _userService;
        private IProductService _productService;
        private ICategoryService _categoryService;
        private ITicketService _ticketService;


        public OrderController(IOrderService orderService, IProductService productService, ICategoryService categoryService, ITicketService ticketService, IUserService userService)
        {
            _orderService = orderService;
            _productService = productService;
            _categoryService = categoryService;
            _ticketService = ticketService;
            _userService = userService;
        }

        public IActionResult Index()
        {
            var model = new OrderListViewModel()
            {
                Products = _productService.GetAll(),
                Categories = _categoryService.GetAll(),
                Users = _userService.GetAll(),
                Tickets = _ticketService.GetAll(),
                Orders = _orderService.GetAll()
            };
            return View(model);
        }

        
    }
}
