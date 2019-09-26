using System;
using System.Collections.Generic;
using System.Text;

namespace OFour.Core.Models
{
    public class CourseModel
    {
        public int Id { get; set; }
        public int? SubjectID { get; set; }
        public int? TeacherID { get; set; }
    }
}
