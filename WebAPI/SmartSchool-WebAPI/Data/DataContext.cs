using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SmartSchool_WebAPI.Models;

namespace SmartSchool_WebAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) { }    
            
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<StudentSubject> StudentsSubjects { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<StudentSubject>()
                .HasKey(AD => new { AD.StudentId, AD.SubjectId });

            builder.Entity<Teacher>()
                .HasData(new List<Teacher>(){
                    new Teacher(1, "Girafales", "Gonzales"),
                    new Teacher(2, "Pardal", "Voador"),
                    new Teacher(3, "Raimundo", "Nonato"),
                    new Teacher(4, "Alexsandro", "Andrade"),
                    new Teacher(5, "Gladys", "Moreno"),
                });
            
            builder.Entity<Student>()
                .HasData(new List<Student>(){
                    new Student(1, "Clark", "Kent", "455.278.840-00", "11933225555", "clarkkent@yahoo.com"),
                    new Student(2, "Leon", "Kennedy", "860.187.460-69", "21999880033", "leonskennedy@hotmail.com"),
                    new Student(3, "Bruce", "Wayne", "730.648.440-08", "47933442121", "brucewayne@gmail.com"),
                    new Student(4, "Tony", "Stark", "704.332.760-10", "1397674944", "stark@yahoo.com"),
                    new Student(5, "Bruce", "Benner", "819.391.990-42", "45998877664", "hulk@hotmail.com"),
                    new Student(6, "Scooby", "Doo", "268.910.380-06", "11945492790", "scooby@yahoo.com"),
                    new Student(7, "Charlie", "Brown", "236.780.220-30", "34977553040", "charliebrown@hotmail.com")
                });
            
            builder.Entity<Subject>()
                .HasData(new List<Subject>{
                    new Subject(1, "Aritmética", "1"),
                    new Subject(2, "Física", "2"),
                    new Subject(3, "Português", "3"),
                    new Subject(4, "Informática", "4"),
                    new Subject(5, "Culinária", "5")
                });

            builder.Entity<StudentSubject>()
                .HasData(new List<StudentSubject>() {
                    new StudentSubject() {StudentId = 1, SubjectId = 2 },
                    new StudentSubject() {StudentId = 1, SubjectId = 4 },
                    new StudentSubject() {StudentId = 1, SubjectId = 5 },
                    new StudentSubject() {StudentId = 2, SubjectId = 1 },
                    new StudentSubject() {StudentId = 2, SubjectId = 2 },
                    new StudentSubject() {StudentId = 2, SubjectId = 5 },
                    new StudentSubject() {StudentId = 3, SubjectId = 1 },
                    new StudentSubject() {StudentId = 3, SubjectId = 2 },
                    new StudentSubject() {StudentId = 3, SubjectId = 3 },
                    new StudentSubject() {StudentId = 4, SubjectId = 1 },
                    new StudentSubject() {StudentId = 4, SubjectId = 4 },
                    new StudentSubject() {StudentId = 4, SubjectId = 5 },
                    new StudentSubject() {StudentId = 5, SubjectId = 4 },
                    new StudentSubject() {StudentId = 5, SubjectId = 5 },
                    new StudentSubject() {StudentId = 6, SubjectId = 1 },
                    new StudentSubject() {StudentId = 6, SubjectId = 2 },
                    new StudentSubject() {StudentId = 6, SubjectId = 3 },
                    new StudentSubject() {StudentId = 6, SubjectId = 4 },
                    new StudentSubject() {StudentId = 7, SubjectId = 1 },
                    new StudentSubject() {StudentId = 7, SubjectId = 2 },
                    new StudentSubject() {StudentId = 7, SubjectId = 3 },
                    new StudentSubject() {StudentId = 7, SubjectId = 4 },
                    new StudentSubject() {StudentId = 7, SubjectId = 5 }
                });
        }
    }
}