using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class PeriodManager : IPeriodService
    {
        IPeriodDal _periodDal;

        public PeriodManager(IPeriodDal periodDal)
        {
            _periodDal = periodDal;
        }

        public Period GetById(int id)
        {
            return _periodDal.GetByID(id);
        }

        public List<Period> Getlist()
        {
            return _periodDal.GetListAll();
        }
    }
}
