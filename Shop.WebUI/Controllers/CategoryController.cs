using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop.Business.Abstract;
using Shop.DataAccess.Abstract;
using Shop.Entities.Concrete;
using Shop.WebUI.Models;

namespace Shop.WebUI.Controllers
{
    public class CategoryController : Controller
    {
       

        private ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            var model = new CategoryListViewModel
            {
                Categories = _categoryService.GetAll()
            };
            return View(model);
        }

        public ActionResult AdminCategoryIndex()
        {
            var model = new CategoryListViewModel
            {
                Categories = _categoryService.GetAll()
            };
            return View(model);

        }

        public ActionResult Add()
        {
            var model = new CategoryAddViewModel()
            {
                Category = new Category()
               
               
            };
            return View(model);

        }
        [HttpPost]
        public ActionResult Add(Category category)
        {
            if (ModelState.IsValid)
            {
                _categoryService.Add(category);
            }

            return RedirectToAction("AdminCategoryIndex");

        }

        public ActionResult Update(int categoryId)
        {
            var model = new CategoryUpdateViewModel()
            {
                Category = _categoryService.GetById(categoryId)
            };
            return View(model);
        }

        [HttpPost]
        public ActionResult Update(Category category)
        {
            if (ModelState.IsValid)
            {
                _categoryService.Update(category);
            }

            return RedirectToAction("Update");

        }

        public ActionResult Delete(Category category)
        {
            _categoryService.Delete(category);
            return RedirectToAction("AdminCategoryIndex");

        }
    }
}
