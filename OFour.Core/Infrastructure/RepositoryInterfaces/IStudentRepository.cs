using OFour.Core.Entities;
using OFour.Core.Infrastructure.RepositoryAbstraction;
using OFour.Core.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OFour.Core.Infrastructure.RepositoryInterfaces
{
    public interface IStudentRepository : IRepositoryBase<Student>
    {

       Task<List<StudentViewModel>> GetStudentViewModels();
    }
}
