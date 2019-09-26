using OFour.Core.Infrastructure.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OFour.Core.Infrastructure.RepositoryAbstraction
{
    public interface IRepositoryManager
    {
        IStudentRepository Student { get; }
        ITeacherRepository Teacher { get; }
        ICourseRepository Course { get; }
        ISubjectRepository Subject { get; }
        IStudentCourseRepository StudentCourse { get; }

        Task<int> CompleteAsync();
        int Complete();
    }
}
