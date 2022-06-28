using Microsoft.AspNetCore.Mvc;
using WebApplication14_FluentValidation.Models;

namespace WebApplication14_FluentValidation.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Person prs)
        {
            if (ModelState.IsValid == true)
            {
                return View();
            }
            return View();
        }
    }
}
