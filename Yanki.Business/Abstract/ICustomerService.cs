using System;
using System.Collections.Generic;
using System.Text;
using Yanki.Entity.Concrete;

namespace Yanki.Business.Abstract
{
    public interface ICustomerService
    {
        void CustomerAdd(Customer customer);
        void CustomerDelete(Customer customer);
        void CustomerUpdate(Customer customer);
        List<Customer> GetList();
        Customer GetById(int id);
    }
}
