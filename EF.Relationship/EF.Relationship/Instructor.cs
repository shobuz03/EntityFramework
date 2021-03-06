﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Relationship
{
    public class Instructor
    {
        public Instructor()
        {
            this.Courses = new List<Course>();
        }

        // Primary key 
        public int InstructorId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public System.DateTime HireDate { get; set; }

        // Navigation properties 
        public virtual OfficeAssignment OfficeAssignment { get; set; }
        public virtual ICollection<Course> Courses { get; private set; }
    }
}
