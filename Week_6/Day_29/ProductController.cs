using Microsoft.AspNetCore.Mvc;
using WebApplication5.Models;
using System.Collections.Generic;
using System.Linq;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    public class ProductController : Controller
    {
        static List<Product> products = new List<Product>();

        // READ (List)
        public IActionResult Index()
        {
            return View(products);
        }

        // CREATE - GET
        public IActionResult Create()
        {
            return View();
        }

        // CREATE - POST
        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                products.Add(product);
                return RedirectToAction("Index");
            }
            return View(product);
        }

        // EDIT - GET
        public IActionResult Edit(int id)
        {
            var product = products.FirstOrDefault(p => p.ProductId == id);
            return View(product);
        }

        // EDIT - POST
        [HttpPost]
        public IActionResult Edit(Product product)
        {
            var existing = products.FirstOrDefault(p => p.ProductId == product.ProductId);
            if (existing != null)
            {
                existing.ProductName = product.ProductName;
                existing.Price = product.Price;
                existing.Category = product.Category;
            }
            return RedirectToAction("Index");
        }

        // DELETE
        public IActionResult Delete(int id)
        {
            var product = products.FirstOrDefault(p => p.ProductId == id);
            if (product != null)
            {
                products.Remove(product);
            }
            return RedirectToAction("Index");
        }
    }
}