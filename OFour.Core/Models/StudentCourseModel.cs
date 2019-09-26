using System;
using System.Collections.Generic;
using System.Text;

namespace OFour.Core.Models
{
    public class StudentCourseModel
    {
        public int StudentID { get; set; }
        public int CourseID { get; set; }
        public bool? Status { get; set; }
    }
}
