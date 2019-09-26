using Microsoft.AspNetCore.Mvc;
using OFour.Core.Infrastructure.BLLInterfaces;
using OFour.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OFour.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : Controller
    {
        private readonly ITeacherOperation _operation;
        public TeacherController(ITeacherOperation operation)
        {
            this._operation = operation;
        }

        [HttpGet("{id}")]
        public Task<TeacherModel> GetTeacher([FromRoute]int id)
        {
            var result = _operation.GetTeacher(id);
            return result;
        }
        [HttpPost]
        public async Task AddTeacher([FromBody]TeacherModel teacher)
        {
            await _operation.AddTeacher(teacher);

        }
        [HttpPut]
        public async Task UpdateTeacher([FromBody]TeacherModel teacher)
        {
            await _operation.UpdateTeacher(teacher);
        }
        [HttpDelete("{id}")]
        public async Task DeleteTeacher([FromRoute]int id)
        {
            await _operation.DeleteTeacher(id);
        }
    }
}
