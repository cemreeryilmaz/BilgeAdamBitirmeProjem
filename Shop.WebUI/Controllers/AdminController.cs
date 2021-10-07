using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Shop.Business.Abstract;
using Shop.WebUI.Models;

namespace Shop.WebUI.Controllers
{
    // [Authorize]
    public class AdminController : Controller
    {
        private IProductService _productService;
        private ICategoryService _categoryService;
        private IOrderService _orderService;
        private ITicketService _ticketService;
        private IUserService _userService;

        public AdminController(IProductService productService, ICategoryService categoryService, IOrderService orderService, ITicketService ticketService, IUserService userService)
        {
            _productService = productService;
            _categoryService = categoryService;
            _orderService = orderService;
            _ticketService = ticketService;
            _userService = userService;
        }

        public ActionResult Index()
        {
            var adminListViewModel = new AdminListViewModel
            {
                Products = _productService.GetAll(),
                Categories = _categoryService.GetAll(),
                Orders = _orderService.GetAll(),
                Users = _userService.GetAll(),
                Tickets = _ticketService.GetAll()
            };
            return View(adminListViewModel);
        }
    }
}
