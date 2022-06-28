using Microsoft.AspNetCore.Mvc;

namespace WebApplicationOne.Controllers
{
    public class UserController : Controller
    {
        public IActionResult User()
        {
            return View();
        }
    }
}
