using LabApp3.Models;
using Microsoft.AspNetCore.Mvc;

namespace LabApp3.Controllers
{
    public class SignUpController : Controller
    {
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult OnSignUp(SignUpViewModel model)
        {
            if (ModelState.IsValid)
            {
               //to do
            }
            return View();
        }
    }
}
