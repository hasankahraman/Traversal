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
    public class Featured2Manager : IFeatured2Service
    {
        IFeatured2DAL _featured2DAL;

        public Featured2Manager(IFeatured2DAL featured2DAL)
        {
            _featured2DAL = featured2DAL;
        }

        public void Add(Featured2 t)
        {
            _featured2DAL.Insert(t);
        }

        public void Delete(Featured2 t)
        {
            _featured2DAL.Delete(t);
        }

        public List<Featured2> GetAll()
        {
            return _featured2DAL.GetAll();
        }

        public Featured2 GetById(int id)
        {
            return _featured2DAL.GetAll().Where(x => x.Id == id).FirstOrDefault();
        }

        public void Update(Featured2 t)
        {
            _featured2DAL.Update(t);
        }
    }
}
