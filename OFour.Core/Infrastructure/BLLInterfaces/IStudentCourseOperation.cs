using OFour.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OFour.Core.Infrastructure.BLLInterfaces
{
    public interface IStudentCourseOperation
    {
        Task<StudentCourseModel> GetStudentCourse(long sID, long cID);
        Task AddStudentCourse(StudentCourseModel studentCourseModel);
        Task UpdateStudentCourse(StudentCourseModel studentCourseModel);
        Task DeleteStudentCourse(long sID, long cID);
    }
}
