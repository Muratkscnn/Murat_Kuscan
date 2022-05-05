using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Lesson
    {
        public int LessonId { get; set; }
        public string LessonName { get; set; }
        public string LessonTeacher { get; set; }
        public int LessonCredit { get; set; }
        public int PeriodId { get; set; }
        public Period Period { get; set; }
        public List<CourseSelection> CourseSelections { get; set; }


    }
}
