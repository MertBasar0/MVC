using Microsoft.AspNetCore.Mvc;

namespace WebApplication17_DerinlemesineRouting.Controllers
{
    public class DynamicRoute : Controller
    {
        public IActionResult Detail(string name, string id)
        {
            return View();
        }
    }
}
