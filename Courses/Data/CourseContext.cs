using Courses.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Courses.Data
{
    public class CourseContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().HasData(
                new Course()
                {
                    Id = 1,
                    Name = "C# for Smarties",
                    Description = "All you need to know about C#"
                },

                new Course()
                {
                    Id = 2,
                    Name = "HTML, CSS, JS, oh my!",
                    Description = "OMG you'll learn all about the front end"
                }
                );
        }
    }
}
