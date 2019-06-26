using Courses.Controllers;
using Courses.Models;
using Courses.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Xunit;
using NSubstitute;

namespace Courses.Tests
{
    public class CourseControllerTests
    {
        CourseController underTest;
        IRepository<Course> courseRepo;

        public CourseControllerTests()
        {
            underTest = new CourseController(courseRepo);
        }

        [Fact]
        public void Index_Returns_A_View()
        {
            var result = underTest.Index();

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Index_Passes_CourseModel_To_View()
        {
            var result = underTest.Index();

            Assert.IsType<List<Course>>(result.Model);
        }

    }
}
