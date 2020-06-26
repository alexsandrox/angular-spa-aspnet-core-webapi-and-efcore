using System.Threading.Tasks;
using SmartSchool_WebAPI.Models;

namespace SmartSchool_WebAPI.Data
{
    public interface IRepository
    {
        //GERAL
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveChangesAsync();

        //ALUNO
        Task<Student[]> GetAllStudentsAsync(bool includeTeacher);        
        Task<Student> GetStudentAsyncById(string studentId, bool includeTeacher);
        Task<Student[]> GetStudentsAsyncBySubjectId(string subjectId, bool includeSubject);
        
        //PROFESSOR
        Task<Teacher[]> GetAllTeachersAsync(bool includeStudent);
        Task<Teacher> GetTeacherAsyncById(string teacherId, bool includeStudent);
        Task<Teacher[]> GetTeachersAsyncByStudentId(string studentId, bool includeSubject);
    }
}