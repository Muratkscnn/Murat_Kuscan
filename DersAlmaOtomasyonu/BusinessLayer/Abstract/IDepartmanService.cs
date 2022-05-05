using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IDepartmanService
    {
        void DepartmanAdd(Departman departman);
        void DepartmanDelete(Departman departman);
        void DepartmanUpdate(Departman departman);
        List<Departman> GetList();
        Departman GetById(int id);
    }
}
