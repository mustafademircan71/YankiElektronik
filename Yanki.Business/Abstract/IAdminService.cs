using System;
using System.Collections.Generic;
using System.Text;
using Yanki.Entity.Concrete;

namespace Yanki.Business.Abstract
{
    public interface IAdminService
    {
        void AdminAdd(Admin admin);
        void AdminDelete(Admin admin);
        void AdminUpdate(Admin admin);
        List<Admin> GetList();
        Admin GetById(int id);
        Admin AdminLogin(string email, string password);
        
    }
}
