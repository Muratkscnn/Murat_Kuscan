using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            var model2 = new CourseSelectionManager(new EfCourseSelectionRepository);
            var context = new StudentManager(new EfStudentRepository);
            var entity = context.GetByIdWithCourses(id);
            var model = new StudentModel()
            {
                StudentId = entity.StudentId,
                No = entity.No,
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                DateOfBirth = entity.DateOfBirth,
                DateOfRegistration = entity.DateOfRegistration,
                Period = entity.Period,
                DepartmentId = entity.DepartmentId,
                SelectedCourses = entity.StudentCourses.Select(x => x.Course).ToList()
            };
            ViewBag.Courses = model2.GetAll();
            return View(model);
        }
    }
}
