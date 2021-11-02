using System;
using System.Collections.Generic;
using System.Text;
using Yanki.Business.Abstract;
using Yanki.DataAccess.Abstract.EntityDal;
using Yanki.Entity.Concrete;

namespace Yanki.Business.Concrete
{
    public class ServiceManager : IServicesService
    {
        IServiceDal _serviceDal;
        public ServiceManager(IServiceDal serviceDal)
        {
            _serviceDal = serviceDal;
        }
        public Service GetById(int id)
        {
            return _serviceDal.GetById(id);
        }

        public List<Service> GetList()
        {
          return  _serviceDal.GetAll();
        }

        public void ServiceAdd(Service service)
        {
            _serviceDal.Insert(service);
        }

        public void ServiceDelete(Service service)
        {
            _serviceDal.Delete(service);
        }

        public void ServiceUpdate(Service service)
        {
            _serviceDal.Update(service);
        }
    }
}
