using Microsoft.AspNetCore.Mvc;

namespace WebApplication5_TagHelpers.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
