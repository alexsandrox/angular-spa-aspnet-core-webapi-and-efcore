using Microsoft.AspNetCore.Mvc;

namespace SmartSchool_WebAPI.Controllers
{
    [ApiController]
    public class TeacherController : ControllerBase
    {
        [HttpGet]
        [Route("v1/[controller]")]
        public IActionResult Get() 
        {
            return Ok("Teacher Page");
        }
    }
}