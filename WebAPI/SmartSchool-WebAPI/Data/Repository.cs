using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SmartSchool_WebAPI.Models;

namespace SmartSchool_WebAPI.Data
{
    public class Repository : IRepository
    {
        private readonly DataContext _context;

        public Repository(DataContext context)
        {
            _context = context;
        }

        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }

        public async Task<Student[]> GetAllStudentsAsync(bool includeSubject = false)
        {
            IQueryable<Student> query = _context.Students;

            if (includeSubject)
            {
                query = query.Include(pe => pe.StudentsSubjects)
                             .ThenInclude(ad => ad.Subject)
                             .ThenInclude(d => d.Teacher);
            }

            query = query.AsNoTracking()
                         .OrderBy(c => c.Id);

            return await query.ToArrayAsync();
        }

        public async Task<Student> GetStudentAsyncById(string studentId, bool includeSubject)
        {
            IQueryable<Student> query = _context.Students;

            if (includeSubject)
            {
                query = query.Include(a => a.StudentsSubjects)
                             .ThenInclude(ad => ad.Subject)
                             .ThenInclude(d => d.Teacher);
            }

            query = query.AsNoTracking()
                         .OrderBy(student => student.Id)
                         .Where(student => student.Id == studentId);

            return await query.FirstOrDefaultAsync();
        }

        public async Task<Student[]> GetStudentsAsyncBySubjectId(string subjectId, bool includeSubject)
        {
            IQueryable<Student> query = _context.Students;

            if (includeSubject)
            {
                query = query.Include(p => p.StudentsSubjects)
                             .ThenInclude(ad => ad.Subject)                             
                             .ThenInclude(d => d.Teacher);
            }

            query = query.AsNoTracking()
                         .OrderBy(student => student.Id)
                         .Where(student => student.StudentsSubjects.Any(ad => ad.SubjectId == subjectId));

            return await query.ToArrayAsync();
        }

        public async Task<Teacher[]> GetAllTeachersAsync(bool includeStudent)
        {
            IQueryable<Teacher> query = _context.Teachers;

            if (includeStudent)
            {
                query = query.Include(c => c.Subjects);
            }

            query = query.AsNoTracking()
                         .OrderBy(teacher => teacher.Id);

            return await query.ToArrayAsync();
        }

        public async Task<Teacher[]> GetTeachersAsyncByStudentId(string studentId, bool includeSubject)
        {
            IQueryable<Teacher> query = _context.Teachers;

            if (includeSubject)
            {
                query = query.Include(p => p.Subjects);
            }

            query = query.AsNoTracking()
                         .OrderBy(student => student.Id)
                         .Where(student => student.Subjects.Any(d => 
                            d.StudentsSubjects.Any(ad => ad.StudentId == studentId)));

            return await query.ToArrayAsync();
        }

        public async Task<Teacher> GetTeacherAsyncById(string teacherId, bool includeStudent)
        {
            IQueryable<Teacher> query = _context.Teachers;

            if (includeStudent)
            {
                query = query.Include(pe => pe.Subjects);
            }

            query = query.AsNoTracking()
                         .OrderBy(teacher => teacher.Id)
                         .Where(teacher => teacher.Id == teacherId);

            return await query.FirstOrDefaultAsync();
        }
    }
}