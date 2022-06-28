using Microsoft.AspNetCore.Mvc;
using WebApplication17_DerinlemesineRouting.Models.UserInfoVm;

namespace WebApplication17_DerinlemesineRouting.Controllers
{
    [Route("Account")]
    public class UserAccountController : Controller
    {
        [Route("User")]
        public IActionResult Index()
        {
            var _userInfo = new UserInfoVM()
            {
                UserName = "mert",
                Email = "mertbasar0@hotmail.com",
                InformationText = "saga",
                Roles = new List<string> { "yazar", "Editör", "Frontend", "backend" }
            };
            return View(_userInfo);
        }

        //UserAccount/index => default useraccount /index url
        //Account/user => Route attribute kullandığımızda startup.cs dosyasınıda tanımlandığı kural tabanlı yönlendirmeden ,
        //farklı olarak controller ve actionlarda özel tanımlamalar ile kullanabiliriz.


        //[Route("parameters")]
        [HttpGet("ByParameters/{email}/{username}/{info}")]
        public IActionResult ByParameters(string email, string username, string info)
        {
            var userInfo = new UserInfoVM()
            {
                UserName = username,
                Email = email,
                InformationText = info
            };
            return View(userInfo);
        }
    }
}
