using Courses.Models;
using Courses.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Courses.Controllers
{
    public class CourseController : Controller
    {
        public ViewResult Index()
        {
            //Course model = new Course(1, "Intro to MVC", "All you need to know about MVC");

            CourseRepository courseRepo = new CourseRepository();

            var model = courseRepo.coursesList[1];

            return View(model);
        }
    }
}
