using AutoMapper;
using OFour.Core.Entities;
using OFour.Core.Infrastructure.BLLInterfaces;
using OFour.Core.Infrastructure.RepositoryAbstraction;
using OFour.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OFour.Bll.Operations
{
    public class StudentCourseOperation : IStudentCourseOperation
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
        public StudentCourseOperation(IRepositoryManager repositoryManager, IMapper mapper)
        {
            this._repositoryManager = repositoryManager;
            this._mapper = mapper;
        }

        public async Task AddStudentCourse(StudentCourseModel studentCourseModel)
        {
            var sc = _mapper.Map<StudentCourse>(studentCourseModel);
            _repositoryManager.StudentCourse.Add(sc);
            await _repositoryManager.CompleteAsync();
        }

        public async Task DeleteStudentCourse(long sID, long cID)
        {
            _repositoryManager.StudentCourse.DeleteWhere(x => x.StudentID == sID && x.CourseID == cID);
            await _repositoryManager.CompleteAsync();
        }

        public async Task<StudentCourseModel> GetStudentCourse(long sID, long cID)
        {
            var sc = await _repositoryManager.StudentCourse.GetSingleAsync(x => x.StudentID == sID && x.CourseID == cID);
            var result = _mapper.Map<StudentCourseModel>(sc);
            return result;
        }

        public async Task UpdateStudentCourse(StudentCourseModel studentCourseModel)
        {
            var result = _mapper.Map<Student>(studentCourseModel);
            _repositoryManager.Student.Update(result);
            await _repositoryManager.CompleteAsync();
        }
    }
}
