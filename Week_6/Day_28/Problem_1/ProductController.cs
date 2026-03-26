using Microsoft.AspNetCore.Mvc;

using System.Collections.Generic;
using System.Linq;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class ProductController : Controller
    {
        // Sample data
        static List<Product> products = new List<Product>()
        {
            new Product { Id = 1, Name = "Laptop", Price = 50000 },
            new Product { Id = 2, Name = "Mobile", Price = 20000 },
            new Product { Id = 3, Name = "Tablet", Price = 15000 }
        };

        // INDEX → List all products
        public IActionResult Index()
        {
            return View(products);
        }

        // DETAILS → Show single product
        public IActionResult Details(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            return View(product);
        }
    }
}