using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudyProgram.DataContext;
using StudyProgram.Entity;
using StudyProgram.IService;
using StudyProgram.Service;

namespace StudyProgram.Controllers
{
    public class Program_StudyController : Controller
    {
        private readonly SPMContext _context;
        public Program_StudyController(SPMContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var courseService = new CourseService(_context);
            ViewBag.ListofCourse = courseService.GetListCourseToDropdown();
            return View();
        }

        public JsonResult GetSpecialitiesByCourseId(string courseId)
        {
            var specialityService = new SpecialityService(_context);
            var result = specialityService.GetSpecialitiesByCourseId(courseId);
            if (result == null)
                return Json(new { isSuccess = false });
            return Json(new { isSuccess = true, data = result });
        }
    }
}