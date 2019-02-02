using Kurum.Entities;
using Kurum.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kurum.MvcWebUI.Controllers
{
    public class CartController : Controller
    {
        // GET: Cart
        //Session id si cookie de tutulur session bilgisi server tarafında tutulur....

        private IProductService _productService;
        public CartController(IProductService productService)
        {
            _productService = productService;
        }
        public ActionResult AddToCart(int productId)
        {
            Product product = _productService.Get(productId);
            var cart = (Cart)Session["cart"];
            if (cart == null)
            {
                cart = new Cart();
                Session["cart"] = cart;
            }
            cart.AddToCart(product, 1);
            //cart.AddToCart(product);
            return RedirectToAction("Index", cart);
        }
        public ActionResult Index()
        {
            var cart = (Cart)Session["cart"];

            return View(cart);
        }
        public ActionResult RemoveFromCard(int productId)
        {
            Product product = _productService.Get(productId);
            var cart = (Cart)Session["cart"];
            //if(cart!=null)
            //{
            //    cart = new Cart();
            //    Session["cart"] = cart;
            //}
            cart.RemoveFromCard(product);
            return RedirectToAction("Index", cart);
        }
        public ActionResult Checkout()
        {
            return View(new ShippingDetail());
        }
        [HttpPost]
        public ActionResult Checkout(ShippingDetail shippingDetail)
        {
            if (ModelState.IsValid)
            {
                return View("Completed");
            }
            else
            {
                return View(shippingDetail);
            }

        }

    }
}