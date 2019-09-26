using OFour.Core.Infrastructure.EntityAbstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace OFour.Core.Entities
{
    public class Course : EntityBaseWithId
    {
        public int SubjectID { get; set; }
        public int TeacherID { get; set; }

        public ICollection<StudentCourse> StudentCourses { get; set; }
        public Subject Subject { get; set; }
        public Teacher Teacher { get; set; }
    }
}
