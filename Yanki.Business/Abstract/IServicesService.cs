using System;
using System.Collections.Generic;
using System.Text;
using Yanki.Entity.Concrete;

namespace Yanki.Business.Abstract
{
    public interface IServicesService
    {
        void ServiceAdd(Service service);
        void ServiceDelete(Service service);
        void ServiceUpdate(Service service);
        List<Service> GetList();
        Service GetById(int id);
    }
}
