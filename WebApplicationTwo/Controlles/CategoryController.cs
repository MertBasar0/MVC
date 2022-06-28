using Microsoft.AspNetCore.Mvc;

namespace WebApplicationTwo.Controlles
{
    //[NonController]
    //Eğer bir controllerdan controller özelliğini kaldırmak isterseniz non attiribute u kullanılır.
    public class CategoryController : Controller
    {
        //Nonaction ve Non controller
        //Normal controller altında bulunan bütün metotları action metorlarıdır. >aten normal düzende de iş kurallarımızı asla controller altında tutmamalıyız.
        //Olduki böyle bir hata yaptınız ve tuttunuz. Bu fonksiyonlar ile action ve controller üzerinde request karşılama üzelliğini kaldırmış olursunuz.

        //[NonAction]  // controller içerisindeki nonaction attribute'u işaretlenen fonksiyonlar dışında request karşılamaz.
                     // Sadece operatif olarak yani algoritma barındıran iş süreçllerini yürüten bir metot olacaktır.
        public IActionResult CategoryIndex()
        {
            return View();
        }
    }
}
