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
    public class StudentOperation : IStudentOperation
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
        public StudentOperation(IRepositoryManager repositoryManager, IMapper mapper)
        {
            this._repositoryManager = repositoryManager;
            this._mapper = mapper;
        }

        public async Task AddStudent(StudentModel studentModel)
        {
            var result = _mapper.Map<Student>(studentModel);
            _repositoryManager.Student.Add(result);
            await _repositoryManager.CompleteAsync();

        }

        public async Task DeleteStudent(long id)
        {
            _repositoryManager.Student.DeleteWhere(x => x.Id == id);
            await _repositoryManager.CompleteAsync();
        }

        public async Task<StudentModel> GetStudent(long id)
        {
            var student = await _repositoryManager.Student.GetSingleAsync(x => x.Id == id);

            var result = _mapper.Map<StudentModel>(student);
            return result;
        }

        public async Task UpdateStudent(StudentModel studentModel)
        {
            var result = _mapper.Map<Student>(studentModel);
            _repositoryManager.Student.Update(result);
            await _repositoryManager.CompleteAsync();

        }
    }
}
