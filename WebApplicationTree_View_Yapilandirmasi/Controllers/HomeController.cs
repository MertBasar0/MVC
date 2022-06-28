using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApplicationTree_View_Yapilandirmasi.Models;

namespace WebApplicationTree_View_Yapilandirmasi.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Index2()
        {
            IEnumerable<Product> products = new List<Product>()
            {
                new Product() { Id = 1, ProductName = "elma", UnitPrice = 3},
                new Product() { Id = 2, ProductName = "armut", UnitPrice = 4},
                new Product() { Id = 3, ProductName = "mandalina", UnitPrice = 6}
            };
            return View(products);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
