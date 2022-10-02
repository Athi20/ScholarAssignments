
using LabApp.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;


namespace LabApp.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        [Area("Admin")]
        [Route("[controller]/[action]")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult OnLogin(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Dashboard","Dashboard", new { Area = "Admin" });
            }
            return RedirectToAction("Login","Login", new { Area = "Admin" });

        }
    }
}
