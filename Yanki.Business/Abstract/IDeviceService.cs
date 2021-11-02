using System;
using System.Collections.Generic;
using System.Text;
using Yanki.Entity.Concrete;

namespace Yanki.Business.Abstract
{
    public interface IDeviceService
    {
        void DeviceAdd(Device device);
        void DeviceDelete(Device device);
        void DeviceUpdate(Device device);
        List<Device> GetList();
        Device GetById(int id);
    }
}
