using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IStudentService
    {
        void StudentAdd(Student student);
        void StudentDelete(Student student);
        void StudentUpdate(Student student);
        List<Student> GetList();
        Student GetById(int id);
    }
}
