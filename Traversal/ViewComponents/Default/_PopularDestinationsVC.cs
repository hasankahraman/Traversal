using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Traversal.ViewComponents.Default
{
    public class _PopularDestinationsVC : ViewComponent
    {
        DestinationManager destinationManager = new DestinationManager(new EFDestinationDAL());
        public IViewComponentResult Invoke()
        {
            var destinations = destinationManager.GetAll();
            return View(destinations);
        }
    }
}
