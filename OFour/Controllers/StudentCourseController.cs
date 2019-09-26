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
    public class StudentCourseController : Controller
    {
        private readonly IStudentCourseOperation _operation;
        public StudentCourseController(IStudentCourseOperation operation)
        {
            this._operation = operation;
        }
        [HttpGet("{studentId}/Student/{courseId}")]
        public Task<StudentCourseModel> GetStudentCourse([FromRoute] int studentId, int courseId)
        {
            var result = _operation.GetStudentCourse(studentId, courseId);
            return result;
        }
        [HttpPost]
        public async Task AddStudentCourse([FromBody] StudentCourseModel model)
        {
            await _operation.AddStudentCourse(model);
        }
        [HttpPut]
        public async Task UpdateStudentCourse([FromBody] StudentCourseModel model)
        {
            await _operation.UpdateStudentCourse(model);
        }
        [HttpDelete("{studentId}/Student/{courseId}")]
        public async Task DeleteStudentCourse([FromRoute] int studentId, int courseId)
        {
            await _operation.DeleteStudentCourse(studentId, courseId);
        }

    }
}
