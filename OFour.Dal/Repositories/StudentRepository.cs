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
    public class StudentRepository : RepositoryBase<Student>, IStudentRepository
    {
        public StudentRepository(WebFacultyContext context) : base(context)
        {

        }

        public async Task<List<StudentViewModel>> GetStudentViewModels()
        {
            var query = await (from Student in Context.Students
                               join StudentCourse in Context.StudentCourses
                               on Student.Id equals StudentCourse.StudentID
                               join Course in Context.Cources
                               on StudentCourse.CourseID equals Course.Id
                               join Subject in Context.Subjects
                               on Course.SubjectID equals Subject.Id
                               join Teacher in Context.Teachers
                               on Course.TeacherID equals Teacher.Id
                               select new StudentViewModel
                               {
                                   FirstName = Student.FirstName,
                                   LastName = Student.LastName,
                                   BirthDate = Student.BirthDate,
                                   Email = Student.Email,
                                   Phone = Student.Phone,
                                   Course = Subject.SubjectName,
                                   Statuse = StudentCourse.Status,
                                   StartDate = Student.StartDay,
                                   TeacherFirstName = Teacher.FirstName,
                                   TeacherLastName = Teacher.LastName

                               }).ToListAsync();

                               

                return query;
        }
    }
}
