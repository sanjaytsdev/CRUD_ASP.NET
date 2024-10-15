using Microsoft.AspNetCore.Mvc;
using restapi.Entities;
using restapi.Services;

namespace restapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly StudentService Service;

        public StudentController(StudentService Service) {
            this.Service = Service;
        }

        [HttpGet("/search/all")]
        public ActionResult<IEnumerable<StudentEntity>> GetAllStudents() {
            return Ok(Service.GetAllStudents());
        }

        [HttpGet("/search/{id}")]
        public ActionResult<StudentEntity> GetStudentById(int id) {
            var student = Service.GetStudentById(id);
            if (student == null)
                return NotFound();
            return Ok(student);
        }

        [HttpPost("/create")]
        public IActionResult AddStudent([FromBody] StudentEntity student) {
            Service.AddStudent(student);
            return CreatedAtAction(nameof(GetStudentById), new { id = student.Id }, student);
        }

        [HttpPut("/update/{id}")]
        public IActionResult UpdateStudent(int id, [FromBody] StudentEntity student) {
            if (id != student.Id)
                return BadRequest();
            Service.UpdateStudent(student);
            return Ok(student);
        }

        [HttpDelete("/delete/{id}")]
        public IActionResult DeleteStudent(int id) {
            Service.DeleteStudent(id);
            return Ok("Student deleted successfully");
        }
    }
}