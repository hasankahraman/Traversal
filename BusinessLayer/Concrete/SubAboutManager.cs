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
    public class SubAboutManager : ISubAboutService
    {
        ISubAboutDAL _subAboutDAL;

        public SubAboutManager(ISubAboutDAL subAboutDAL)
        {
            _subAboutDAL = subAboutDAL;
        }

        public void Add(SubAbout t)
        {
            _subAboutDAL.Insert(t);
        }

        public void Delete(SubAbout t)
        {
            _subAboutDAL.Delete(t);
        }

        public List<SubAbout> GetAll()
        {
            return _subAboutDAL.GetAll();
        }

        public SubAbout GetById(int id)
        {
            return _subAboutDAL.GetAll().Where(x=> x.Id == id).FirstOrDefault();
        }

        public void Update(SubAbout t)
        {
            _subAboutDAL.Update(t);
        }
    }
}
