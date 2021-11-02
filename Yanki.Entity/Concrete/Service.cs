using System;
using System.Collections.Generic;
using System.Text;

namespace Yanki.Entity.Concrete
{
    public class Service
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime ModifiedTime { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int FaultId { get; set; }
        public Fault Fault { get; set; }
        public int DeviceId { get; set; }
        public Device Device { get; set; }
        public double Price { get; set; }
        public string ServiceCode { get; set; }
    }
}
