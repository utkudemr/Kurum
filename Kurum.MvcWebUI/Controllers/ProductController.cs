using Kurum.Bll.Concrete;
using Kurum.Dal.Concrete.EntityFramework;
using Kurum.Interfaces;
using Kurum.MvcWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kurum.MvcWebUI.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        public int pageSize = 5;
        public ActionResult Index(int category=0,int page=1)
        {
            var products = _productService.GetAll().Where(p => p.CategoryId == category || category == 0).ToList() ;
            return View(new ProductViewModel
            {
               Product=products.Skip((page - 1) * pageSize).Take(5).ToList(),
                PaggingInfo = new PagingInfo
                {
                    ItemsPerPage = pageSize,
                    TotalItems = products.Count,
                    CurrentPage = page,
                    CurrentCategory=category
                }
            });
        }
        public ActionResult Deneme()
        {
            return View();
        }

        
    }
}