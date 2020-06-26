using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SmartSchool_WebAPI.Data;

namespace SmartSchool_WebAPI.Controllers
{
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IRepository _repository;

        public StudentController(IRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Route("v1/students")]
        public async Task<IActionResult> Get() 
        {
            try
            {
                // para retornar apenas os alunos na nossa consulta, altere o parâmetro para false
                var result = await _repository.GetAllStudentsAsync(true);
                return Ok(result);
            }
            catch (Exception)
            {
                // trabalhando diretamente com http
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database failed");
            }
        }
        
        [HttpGet]
        [Route("v1/students/{id}")]
        public async Task<IActionResult> Get(string studentId) 
        {
            try
            {
                var result = await _repository.GetStudentAsyncById(studentId, true);
                return Ok(result);
            }
            catch (Exception)
            {
                // trabalhando diretamente com http
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database failed");
            }
        }

                
        [HttpGet]
        [Route("v1/students/subject/{id}")]
        public async Task<IActionResult> GetSubject(string subjectId) 
        {
            try
            {
                var result = await _repository.GetStudentsAsyncBySubjectId(subjectId, true);
                return Ok(result);
            }
            catch (Exception)
            {
                // trabalhando diretamente com http
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database failed");
            }
        }
    }
}