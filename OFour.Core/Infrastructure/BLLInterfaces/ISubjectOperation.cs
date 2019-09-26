using OFour.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OFour.Core.Infrastructure.BLLInterfaces
{
    public interface ISubjectOperation
    {
        Task<SubjectModel> GetSubject(long id);
        Task AddSubject(SubjectModel subjectModel);
        Task UpdateSubject(SubjectModel subjectModel);
        Task DeleteSubject(long id);
    }
}
