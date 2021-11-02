using System;
using System.Collections.Generic;
using System.Text;
using Yanki.Business.Abstract;
using Yanki.DataAccess.Abstract;
using Yanki.DataAccess.Abstract.EntityDal;
using Yanki.Entity.Concrete;

namespace Yanki.Business.Concrete
{
    public class CustomerTypeManager : ICustomerTypeService
    {
        ICustomerTypeDal _customerTypeDal;
        public CustomerTypeManager(ICustomerTypeDal customerTypeDal)
        {
            _customerTypeDal = customerTypeDal;
        }
        public void CustomerTypeAdd(CustomerType customerType)
        {
            _customerTypeDal.Insert(customerType);
        }

        public void CustomerTypeDelete(CustomerType customerType)
        {
            _customerTypeDal.Delete(customerType);
        }

        public void CustomerTypeUpdate(CustomerType customerType)
        {
            _customerTypeDal.Update(customerType);
        }

        public CustomerType GetById(int id)
        {
            return _customerTypeDal.GetById(id);
        }

        public List<CustomerType> GetList()
        {
            return _customerTypeDal.GetAll();
        }
    }
}
