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
    public class DestinationManager : IDestinationService
    {
        IDestinationDAL _destinationDAL;

        public DestinationManager(IDestinationDAL destinationDAL)
        {
            _destinationDAL = destinationDAL;
        }

        public void Add(Destination t)
        {
            _destinationDAL.Insert(t);
        }

        public void Delete(Destination t)
        {
            _destinationDAL.Delete(t);
        }

        public List<Destination> GetAll()
        {
            return _destinationDAL.GetAll();
        }

        public Destination GetById(int id)
        {
            return _destinationDAL.GetAll().Where(x => x.Id == id).FirstOrDefault();
        }

        public void Update(Destination t)
        {
            _destinationDAL.Update(t);
        }
    }
}
