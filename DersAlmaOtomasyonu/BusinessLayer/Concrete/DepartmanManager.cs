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
    public class DepartmanManager : IDepartmanService
    {
        IDepartmanDal _departmandal;

        public DepartmanManager(IDepartmanDal departmandal)
        {
            _departmandal = departmandal;
        }

        public void DepartmanAdd(Departman departman)
        {
            _departmandal.Insert(departman);
        }

        public void DepartmanDelete(Departman departman)
        {
            _departmandal.Delete(departman);
        }

        public void DepartmanUpdate(Departman departman)
        {
            _departmandal.Update(departman);

        }

        public Departman GetById(int id)
        {
            return _departmandal.GetByID(id);
        }

        public List<Departman> GetList()
        {
            return _departmandal.GetListAll();
        }
    }
}
