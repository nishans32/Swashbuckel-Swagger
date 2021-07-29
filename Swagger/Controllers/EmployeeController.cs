using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Swagger
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        /// <summary>
        /// This is a test Api
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///     GET api/employee/{id}
        /// </remarks>
        /// <param name="id">Id of the Employee</param>
        /// <returns></returns>
        [HttpGet]
        [Route("{id}")]
        [ProducesResponseType(typeof(Employee), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> GetEmployee(int id)
        {
            var employee = new Employee
            {
                Id = 1,
                Name = "Robert Martin"
            };

            return await Task.FromResult(Ok(employee));
        }
    }
}
