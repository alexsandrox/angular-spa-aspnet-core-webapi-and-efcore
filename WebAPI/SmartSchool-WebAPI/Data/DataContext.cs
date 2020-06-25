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
                    new Teacher("1", "Girafales", "Gonzales", "Aritmética"),
                    new Teacher("2", "Pardal", "Voador", "Física"),
                    new Teacher("3", "Raimundo", "Nonato", "Português"),
                    new Teacher("4", "Alexsandro", "Andrade", "Informática"),
                    new Teacher("5", "Gladys", "Moreno", "Culinária"),
                });
            
            builder.Entity<Subject>()
                .HasData(new List<Subject>{
                    new Subject("1", "Aritmética", "1"),
                    new Subject("2", "Física", "2"),
                    new Subject("3", "Português", "3"),
                    new Subject("4", "Informática", "4"),
                    new Subject("5", "Culinária", "5")
                });
            
            builder.Entity<Student>()
                .HasData(new List<Student>(){
                    new Student("72143DA8-799B-4962-A8AE-EF926FE299C5", "Clark", "Kent", "455.278.840-00", "11933225555", "clarkkent@yahoo.com"),
                    new Student("0530841D-AA4A-4469-9F6D-8DD39C75BD51", "Leon", "Kennedy", "860.187.460-69", "21999880033", "leonskennedy@hotmail.com"),
                    new Student("22E5557C-A61E-476F-A996-09FAB7DFF0AD", "Bruce", "Wayne", "730.648.440-08", "47933442121", "brucewayne@gmail.com"),
                    new Student("B36F6B51-3F95-4B3E-95C0-19099A78E825", "Tony", "Stark", "704.332.760-10", "1397674944", "stark@yahoo.com"),
                    new Student("B76B460B-3F15-4D71-9B31-1C0EFA20D0DE", "Bruce", "Benner", "819.391.990-42", "45998877664", "hulk@hotmail.com"),
                    new Student("E8E0015B-1EB1-444C-AF78-C0DCDE508109", "Scooby", "Doo", "268.910.380-06", "11945492790", "scooby@yahoo.com"),
                    new Student("B1FE8B94-1773-443A-9E04-52753571F3D3", "Charlie", "Brown", "236.780.220-30", "34977553040", "charliebrown@hotmail.com")
                });

            builder.Entity<StudentSubject>()
                .HasData(new List<StudentSubject>() {
                    new StudentSubject() {StudentId = "72143DA8-799B-4962-A8AE-EF926FE299C5", SubjectId = "2" },
                    new StudentSubject() {StudentId = "72143DA8-799B-4962-A8AE-EF926FE299C5", SubjectId = "4" },
                    new StudentSubject() {StudentId = "72143DA8-799B-4962-A8AE-EF926FE299C5", SubjectId = "5" },
                    new StudentSubject() {StudentId = "0530841D-AA4A-4469-9F6D-8DD39C75BD51", SubjectId = "1" },
                    new StudentSubject() {StudentId = "0530841D-AA4A-4469-9F6D-8DD39C75BD51", SubjectId = "2" },
                    new StudentSubject() {StudentId = "0530841D-AA4A-4469-9F6D-8DD39C75BD51", SubjectId = "5" },
                    new StudentSubject() {StudentId = "22E5557C-A61E-476F-A996-09FAB7DFF0AD", SubjectId = "1" },
                    new StudentSubject() {StudentId = "22E5557C-A61E-476F-A996-09FAB7DFF0AD", SubjectId = "2" },
                    new StudentSubject() {StudentId = "22E5557C-A61E-476F-A996-09FAB7DFF0AD", SubjectId = "3" },
                    new StudentSubject() {StudentId = "B36F6B51-3F95-4B3E-95C0-19099A78E825", SubjectId = "1" },
                    new StudentSubject() {StudentId = "B36F6B51-3F95-4B3E-95C0-19099A78E825", SubjectId = "4" },
                    new StudentSubject() {StudentId = "B36F6B51-3F95-4B3E-95C0-19099A78E825", SubjectId = "5" },
                    new StudentSubject() {StudentId = "B76B460B-3F15-4D71-9B31-1C0EFA20D0DE", SubjectId = "4" },
                    new StudentSubject() {StudentId = "B76B460B-3F15-4D71-9B31-1C0EFA20D0DE", SubjectId = "5" },
                    new StudentSubject() {StudentId = "B76B460B-3F15-4D71-9B31-1C0EFA20D0DE", SubjectId = "1" },
                    new StudentSubject() {StudentId = "E8E0015B-1EB1-444C-AF78-C0DCDE508109", SubjectId = "2" },
                    new StudentSubject() {StudentId = "E8E0015B-1EB1-444C-AF78-C0DCDE508109", SubjectId = "3" },
                    new StudentSubject() {StudentId = "E8E0015B-1EB1-444C-AF78-C0DCDE508109", SubjectId = "4" },
                    new StudentSubject() {StudentId = "B1FE8B94-1773-443A-9E04-52753571F3D3", SubjectId = "1" },
                    new StudentSubject() {StudentId = "B1FE8B94-1773-443A-9E04-52753571F3D3", SubjectId = "3" },
                    new StudentSubject() {StudentId = "B1FE8B94-1773-443A-9E04-52753571F3D3", SubjectId = "4" }
                });
        }
    }
}