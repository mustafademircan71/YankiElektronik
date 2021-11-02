using System;
using System.Collections.Generic;
using System.Text;
using Yanki.Business.Abstract;
using Yanki.DataAccess.Abstract.EntityDal;
using Yanki.Entity.Concrete;

namespace Yanki.Business.Concrete
{
    public class FaultManager : IFaultService
    {
        IFaultDal _faultDal;
        public FaultManager(IFaultDal faultDal)
        {
            _faultDal = faultDal;
        }
        public void FaultAdd(Fault fault)
        {
            _faultDal.Insert(fault);
        }

        public void FaultDelete(Fault fault)
        {
            _faultDal.Delete(fault);
        }

        public void FaultUpdate(Fault fault)
        {
            _faultDal.Update(fault);
        }

        public Fault GetById(int id)
        {
            return _faultDal.GetById(id);
        }

        public List<Fault> GetList()
        {
            return _faultDal.GetAll();
        }
    }
}
