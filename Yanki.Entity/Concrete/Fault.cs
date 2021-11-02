using System;
using System.Collections.Generic;
using System.Text;

namespace Yanki.Entity.Concrete
{
    public class Fault
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime ModifiedTime { get; set; }
        public string FaultName { get; set; }
        public List<Service> Services { get; set; }
    }
}
