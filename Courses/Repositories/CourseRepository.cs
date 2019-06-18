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

        public CourseRepository(UniversityContext db)
        {
            this.db = db;

            //coursesList = new List<Course>()
            //{
            //    new Course(1, "Machine Learning", "Machine learning for humans"),
            //    new Course(2, "C# for Smarties", "It's all you need to learn it all"),
            //    new Course(3, "HTML, CSS, JS, oh my!", "OMG, the front end will become your BFF")
            //};
        }

        public IEnumerable<Course> GetAll()
        {
            return db.Courses.ToList();
        }

        public Course GetById(int id)
        {
            return db.Courses.Single(c => c.Id == id);
        }
    }
}
