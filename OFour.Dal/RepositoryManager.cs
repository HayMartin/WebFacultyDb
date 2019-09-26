using OFour.Core.Infrastructure.RepositoryAbstraction;
using OFour.Core.Infrastructure.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
namespace OFour.Dal
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly WebFacultyContext _context;
        public RepositoryManager(IServiceProvider serviceProvider, WebFacultyContext context)
        {
            this._serviceProvider = serviceProvider;
            this._context = context;
        }

        IStudentRepository _students;
        ITeacherRepository _teachers;
        ISubjectRepository _subjects;
        ICourseRepository _courses;
        IStudentCourseRepository _studentcourses;

        public IStudentRepository Student =>
            _students ?? (_students = _serviceProvider.GetService<IStudentRepository>());

        public ITeacherRepository Teacher =>
            _teachers ?? (_teachers = _serviceProvider.GetService<ITeacherRepository>());

        public ICourseRepository Course =>
            _courses ?? (_courses = _serviceProvider.GetService<ICourseRepository>());

        public ISubjectRepository Subject =>
            _subjects ?? (_subjects = _serviceProvider.GetService<ISubjectRepository>());

        public IStudentCourseRepository StudentCourse =>
            _studentcourses ?? (_studentcourses = _serviceProvider.GetService<IStudentCourseRepository>());

      
        public int Complete()
        {
            return _context.SaveChanges();
        }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

        
    }
}
