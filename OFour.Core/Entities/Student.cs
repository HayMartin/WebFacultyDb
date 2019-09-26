using OFour.Core.Infrastructure.EntityAbstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace OFour.Core.Entities
{
    public class Student : EntityBaseWithId
    {

        private DateTime _startDay;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime StartDay
        {
            get { return this._startDay; }
            set
            {
                if (value <= DateTime.Now)
                    this._startDay = value;
                else
                    throw new Exception("!!!");
            }
        }

        public ICollection<StudentCourse> StudentCourses { get; set; }


    }
}
