using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SampleCRUD.Data;

namespace SampleCRUD.Controllers
{
    
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployee _employee;
        public EmployeeController(IEmployee employee)
        {
            _employee = employee;
        }

        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetEmployees()
        {
            return Ok(_employee.GetEmployees());
        }
    }
}
