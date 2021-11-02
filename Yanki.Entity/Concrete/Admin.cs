using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Yanki.Entity.Concrete
{
    public class Admin
    {
        [Key]
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime ModifiedTime { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
    }
}
