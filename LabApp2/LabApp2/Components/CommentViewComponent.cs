using Microsoft.AspNetCore.Mvc;

namespace LabApp2.Components
{
    public class CommentViewComponent: ViewComponent
    {
        static List<string> comments = new List<string> { "First comment"};
        public IViewComponentResult Invoke(string NewComment)
        {
            if (NewComment != null)
            {
                comments.Add(new string (NewComment));
              
            }
            return View("~/views/components/_Comments.cshtml", comments);

        }
    }
}
