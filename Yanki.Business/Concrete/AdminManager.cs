using System;
using System.Collections.Generic;
using System.Text;
using Yanki.Business.Abstract;
using Yanki.DataAccess.Abstract.EntityDal;
using Yanki.Entity.Concrete;

namespace Yanki.Business.Concrete
{
    public class AdminManager : IAdminService
    {
        IAdminDal _adminDal;
        public AdminManager(IAdminDal adminDal)
        {
            _adminDal = adminDal;
        }
        public void AdminAdd(Admin admin)
        {
            _adminDal.Insert(admin);
        }

        public void AdminDelete(Admin admin)
        {
            _adminDal.Delete(admin);
        }

        public Admin AdminLogin(string email, string password)
        {
           return _adminDal.AdminLogin(email, password);
        }

        public void AdminUpdate(Admin admin)
        {
            _adminDal.Update(admin);
        }

        public Admin GetById(int id)
        {
            return _adminDal.GetById(id);
        }

        public List<Admin> GetList()
        {
            return _adminDal.GetAll();
        }
    }
}
