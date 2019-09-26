using OFour.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OFour.Core.Infrastructure.BLLInterfaces
{
    public interface ITeacherOperation
    {
        Task<TeacherModel> GetTeacher(long id);
        Task AddTeacher(TeacherModel teacherModel);
        Task UpdateTeacher(TeacherModel teacherModel);
        Task DeleteTeacher(long id);
    }
}
