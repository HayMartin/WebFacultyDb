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
    public class SubjectController : Controller
    {
        private readonly ISubjectOperation _operation;
        public SubjectController(ISubjectOperation operation)
        {
            this._operation = operation;
        }

        [HttpGet("{id}")]
        public Task<SubjectModel> GetSubject([FromRoute] int id)
        {
            var result = _operation.GetSubject(id);
            return result;
        }
        [HttpDelete("{id}")]
        public async Task DeleteSubject([FromRoute]int id)
        {
            await _operation.DeleteSubject(id);
        }
        [HttpPut]
        public async Task UpdateSubject([FromBody] SubjectModel model)
        {
            await _operation.UpdateSubject(model);
        }
        [HttpPost]
        public async Task AddSubject([FromBody] SubjectModel model)
        {
            try
            {
                await _operation.AddSubject(model);

            }
            catch (Exception ex)
            {
                Console.WriteLine(  ex.Message);

            }
        }
    }
}
