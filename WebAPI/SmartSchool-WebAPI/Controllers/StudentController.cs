using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SmartSchool_WebAPI.Models;
using SmartSchool_WebAPI.Repositories;
using System;
using System.Threading.Tasks;

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
        [Route("v1/student")]
        public async Task<IActionResult> Get() 
        {
            try
            {
                // para retornar apenas os alunos na nossa consulta, altere o parâmetro para false
                var result = await _repository.GetAllStudentsAsync(true);
                
                if(result == null) return NotFound("Não foi encontrado nenhum aluno em nosso sistema de banco de dados");

                return Ok(result);
            }
            catch (Exception)
            {
                // trabalhando diretamente com http
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Get Method: Database failed");
            }
        }
        
        [HttpGet]
        [Route("v1/student/{id:int}")]
        public async Task<IActionResult> Get(int id) 
        {
            try
            {
                var result = await _repository.GetStudentAsyncById(id, true);

                if(result == null) return NotFound("Não foi encontrado nenhum aluno em nosso sistema com o id informado: " + id);

                return Ok(result);
            }
            catch (Exception)
            {
                // trabalhando diretamente com http
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Get(id) Method: Database failed");
            }
        }

                
        [HttpGet]
        [Route("v1/student/subject/{id:int}")]
        public async Task<IActionResult> GetSubject(int id) 
        {
            try
            {
                var result = await _repository.GetStudentsAsyncBySubjectId(id, true);
                return Ok(result);
            }
            catch (Exception)
            {
                // trabalhando diretamente com http
                return this.StatusCode(StatusCodes.Status500InternalServerError, "GetSubject Method: Database failed");
            }
        }

        [HttpPost]
        [Route("v1/student/register")]
        public async Task<IActionResult> Post([FromBody] Student model)
        {
            try
            {
                _repository.Add(model);
                
                if(await _repository.SaveChangesAsync()) return Ok(model);
            }
            catch (Exception)
            {
                // trabalhando diretamente com http
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Post Method: Database failed");
            }

            return BadRequest("Um erro ocorreu. Não foi possível adicionar o aluno em nosso sistema.");
        }

        [HttpPut]
        [Route("v1/student/update/{id:int}")]
        public async Task<IActionResult> Put(int id, Student model) 
        {
            try
            {
                var student = await _repository.GetStudentAsyncById(id, false);

                if(student == null) return NotFound($"Não foi encontrado nenhum aluno com o id " + id);

                _repository.Update(model);
                
                if(await _repository.SaveChangesAsync()) return Ok(model);
            }
            catch (System.Exception)
            {
                // trabalhando diretamente com http
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Put Method: Database failed");
            }

            return BadRequest("Um erro ocorreu. Não foi possível atualizar o aluno.");
        }

        [HttpDelete]
        [Route("v1/[controller]/delete/{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var student = await _repository.GetStudentAsyncById(id, false);
                if(student == null) return NotFound($"Não foi encontrado nenhum aluno com o id " + id);

                _repository.Delete(student);

                if(await _repository.SaveChangesAsync())
                    return Ok("O aluno foi excluído com sucesso.");
            }
            catch (System.Exception)
            {
                // trabalhando diretamente com http
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Delete Method: Database failed");
            }

            return BadRequest("Um erro ocorreu. Não foi possível excluir o aluno.");
        }
    }
}