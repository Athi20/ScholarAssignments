using Microsoft.AspNetCore.Mvc;

namespace LabApp.Areas.Admin.Controllers
{
    public class ProfileController : Controller
    {
        [Area("Admin")]
        [Route("[controller]/[action]")]
        public IActionResult Profile()
        {
            return View();
        }
    }
}
