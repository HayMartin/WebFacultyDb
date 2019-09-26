using OFour.Core.Entities;
using OFour.Core.Infrastructure.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OFour.Dal.Repositories
{
    public class StudentCourseRepository : RepositoryBase<StudentCourse>, IStudentCourseRepository
    {
        public StudentCourseRepository(WebFacultyContext context) : base(context)
        {

        }
    }
}
