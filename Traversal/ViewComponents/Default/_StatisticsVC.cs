using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Traversal.ViewComponents.Default
{
    public class _StatisticsVC : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Context c = new Context();
            ViewBag.Destinations = c.Destinations.Count();
            ViewBag.Guides = c.Guides.Count();
            //ViewBag.Customers = c.
            return View();
        }
    }
}
