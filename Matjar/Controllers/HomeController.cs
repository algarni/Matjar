using Matjar.DataContexts;
using Matjar.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Matjar.Controllers
{
    
    public class HomeController : Controller
    {
        private MatjarDbContext db = new MatjarDbContext();

        public ActionResult Index()
        {
            var products = db.Products.Select(p => p).Where(p => p.IsPublished == true && p.ShowOnHomePage == true).ToList();
            return View(products);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}