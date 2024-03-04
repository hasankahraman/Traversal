using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Traversal.ViewComponents.Default
{
    public class _Featured1VC : ViewComponent
    {
        Featured1Manager featured1Manager = new Featured1Manager(new EFFeatured1DAL());
        public IViewComponentResult Invoke()
        {
            var featured1 = featured1Manager.GetAll().FirstOrDefault();
            return View(featured1);
        }
    }
}
