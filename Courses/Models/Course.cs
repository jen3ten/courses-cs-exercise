﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Courses.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual int InstructorId { get; set; }
        public virtual Instructor Instructor { get; set; }

        public Course()
        {
        }

        public Course(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }
    }
}
