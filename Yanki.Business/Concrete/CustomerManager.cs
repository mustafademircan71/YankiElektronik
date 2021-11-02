using System;
using System.Collections.Generic;
using System.Text;
using Yanki.Business.Abstract;
using Yanki.DataAccess.Abstract.EntityDal;
using Yanki.Entity.Concrete;

namespace Yanki.Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
        public void CustomerAdd(Customer customer)
        {
            _customerDal.Insert(customer);
        }

        public void CustomerDelete(Customer customer)
        {
            _customerDal.Delete(customer);
        }

        public void CustomerUpdate(Customer customer)
        {
            _customerDal.Update(customer);
        }

        public Customer GetById(int id)
        {
            return _customerDal.GetById(id);
        }

        public List<Customer> GetList()
        {
            return _customerDal.GetAll();
        }
    }
}
