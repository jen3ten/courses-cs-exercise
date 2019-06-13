﻿using Courses.Models;
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
            Course model = new Course(1, "Intro to MVC", "All you need to know about MVC");
            return View(model);
        }
    }
}
