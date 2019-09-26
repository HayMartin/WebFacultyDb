using OFour.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OFour.Core.Infrastructure.BLLInterfaces
{
    public interface IStudentOperation
    {
        Task<StudentModel> GetStudent(long id);
        Task AddStudent(StudentModel studentModel);
        Task UpdateStudent(StudentModel studentModel);
        Task DeleteStudent(long id);
    }
}
