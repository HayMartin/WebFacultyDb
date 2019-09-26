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
    public class SubjectOperation : ISubjectOperation
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
        public SubjectOperation(IRepositoryManager repositoryManager, IMapper mapper)
        {
            this._repositoryManager = repositoryManager;
            this._mapper = mapper;
        }

        public async Task AddSubject(SubjectModel subjectModel)
        {
            var result = _mapper.Map<Subject>(subjectModel);
            _repositoryManager.Subject.Add(result);
            await _repositoryManager.CompleteAsync();
        }

        public async Task DeleteSubject(long id)
        {
            _repositoryManager.Subject.DeleteWhere(x => x.Id == id);
            await _repositoryManager.CompleteAsync();
        }

        public async Task<SubjectModel> GetSubject(long id)
        {
            var subject = await _repositoryManager.Subject.GetSingleAsync(x => x.Id == id);
            var result = _mapper.Map<SubjectModel>(subject);
            return result;
        }

        public async Task UpdateSubject(SubjectModel subjectModel)
        {
            var subject = _mapper.Map<Subject>(subjectModel);
            _repositoryManager.Subject.Update(subject);
            await _repositoryManager.CompleteAsync();
        }
    }
}
