using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SmartSchool_WebAPI.Models;
using SmartSchool_WebAPI.Repositories;
using System.Threading.Tasks;

namespace SmartSchool_WebAPI.Controllers
{
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly IRepository _repository;

        public TeacherController(IRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Route("v1/teacher")]
        public async Task<IActionResult> Get() 
        {
            try
            {
                var result = await _repository.GetAllTeachersAsync(true);

                return Ok(result);
            }
            catch (System.Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Get Method: Database failed");
            }
        }

        [HttpGet]
        [Route("v1/teacher/{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var teacher = await _repository.GetTeacherAsyncById(id, true);

                return Ok(teacher);
            }
            catch (System.Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Get(id) Method: Database failed");
            }
        }

        [HttpGet]
        [Route("v1/teacher/student/{id:int}")]
        public async Task<IActionResult> GetStudent(int id)
        {
            try
            {
                var result = await _repository.GetTeachersAsyncByStudentId(id, false);
                return Ok(result);
            }
            catch (System.Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "GetStudent Method: Database failed");
            }
        }

        [HttpPost]
        [Route("v1/teacher/register")]
        public async Task<IActionResult> Post(Teacher model)
        {
            try
            {
                _repository.Add(model);

                if(await _repository.SaveChangesAsync()) return Ok(model);
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Post Method: Database failed");
            }

            return BadRequest("Um erro ocorreu. Não foi possível adicionar o professor em nosso sistema.");
        }

        [HttpPut]
        [Route("v1/teacher/update/{id:int}")]
        public async Task<IActionResult> Put(int id, Teacher model)
        {
            try
            {
                var teacher = await _repository.GetTeacherAsyncById(id, false);

                if(teacher == null) return NotFound("Não foi encontrado nenhum professor em nosso sistema com o id informado: " + id);

                _repository.Update(model);

                if(await _repository.SaveChangesAsync()) return Ok(model);
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Put Method: Databse failed");
            }

            return BadRequest("Um erro ocorreu. Não foi possível atualizar o professor");
        }

        [HttpDelete]
        [Route("v1/teacher/delete/{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var teacher = await _repository.GetTeacherAsyncById(id, false);

                if(teacher == null) return NotFound("Não foi encontrado nenhum professor em nosso sistema com o id informado: " + id);

                _repository.Delete(teacher);

                if(await _repository.SaveChangesAsync()) return Ok("O professor foi excluído com sucesso.");
            }
            catch (System.Exception)
            {
                // trabalhando diretamente com http
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Delete Method: Database failed");
            }

            return BadRequest("Um erro ocorreu. Não foi possível excluir o professor.");
        }
    }
}