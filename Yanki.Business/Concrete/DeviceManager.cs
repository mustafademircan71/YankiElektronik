using System;
using System.Collections.Generic;
using System.Text;
using Yanki.Business.Abstract;
using Yanki.DataAccess.Abstract.EntityDal;
using Yanki.Entity.Concrete;

namespace Yanki.Business.Concrete
{
    public class DeviceManager : IDeviceService
    {
        IDeviceDal _deviceDal;
        public DeviceManager(IDeviceDal deviceDal)
        {
            _deviceDal = deviceDal;
        }
        public void DeviceAdd(Device device)
        {
            _deviceDal.Insert(device);
        }

        public void DeviceDelete(Device device)
        {
            _deviceDal.Delete(device);
        }

        public void DeviceUpdate(Device device)
        {
            _deviceDal.Update(device);
        }

        public Device GetById(int id)
        {
            return _deviceDal.GetById(id);
        }

        public List<Device> GetList()
        {
            return _deviceDal.GetAll();
        }
    }
}
