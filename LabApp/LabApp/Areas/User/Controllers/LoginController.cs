using LabApp.Areas.User.Models;
using Microsoft.AspNetCore.Mvc;

namespace LabApp.Areas.User.Controllers
{
    public class LoginController : Controller
    {
        [Area("User")]
        [Route("User/[controller]/[action]")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult OnUserLogin(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Dashboard", "Dashboard", new {Area="User"});
            }
            return RedirectToAction("Login", "Login", new { Area = "User" });

        }
    }
}
