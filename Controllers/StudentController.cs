using DemoAPI.Infrastructure;
using DemoAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudents _studentService;
        public StudentController(IStudents studentService)
        {
            _studentService = studentService;
        }


        [HttpPost("create_student")]
        public async Task<bool> AddStudent(StudentDTO input)
        {
           var result = await _studentService.CreateStudent(input);
            return result;
        }
    }
}
