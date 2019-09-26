using System;
using System.Collections.Generic;
using System.Text;

namespace OFour.Core.Models
{
    public class StudentModel
    {
        private DateTime _startDay;
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FirstNameArm { get; set; }
        public string LastNameArm { get; set; }
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
    }
}
