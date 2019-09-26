using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OFour.Core.Infrastructure.BLLInterfaces;
using OFour.Core.Infrastructure.RepositoryInterfaces;
using OFour.Core.Models;
using OFour.Core.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace OFour.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : Controller
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IStudentOperation _operation;
        public StudentController(IStudentOperation studentOperation, IStudentRepository student)
        {
            this._operation = studentOperation;
            this._studentRepository = student;
        }
        [HttpGet("{id}")]
        public Task<StudentModel> GetStudent([FromRoute] int id)
        {
            var result = _operation.GetStudent(id);
            return result;
        }

        [HttpPost]
        public async Task AddStudent([FromBody] StudentModel student)
        {
            await _operation.AddStudent(student);
        }
        [HttpPut]
        public async Task UpdateStudent([FromBody] StudentModel student)
        {
            await _operation.UpdateStudent(student);
        }
        [HttpDelete("{id}")]
        public async Task DeleteStudent([FromRoute] int id)
        {
            await _operation.DeleteStudent(id);
        }

        [HttpGet]
        public async Task<List<StudentViewModel>> StudentViewModel()
        {
            var result = await _studentRepository.GetStudentViewModels();

            return result;
        }

    }
}
