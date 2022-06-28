using Microsoft.AspNetCore.Mvc;

namespace WebApplication11_KullanıcıdanVeriAlmaAjax.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(string a, string b)
        {
            return View();
        }
    }
}
