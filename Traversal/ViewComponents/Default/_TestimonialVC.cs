using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Traversal.ViewComponents.Default
{
    public class _TestimonialVC : ViewComponent
    {
        TestimonialManager testimonialManager = new TestimonialManager(new EFTestimonialDAL());
        public IViewComponentResult Invoke()
        {
            var testimonials = testimonialManager.GetAll();
            return View(testimonials);
        }
    }
}
