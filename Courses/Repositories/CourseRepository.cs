using Courses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Courses.Repositories
{
    public class CourseRepository : IRepository<Course>
    {
        // A db will be used in place of the List
        //public List<Course> coursesList;

        private UniversityContext db;

        public void Create(Course course)
        {
            db.Courses.Add(course);
            db.SaveChanges();
        }

        public CourseRepository(UniversityContext db)
        {
            this.db = db;
        }

        public IEnumerable<Course> GetAll()
        {
            return db.Courses.ToList();
        }

        public Course GetById(int id)
        {
            return db.Courses.Single(c => c.Id == id);
        }

        public void Delete(Course course)
        {
            db.Courses.Remove(course);
            db.SaveChanges();
        }

    }
}
