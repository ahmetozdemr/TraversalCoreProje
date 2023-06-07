using Microsoft.AspNetCore.Mvc;

namespace TraversalMvcUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
