using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ICourseSelectionDal : IGenericDal<CourseSelection>
    {
        public List<CourseSelection> GetListWithStudentandPeriod();
        public List<CourseSelection> GetListWithLesson();

    }
}
