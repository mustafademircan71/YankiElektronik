using System;
using System.Collections.Generic;
using System.Text;
using Yanki.DataAccess.Abstract.EntityDal;
using Yanki.DataAccess.Repositories;
using Yanki.Entity.Concrete;

namespace Yanki.DataAccess.EntityFramework
{
    public class EfDeviceRepository:GenericRepository<Device>,IDeviceDal

    {
    }
}
