using Microsoft.AspNetCore.Mvc;
using WebApplication6_ModelBindingMekanizmasi.Models;

namespace WebApplication6_ModelBindingMekanizmasi.Controllers
{
    public class ProductController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var product = new Product
            {
                ProductID = 1,
                ProductName = "armut",
                UnitPrice = 3
            };
            return View(product);

            //Eğer get işleminde nesneyi buraya üretip gönderirseniz view'e post işleminde yine bu nesne doldurulup gönderilecektir.
        }
        //ModelBinding
        [HttpPost]
        public IActionResult Index(Product Product)
        {
            return View();
        }

        //Input Nesnelerini name değerlerinin parametreleri üzerinden eşleştirilerek bind eidlme işlemi

        //[HttpPost]
        //public IActionResult Index(string txtProductName, string txtUnitPrice)
        //{
        //    return View();
        //}
    }
}
