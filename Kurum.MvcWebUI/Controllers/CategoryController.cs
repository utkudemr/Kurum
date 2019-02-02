using Kurum.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kurum.MvcWebUI.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category

        private ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public PartialViewResult List(int category=0)
        {
            ViewBag.category = category;
            return PartialView(_categoryService.GetAll());
        }
    }
}