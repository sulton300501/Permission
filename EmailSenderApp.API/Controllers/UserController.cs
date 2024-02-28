using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using EmailSenderApp.API.Atributes;
using EmailSenderApp.Domain.Entities.Models.Enums;

namespace EmailSenderApp.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize]
    public class UserController : ControllerBase
    {
        List<string> users = new List<string>()
        {
            "Student 1","Student 2","Student 3","Student 4"
        };

        List<string> teacher = new List<string>()
        {
            "Teacher 1","Teacher 2","Teacher 3","Teacher 4"
        };
        [HttpGet]
        [IdentifyFilter(Permission.GetAllStudents)]
        
        public IActionResult GetStudents()
        {
            return Ok(users);
        }

        [HttpGet]
        [IdentifyFilter(Permission.GetAllTeachers)]
        public IActionResult GetTeachers()
        {
            return Ok(teacher);
        }

        [HttpPost]
        [IdentifyFilter(Permission.CreateStudent)]
        public IActionResult CreateStudent()
        {
            return Ok("Create bo'ldi");
        }

        [HttpDelete]
        [IdentifyFilter(Permission.DeleteStudent)]
        public IActionResult DeleteStudent()
        {
            return Ok("Delete bo'ldi");
        }




    }
}
