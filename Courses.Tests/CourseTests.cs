using Courses.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Courses.Tests
{
    public class CourseTests
    {
        Course underTest;

        public CourseTests()
        {
            underTest = new Course(42, "Course Name", "Description of course");
        }
            
        [Fact]
        public void CourseConstructor_Sets_Name_On_CourseModel()
        {
            var result = underTest.Name;

            Assert.Equal("Course Name", result);
        }

        [Fact]
        public void CourseConstructor_Sets_Id_On_CourseModel()
        {
            var result = underTest.Id;

            Assert.Equal(42, result);
        }

        [Fact]
        public void CourseConstructor_Sets_Description_On_CourseModel()
        {
            var result = underTest.Description;

            Assert.Equal("Description of course", result);
        }

    }
}
