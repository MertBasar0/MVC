using Microsoft.AspNetCore.Mvc;
using WebApplication12_KullanıcıdanGelenVeriKontrolü.Models;

namespace WebApplication12_KullanıcıdanGelenVeriKontrolü.Controllers
{
    public class ProductController : Controller
    {

        //Kullanıcıdan gelen dataları switch ve if else yöntemleri ile kontrol etmezsiniz. Çok uzar çok kötü kod yazılmış olur.
        //Doğru bir yaklaşım değildir. Bu yöntem kullanılmamalıdır. Yönetilebilirlik ve esneklik yoktur.
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Product product)
        {
            //ModelState : Mvc'de bir type'ın data annotationsların durumunu kontrol eden geriye sonuç döndüren bir propert'dir.

            if (ModelState.IsValid)
            {
                //İşlemler // operasyonlar vs vs
            }
            else
            {
                ViewBag.hatamesaj = ModelState.Values.FirstOrDefault(x => x.ValidationState == 
                Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid).Errors[0].ErrorMessage;
            }
            return View();
        }
    }
}
