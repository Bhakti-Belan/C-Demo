using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApiDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {

        [HttpGet(Name = "GetStds")]

        public IEnumerable<Student> Get()
        {
           


            return StudentDB.getAll().ToArray();
        }
        [HttpPost]
        public ActionResult SaveStud([FromBody] Student student)
        {
            if (student == null)
            {
                return BadRequest("Student Is Null");
            }
            StudentDB.add(student);
            return Ok("Student Added!!");
        }
        [HttpGet("{id}")]
        public IActionResult GetStud(int id)
        {
            var student=StudentDB.GetStudent(id);
            if (student == null)
            {
                return NotFound("Student Not Found With Given Id");
            }
            
            return Ok(student);
        }
        [HttpDelete("{id}")]
        public IActionResult DelStud(int id)
        {
            var student = StudentDB.GetStudent(id);
            if (student == null)
            {
                return NotFound("Student Not Found With Given Id");
            }
            else
                StudentDB.DeleteStudent(id);

                return Ok("Student Deleted");
        }
        [HttpPut("{id}")]
        public IActionResult PutStud(int id, [FromBody]string name)
        {
            var student = StudentDB.GetStudent(id);
            if (student == null)
            {
                return NotFound("Student Not Found With Given Id");
            }
            else
                StudentDB.UpdateStudent(id,name);

            return Ok("Student Updated");
        }
    }
}
