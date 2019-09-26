using OFour.Core.Infrastructure.EntityAbstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace OFour.Core.Entities
{
    public class Teacher : EntityBaseWithId
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public ICollection<Course> Cources { get; set; }

    }
}
