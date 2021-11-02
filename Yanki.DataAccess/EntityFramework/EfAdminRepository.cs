using System;
using System.Collections.Generic;
using System.Text;
using Yanki.DataAccess.Abstract.EntityDal;
using Yanki.DataAccess.Repositories;
using Yanki.Entity.Concrete;

namespace Yanki.DataAccess.EntityFramework
{
    public class EfAdminRepository : GenericRepository<Admin>, IAdminDal
    {
        public Admin AdminLogin(string email, string password)
        {
            return Get(x => x.Email == email && x.Password == password);
        }
    }
}
