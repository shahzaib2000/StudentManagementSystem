using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StudentManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        public ActionResult GetStudent([FromQuery] int count)
        {
            string[] names = { "Shahzaib", "Ali", "Samreen" };
            if (!names.Any())
                return NotFound();
            return Ok(names.Take(count));
            //return Ok(names);
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteStudent(string id)
        {
            bool badresponse = false;

            if (badresponse)

                return BadRequest();

            return NoContent();
        }

    }
}
