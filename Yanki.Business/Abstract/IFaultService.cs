using System;
using System.Collections.Generic;
using System.Text;
using Yanki.Entity.Concrete;

namespace Yanki.Business.Abstract
{
    public interface IFaultService
    {
        void FaultAdd(Fault fault);
        void FaultDelete(Fault fault);
        void FaultUpdate(Fault fault);
        List<Fault> GetList();
        Fault GetById(int id);
    }
}
