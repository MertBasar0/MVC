using Microsoft.AspNetCore.Mvc;
using WebApplication13_OdevValidationControll.Models;

namespace WebApplication13_OdevValidationControll.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Index(User usr)
        {
            if (ModelState.IsValid)
            {

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
