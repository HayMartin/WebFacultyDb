using OFour.Core.Infrastructure.EntityAbstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace OFour.Core.Entities
{
    public class Subject : EntityBaseWithId
    {
        public string SubjectName { get; set; }

        public ICollection<Course> Cources { get; set; }

    }
}
