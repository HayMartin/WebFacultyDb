using System;
using System.Collections.Generic;
using System.Text;

namespace OFour.Core.ViewModel
{
    public class StudentViewModel
    {
        public string  FirstName { get; set; }
        public string  LastName { get; set; }
        public DateTime? BirthDate{ get; set; }
        public string  Email { get; set; }
        public string  Phone { get; set; }
        public string  Course { get; set; }
        public bool Statuse { get; set; }
        public DateTime? StartDate { get; set; }
        public string  TeacherFirstName { get; set; }
        public string  TeacherLastName { get; set; }
    }
}
