using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Traversal.ViewComponents.Default
{
    public class _Featured2VC : ViewComponent
    {
        
            Featured2Manager featured2Manager = new Featured2Manager(new EFFeatured2DAL());
            public IViewComponentResult Invoke()
            {
                var featured2 = featured2Manager.GetAll();
                return View(featured2);
            }
        }        
    }
