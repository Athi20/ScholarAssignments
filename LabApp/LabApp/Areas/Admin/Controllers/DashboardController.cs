using Microsoft.AspNetCore.Mvc;

namespace LabApp.Areas.Admin.Controllers
{
    public class DashboardController : Controller
    {
        [Area("Admin")]
        [Route("[controller]/[action]")]
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
