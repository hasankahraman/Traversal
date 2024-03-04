using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Traversal.ViewComponents.Default
{
    public class _SubAboutVC : ViewComponent
    {
        SubAboutManager subAboutManager = new SubAboutManager(new EFSubAboutDAL());
        public IViewComponentResult Invoke()
        {
            var subAbouts = subAboutManager.GetAll();
            return View(subAbouts);
        }        
    }
}
