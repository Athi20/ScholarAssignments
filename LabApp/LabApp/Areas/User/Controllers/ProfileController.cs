using Microsoft.AspNetCore.Mvc;

namespace LabApp.Areas.User.Controllers
{
    public class ProfileController : Controller
    {
        [Area("User")]
        [Route("User/[controller]/[action]")]
        public IActionResult Profile()
        {
            return View();
        }
    }
}
