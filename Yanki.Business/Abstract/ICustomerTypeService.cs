using System;
using System.Collections.Generic;
using System.Text;
using Yanki.Entity.Concrete;

namespace Yanki.Business.Abstract
{
    public interface ICustomerTypeService
    {
        void CustomerTypeAdd(CustomerType customerType);
        void CustomerTypeDelete(CustomerType customerType);
        void CustomerTypeUpdate(CustomerType customerType);
        List<CustomerType> GetList();
        CustomerType GetById(int id);
    }
}
