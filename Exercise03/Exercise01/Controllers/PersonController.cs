using Exercise01.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Exercise01.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpPost("create-person")]
        public IActionResult CreatePerson([FromBody] string name)
        {
            var result = _personService.CreatePerson(name);
            return Ok(result);
        }

        [HttpPost("create-student")]
        public IActionResult CreateStudent([FromBody] string name, [FromQuery] int age)
        {
            var result = _personService.CreateStudent(name, age);
            return Ok(result);
        }

        [HttpPost("create-teacher")]
        public IActionResult CreateTeacher([FromBody] string name, [FromQuery] int age)
        {
            var result = _personService.CreateTeacher(name, age);
            return Ok(result);
        }
    }
}