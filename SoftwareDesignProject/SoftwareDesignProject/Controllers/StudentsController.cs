using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SoftwareDesignProject.Data.Models;
using SoftwareDesignProject.Data.Services;

namespace SoftwareDesignProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        public StudentsService _studentsServices;

        public StudentsController(StudentsService studentsServices)
        {
            _studentsServices = studentsServices;
        }

        [HttpGet("get-all-students")]
        public IActionResult GetAllStudents()
        {
            var allStudents = _studentsServices.GetAllStudents();
            return Ok(allStudents);
        }

        [HttpGet("get-student-by-id/{nrLeternjoftimit}")]
        public IActionResult GetStudentById(int nrLeternjoftimit)
        {
            var student = _studentsServices.GetStudentById(nrLeternjoftimit);
            return Ok(student);
        }

        [HttpPost("add-student")]
        public IActionResult AddStudent([FromBody] Student student)
        {
            _studentsServices.AddStudent(student);
            return Ok();
        }

        [HttpPut("update-student/{nrLeternjoftimit}")]
        public IActionResult UpdateStudentById(int nrLeternjoftimit, [FromBody]Student student)
        {
            var updatedStudent = _studentsServices.UpdateStudentById(nrLeternjoftimit, student);
            return Ok(updatedStudent);
        }
      


        [HttpDelete("delete-student-by-id/{nrLeternjoftimit}")]
        public IActionResult DeleteStudentById(int nrLeternjoftimit)
        {
            _studentsServices.DeleteStudentById(nrLeternjoftimit);
            return Ok();
        }

    }

}
