using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Matjar.DataContexts;
using Matjar.Models;
using System.IO;

namespace Matjar.Controllers
{
    public class ProductsController : Controller
    {
        private MatjarDbContext db = new MatjarDbContext();

        // GET: Products
        public ActionResult Index()
        {
            var products = db.Products.Include(p => p.Category);
            return View(products.ToList());
        }

        // GET: Products/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // GET: Products/ItemDetail/5
        public ActionResult ItemDetail(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // GET: Products/Create
        public ActionResult Create()
        {
            ViewBag.CategoryId = new SelectList(db.Categories, "CategoryId", "CategoryName");
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProductId,ProductName,ProductDescription,Price,IsPublished,ShowOnHomePage,CategoryId")] Product product, HttpPostedFileBase file)
        {
            if (ModelState.IsValid)
            {
                
                string productImageFolder = Server.MapPath("~/Content/Images/x580x420");
                //if (!Directory.Exists(productImageFolder)) Directory.CreateDirectory(productImageFolder);
                string productImageName = System.Guid.NewGuid().ToString();
                string productImagePath = Path.Combine(productImageFolder, productImageName);
                ImageResizer.ImageJob productImage = new ImageResizer.ImageJob(file, productImagePath,
                    new ImageResizer.Instructions("width=580;height=420;format=jpg;mode=max"), false, true);
                productImage.CreateParentDirectory = true;
                productImage.Build();

                string productThumbnailFolder = Server.MapPath("~/Content/Images/x100x100");
                //if (!Directory.Exists(productImageFolder)) Directory.CreateDirectory(productImageFolder);
                string productThumbnailPath = Path.Combine(productThumbnailFolder, productImageName);
                ImageResizer.ImageJob productThumbnail = new ImageResizer.ImageJob(file, productThumbnailPath,
                    new ImageResizer.Instructions("width=100;height=100;format=jpg;mode=max"), false, true);
                productThumbnail.CreateParentDirectory = true;
                productThumbnail.Build();

                Image image = new Image
                {
                    ImageName = Path.GetFileName(productImage.FinalPath)
                };

                product.Images.Add(image);
                db.Products.Add(product);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CategoryId = new SelectList(db.Categories, "CategoryId", "CategoryName", product.CategoryId);
            return View(product);
        }

        // GET: Products/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            ViewBag.CategoryId = new SelectList(db.Categories, "CategoryId", "CategoryName", product.CategoryId);
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProductId,ProductName,ProductDescription,Price,IsPublished,ShowOnHomePage,CategoryId")] Product product)
        {
            if (ModelState.IsValid)
            {
                db.Entry(product).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CategoryId = new SelectList(db.Categories, "CategoryId", "CategoryName", product.CategoryId);
            return View(product);
        }

        // GET: Products/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Product product = db.Products.Find(id);
            db.Products.Remove(product);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
