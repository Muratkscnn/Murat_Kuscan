using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentFirstName { get; set; }
        public string StudentLastName { get; set; }
        public int DepartmanId { get; set; }
        public DateTime StudentBirthDay { get; set; }
        public DateTime StudentRegisterDate { get; set; }
        public Departman Departman { get; set; }
        public int PeriodId { get; set; }
        public Period Period { get; set; }
        public List<CourseSelection> CourseSelections { get; set; }


    }
}
