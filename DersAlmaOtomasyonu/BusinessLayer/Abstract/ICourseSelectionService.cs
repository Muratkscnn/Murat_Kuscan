using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICourseSelectionService
    {
        void CourseSelectionAdd(CourseSelection courseSelection);
        void CourseSelectionDelete(CourseSelection courseSelection);
        void CourseSelectionUpdate(CourseSelection courseSelection);
        List<CourseSelection> GetList();
        List<CourseSelection> GetWithStudentAndPeriod();
        List<CourseSelection> GetListWithLesson();
        CourseSelection GetById(int id);
    }
}
