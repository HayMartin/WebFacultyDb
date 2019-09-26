using OFour.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OFour.Core.Infrastructure.BLLInterfaces
{
    public interface ICourseOperation
    {
        Task<CourseModel> GetCourse(long id);
        Task AddCourse(CourseModel courseModel);
        Task UpdateCourse(CourseModel courseModel);
        Task DeleteCourse(long id);
    }
}
