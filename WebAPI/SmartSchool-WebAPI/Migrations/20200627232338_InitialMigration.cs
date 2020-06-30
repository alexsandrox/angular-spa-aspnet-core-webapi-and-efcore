using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartSchool_WebAPI.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Document = table.Column<string>(nullable: true),
                    Phonenumber = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    TeacherId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subjects_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentsSubjects",
                columns: table => new
                {
                    StudentId = table.Column<int>(nullable: false),
                    SubjectId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentsSubjects", x => new { x.StudentId, x.SubjectId });
                    table.ForeignKey(
                        name: "FK_StudentsSubjects_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentsSubjects_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "CreatedAt", "Document", "Email", "FirstName", "LastName", "Phonenumber", "UpdatedAt" },
                values: new object[] { 1, new DateTime(2020, 6, 27, 20, 23, 37, 969, DateTimeKind.Local).AddTicks(2630), "455.278.840-00", "clarkkent@yahoo.com", "Clark", "Kent", "11933225555", new DateTime(2020, 6, 27, 20, 23, 37, 973, DateTimeKind.Local).AddTicks(2292) });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "CreatedAt", "Document", "Email", "FirstName", "LastName", "Phonenumber", "UpdatedAt" },
                values: new object[] { 2, new DateTime(2020, 6, 27, 20, 23, 37, 973, DateTimeKind.Local).AddTicks(2931), "860.187.460-69", "leonskennedy@hotmail.com", "Leon", "Kennedy", "21999880033", new DateTime(2020, 6, 27, 20, 23, 37, 973, DateTimeKind.Local).AddTicks(2955) });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "CreatedAt", "Document", "Email", "FirstName", "LastName", "Phonenumber", "UpdatedAt" },
                values: new object[] { 3, new DateTime(2020, 6, 27, 20, 23, 37, 973, DateTimeKind.Local).AddTicks(2974), "730.648.440-08", "brucewayne@gmail.com", "Bruce", "Wayne", "47933442121", new DateTime(2020, 6, 27, 20, 23, 37, 973, DateTimeKind.Local).AddTicks(2977) });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "CreatedAt", "Document", "Email", "FirstName", "LastName", "Phonenumber", "UpdatedAt" },
                values: new object[] { 4, new DateTime(2020, 6, 27, 20, 23, 37, 973, DateTimeKind.Local).AddTicks(2981), "704.332.760-10", "stark@yahoo.com", "Tony", "Stark", "1397674944", new DateTime(2020, 6, 27, 20, 23, 37, 973, DateTimeKind.Local).AddTicks(2983) });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "CreatedAt", "Document", "Email", "FirstName", "LastName", "Phonenumber", "UpdatedAt" },
                values: new object[] { 5, new DateTime(2020, 6, 27, 20, 23, 37, 973, DateTimeKind.Local).AddTicks(2986), "819.391.990-42", "hulk@hotmail.com", "Bruce", "Benner", "45998877664", new DateTime(2020, 6, 27, 20, 23, 37, 973, DateTimeKind.Local).AddTicks(2988) });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "CreatedAt", "Document", "Email", "FirstName", "LastName", "Phonenumber", "UpdatedAt" },
                values: new object[] { 6, new DateTime(2020, 6, 27, 20, 23, 37, 973, DateTimeKind.Local).AddTicks(2995), "268.910.380-06", "scooby@yahoo.com", "Scooby", "Doo", "11945492790", new DateTime(2020, 6, 27, 20, 23, 37, 973, DateTimeKind.Local).AddTicks(2997) });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "CreatedAt", "Document", "Email", "FirstName", "LastName", "Phonenumber", "UpdatedAt" },
                values: new object[] { 7, new DateTime(2020, 6, 27, 20, 23, 37, 973, DateTimeKind.Local).AddTicks(3000), "236.780.220-30", "charliebrown@hotmail.com", "Charlie", "Brown", "34977553040", new DateTime(2020, 6, 27, 20, 23, 37, 973, DateTimeKind.Local).AddTicks(3002) });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { 1, "Girafales", "Gonzales" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { 2, "Pardal", "Voador" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { 3, "Raimundo", "Nonato" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { 4, "Alexsandro", "Andrade" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { 5, "Gladys", "Moreno" });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "Name", "TeacherId" },
                values: new object[] { 1, "Aritmética", 1 });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "Name", "TeacherId" },
                values: new object[] { 2, "Física", 2 });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "Name", "TeacherId" },
                values: new object[] { 3, "Português", 3 });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "Name", "TeacherId" },
                values: new object[] { 4, "Informática", 4 });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "Name", "TeacherId" },
                values: new object[] { 5, "Culinária", 5 });

            migrationBuilder.InsertData(
                table: "StudentsSubjects",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 2, 1 });

            migrationBuilder.InsertData(
                table: "StudentsSubjects",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 4, 5 });

            migrationBuilder.InsertData(
                table: "StudentsSubjects",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 2, 5 });

            migrationBuilder.InsertData(
                table: "StudentsSubjects",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 1, 5 });

            migrationBuilder.InsertData(
                table: "StudentsSubjects",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 7, 4 });

            migrationBuilder.InsertData(
                table: "StudentsSubjects",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 6, 4 });

            migrationBuilder.InsertData(
                table: "StudentsSubjects",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 5, 4 });

            migrationBuilder.InsertData(
                table: "StudentsSubjects",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 4, 4 });

            migrationBuilder.InsertData(
                table: "StudentsSubjects",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 1, 4 });

            migrationBuilder.InsertData(
                table: "StudentsSubjects",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 7, 3 });

            migrationBuilder.InsertData(
                table: "StudentsSubjects",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 5, 5 });

            migrationBuilder.InsertData(
                table: "StudentsSubjects",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 6, 3 });

            migrationBuilder.InsertData(
                table: "StudentsSubjects",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 7, 2 });

            migrationBuilder.InsertData(
                table: "StudentsSubjects",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 6, 2 });

            migrationBuilder.InsertData(
                table: "StudentsSubjects",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 3, 2 });

            migrationBuilder.InsertData(
                table: "StudentsSubjects",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 2, 2 });

            migrationBuilder.InsertData(
                table: "StudentsSubjects",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 1, 2 });

            migrationBuilder.InsertData(
                table: "StudentsSubjects",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 7, 1 });

            migrationBuilder.InsertData(
                table: "StudentsSubjects",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 6, 1 });

            migrationBuilder.InsertData(
                table: "StudentsSubjects",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 4, 1 });

            migrationBuilder.InsertData(
                table: "StudentsSubjects",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 3, 1 });

            migrationBuilder.InsertData(
                table: "StudentsSubjects",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 3, 3 });

            migrationBuilder.InsertData(
                table: "StudentsSubjects",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { 7, 5 });

            migrationBuilder.CreateIndex(
                name: "IX_StudentsSubjects_SubjectId",
                table: "StudentsSubjects",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_TeacherId",
                table: "Subjects",
                column: "TeacherId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentsSubjects");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.DropTable(
                name: "Teachers");
        }
    }
}
