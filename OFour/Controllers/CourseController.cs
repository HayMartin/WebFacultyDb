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
    public class CourseController : Controller
    {
        private readonly ICourseOperation _operation;
        public CourseController(ICourseOperation operation)
        {
            this._operation = operation;
        }
        [HttpPost]
        public async Task AddCourse([FromBody] CourseModel model)
        {
            await _operation.AddCourse(model);
        }
        [HttpGet("{id}")]
        public Task<CourseModel> GetCourse([FromRoute] int id)
        {
            var result = _operation.GetCourse(id);
            return result;
        }
        [HttpPut]
        public async Task UpdateCourse([FromBody] CourseModel model)
        {
            await _operation.UpdateCourse(model);
        }
        [HttpDelete("{id}")]
        public async Task DeleteCourse([FromRoute] int id)
        {
            await _operation.DeleteCourse(id);
        }
    }
}
