using Microsoft.AspNetCore.Mvc;
using WebApplication8_QueryStringVeriAlma.Models;

namespace WebApplication8_QueryStringVeriAlma.Controllers
{
    public class ProductController : Controller
    {
        //Query String : Güvenlik gerektirmeyen bilgilerin url üzerinden taşınması için kullanılan yapılardır.
        //https://:..........................com /sehir/istanbul?ilce="Kadikoy"
        //QueryString yapılan request türü ne olursa olsun string değeri taşınabilir.


        //public IActionResult Index()
        //{
        //    return View();
        //}

        //public IActionResult Index(int a, int b)
        //{
        //    return View();
        //}


        //Bu url'i tetiklediğinizde
        //https://localhost:44394/product/index/?a=5&B=50

    //    public IActionResult Index()
    //    {
    //        var QueryString = Request.QueryString; //Request yapılan endpoint'e querystring parametresi eklenmiş mi eklenmemiş mi
    //                                               //bunla ilgili bilgi verir.

    //        var a = Request.Query["a"].ToString();
    //        var b = Request.Query["b"].ToString();


    //        return View();
    //    }

        public IActionResult Index()
        {
            Product product = new Product()
            {
                ProductID = 1,
                ProductName ="armut",
                UnitPrice = 4
            };
            return View(product);
        }
    }
}
