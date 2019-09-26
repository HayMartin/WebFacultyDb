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
    public class TeacherRepository : RepositoryBase<Teacher>, ITeacherRepository
    {
        public TeacherRepository(WebFacultyContext context) : base(context)
        {

        }

        public async Task<List<TeacherViewModel>> GetTeacherViewModels()
        {
            var query = await (from Teacher in Context.Teachers
                               join Course in Context.Cources
                               on Teacher.Id equals Course.TeacherID
                               join Subject in Context.Subjects
                               on Course.SubjectID equals Subject.Id
                               select new TeacherViewModel
                               {
                                   FirstName = Teacher.FirstName,
                                   LastName = Teacher.LastName,
                                   Phone = Teacher.Phone,
                                   Subject = Subject.SubjectName
                               }).ToListAsync(); 

                               




                return query;
        }
    }
}
