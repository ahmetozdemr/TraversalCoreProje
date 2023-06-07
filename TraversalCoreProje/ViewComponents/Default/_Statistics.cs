using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalMvcUI.ViewComponents.Default
{
    public class _Statistics : ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
