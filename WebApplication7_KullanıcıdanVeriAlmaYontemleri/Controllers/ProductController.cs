using Microsoft.AspNetCore.Mvc;
using WebApplication7_KullanıcıdanVeriAlmaYontemleri.Models;

namespace WebApplication7_KullanıcıdanVeriAlmaYontemleri.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult Index(IFormCollection datas)
        //{
        //    //IFormCollection yapısı ile form üzerinden nesneler rahatlıkla alınabilir.

        //    var value1 = datas["txtValue1"].ToString();
        //    var value2 = datas["txtValue2"].ToString();
        //    var value3 = datas["txtValue3"].ToString();
        //    return View();
        //}


                //2. Yöntem

        //[HttpPost]
        //public IActionResult Index(string txtValue1, string txtValue2, string txtValue3)
        //{
        //    var deger1 = txtValue1;

        //    //IFormCollection yapısı ile form üzerinde neneler rahatlıkla alınabilirler.

        //    return View();
        //}


        [HttpPost]
        public IActionResult Index(Product Product)
        {
            return View();
        }
    }
}
