using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete.Destination;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Controllers
{
    public class CommentController : Controller
    {
        private CommentManager commentManager = new CommentManager(new EfCommentDal());
        [HttpGet]
        public PartialViewResult AddComment()
        {
            return PartialView();
        }
        [HttpPost]
        public IActionResult AddComment(Comment c)
        {
            c.CommentDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            c.CommentState = true;
            commentManager.TAdd(c);
            return RedirectToAction("Index","Destination");
        }
    }
}
