using Microsoft.AspNetCore.Mvc;

namespace WebApplication10_KullanıcıdanRouteUzerindenDataAlma.Controllers
{
    public class ProductController : Controller
    {
        //public IActionResult Index(string id, int a, int b)
        //{
        //    var value = Request.RouteValues;
        //    var deger = value.Values;

        //    List<string> list = new List<string>();
        //    foreach (var item in deger)
        //    {
        //        list.Add(item.ToString());
        //    }
        //    ViewBag.test = list;
        //    //Parametredeki sıralamanın önemi yok önemli olan endpointde ki sıralama.
        //    return View();
        //}

        //Header üzerinden veri almak için tarayıcı sizlere yetki vermez bunun için postman uygulaması kullanılmalıdır.
        public IActionResult Index()
        {
            var values = Request.Headers.ToList();
            return View();
        }
    }
}
