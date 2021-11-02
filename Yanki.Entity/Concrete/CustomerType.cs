using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Yanki.Entity.Concrete
{
    public class CustomerType
    {
        [Key]
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime ModifiedTime { get; set; }
        public string CustomerTypeName { get; set; }
        public List<Customer> Customers { get; set; }

    }
}
