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
    public class StudentManager : IStudentService
    {
        IStudentDal _studentdal;

        public StudentManager(IStudentDal studentdal)
        {
            _studentdal = studentdal;
        }

        public Student GetById(int id)
        {
            return _studentdal.GetByID(id);
        }

        public Student GetByIdWithCourses(int id)
        {
            return _studentdal.GetByIdWithCourses(id);
        }

        public List<Student> GetList()
        {
            return _studentdal.GetListAll();
        }

        public List<Student> GetListWithDepartman()
        {
            return _studentdal.GetListWithDepartman();
        }

        public void StudentAdd(Student student)
        {
            _studentdal.Insert(student);
        }

        public void StudentDelete(Student student)
        {
            _studentdal.Delete(student);

        }

        public void StudentUpdate(Student student)
        {
            _studentdal.Update(student);

        }
    }
}
