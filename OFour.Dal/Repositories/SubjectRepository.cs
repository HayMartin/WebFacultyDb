using OFour.Core.Entities;
using OFour.Core.Infrastructure.RepositoryInterfaces;
using OFour.Core.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace OFour.Dal.Repositories
{
    public class SubjectRepository : RepositoryBase<Subject>, ISubjectRepository
    {
        public SubjectRepository(WebFacultyContext context) : base(context)
        {

        }

        public async Task<List<SubjectViewModel>> GetSubjectViewModels()
        {
            var query = await (from Course in Context.Cources
                               join Subject in Context.Subjects
                               on Course.SubjectID equals Subject.Id
                               join Teacher in Context.Teachers
                               on Course.TeacherID equals Teacher.Id
                               select new SubjectViewModel
                               {
                                   Type = Subject.SubjectName,
                                   TeacherName = Teacher.FirstName,
                                   TeacherLastName = Teacher.LastName,
                                   Phone = Teacher.Phone

                               }).ToListAsync();


                return query;
        }
    }
}
