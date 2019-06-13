using Courses.Models;
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
            Course model = new Course();
            return View(model);
        }
    }
}
