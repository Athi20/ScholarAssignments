using Microsoft.AspNetCore.Mvc;

namespace LabApp2.Components
{
    public class CommentCountViewComponent:ViewComponent
    {

            static int count=0;
            public IViewComponentResult Invoke(int CommentCount)
            {
                count++;
                return View("~/views/components/_CommentsCount.cshtml", count);
            }
        
    }
}
