using Microsoft.AspNetCore.Mvc;

namespace WebApplication4.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
            //3 çeşit helper metot çeşidi var bu metotlar
            //url helper // html helper // Tag helper
            //asp core ile gelen görevler neticesinde eklenmiş olan yeniliklerdir. Tag helperlar eski standartta yoktur. Html helperlar kullanılırdır.
            //Fakat html helperlar maliyetli olduğu için eskisi kadar sık kullanılmazlar.
        }
        #region UrlHelpers
        //Asp.net core mvc uyglulamalarında url oluşturmak için yatdımcı metotlar içeren o ankş url için parametreler üzerinde gönderilen değerleri url
        //verip bize sunan yardımcı metottur.
        //Üçerisinde bir çok metot barındırır.
        //Bunlar
        //Action: Verilen controller ve actiona ait url oluşturmaya yarayan metot.
        //Hostbilgisi getirmez.
        //Url.Action("index","product") => 
        //https://localhost:/5000/product/index

        //Content : Çok kullanılmazlar.  css ve script gibi dosya dizinlerini programatiik olarak görmek istersek kullanırız.

        //Kullanılmamasının nedeni => asp.netcore

        //Usestaticfiles middeware ile gelen static dosya yapılandırması bu görevi daha iyi yapmaktadır.
        //RouteUrl : Mimarinizde tanımladığınız route isimlerine uygun bir şekilde url oluşturan metotdur. Startup dosyası altında default olarak
        //hangisi ayarlandıysa o isme özel url oluşturulacaktır.
        //endpoints.MapDefaultControllerRoute() => Default Route gibi..
        //ActionContext => o anki url'e dair tüm bilgileri toplar getirir.
        #endregion

        #region htmlHelper
        //html etiketlerini server tabanlı oluşturmanızı sağlayan yardımcı metotlardır.
        //Hedeflenen .cshtml dosyalarını render etmemizi sağlamaktadır.
        //O anki contex' e dair bilgileri edinmemizi sağlamaktadır.

        //Veri taşıma kontrollerine erişmemizi sağlamaktadır.

        //metotlar
        //html.partial()
        //hedef view'i render etmenizi sağlayan bir fonksiyondur.
        
        //htmlform metotları
        //

        #endregion
    }
}
