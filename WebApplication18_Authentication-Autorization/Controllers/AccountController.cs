using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebApplication18_Authentication_Autorization.Models.DTOs;
using WebApplication18_Authentication_Autorization.Models.Entities.Concrete;

namespace WebApplication18_Authentication_Autorization.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IPasswordHasher<AppUser> _passwordHasher;

        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, IPasswordHasher<AppUser> passwordHasher)
        {
            this._userManager = userManager;
            this._signInManager = signInManager;
            this._passwordHasher = passwordHasher;
        }


        #region Registration

        [AllowAnonymous]
        public IActionResult Register() => View();

        [HttpPost,ValidateAntiForgeryToken,AllowAnonymous]
        public async Task<IActionResult> Register(RegistorDTO model)
        {
            if (ModelState.IsValid)
            {
                AppUser appUser = new AppUser() { UserName = model.UserName, Email = model.Email };
                IdentityResult ıdentityResult = await _userManager.CreateAsync(appUser, model.Password);
                if (ıdentityResult.Succeeded)
                {
                    return RedirectToAction("Login");
                }
                else
                {
                    foreach (IdentityError error in ıdentityResult.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }

            }
            return View(model);
        }

        #endregion

        #region Login


        [AllowAnonymous]
        public IActionResult Login(string returnUrl)
        {
            return View(new LoginDTO { ReturnUrl = returnUrl});
        }

        [HttpPost,ValidateAntiForgeryToken,AllowAnonymous]
        public async  Task<IActionResult>  Login(LoginDTO login)
        {
            if (ModelState.IsValid)
            {
                AppUser user = await _userManager.FindByNameAsync(login.UserName);
                if (user == null)
                {
                    Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(user.UserName, user.PasswordHash, false, false);
                    if (result.Succeeded)
                    {
                        return Redirect(login.ReturnUrl ?? "/");
                    }
                    ModelState.AddModelError("", "hata");

                }
               
            }
            return View(login);
        }


        #endregion

        #region Edit
        //public async Task<IActionResult> Edit()
        //{
        //    AppUser user = await _userManager.FindByNameAsync(User.)
        //}
        #endregion

    }
}
