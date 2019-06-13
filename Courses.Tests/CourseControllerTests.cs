using Courses.Controllers;
using Courses.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace Courses.Tests
{
    public class CourseControllerTests
    {
        [Fact]
        public void Index_Returns_A_View()
        {
            var underTest = new CourseController();

            var result = underTest.Index();

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Index_Passes_CourseModel_To_View()
        {
            var underTest = new CourseController();

            var result = underTest.Index();

            Assert.IsType<Course>(result.Model);
        }
    }
}
