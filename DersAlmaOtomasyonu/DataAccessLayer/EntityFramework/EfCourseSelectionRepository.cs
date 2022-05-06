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
    public class EfCourseSelectionRepository : GenericRepository<CourseSelection>, ICourseSelectionDal
    {
        public List<CourseSelection> GetListWithLesson()
        {
            using (var c = new Context())
            {
                return c.CourseSelections.Include(c => c.Lesson).ThenInclude(c => c.Period).ToList();
            }
        }

        public List<CourseSelection> GetListWithStudentandPeriod()
        {
            using (var c = new Context())
            {
                return c.CourseSelections.Include(c => c.Student).ThenInclude(c => c.Period).ToList();
            }
        }
    }
}
