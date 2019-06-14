﻿using Courses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Courses.Repositories
{
    public class CourseRepository
    {
        List<Course> coursesList;

        public CourseRepository()
        {
            coursesList = new List<Course>()
            {
                new Course(1, "Machine Learning", "Machine learning for humans"),
                new Course(2, "C# for Smarties", "It's all you need to learn it all"),
                new Course(3, "HTML, CSS, JS, oh my!", "OMG, the front end will become your BFF")
            };
        }
    }
}
