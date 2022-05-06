using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfStudentRepository : GenericRepository<Student>, IStudentDal
    {
        public List<Student> GetListWithDepartman()
        {
            using (var c=new Context())
            {
                return c.Students.Include(c => c.Departman).ToList();
            }
        }
        public Student GetByIdWithCourses(int id)
        {
            using (var context = new Context())
            {
                return context.Students
                    .Where(x => x.StudentId == id)
                    .Include(x => x.CourseSelections)
                    .ThenInclude(x => x.Lesson)
                    .FirstOrDefault();
            }
        }
    }
}
