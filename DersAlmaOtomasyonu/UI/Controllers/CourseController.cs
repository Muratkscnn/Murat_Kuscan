using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI.Controllers
{
    public class CourseController : Controller
    {
        CourseSelectionManager cm = new CourseSelectionManager(new EfCourseSelectionRepository());
        public IActionResult Index()
        {
            ViewBag.i = cm.GetListWithLesson();
            var values = cm.GetWithStudentAndPeriod();
            return View(values);
        }
    }
}
