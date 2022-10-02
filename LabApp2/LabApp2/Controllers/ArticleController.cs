using LabApp2.Models;
using Microsoft.AspNetCore.Mvc;

namespace LabApp2.Controllers
{
    public class ArticleController : Controller
    {
        public IActionResult Article()
        {
            return View();
        }

        [HttpPost]
        public IActionResult OnAdd(ArticleViewModel model)
        {
            if (ModelState.IsValid)
            {

                if (model.Comment != null)
                {
                    ViewBag.AddedComment = model.Comment;
                }
                return View("Article");
            }
            else
            {
                return View("Article");
            }
        }
    }
}
