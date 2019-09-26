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
    public class CourseOperation : ICourseOperation
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
        public CourseOperation(IRepositoryManager repositoryManager, IMapper mapper)
        {
            this._repositoryManager = repositoryManager;
            this._mapper = mapper;
        }

        public async Task AddCourse(CourseModel courseModel)
        {
            var subject = _mapper.Map<Course>(courseModel);
            _repositoryManager.Course.Add(subject);
            await _repositoryManager.CompleteAsync();
        }

        public async Task DeleteCourse(long id)
        {
            _repositoryManager.Course.DeleteWhere(x => x.Id == id);
            await _repositoryManager.CompleteAsync();
        }

        public async Task<CourseModel> GetCourse(long id)
        {
            var course = await _repositoryManager.Course.GetSingleAsync(x => x.Id == id);
            var result = _mapper.Map<CourseModel>(course);
            return result;
        }

        public async Task UpdateCourse(CourseModel courseModel)
        {
            var result = _mapper.Map<Course>(courseModel);
            _repositoryManager.Course.Update(result);
            await _repositoryManager.CompleteAsync();
        }
    }
}
