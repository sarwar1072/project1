using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Assignment6.web.Models;
namespace Assignment6.web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Course2()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(StudentModel studentModel)
        {
           studentModel.AddStudent();

            return View();
        }      
        [HttpPost]
        public IActionResult Course2(CourseModel courseModel)
        {
            courseModel.AddCourse();
               return View();
        }
        [HttpPost]
        public IActionResult EditStudent(StudentModel studentModel)
        {
            studentModel.editStudent();
            return Redirect("/Home/Index");
        }

        [HttpPost]
        public IActionResult DeleteStudent(StudentModel studentModel)
        {
            studentModel.deleteStudent();
            return Redirect("/Home/Index");
        }

        [HttpPost]
        public IActionResult EditCourse(CourseModel courseModel)
        {
            courseModel.editCourse();
            return Redirect("/Home/Course2");
        }

        [HttpPost]
        public IActionResult DeleteCourse(CourseModel courseModel)
        {
            courseModel.deleteCourse();
            return Redirect("/Home/Course2");
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
