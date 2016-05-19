using Matjar.DataContexts;
using Matjar.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Matjar.Controllers
{
    public class ShoppingCartController : Controller
    {
        private MatjarDbContext db = new MatjarDbContext();

        // GET: ShoppingCart
        public ViewResult Index(string returnUrl)
        {
            return View(new ShoppingCartViewModel
            {
                Cart = GetCart(),
                ReturnUrl = returnUrl
            });
        }

        public RedirectToRouteResult AddToCart(int productId, string returnUrl)
        {
            Product product = db.Products.SingleOrDefault(p => p.ProductId == productId);

            if (product != null)
            {
                GetCart().AddItem(product, 1);
            }
            return RedirectToAction("Index", new { returnUrl });
        }

        public RedirectToRouteResult RemoveFromCart(int productId, string returnUrl)
        {
            GetCart().RemoveItem(productId);
            return RedirectToAction("Index", new { returnUrl });
        }

        public PartialViewResult CartWidget()
        {
            return PartialView(GetCart());
        }

        private ShoppingCartModel GetCart()
        {
            ShoppingCartModel cart = (ShoppingCartModel)Session["Cart"];

            if (cart == null)
            {
                cart = new ShoppingCartModel();
                Session["Cart"] = cart;
            }

            return cart;
        }
    }
}