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
            courseRepo = Substitute.For<IRepository<Course>>();
            underTest = new CourseController(courseRepo);
        }

        [Fact]
        public void Index_Returns_A_View()
        {
            var result = underTest.Index();

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Index_Passes_All_Courses_To_View()
        {
            var expectedCourses = new List<Course>();
            courseRepo.GetAll().Returns(expectedCourses);

            var result = underTest.Index();

            Assert.Equal(expectedCourses, result.Model);
        }
    }
}
