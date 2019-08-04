using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppCRUD.Models;

namespace WebAppCRUD.Controllers
{
    public class ProductController : Controller
    {
        static Product[] catagory = {
            new Product(0, "p1", 120.25f, 5),
            new Product(1, "p2", 200f, 10),
            new Product(2, "p3", 150, 7),
            new Product(3, "p4", 300, 13),
            new Product(4, "p5", 175.75f, 3),
            new Product(5, "p6", 120.25f, 10),
            new Product(6, "p7", 100, 5),
        };
        static private List<Product> productsList = new List<Product>(catagory);
        static private int idCount = productsList.Count;

        // GET: Product
        public ActionResult Index()
        {
            return View(productsList);
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            return View(productsList.ElementAt(id));
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(Product collection)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    collection.ProductId = idCount;
                    idCount++;
                    productsList.Add(collection);
                    return RedirectToAction("Index");
                }
                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            return View(productsList.ElementAt(id));
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Product collection)
        {
            try
            {
                // TODO: Add update logic here
                productsList[id].ProductName = collection.ProductName;
                productsList[id].ProductPrice = collection.ProductPrice;
                productsList[id].ProductAmount = collection.ProductAmount;
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            return View(productsList.ElementAt(id));
        }

        // POST: Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                productsList.RemoveAt(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
