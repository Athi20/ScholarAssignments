using Microsoft.AspNetCore.Mvc;

namespace LabApp.Areas.User.Controllers
{
    public class DashboardController : Controller
    {
        [Area("User")]
        [Route("User/[controller]/[action]")]
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
