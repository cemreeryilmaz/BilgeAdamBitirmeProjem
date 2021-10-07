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
    public class UserController : Controller
    {
        private IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        public IActionResult Index()
        {
            var model = new UserListViewModel()
            {
                Users = _userService.GetAll()
            };
            return View(model);
        }

        public ActionResult Add()
        {
            var model = new UserAddViewModel()
            {
                User = new User()


            };
            return View(model);

        }
        [HttpPost]
        public ActionResult Add(User user)
        {
            if (ModelState.IsValid)
            {
                _userService.Add(user);
            }

            return RedirectToAction("Index");

        }

        public ActionResult Update(int userId)
        {
            var model = new UserUpdateViewModel()
            {
                User = _userService.GetById(userId)
            };
            return View(model);
        }

        [HttpPost]
        public ActionResult Update(User user)
        {
            if (ModelState.IsValid)
            {
                _userService.Update(user);
            }

            return RedirectToAction("Update");

        }

        public ActionResult Delete(User user)
        {
            _userService.Delete(user);
            return RedirectToAction("Index");

        }
    }
}
