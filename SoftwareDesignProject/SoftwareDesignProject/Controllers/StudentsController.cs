
using Microsoft.AspNetCore.Mvc;
using SoftwareDesignProject.Data;
using SoftwareDesignProject.Data.Models;
using SoftwareDesignProject.Data.Services;

namespace SoftwareDesignProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        //dependency injection 
        private readonly AppDbContext _context;
        private readonly IStudentService _studentService;


        public StudentsController(AppDbContext context, IStudentService studentService)
        {
            _context = context;
            _studentService = studentService;
        }

        [HttpGet("get-all-students")]
        public IActionResult GetAllStudents()
        {
            var allStudents = _studentService.GetAllStudents();
            return Ok(allStudents);
        }

        [HttpGet("get-student-by-id/{nrLeternjoftimit}")]
        public IActionResult GetStudentById(int nrLeternjoftimit)
        {
            var student = _studentService.GetStudentById(nrLeternjoftimit);
            return Ok(student);
        }

        [HttpPost("add-student")]
        public IActionResult AddStudent([FromBody] Student student)
        {
            _studentService.AddStudent(student);
            return Ok();
        }

        [HttpPut("update-student/{nrLeternjoftimit}")]
        public IActionResult UpdateStudentById(int nrLeternjoftimit, [FromBody] Student student)
        {
            var updatedStudent = _studentService.UpdateStudentById(nrLeternjoftimit, student);
            return Ok(updatedStudent);
        }



        [HttpDelete("delete-student-by-id/{nrLeternjoftimit}")]
        public IActionResult DeleteStudentById(int nrLeternjoftimit)
        {
            _studentService.DeleteStudentById(nrLeternjoftimit);
            return Ok();
        }

    }

}
