using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UI.Models;

namespace UI.Controllers
{
    public class StudentController : Controller
    {
        StudentManager sm = new StudentManager(new EfStudentRepository());
        public IActionResult Index()
        {
            var values = sm.GetListWithDepartman();

            return View(values);
        }
        public IActionResult DersAtama(int id)
        {
            var model2 = new CourseSelectionManager(new EfCourseSelectionRepository());
            var context = new StudentManager(new EfStudentRepository());
            var entity = context.GetByIdWithCourses(id);
            var model = new StudentModel()
            {
                StudentId = entity.StudentId,
                No = 3,
                FirstName = entity.StudentFirstName,
                LastName = entity.StudentLastName,
                DateOfBirth = entity.StudentBirthDay,
                DateOfRegistration = entity.StudentRegisterDate,
                Period = entity.PeriodId,
                DepartmentId = entity.DepartmanId,
                SelectedCourses = entity.CourseSelections.Select(x => x.Lesson).ToList()
            };
            ViewBag.Courses = model2.GetList();
            return View(model);
        }
    }
}
