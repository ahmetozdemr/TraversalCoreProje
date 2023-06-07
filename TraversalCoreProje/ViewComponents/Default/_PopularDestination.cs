using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalMvcUI.ViewComponents.Default
{
    public class _PopularDestination : ViewComponent
    {

        public IViewComponentResult Invoke()
        {
      
            return View();
        }
    }
}
