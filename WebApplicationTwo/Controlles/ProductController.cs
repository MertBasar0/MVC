    using Microsoft.AspNetCore.Mvc;
using WebApplicationTwo.Models;

namespace WebApplicationTwo.Controlles
{
    public class ProductController : Controller
    {
        //public IActionResult Index()
        //{
        //    Product product = new Product();
        //    product.Id = 1;
        //    product.ProductName = "Armut";
        //    product.UnitPrice = 5;

        //    ViewResult result = View("test");
        //    //Belirtilen view isimdeki dosyayı render eder.


        //    return result;


        //    //view fonksiyonu bu actitona ait bir view (cshtml) dosyasını tetikleyecek olan fonksiyondur.


        //}

        #region partialviewresult

        //public PartialViewResult index()
        //{
        //    PartialViewResult::
        //    //Ajax client üzerindde çalışır sayfaya git gel yapmadan çalışan bir yapıdır.
        //    //viewresult adlı dosya viewstartcs.html dsoyasını baz alır. Fakat Partialviewresult ilgili dosyayı baz almadan render eder.
        //}


        #endregion

        #region JsonResult
        //Üretilen datayı kson türüne dönüştürüp göndereceksen json result kullanabilirsiniz.
        //public IActionResult index()

        //{
        //    JsonResult donensonuc = Json(new Product()
        //    {
        //        Id = 1,
        //        ProductName = "BilgeAdam",
        //        UnitPrice = 5
        //    });
        //    return donensonuc;
        //}

        #endregion

        #region EmptyResult
        //Örnek:
        //Bazen gelen istekler neticesinde herhangi bir şey dönmek istemeyebiliriz. Böyle bir durumda emptyresult action türü kullanılmalıdır.
        //client'dan gelen istek geldi, işinizi yaptınız fakat geriye bir değer döndürmek istemiyorsunuz... işlemin bittiğine dair response döndürmek zorundasınız.
        //Fakat bu response'da değer taşımak zorunda değilsiniz.

        //public EmptyResult index()
        //{
        //    return new EmptyResult();
        //}
        #endregion


        #region ContentResult

        //public ContentResult index()
        //{
        //    return Content("gfgfgfgf");
        //}
        #endregion


        #region ActionResult
        //Bütün result tiplerinin base classıdır.
        //Gelen bir istek neticesinde geriye dönülecek action türleri değişkenlik gösterebildiği durumlarda kullanılır.

        //Fakat IActionResult'un interfaceidir. Yani poliformizm kurallarına uygulayarak çok biçimlilik şeklinde kullanılabileceği için diğer türlerin referansı bütün tip üzerinde tutmanızı sağlar.
        //public ActionResult index()
        //{
        //Bir yapının içerisinde ne dönüleceğini bilmiyorsanız tahmin edemiyorsanız bütün result türlerinin atası olan action result kullanılır.
        //    if (2 != 2)
        //    {
        //        //birşeyler vs vs
        //        return Json(new object());
        //    }
        //    else if (8>3)
        //    {
        //        return Content("metinsel ifade");
        //    }
        //    return View();  
        //}
        #endregion

        #region IActionResult

        //public IActionResult index()
        //{
        //    return new JsonResult(new Product()
        //    {
        //        ProductName =   "fasfasf",
        //        UnitPrice = 2
        //    });  
        //}
        #endregion

    }
}
