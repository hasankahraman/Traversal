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
    public class Featured1Manager : IFeatured1Service
    {
        IFeatured1DAL _featured1DAL;

        public Featured1Manager(IFeatured1DAL featuredDAL)
        {
            _featured1DAL = featuredDAL;
        }

        public void Add(Featured1 t)
        {
            _featured1DAL.Insert(t);
        }

        public void Delete(Featured1 t)
        {
            _featured1DAL.Delete(t);
        }

        public List<Featured1> GetAll()
        {
            return _featured1DAL.GetAll();
        }

        public Featured1 GetById(int id)
        {
            return _featured1DAL.GetAll().Where(x => x.Id == id).FirstOrDefault();
        }

        public void Update(Featured1 t)
        {
            _featured1DAL.Update(t);
        }
    }
}
