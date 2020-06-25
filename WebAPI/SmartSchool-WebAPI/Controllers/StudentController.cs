using Microsoft.AspNetCore.Mvc;

namespace SmartSchool_WebAPI.Controllers
{
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        [Route("v1/[controller]")]
        public IActionResult Get() 
        {
            return Ok("Student Page");
        }
    }
}