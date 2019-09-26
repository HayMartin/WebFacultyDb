using OFour.Core.Entities;
using OFour.Core.Infrastructure.RepositoryInterfaces;
using OFour.Core.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OFour.Dal.Repositories
{
    public class CourseRepository : RepositoryBase<Course>, ICourseRepository
    {
        public CourseRepository(WebFacultyContext context) : base(context)
        {

        }

       
    }
}
