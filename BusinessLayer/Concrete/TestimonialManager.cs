using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class TestimonialManager : ITestimonalService
    {
        ITestimonialDAL _testimonialDAL;

        public TestimonialManager(ITestimonialDAL testimonialDAL)
        {
            _testimonialDAL = testimonialDAL;
        }

        public void Add(Testimonial t)
        {
            _testimonialDAL.Insert(t);
        }

        public void Delete(Testimonial t)
        {
            _testimonialDAL.Delete(t);
        }

        public List<Testimonial> GetAll()
        {
            return _testimonialDAL.GetAll();
        }

        public Testimonial GetById(int id)
        {
            return _testimonialDAL.GetAll().Where(x => x.Id == id).FirstOrDefault();
        }

        public void Update(Testimonial t)
        {
            _testimonialDAL.Update(t);
        }
    }
}
