using Microsoft.AspNetCore.Mvc;

namespace WebApplication10_KullanıcıdanRouteUzerindenDataAlma.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
