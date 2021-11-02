using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Yanki.Entity.Concrete
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime ModifiedTime { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int CustomerTypeId { get; set; }
        public CustomerType CustomerType { get; set; }
        public List<Service> Services { get; set; }

    }
}
