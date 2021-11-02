using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Yanki.Entity.Concrete;

namespace Yanki.DataAccess.Concrete
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-NKKGRR6;database=YankiComputerDb;integrated security=true;");
        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerType> CustomerTypes { get; set; }
        public DbSet<Device> Devices { get; set; }
        public DbSet<Fault> Faults { get; set; }
        public DbSet<Service> Services { get; set; }
    }
}
