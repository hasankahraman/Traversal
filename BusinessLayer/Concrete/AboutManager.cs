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
    public class AboutManager : IAboutService
    {
        IAboutDAL _aboutDAL;

        public AboutManager(IAboutDAL aboutDAL)
        {
            _aboutDAL = aboutDAL;
        }

        public void Add(About t)
        {
            _aboutDAL.Insert(t);
        }

        public void Delete(About t)
        {
            _aboutDAL.Delete(t);
        }

        public List<About> GetAll()
        {
            return _aboutDAL.GetAll();
        }

        public About GetById(int id)
        {
            return _aboutDAL.GetAll().Where(x=> x.Id == id).FirstOrDefault();
        }

        public void Update(About t)
        {
            _aboutDAL.Update(t);
        }
    }
}
