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
    public class TeacherOperation : ITeacherOperation
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
        public TeacherOperation(IRepositoryManager repositoryManager, IMapper mapper)
        {
            this._repositoryManager = repositoryManager;
            this._mapper = mapper;
        }

        public async Task AddTeacher(TeacherModel teacherModel)
        {
            var result = _mapper.Map<Teacher>(teacherModel);
            _repositoryManager.Teacher.Add(result);
            await _repositoryManager.CompleteAsync();
        }

        public async Task DeleteTeacher(long id)
        {
            _repositoryManager.Teacher.DeleteWhere(x => x.Id == id);
            await _repositoryManager.CompleteAsync();
        }

        public async Task<TeacherModel> GetTeacher(long id)
        {
            var student = await _repositoryManager.Teacher.GetSingleAsync(x => x.Id == id);
            var result = _mapper.Map<TeacherModel>(student);
            return result;

        }

        public async Task UpdateTeacher(TeacherModel teacherModel)
        {
            var teacher = _mapper.Map<Teacher>(teacherModel);
            _repositoryManager.Teacher.Update(teacher);
            await _repositoryManager.CompleteAsync();
        }
    }
}
