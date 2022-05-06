using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IStudentDal : IGenericDal<Student>
    {
        List<Student> GetListWithDepartman();
        public Student GetByIdWithCourses(int id);

    }
}
