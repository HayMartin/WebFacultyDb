using OFour.Core.Infrastructure.EntityAbstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace OFour.Core.Entities
{

    public class StudentCourse : EntityBase
    {
        public int StudentID { get; set; }
        public int CourseID { get; set; }
        public bool Status { get; set; }

        public Student Student { get; set; }
        public Course Cource { get; set; }
    }
}
