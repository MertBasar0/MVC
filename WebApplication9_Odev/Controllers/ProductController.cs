using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication9_Odev.Dal;
using WebApplication9_Odev.Models;

namespace WebApplication9_Odev.Controllers
{
    public class ProductController : Controller
    {

        public void productList(Product ps)
        {
            using (TestContext ts = new TestContext())
            {
                //List<Product> products = new List<Product>();
                //foreach (var item in ts.Products.ToList())
                //{
                //    products.Add(item);
                //}
                ts.Products.Add(ps);
                ts.SaveChanges();
            }
        }

        //public IActionResult Index()
        //{
        //    return View(productList());
        //}

        //[HttpPost]
        //public IActionResult Index(Product prd)
        //{
        //    return View();
        //}

    }
}
