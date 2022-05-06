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
    public class CourseSelectionManager : ICourseSelectionService
    {
        ICourseSelectionDal _course;

        public CourseSelectionManager(ICourseSelectionDal course)
        {
            _course = course;
        }

        public void CourseSelectionAdd(CourseSelection courseSelection)
        {
            _course.Insert(courseSelection);
        }

        public void CourseSelectionDelete(CourseSelection courseSelection)
        {
            _course.Delete(courseSelection);

        }

        public void CourseSelectionUpdate(CourseSelection courseSelection)
        {
            _course.Update(courseSelection);

        }

        public CourseSelection GetById(int id)
        {
            return _course.GetByID(id);
        }

        public List<CourseSelection> GetList()
        {
            return _course.GetListAll();
        }

        public List<CourseSelection> GetListWithLesson()
        {
            return _course.GetListWithLesson();
        }

        public List<CourseSelection> GetWithStudentAndPeriod()
        {
            return _course.GetListWithStudentandPeriod();

        }
    }
}
